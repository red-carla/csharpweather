using System;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace EndWeather
{
    public partial class frmMain : Form
    {
        private string city;
        private int interval = 60000;
        private string mode;
        private string measurement;
        private string temp;
        private double tempCelsius;
        private int time;
        private string units;
        private string URLString;
        private WeatherModel weather;

        public frmMain()
        {
            var t = new Thread(startSplash);
            t.Start();
            Thread.Sleep(1000);
            InitializeComponent();
            city = "Amsterdam";
            units = "&units=metric";
            URLString = @"http://api.openweathermap.org/data/2.5/weather?q=" + city +
                        "&appid=d26ac9920bb71bc7ebe78c5956ede339" + units + "&lang=en";
            mode = "°C";
            measurement = "km/h";
            
            loadInfo();
            t.Abort();
        }

        public void startSplash()
        {
            Application.Run(new frmSplash());
        }

        public void loadInfo()
        {
            var localDate = DateTime.Now;
            var culture = new CultureInfo("en-GB");
            var dateStamp = localDate.ToString(culture);
            var date = dateStamp.Substring(0, 10);
            var json = new WebClient().DownloadString(URLString);
            weather = JsonConvert.DeserializeObject<WeatherModel>(json);

            locationLabel.Text = weather.name;
            var place = weather.name;
            temperatureLabel.Text = weather.main.temp + mode;
            currentTempToolStripMenuItem.Text = weather.main.temp + mode;
            humidityLabel.Text = weather.main.humidity + "% humidity";
            windLabel.Text = weather.wind.speed + measurement;
            pressLabel.Text = weather.main.pressure + "Pa";
            foreach (var weatheritem in weather.weather)
            {
                currentLabel.Text = weatheritem.main;

                WeatherPicture.ImageLocation = "http://openweathermap.org/img/w/" + weatheritem.icon + ".png";
            }

            //date time app refresh
            label1.Text = DateTime.Now.ToString();
            temp = weather.main.temp;
            //new connection
            MySqlConnection connection;

            var connectionString =
                "datasource=127.0.0.1;port=3306;username=root;password=;database=weatherdb;SslMode=none";

            connection = new MySqlConnection(connectionString);

            connection.Open();

            var CheckString =
                "SELECT cityName, wDate FROM cityWeather WHERE cityName = '{0}' AND wDate = '{1}'";
            var CheckStringFormat = string.Format(CheckString, place, date);

            var checkcmd = new MySqlCommand(CheckStringFormat, connection);
            var i = checkcmd.ExecuteNonQuery();

            var SqlReader = checkcmd.ExecuteReader();
            //from f to c
            if (units.Equals("&units=imperial"))
            {
                tempCelsius = (double.Parse(temp.Replace(".", ",")) - 32) / 1.8;

                if (!SqlReader.HasRows)
                {
                    SqlReader.Close();
                    var sqlString =
                        "INSERT into cityWeather (cityName, cityTemp, wDate) VALUES ('{0}', '{1}', '{2}')";
                    var cmdString = string.Format(sqlString, place, tempCelsius.ToString(), date);
                    var command = new MySqlCommand(cmdString, connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    SqlReader.Close();
                }
            }
            //check if celsius
            else if (units.Equals("&units=metric"))
            {
                tempCelsius = double.Parse(temp.Replace(".", ","));

                if (!SqlReader.HasRows)
                {
                    SqlReader.Close();
                    var sqlString =
                        "INSERT into cityWeather (cityName, cityTemp, wDate) VALUES ('{0}', '{1}', '{2}')";
                    var cmdString = string.Format(sqlString, place, tempCelsius.ToString(), date);
                    var command = new MySqlCommand(cmdString, connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    SqlReader.Close();
                }
            }

            else
            {
                
                tempCelsius = double.Parse(temp.Replace(".", ",")) - 273;
                
                if (!SqlReader.HasRows)
                {
                    SqlReader.Close();
                    var sqlString =
                        "INSERT into cityWeather (cityName, cityTemp, wDate) VALUES ('{0}', '{1}', '{2}')";
                    var cmdString = string.Format(sqlString, place, tempCelsius.ToString(), date);
                    var command = new MySqlCommand(cmdString, connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    SqlReader.Close();
                }
            }

            //get data from db
            var ChartString = "SELECT cityTemp, wDate FROM cityWeather WHERE cityName = '{0}'";
            var ChartStringFormat = string.Format(ChartString, place);
            var ChartCmd = new MySqlCommand(ChartStringFormat, connection);
            var ChartReader = ChartCmd.ExecuteReader();

            if (units.Equals("&units=metric"))
            {
                foreach (var series in trendChart.Series) series.Points.Clear();

                while (ChartReader.Read())
                {
                    var celsius = double.Parse(ChartReader.GetString(0));

                    trendChart.Series["5 Days"].Points.AddXY(ChartReader.GetString(1),
                        celsius.ToString(CultureInfo.InvariantCulture));
                }
            }

            else if (units.Equals("&units=imperial"))
            {
                foreach (var series in trendChart.Series) series.Points.Clear();


                while (ChartReader.Read())
                {
                    var imp = float.Parse(ChartReader.GetString(0));
                    var imperial = imp * 1.8 + 32;
                    trendChart.Series["5 Days"].Points.AddXY(ChartReader.GetString(1), imperial);
                }
            }
            else
            {
                foreach (var series in trendChart.Series) series.Points.Clear();
            }


            connection.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            city = locationCheck.Text;
            interval = int.Parse(intervalTime.Text) * 60000;
            //check mode and city
            if (degreesCelsius.Checked && locationCheck.Text != "")
            {
                units = "&units=metric";
                URLString = @"http://api.openweathermap.org/data/2.5/weather?q=" + city +
                            "&appid=d26ac9920bb71bc7ebe78c5956ede339" + units + "&lang=nl";
                mode = "°C";
                measurement = "km/h";
                loadInfo();
            }
            //otherwise if fahrenheit
            else if (degreesFahrenheit.Checked && locationCheck.Text != "")
            {
                units = "&units=imperial";
                URLString = "http://api.openweathermap.org/data/2.5/weather?q=" + city +
                            "&appid=d26ac9920bb71bc7ebe78c5956ede339" + units + "&lang=nl";
                mode = "°F";
                measurement = "mph";
                loadInfo();
            }
            else
            {
                MessageBox.Show("Please add a place name.");
            }
        }

        //show about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutbox = new AboutBox1();
            aboutbox.Show();
        }

        // close
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //refresh
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadInfo();
        }

        // open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
        }

        //timer to refresh form
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (time > interval)
            {
                time += 1;
            }
            else
            {
                refreshTimer.Stop();
                refreshTimer.Interval = interval;
                loadInfo();
                time = 0;
                refreshTimer.Start();
            }
        }

        private void weatherStation_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}