-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Generation Time: 31 март 2021 в 10:18
-- Версия на сървъра: 5.7.26-log
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
-- Структура на таблица `mb_contract_history`
--

CREATE TABLE `mb_contract_history` (
  `id` int(11) NOT NULL,
  `empid` int(11) NOT NULL,
  `contract` enum('FULLTIME','EIGHTYPERCENT','FLEX','LEFT') NOT NULL,
  `startdate` date NOT NULL,
  `lastdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура на таблица `mb_employee`
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
  `contracttype` enum('FULLTIME','EIGHTYPERCENT','FLEX','LEFT') NOT NULL,
  `position` enum('STORE_WORKER','STOCK_WORKER','DEPARTMENT_MANAGER','STORE_MANAGER','STOCK_MANAGER','HR') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `mb_employee`
--

INSERT INTO `mb_employee` (`id`, `bsn`, `fname`, `lname`, `gender`, `email`, `uname`, `pwd`, `birthdate`, `street`, `streetnumber`, `zipcode`, `town`, `country`, `firstworkingday`, `emergphonenumber`, `iban`, `hourlywage`, `contracttype`, `position`) VALUES
(2, '999999990', 'Marvin', 'Tommie', 'MALE', 'Marvin@mediabazaar.com', 'Marvin001', '0000', '1995-09-07', 'De Koppele', '132', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715303', '3333 4444 5555 6666', 20.0, 'FULLTIME', 'HR'),
(3, '999999991', 'Archie', 'Beverly', 'MALE', 'Archie@mediabazaar.com', 'Archie001', '0000', '1980-03-03', 'Van Renesseweg', '59', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715101', '3333 4444 5555 5555', 16.0, 'FULLTIME', 'STORE_MANAGER'),
(4, '999999992', 'Jay', 'Ross', 'MALE', 'Jay@mediabazaar.com', 'Jay001', '0000', '1981-03-03', 'Thorvaldsenlaan', '135', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715202', '3333 4444 5555 1111', 16.0, 'FULLTIME', 'DEPARTMENT_MANAGER'),
(6, '999999993', 'Roberto', 'Shaw', 'MALE', 'Roberto@mediabazaar.com', 'Roberto001', '0000', '1982-03-03', 'Fellenoord', '120', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715102', '3333 4444 5555 4440', 16.0, 'FULLTIME', 'STORE_WORKER'),
(7, '999999994', 'Victoria', 'Clark', 'FEMALE', 'Victoria@mediabazaar.com', 'Victoria001', '0000', '1983-03-02', 'Uranuslaan', '192', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715307', '3333 4444 5555 2323', 16.0, 'FULLTIME', 'STORE_WORKER'),
(8, '999999995', 'Elizabeth', 'Guerrero', 'FEMALE', 'Elizabeth@mediabazaar.com', 'Elizabeth001', '0000', '1984-03-02', 'Beukenlaan', '179', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715106', '3333 4444 5555 2322', 10.0, 'EIGHTYPERCENT', 'STOCK_MANAGER'),
(9, '999999996', 'Oscar', 'Patterson', 'MALE', 'Oscar@mediabazaar.com', 'Oscar001', '0000', '1996-06-07', 'Bleekweg', '44', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882715103', '3333 4444 5555 6655', 10.0, 'EIGHTYPERCENT', 'STORE_WORKER'),
(12, '999999999', 'Mona', 'Robertson', 'OTHER', 'Mona@mediabazaar.com', 'Mona001', '0000', '1990-09-04', 'Antonius van Gilsweg', '52', '5641WE', 'Eindhoven', 'Netherlands', '2018-01-07', '0882727303', '3333 4444 5555 9678', 10.0, 'EIGHTYPERCENT', 'STORE_WORKER'),
(28, '2653652', 'Jeff', 'Hardy', 'MALE', 'jeff@mediabazaar.com', 'Jeff001', '0000', '1991-06-13', 'BinnenStaat ', '13', '242349', 'Den Hague', 'Netherlands', '2021-03-03', '0852832', '923759235', 11.0, 'EIGHTYPERCENT', 'STOCK_WORKER'),
(40, '999999997', 'Orlando', 'Holt', 'MALE', 'Orlando@mediabazaar.com', 'Orlando001', '0000', '2005-07-15', 'Glaslaan', '114', '5641WE', 'Eindhoven', 'Netherlands', '2020-03-05', '+31888888888', '3333 4444 5555 6666', 10.0, 'FULLTIME', 'STORE_WORKER'),
(51, '32321312313', 'Thomas', 'Thompson', 'MALE', 'tthompson007@gmail.com', 'tthompson007', '0', '1994-02-22', 'Kruisstraat', '90', '5612YT', 'Eindhoven', 'Netherland', '2021-03-24', '0605023121', '0650 4035 4560', 12.0, 'EIGHTYPERCENT', 'DEPARTMENT_MANAGER');

-- --------------------------------------------------------

--
-- Структура на таблица `mb_product`
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
-- Схема на данните от таблица `mb_product`
--

INSERT INTO `mb_product` (`pNum`, `brand`, `type`, `model`, `description`, `category`, `sub_category`, `cost_price`, `sales_price`, `amount_in_store`, `amount_in_warehouse`) VALUES
(1, 'Bosch', 'Screwdriver', 'EasyDrill 1200 12V', 'easy to drill.', 'Tools', 'Drills', '88.99', '98.99', 10, 25),
(2, 'DeWalt', 'Screwdriver', 'DCD791P2-QW', 'for daily jobs.', 'Tools', 'Drills', '288.50', '299.99', 12, 18),
(3, 'Makita', 'Belt sander', '9903', 'low vibration.', 'Tools', 'Sanders', '250.25', '269.99', 7, 10),
(4, 'PowerPlus', 'Long-neck sander', 'POWX0479', 'easy to use.', 'Tools', 'Sanders', '120.99', '135.99', 3, 8),
(5, 'Fein', 'Professional', 'MultiMaster FMM350QSL', 'a lot of usage.', 'Tools', 'Multitools', '255.00', '269.00', 3, 5),
(6, 'Dremel', 'Rotating', 'Lite 7760', 'Light and compact', 'Tools', 'Mulititools', '60.00', '72.00', 10, 30),
(7, 'Dremel', 'Rotating', '3000 JU', 'All around multi-tool', 'Tools', 'Mulititools', '49.50', '61.95', 8, 28),
(28, 'Dewong', 'hand-saw', '3000', 'easy to use', 'Tools', 'saw', '20.00', '30.00', 5, 20);

-- --------------------------------------------------------

--
-- Структура на таблица `mb_shift`
--

CREATE TABLE `mb_shift` (
  `id` int(10) NOT NULL,
  `shiftType` enum('Morning','Afternoon','Evening','Night') NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `mb_shift`
--

INSERT INTO `mb_shift` (`id`, `shiftType`, `date`) VALUES
(1, 'Morning', '2021-04-01'),
(3, 'Morning', '2013-03-20'),
(4, 'Morning', '2021-04-02'),
(6, 'Morning', '2021-04-05'),
(7, 'Afternoon', '2021-05-03'),
(8, 'Evening', '2021-03-18'),
(9, 'Morning', '2021-05-09'),
(10, 'Afternoon', '2021-05-28'),
(11, 'Night', '2021-06-05'),
(12, 'Afternoon', '2021-06-05'),
(13, 'Afternoon', '2021-04-04'),
(14, 'Morning', '2021-04-04'),
(15, 'Evening', '2021-04-04'),
(16, 'Night', '2021-04-04'),
(17, 'Afternoon', '2021-05-06'),
(18, 'Afternoon', '2021-05-05'),
(19, 'Afternoon', '2021-04-03'),
(20, 'Morning', '2021-04-03'),
(21, 'Afternoon', '2021-04-05'),
(22, 'Evening', '2021-05-08'),
(23, 'Evening', '2021-05-06'),
(24, 'Evening', '2021-05-04'),
(25, 'Evening', '2021-04-03'),
(26, 'Afternoon', '2021-06-01'),
(27, 'Morning', '2021-05-07'),
(28, 'Afternoon', '2021-05-07'),
(29, 'Evening', '2021-05-07'),
(30, 'Night', '2021-05-07'),
(31, 'Morning', '2021-05-08'),
(32, 'Afternoon', '2021-05-08'),
(33, 'Night', '2021-05-08'),
(34, 'Morning', '2021-05-06'),
(35, 'Morning', '2021-06-03'),
(36, 'Morning', '2021-05-04'),
(37, 'Afternoon', '2021-05-10'),
(38, 'Morning', '2021-05-10'),
(39, 'Afternoon', '2021-04-06'),
(40, 'Evening', '2021-05-05'),
(41, 'Afternoon', '2021-05-09'),
(42, 'Afternoon', '2021-05-02'),
(43, 'Morning', '2021-05-05'),
(44, 'Afternoon', '2021-05-04'),
(45, 'Afternoon', '2021-04-01'),
(46, 'Evening', '2021-04-01'),
(47, 'Night', '2021-04-01'),
(48, 'Afternoon', '2021-04-02'),
(49, 'Evening', '2021-04-02'),
(50, 'Night', '2021-04-02'),
(51, 'Night', '2021-04-03'),
(52, 'Afternoon', '2021-03-31'),
(53, 'Evening', '2021-03-31'),
(54, 'Evening', '2021-05-03'),
(55, 'Afternoon', '2021-05-21'),
(56, 'Afternoon', '2021-05-17'),
(57, 'Morning', '2021-05-17'),
(58, 'Evening', '2021-05-17'),
(59, 'Evening', '2021-03-16'),
(60, 'Morning', '2021-02-03'),
(61, 'Afternoon', '2021-02-03'),
(62, 'Evening', '2021-02-03'),
(63, 'Night', '2021-02-03'),
(64, 'Morning', '2021-03-15'),
(65, 'Afternoon', '2021-03-15'),
(66, 'Evening', '2021-03-15'),
(67, 'Night', '2021-03-15'),
(68, 'Morning', '2021-03-14'),
(69, 'Afternoon', '2021-03-14'),
(70, 'Evening', '2021-03-14'),
(71, 'Night', '2021-03-14'),
(72, 'Morning', '2021-03-13'),
(73, 'Afternoon', '2021-03-13'),
(74, 'Evening', '2021-03-13'),
(75, 'Night', '2021-03-13'),
(76, 'Night', '2021-05-06'),
(77, 'Afternoon', '2021-06-04'),
(78, 'Afternoon', '2021-06-03'),
(79, 'Afternoon', '2021-04-07'),
(80, 'Evening', '2021-04-07'),
(81, 'Morning', '2021-05-03'),
(82, 'Afternoon', '2021-03-19'),
(83, 'Afternoon', '2021-03-20'),
(84, 'Night', '2021-04-06'),
(85, 'Evening', '2021-04-05'),
(86, 'Night', '2021-04-05'),
(87, 'Morning', '2021-06-17'),
(88, 'Afternoon', '2021-06-17'),
(89, 'Evening', '2021-06-17'),
(90, 'Night', '2021-06-17'),
(91, 'Morning', '2021-04-12'),
(92, 'Afternoon', '2021-04-12'),
(93, 'Evening', '2021-04-12'),
(94, 'Night', '2021-04-12'),
(95, 'Morning', '2021-04-13'),
(96, 'Afternoon', '2021-04-13'),
(97, 'Evening', '2021-04-13'),
(98, 'Night', '2021-04-13'),
(99, 'Evening', '2021-05-10'),
(100, 'Night', '2021-05-04'),
(101, 'Evening', '2021-03-21'),
(102, 'Morning', '2021-03-20'),
(103, 'Evening', '2021-03-20'),
(104, 'Night', '2021-05-03'),
(105, 'Morning', '2021-03-18'),
(106, 'Afternoon', '2021-03-18'),
(107, 'Morning', '2021-04-25'),
(108, 'Afternoon', '2021-04-23'),
(109, 'Afternoon', '2021-05-20'),
(110, 'Evening', '2021-05-20'),
(111, 'Evening', '2021-04-17'),
(112, 'Morning', '2021-06-18'),
(113, 'Afternoon', '2021-06-18'),
(114, 'Afternoon', '2021-03-23'),
(115, 'Morning', '2021-03-23'),
(116, 'Night', '2021-03-23'),
(117, 'Morning', '2021-03-24'),
(118, 'Evening', '2021-03-19'),
(119, 'Morning', '2021-03-29'),
(120, 'Afternoon', '2021-03-29'),
(121, 'Evening', '2021-03-29'),
(122, 'Night', '2021-03-29'),
(123, 'Morning', '2021-03-30'),
(124, 'Afternoon', '2021-03-30'),
(125, 'Evening', '2021-03-30'),
(126, 'Night', '2021-03-30'),
(127, 'Morning', '2021-03-31'),
(128, 'Night', '2021-03-31'),
(129, 'Morning', '2021-04-06'),
(130, 'Evening', '2021-04-06'),
(131, 'Morning', '2021-04-07'),
(132, 'Night', '2021-04-07'),
(133, 'Morning', '2021-04-08'),
(134, 'Afternoon', '2021-04-08'),
(135, 'Evening', '2021-04-08'),
(136, 'Night', '2021-04-08'),
(137, 'Morning', '2021-04-09'),
(138, 'Afternoon', '2021-04-09'),
(139, 'Evening', '2021-04-09'),
(140, 'Night', '2021-04-09'),
(141, 'Morning', '2021-04-10'),
(142, 'Afternoon', '2021-04-10'),
(143, 'Evening', '2021-04-10'),
(144, 'Night', '2021-04-10'),
(145, 'Morning', '2021-04-26'),
(146, 'Afternoon', '2021-04-26'),
(147, 'Evening', '2021-04-26'),
(148, 'Night', '2021-04-26'),
(149, 'Morning', '2021-04-27'),
(150, 'Afternoon', '2021-04-27'),
(151, 'Evening', '2021-04-27'),
(152, 'Night', '2021-04-27'),
(153, 'Morning', '2021-04-28'),
(154, 'Afternoon', '2021-04-28'),
(155, 'Evening', '2021-04-28'),
(156, 'Night', '2021-04-28'),
(157, 'Morning', '2021-04-29'),
(158, 'Afternoon', '2021-04-29'),
(159, 'Evening', '2021-04-29'),
(160, 'Night', '2021-04-29'),
(161, 'Morning', '2021-04-30'),
(162, 'Afternoon', '2021-04-30'),
(163, 'Evening', '2021-04-30'),
(164, 'Night', '2021-04-30'),
(165, 'Morning', '2021-05-01'),
(166, 'Afternoon', '2021-05-01'),
(167, 'Evening', '2021-05-01'),
(168, 'Night', '2021-05-01'),
(169, 'Morning', '2021-05-02'),
(170, 'Evening', '2021-05-02'),
(171, 'Night', '2021-05-02'),
(172, 'Night', '2021-05-05'),
(173, 'Evening', '2021-05-09'),
(174, 'Night', '2021-05-09'),
(175, 'Night', '2021-05-10'),
(176, 'Morning', '2021-05-11'),
(177, 'Afternoon', '2021-05-11'),
(178, 'Evening', '2021-05-11'),
(179, 'Night', '2021-05-11'),
(180, 'Morning', '2021-05-12'),
(181, 'Afternoon', '2021-05-12'),
(182, 'Evening', '2021-05-12'),
(183, 'Night', '2021-05-12'),
(184, 'Morning', '2021-04-14'),
(185, 'Afternoon', '2021-04-14'),
(186, 'Evening', '2021-04-14'),
(187, 'Night', '2021-04-14'),
(188, 'Morning', '2021-04-15'),
(189, 'Afternoon', '2021-04-15'),
(190, 'Evening', '2021-04-15'),
(191, 'Night', '2021-04-15'),
(192, 'Morning', '2021-04-16'),
(193, 'Afternoon', '2021-04-16'),
(194, 'Evening', '2021-04-16'),
(195, 'Night', '2021-04-16'),
(196, 'Morning', '2021-04-17'),
(197, 'Afternoon', '2021-04-17'),
(198, 'Night', '2021-04-17'),
(199, 'Morning', '2021-04-18'),
(200, 'Afternoon', '2021-04-18'),
(201, 'Evening', '2021-04-18'),
(202, 'Night', '2021-04-18'),
(203, 'Morning', '2021-03-16'),
(204, 'Afternoon', '2021-03-16'),
(205, 'Night', '2021-03-16'),
(206, 'Morning', '2021-03-17'),
(207, 'Afternoon', '2021-03-17'),
(208, 'Evening', '2021-03-17'),
(209, 'Night', '2021-03-17'),
(210, 'Night', '2021-03-18'),
(211, 'Morning', '2021-03-19'),
(212, 'Night', '2021-03-19'),
(213, 'Night', '2021-03-20'),
(214, 'Morning', '2021-03-21'),
(215, 'Afternoon', '2021-03-21'),
(216, 'Night', '2021-03-21'),
(217, 'Morning', '2021-03-22'),
(218, 'Afternoon', '2021-03-22'),
(219, 'Evening', '2021-03-22'),
(220, 'Night', '2021-03-22'),
(221, 'Evening', '2021-03-23'),
(222, 'Afternoon', '2021-03-24'),
(223, 'Evening', '2021-03-24'),
(224, 'Night', '2021-03-24'),
(225, 'Morning', '2021-03-25'),
(226, 'Afternoon', '2021-03-25'),
(227, 'Evening', '2021-03-25'),
(228, 'Night', '2021-03-25'),
(229, 'Morning', '2021-03-26'),
(230, 'Afternoon', '2021-03-26'),
(231, 'Evening', '2021-03-26'),
(232, 'Night', '2021-03-26'),
(233, 'Morning', '2021-03-27'),
(234, 'Afternoon', '2021-03-27'),
(235, 'Evening', '2021-03-27'),
(236, 'Night', '2021-03-27'),
(237, 'Morning', '2021-03-28'),
(238, 'Afternoon', '2021-03-28'),
(239, 'Evening', '2021-03-28'),
(240, 'Night', '2021-03-28'),
(241, 'Morning', '2021-06-02'),
(242, 'Afternoon', '2021-06-02'),
(243, 'Evening', '2021-06-02'),
(244, 'Morning', '2021-06-14'),
(245, 'Evening', '2021-06-14'),
(246, 'Evening', '2021-06-05'),
(247, 'Morning', '2021-05-31'),
(248, 'Afternoon', '2021-05-31'),
(249, 'Evening', '2021-05-31'),
(250, 'Night', '2021-05-31'),
(251, 'Morning', '2021-06-01'),
(252, 'Evening', '2021-06-01'),
(253, 'Night', '2021-06-01'),
(254, 'Night', '2021-06-02'),
(255, 'Evening', '2021-06-03'),
(256, 'Night', '2021-06-03'),
(257, 'Morning', '2021-06-04'),
(258, 'Evening', '2021-06-04'),
(259, 'Night', '2021-06-04'),
(260, 'Morning', '2021-06-05'),
(261, 'Morning', '2021-06-06'),
(262, 'Afternoon', '2021-06-06'),
(263, 'Evening', '2021-06-06'),
(264, 'Night', '2021-06-06'),
(265, 'Morning', '2021-05-14'),
(266, 'Morning', '2021-04-19'),
(267, 'Afternoon', '2021-04-19'),
(268, 'Evening', '2021-04-19'),
(269, 'Night', '2021-04-19'),
(270, 'Morning', '2021-04-20'),
(271, 'Afternoon', '2021-04-20'),
(272, 'Evening', '2021-04-20'),
(273, 'Night', '2021-04-20'),
(274, 'Morning', '2021-04-21'),
(275, 'Afternoon', '2021-04-21'),
(276, 'Evening', '2021-04-21'),
(277, 'Night', '2021-04-21'),
(278, 'Morning', '2021-04-22'),
(279, 'Afternoon', '2021-04-22'),
(280, 'Evening', '2021-04-22'),
(281, 'Night', '2021-04-22'),
(282, 'Morning', '2021-04-23'),
(283, 'Evening', '2021-04-23'),
(284, 'Night', '2021-04-23'),
(285, 'Morning', '2021-04-24'),
(286, 'Afternoon', '2021-04-24'),
(287, 'Evening', '2021-04-24'),
(288, 'Night', '2021-04-24'),
(289, 'Afternoon', '2021-04-25'),
(290, 'Evening', '2021-04-25'),
(291, 'Night', '2021-04-25');

-- --------------------------------------------------------

--
-- Структура на таблица `mb_shift_with_assigned_employee`
--

CREATE TABLE `mb_shift_with_assigned_employee` (
  `shiftID` int(10) NOT NULL,
  `employeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `mb_shift_with_assigned_employee`
--

INSERT INTO `mb_shift_with_assigned_employee` (`shiftID`, `employeeID`) VALUES
(123, 40),
(123, 12),
(124, 12),
(124, 40),
(125, 12),
(125, 40),
(6, 12),
(230, 12),
(237, 6),
(246, 6),
(14, 7),
(14, 40),
(231, 7),
(231, 40),
(188, 6),
(196, 9),
(196, 12),
(197, 6),
(197, 9),
(111, 7),
(111, 40),
(198, 12),
(198, 40),
(91, 6),
(92, 7),
(96, 9),
(97, 6),
(186, 9),
(187, 40),
(93, 9),
(94, 40),
(95, 6),
(98, 12),
(184, 6),
(185, 12),
(190, 40),
(192, 6),
(193, 7),
(194, 40),
(195, 7),
(199, 12),
(200, 6),
(201, 12),
(202, 40),
(202, 7),
(189, 40),
(188, 7),
(189, 12),
(190, 7),
(191, 9),
(190, 6),
(188, 12),
(188, 40);

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
-- Indexes for table `mb_shift`
--
ALTER TABLE `mb_shift`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mb_shift_with_assigned_employee`
--
ALTER TABLE `mb_shift_with_assigned_employee`
  ADD KEY `shiftID` (`shiftID`),
  ADD KEY `employeeID` (`employeeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `mb_contract_history`
--
ALTER TABLE `mb_contract_history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `mb_employee`
--
ALTER TABLE `mb_employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `mb_product`
--
ALTER TABLE `mb_product`
  MODIFY `pNum` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `mb_shift`
--
ALTER TABLE `mb_shift`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=292;

--
-- Ограничения за дъмпнати таблици
--

--
-- Ограничения за таблица `mb_contract_history`
--
ALTER TABLE `mb_contract_history`
  ADD CONSTRAINT `contracthistoryFK` FOREIGN KEY (`empid`) REFERENCES `mb_employee` (`id`);

--
-- Ограничения за таблица `mb_shift_with_assigned_employee`
--
ALTER TABLE `mb_shift_with_assigned_employee`
  ADD CONSTRAINT `employee_fk` FOREIGN KEY (`employeeID`) REFERENCES `mb_employee` (`id`),
  ADD CONSTRAINT `shift_fk` FOREIGN KEY (`shiftID`) REFERENCES `mb_shift` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
