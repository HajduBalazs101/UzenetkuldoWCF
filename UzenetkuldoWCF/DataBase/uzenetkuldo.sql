-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 03, 2026 at 05:53 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uzenetkuldo`
--

-- --------------------------------------------------------

--
-- Table structure for table `uzenet`
--

CREATE TABLE `uzenet` (
  `Id` int(11) NOT NULL,
  `Szoveg` text NOT NULL,
  `KüldesiIdo` datetime NOT NULL,
  `UzenetTipus` varchar(50) NOT NULL,
  `Telefon` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- Dumping data for table `uzenet`
--

INSERT INTO `uzenet` (`Id`, `Szoveg`, `KüldesiIdo`, `UzenetTipus`, `Telefon`, `Email`) VALUES
(2, 'Adategyeztetés céljából kérjük, keresse fel honlapunkat: https://www.ceghonlap.hu', '2026-08-27 19:05:38', 'Email', NULL, 'ugyfelcim1@mail.hu'),
(3, 'Vigyázat, csalók!!!\r\nIsmeretlenek a cégünk nevével visszaélve bizalmas információk (jelszavak, szerződésadatok) megadását kérhetik öntől teefonon vagy emailben. Felhívjuk figyelmét, hogy ilyen információt senkitől sem kérünk, ezért ne dőljön be a csalóknak!', '2026-09-13 10:07:19', 'SMS', '+36205009301', NULL),
(4, 'Vigyázat, csalók!!!\r\nIsmeretlenek a cégünk nevével visszaélve bizalmas információk (jelszavak, szerződésadatok) megadását kérhetik öntől teefonon vagy emailben. Felhívjuk figyelmét, hogy ilyen információt senkitől sem kérünk, ezért ne dőljön be a csalóknak!', '2026-09-13 10:07:19', 'Email', NULL, 'kiemeltugyfel@mail.com'),
(5, 'Új üzenet mentése', '2026-10-03 16:00:00', 'Email', '', 'create@teszt.hu');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `uzenet`
--
ALTER TABLE `uzenet`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `uzenet`
--
ALTER TABLE `uzenet`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
