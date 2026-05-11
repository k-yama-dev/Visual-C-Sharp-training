-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- ホスト: localhost
-- 生成日時: 2026-05-11 04:56:22
-- サーバのバージョン： 8.0.45
-- PHP のバージョン: 8.2.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- データベース: `mydb`
--

-- --------------------------------------------------------

--
-- テーブルの構造 `categorytable`
--

CREATE TABLE `categorytable` (
  `分類` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `入出金分類` varchar(10) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `categorytable`
--

INSERT INTO `categorytable` (`分類`, `入出金分類`) VALUES
('交通費', '出金'),
('家賃', '出金'),
('給料', '入金'),
('食費', '出金');

--
-- ダンプしたテーブルのインデックス
--

--
-- テーブルのインデックス `categorytable`
--
ALTER TABLE `categorytable`
  ADD PRIMARY KEY (`分類`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
