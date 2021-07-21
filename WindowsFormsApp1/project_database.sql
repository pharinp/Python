-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 21, 2021 at 03:23 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Table structure for table `home`
--

CREATE TABLE `home` (
  `id` int(15) NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `product_unit` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `unit` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `amount` float NOT NULL,
  `price` float NOT NULL,
  `home_user` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `edit_user` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `comment` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `time` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `home`
--

INSERT INTO `home` (`id`, `name`, `product_unit`, `unit`, `amount`, `price`, `home_user`, `edit_user`, `comment`, `time`) VALUES
(1, 'เห็ดขอนขาว', 'กิโลกรัม', '100', 3, 300, 'ปริญ', '', '', '2021-06-14 16:44:43'),
(2, 'ทุเรียน', 'กิโลกรัม', '140', 22, 3080, 'นฏกร', '', 'หมอนทอง', '2021-06-14 17:27:46'),
(3, 'เห็ดนางฟ้า', 'กิโลกรัม', '69', 4, 276, 'ปริญ', '', '', '2021-06-14 17:39:49'),
(4, 'มังคุด', 'กิโลกรัม', '22', 80, 1760, 'นฏกร', 'แก้ไขโดย admin', 'มังคุดท้ายปีอร่อยมาก', '2021-06-14 17:40:48'),
(6, 'เห็ดขอนขาว', 'กิโลกรัม', '100', 23, 2300, 'ชวดล', '', '', '2021-06-15 16:28:38'),
(7, 'เห็ดฟาง', 'กิโลกรัม', '80', 10, 800, 'นฏกร', '', '', '2021-06-15 17:05:05'),
(8, 'เงาะโรงเรียน', 'กิโลกรัม', '35', 12, 420, 'นฏกร', '', '', '2021-06-17 16:10:43'),
(9, 'เห็ดฟาง', 'กิโลกรัม', '65', 12, 780, 'นฏกร', '', '', '2021-06-17 16:16:55'),
(10, 'เห็ดฟาง', 'กิโลกรัม', '65', 14, 910, 'ปริญ', '', '', '2021-06-17 16:18:57'),
(11, 'เห็ดฟาง', 'กิโลกรัม', '50', 10, 500, 'นฏกร', 'แก้ไขโดย ปริญ', '', '2021-06-18 19:04:55'),
(12, 'เห็ดขอนขาว', 'กิโลกรัม', '100', 3, 300, 'ปริญ', '', '', '2021-06-20 11:23:02'),
(13, 'น้ำส้มคั้น', 'แพ็ค', '290', 22, 6380, 'อังกูร', '', 'แพ็คละ 24 ขวด', '2021-06-20 11:25:54'),
(14, 'เห็ดฟาง', 'กิโลกรัม', '52', 23, 1196, 'อังกูร', '', '', '2021-06-20 11:27:08'),
(15, 'เห็ดนางฟ้า', 'กิโลกรัม', '80', 20, 1600, 'ปริญ', 'แก้ไขโดย ปริญ', '', '2021-06-20 18:22:35'),
(16, 'เห็ดขอนขาว', 'กิโลกรัม', '100', 2, 200, 'นฏกร', '', '', '2021-06-24 13:22:02'),
(17, 'เห็ดขอนขาว', 'กิโลกรัม', '100', 5, 500, 'admin', '', '', '2021-07-03 10:09:50');

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `member_id` int(20) NOT NULL,
  `member_user` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `member_password` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `member_name` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `member_lastname` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `member_email` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `member_phone` text COLLATE utf8_unicode_ci NOT NULL,
  `member_address` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `member_status` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `member_date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`member_id`, `member_user`, `member_password`, `member_name`, `member_lastname`, `member_email`, `member_phone`, `member_address`, `member_status`, `member_date`) VALUES
(1, 'parinp', '123456', 'ปริญ', 'ภูกาบเพชร', 'pharinp@gmail.com', '0849746701', 'มหาวิทยาลัยขอนแก่น', 'ADMIN', '2021-06-14 16:43:44'),
(2, 'chawadon', '123456', 'ชวดล', 'บรรจง', 'chawadon@gmail.com', '0845697452', 'มุกดาหาร', 'USER', '2021-06-14 17:20:12'),
(3, 'angkun', '147852', 'อังกูร', 'แก้ววันนา', 'angkun@gmail.com', '0213645849', 'อุบลราชธานี', 'USER', '2021-06-14 17:25:52'),
(4, 'natakorn', '123456', 'นฏกร', 'ประมายันต์', 'nkp.kku@gmail.com', '0838870888', 'บ้านเป็ด ต.บ้านเป็ด อ.เมือง จ.ขอนแก่น 40000', 'USER', '2021-06-14 17:38:51'),
(5, 'ADMIN', 'admin', 'admin', 'test', 'admin@gmail.com', '0123456789', 'มหาวิทยาลัยขอนแก่น', 'ADMIN', '2021-07-03 07:00:00'),
(6, 'usertest', '0258', 'user', 'user', 'user@gmail.com', '0789456123', 'มหาวิทยาลัยขอนแก่น', 'USER', '2021-07-03 07:05:55');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `home`
--
ALTER TABLE `home`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`member_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `home`
--
ALTER TABLE `home`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `member_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
