-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Generation Time: Apr 23, 2021 at 08:55 AM
-- Server version: 5.7.26-log
-- PHP Version: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi467491`
--

-- --------------------------------------------------------

--
-- Table structure for table `mb_contract_history`
--

CREATE TABLE `mb_contract_history` (
  `id` int(11) NOT NULL,
  `empid` int(11) NOT NULL,
  `contract` enum('FULLTIME','EIGHTYPERCENT','FLEX','LEFT') NOT NULL,
  `startdate` date NOT NULL,
  `lastdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mb_contract_history`
--

INSERT INTO `mb_contract_history` (`id`, `empid`, `contract`, `startdate`, `lastdate`) VALUES
(26, 2, 'FULLTIME', '2020-08-14', '2021-04-11'),
(27, 2, 'EIGHTYPERCENT', '2020-08-14', '2021-04-11'),
(28, 57, 'EIGHTYPERCENT', '2021-04-11', '2021-04-11'),
(29, 51, 'EIGHTYPERCENT', '2021-04-11', '2021-04-11'),
(30, 57, 'LEFT', '2021-04-11', '2021-04-11'),
(31, 51, 'FULLTIME', '2021-04-11', '2021-04-11'),
(32, 2, 'FULLTIME', '2020-08-14', '2021-04-11'),
(33, 57, 'FULLTIME', '2021-04-11', '2021-04-11'),
(34, 8, 'EIGHTYPERCENT', '2021-04-11', '2021-04-11'),
(35, 3, 'FULLTIME', '2021-04-11', '2021-04-11'),
(36, 2, 'EIGHTYPERCENT', '2021-04-11', '2021-04-11'),
(37, 2, 'FULLTIME', '2021-04-11', '2021-04-11'),
(38, 4, 'FULLTIME', '2021-04-11', '2021-04-12'),
(39, 7, 'FULLTIME', '2021-04-11', '2021-04-12'),
(40, 60, 'FULLTIME', '2021-04-14', '2021-04-14'),
(41, 59, 'FULLTIME', '2021-04-14', '2021-04-15'),
(42, 51, 'EIGHTYPERCENT', '2021-04-11', '2021-04-15'),
(43, 40, 'EIGHTYPERCENT', '2021-04-11', '2021-04-16'),
(44, 2, 'EIGHTYPERCENT', '2021-04-11', '2021-04-17'),
(45, 2, 'LEFT', '2021-04-17', '2021-04-17'),
(47, 79, 'EIGHTYPERCENT', '2021-04-22', '2021-04-22'),
(48, 79, 'FULLTIME', '2021-04-22', '2021-04-22'),
(49, 79, 'EIGHTYPERCENT', '2021-04-22', '2021-04-22');

-- --------------------------------------------------------

--
-- Table structure for table `mb_department`
--

CREATE TABLE `mb_department` (
  `code` int(11) NOT NULL,
  `dept_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mb_department`
--

INSERT INTO `mb_department` (`code`, `dept_name`) VALUES
(2303, 'Electrical & Lighting'),
(2678, 'Hand & Power Tools'),
(9999, 'g');

-- --------------------------------------------------------

--
-- Table structure for table `mb_dept_with_assigned_dmanager`
--

CREATE TABLE `mb_dept_with_assigned_dmanager` (
  `dept_code` int(11) NOT NULL,
  `dmanager_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `mb_employee`
--

CREATE TABLE `mb_employee` (
  `id` int(11) NOT NULL,
  `bsn` varchar(11) NOT NULL,
  `fname` varchar(40) NOT NULL,
  `lname` varchar(40) NOT NULL,
  `gender` enum('MALE','FEMALE','OTHER') NOT NULL,
  `email` varchar(60) NOT NULL,
  `uname` varchar(30) NOT NULL,
  `pwd` varchar(50) NOT NULL,
  `birthdate` date NOT NULL,
  `street` varchar(50) NOT NULL,
  `streetnumber` varchar(20) NOT NULL,
  `zipcode` varchar(20) NOT NULL,
  `town` varchar(40) NOT NULL,
  `country` varchar(40) NOT NULL,
  `firstworkingday` date NOT NULL,
  `emergphonenumber` varchar(15) NOT NULL,
  `iban` varchar(20) NOT NULL,
  `hourlywage` double(100,1) NOT NULL,
  `contractstartdate` date NOT NULL,
  `contracttype` enum('FULLTIME','EIGHTYPERCENT','FLEX','LEFT') NOT NULL,
  `position` enum('CASHIER','STORE_WORKER','STOCK_WORKER','DEPARTMENT_MANAGER','STORE_MANAGER','STOCK_MANAGER','HR') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mb_employee`
--

INSERT INTO `mb_employee` (`id`, `bsn`, `fname`, `lname`, `gender`, `email`, `uname`, `pwd`, `birthdate`, `street`, `streetnumber`, `zipcode`, `town`, `country`, `firstworkingday`, `emergphonenumber`, `iban`, `hourlywage`, `contractstartdate`, `contracttype`, `position`) VALUES
(2, '999999990', 'Marvin', 'Tommie', 'MALE', 'Marvin@mediabazaar.com', 'Marvin001', '0000', '1995-09-07', 'De Koppele', '132', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715303', '3333 4444 5555 6666', 20.0, '2021-04-17', 'FULLTIME', 'HR'),
(3, '999999991', 'Archie', 'Beverly', 'MALE', 'Archie@mediabazaar.com', 'Archie001', '0000', '1980-03-03', 'Van Renesseweg', '59', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715101', '3333 4444 5555 5555', 16.0, '2021-04-11', 'EIGHTYPERCENT', 'STORE_MANAGER'),
(4, '999999992', 'Jay', 'Ross', 'MALE', 'Jay@mediabazaar.com', 'Jay001', '0000', '1981-03-03', 'Thorvaldsenlaan', '135', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715202', '3333 4444 5555 1111', 16.0, '2021-04-12', 'EIGHTYPERCENT', 'DEPARTMENT_MANAGER'),
(6, '999999993', 'Roberto', 'Shaw', 'MALE', 'Roberto@mediabazaar.com', 'Roberto001', '0000', '1982-03-03', 'Fellenoord', '120', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715102', '3333 4444 5555 4440', 16.0, '2021-04-11', 'FULLTIME', 'STORE_WORKER'),
(7, '999999994', 'Victoria', 'Clark', 'FEMALE', 'Victoria@mediabazaar.com', 'Victoria001', '0000', '1983-03-02', 'Uranuslaan', '192', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715307', '3333 4444 5555 2323', 16.0, '2021-04-12', 'EIGHTYPERCENT', 'STORE_WORKER'),
(8, '999999995', 'Elizabeth', 'Guerrero', 'FEMALE', 'Elizabeth@mediabazaar.com', 'Elizabeth001', '0000', '1984-03-02', 'Beukenlaan', '179', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715106', '3333 4444 5555 2322', 10.0, '2021-04-11', 'FULLTIME', 'STOCK_MANAGER'),
(9, '999999996', 'Oscar', 'Patterson', 'MALE', 'Oscar@mediabazaar.com', 'Oscar001', '0000', '1996-06-07', 'Bleekweg', '44', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715103', '3333 4444 5555 6655', 10.0, '2021-04-11', 'LEFT', 'STORE_WORKER'),
(12, '999999999', 'Mona', 'Robertson', 'OTHER', 'Mona@mediabazaar.com', 'Mona001', '0000', '1990-09-04', 'Antonius van Gilsweg', '52', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882727303', '3333 4444 5555 9678', 10.0, '2021-04-11', 'LEFT', 'STORE_WORKER'),
(28, '2653652', 'Jeff', 'Hardy', 'MALE', 'jeff@mediabazaar.com', 'Jeff001', '0000', '1991-06-13', 'BinnenStaat ', '13', '242349', 'Den Hague', 'Netherlands', '2021-03-03', '0852832', '923759235', 11.0, '2021-04-11', 'EIGHTYPERCENT', 'STOCK_WORKER'),
(40, '999999997', 'Orlando', 'Holt', 'MALE', 'Orlando@mediabazaar.com', 'Orlando001', '0000', '2005-07-15', 'Glaslaan', '114', '5641WE', 'Eindhoven', 'Netherlands', '2020-03-05', '+31888888888', '3333 4444 5555 6666', 10.0, '2021-04-16', 'FULLTIME', 'STORE_WORKER'),
(51, '32321312313', 'Thomas', 'Thompson', 'MALE', 'tthompson007@gmail.com', 'tthompson007', '0', '1994-02-22', 'Kruisstraat', '90', '5612YT', 'Eindhoven', 'Netherland', '2021-03-24', '0605023121', '0650 4035 4560', 12.0, '2021-04-15', 'FULLTIME', 'DEPARTMENT_MANAGER'),
(57, 'TEST', 'TEST', 'TEST', 'MALE', 'TEST', 'TEST', '0', '2021-04-11', 'TEST', 'TEST', 'TEST', 'TEST', 'TEST', '2021-04-11', 'TEST', 'TEST', 10.0, '2021-04-11', 'EIGHTYPERCENT', 'STORE_WORKER'),
(58, '2335', 'Randy', 'Wilson', 'MALE', 'somewhere', 'Randy001', '0', '2019-06-14', 'somewhere', 'somewhere', 'somewhere', 'somewhere', 'somewhere', '2021-04-14', '3243', '23532', 32.0, '2021-04-14', 'FULLTIME', 'DEPARTMENT_MANAGER'),
(59, '436', 'Bob', 'McMan', 'MALE', 'somewhere', 'Bob001', '0', '2019-06-14', 'somewhere', 'somewhere', 'somewhere', 'somewhere', 'somewhere', '2021-04-14', '463', '457', 32.0, '2021-04-15', 'EIGHTYPERCENT', 'DEPARTMENT_MANAGER'),
(60, '6858', 'Stacey', 'Holiday', 'FEMALE', 'somewhere', 'Stacey001', '0', '2019-06-14', 'somewhere', 'somewhere', 'somewhere', 'somewhere', 'somewhere', '2021-04-14', '678', '6979', 32.0, '2021-04-14', 'EIGHTYPERCENT', 'DEPARTMENT_MANAGER'),
(61, 'Test6', 'Test6', 'Test6', 'MALE', 'Test6', 'Test6', '0', '2021-04-14', 'Test6', 'Test6', 'Test6', 'Test6', 'Test6', '2021-04-14', 'Test6', 'Test6', 2.0, '2021-04-14', 'FULLTIME', 'STORE_WORKER'),
(74, 'Test56', 'Test56', 'Test56', 'MALE', 'Test56', 'Test56', '0', '2021-04-16', 'Test56', 'Test56', 'Test56', 'Test56', 'Test56', '2021-04-16', 'Test56', 'Test56', 22.0, '2021-04-16', 'FULLTIME', 'STORE_WORKER'),
(75, 'exe', 'exe', 'exe', 'MALE', 'exe', 'exe', '0', '2021-04-16', 'exe', 'exe', 'exe', 'exe', 'exe', '2021-04-16', 'exe', 'exe', 22.0, '2021-04-16', 'FULLTIME', 'DEPARTMENT_MANAGER'),
(79, '987678652', 'Tony', 'Stoychev', 'MALE', 'Tony@abv.bg', 'Tony001', '0', '2000-02-02', 'Mortierlaan', '67', '5674WE', 'Eindhoven', 'Netherlands', '2021-04-22', '0886517892', '2222 4333 6666 3332', 10.0, '2021-04-22', 'EIGHTYPERCENT', 'CASHIER');

-- --------------------------------------------------------

--
-- Table structure for table `mb_product`
--

CREATE TABLE `mb_product` (
  `pNum` int(11) NOT NULL,
  `brand` varchar(30) NOT NULL,
  `type` varchar(30) NOT NULL,
  `model` varchar(30) NOT NULL,
  `description` text NOT NULL,
  `category` varchar(30) NOT NULL,
  `sub_category` varchar(30) NOT NULL,
  `cost_price` decimal(7,2) NOT NULL,
  `sales_price` decimal(7,2) NOT NULL,
  `amount_in_store` int(11) NOT NULL,
  `amount_in_warehouse` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mb_product`
--

INSERT INTO `mb_product` (`pNum`, `brand`, `type`, `model`, `description`, `category`, `sub_category`, `cost_price`, `sales_price`, `amount_in_store`, `amount_in_warehouse`) VALUES
(1, 'Bosch', 'Screwdriver', 'EasyDrill 1200 12V', 'easy to drill.', 'Tools', 'Drills', '88.99', '98.99', 10, 25),
(2, 'DeWalt', 'Screwdriver', 'DCD791P2-QW', 'for daily jobs.', 'Tools', 'Drills', '288.50', '299.99', 12, 18),
(3, 'Makita', 'Belt sander', '9903', 'low vibration.', 'Tools', 'Sanders', '250.25', '269.99', 7, 10),
(4, 'PowerPlus', 'Long-neck sander', 'POWX0479', 'easy to use.', 'Tools', 'Sanders', '120.99', '135.99', 3, 8),
(5, 'Fein', 'Professional', 'MultiMaster FMM350QSL', 'a lot of usage.', 'Tools', 'Multitools', '255.00', '269.00', 3, 5),
(6, 'Dremel', 'Rotating', 'Lite 7760', 'Light and compact', 'Tools', 'Mulititools', '60.00', '72.00', 10, 30),
(7, 'Dremel', 'Rotating', '3000 JU', 'All around multi-tool', 'Tools', 'Mulititools', '49.50', '61.95', 8, 28),
(49, 'test', 'test', 'test', '3', 'test', 'test', '2.00', '3.00', 3, 3);

-- --------------------------------------------------------

--
-- Table structure for table `mb_receipt`
--

CREATE TABLE `mb_receipt` (
  `id` int(11) NOT NULL,
  `empid` int(11) NOT NULL,
  `paymenttype` enum('CASH','CARD') NOT NULL,
  `totalprice` double(7,4) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `mb_shift`
--

CREATE TABLE `mb_shift` (
  `shiftType` enum('Morning','Afternoon','Evening','Night') NOT NULL,
  `date` date NOT NULL,
  `assignableEmployees` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mb_shift`
--

INSERT INTO `mb_shift` (`shiftType`, `date`, `assignableEmployees`) VALUES
('Morning', '2021-04-19', 5),
('Morning', '2021-04-21', 10),
('Morning', '2021-04-22', 5),
('Morning', '2021-04-23', 10),
('Morning', '2021-04-24', 10),
('Morning', '2021-04-25', 10),
('Morning', '2021-04-26', 5),
('Morning', '2021-04-27', 5),
('Morning', '2021-04-28', 5),
('Morning', '2021-05-03', 5),
('Afternoon', '2021-04-21', 10),
('Afternoon', '2021-04-22', 10),
('Afternoon', '2021-04-23', 10),
('Afternoon', '2021-04-24', 10),
('Afternoon', '2021-04-25', 10),
('Afternoon', '2021-04-26', 10),
('Afternoon', '2021-04-27', 10),
('Afternoon', '2021-04-28', 10),
('Afternoon', '2021-05-03', 10),
('Evening', '2021-04-19', 10),
('Evening', '2021-04-21', 5),
('Evening', '2021-04-22', 10),
('Evening', '2021-04-23', 10),
('Evening', '2021-04-24', 10),
('Evening', '2021-04-25', 10),
('Evening', '2021-04-26', 10),
('Evening', '2021-04-27', 10),
('Evening', '2021-04-28', 10),
('Evening', '2021-05-03', 10),
('Night', '2021-04-21', 2),
('Night', '2021-04-22', 5),
('Night', '2021-04-23', 10),
('Night', '2021-04-24', 10),
('Night', '2021-04-25', 10),
('Night', '2021-04-26', 5),
('Night', '2021-04-27', 5),
('Night', '2021-04-28', 5),
('Night', '2021-05-03', 5),
('Night', '2021-05-17', 5);

-- --------------------------------------------------------

--
-- Table structure for table `mb_shift_with_assigned_employee`
--

CREATE TABLE `mb_shift_with_assigned_employee` (
  `shiftType` enum('Morning','Afternoon','Evening','Night') NOT NULL,
  `date` date NOT NULL,
  `employeeID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mb_shift_with_assigned_employee`
--

INSERT INTO `mb_shift_with_assigned_employee` (`shiftType`, `date`, `employeeID`) VALUES
('Morning', '2021-04-21', 6),
('Morning', '2021-04-22', 6),
('Morning', '2021-04-24', 6),
('Afternoon', '2021-04-21', 6),
('Afternoon', '2021-04-22', 6),
('Afternoon', '2021-04-23', 6),
('Afternoon', '2021-04-24', 6),
('Evening', '2021-04-22', 6),
('Evening', '2021-04-23', 6),
('Evening', '2021-04-24', 6),
('Night', '2021-04-23', 6),
('Morning', '2021-04-21', 7),
('Morning', '2021-04-23', 7),
('Evening', '2021-04-24', 7),
('Night', '2021-04-21', 7),
('Morning', '2021-04-21', 40),
('Morning', '2021-04-22', 40),
('Afternoon', '2021-04-22', 40),
('Afternoon', '2021-04-23', 40),
('Night', '2021-04-22', 40),
('Night', '2021-04-23', 40),
('Afternoon', '2021-04-21', 57),
('Evening', '2021-04-21', 57),
('Night', '2021-04-24', 57),
('Morning', '2021-04-24', 61),
('Afternoon', '2021-04-21', 74),
('Night', '2021-04-21', 74);

-- --------------------------------------------------------

--
-- Table structure for table `mb_sold_product`
--

CREATE TABLE `mb_sold_product` (
  `id` int(11) NOT NULL,
  `receiptid` int(11) NOT NULL,
  `productid` int(11) NOT NULL,
  `quantity` int(5) NOT NULL,
  `unitprice` double(7,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

CREATE TABLE `test` (
  `dept_code` int(11) NOT NULL,
  `pNumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `test`
--

INSERT INTO `test` (`dept_code`, `pNumber`) VALUES
(1, 1),
(1, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `mb_contract_history`
--
ALTER TABLE `mb_contract_history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `contracthistoryFK` (`empid`);

--
-- Indexes for table `mb_department`
--
ALTER TABLE `mb_department`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `mb_dept_with_assigned_dmanager`
--
ALTER TABLE `mb_dept_with_assigned_dmanager`
  ADD KEY `dept_codeFK` (`dept_code`),
  ADD KEY `dmanager_idFK` (`dmanager_id`);

--
-- Indexes for table `mb_employee`
--
ALTER TABLE `mb_employee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `bsn` (`bsn`);

--
-- Indexes for table `mb_product`
--
ALTER TABLE `mb_product`
  ADD PRIMARY KEY (`pNum`);

--
-- Indexes for table `mb_receipt`
--
ALTER TABLE `mb_receipt`
  ADD PRIMARY KEY (`id`),
  ADD KEY `empidFK` (`empid`);

--
-- Indexes for table `mb_shift`
--
ALTER TABLE `mb_shift`
  ADD PRIMARY KEY (`shiftType`,`date`);

--
-- Indexes for table `mb_shift_with_assigned_employee`
--
ALTER TABLE `mb_shift_with_assigned_employee`
  ADD PRIMARY KEY (`shiftType`,`date`,`employeeID`),
  ADD KEY `employeeID` (`employeeID`);

--
-- Indexes for table `mb_sold_product`
--
ALTER TABLE `mb_sold_product`
  ADD PRIMARY KEY (`id`),
  ADD KEY `receiptidFK` (`receiptid`),
  ADD KEY `productidFK` (`productid`);

--
-- Indexes for table `test`
--
ALTER TABLE `test`
  ADD KEY `dept_codeFK` (`dept_code`),
  ADD KEY `pNumFK` (`pNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `mb_contract_history`
--
ALTER TABLE `mb_contract_history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `mb_employee`
--
ALTER TABLE `mb_employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=85;

--
-- AUTO_INCREMENT for table `mb_product`
--
ALTER TABLE `mb_product`
  MODIFY `pNum` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `mb_receipt`
--
ALTER TABLE `mb_receipt`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `mb_sold_product`
--
ALTER TABLE `mb_sold_product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `mb_contract_history`
--
ALTER TABLE `mb_contract_history`
  ADD CONSTRAINT `contracthistoryFK` FOREIGN KEY (`empid`) REFERENCES `mb_employee` (`id`);

--
-- Constraints for table `mb_dept_with_assigned_dmanager`
--
ALTER TABLE `mb_dept_with_assigned_dmanager`
  ADD CONSTRAINT `dept_codeFK` FOREIGN KEY (`dept_code`) REFERENCES `mb_department` (`code`),
  ADD CONSTRAINT `dmanager_idFK` FOREIGN KEY (`dmanager_id`) REFERENCES `mb_employee` (`id`);

--
-- Constraints for table `mb_receipt`
--
ALTER TABLE `mb_receipt`
  ADD CONSTRAINT `empidFK` FOREIGN KEY (`empid`) REFERENCES `mb_employee` (`id`);

--
-- Constraints for table `mb_shift_with_assigned_employee`
--
ALTER TABLE `mb_shift_with_assigned_employee`
  ADD CONSTRAINT `mb_shift_with_assigned_employee_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `mb_employee` (`id`),
  ADD CONSTRAINT `mb_shift_with_assigned_employee_ibfk_2` FOREIGN KEY (`shiftType`,`date`) REFERENCES `mb_shift` (`shiftType`, `date`);

--
-- Constraints for table `mb_sold_product`
--
ALTER TABLE `mb_sold_product`
  ADD CONSTRAINT `productidFK` FOREIGN KEY (`productid`) REFERENCES `mb_product` (`pNum`),
  ADD CONSTRAINT `receiptidFK` FOREIGN KEY (`receiptid`) REFERENCES `mb_receipt` (`id`);

--
-- Constraints for table `test`
--
ALTER TABLE `test`
  ADD CONSTRAINT `pNumFK` FOREIGN KEY (`pNumber`) REFERENCES `mb_product` (`pNum`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;