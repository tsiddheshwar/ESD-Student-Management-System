-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 21, 2018 at 09:35 PM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `esdtraining`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Username` varchar(10) NOT NULL,
  `Password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Username`, `Password`) VALUES
('Admin', 'Admin123'),
('b', 'b'),
('c', 'c');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `Id` int(2) NOT NULL,
  `name` varchar(30) NOT NULL,
  `branch` varchar(50) NOT NULL,
  `year` int(5) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `mobile` bigint(12) NOT NULL,
  `Marks1` int(3) NOT NULL,
  `Marks2` int(3) NOT NULL,
  `project` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`Id`, `name`, `branch`, `year`, `gender`, `email`, `mobile`, `Marks1`, `Marks2`, `project`) VALUES
(1, 'Suyash', 'Computer ', 4, 'Male', 'jagdalesuyash7243@gmail.com', 7030143962, 75, 68, 80),
(2, 'Rahul Hasule', 'Computer', 4, 'Male', 'rahulhasule@gmail.com', 7038685984, 80, 76, 69);

-- --------------------------------------------------------

--
-- Table structure for table `trainer`
--

CREATE TABLE `trainer` (
  `name` varchar(30) NOT NULL,
  `uname` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `mobile` bigint(20) NOT NULL,
  `session` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `trainer`
--

INSERT INTO `trainer` (`name`, `uname`, `pass`, `email`, `mobile`, `session`) VALUES
('a', 'a', 'a', 'a', 9921349404, 0),
('b', 'b', 'b', 'b', 7038685984, 0),
('ABC', 'c', 'c', 'abc@gmail.com', 9921349704, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
