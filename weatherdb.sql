-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 17, 2019 at 10:45 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `weatherdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `cityweather`
--

CREATE TABLE `cityweather` (
  `wID` int(7) NOT NULL,
  `cityTemp` varchar(20) NOT NULL,
  `wDate` varchar(20) NOT NULL,
  `cityName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cityweather`
--

INSERT INTO `cityweather` (`wID`, `cityTemp`, `wDate`, `cityName`) VALUES
(1, '10', '12/01/2019', 'Amsterdam'),
(2, '-5', '12/01/2019', 'New York'),
(3, '0', '12/01/2019', 'London'),
(4, '30', '12/01/2019', 'Harare'),
(5, '5', '13/01/2019', 'Amsterdam'),
(6, '-3', '13/01/2019', 'New York'),
(7, '-4', '13/01/2019', 'London'),
(8, '23', '13/01/2019', 'Harare'),
(9, '2', '14/01/2019', 'Amsterdam'),
(10, '2', '14/01/2019', 'New York'),
(11, '-3', '14/01/2019', 'London'),
(12, '28', '14/01/2019', 'Harare'),
(13, '7', '15/01/2019', 'Amsterdam'),
(14, '-10', '15/01/2019', 'New York'),
(15, '0', '15/01/2019', 'London'),
(16, '25', '15/01/2019', 'Harare'),
(29, '6,35', '16/01/2019', 'Amsterdam'),
(30, '1,23', '16/01/2019', 'New York'),
(31, '18,62', '16/01/2019', 'Harare'),
(32, '5,01', '17/01/2019', 'Amsterdam');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cityweather`
--
ALTER TABLE `cityweather`
  ADD PRIMARY KEY (`wID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cityweather`
--
ALTER TABLE `cityweather`
  MODIFY `wID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
