-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 11, 2019 at 10:32 AM
-- Server version: 10.1.39-MariaDB
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vms`
--

-- --------------------------------------------------------

--
-- Table structure for table `delcom`
--

CREATE TABLE `delcom` (
  `compname` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `delcom`
--

INSERT INTO `delcom` (`compname`) VALUES
('PosLaju'),
('GDEX'),
('SkyNet'),
('DHL'),
('City-Link'),
('TA-Q-BIN'),
('FoodPanda'),
('DeliveryEat'),
('GrabFood'),
('Ninja Express');

-- --------------------------------------------------------

--
-- Table structure for table `preregister`
--

CREATE TABLE `preregister` (
  `id` varchar(16) NOT NULL,
  `name` varchar(50) NOT NULL,
  `ic` varchar(12) DEFAULT NULL,
  `passport` varchar(10) DEFAULT NULL,
  `contact` varchar(10) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `unit` varchar(20) NOT NULL,
  `host` varchar(20) NOT NULL,
  `vehicleno` varchar(10) DEFAULT NULL,
  `company` varchar(50) DEFAULT NULL,
  `purpose` varchar(100) NOT NULL,
  `precheckin` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `remark` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tenantunit`
--

CREATE TABLE `tenantunit` (
  `unitno` varchar(10) NOT NULL,
  `unitname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tenantunit`
--

INSERT INTO `tenantunit` (`unitno`, `unitname`) VALUES
('101', 'ADMIN ');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userid` int(4) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` varchar(255) NOT NULL,
  `company` varchar(50) NOT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userid`, `username`, `password`, `company`, `role`) VALUES
(1, 'admin', 'admin', '101', 'admin'),
(2, 'tenant1', 'tenant1', '101', 'tenant'),
(3, 'user1', 'user1', '101', 'security');

-- --------------------------------------------------------

--
-- Table structure for table `visitor`
--

CREATE TABLE `visitor` (
  `id` varchar(17) NOT NULL,
  `visitortype` varchar(10) NOT NULL,
  `name` varchar(50) NOT NULL,
  `ic` varchar(12) DEFAULT NULL,
  `passport` varchar(10) DEFAULT NULL,
  `contact` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `unit` varchar(20) NOT NULL,
  `host` varchar(20) NOT NULL,
  `company` varchar(30) DEFAULT NULL,
  `vehicleno` varchar(10) DEFAULT NULL,
  `badge` varchar(10) NOT NULL,
  `purpose` varchar(100) NOT NULL,
  `checkin` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `checkout` timestamp NULL DEFAULT '0000-00-00 00:00:00',
  `status` tinyint(1) NOT NULL DEFAULT '0',
  `forcecheckout` tinyint(1) NOT NULL DEFAULT '0',
  `forcereason` varchar(255) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `preregister`
--
ALTER TABLE `preregister`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tenantunit`
--
ALTER TABLE `tenantunit`
  ADD PRIMARY KEY (`unitno`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userid`);

--
-- Indexes for table `visitor`
--
ALTER TABLE `visitor`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userid` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
