-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8111
-- Generation Time: Jan 01, 2022 at 04:58 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `quanlykhoahoc`
--

-- --------------------------------------------------------

--
-- Table structure for table `approle`
--

CREATE TABLE `approle` (
  `Id` varchar(100) NOT NULL,
  `Name` text DEFAULT NULL,
  `NormalizedName` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `Discriminator` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `approle`
--

INSERT INTO `approle` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`, `Discriminator`) VALUES
('166b3f9d-a7f7-4154-8374-30980d66df15', 'Manager', 'MANAGER', '4c95fb39-f180-4542-adfa-8afa8979e275', 'IdentityRole'),
('6eae9fb2-30e2-4b46-996a-69cee71bb287', 'Admin', 'ADMIN', 'cdc84ebc-fc85-4493-89ae-057b95338b5f', 'IdentityRole'),
('797a66f0-0bdd-4043-b9c0-62f01661d189', 'Viewer', 'VIEWER', '0cd5b9b1-c993-4445-9bc3-95a948904f39', 'IdentityRole');

-- --------------------------------------------------------

--
-- Table structure for table `approleclaim`
--

CREATE TABLE `approleclaim` (
  `Id` int(11) NOT NULL,
  `RoleId` text DEFAULT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `approleclaim`
--

INSERT INTO `approleclaim` (`Id`, `RoleId`, `ClaimType`, `ClaimValue`) VALUES
(1, '6eae9fb2-30e2-4b46-996a-69cee71bb287', 'quanly', 'user'),
(3, 'e5d797ac-120f-47b1-9f25-dba92a9e1342', 'edit', 'user'),
(5, '166b3f9d-a7f7-4154-8374-30980d66df15', 'khongquanly', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `appuser`
--

CREATE TABLE `appuser` (
  `Id` varchar(767) NOT NULL,
  `UserName` text DEFAULT NULL,
  `NormalizedUserName` text DEFAULT NULL,
  `Email` text DEFAULT NULL,
  `NormalizedEmail` text DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `address` varchar(200) DEFAULT NULL,
  `birthday` datetime DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `avatar` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appuser`
--

INSERT INTO `appuser` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `address`, `birthday`, `gender`, `avatar`) VALUES
('53b4d55f-4957-47af-b5a5-867752ff789b', 'NguyenVanA', 'NGUYENVANA', 'abcd@gmail.com', 'ABCD@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEJtYEgFEQaiCn3Zl8FNyeFG4r6lGqHQJZItHcZBF+Ad2MVCuNggGZQHLeXlfqbbu1g==', '6ITMNR54AKBGH3U4BDCJIITQENPELOIS', 'f3964e92-52d3-445d-97f8-848183553fe7', NULL, 0, 0, NULL, 1, 0, NULL, '2021-12-01 00:00:00', 'Nam', 'avatar3.png'),
('677aa397-36b0-4676-a955-7e6c4297fb3a', 'TranPhanHaiDang', 'TRANPHANHAIDANG', 'haidangtr15012001@gmail.com', 'HAIDANGTR15012001@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEHU/i3B1VXzyAQ8WhlMJr9NfdOKGReMiEHbPwAW7rLDoP1zY2FDhlXMMzyRXtv6Kgg==', 'T77DV3Y4DASQLVAHKZUGBCUMGMNXIU6M', '13933af4-916c-4c5d-97ee-7a956aaa4f2e', NULL, 0, 0, NULL, 1, 0, NULL, '2001-01-15 00:00:00', 'Nam', 'avatar1.png'),
('71a4c50d-fc68-474a-895b-8682f0141b93', 'KhanhDuy', 'KHANHDUY', '19521420@gm.uit.edu.vn', '19521420@GM.UIT.EDU.VN', 1, 'AQAAAAEAACcQAAAAENb1Pgwlh5SCkeLef1AH1W4QYJC4iS1syKbOZJu0ai39XXyoGjGZA7zpoCzGOe+Ezw==', 'J3RIIU7AGPH4EMKDZ5CGPE2ZTRQR3RBK', '346b9806-4410-44ab-b6e4-629ace18799d', NULL, 0, 0, NULL, 1, 0, NULL, '2001-03-18 00:00:00', 'Nam', 'avatar2.png'),
('9c994d92-d7c9-4597-b379-ce8551183d15', 'GiangBanh', 'GIANGBANH', '19521443@gm.uit.edu.vn', '19521443@GM.UIT.EDU.VN', 1, 'AQAAAAEAACcQAAAAEHAIakBwVv6yNKhG0hms38pox8qKru135S9XttNzPdaybXfVhhuGqKm88GE79LcShQ==', 'VUZAPVG66VUGG45GYH77ZTP6ZGEQHVTI', 'd843d277-90f4-4200-86a5-857faabce17c', NULL, 0, 0, NULL, 1, 0, NULL, '2001-01-01 00:00:00', 'Nam', 'avatar3.png'),
('a88ce81e-968c-4be8-83a8-234be543fa90', '19521319@gm.uit.edu.vn', '19521319@GM.UIT.EDU.VN', '19521319@gm.uit.edu.vn', '19521319@GM.UIT.EDU.VN', 1, 'AQAAAAEAACcQAAAAED1vDZ2bRHnM6Lby4s9kCoawvkqUKg7m9FVcZ2mFBZi3O87KBnTfioMLrfqp0w5mkw==', 'HWOOIVCXGEJ3X6H73HPFRB5OIP2KXIVO', '69cce740-44a4-4256-95cd-198818aa67b4', '+84123456', 0, 0, NULL, 1, 0, 'Đồng Tháp', '2001-01-15 20:32:00', NULL, 'avatar3.png'),
('f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 'HaiDang', 'HAIDANG', 'abc@gmail.com', 'ABC@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEEYoVGDZ69shx2kvMJn/G/UqYP/s6cZJzvsu8pvFoOGUY80kD5NeXxdF/tpmR8dVxw==', '6H33K3OEUUPEWI67YNK5JGPCBJ72G5YO', 'eabd359d-70e4-406b-91e6-5237d759fe82', '123456789', 0, 0, NULL, 1, 0, 'abc', '2021-12-14 23:28:00', NULL, 'avatar3.png');

-- --------------------------------------------------------

--
-- Table structure for table `appuserclaim`
--

CREATE TABLE `appuserclaim` (
  `Id` int(11) NOT NULL,
  `UserId` text DEFAULT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `appuserlogin`
--

CREATE TABLE `appuserlogin` (
  `UserId` varchar(100) NOT NULL,
  `LoginProvider` text DEFAULT NULL,
  `ProviderKey` text DEFAULT NULL,
  `ProviderDisplayName` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appuserlogin`
--

INSERT INTO `appuserlogin` (`UserId`, `LoginProvider`, `ProviderKey`, `ProviderDisplayName`) VALUES
('33bf0004-8313-44fe-a5d5-0aecf2ea7a58', 'Google', '116194913539978270769', 'Google'),
('a634d1cd-f8c5-42ca-ac4c-85f86c25de36', 'Facebook', '3079733455641739', 'Facebook'),
('a88ce81e-968c-4be8-83a8-234be543fa90', 'Google', '116194913539978270769', 'Google'),
('e9af451a-fc6b-415d-8533-bef3956d148b', 'Facebook', '3079733455641739', 'Facebook');

-- --------------------------------------------------------

--
-- Table structure for table `appuserrole`
--

CREATE TABLE `appuserrole` (
  `UserId` varchar(100) NOT NULL,
  `RoleId` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `appuserrole`
--

INSERT INTO `appuserrole` (`UserId`, `RoleId`) VALUES
('71a4c50d-fc68-474a-895b-8682f0141b93', '6eae9fb2-30e2-4b46-996a-69cee71bb287'),
('9c994d92-d7c9-4597-b379-ce8551183d15', '166b3f9d-a7f7-4154-8374-30980d66df15'),
('9c994d92-d7c9-4597-b379-ce8551183d15', '6eae9fb2-30e2-4b46-996a-69cee71bb287'),
('a88ce81e-968c-4be8-83a8-234be543fa90', '0444a10f-bbc4-408e-b805-e535cb3d4a98'),
('a88ce81e-968c-4be8-83a8-234be543fa90', '166b3f9d-a7f7-4154-8374-30980d66df15'),
('a88ce81e-968c-4be8-83a8-234be543fa90', '7de294a7-6391-40bc-a16c-7418567216ab'),
('a88ce81e-968c-4be8-83a8-234be543fa90', 'e5d797ac-120f-47b1-9f25-dba92a9e1342'),
('D1DFEBA3-BBA8-48D9-87E6-8EE1AD1C9F14', 'A44641C4-B68C-43D8-8ECD-E001276D9148'),
('f5ebe639-df16-4e3e-bbc9-8e7dc9400707', '6eae9fb2-30e2-4b46-996a-69cee71bb287');

-- --------------------------------------------------------

--
-- Table structure for table `appusertoken`
--

CREATE TABLE `appusertoken` (
  `UserId` varchar(100) NOT NULL,
  `LoginProvider` text DEFAULT NULL,
  `Name` text DEFAULT NULL,
  `Value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `cmtId` int(11) NOT NULL,
  `userId` varchar(767) NOT NULL,
  `courseId` int(11) NOT NULL,
  `evaluate` float NOT NULL,
  `content` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `comment`
--

INSERT INTO `comment` (`cmtId`, `userId`, `courseId`, `evaluate`, `content`) VALUES
(1, '677aa397-36b0-4676-a955-7e6c4297fb3a', 14, 9, 'abc'),
(2, 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 14, 10, 'text'),
(3, 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 14, 1, 'text'),
(4, 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 2, 9, 'text');

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `courseId` int(11) NOT NULL,
  `courseName` varchar(50) NOT NULL,
  `discription` varchar(1000) NOT NULL,
  `price` int(11) NOT NULL DEFAULT 0,
  `originalPrice` int(11) NOT NULL,
  `imgCourse` varchar(5000) NOT NULL,
  `totalTime` varchar(100) NOT NULL,
  `totalStudent` int(11) NOT NULL,
  `topicId` int(11) NOT NULL,
  `discountId` int(11) NOT NULL,
  `rating` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`courseId`, `courseName`, `discription`, `price`, `originalPrice`, `imgCourse`, `totalTime`, `totalStudent`, `topicId`, `discountId`, `rating`) VALUES
(1, 'Lập trình hướng đối tượng trong C++', 'Khóa học C++ OOP giúp các lập trình viên học được kỹ thuật lập trình mà tất cả logic, yêu cầu thực tế đều được xây dựng xoay quanh các đối tượng. Hiểu được cách thức hoạt động của C++ OOP sẽ làm đơn giản hóa việc bảo trì và dễ dàng mở rộng trong việc thiết kế phần mềm.', 200000, 400000, 'https://drive.google.com/uc?id=1tg8t9mU6fK2NiIaoOpZGDBqKyDHl3GWK ', '100 giờ', 5000, 3, 3, 9),
(2, 'Truyền thông và Mạng máy tính', 'Khóa học cung cấp cho lập trình viên những kiến thức cơ bản và dễ hiểu về mạng máy tính và truyền thông dữ liệu.', 250000, 500000, 'https://drive.google.com/uc?id=1M13QkBMNWf3mMAtY73_6j6VzfIwyQ8ou', '115 giờ 15 phút', 545, 3, 1, 7),
(3, 'Phần mềm máy tính', 'Phần mềm luôn là công cụ cần thiết trong mọi lĩnh vực, khóa học này sẽ giúp bạn hiểu được các khái niệm về phần mềm và các phần mềm phổ biến hiện nay.\r\n', 400000, 800000, 'https://drive.google.com/uc?id=1OGubr6XYS_IamIC1c4BkmLipc8izjn1O', '80 giờ', 890, 5, 3, 9),
(4, 'Phần cứng máy tính', 'Khóa học này tập trung vào việc cung cấp các kiến thức chung về các bộ phận của máy tính để bạn có thể áp dụng vào việc lựa chọn và sử dụng máy tính.\r\n', 400000, 500000, 'https://drive.google.com/uc?id=1V9EOdu9mY2spgIgOVo30bUyxpaO9H9Rt', '150 giờ', 545, 3, 2, 8),
(5, 'C cho người mới bắt đầu', 'Khóa học lập trình C cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản và là nền tảng để bạn đi xa hơn trên con đường lập trình.\r\n', 375000, 750000, 'https://drive.google.com/uc?id=1yNm40INiL3wWtgHmO6HY9k81MrKldvdt', '200 giờ', 1500, 4, 1, 9),
(6, 'C++ cho người mới bắt đầu', 'Khóa học lập trình C++ cơ bản cho người mới bắt đầu. Khóa học này sẽ cung cấp những kiến thức cơ bản, dễ hiểu nhất về ngôn ngữ lập trình C++.\r\n', 250000, 500000, 'https://drive.google.com/uc?id=1_o-6-BiHJ_HDATs6LDDcq1ZdNLtLtxr3', '200 giờ', 2000, 4, 4, 10),
(7, 'Làm quen với SQL', 'Khóa học này sẽ giúp các lập trình viên nắm được nguyên tắc, cú pháp và cách thức hoạt động của SQL (Structured Query Language).\r\n', 520000, 650000, 'https://drive.google.com/uc?id=1nz4sj-8dFyHBhY3o_guQq2--rTtMTSvp', '150 giờ', 2000, 4, 2, 9),
(8, 'Javascript căn bản', 'Giúp học viên nắm vững các nguyên tắc và cú pháp cơ bản trong Javascript - ngôn ngữ lập trình phổ biến nhất trên thế giới.\r\n', 600000, 750000, 'https://drive.google.com/uc?id=174z_MRZCD7REQnDI7UjWVI7s1h9-RpRW', '175 giờ ', 1500, 4, 5, 7),
(9, 'Python cơ bản', 'Khóa học lập trình Python cơ bản với các bài tập và lý thuyết dễ hiểu, học xong bạn có thể tự tin để tới với các chủ đề nâng cao hơn của Python.\r\n', 440000, 550000, 'https://drive.google.com/uc?id=1XOnqOxas8vt7wTv_n-hJiUR59mVWcLeP', '130 giờ', 1300, 5, 2, 9),
(10, 'C# cơ bản', 'Khóa học lập trình C# kèm thực hành, khóa học sẽ giúp bạn làm quen với lập trình cũng như tạo nền tảng tư duy và kỹ năng cơ bản khi giải các bài tập.\r\n', 600000, 750000, 'https://drive.google.com/uc?id=1BWVWRTBPXZOK62y3bGAWwwZDRJv6zh7B', '140 giờ', 1500, 5, 2, 10),
(11, 'Java cơ bản', 'Khóa học lập trình Java cơ bản cho người mới bắt đầu, khóa học này sẽ là nền tảng cho khóa Java nâng cao để tiến tới Java Web hay lập trình Android, …\r\n', 400000, 800000, 'https://drive.google.com/uc?id=1indBclBHBP3iSROrvblYg7XeH6iEusEf', '200 giờ', 2500, 4, 4, 9),
(12, 'Thuật toán căn bản', 'Với khóa học thuật toán cơ bản, bạn sẽ học được cách tư duy và giải quyết các bài toán lập trình cơ bản mà một lập trình viên cần có.\r\n', 425000, 850000, 'https://drive.google.com/uc?id=1N0wa9aqjhieH4tLPvgY6j5gwRyTiZEQr', '175 giờ', 500, 6, 1, 8),
(13, 'Thực hành với SQL', 'Khóa học này sẽ giúp bạn biết về một số chức năng chính cần thiết để sắp xếp, lọc và phân loại thông tin trong cơ sở dữ liệu quan hệ, mở rộng bộ công cụ SQL của bạn và giúp bạn có khả năng giải quyết các vấn đề phức tạp hơn thông qua bộ công cụ này. Yêu cầu: Bạn cần hoàn thành khóa Làm quen với SQL để có kiến thức cơ bản trước khi\r\n', 640000, 800000, 'https://drive.google.com/uc?id=1VmBM07dQc1zkpdhG6c6ZlvolXnSlzrLi', '250 giờ 15 phút', 1400, 6, 2, 9),
(14, 'Cấu trúc dữ liệu và giải thuật', 'Khóa học này sẽ giúp các bạn hiểu thuật toán cũng như hiểu rõ bản chất của các cấu trúc dữ liệu - điều kiện để trở thành lập trình viên giỏi.\r\n', 100000, 200000, 'https://drive.google.com/uc?id=14G1yOY1SO6GahAjK6zIE1DbD9m-cR85X', '150 giờ', 2000, 4, 3, 8),
(15, 'Lập trình hướng đối tượng trong Java', 'Lập trình hướng đối tượng (Object-Oriented-Programming) là phương pháp lập trình dựa trên đối tượng để tìm ra bản chất của vấn đề. Khóa học Java OOP giúp các lập trình viên học được kỹ thuật lập trình mà tất cả logic, yêu cầu thực tế đều được xây dựng xoay quanh các đối tượng. Hiểu được cách thức hoạt động của Java OOP sẽ làm đơn giản hóa việc bảo trì và dễ dàng mở rộng trong việc thiết kế phần mềm.\r\n', 400000, 800000, 'https://drive.google.com/uc?id=1KuFnvgVqfelPZ4x7NEMfPB6OmqheImDU', '200 giờ', 1500, 6, 3, 8),
(16, 'C++ nâng cao', 'Khóa học lập trình C++ nâng cao sẽ giúp bạn hiểu sâu hơn về C++ với một số khái niệm như con trỏ, mảng, cấp phát bộ nhớ động, struct,…\r\n', 680000, 850000, 'https://drive.google.com/uc?id=12GS1gi1IlxvHGItqBOtN8ahlrLWd97Ql', '250 giờ', 545, 7, 5, 9);

-- --------------------------------------------------------

--
-- Table structure for table `discount`
--

CREATE TABLE `discount` (
  `discountId` int(11) NOT NULL,
  `discription` varchar(1000) NOT NULL,
  `time` datetime NOT NULL,
  `sale` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `discount`
--

INSERT INTO `discount` (`discountId`, `discription`, `time`, `sale`) VALUES
(1, 'Khuyến mãi ngày tựu trường', '2021-12-16 04:49:04', 0.5),
(2, 'Kỉ niệm một năm thành lập', '2021-11-01 00:00:00', 0.2),
(3, 'Khuyến mãi ngày tết', '2021-11-02 00:00:00', 0.5),
(4, 'Siêu sale back to school', '2021-11-20 00:00:00', 0.5),
(5, 'Mừng trung thu', '2021-11-01 00:00:00', 0.2),
(6, 'Khuyến mãi lần đầu đăng kí', '2021-11-01 00:00:00', 0.5);

-- --------------------------------------------------------

--
-- Table structure for table `exercise`
--

CREATE TABLE `exercise` (
  `exerciseId` int(11) NOT NULL,
  `content` varchar(1000) NOT NULL,
  `deadline` date NOT NULL,
  `lessonId` int(11) NOT NULL,
  `userId` varchar(767) NOT NULL,
  `exerciseName` varchar(500) NOT NULL DEFAULT '',
  `input` varchar(500) NOT NULL DEFAULT '',
  `output` varchar(500) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `exercise`
--

INSERT INTO `exercise` (`exerciseId`, `content`, `deadline`, `lessonId`, `userId`, `exerciseName`, `input`, `output`) VALUES
(1, 'Nội dung 1', '2021-12-15', 75, '9c994d92-d7c9-4597-b379-ce8551183d15', 'Bài tập 1', '', ''),
(2, 'bai tap 2', '2021-12-17', 1, '9c994d92-d7c9-4597-b379-ce8551183d15', 'khoiwe động', 'nhạp mảng', 'array aaaaaa'),
(3, 'làm quen với mảng', '2021-12-30', 1, '9c994d92-d7c9-4597-b379-ce8551183d15', 'bài tập 2 ', 'adadadad', 'adadada'),
(4, 'adadada', '2021-12-30', 1, '9c994d92-d7c9-4597-b379-ce8551183d15', 'biến và biểu thức', 'aaaaaa x=5', 'adadadadad');

-- --------------------------------------------------------

--
-- Table structure for table `exerciseinuser`
--

CREATE TABLE `exerciseinuser` (
  `exerciseId` int(11) NOT NULL,
  `userId` varchar(767) NOT NULL,
  `submit` datetime NOT NULL,
  `scores` float NOT NULL,
  `content` text NOT NULL,
  `status` varchar(100) NOT NULL DEFAULT 'Chưa chấm điểm'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `exerciseinuser`
--

INSERT INTO `exerciseinuser` (`exerciseId`, `userId`, `submit`, `scores`, `content`, `status`) VALUES
(2, 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', '2021-12-27 04:39:16', 0, '\r\n            bnnbv', 'Đã chấm điểm');

-- --------------------------------------------------------

--
-- Table structure for table `lesson`
--

CREATE TABLE `lesson` (
  `lessonId` int(11) NOT NULL,
  `title` varchar(200) NOT NULL,
  `content` text NOT NULL,
  `courseId` int(11) NOT NULL,
  `description` text NOT NULL,
  `captionLink` varchar(500) NOT NULL DEFAULT '',
  `link` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lesson`
--

INSERT INTO `lesson` (`lessonId`, `title`, `content`, `courseId`, `description`, `captionLink`, `link`) VALUES
(1, 'Lớp và đối tượng', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 1, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(2, 'Biến tĩnh và phương thức tĩnh', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 1, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(3, 'Tính đóng gói', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chươ', 1, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(4, 'Tính kế thừa', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau: \r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chư', 1, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(5, 'Mối quan hệ giữa các đối tượng', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        re', 1, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(6, 'Tính đa hình kế thừa', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        re', 1, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(7, 'Truyền thông máy tính và dữ liệu', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 2, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(8, 'Cáp mạng và phân loại', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 2, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(9, 'Thiết bị chuyển mạch, định tuyến và mô hình đấu nối', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau: \r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chương trình:\r\nHello from SubClass', 2, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(10, 'Các loại hình mạng và phân loại', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau: \r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chương trình:\r\nHello from SubClass', 2, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(11, 'Các công nghệ phổ biến trong truyền tải mạng', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        return 0;\r\n}\r\n', 2, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(12, 'Các thông số trong truyền tải mạng', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        return 0;\r\n}\r\n', 2, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(13, 'Giới thiệu về phần mềm', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 3, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(14, 'Phần mềm hệ thống', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 3, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(15, 'Giới thiệu về hệ điều hành', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau: \r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chương trình:\r\nHello from SubClass', 3, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(16, 'Phần mềm ứng dụng: Trình duyệt web', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau: \r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chương trình:\r\nHello from SubClass', 3, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(17, 'Phần mềm ứng dụng: Phần mềm văn phòng', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        return 0;\r\n}\r\n', 3, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(18, 'Phần mềm ứng dụng: Trình soạn thảo và lập trình', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        return 0;\r\n}\r\n', 3, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(19, 'Giới thiệu về máy tính', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 4, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(20, 'Đơn vị xử lý trung tâm', 'Sử dụng phương pháp lập trình hướng đối tượng để giải quyết bài tập sau:\r\nBạn hãy viết chương trình nhập từ bàn phím chiều dài và chiều rộng của một hình chữ nhật và hiển thị ra màn hình:\r\nArea = {P1}\r\nPerimeter = {P2}\r\nVới {P1} và {P2} lần lượt là diện tích và chu vi của hình chữ nhật đó.\r\nVí dụ nếu bạn nhập:\r\n4.5\r\n5.5\r\nThì màn hình sẽ hiển thị ra:\r\nArea: 24.75\r\nPerimeter: 20', 4, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(21, 'Nguồn điện', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau: \r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chương trình:\r\nHello from SubClass', 4, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(22, 'Bo mạch chính', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau: \r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\nLý thuyết\r\nTrước hết bạn hãy nhìn vào đoạn code có sẵn, phương thức display() ở lớp cha sẽ chỉ hiển thị được thông tin về tên và giới tính, do đó để hiển thị thêm được thông tin về tiền lương (salary) bằng phương thức display() thì bạn cần ghi đè lại phương thức display() ở lớp cha.\r\nTrong kế thừa, khi lớp con khai báo phương thức có tên trùng với phương thức ở lớp cha thì phương thức của lớp cha sẽ bị thay thế bởi phương thức ở lớp con. Ví dụ:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SuperClass\"\" << endl;\r\n        }\r\n};\r\n\r\nclass SubClass : public SuperClass {\r\npublic:\r\n        void display() {\r\n                cout << \"\"Hello from SubClass\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        SubClass s;\r\n        s.display();\r\n        return 0;\r\n}\r\nKết quả khi chạy chương trình:\r\nHello from SubClass', 4, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(23, 'Bộ nhớ RAM/ROM', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        return 0;\r\n}\r\n', 4, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(24, 'Các cổng kết nối', 'Bạn hãy vận dụng tính đa hình để điền code vào dấu ... sao cho chương trình hiển thị ra thông tin sau:\r\nsome sound\r\nbow wow\r\nmeow meow\r\nquack quack\r\nHướng dẫn\r\nCode mẫu:\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Animal {\r\npublic:\r\n        virtual void sound() {\r\n                cout << \"\"some sound\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Dog : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"bow wow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Cat : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"meow meow\"\" << endl;\r\n        }\r\n};\r\n\r\nclass Duck : public Animal {\r\npublic:\r\n        void sound() {\r\n                cout << \"\"quack quack\"\" << endl;\r\n        }\r\n};\r\n\r\nint main() {\r\n        Animal* animals[4];\r\n        animals[0] = new Animal();\r\n        animals[1] = new Dog();\r\n        animals[2] = new Cat();\r\n        animals[3] = new Duck();\r\n        for (int i = 0; i < 4; i++) {\r\n                animals[i]->sound();\r\n        }\r\n        return 0;\r\n}\r\n', 4, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(25, 'Chương trình C đầu tiên', 'Bài tập\r\nBạn hãy viết chương trình hiện ra màn hình dòng chữ:\r\n\r\nWelcome to DCE!\r\n\r\nHướng dẫn\r\nĐể hiển thị lên màn hình một dòng chữ nào đó bạn có thể dùng câu lệnh cout <<. Ví dụ bạn có thể viết chương trình hiển thị ra hình dòng chữ Welcome bằng các câu lệnh:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        cout << \"\"Welcome\"\";\r\n        return 0;\r\n}\r\n', 5, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(26, 'Biến', 'Bài tập\r\nBạn hãy viết chương trình khai báo 2 biến a và b kiểu số nguyên, sau đó gán giá trị cho a = 254, b = 343 và hiển thị ra màn hình:\r\n\r\na + b = {P}\r\n\r\nVới {P} là tổng của biến a và biến b.\r\n\r\nLý thuyết\r\nBiến trong lập trình được dùng để đại diện cho một giá trị mà có thể thay đổi trong quá trình chạy. Ví dụ như biến thể hiện số tuổi, số tiền trong tài khoản, ... các giá trị này hoàn toàn có thể thay đổi theo thời gian và cần sử dụng biến để lưu trữ.\r\n\r\nỨng với mỗi kiểu dữ liệu như số nguyên, số thực, xâu ký tự, ... thì lại có một cách khai báo biến khác nhau. Trong đó cú pháp để khai báo biến kiểu số nguyên sẽ giống như sau:\r\n\r\nint tên_biến;\r\n\r\nVí dụ về chương tình khai báo và sử dụng biến kiểu số nguyên:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến x kiểu số nguyên\r\n        int x;\r\n        // Gán giá trị cho x = 5\r\n        x = 5;\r\n        // Hiển thị giá trị của biến x ra màn hình\r\n        cout << \"\"x = \"\" << x;\r\n        return 0;\r\n}\r\n\r\nTrong ví dụ trên thì int là từ khóa được dùng để khai báo biến kiểu số nguyên (int là viết tắt của cụm từ integer - có nghĩa là số nguyên).\r\n\r\nBạn còn có thể gán giá trị cho biến ngay khi khai báo giống như sau:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo và gán giá trị cho biến x\r\n        int x = 5;\r\n        cout << \"\"x = \"\" << x << endl;\r\n        x = 7;\r\n        // Hiển thị ra màn hình giá trị của x sau khi thay đổi\r\n        cout << \"\"x = \"\" << x << endl;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\nx = 5\r\nx = 7\r\n\r\nCó thể thấy cách khai báo và sử dụng biến rất đơn giản, bạn cũng có thể sử dụng biến để thực hiện các phép toán:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến a kiểu số nguyên và gán giá trị cho a = 438\r\n        int a = 438;\r\n        // Khai báo biến b kiểu số nguyên và gán giá trị cho b = 238\r\n        int b = 238;\r\n        // Hiển thị ra màn hình hiệu của a và b\r\n        cout << \"\"a - b = \"\" << a - b;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\na - b = 200\r\n\r\nLưu ý: Khi đặt tên cho biến bạn cần tuân theo 1 số nguyên tắc sau:\r\nTên biến có thể có chữ cái, chữ số và dấu gạch dưới nhưng ký tự đầu tiên của tên biến bắt buộc phải là dấu gạch dưới hoặc chữ cái.\r\nTên biến không được có khoảng trắng.\r\nTên biến không được trùng với các từ khóa như int, float, static, struct...\r\n\r\nMột số tên biến hợp lệ:\r\nint a;\r\nint _a;\r\nint a10_;\r\n\r\nMột số tên biến không hợp lệ:\r\nint 10a;\r\nint a 10;\r\nint int;\r\n\r\nHướng dẫn\r\n\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int a = 254;\r\n        int b = 343;\r\n        cout << \"\"a + b = \"\" << a + b;\r\n        return 0;\r\n}', 5, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(27, 'Đầu vào', 'Bài tập\r\nBạn hãy viết chương trình nhập vào tên của mình từ bàn phím và thực hiện hiển thị ra màn hình dòng chữ:\r\nHello {P}\r\nVới {P} là tên bạn vừa nhập từ bàn phím.\r\n\r\nVí dụ nếu bạn nhập tên là Trung thì màn hình sẽ hiển thị lên dòng chữ:\r\nHello Trung\r\n\r\nLý thuyết\r\nĐể nhập dữ liệu cho 1 biến từ bàn phím bạn có thể dùng câu lệnh cin >> tên_biến;\r\n\r\nBạn hãy chạy thử chương trình sau để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến name kiểu string\r\n        string name;\r\n        // Dùng lệnh cin để nhập giá trị cho biến name từ bàn phím\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}\r\n\r\nSau khi chạy bạn hãy nhập từ bàn phím:\r\nTrung\r\nVà bấm phím Enter thì màn hình sẽ hiển thị ra:\r\nHello Trung\r\n\r\nCó thể thấy việc nhập dữ liệu từ bàn phím vào 1 biến là rất đơn giản, bạn chỉ cần dùng câu lệnh cin >> tên_biến;\r\n\r\nLưu ý: với cout thì bạn dùng cặp dấu nhỏ hơn (<<) còn với cin thì bạn dùng cặp dấu lớn hơn (>>).\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        string name;\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}', 5, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(28, 'Cấu trúc rẽ nhánh', 'Bài tập\r\nBạn hãy viết chương trình nhập vào từ bàn phím số nguyên n. Sau đó kiểm tra xem nếu n là số chẵn thì hiển thị ra:\r\nn is an even number\r\nNgược lại, nếu n là số lẻ thì hiển thị ra:\r\nn is an odd number\r\n\r\nLý thuyết\r\nKhi lập trình chắc chắn sẽ có những lúc bạn muốn sử dụng tới câu điều kiện, ví dụ như khi bạn muốn viết chương trình kiểm tra tính chẵn lẻ của một số hay kiểm tra xem tên của 2 người có giống nhau hay không, ... để viết được chương trình theo yêu cầu trên thì bạn cần biết cách sử dụng mệnh đề if hoặc mệnh đề if-else.\r\n\r\nMệnh đề if:\r\n\r\nMệnh đề if được dùng để kiểm tra một biểu thức điều kiện có đúng hay không, nếu đúng thì các câu lệnh bên trong mệnh đề if sẽ được thực thi. Ví dụ để kiểm tra xem n có chia hết cho 2 không bạn có thể làm như sau:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n}\r\nif (n % 2 != 0) {\r\n        // Nếu n không chia hết cho 2 thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nTrong ngôn ngữ lập trình C++, == là toán tử kiểm tra xem 2 giá trị có bằng nhau không, != là toán tử kiểm tra xem 2 giá trị có khác nhau không. Như ở ví dụ trên if (n % 2 == 0) là câu lệnh kiểm tra xem n chia dư cho 2 có bằng 0 không, if (n % 2 != 0) là câu lệnh kiểm tra xem n chia dư cho 2 có khác 0 không.\r\n\r\nLưu ý: Một số bạn hay nhầm giữa toán tử = và toán tử ==, toán tử = là toán tử gán giá trị chứ không phải toán tử so sánh nên nếu bạn dùng toán tử = để so sánh hay giá trị thì chương trình sẽ cho ra kết quả sai.\r\n\r\nMệnh đề if-else:\r\n\r\nTương tự như mệnh đề if nhưng nếu biểu thức điều kiện trong if sai thì đoạn code bên trong else sẽ được thực thi:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n} else {\r\n        // Ngược lại (n không chia hết cho 2) thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nNếu bạn vẫn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng mệnh đề if:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        }\r\n        if(n % 2 != 0) {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}\r\n\r\nCode mẫu sử dụng mệnh đề if-else:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        } else {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}', 5, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(29, 'Vòng lặp', 'Bài tập\r\nBạn hãy viết chương trình nhập từ bàn phím số nguyên a và b. Sau đó hiển thị ra các số từ a tới b:\r\n\r\nVí dụ nếu nhập a = 5, b = 9 thì chương trình sẽ hiển thị ra màn hình:\r\n5 6 7 8 9 \r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int a, b;\r\n    cin >> a >> b;\r\n    for (int i = a; i <= b; i++) {\r\n        cout << i << \"\" \"\";\r\n    }\r\n    return 0;\r\n}', 5, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(30, 'Vòng lặp: while và do-while', 'Bài tập\r\nBạn hãy viết chương trình nhập vào bàn phím số nguyên n và hiển thị ra các số chẵn từ n tới 100.\r\n\r\nVí dụ nếu nhập n = 90 thì chương trình sẽ hiển thị ra màn hình:\r\n90 92 94 96 98 100\r\n\r\nLý thuyết\r\nCấu trúc vòng lặp while:\r\n\r\nwhile (biểu_thức){\r\n    // Nếu biểu thức đúng thì thực hiện đoạn code trong khối lệnh này\r\n}\r\n\r\nCó thể thấy cách sử dụng vòng lặp while rất đơn giản, khi biểu_thức còn đúng thì thực hiện đoạn code bên trong vòng while.\r\n\r\nHãy xem một vài ví dụ về vòng lặp while để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 5;\r\n    while (n != 0) {\r\n        cout << n << \"\" \"\";\r\n        n--;\r\n    }\r\n    return 0;\r\n}\r\n\r\nChương trình này sẽ hiển thị ra màn hình:\r\n5 4 3 2 1 \r\n\r\nĐoạn code trên có thể hiểu đơn giản là: Khi n còn khác 0 thì hiển thị ra màn hình giá trị của n và giảm n đi 1.\r\n\r\nVí dụ khác về hiển thị các số chẵn từ 1 tới 100 sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 1;\r\n    while (n <= 100) {\r\n        if (n % 2 == 0) {\r\n            cout << n << \"\" \"\";\r\n        }\r\n        n++;\r\n    }\r\n    return 0;\r\n}\r\nĐọc tới đây bạn đã có thể quay lại phần bài tập và làm thử.\r\n\r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        while (n <= 100) {\r\n                if (n % 2 == 0) {\r\n                        cout << n << \"\" \"\";\r\n                }\r\n                n++;\r\n        }\r\n        return 0;\r\n}', 5, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(31, 'Chương trình C++ đầu tiên', 'Bài tập\r\nBạn hãy viết chương trình hiện ra màn hình dòng chữ:\r\n\r\nWelcome to DCE!\r\n\r\nHướng dẫn\r\nĐể hiển thị lên màn hình một dòng chữ nào đó bạn có thể dùng câu lệnh cout <<. Ví dụ bạn có thể viết chương trình hiển thị ra hình dòng chữ Welcome bằng các câu lệnh:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        cout << \"\"Welcome\"\";\r\n        return 0;\r\n}\r\n', 6, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(32, 'Biến và các kiểu dữ liệu', 'Bài tập\r\nBạn hãy viết chương trình khai báo 2 biến a và b kiểu số nguyên, sau đó gán giá trị cho a = 254, b = 343 và hiển thị ra màn hình:\r\n\r\na + b = {P}\r\n\r\nVới {P} là tổng của biến a và biến b.\r\n\r\nLý thuyết\r\nBiến trong lập trình được dùng để đại diện cho một giá trị mà có thể thay đổi trong quá trình chạy. Ví dụ như biến thể hiện số tuổi, số tiền trong tài khoản, ... các giá trị này hoàn toàn có thể thay đổi theo thời gian và cần sử dụng biến để lưu trữ.\r\n\r\nỨng với mỗi kiểu dữ liệu như số nguyên, số thực, xâu ký tự, ... thì lại có một cách khai báo biến khác nhau. Trong đó cú pháp để khai báo biến kiểu số nguyên sẽ giống như sau:\r\n\r\nint tên_biến;\r\n\r\nVí dụ về chương tình khai báo và sử dụng biến kiểu số nguyên:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến x kiểu số nguyên\r\n        int x;\r\n        // Gán giá trị cho x = 5\r\n        x = 5;\r\n        // Hiển thị giá trị của biến x ra màn hình\r\n        cout << \"\"x = \"\" << x;\r\n        return 0;\r\n}\r\n\r\nTrong ví dụ trên thì int là từ khóa được dùng để khai báo biến kiểu số nguyên (int là viết tắt của cụm từ integer - có nghĩa là số nguyên).\r\n\r\nBạn còn có thể gán giá trị cho biến ngay khi khai báo giống như sau:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo và gán giá trị cho biến x\r\n        int x = 5;\r\n        cout << \"\"x = \"\" << x << endl;\r\n        x = 7;\r\n        // Hiển thị ra màn hình giá trị của x sau khi thay đổi\r\n        cout << \"\"x = \"\" << x << endl;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\nx = 5\r\nx = 7\r\n\r\nCó thể thấy cách khai báo và sử dụng biến rất đơn giản, bạn cũng có thể sử dụng biến để thực hiện các phép toán:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến a kiểu số nguyên và gán giá trị cho a = 438\r\n        int a = 438;\r\n        // Khai báo biến b kiểu số nguyên và gán giá trị cho b = 238\r\n        int b = 238;\r\n        // Hiển thị ra màn hình hiệu của a và b\r\n        cout << \"\"a - b = \"\" << a - b;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\na - b = 200\r\n\r\nLưu ý: Khi đặt tên cho biến bạn cần tuân theo 1 số nguyên tắc sau:\r\nTên biến có thể có chữ cái, chữ số và dấu gạch dưới nhưng ký tự đầu tiên của tên biến bắt buộc phải là dấu gạch dưới hoặc chữ cái.\r\nTên biến không được có khoảng trắng.\r\nTên biến không được trùng với các từ khóa như int, float, static, struct...\r\n\r\nMột số tên biến hợp lệ:\r\nint a;\r\nint _a;\r\nint a10_;\r\n\r\nMột số tên biến không hợp lệ:\r\nint 10a;\r\nint a 10;\r\nint int;\r\n\r\nHướng dẫn\r\n\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int a = 254;\r\n        int b = 343;\r\n        cout << \"\"a + b = \"\" << a + b;\r\n        return 0;\r\n}', 6, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(33, 'Các toán tử và đầu vào', 'Bài tập\r\nBạn hãy viết chương trình nhập vào tên của mình từ bàn phím và thực hiện hiển thị ra màn hình dòng chữ:\r\nHello {P}\r\nVới {P} là tên bạn vừa nhập từ bàn phím.\r\n\r\nVí dụ nếu bạn nhập tên là Trung thì màn hình sẽ hiển thị lên dòng chữ:\r\nHello Trung\r\n\r\nLý thuyết\r\nĐể nhập dữ liệu cho 1 biến từ bàn phím bạn có thể dùng câu lệnh cin >> tên_biến;\r\n\r\nBạn hãy chạy thử chương trình sau để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến name kiểu string\r\n        string name;\r\n        // Dùng lệnh cin để nhập giá trị cho biến name từ bàn phím\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}\r\n\r\nSau khi chạy bạn hãy nhập từ bàn phím:\r\nTrung\r\nVà bấm phím Enter thì màn hình sẽ hiển thị ra:\r\nHello Trung\r\n\r\nCó thể thấy việc nhập dữ liệu từ bàn phím vào 1 biến là rất đơn giản, bạn chỉ cần dùng câu lệnh cin >> tên_biến;\r\n\r\nLưu ý: với cout thì bạn dùng cặp dấu nhỏ hơn (<<) còn với cin thì bạn dùng cặp dấu lớn hơn (>>).\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        string name;\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}', 6, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(34, 'Câu lệnh rẽ nhánh', 'Bài tập\r\nBạn hãy viết chương trình nhập vào từ bàn phím số nguyên n. Sau đó kiểm tra xem nếu n là số chẵn thì hiển thị ra:\r\nn is an even number\r\nNgược lại, nếu n là số lẻ thì hiển thị ra:\r\nn is an odd number\r\n\r\nLý thuyết\r\nKhi lập trình chắc chắn sẽ có những lúc bạn muốn sử dụng tới câu điều kiện, ví dụ như khi bạn muốn viết chương trình kiểm tra tính chẵn lẻ của một số hay kiểm tra xem tên của 2 người có giống nhau hay không, ... để viết được chương trình theo yêu cầu trên thì bạn cần biết cách sử dụng mệnh đề if hoặc mệnh đề if-else.\r\n\r\nMệnh đề if:\r\n\r\nMệnh đề if được dùng để kiểm tra một biểu thức điều kiện có đúng hay không, nếu đúng thì các câu lệnh bên trong mệnh đề if sẽ được thực thi. Ví dụ để kiểm tra xem n có chia hết cho 2 không bạn có thể làm như sau:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n}\r\nif (n % 2 != 0) {\r\n        // Nếu n không chia hết cho 2 thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nTrong ngôn ngữ lập trình C++, == là toán tử kiểm tra xem 2 giá trị có bằng nhau không, != là toán tử kiểm tra xem 2 giá trị có khác nhau không. Như ở ví dụ trên if (n % 2 == 0) là câu lệnh kiểm tra xem n chia dư cho 2 có bằng 0 không, if (n % 2 != 0) là câu lệnh kiểm tra xem n chia dư cho 2 có khác 0 không.\r\n\r\nLưu ý: Một số bạn hay nhầm giữa toán tử = và toán tử ==, toán tử = là toán tử gán giá trị chứ không phải toán tử so sánh nên nếu bạn dùng toán tử = để so sánh hay giá trị thì chương trình sẽ cho ra kết quả sai.\r\n\r\nMệnh đề if-else:\r\n\r\nTương tự như mệnh đề if nhưng nếu biểu thức điều kiện trong if sai thì đoạn code bên trong else sẽ được thực thi:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n} else {\r\n        // Ngược lại (n không chia hết cho 2) thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nNếu bạn vẫn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng mệnh đề if:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        }\r\n        if(n % 2 != 0) {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}\r\n\r\nCode mẫu sử dụng mệnh đề if-else:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        } else {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}', 6, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(35, 'Vòng lặp: for', 'Bài tập\r\nBạn hãy viết chương trình nhập từ bàn phím số nguyên a và b. Sau đó hiển thị ra các số từ a tới b:\r\n\r\nVí dụ nếu nhập a = 5, b = 9 thì chương trình sẽ hiển thị ra màn hình:\r\n5 6 7 8 9 \r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int a, b;\r\n    cin >> a >> b;\r\n    for (int i = a; i <= b; i++) {\r\n        cout << i << \"\" \"\";\r\n    }\r\n    return 0;\r\n}', 6, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(36, 'Vòng lặp: while và do-while', 'Bài tập\r\nBạn hãy viết chương trình nhập vào bàn phím số nguyên n và hiển thị ra các số chẵn từ n tới 100.\r\n\r\nVí dụ nếu nhập n = 90 thì chương trình sẽ hiển thị ra màn hình:\r\n90 92 94 96 98 100\r\n\r\nLý thuyết\r\nCấu trúc vòng lặp while:\r\n\r\nwhile (biểu_thức){\r\n    // Nếu biểu thức đúng thì thực hiện đoạn code trong khối lệnh này\r\n}\r\n\r\nCó thể thấy cách sử dụng vòng lặp while rất đơn giản, khi biểu_thức còn đúng thì thực hiện đoạn code bên trong vòng while.\r\n\r\nHãy xem một vài ví dụ về vòng lặp while để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 5;\r\n    while (n != 0) {\r\n        cout << n << \"\" \"\";\r\n        n--;\r\n    }\r\n    return 0;\r\n}\r\n\r\nChương trình này sẽ hiển thị ra màn hình:\r\n5 4 3 2 1 \r\n\r\nĐoạn code trên có thể hiểu đơn giản là: Khi n còn khác 0 thì hiển thị ra màn hình giá trị của n và giảm n đi 1.\r\n\r\nVí dụ khác về hiển thị các số chẵn từ 1 tới 100 sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 1;\r\n    while (n <= 100) {\r\n        if (n % 2 == 0) {\r\n            cout << n << \"\" \"\";\r\n        }\r\n        n++;\r\n    }\r\n    return 0;\r\n}\r\nĐọc tới đây bạn đã có thể quay lại phần bài tập và làm thử.\r\n\r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        while (n <= 100) {\r\n                if (n % 2 == 0) {\r\n                        cout << n << \"\" \"\";\r\n                }\r\n                n++;\r\n        }\r\n        return 0;\r\n}', 6, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(37, 'Giới thiệu về cơ sở dữ liệu', 'Bài tập\r\nBạn hãy viết chương trình hiện ra màn hình dòng chữ:\r\n\r\nWelcome to DCE!\r\n\r\nHướng dẫn\r\nĐể hiển thị lên màn hình một dòng chữ nào đó bạn có thể dùng câu lệnh cout <<. Ví dụ bạn có thể viết chương trình hiển thị ra hình dòng chữ Welcome bằng các câu lệnh:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        cout << \"\"Welcome\"\";\r\n        return 0;\r\n}\r\n', 7, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(38, 'Khởi tạo bảng', 'Bài tập\r\nBạn hãy viết chương trình khai báo 2 biến a và b kiểu số nguyên, sau đó gán giá trị cho a = 254, b = 343 và hiển thị ra màn hình:\r\n\r\na + b = {P}\r\n\r\nVới {P} là tổng của biến a và biến b.\r\n\r\nLý thuyết\r\nBiến trong lập trình được dùng để đại diện cho một giá trị mà có thể thay đổi trong quá trình chạy. Ví dụ như biến thể hiện số tuổi, số tiền trong tài khoản, ... các giá trị này hoàn toàn có thể thay đổi theo thời gian và cần sử dụng biến để lưu trữ.\r\n\r\nỨng với mỗi kiểu dữ liệu như số nguyên, số thực, xâu ký tự, ... thì lại có một cách khai báo biến khác nhau. Trong đó cú pháp để khai báo biến kiểu số nguyên sẽ giống như sau:\r\n\r\nint tên_biến;\r\n\r\nVí dụ về chương tình khai báo và sử dụng biến kiểu số nguyên:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến x kiểu số nguyên\r\n        int x;\r\n        // Gán giá trị cho x = 5\r\n        x = 5;\r\n        // Hiển thị giá trị của biến x ra màn hình\r\n        cout << \"\"x = \"\" << x;\r\n        return 0;\r\n}\r\n\r\nTrong ví dụ trên thì int là từ khóa được dùng để khai báo biến kiểu số nguyên (int là viết tắt của cụm từ integer - có nghĩa là số nguyên).\r\n\r\nBạn còn có thể gán giá trị cho biến ngay khi khai báo giống như sau:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo và gán giá trị cho biến x\r\n        int x = 5;\r\n        cout << \"\"x = \"\" << x << endl;\r\n        x = 7;\r\n        // Hiển thị ra màn hình giá trị của x sau khi thay đổi\r\n        cout << \"\"x = \"\" << x << endl;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\nx = 5\r\nx = 7\r\n\r\nCó thể thấy cách khai báo và sử dụng biến rất đơn giản, bạn cũng có thể sử dụng biến để thực hiện các phép toán:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến a kiểu số nguyên và gán giá trị cho a = 438\r\n        int a = 438;\r\n        // Khai báo biến b kiểu số nguyên và gán giá trị cho b = 238\r\n        int b = 238;\r\n        // Hiển thị ra màn hình hiệu của a và b\r\n        cout << \"\"a - b = \"\" << a - b;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\na - b = 200\r\n\r\nLưu ý: Khi đặt tên cho biến bạn cần tuân theo 1 số nguyên tắc sau:\r\nTên biến có thể có chữ cái, chữ số và dấu gạch dưới nhưng ký tự đầu tiên của tên biến bắt buộc phải là dấu gạch dưới hoặc chữ cái.\r\nTên biến không được có khoảng trắng.\r\nTên biến không được trùng với các từ khóa như int, float, static, struct...\r\n\r\nMột số tên biến hợp lệ:\r\nint a;\r\nint _a;\r\nint a10_;\r\n\r\nMột số tên biến không hợp lệ:\r\nint 10a;\r\nint a 10;\r\nint int;\r\n\r\nHướng dẫn\r\n\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int a = 254;\r\n        int b = 343;\r\n        cout << \"\"a + b = \"\" << a + b;\r\n        return 0;\r\n}', 7, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', '');
INSERT INTO `lesson` (`lessonId`, `title`, `content`, `courseId`, `description`, `captionLink`, `link`) VALUES
(39, 'Hiểu biết về những ràng buộc', 'Bài tập\r\nBạn hãy viết chương trình nhập vào tên của mình từ bàn phím và thực hiện hiển thị ra màn hình dòng chữ:\r\nHello {P}\r\nVới {P} là tên bạn vừa nhập từ bàn phím.\r\n\r\nVí dụ nếu bạn nhập tên là Trung thì màn hình sẽ hiển thị lên dòng chữ:\r\nHello Trung\r\n\r\nLý thuyết\r\nĐể nhập dữ liệu cho 1 biến từ bàn phím bạn có thể dùng câu lệnh cin >> tên_biến;\r\n\r\nBạn hãy chạy thử chương trình sau để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến name kiểu string\r\n        string name;\r\n        // Dùng lệnh cin để nhập giá trị cho biến name từ bàn phím\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}\r\n\r\nSau khi chạy bạn hãy nhập từ bàn phím:\r\nTrung\r\nVà bấm phím Enter thì màn hình sẽ hiển thị ra:\r\nHello Trung\r\n\r\nCó thể thấy việc nhập dữ liệu từ bàn phím vào 1 biến là rất đơn giản, bạn chỉ cần dùng câu lệnh cin >> tên_biến;\r\n\r\nLưu ý: với cout thì bạn dùng cặp dấu nhỏ hơn (<<) còn với cin thì bạn dùng cặp dấu lớn hơn (>>).\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        string name;\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}', 7, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(40, 'Sửa đổi dữ liệu', 'Bài tập\r\nBạn hãy viết chương trình nhập vào từ bàn phím số nguyên n. Sau đó kiểm tra xem nếu n là số chẵn thì hiển thị ra:\r\nn is an even number\r\nNgược lại, nếu n là số lẻ thì hiển thị ra:\r\nn is an odd number\r\n\r\nLý thuyết\r\nKhi lập trình chắc chắn sẽ có những lúc bạn muốn sử dụng tới câu điều kiện, ví dụ như khi bạn muốn viết chương trình kiểm tra tính chẵn lẻ của một số hay kiểm tra xem tên của 2 người có giống nhau hay không, ... để viết được chương trình theo yêu cầu trên thì bạn cần biết cách sử dụng mệnh đề if hoặc mệnh đề if-else.\r\n\r\nMệnh đề if:\r\n\r\nMệnh đề if được dùng để kiểm tra một biểu thức điều kiện có đúng hay không, nếu đúng thì các câu lệnh bên trong mệnh đề if sẽ được thực thi. Ví dụ để kiểm tra xem n có chia hết cho 2 không bạn có thể làm như sau:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n}\r\nif (n % 2 != 0) {\r\n        // Nếu n không chia hết cho 2 thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nTrong ngôn ngữ lập trình C++, == là toán tử kiểm tra xem 2 giá trị có bằng nhau không, != là toán tử kiểm tra xem 2 giá trị có khác nhau không. Như ở ví dụ trên if (n % 2 == 0) là câu lệnh kiểm tra xem n chia dư cho 2 có bằng 0 không, if (n % 2 != 0) là câu lệnh kiểm tra xem n chia dư cho 2 có khác 0 không.\r\n\r\nLưu ý: Một số bạn hay nhầm giữa toán tử = và toán tử ==, toán tử = là toán tử gán giá trị chứ không phải toán tử so sánh nên nếu bạn dùng toán tử = để so sánh hay giá trị thì chương trình sẽ cho ra kết quả sai.\r\n\r\nMệnh đề if-else:\r\n\r\nTương tự như mệnh đề if nhưng nếu biểu thức điều kiện trong if sai thì đoạn code bên trong else sẽ được thực thi:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n} else {\r\n        // Ngược lại (n không chia hết cho 2) thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nNếu bạn vẫn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng mệnh đề if:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        }\r\n        if(n % 2 != 0) {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}\r\n\r\nCode mẫu sử dụng mệnh đề if-else:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        } else {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}', 7, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(41, 'Chuẩn hoá cơ sở dữ liệu', 'Bài tập\r\nBạn hãy viết chương trình nhập từ bàn phím số nguyên a và b. Sau đó hiển thị ra các số từ a tới b:\r\n\r\nVí dụ nếu nhập a = 5, b = 9 thì chương trình sẽ hiển thị ra màn hình:\r\n5 6 7 8 9 \r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int a, b;\r\n    cin >> a >> b;\r\n    for (int i = a; i <= b; i++) {\r\n        cout << i << \"\" \"\";\r\n    }\r\n    return 0;\r\n}', 7, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(42, 'Truy vấn cơ sở dữ liệu', 'Bài tập\r\nBạn hãy viết chương trình nhập vào bàn phím số nguyên n và hiển thị ra các số chẵn từ n tới 100.\r\n\r\nVí dụ nếu nhập n = 90 thì chương trình sẽ hiển thị ra màn hình:\r\n90 92 94 96 98 100\r\n\r\nLý thuyết\r\nCấu trúc vòng lặp while:\r\n\r\nwhile (biểu_thức){\r\n    // Nếu biểu thức đúng thì thực hiện đoạn code trong khối lệnh này\r\n}\r\n\r\nCó thể thấy cách sử dụng vòng lặp while rất đơn giản, khi biểu_thức còn đúng thì thực hiện đoạn code bên trong vòng while.\r\n\r\nHãy xem một vài ví dụ về vòng lặp while để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 5;\r\n    while (n != 0) {\r\n        cout << n << \"\" \"\";\r\n        n--;\r\n    }\r\n    return 0;\r\n}\r\n\r\nChương trình này sẽ hiển thị ra màn hình:\r\n5 4 3 2 1 \r\n\r\nĐoạn code trên có thể hiểu đơn giản là: Khi n còn khác 0 thì hiển thị ra màn hình giá trị của n và giảm n đi 1.\r\n\r\nVí dụ khác về hiển thị các số chẵn từ 1 tới 100 sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 1;\r\n    while (n <= 100) {\r\n        if (n % 2 == 0) {\r\n            cout << n << \"\" \"\";\r\n        }\r\n        n++;\r\n    }\r\n    return 0;\r\n}\r\nĐọc tới đây bạn đã có thể quay lại phần bài tập và làm thử.\r\n\r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        while (n <= 100) {\r\n                if (n % 2 == 0) {\r\n                        cout << n << \"\" \"\";\r\n                }\r\n                n++;\r\n        }\r\n        return 0;\r\n}', 7, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(43, 'Tổng quan, console.log và chú thích', 'Bài tập\r\nBạn hãy viết chương trình hiện ra màn hình dòng chữ:\r\n\r\nWelcome to DCE!\r\n\r\nHướng dẫn\r\nĐể hiển thị lên màn hình một dòng chữ nào đó bạn có thể dùng câu lệnh cout <<. Ví dụ bạn có thể viết chương trình hiển thị ra hình dòng chữ Welcome bằng các câu lệnh:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        cout << \"\"Welcome\"\";\r\n        return 0;\r\n}\r\n', 8, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(44, 'Biến', 'Bài tập\r\nBạn hãy viết chương trình khai báo 2 biến a và b kiểu số nguyên, sau đó gán giá trị cho a = 254, b = 343 và hiển thị ra màn hình:\r\n\r\na + b = {P}\r\n\r\nVới {P} là tổng của biến a và biến b.\r\n\r\nLý thuyết\r\nBiến trong lập trình được dùng để đại diện cho một giá trị mà có thể thay đổi trong quá trình chạy. Ví dụ như biến thể hiện số tuổi, số tiền trong tài khoản, ... các giá trị này hoàn toàn có thể thay đổi theo thời gian và cần sử dụng biến để lưu trữ.\r\n\r\nỨng với mỗi kiểu dữ liệu như số nguyên, số thực, xâu ký tự, ... thì lại có một cách khai báo biến khác nhau. Trong đó cú pháp để khai báo biến kiểu số nguyên sẽ giống như sau:\r\n\r\nint tên_biến;\r\n\r\nVí dụ về chương tình khai báo và sử dụng biến kiểu số nguyên:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến x kiểu số nguyên\r\n        int x;\r\n        // Gán giá trị cho x = 5\r\n        x = 5;\r\n        // Hiển thị giá trị của biến x ra màn hình\r\n        cout << \"\"x = \"\" << x;\r\n        return 0;\r\n}\r\n\r\nTrong ví dụ trên thì int là từ khóa được dùng để khai báo biến kiểu số nguyên (int là viết tắt của cụm từ integer - có nghĩa là số nguyên).\r\n\r\nBạn còn có thể gán giá trị cho biến ngay khi khai báo giống như sau:\r\n\r\n#include <iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo và gán giá trị cho biến x\r\n        int x = 5;\r\n        cout << \"\"x = \"\" << x << endl;\r\n        x = 7;\r\n        // Hiển thị ra màn hình giá trị của x sau khi thay đổi\r\n        cout << \"\"x = \"\" << x << endl;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\nx = 5\r\nx = 7\r\n\r\nCó thể thấy cách khai báo và sử dụng biến rất đơn giản, bạn cũng có thể sử dụng biến để thực hiện các phép toán:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến a kiểu số nguyên và gán giá trị cho a = 438\r\n        int a = 438;\r\n        // Khai báo biến b kiểu số nguyên và gán giá trị cho b = 238\r\n        int b = 238;\r\n        // Hiển thị ra màn hình hiệu của a và b\r\n        cout << \"\"a - b = \"\" << a - b;\r\n        return 0;\r\n}\r\n\r\nKết quả khi chạy chương trình:\r\na - b = 200\r\n\r\nLưu ý: Khi đặt tên cho biến bạn cần tuân theo 1 số nguyên tắc sau:\r\nTên biến có thể có chữ cái, chữ số và dấu gạch dưới nhưng ký tự đầu tiên của tên biến bắt buộc phải là dấu gạch dưới hoặc chữ cái.\r\nTên biến không được có khoảng trắng.\r\nTên biến không được trùng với các từ khóa như int, float, static, struct...\r\n\r\nMột số tên biến hợp lệ:\r\nint a;\r\nint _a;\r\nint a10_;\r\n\r\nMột số tên biến không hợp lệ:\r\nint 10a;\r\nint a 10;\r\nint int;\r\n\r\nHướng dẫn\r\n\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int a = 254;\r\n        int b = 343;\r\n        cout << \"\"a + b = \"\" << a + b;\r\n        return 0;\r\n}', 8, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(45, 'Các toán tử', 'Bài tập\r\nBạn hãy viết chương trình nhập vào tên của mình từ bàn phím và thực hiện hiển thị ra màn hình dòng chữ:\r\nHello {P}\r\nVới {P} là tên bạn vừa nhập từ bàn phím.\r\n\r\nVí dụ nếu bạn nhập tên là Trung thì màn hình sẽ hiển thị lên dòng chữ:\r\nHello Trung\r\n\r\nLý thuyết\r\nĐể nhập dữ liệu cho 1 biến từ bàn phím bạn có thể dùng câu lệnh cin >> tên_biến;\r\n\r\nBạn hãy chạy thử chương trình sau để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        // Khai báo biến name kiểu string\r\n        string name;\r\n        // Dùng lệnh cin để nhập giá trị cho biến name từ bàn phím\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}\r\n\r\nSau khi chạy bạn hãy nhập từ bàn phím:\r\nTrung\r\nVà bấm phím Enter thì màn hình sẽ hiển thị ra:\r\nHello Trung\r\n\r\nCó thể thấy việc nhập dữ liệu từ bàn phím vào 1 biến là rất đơn giản, bạn chỉ cần dùng câu lệnh cin >> tên_biến;\r\n\r\nLưu ý: với cout thì bạn dùng cặp dấu nhỏ hơn (<<) còn với cin thì bạn dùng cặp dấu lớn hơn (>>).\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        string name;\r\n        cin >> name;\r\n        cout << \"\"Hello \"\" << name;\r\n        return 0;\r\n}', 8, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(46, 'Các hàm', 'Bài tập\r\nBạn hãy viết chương trình nhập vào từ bàn phím số nguyên n. Sau đó kiểm tra xem nếu n là số chẵn thì hiển thị ra:\r\nn is an even number\r\nNgược lại, nếu n là số lẻ thì hiển thị ra:\r\nn is an odd number\r\n\r\nLý thuyết\r\nKhi lập trình chắc chắn sẽ có những lúc bạn muốn sử dụng tới câu điều kiện, ví dụ như khi bạn muốn viết chương trình kiểm tra tính chẵn lẻ của một số hay kiểm tra xem tên của 2 người có giống nhau hay không, ... để viết được chương trình theo yêu cầu trên thì bạn cần biết cách sử dụng mệnh đề if hoặc mệnh đề if-else.\r\n\r\nMệnh đề if:\r\n\r\nMệnh đề if được dùng để kiểm tra một biểu thức điều kiện có đúng hay không, nếu đúng thì các câu lệnh bên trong mệnh đề if sẽ được thực thi. Ví dụ để kiểm tra xem n có chia hết cho 2 không bạn có thể làm như sau:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n}\r\nif (n % 2 != 0) {\r\n        // Nếu n không chia hết cho 2 thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nTrong ngôn ngữ lập trình C++, == là toán tử kiểm tra xem 2 giá trị có bằng nhau không, != là toán tử kiểm tra xem 2 giá trị có khác nhau không. Như ở ví dụ trên if (n % 2 == 0) là câu lệnh kiểm tra xem n chia dư cho 2 có bằng 0 không, if (n % 2 != 0) là câu lệnh kiểm tra xem n chia dư cho 2 có khác 0 không.\r\n\r\nLưu ý: Một số bạn hay nhầm giữa toán tử = và toán tử ==, toán tử = là toán tử gán giá trị chứ không phải toán tử so sánh nên nếu bạn dùng toán tử = để so sánh hay giá trị thì chương trình sẽ cho ra kết quả sai.\r\n\r\nMệnh đề if-else:\r\n\r\nTương tự như mệnh đề if nhưng nếu biểu thức điều kiện trong if sai thì đoạn code bên trong else sẽ được thực thi:\r\n\r\nif (n % 2 == 0) {\r\n        // Nếu n chia hết cho 2 thì hiển thị n is an even number\r\n        cout << \"\"n is an even number\"\";\r\n} else {\r\n        // Ngược lại (n không chia hết cho 2) thì hiển thị n is an odd number\r\n        cout << \"\"n is an odd number\"\";\r\n}\r\n\r\nNếu bạn vẫn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng mệnh đề if:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        }\r\n        if(n % 2 != 0) {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}\r\n\r\nCode mẫu sử dụng mệnh đề if-else:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        if (n % 2 == 0) {\r\n                cout << \"\"n is an even number\"\";\r\n        } else {\r\n                cout << \"\"n is an odd number\"\";\r\n        }\r\n        return 0;\r\n}', 8, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(47, 'Lệnh If - Else và Switch - Case ', 'Bài tập\r\nBạn hãy viết chương trình nhập từ bàn phím số nguyên a và b. Sau đó hiển thị ra các số từ a tới b:\r\n\r\nVí dụ nếu nhập a = 5, b = 9 thì chương trình sẽ hiển thị ra màn hình:\r\n5 6 7 8 9 \r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int a, b;\r\n    cin >> a >> b;\r\n    for (int i = a; i <= b; i++) {\r\n        cout << i << \"\" \"\";\r\n    }\r\n    return 0;\r\n}', 8, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(48, 'Vòng lặp', 'Bài tập\r\nBạn hãy viết chương trình nhập vào bàn phím số nguyên n và hiển thị ra các số chẵn từ n tới 100.\r\n\r\nVí dụ nếu nhập n = 90 thì chương trình sẽ hiển thị ra màn hình:\r\n90 92 94 96 98 100\r\n\r\nLý thuyết\r\nCấu trúc vòng lặp while:\r\n\r\nwhile (biểu_thức){\r\n    // Nếu biểu thức đúng thì thực hiện đoạn code trong khối lệnh này\r\n}\r\n\r\nCó thể thấy cách sử dụng vòng lặp while rất đơn giản, khi biểu_thức còn đúng thì thực hiện đoạn code bên trong vòng while.\r\n\r\nHãy xem một vài ví dụ về vòng lặp while để hiểu rõ hơn:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 5;\r\n    while (n != 0) {\r\n        cout << n << \"\" \"\";\r\n        n--;\r\n    }\r\n    return 0;\r\n}\r\n\r\nChương trình này sẽ hiển thị ra màn hình:\r\n5 4 3 2 1 \r\n\r\nĐoạn code trên có thể hiểu đơn giản là: Khi n còn khác 0 thì hiển thị ra màn hình giá trị của n và giảm n đi 1.\r\n\r\nVí dụ khác về hiển thị các số chẵn từ 1 tới 100 sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n    int n = 1;\r\n    while (n <= 100) {\r\n        if (n % 2 == 0) {\r\n            cout << n << \"\" \"\";\r\n        }\r\n        n++;\r\n    }\r\n    return 0;\r\n}\r\nĐọc tới đây bạn đã có thể quay lại phần bài tập và làm thử.\r\n\r\nNếu bạn chưa làm được bài này thì có thể xem hướng dẫn ở bên dưới.\r\n\r\nHướng dẫn\r\nCode mẫu sử dụng vòng lặp while:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nint main() {\r\n        int n;\r\n        cin >> n;\r\n        while (n <= 100) {\r\n                if (n % 2 == 0) {\r\n                        cout << n << \"\" \"\";\r\n                }\r\n                n++;\r\n        }\r\n        return 0;\r\n}', 8, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(49, 'Chương trình đầu tiên và chú thích', 'Chúng ta có một số nguyên dương n. Mỗi một lần ta thay thế n bằng tổng các thừa số nguyên tố của nó (ví dụ 12=2*2*3 thì 12 sẽ được thay thế bằng số 2+2+3=7)\r\n\r\nChúng ta áp dụng phép toán này vào số hiện tại cho đến khi kết quả thu được giống vs số hiện tại\r\n\r\nCho một số tự nhiên, hãy tìm kết quả cuối cùng của phép toán trên.\r\n\r\nVí dụ:\r\n\r\nVới n = 24, kết quả factorSum(n) = 5.\r\n24 -> (2 + 2 + 2 + 3) = 9 -> (3 + 3) = 6 -> (2 + 3) = 5 -> 5.\r\nVì vậy kết quả trong trường hợp n = 24 là 5.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] integer n\r\nĐiều kiện:\r\n2 ≤ n ≤ 200.\r\n[Đầu ra] integer\r\n\r\nLý thuyết\r\nCách kiểm tra một số nguyên dương n có phải một số nguyên tố hay không ? \r\n\r\nNhận thấy rằng một số nguyên n > 1 không phải là một số nguyên tố khi và chỉ khi n có thể biểu diễn dưới dạng : n = x * y, với x,y là hai số nguyên dương lớn hơn 1.\r\nGiả sử răng x ≤ y ⇒ x * x ≤ x * y = n ⇒ x ≤ √n \r\nTừ nhận xét trên ta thấy rằng để kiểm tra xem n có chia hết cho một số nào nhỏ hơn nó hay không ta chỉ việc xét các số từ 2 đến √n thay vì xét các số từ 2 đến n-1 như Cách 1 \r\nbool isPrime(int n)\r\n{\r\n    if (n <= 1) return false;\r\n    for (int i = 2; i <= sqrt(n); ++i) \r\n        if (n % i == 0) return false;\r\n    return true;\r\n}\r\nĐộ phức tạp : O(√n)\r\nHướng dẫn bài tập.\r\nVới bài tập này ta không cần nhất thiết phải kiểm tra số nguyên tố.\r\n\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nint solve(int n){\r\n    int k = 2, sum = 0;\r\n    while (n > 1){\r\n        while (n % k == 0){\r\n            sum += k;\r\n            n /= k;\r\n        }\r\n        k++;\r\n    }\r\n    return sum;\r\n}\r\nint factorSum(int n)\r\n{\r\n    while (n != solve(n))\r\n        n = solve(n);\r\n    return n;\r\n}', 9, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(51, 'Đầu vào', 'Cho xâu kí tự. Hãy đếm số lượng kí tự khác nhau trong xâu đó\r\nVí dụ:\r\nVới s = \"\"cabca\"\", thì kết quả differentSymbolsNaive(s) = 3.\r\nCó 3 kí tự khác nhau là a, b và c.\r\n\r\nĐầu vào/Đầu ra:\r\n[Thời gian chạy] 0.5 seconds\r\n[Đầu vào] string s\r\nXâu kí tự chứa các chữ cái in thường.\r\nGuaranteed constraints:\r\n3 ≤ s.length ≤ 1000.\r\n[Đầu ra] integer.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nint differentSymbolsNaive(std::string s)\r\n{\r\n    vector <bool> b(256, false);\r\n    for (int i = 0; i < s.length(); i++)\r\n        b[s[i]] = true;\r\n    int d = 0;\r\n    for (int i = 0; i < s.length(); i++)\r\n    if (b[s[i]]){\r\n        d++;\r\n        b[s[i]] = false;\r\n    }\r\n    return d;\r\n}', 9, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(52, 'Toán tử cơ bản', 'Cho số nguyên dương n. Hãy tạo ra ma trận vuông kích thước n*n chứa các số từ 1 tới n*n tăng dần theo hình xoắn ốc, xuất phát từ ô trên trái và đi theo theo theo chiều kim đồng hồ\r\n\r\nVí dụ\r\nVới n = 3, kết quả\r\nspiralNumbers(n) = [[1, 2, 3],\r\n                    [8, 9, 4],\r\n                    [7, 6, 5]]\r\n\r\nĐầu vào/đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] integer n\r\nĐộ dài của ma trận\r\nĐiều kiện:\r\n3 ≤ n ≤ 100.\r\n[Đầu ra] matrix.integer\r\n\r\nGợi ý:\r\n\r\nTạo ra ma trận kích thước n*n\r\nSử dụng 2 biến để lưu trữ hàng và cột hiện tại, bắt đầu xuất phát từ ô (0,0) (trên trái)\r\nSử dụng 1 biến để lưu trữ giá trị hiện tại của số nằm trong ma trận. Biến này sẽ tăng dần từ 1 cho tới n*n\r\nĐiền số vào ma trận theo nguyên tắc:\r\nVới cạnh đi từ trái qua phải: tăng dần cột, giữ nguyên hàng\r\nVới cạnh đi từ trên xuống dưới: tăng dần hàng, giữ nguyên cột\r\nVới cạnh đi từ phải qua trái: giảm dần cột, giữ nguyên hàng\r\nVới cạnh đi từ dưới lên trên: giảm dần hàng, giữ nguyên cột.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nstd::vector<std::vector<int>> spiralNumbers(int n)\r\n{\r\n    std::vector<std::vector<int>> a;\r\n    std::vector<int> b;\r\n    for (int i=0; i<n; i++) b.push_back(1);\r\n    for (int i=0; i<n; i++) a.push_back(b);\r\n    int l=0;\r\n    int r = n-1;\r\n    int k=0;\r\n    while (k<n*n){\r\n        if (k<n*n){\r\n            for (int j=l; j<=r; j++){\r\n                k++;\r\n                a[l][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=l+1; i<=r; i++){\r\n                k++;\r\n                a[i][r] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int j=r-1; j>=l; j--){\r\n                k++;\r\n                a[r][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=r-1; i>=l+1; i--){\r\n                k++;\r\n                a[i][l] = k;\r\n            }\r\n        }\r\n        l++; r--;\r\n    }\r\n    return a;\r\n}', 9, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(57, 'Các toán tử', 'Cho xâu kí tự. Hãy đếm số lượng kí tự khác nhau trong xâu đó\r\nVí dụ:\r\nVới s = \"\"cabca\"\", thì kết quả differentSymbolsNaive(s) = 3.\r\nCó 3 kí tự khác nhau là a, b và c.\r\n\r\nĐầu vào/Đầu ra:\r\n[Thời gian chạy] 0.5 seconds\r\n[Đầu vào] string s\r\nXâu kí tự chứa các chữ cái in thường.\r\nGuaranteed constraints:\r\n3 ≤ s.length ≤ 1000.\r\n[Đầu ra] integer.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nint differentSymbolsNaive(std::string s)\r\n{\r\n    vector <bool> b(256, false);\r\n    for (int i = 0; i < s.length(); i++)\r\n        b[s[i]] = true;\r\n    int d = 0;\r\n    for (int i = 0; i < s.length(); i++)\r\n    if (b[s[i]]){\r\n        d++;\r\n        b[s[i]] = false;\r\n    }\r\n    return d;\r\n}', 10, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(58, 'Câu lệnh điều kiện', 'Cho số nguyên dương n. Hãy tạo ra ma trận vuông kích thước n*n chứa các số từ 1 tới n*n tăng dần theo hình xoắn ốc, xuất phát từ ô trên trái và đi theo theo theo chiều kim đồng hồ\r\n\r\nVí dụ\r\nVới n = 3, kết quả\r\nspiralNumbers(n) = [[1, 2, 3],\r\n                    [8, 9, 4],\r\n                    [7, 6, 5]]\r\n\r\nĐầu vào/đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] integer n\r\nĐộ dài của ma trận\r\nĐiều kiện:\r\n3 ≤ n ≤ 100.\r\n[Đầu ra] matrix.integer\r\n\r\nGợi ý:\r\n\r\nTạo ra ma trận kích thước n*n\r\nSử dụng 2 biến để lưu trữ hàng và cột hiện tại, bắt đầu xuất phát từ ô (0,0) (trên trái)\r\nSử dụng 1 biến để lưu trữ giá trị hiện tại của số nằm trong ma trận. Biến này sẽ tăng dần từ 1 cho tới n*n\r\nĐiền số vào ma trận theo nguyên tắc:\r\nVới cạnh đi từ trái qua phải: tăng dần cột, giữ nguyên hàng\r\nVới cạnh đi từ trên xuống dưới: tăng dần hàng, giữ nguyên cột\r\nVới cạnh đi từ phải qua trái: giảm dần cột, giữ nguyên hàng\r\nVới cạnh đi từ dưới lên trên: giảm dần hàng, giữ nguyên cột.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nstd::vector<std::vector<int>> spiralNumbers(int n)\r\n{\r\n    std::vector<std::vector<int>> a;\r\n    std::vector<int> b;\r\n    for (int i=0; i<n; i++) b.push_back(1);\r\n    for (int i=0; i<n; i++) a.push_back(b);\r\n    int l=0;\r\n    int r = n-1;\r\n    int k=0;\r\n    while (k<n*n){\r\n        if (k<n*n){\r\n            for (int j=l; j<=r; j++){\r\n                k++;\r\n                a[l][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=l+1; i<=r; i++){\r\n                k++;\r\n                a[i][r] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int j=r-1; j>=l; j--){\r\n                k++;\r\n                a[r][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=r-1; i>=l+1; i--){\r\n                k++;\r\n                a[i][l] = k;\r\n            }\r\n        }\r\n        l++; r--;\r\n    }\r\n    return a;\r\n}', 10, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(59, 'Vòng lặp', 'Cho tọa độ tâm và bán kính của một đường tròn cùng tọa độ của một điểm trên mặt phẳng 2 chiều\r\n\r\nKiểm tra xem điểm có nằm trong (hoặc nằm trên viền) của đường tròn hay không?\r\n\r\nVí dụ\r\n\r\nVới point = [1, 1], center = [2, 2], và radius = 1, kết quả insideCircle(point, center, radius) = false.\r\nVới point = [1, 1], center = [0, 0], và radius = 3, kết quả insideCircle(point, center, radius) = true.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] array.integer point\r\nMảng 2 phần tử thể hiện tọa độ của điểm cần kiểm tra.\r\nĐiều kiện:\r\n-100 ≤ point[i] ≤ 100.\r\n\r\n[Đầu vào] array.integer center\r\nMảng 2 phần tử thể hiện tọa độ tâm của đường tròn\r\nĐiều kiện:\r\n-10 ≤ center[i] ≤ 10.\r\n\r\n[Đầu vào] integer radius\r\nBán kính đường tròn.\r\nĐiều kiện:\r\n1 ≤ radius ≤ 5.\r\n\r\n[Đầu ra] boolean\r\ntrue nếu point nằm trong đường tròn, false nếu ngược lại.\r\n\r\nLý thuyết :\r\nCho hệ Oxy, 1 điểm A(x, y) và 1 hình tròn có tâm tại C(xC, yC), bán kính R\r\nKhi đó có 3 quan hệ : \r\ndist(A, C) < R : điểm A nằm trong hình tròn\r\ndist(A, C) = R : điểm A ở trên biên hình tròn\r\ndist(A, C) > R : điểm A nằm ngoài hình tròn với dist(A, C) là khoảng cách giữa điểm A và điểm C\r\n\r\nCode minh họa\r\nint sqr(int x) { // tra ve binh phuong cua 1 so\r\n    return x * x;\r\n}\r\nint checkPointCircle(vector <int> A, vector <int> C, int R) {\r\n    int sqr_dist = sqr(C[0] - A[0]) + sqr(C[1] - A[1]);\r\n    // binh phuong dist(A, C)\r\n    if (sqr_dist < R * R) return -1; // trong hinh tron\r\n    if (sqr_dist == R * R) return 0; // tren bien hinh tron\r\n    if (sqr_dist > R * R) return 1;  // ngoai hinh tron\r\n}\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nbool insideCircle(std::vector<int> point, std::vector<int> center, int radius)\r\n{\r\n   return (pow((center[0]-point[0]),2)+pow((center[1]-point[1]),2) <= radius*radius)?true:false;\r\n}\r\n', 10, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(60, 'Vòng lặp: while và do-while', 'Cho một mảng các số nguyên, bạn hãy viết hàm kiểm tra xem các phần tử của mảng có tạo thành một dãy số tăng dần hoặc giảm dần hay không, nếu có return true, ngược lại return false.\r\n\r\nVí du\r\nVới sequence = [1, 4, 5, 7, 9], thì kết quả là isMonotonous(sequence) = true\r\nVới sequence = [0], thì kết quả là isMonotonous(sequence) = true;\r\nVới sequence = [3, 3], thì kết quả là isMonotonous(sequence) = false.\r\nGiải thích: 2 phần tử bằng nhau không tạo thành dãy tăng hay dãy giảm.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] array.integer sequence\r\nĐiều kiện:\r\n1 ≤ sequence.length ≤ 10,\r\n-250 ≤ sequence[i] ≤ 250.\r\n\r\n[Đầu ra] boolean\r\ntrue nếu sequence là dãy tăng hoặc dãy giảm, false trong trường hợp ngược lại.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nbool isMonotonous(std::vector<int> sequence)\r\n{\r\n    if (sequence.size() == 1)\r\n        return true;\r\n    if (sequence.size() == 2)\r\n        return (sequence[0] != sequence[1]);\r\n    for (int i = 2; i < sequence.size(); i++)\r\n        if ((sequence[i-1] - sequence[i-2])*(sequence[i]-sequence[i-1]) <= 0) \r\n            return false;\r\n    return true;\r\n}', 10, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(61, 'Chương trình đầu tiên và chú thích', 'Chúng ta có một số nguyên dương n. Mỗi một lần ta thay thế n bằng tổng các thừa số nguyên tố của nó (ví dụ 12=2*2*3 thì 12 sẽ được thay thế bằng số 2+2+3=7)\r\n\r\nChúng ta áp dụng phép toán này vào số hiện tại cho đến khi kết quả thu được giống vs số hiện tại\r\n\r\nCho một số tự nhiên, hãy tìm kết quả cuối cùng của phép toán trên.\r\n\r\nVí dụ:\r\n\r\nVới n = 24, kết quả factorSum(n) = 5.\r\n24 -> (2 + 2 + 2 + 3) = 9 -> (3 + 3) = 6 -> (2 + 3) = 5 -> 5.\r\nVì vậy kết quả trong trường hợp n = 24 là 5.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] integer n\r\nĐiều kiện:\r\n2 ≤ n ≤ 200.\r\n[Đầu ra] integer\r\n\r\nLý thuyết\r\nCách kiểm tra một số nguyên dương n có phải một số nguyên tố hay không ? \r\n\r\nNhận thấy rằng một số nguyên n > 1 không phải là một số nguyên tố khi và chỉ khi n có thể biểu diễn dưới dạng : n = x * y, với x,y là hai số nguyên dương lớn hơn 1.\r\nGiả sử răng x ≤ y ⇒ x * x ≤ x * y = n ⇒ x ≤ √n \r\nTừ nhận xét trên ta thấy rằng để kiểm tra xem n có chia hết cho một số nào nhỏ hơn nó hay không ta chỉ việc xét các số từ 2 đến √n thay vì xét các số từ 2 đến n-1 như Cách 1 \r\nbool isPrime(int n)\r\n{\r\n    if (n <= 1) return false;\r\n    for (int i = 2; i <= sqrt(n); ++i) \r\n        if (n % i == 0) return false;\r\n    return true;\r\n}\r\nĐộ phức tạp : O(√n)\r\nHướng dẫn bài tập.\r\nVới bài tập này ta không cần nhất thiết phải kiểm tra số nguyên tố.\r\n\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nint solve(int n){\r\n    int k = 2, sum = 0;\r\n    while (n > 1){\r\n        while (n % k == 0){\r\n            sum += k;\r\n            n /= k;\r\n        }\r\n        k++;\r\n    }\r\n    return sum;\r\n}\r\nint factorSum(int n)\r\n{\r\n    while (n != solve(n))\r\n        n = solve(n);\r\n    return n;\r\n}', 11, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(63, 'Các toán tử', 'Cho xâu kí tự. Hãy đếm số lượng kí tự khác nhau trong xâu đó\r\nVí dụ:\r\nVới s = \"\"cabca\"\", thì kết quả differentSymbolsNaive(s) = 3.\r\nCó 3 kí tự khác nhau là a, b và c.\r\n\r\nĐầu vào/Đầu ra:\r\n[Thời gian chạy] 0.5 seconds\r\n[Đầu vào] string s\r\nXâu kí tự chứa các chữ cái in thường.\r\nGuaranteed constraints:\r\n3 ≤ s.length ≤ 1000.\r\n[Đầu ra] integer.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nint differentSymbolsNaive(std::string s)\r\n{\r\n    vector <bool> b(256, false);\r\n    for (int i = 0; i < s.length(); i++)\r\n        b[s[i]] = true;\r\n    int d = 0;\r\n    for (int i = 0; i < s.length(); i++)\r\n    if (b[s[i]]){\r\n        d++;\r\n        b[s[i]] = false;\r\n    }\r\n    return d;\r\n}', 11, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(64, 'Các câu lệnh điều kiện', 'Cho số nguyên dương n. Hãy tạo ra ma trận vuông kích thước n*n chứa các số từ 1 tới n*n tăng dần theo hình xoắn ốc, xuất phát từ ô trên trái và đi theo theo theo chiều kim đồng hồ\r\n\r\nVí dụ\r\nVới n = 3, kết quả\r\nspiralNumbers(n) = [[1, 2, 3],\r\n                    [8, 9, 4],\r\n                    [7, 6, 5]]\r\n\r\nĐầu vào/đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] integer n\r\nĐộ dài của ma trận\r\nĐiều kiện:\r\n3 ≤ n ≤ 100.\r\n[Đầu ra] matrix.integer\r\n\r\nGợi ý:\r\n\r\nTạo ra ma trận kích thước n*n\r\nSử dụng 2 biến để lưu trữ hàng và cột hiện tại, bắt đầu xuất phát từ ô (0,0) (trên trái)\r\nSử dụng 1 biến để lưu trữ giá trị hiện tại của số nằm trong ma trận. Biến này sẽ tăng dần từ 1 cho tới n*n\r\nĐiền số vào ma trận theo nguyên tắc:\r\nVới cạnh đi từ trái qua phải: tăng dần cột, giữ nguyên hàng\r\nVới cạnh đi từ trên xuống dưới: tăng dần hàng, giữ nguyên cột\r\nVới cạnh đi từ phải qua trái: giảm dần cột, giữ nguyên hàng\r\nVới cạnh đi từ dưới lên trên: giảm dần hàng, giữ nguyên cột.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nstd::vector<std::vector<int>> spiralNumbers(int n)\r\n{\r\n    std::vector<std::vector<int>> a;\r\n    std::vector<int> b;\r\n    for (int i=0; i<n; i++) b.push_back(1);\r\n    for (int i=0; i<n; i++) a.push_back(b);\r\n    int l=0;\r\n    int r = n-1;\r\n    int k=0;\r\n    while (k<n*n){\r\n        if (k<n*n){\r\n            for (int j=l; j<=r; j++){\r\n                k++;\r\n                a[l][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=l+1; i<=r; i++){\r\n                k++;\r\n                a[i][r] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int j=r-1; j>=l; j--){\r\n                k++;\r\n                a[r][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=r-1; i>=l+1; i--){\r\n                k++;\r\n                a[i][l] = k;\r\n            }\r\n        }\r\n        l++; r--;\r\n    }\r\n    return a;\r\n}', 11, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(65, 'Vòng lặp', 'Cho tọa độ tâm và bán kính của một đường tròn cùng tọa độ của một điểm trên mặt phẳng 2 chiều\r\n\r\nKiểm tra xem điểm có nằm trong (hoặc nằm trên viền) của đường tròn hay không?\r\n\r\nVí dụ\r\n\r\nVới point = [1, 1], center = [2, 2], và radius = 1, kết quả insideCircle(point, center, radius) = false.\r\nVới point = [1, 1], center = [0, 0], và radius = 3, kết quả insideCircle(point, center, radius) = true.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] array.integer point\r\nMảng 2 phần tử thể hiện tọa độ của điểm cần kiểm tra.\r\nĐiều kiện:\r\n-100 ≤ point[i] ≤ 100.\r\n\r\n[Đầu vào] array.integer center\r\nMảng 2 phần tử thể hiện tọa độ tâm của đường tròn\r\nĐiều kiện:\r\n-10 ≤ center[i] ≤ 10.\r\n\r\n[Đầu vào] integer radius\r\nBán kính đường tròn.\r\nĐiều kiện:\r\n1 ≤ radius ≤ 5.\r\n\r\n[Đầu ra] boolean\r\ntrue nếu point nằm trong đường tròn, false nếu ngược lại.\r\n\r\nLý thuyết :\r\nCho hệ Oxy, 1 điểm A(x, y) và 1 hình tròn có tâm tại C(xC, yC), bán kính R\r\nKhi đó có 3 quan hệ : \r\ndist(A, C) < R : điểm A nằm trong hình tròn\r\ndist(A, C) = R : điểm A ở trên biên hình tròn\r\ndist(A, C) > R : điểm A nằm ngoài hình tròn với dist(A, C) là khoảng cách giữa điểm A và điểm C\r\n\r\nCode minh họa\r\nint sqr(int x) { // tra ve binh phuong cua 1 so\r\n    return x * x;\r\n}\r\nint checkPointCircle(vector <int> A, vector <int> C, int R) {\r\n    int sqr_dist = sqr(C[0] - A[0]) + sqr(C[1] - A[1]);\r\n    // binh phuong dist(A, C)\r\n    if (sqr_dist < R * R) return -1; // trong hinh tron\r\n    if (sqr_dist == R * R) return 0; // tren bien hinh tron\r\n    if (sqr_dist > R * R) return 1;  // ngoai hinh tron\r\n}\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nbool insideCircle(std::vector<int> point, std::vector<int> center, int radius)\r\n{\r\n   return (pow((center[0]-point[0]),2)+pow((center[1]-point[1]),2) <= radius*radius)?true:false;\r\n}\r\n', 11, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(66, 'Vòng lặp: while và do-while', 'Cho một mảng các số nguyên, bạn hãy viết hàm kiểm tra xem các phần tử của mảng có tạo thành một dãy số tăng dần hoặc giảm dần hay không, nếu có return true, ngược lại return false.\r\n\r\nVí du\r\nVới sequence = [1, 4, 5, 7, 9], thì kết quả là isMonotonous(sequence) = true\r\nVới sequence = [0], thì kết quả là isMonotonous(sequence) = true;\r\nVới sequence = [3, 3], thì kết quả là isMonotonous(sequence) = false.\r\nGiải thích: 2 phần tử bằng nhau không tạo thành dãy tăng hay dãy giảm.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] array.integer sequence\r\nĐiều kiện:\r\n1 ≤ sequence.length ≤ 10,\r\n-250 ≤ sequence[i] ≤ 250.\r\n\r\n[Đầu ra] boolean\r\ntrue nếu sequence là dãy tăng hoặc dãy giảm, false trong trường hợp ngược lại.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nbool isMonotonous(std::vector<int> sequence)\r\n{\r\n    if (sequence.size() == 1)\r\n        return true;\r\n    if (sequence.size() == 2)\r\n        return (sequence[0] != sequence[1]);\r\n    for (int i = 2; i < sequence.size(); i++)\r\n        if ((sequence[i-1] - sequence[i-2])*(sequence[i]-sequence[i-1]) <= 0) \r\n            return false;\r\n    return true;\r\n}', 11, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(67, 'Số học', 'Chúng ta có một số nguyên dương n. Mỗi một lần ta thay thế n bằng tổng các thừa số nguyên tố của nó (ví dụ 12=2*2*3 thì 12 sẽ được thay thế bằng số 2+2+3=7)\r\n\r\nChúng ta áp dụng phép toán này vào số hiện tại cho đến khi kết quả thu được giống vs số hiện tại\r\n\r\nCho một số tự nhiên, hãy tìm kết quả cuối cùng của phép toán trên.\r\n\r\nVí dụ:\r\n\r\nVới n = 24, kết quả factorSum(n) = 5.\r\n24 -> (2 + 2 + 2 + 3) = 9 -> (3 + 3) = 6 -> (2 + 3) = 5 -> 5.\r\nVì vậy kết quả trong trường hợp n = 24 là 5.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] integer n\r\nĐiều kiện:\r\n2 ≤ n ≤ 200.\r\n[Đầu ra] integer\r\n\r\nLý thuyết\r\nCách kiểm tra một số nguyên dương n có phải một số nguyên tố hay không ? \r\n\r\nNhận thấy rằng một số nguyên n > 1 không phải là một số nguyên tố khi và chỉ khi n có thể biểu diễn dưới dạng : n = x * y, với x,y là hai số nguyên dương lớn hơn 1.\r\nGiả sử răng x ≤ y ⇒ x * x ≤ x * y = n ⇒ x ≤ √n \r\nTừ nhận xét trên ta thấy rằng để kiểm tra xem n có chia hết cho một số nào nhỏ hơn nó hay không ta chỉ việc xét các số từ 2 đến √n thay vì xét các số từ 2 đến n-1 như Cách 1 \r\nbool isPrime(int n)\r\n{\r\n    if (n <= 1) return false;\r\n    for (int i = 2; i <= sqrt(n); ++i) \r\n        if (n % i == 0) return false;\r\n    return true;\r\n}\r\nĐộ phức tạp : O(√n)\r\nHướng dẫn bài tập.\r\nVới bài tập này ta không cần nhất thiết phải kiểm tra số nguyên tố.\r\n\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nint solve(int n){\r\n    int k = 2, sum = 0;\r\n    while (n > 1){\r\n        while (n % k == 0){\r\n            sum += k;\r\n            n /= k;\r\n        }\r\n        k++;\r\n    }\r\n    return sum;\r\n}\r\nint factorSum(int n)\r\n{\r\n    while (n != solve(n))\r\n        n = solve(n);\r\n    return n;\r\n}', 12, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(69, 'Đếm', 'Cho xâu kí tự. Hãy đếm số lượng kí tự khác nhau trong xâu đó\r\nVí dụ:\r\nVới s = \"\"cabca\"\", thì kết quả differentSymbolsNaive(s) = 3.\r\nCó 3 kí tự khác nhau là a, b và c.\r\n\r\nĐầu vào/Đầu ra:\r\n[Thời gian chạy] 0.5 seconds\r\n[Đầu vào] string s\r\nXâu kí tự chứa các chữ cái in thường.\r\nGuaranteed constraints:\r\n3 ≤ s.length ≤ 1000.\r\n[Đầu ra] integer.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nint differentSymbolsNaive(std::string s)\r\n{\r\n    vector <bool> b(256, false);\r\n    for (int i = 0; i < s.length(); i++)\r\n        b[s[i]] = true;\r\n    int d = 0;\r\n    for (int i = 0; i < s.length(); i++)\r\n    if (b[s[i]]){\r\n        d++;\r\n        b[s[i]] = false;\r\n    }\r\n    return d;\r\n}', 12, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(70, 'Ma trận', 'Cho số nguyên dương n. Hãy tạo ra ma trận vuông kích thước n*n chứa các số từ 1 tới n*n tăng dần theo hình xoắn ốc, xuất phát từ ô trên trái và đi theo theo theo chiều kim đồng hồ\r\n\r\nVí dụ\r\nVới n = 3, kết quả\r\nspiralNumbers(n) = [[1, 2, 3],\r\n                    [8, 9, 4],\r\n                    [7, 6, 5]]\r\n\r\nĐầu vào/đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] integer n\r\nĐộ dài của ma trận\r\nĐiều kiện:\r\n3 ≤ n ≤ 100.\r\n[Đầu ra] matrix.integer\r\n\r\nGợi ý:\r\n\r\nTạo ra ma trận kích thước n*n\r\nSử dụng 2 biến để lưu trữ hàng và cột hiện tại, bắt đầu xuất phát từ ô (0,0) (trên trái)\r\nSử dụng 1 biến để lưu trữ giá trị hiện tại của số nằm trong ma trận. Biến này sẽ tăng dần từ 1 cho tới n*n\r\nĐiền số vào ma trận theo nguyên tắc:\r\nVới cạnh đi từ trái qua phải: tăng dần cột, giữ nguyên hàng\r\nVới cạnh đi từ trên xuống dưới: tăng dần hàng, giữ nguyên cột\r\nVới cạnh đi từ phải qua trái: giảm dần cột, giữ nguyên hàng\r\nVới cạnh đi từ dưới lên trên: giảm dần hàng, giữ nguyên cột.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nstd::vector<std::vector<int>> spiralNumbers(int n)\r\n{\r\n    std::vector<std::vector<int>> a;\r\n    std::vector<int> b;\r\n    for (int i=0; i<n; i++) b.push_back(1);\r\n    for (int i=0; i<n; i++) a.push_back(b);\r\n    int l=0;\r\n    int r = n-1;\r\n    int k=0;\r\n    while (k<n*n){\r\n        if (k<n*n){\r\n            for (int j=l; j<=r; j++){\r\n                k++;\r\n                a[l][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=l+1; i<=r; i++){\r\n                k++;\r\n                a[i][r] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int j=r-1; j>=l; j--){\r\n                k++;\r\n                a[r][j] = k;\r\n            }\r\n        }\r\n        if (k<n*n){\r\n            for (int i=r-1; i>=l+1; i--){\r\n                k++;\r\n                a[i][l] = k;\r\n            }\r\n        }\r\n        l++; r--;\r\n    }\r\n    return a;\r\n}', 12, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(71, 'Hình học', 'Cho tọa độ tâm và bán kính của một đường tròn cùng tọa độ của một điểm trên mặt phẳng 2 chiều\r\n\r\nKiểm tra xem điểm có nằm trong (hoặc nằm trên viền) của đường tròn hay không?\r\n\r\nVí dụ\r\n\r\nVới point = [1, 1], center = [2, 2], và radius = 1, kết quả insideCircle(point, center, radius) = false.\r\nVới point = [1, 1], center = [0, 0], và radius = 3, kết quả insideCircle(point, center, radius) = true.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] array.integer point\r\nMảng 2 phần tử thể hiện tọa độ của điểm cần kiểm tra.\r\nĐiều kiện:\r\n-100 ≤ point[i] ≤ 100.\r\n\r\n[Đầu vào] array.integer center\r\nMảng 2 phần tử thể hiện tọa độ tâm của đường tròn\r\nĐiều kiện:\r\n-10 ≤ center[i] ≤ 10.\r\n\r\n[Đầu vào] integer radius\r\nBán kính đường tròn.\r\nĐiều kiện:\r\n1 ≤ radius ≤ 5.\r\n\r\n[Đầu ra] boolean\r\ntrue nếu point nằm trong đường tròn, false nếu ngược lại.\r\n\r\nLý thuyết :\r\nCho hệ Oxy, 1 điểm A(x, y) và 1 hình tròn có tâm tại C(xC, yC), bán kính R\r\nKhi đó có 3 quan hệ : \r\ndist(A, C) < R : điểm A nằm trong hình tròn\r\ndist(A, C) = R : điểm A ở trên biên hình tròn\r\ndist(A, C) > R : điểm A nằm ngoài hình tròn với dist(A, C) là khoảng cách giữa điểm A và điểm C\r\n\r\nCode minh họa\r\nint sqr(int x) { // tra ve binh phuong cua 1 so\r\n    return x * x;\r\n}\r\nint checkPointCircle(vector <int> A, vector <int> C, int R) {\r\n    int sqr_dist = sqr(C[0] - A[0]) + sqr(C[1] - A[1]);\r\n    // binh phuong dist(A, C)\r\n    if (sqr_dist < R * R) return -1; // trong hinh tron\r\n    if (sqr_dist == R * R) return 0; // tren bien hinh tron\r\n    if (sqr_dist > R * R) return 1;  // ngoai hinh tron\r\n}\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nbool insideCircle(std::vector<int> point, std::vector<int> center, int radius)\r\n{\r\n   return (pow((center[0]-point[0]),2)+pow((center[1]-point[1]),2) <= radius*radius)?true:false;\r\n}\r\n', 12, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(72, 'Dãy số', 'Cho một mảng các số nguyên, bạn hãy viết hàm kiểm tra xem các phần tử của mảng có tạo thành một dãy số tăng dần hoặc giảm dần hay không, nếu có return true, ngược lại return false.\r\n\r\nVí du\r\nVới sequence = [1, 4, 5, 7, 9], thì kết quả là isMonotonous(sequence) = true\r\nVới sequence = [0], thì kết quả là isMonotonous(sequence) = true;\r\nVới sequence = [3, 3], thì kết quả là isMonotonous(sequence) = false.\r\nGiải thích: 2 phần tử bằng nhau không tạo thành dãy tăng hay dãy giảm.\r\n\r\nĐầu vào/Đầu ra\r\n[Thời gian chạy] 0.5 giây\r\n[Đầu vào] array.integer sequence\r\nĐiều kiện:\r\n1 ≤ sequence.length ≤ 10,\r\n-250 ≤ sequence[i] ≤ 250.\r\n\r\n[Đầu ra] boolean\r\ntrue nếu sequence là dãy tăng hoặc dãy giảm, false trong trường hợp ngược lại.\r\n\r\nHướng dẫn bài tập.\r\nCode mẫu:\r\n\r\nNgôn ngữ C++:\r\n\r\nbool isMonotonous(std::vector<int> sequence)\r\n{\r\n    if (sequence.size() == 1)\r\n        return true;\r\n    if (sequence.size() == 2)\r\n        return (sequence[0] != sequence[1]);\r\n    for (int i = 2; i < sequence.size(); i++)\r\n        if ((sequence[i-1] - sequence[i-2])*(sequence[i]-sequence[i-1]) <= 0) \r\n            return false;\r\n    return true;\r\n}', 12, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(73, 'Hàm toán học', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 13, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(74, 'Thao tác với văn bản', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 13, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(75, 'Làm việc với ngày/giờ', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 13, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(76, 'Các mệnh đề SET', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 13, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', '');
INSERT INTO `lesson` (`lessonId`, `title`, `content`, `courseId`, `description`, `captionLink`, `link`) VALUES
(77, 'Biểu thức điều kiện', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 13, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(78, 'Truy vấn con', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 13, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(79, 'Cấu trúc dữ liệu mảng', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 14, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(80, 'Ngăn xếp và hàng đợi', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 14, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(81, 'Danh sách liên kết', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 14, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(82, 'Giải thuật tìm kiếm', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n	string name;\r\n	string gender;\r\n\r\npublic:\r\n	Person(string name, string gender) {\r\n		this->name = name;\r\n		this->gender = gender;\r\n	}\r\n\r\n	string getName() {\r\n		return name;\r\n	}\r\n\r\n	void setName(string name) {\r\n		this->name = name;\r\n	}\r\n\r\n	string getGender() {\r\n		return gender;\r\n	}\r\n\r\n	void setGender(string gender) {\r\n		this->gender = gender;\r\n	}\r\n\r\n	void display() {\r\n		cout << \"\"Name: \"\" << name << endl;\r\n		cout << \"\"Gender: \"\" << gender << endl;\r\n	}\r\n};\r\n\r\nclass Student : Person {\r\n	...\r\n};\r\n\r\nint main() {\r\n	Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n	s.display();\r\n	return 0;\r\n}', 14, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(83, 'Giải thuật sắp xếp', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 14, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(84, 'Giải thuật đệ quy', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 14, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(85, 'Lớp và đối tượng', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 15, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(86, 'Biến tĩnh, phương thức tĩnh', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 15, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(87, 'Tính đóng gói', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 15, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(88, 'Tính kế thừa', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 15, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(89, 'Tính đa hình và trừu tượng', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 15, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(90, 'Mối quan hệ giữa các đối tượng', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 15, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(91, 'Con trỏ', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 16, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(92, 'Mảng', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 16, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(93, 'Các phép toán thao tác bit', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 16, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(94, 'Kiểu cấu trúc', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 16, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(95, 'Stack', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 16, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', ''),
(96, 'Queue', 'Bạn hãy điền code vào dấu ... để chương trình hiển thị ra màn hình thông tin sau:\r\nName: Hieu\r\nGender: Male\r\nSalary: 1700\r\n\r\nCode của chương trình cần điền:\r\n\r\n#include<iostream>\r\n\r\nusing namespace std;\r\n\r\nclass Person {\r\nprivate:\r\n        string name;\r\n        string gender;\r\n\r\npublic:\r\n        Person(string name, string gender) {\r\n                this->name = name;\r\n                this->gender = gender;\r\n        }\r\n\r\n        string getName() {\r\n                return name;\r\n        }\r\n\r\n        void setName(string name) {\r\n                this->name = name;\r\n        }\r\n\r\n        string getGender() {\r\n                return gender;\r\n        }\r\n\r\n        void setGender(string gender) {\r\n                this->gender = gender;\r\n        }\r\n\r\n        void display() {\r\n                cout << \"\"Name: \"\" << name << endl;\r\n                cout << \"\"Gender: \"\" << gender << endl;\r\n        }\r\n};\r\n\r\nclass Student : Person {\r\n        ...\r\n};\r\n\r\nint main() {\r\n        Student s(\"\"Trung\"\", \"\"Male\"\", 1700);\r\n        s.display();\r\n        return 0;\r\n}', 16, 'Học bài này để giúp bạn giỏi hơn về lập trình và mọi thứ liên quan đến lập trình', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `receipt`
--

CREATE TABLE `receipt` (
  `receiptId` int(11) NOT NULL,
  `totalPrice` float NOT NULL DEFAULT 0,
  `timeReceipt` datetime NOT NULL,
  `registerId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `register`
--

CREATE TABLE `register` (
  `registerId` int(11) NOT NULL,
  `timeReg` datetime NOT NULL,
  `userId` varchar(767) NOT NULL,
  `courseId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `register`
--

INSERT INTO `register` (`registerId`, `timeReg`, `userId`, `courseId`) VALUES
(29, '2021-12-29 23:56:00', '677aa397-36b0-4676-a955-7e6c4297fb3a', 15),
(30, '2021-12-29 02:23:06', 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 4),
(31, '2021-12-29 02:23:06', 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 5),
(32, '2021-12-31 09:13:33', 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 2),
(33, '2021-12-31 09:13:33', 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 1),
(34, '2021-12-31 09:13:33', 'f5ebe639-df16-4e3e-bbc9-8e7dc9400707', 7);

-- --------------------------------------------------------

--
-- Table structure for table `topic`
--

CREATE TABLE `topic` (
  `topicId` int(11) NOT NULL,
  `topicName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `topic`
--

INSERT INTO `topic` (`topicId`, `topicName`) VALUES
(3, 'Kiến thức cơ bản'),
(4, 'Lập trình cơ bản'),
(5, 'Lập trình nâng cao'),
(6, 'Giải quyết vấn đề'),
(7, ' Kỹ năng nâng cao');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211120083840_MyCourse', '3.1.21'),
('20211120132739_MyCourse1', '3.1.21'),
('20211120141633_MyCourse2', '3.1.21'),
('20211120143044_MyCourse3', '3.1.21'),
('20211128041820_identity', '3.1.21'),
('20211128045858_identitynew', '3.1.21'),
('20211128050338_identitynew1', '3.1.21'),
('20211128050538_identitynew2', '3.1.21'),
('20211128051445_identitynew3', '3.1.21'),
('20211128085942_new', '3.1.21'),
('20211205124723_new1', '3.1.21'),
('20211206044011_new2', '3.1.21'),
('20211208080032_new3', '3.1.21'),
('20211214154704_addcontactmodel', '3.1.21'),
('20211217075108_new4', '3.1.21'),
('20211217084053_new5', '3.1.21'),
('20211218025334_new6', '3.1.21'),
('20211219170614_new7', '3.1.21'),
('20211220023920_new8', '3.1.21'),
('20211223022359_new10', '3.1.21'),
('20211223083535_new11', '3.1.21'),
('20211224154413_new12', '3.1.21'),
('20211227145838_new13', '3.1.21'),
('20211228080008_new14', '3.1.21'),
('20211229033408_new15', '3.1.21'),
('20220101155419_new16', '3.1.21');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `approle`
--
ALTER TABLE `approle`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `approleclaim`
--
ALTER TABLE `approleclaim`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `appuser`
--
ALTER TABLE `appuser`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `appuserclaim`
--
ALTER TABLE `appuserclaim`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `appuserlogin`
--
ALTER TABLE `appuserlogin`
  ADD PRIMARY KEY (`UserId`);

--
-- Indexes for table `appuserrole`
--
ALTER TABLE `appuserrole`
  ADD PRIMARY KEY (`UserId`,`RoleId`);

--
-- Indexes for table `appusertoken`
--
ALTER TABLE `appusertoken`
  ADD PRIMARY KEY (`UserId`);

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`cmtId`),
  ADD KEY `comment_ibfk_1` (`userId`),
  ADD KEY `IX_comment_courseId` (`courseId`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`courseId`),
  ADD KEY `IX_course_discountId` (`discountId`),
  ADD KEY `IX_course_topicId` (`topicId`);

--
-- Indexes for table `discount`
--
ALTER TABLE `discount`
  ADD PRIMARY KEY (`discountId`);

--
-- Indexes for table `exercise`
--
ALTER TABLE `exercise`
  ADD PRIMARY KEY (`exerciseId`),
  ADD KEY `IX_exercise_lessonId` (`lessonId`),
  ADD KEY `teacher_id` (`userId`);

--
-- Indexes for table `exerciseinuser`
--
ALTER TABLE `exerciseinuser`
  ADD PRIMARY KEY (`exerciseId`,`userId`),
  ADD KEY `IX_exerciseInUser_exerciseId` (`exerciseId`),
  ADD KEY `userId` (`userId`);

--
-- Indexes for table `lesson`
--
ALTER TABLE `lesson`
  ADD PRIMARY KEY (`lessonId`),
  ADD KEY `IX_lesson_courseId` (`courseId`);

--
-- Indexes for table `receipt`
--
ALTER TABLE `receipt`
  ADD PRIMARY KEY (`receiptId`),
  ADD KEY `IX_receipt_registerId` (`registerId`);

--
-- Indexes for table `register`
--
ALTER TABLE `register`
  ADD PRIMARY KEY (`registerId`),
  ADD KEY `IX_register_courseId` (`courseId`),
  ADD KEY `IX_register_userId` (`userId`);

--
-- Indexes for table `topic`
--
ALTER TABLE `topic`
  ADD PRIMARY KEY (`topicId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `approleclaim`
--
ALTER TABLE `approleclaim`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `appuserclaim`
--
ALTER TABLE `appuserclaim`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `comment`
--
ALTER TABLE `comment`
  MODIFY `cmtId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `courseId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `discount`
--
ALTER TABLE `discount`
  MODIFY `discountId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `exercise`
--
ALTER TABLE `exercise`
  MODIFY `exerciseId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `lesson`
--
ALTER TABLE `lesson`
  MODIFY `lessonId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

--
-- AUTO_INCREMENT for table `receipt`
--
ALTER TABLE `receipt`
  MODIFY `receiptId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `register`
--
ALTER TABLE `register`
  MODIFY `registerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `topic`
--
ALTER TABLE `topic`
  MODIFY `topicId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `comment_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `appuser` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `comment_ibfk_2` FOREIGN KEY (`courseId`) REFERENCES `course` (`courseId`);

--
-- Constraints for table `course`
--
ALTER TABLE `course`
  ADD CONSTRAINT `FK_course_discount_discountId` FOREIGN KEY (`discountId`) REFERENCES `discount` (`discountId`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_course_topic_topicId` FOREIGN KEY (`topicId`) REFERENCES `topic` (`topicId`) ON DELETE CASCADE;

--
-- Constraints for table `exercise`
--
ALTER TABLE `exercise`
  ADD CONSTRAINT `FK_exercise_lesson_lessonId` FOREIGN KEY (`lessonId`) REFERENCES `lesson` (`lessonId`) ON DELETE CASCADE,
  ADD CONSTRAINT `exercise_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `appuser` (`Id`);

--
-- Constraints for table `exerciseinuser`
--
ALTER TABLE `exerciseinuser`
  ADD CONSTRAINT `FK_exerciseInUser_exercise_exerciseId` FOREIGN KEY (`exerciseId`) REFERENCES `exercise` (`exerciseId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `exerciseinuser_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `appuser` (`Id`);

--
-- Constraints for table `lesson`
--
ALTER TABLE `lesson`
  ADD CONSTRAINT `FK_lesson_course_courseId` FOREIGN KEY (`courseId`) REFERENCES `course` (`courseId`) ON DELETE CASCADE;

--
-- Constraints for table `receipt`
--
ALTER TABLE `receipt`
  ADD CONSTRAINT `FK_receipt_register_registerId` FOREIGN KEY (`registerId`) REFERENCES `register` (`registerId`) ON DELETE CASCADE;

--
-- Constraints for table `register`
--
ALTER TABLE `register`
  ADD CONSTRAINT `FK_register_course_courseId` FOREIGN KEY (`courseId`) REFERENCES `course` (`courseId`) ON DELETE CASCADE,
  ADD CONSTRAINT `register_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `appuser` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
