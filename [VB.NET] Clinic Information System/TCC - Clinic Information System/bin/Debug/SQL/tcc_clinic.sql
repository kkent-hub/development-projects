-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 25, 2018 at 02:21 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tcc_clinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `incase_emergency`
--

CREATE TABLE `incase_emergency` (
  `ID` int(11) NOT NULL,
  `Std_ID` text NOT NULL,
  `Name` text NOT NULL,
  `Relationship` text NOT NULL,
  `Contact_No` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `incase_emergency`
--

INSERT INTO `incase_emergency` (`ID`, `Std_ID`, `Name`, `Relationship`, `Contact_No`) VALUES
(1, '20151933', 'Casino, Lyn Nagac', 'Mother', '09351609597'),
(2, '20181932', 'Casino, Lyn Nagac', 'Mother', '870000');

-- --------------------------------------------------------

--
-- Table structure for table `medical_history`
--

CREATE TABLE `medical_history` (
  `ID` int(11) NOT NULL,
  `Std_ID` text NOT NULL,
  `Q1` text NOT NULL,
  `Q2` text NOT NULL,
  `Q3` text NOT NULL,
  `Q4` text NOT NULL,
  `Q5` text NOT NULL,
  `Q6` text NOT NULL,
  `Q7` text NOT NULL,
  `Q8` text NOT NULL,
  `Q9` text NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `medical_history`
--

INSERT INTO `medical_history` (`ID`, `Std_ID`, `Q1`, `Q2`, `Q3`, `Q4`, `Q5`, `Q6`, `Q7`, `Q8`, `Q9`, `Date`) VALUES
(1, '20151933', 'No', 'No', 'No', 'No', 'No', 'No', 'Yes', 'No', 'No', '2018-06-20'),
(2, '20181932', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', '2018-06-23');

-- --------------------------------------------------------

--
-- Table structure for table `other_medical_info`
--

CREATE TABLE `other_medical_info` (
  `ID` int(11) NOT NULL,
  `Std_ID` text NOT NULL,
  `Health_Condition` text NOT NULL,
  `Taking_Medication` text NOT NULL,
  `Medication` text NOT NULL,
  `During_After_Excerise` text NOT NULL,
  `Q1_Symptoms` text NOT NULL,
  `OutCome` text NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `other_medical_info`
--

INSERT INTO `other_medical_info` (`ID`, `Std_ID`, `Health_Condition`, `Taking_Medication`, `Medication`, `During_After_Excerise`, `Q1_Symptoms`, `OutCome`, `Date`) VALUES
(1, '20151933', 'N/N', 'Yes', 'I forgot what medication i take.', 'Fainting spells,Excessive Bruising,Chest Pain,Extreme shortness of breath,Coughing / Wheezing,Lighteadedness / Dizziness,Numbness and tingling sensation of extremities', 'No', 'N/N', '2018-06-20'),
(2, '20181932', 'Condition', 'Yes', 'wow amazing', 'Fainting spells,Excessive Bruising,Chest Pain,Extreme shortness of breath,Coughing / Wheezing,Lighteadedness / Dizziness,Numbness and tingling sensation of extremities', 'Yes', 'outcome sample', '2018-06-23');

-- --------------------------------------------------------

--
-- Table structure for table `present_history`
--

CREATE TABLE `present_history` (
  `ID` int(11) NOT NULL,
  `Std_ID` text NOT NULL,
  `Alcohol` text NOT NULL,
  `Smoking` text NOT NULL,
  `Contraceptive` text NOT NULL,
  `BP` text NOT NULL,
  `RR` text NOT NULL,
  `Height` text NOT NULL,
  `BMI` text NOT NULL,
  `LMP` text NOT NULL,
  `Temperature` text NOT NULL,
  `PR` text NOT NULL,
  `Weight` text NOT NULL,
  `Visual_Acuity` text NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `present_history`
--

INSERT INTO `present_history` (`ID`, `Std_ID`, `Alcohol`, `Smoking`, `Contraceptive`, `BP`, `RR`, `Height`, `BMI`, `LMP`, `Temperature`, `PR`, `Weight`, `Visual_Acuity`, `Date`) VALUES
(1, '20151933', 'Emperador Light', 'Malboro', 'N/N', '100', '35', '167cm', '34', '678', '90', '34', '80lbs', '100', '2018-06-20'),
(2, '20181932', 'sample1', 'sample2', 'sample3', 'sample4', 'sample5', 'sample6', 'sample7', 'sample8', 'sample9', 'sample10', 'sample11', 'sample12', '2018-06-23');

-- --------------------------------------------------------

--
-- Table structure for table `referral`
--

CREATE TABLE `referral` (
  `ID` int(11) NOT NULL,
  `Name` text NOT NULL,
  `Age` text NOT NULL,
  `Course_Year` text NOT NULL,
  `Address` text NOT NULL,
  `Reason` text NOT NULL,
  `Temp` text NOT NULL,
  `HR` text NOT NULL,
  `RR` text NOT NULL,
  `BP` text NOT NULL,
  `Intervention` text NOT NULL,
  `Reason_Referral` text NOT NULL,
  `Referral_by` text NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `referral`
--

INSERT INTO `referral` (`ID`, `Name`, `Age`, `Course_Year`, `Address`, `Reason`, `Temp`, `HR`, `RR`, `BP`, `Intervention`, `Reason_Referral`, `Referral_by`, `Date`) VALUES
(1, 'Casino, Kent Russell Nagac', '20', 'BSIT - 2ND', '#337 Zone-1, Kauswagan, Cagayan de Oro', 'reason', 'temp', 'hr', 'rr', 'bp', 'intervation', '', '', '0001-01-01'),
(2, 'Casino, Kent Russell Nagac', '20', 'BSIT - 2ND', '#337 Zone-1, Kauswagan, Cagayan de Oro', 'reason', 'temp', 'hr', 'rr', 'bp', 'intervation', 'Medical Certificate for employment.', 'June Dudy Ann N. Conales, RN', '0001-01-01'),
(3, 'Casino, Kent Russell Nagac', '20', 'BSIT - 2ND', '#337 Zone-1, Kauswagan, Cagayan de Oro', '', '', '', '', '', '', 'Dental check-up / Dental extraction.', 'June Dudy Ann N. Conales, RN', '2018-06-24'),
(4, 'Casino, Kent Russell Nagac', '20', 'BSIT - 2ND', '#337 Zone-1, Kauswagan, Cagayan de Oro', 'qwe', 'qwe', 'qew', 'qew', 'qew', 'qwe', 'Dental check-up / Dental extraction.', 'June Dudy Ann N. Conales, RN', '2018-06-25'),
(5, 'Casino, Kent Russell Nagac', '20', 'BSIT - 2ND', '#337 Zone-1, Kauswagan, Cagayan de Oro', 'rqweasdsadsdadasdasdasdasdsadrqweasdsadsdadasdasdasdasdsadrqweasdsadsdadasdasdasdasdsad', '11', '123', '567', '889', 'rqweasdsadsdadasdasdasdasdsadrqweasdsadsdadasdasdasdasdsad', 'Dental check-up / Dental extraction.', 'June Dudy Ann N. Conales, RN', '2018-06-25');

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE `student_info` (
  `ID` int(11) NOT NULL,
  `Std_ID` int(11) NOT NULL,
  `First_Name` text NOT NULL,
  `Middle_Name` text NOT NULL,
  `Last_Name` text NOT NULL,
  `Gender` text NOT NULL,
  `Course` text NOT NULL,
  `Year` text NOT NULL,
  `Civil_Status` text NOT NULL,
  `Birthdate` date NOT NULL,
  `Blood_Type` text NOT NULL,
  `Religion` text NOT NULL,
  `Contact_No` text NOT NULL,
  `Home_Address` text NOT NULL,
  `Present_Address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`ID`, `Std_ID`, `First_Name`, `Middle_Name`, `Last_Name`, `Gender`, `Course`, `Year`, `Civil_Status`, `Birthdate`, `Blood_Type`, `Religion`, `Contact_No`, `Home_Address`, `Present_Address`) VALUES
(1, 20151933, 'Kent Russell', 'Nagac', 'Casino', 'Male', 'BSIT', '2ND', 'Single', '1997-09-16', 'O', 'Jesus Christ', '09161356445', '#337 Zone-1, Kauswagan, Cagayan de Oro', '#337 Zone-1, Kauswagan, Cagayan de Oro'),
(2, 20181932, 'Maverick', 'Nagac', 'Casino', 'Female', 'BSBA', ' 4TH', 'Single', '2011-06-23', 'B', 'Catholic', '87000', 'Poblacion, Tagoloan, Misamis Oriental', ''),
(4, 20151931, 'Rodrigo', 'Duterte', 'Roa', 'Male', 'CRIM', ' 4TH', '', '1988-03-12', '', '', '09161356445', '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `incase_emergency`
--
ALTER TABLE `incase_emergency`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `medical_history`
--
ALTER TABLE `medical_history`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `other_medical_info`
--
ALTER TABLE `other_medical_info`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `present_history`
--
ALTER TABLE `present_history`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `referral`
--
ALTER TABLE `referral`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student_info`
--
ALTER TABLE `student_info`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `incase_emergency`
--
ALTER TABLE `incase_emergency`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `medical_history`
--
ALTER TABLE `medical_history`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `other_medical_info`
--
ALTER TABLE `other_medical_info`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `present_history`
--
ALTER TABLE `present_history`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `referral`
--
ALTER TABLE `referral`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `student_info`
--
ALTER TABLE `student_info`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
