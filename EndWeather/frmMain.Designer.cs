namespace EndWeather
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.pressLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WeatherPicture = new System.Windows.Forms.PictureBox();
            this.currentLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.Trend = new System.Windows.Forms.TabPage();
            this.trendChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Settings = new System.Windows.Forms.TabPage();
            this.intervalTime = new System.Windows.Forms.TextBox();
            this.locationCheck = new System.Windows.Forms.TextBox();
            this.updateFormData = new System.Windows.Forms.Button();
            this.degreesFahrenheit = new System.Windows.Forms.RadioButton();
            this.degreesCelsius = new System.Windows.Forms.RadioButton();
            this.labelInterval = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.weatherStation = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPicture)).BeginInit();
            this.Trend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendChart)).BeginInit();
            this.Settings.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.Home);
            this.tabControl.Controls.Add(this.Trend);
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(20, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(258, 218);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 4;
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.Controls.Add(this.pressLabel);
            this.Home.Controls.Add(this.windLabel);
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.WeatherPicture);
            this.Home.Controls.Add(this.currentLabel);
            this.Home.Controls.Add(this.humidityLabel);
            this.Home.Controls.Add(this.temperatureLabel);
            this.Home.Controls.Add(this.locationLabel);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(250, 189);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // pressLabel
            // 
            this.pressLabel.AutoSize = true;
            this.pressLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressLabel.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressLabel.ForeColor = System.Drawing.Color.White;
            this.pressLabel.Location = new System.Drawing.Point(8, 148);
            this.pressLabel.Name = "pressLabel";
            this.pressLabel.Size = new System.Drawing.Size(62, 19);
            this.pressLabel.TabIndex = 11;
            this.pressLabel.Text = "pressLabel";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(9, 169);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(59, 19);
            this.windLabel.TabIndex = 10;
            this.windLabel.Text = "windLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brandon Grotesque Thin", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // WeatherPicture
            // 
            this.WeatherPicture.BackColor = System.Drawing.Color.Transparent;
            this.WeatherPicture.Location = new System.Drawing.Point(198, 18);
            this.WeatherPicture.Name = "WeatherPicture";
            this.WeatherPicture.Size = new System.Drawing.Size(39, 41);
            this.WeatherPicture.TabIndex = 8;
            this.WeatherPicture.TabStop = false;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Brandon Grotesque Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(11, 58);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(125, 30);
            this.currentLabel.TabIndex = 7;
            this.currentLabel.Text = "currentLabel";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(8, 128);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(80, 19);
            this.humidityLabel.TabIndex = 6;
            this.humidityLabel.Text = "humidityLabel";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.temperatureLabel.Font = new System.Drawing.Font("Brandon Grotesque Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.ForeColor = System.Drawing.Color.White;
            this.temperatureLabel.Location = new System.Drawing.Point(148, 82);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(181, 34);
            this.temperatureLabel.TabIndex = 5;
            this.temperatureLabel.Text = "temperatureLabel";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Font = new System.Drawing.Font("Brandon Grotesque Regular", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(3, 18);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(105, 27);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "locationLabel";
            // 
            // Trend
            // 
            this.Trend.Controls.Add(this.trendChart);
            this.Trend.Location = new System.Drawing.Point(4, 25);
            this.Trend.Name = "Trend";
            this.Trend.Padding = new System.Windows.Forms.Padding(3);
            this.Trend.Size = new System.Drawing.Size(250, 189);
            this.Trend.TabIndex = 1;
            this.Trend.Text = "Graph";
            this.Trend.UseVisualStyleBackColor = true;
            // 
            // trendChart
            // 
            this.trendChart.BackImage = "C:\\Users\\Carla\\Downloads\\Moonlit Asteroid.jpg";
            this.trendChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.trendChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.trendChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.trendChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.trendChart.Legends.Add(legend2);
            this.trendChart.Location = new System.Drawing.Point(-9, 6);
            this.trendChart.Name = "trendChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Maroon;
            series2.CustomProperties = "LabelStyle=Bottom";
            series2.Font = new System.Drawing.Font("Brandon Grotesque Thin", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "5 Days";
            this.trendChart.Series.Add(series2);
            this.trendChart.Size = new System.Drawing.Size(264, 186);
            this.trendChart.TabIndex = 0;
            this.trendChart.Text = "trendChart";
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.Controls.Add(this.intervalTime);
            this.Settings.Controls.Add(this.locationCheck);
            this.Settings.Controls.Add(this.updateFormData);
            this.Settings.Controls.Add(this.degreesFahrenheit);
            this.Settings.Controls.Add(this.degreesCelsius);
            this.Settings.Controls.Add(this.labelInterval);
            this.Settings.Controls.Add(this.cityLabel);
            this.Settings.Location = new System.Drawing.Point(4, 25);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(250, 189);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // intervalTime
            // 
            this.intervalTime.Location = new System.Drawing.Point(121, 67);
            this.intervalTime.Name = "intervalTime";
            this.intervalTime.Size = new System.Drawing.Size(100, 20);
            this.intervalTime.TabIndex = 7;
            this.intervalTime.Text = "5";
            // 
            // locationCheck
            // 
            this.locationCheck.Location = new System.Drawing.Point(121, 24);
            this.locationCheck.Name = "locationCheck";
            this.locationCheck.Size = new System.Drawing.Size(100, 20);
            this.locationCheck.TabIndex = 6;
            this.locationCheck.Text = "Amsterdam";
            // 
            // updateFormData
            // 
            this.updateFormData.Location = new System.Drawing.Point(92, 152);
            this.updateFormData.Name = "updateFormData";
            this.updateFormData.Size = new System.Drawing.Size(75, 23);
            this.updateFormData.TabIndex = 5;
            this.updateFormData.Text = "Update";
            this.updateFormData.UseVisualStyleBackColor = true;
            this.updateFormData.Click += new System.EventHandler(this.button1_Click);
            // 
            // degreesFahrenheit
            // 
            this.degreesFahrenheit.AutoSize = true;
            this.degreesFahrenheit.BackColor = System.Drawing.Color.Transparent;
            this.degreesFahrenheit.Font = new System.Drawing.Font("Brandon Grotesque Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesFahrenheit.ForeColor = System.Drawing.Color.White;
            this.degreesFahrenheit.Location = new System.Drawing.Point(145, 112);
            this.degreesFahrenheit.Name = "degreesFahrenheit";
            this.degreesFahrenheit.Size = new System.Drawing.Size(80, 23);
            this.degreesFahrenheit.TabIndex = 3;
            this.degreesFahrenheit.Text = "Fahrenheit\r\n";
            this.degreesFahrenheit.UseVisualStyleBackColor = false;
            // 
            // degreesCelsius
            // 
            this.degreesCelsius.AutoSize = true;
            this.degreesCelsius.BackColor = System.Drawing.Color.Transparent;
            this.degreesCelsius.Font = new System.Drawing.Font("Brandon Grotesque Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesCelsius.ForeColor = System.Drawing.Color.White;
            this.degreesCelsius.Location = new System.Drawing.Point(30, 112);
            this.degreesCelsius.Name = "degreesCelsius";
            this.degreesCelsius.Size = new System.Drawing.Size(62, 23);
            this.degreesCelsius.TabIndex = 2;
            this.degreesCelsius.Text = "Celsius";
            this.degreesCelsius.UseVisualStyleBackColor = false;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.BackColor = System.Drawing.Color.Transparent;
            this.labelInterval.Font = new System.Drawing.Font("Brandon Grotesque Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterval.ForeColor = System.Drawing.Color.White;
            this.labelInterval.Location = new System.Drawing.Point(7, 67);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(86, 19);
            this.labelInterval.TabIndex = 1;
            this.labelInterval.Text = "Refresh interval";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Brandon Grotesque Thin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(60, 27);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 19);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City";
            // 
            // weatherStation
            // 
            this.weatherStation.ContextMenuStrip = this.contextMenuStrip1;
            this.weatherStation.Icon = ((System.Drawing.Icon)(resources.GetObject("weatherStation.Icon")));
            this.weatherStation.Text = "weatherStation";
            this.weatherStation.Visible = true;
            this.weatherStation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.weatherStation_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentTempToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 114);
            this.contextMenuStrip1.Text = "System Tray ";
            // 
            // currentTempToolStripMenuItem
            // 
            this.currentTempToolStripMenuItem.Name = "currentTempToolStripMenuItem";
            this.currentTempToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.currentTempToolStripMenuItem.Text = "CurrentTemp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 60000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(258, 219);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What\'s the weather?";
            this.TopMost = true;
            this.tabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPicture)).EndInit();
            this.Trend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trendChart)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TabPage Trend;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Button updateFormData;
        private System.Windows.Forms.RadioButton degreesFahrenheit;
        private System.Windows.Forms.RadioButton degreesCelsius;
        private System.Windows.Forms.TextBox intervalTime;
        private System.Windows.Forms.TextBox locationCheck;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem currentTempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox WeatherPicture;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart trendChart;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label pressLabel;
        private System.Windows.Forms.NotifyIcon weatherStation;
    }
}

