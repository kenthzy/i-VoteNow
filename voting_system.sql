-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 08, 2024 at 06:16 AM
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
-- Database: `voting_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`id`, `name`, `username`, `password`) VALUES
(1, 'Kenneth Gonzales', 'admin', 'admin123'),
(3, 'christian pascual', 'chris', 'pascual19'),
(4, 'shai jade', 'riverashairen', 'password'),
(6, 'shai', 'shaaai', 'password');

-- --------------------------------------------------------

--
-- Table structure for table `candidates`
--

CREATE TABLE `candidates` (
  `id` int(11) NOT NULL,
  `position` varchar(50) DEFAULT NULL,
  `candidate_name` varchar(100) DEFAULT NULL,
  `vote_count` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `candidates`
--

INSERT INTO `candidates` (`id`, `position`, `candidate_name`, `vote_count`) VALUES
(1, 'president', 'KENNETH GONZALES', 4),
(2, 'president', 'JUSTIN FELIZARIO', 1),
(3, 'president', 'SHAIREN JADE RIVERA', 3),
(4, 'president', 'CHRISTIAN PASCUAL', 1),
(5, 'vice-president', 'ALEXANDER SANTIAGO', 2),
(6, 'vice-president', 'MARIA DELGADO', 4),
(7, 'vice-president', 'JONATHAN CRUZ', 2),
(8, 'vice-president', 'ELENA VASQUEZ', 1),
(9, 'secretary', 'FRANCISCO MENDOZA', 3),
(10, 'secretary', 'ISABEL GARCIA', 2),
(11, 'secretary', 'CARLOS RIVERA', 2),
(12, 'secretary', 'LUCIA FERNANDEZ', 2),
(13, 'treasurer', 'MIGUEL TORRES', 1),
(14, 'treasurer', 'CAMILA MARTINEZ', 2),
(15, 'treasurer', 'NICHOLAS RAMIREZ', 2),
(16, 'treasurer', 'SOPHIA MORENO', 3),
(17, 'auditor', 'DANIEL ORTIZ', 3),
(18, 'auditor', 'VICTORIA HERNANDEZ', 3),
(19, 'auditor', 'JAVIER LOPEZ', 2),
(20, 'auditor', 'GABRIELA FLORES', 1),
(21, 'publicInformationOffice', 'ANTHONY GOMEZ', 0),
(22, 'publicInformationOffice', 'VALERIA DIAZ', 4),
(23, 'publicInformationOffice', 'DAVID PEREZ', 2),
(24, 'publicInformationOffice', 'ISABELLA SANTOS', 3),
(25, 'partylist', 'BAYANIHAN PARTYLIST', 3),
(26, 'partylist', 'SANDIGAN PARTYLIST', 4),
(27, 'partylist', 'KABABAIHAN PARTYLIST', 1),
(28, 'partylist', 'KALIKASAN PARTYLIST', 1);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `has_voted` tinyint(1) DEFAULT 0,
  `name` varchar(255) DEFAULT NULL,
  `student_id` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `email`, `password`, `created_at`, `has_voted`, `name`, `student_id`) VALUES
(1, 'kenthgnzls@gmail.com', '$2y$10$WlyPXNacWVTGSNodx3dzou4Lcmv.GeQHCRT/gDT1Qa728T/lgh0OW', '2024-05-31 15:58:00', 1, 'Kenneth Gonzales', '22-01531'),
(2, 'Jess@hotmail.com', '$2y$10$x7bxbT/Oz69XlElNSiZReeQNBqUYKtxyF6a1kxuOQ6CITIt8Tl/BC', '2024-06-04 04:57:49', 0, 'Jesus Jr. Gomez', '22-01535'),
(3, 'Riz@hotmail.com', '$2y$10$q7oZxjGRLN.bh9M.OwbVAOkD/eS92J0i1VtMF4uFsq0tNQvtkcYm2', '2024-06-04 09:38:52', 0, 'Kenneth Rizal', '22-01534'),
(4, 'Pas@gmail.com', '$2y$10$wv39X0kvPW4YVdMG8jHUS.dKKZLOuEp37FWICUYsDafmNzWEO0buW', '2024-06-04 10:09:11', 1, 'KENNETH GOMEZ', '22-01536'),
(5, 'luna@gmail.com', '$2y$10$evsAspDMJ7RAWlNXRBdhOua2BNt27c5aSxogreGbbWMD3b7FV6w7y', '2024-06-05 15:46:10', 1, 'HENERAL LUNA', '22-01589'),
(6, 'justin@gmail.com', '$2y$10$i5P/FjyMECJ6fKKOll9ljuIRTvhU1cuHtIN3LaYx9TgDQJioTWzkC', '2024-06-06 05:52:28', 1, 'JUSTIN FELIZARIO', '22-01962'),
(7, 'riverajadeshairen@gmail.com', '$2y$10$iAgebJGSp8Cwu3AHe8r.rON2kfnr53VEYh0Os8KeXragg/xt4Jpr6', '2024-06-06 06:04:31', 1, 'Shairen Rivera', '22-00871'),
(8, 'jadeshairen@gmail.com', '$2y$10$XymMqgvyDBDOwV686Ccoie8CukWekXSNswqBT4kWacuY5WL1Fo0N6', '2024-06-06 06:08:00', 1, 'shai rivera', '22-00887'),
(9, 'shashai@gmail.com', '$2y$10$zhEVAYpveVzz9bP73Ow1we52imzyUpRf/nUtBBn2LvnQD0zTNltqG', '2024-06-06 09:13:11', 1, 'jade shairen', '22-88887'),
(10, 'juztinelagutin23@gmail.com', '$2y$10$sK.9YS7AfNWix4MTkQk5eOXe34NLd3E5h43ScNIfekB2izwIl.P8S', '2024-06-06 09:24:28', 1, 'juztine lagutin', '22-01128'),
(11, 'sacsi@gmail.com', '$2y$10$HbLFrhwr44ULe4J.LtJxQeJwW2hwWGuHlqR4loPCYDZmz3KU2GJX2', '2024-06-06 11:28:25', 1, 'Kenneth Sacsi', '22-01546'),
(12, 'luis@gmail.com', '$2y$10$gqFqwVcM4nmjtCNkHztssOkVFIzTPY2VQojd6CZu2clge5XuBM7Yu', '2024-06-06 13:16:19', 0, 'Lorenzo Luis', '22-01588');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `candidates`
--
ALTER TABLE `candidates`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `candidates`
--
ALTER TABLE `candidates`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
