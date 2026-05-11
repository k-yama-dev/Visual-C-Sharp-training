-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- ホスト: localhost
-- 生成日時: 2026-05-11 04:56:14
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
-- テーブルの構造 `moneytable`
--

CREATE TABLE `moneytable` (
  `id` int NOT NULL,
  `日付` date NOT NULL,
  `分類` varchar(30) COLLATE utf8mb4_general_ci NOT NULL,
  `品名` varchar(30) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `金額` int DEFAULT NULL,
  `備考` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `moneytable`
--

INSERT INTO `moneytable` (`id`, `日付`, `分類`, `品名`, `金額`, `備考`) VALUES
(8, '2026-04-28', '家賃', '家賃', 55000, '4月分'),
(9, '2026-05-05', '給料', 'GOGO', 30000, '4月分'),
(10, '2026-05-11', '交通費', '高速代', 1150, '朝'),
(12, '2026-05-06', '食費', 'めっけもん', 3000, '中村屋'),
(13, '2026-05-11', '食費', 'Maｒshmallow', 330, 'msm'),
(14, '2026-05-11', '交通費', 'パーキング', 900, 'nothing');

--
-- ダンプしたテーブルのインデックス
--

--
-- テーブルのインデックス `moneytable`
--
ALTER TABLE `moneytable`
  ADD PRIMARY KEY (`id`);

--
-- ダンプしたテーブルの AUTO_INCREMENT
--

--
-- テーブルの AUTO_INCREMENT `moneytable`
--
ALTER TABLE `moneytable`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
