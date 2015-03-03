-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 16, 2015 at 06:21 AM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hospital_system`
--
CREATE DATABASE IF NOT EXISTS `hospital_system` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `hospital_system`;

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE IF NOT EXISTS `bill` (
  `PatientID` int(11) NOT NULL AUTO_INCREMENT,
  `dateadmited` date NOT NULL,
  `datedis` date NOT NULL,
  `ward` varchar(50) NOT NULL,
  `room` varchar(50) NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`PatientID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`PatientID`, `dateadmited`, `datedis`, `ward`, `room`, `total`) VALUES
(1, '2015-01-01', '2015-01-15', 'Cardiology', '3', 8500);

-- --------------------------------------------------------

--
-- Table structure for table `blood_group`
--

CREATE TABLE IF NOT EXISTS `blood_group` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `blood_group`
--

INSERT INTO `blood_group` (`id`, `type`) VALUES
(1, 'O-'),
(2, 'O+'),
(3, 'A-'),
(4, 'A+'),
(5, 'B-'),
(6, 'B+'),
(7, 'AB-'),
(8, 'AB+');

-- --------------------------------------------------------

--
-- Table structure for table `doctor`
--

CREATE TABLE IF NOT EXISTS `doctor` (
  `doc_id` int(4) NOT NULL AUTO_INCREMENT,
  `F_Name` text NOT NULL,
  `L_Name` text NOT NULL,
  `Sex` enum('M','F') NOT NULL,
  `NIC` varchar(10) NOT NULL,
  `Salary` int(11) NOT NULL,
  `DOB` date NOT NULL,
  `Age` int(3) NOT NULL,
  `Qualification` text NOT NULL,
  `Speciality` text NOT NULL,
  `Channeling_Fee` text NOT NULL,
  PRIMARY KEY (`doc_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=31 ;

--
-- Dumping data for table `doctor`
--

INSERT INTO `doctor` (`doc_id`, `F_Name`, `L_Name`, `Sex`, `NIC`, `Salary`, `DOB`, `Age`, `Qualification`, `Speciality`, `Channeling_Fee`) VALUES
(1, 'Prabath ', 'Bandara', 'M', '883478657v', 55000, '1967-10-15', 25, 'MBBS', 'Gastrologist', '1500'),
(2, 'Yasantha', 'Sampath', 'M', '754567789v', 50000, '1975-10-14', 33, 'MBBS', 'Diabetologist', '1200'),
(3, 'Lahiru', 'Bandara', 'M', '886754367v', 60000, '1988-10-12', 35, 'MBBS', 'Cardiologist', '1350'),
(4, 'Mihisurani', 'Sharwandha', 'F', '886778654v', 55000, '1988-10-01', 25, 'MBBS', 'Neurologist', '1600'),
(6, 'Jagath', 'Silva', 'M', '789865438v', 40000, '1978-10-13', 36, 'MBBS', 'Nepherlogist', '1000'),
(7, 'Kamal', 'Nalaka', 'M', '921117073v', 43000, '1978-10-13', 36, 'MBBS', 'Rheumatologist', '800'),
(8, 'Nimaz', 'Akbar', 'M', '881117073v', 70000, '1988-09-01', 30, 'MBBS', 'Plastic Surgeon', '1250'),
(9, 'Gayan', 'Harsha', 'M', '886567879v', 55000, '1988-09-01', 26, 'MBBS', 'Physiotherapist', '680'),
(10, 'Gayathri', 'Ahinsa', 'F', '886567879v', 55000, '1988-09-01', 32, 'MBBS', 'Physician', ' 680'),
(11, 'Sakthi', 'Harsha', 'M', '886567879v', 55000, '1988-09-01', 24, 'MBBS', 'Radiologist', ' 680'),
(12, 'Nilika', 'Bandara', 'F', '886567879v', 55000, '1988-09-01', 33, 'MBBS', 'Vascular Surgen', ' 670'),
(13, 'Sumudu', 'Jewanthi', 'F', '886567879v', 55000, '1988-09-01', 26, 'MBBS', 'Padediatricians', ' 980'),
(14, 'Nayana', 'Harshi', 'F', '886567879v', 55000, '1988-09-01', 26, 'MBBS', 'Physiotherapist', '  680'),
(15, 'lakmal', 'Silva', 'M', '679876549v', 88000, '1967-10-13', 47, 'MBBS', 'Pneumologist', '1600'),
(16, 'Fazir', 'Akbar', 'M', '909876549v', 80000, '1990-10-13', 24, 'MBBS', 'Neonatologist', '  900'),
(17, 'Nalinda', 'Harsha', 'M', '909876549v', 78000, '1990-10-13', 33, 'MBBS', 'Radiotherapist', '  780'),
(18, 'Bhagya', 'Sashi', 'F', '909876549v', 68000, '1991-11-21', 35, 'MBBS', 'Public Health', '  660'),
(19, 'Winodi', 'Ganga', 'F', '909876549v', 98000, '1990-10-13', 55, 'MBBS', 'Allergy and Immunologist', '  680'),
(20, 'Kasun', 'Jagath', 'M', '909876549v', 86000, '1990-10-13', 67, 'MBBS', 'Hepatologist', '  370'),
(21, 'Lakmal', 'Harsha', 'M', '909876549v', 58000, '1990-10-13', 34, 'MBBS', 'Stomatologist', '  570'),
(22, 'Malinda', 'Harsha', 'M', '909876549v', 48000, '1990-10-13', 30, 'MBBS', 'Pulmonologist', '  780'),
(23, 'Kumudu', 'Samanmali', 'F', '909876549v', 68000, '1990-10-13', 45, 'MBBS', 'Pediatrics', '  890'),
(24, 'Saduni', 'Ishara', 'F', '909876549v', 48000, '1990-10-13', 26, 'MBBS', 'Obstetrics and Gynecologist', '  450'),
(25, 'Nalinda', 'Harsha', 'M', '909876549v', 85000, '1990-10-13', 28, 'MBBS', 'Otolaryngologist', '  780'),
(26, 'Malithi', 'Silva', 'F', '909876549v', 73000, '1990-10-13', 54, 'MBBS', 'Dermatologist', '  700'),
(27, 'Nalika', 'Harshani', 'M', '909876549v', 47000, '1990-10-13', 28, 'MBBS', 'Family medicine', '  960'),
(28, 'Peshala', 'Disanayaka', 'F', '909876549v', 56000, '1990-10-13', 24, 'MBBS', 'Pulmonologist', '  700'),
(29, 'Nalinda', 'Harsha', 'M', '909876549v', 88000, '1990-10-13', 24, 'MBBS', 'Otolaryngologist', '  900'),
(30, 'ggg', 'rrrr', 'M', '666566', 66666, '2015-01-15', 0, 'hhh', 'hhhh', '555');

-- --------------------------------------------------------

--
-- Table structure for table `doc_pat`
--

CREATE TABLE IF NOT EXISTS `doc_pat` (
  `doc_ID` int(11) NOT NULL,
  `pat_ID` int(11) NOT NULL,
  PRIMARY KEY (`doc_ID`,`pat_ID`),
  KEY `pat_ID` (`pat_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `id` int(11) NOT NULL,
  `user` varchar(20) NOT NULL,
  `Password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `user`, `Password`) VALUES
(1, 'Doctor', '1234'),
(2, 'Nurse', '1234'),
(3, 'Receptionist', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `nurse`
--

CREATE TABLE IF NOT EXISTS `nurse` (
  `F_Name` varchar(50) NOT NULL,
  `L_Name` varchar(50) NOT NULL,
  `sex` enum('M','F') NOT NULL,
  `Nurse_Id` int(4) NOT NULL,
  `Salary` int(6) NOT NULL,
  `DOB` date NOT NULL,
  `Quli` text NOT NULL,
  `Shift` text NOT NULL,
  PRIMARY KEY (`Nurse_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `nurse`
--

INSERT INTO `nurse` (`F_Name`, `L_Name`, `sex`, `Nurse_Id`, `Salary`, `DOB`, `Quli`, `Shift`) VALUES
('afa', 'erere', 'M', 1, 343434, '2015-01-16', 'afafa', '30');

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE IF NOT EXISTS `patients` (
  `Pat_ID` int(11) NOT NULL AUTO_INCREMENT,
  `F_Name` varchar(50) NOT NULL,
  `L_Name` varchar(50) NOT NULL,
  `Date_Adm` date NOT NULL,
  `Date_Dis` date NOT NULL,
  `NIC` text NOT NULL,
  `Gender` enum('M','F') NOT NULL,
  `DOB` date NOT NULL,
  `Blood_Grp` text NOT NULL,
  `Weight` decimal(5,0) NOT NULL,
  `Marital` int(7) NOT NULL,
  `Add1` text NOT NULL,
  `Add2` varchar(50) NOT NULL,
  `Nationality` varchar(20) NOT NULL,
  `State` varchar(50) NOT NULL,
  `Tel_Num` int(12) NOT NULL,
  `Mob_Num` int(12) NOT NULL,
  PRIMARY KEY (`Pat_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`Pat_ID`, `F_Name`, `L_Name`, `Date_Adm`, `Date_Dis`, `NIC`, `Gender`, `DOB`, `Blood_Grp`, `Weight`, `Marital`, `Add1`, `Add2`, `Nationality`, `State`, `Tel_Num`, `Mob_Num`) VALUES
(4, '343rea', 'afaf', '0000-00-00', '0000-00-00', '354345', 'M', '0000-00-00', 'O-', '454', 0, '0', '0', '0', 'Central', 555555555, 666666666);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doc_pat`
--
ALTER TABLE `doc_pat`
  ADD CONSTRAINT `doc_pat_ibfk_1` FOREIGN KEY (`doc_ID`) REFERENCES `doctor` (`doc_id`),
  ADD CONSTRAINT `doc_pat_ibfk_2` FOREIGN KEY (`pat_ID`) REFERENCES `patients` (`Pat_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
