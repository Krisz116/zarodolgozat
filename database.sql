-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Már 22. 08:38
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `zaro`
--
CREATE DATABASE IF NOT EXISTS `zaro` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `zaro`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `alt_iskolak`
--

CREATE TABLE `alt_iskolak` (
  `Isk_ID` int(11) NOT NULL,
  `Isk_nev` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `alt_iskolak`
--

INSERT INTO `alt_iskolak` (`Isk_ID`, `Isk_nev`) VALUES
(1, 'Bardos Lajos Altalános Iskola'),
(2, 'Gönczy Pál Református és Két  Tannyelvű Általános Iskola'),
(3, 'Thököly Imre Kéttannyelvű Általános Iskola'),
(4, 'Nagyrábé Mórincz Zsigmond Általános Iskola'),
(5, 'Éltes Lajos Általános Iskola'),
(6, 'Arany János Magyar-Angol Két Tanítási Nyelvű Általános Iskola és AMI'),
(7, 'Diószegi Lajos Általános Iskola'),
(8, 'Kövy Sándor Általános Iskola ');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `be_ki_iratkozas`
--

CREATE TABLE `be_ki_iratkozas` (
  `ID` int(11) NOT NULL,
  `Diak_ID` varchar(255) NOT NULL,
  `Isk_ID` int(11) NOT NULL,
  `Ki_Be` varchar(255) NOT NULL,
  `Datum` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `be_ki_iratkozas`
--

INSERT INTO `be_ki_iratkozas` (`ID`, `Diak_ID`, `Isk_ID`, `Ki_Be`, `Datum`) VALUES
(1, '1238410722', 1, '	Be', '2022.06.13'),
(2, '1235597260', 2, '	Be', '2022.06.20'),
(3, '1236118721', 2, '	Be', '2022.06.21'),
(4, '1236118758', 1, '	Be', '2022.07.04'),
(5, '1236590354', 3, '	Be', '2022.07.06'),
(6, '1237169861', 2, '	Be', '2022.07.06'),
(7, '1237169870', 4, '	Be', '2022.07.20'),
(8, '1241717003', 5, '	Be', '2022.07.30'),
(9, '1241922013', 5, '	Be', '2022.07.30'),
(10, '1241437155', 8, 'Ki', '2022.06.16'),
(11, '1242951275', 2, 'Ki', '2022.06.16'),
(12, '1246316141', 2, 'Ki', '2022.06.16'),
(13, '1240853223', 1, 'Ki', '2022.06.18'),
(14, '1240853198', 6, 'Ki', '2022.06.20'),
(15, '1240986045', 5, 'Ki', '2022.06.30'),
(16, '1241717691', 5, 'Ki', '2022.06.31'),
(17, '1241717717', 7, 'Ki', '2022.07.01'),
(18, '1241717708', 7, 'Ki', '2022.07.02');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `diak`
--

CREATE TABLE `diak` (
  `Nev` varchar(255) NOT NULL,
  `Sz_Datum` varchar(255) NOT NULL,
  `Anyja_Sz_nev` varchar(255) NOT NULL,
  `Diak_ID` varchar(255) NOT NULL,
  `osztaly` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `diak`
--

INSERT INTO `diak` (`Nev`, `Sz_Datum`, `Anyja_Sz_nev`, `Diak_ID`, `osztaly`) VALUES
('Czeglédi Győző', '2015.07.27', 'Osváth Annamária', '1018611033', '1.a'),
('Budai Izabella', '2015.04.24', 'Pindicska Henriett', '1018611088', '1.a'),
('Hagymási Brájen', '2015.08.20', 'Kaszás Angéla', '1122892692', '1.a'),
('Kenéz Jázmin', '2016.07.06', 'Baksa Ágnes', '1212572712', '1.a'),
('Győrfi Sándor Olivér', '2014.12.31', 'Jancsa Viktória', '1213085319', '1.a'),
('Zsiga Vince', '2016.01.11', 'Kaszás Anikó', '1220483688', '1.a'),
('Soós István', '2015.04.27', 'Hermann Gyöngyi', '1220483740', '1.a'),
('Soós Máté Bence', '2015.12.12', 'Tamás Mónika', '1220483759', '1.a'),
('Szilágyi Réka', '2015.07.01', 'Harangozó Adrienn', '1220483768', '1.a'),
('Karika Áron Ervin', '2015.02.23', 'Kiss Anita Erzsébet', '1220580582', '1.a'),
('Tóth-Munkácsi Miklós', '2015.02.01', 'Munkácsi Angéla Éva', '1220706215', '1.a'),
('Szűcs Farkas László', '2015.05.18', 'Csobán Julianna', '1220706279', '1.a'),
('Tóth Kristóf Dávid', '2016.07.17', 'Rézmüves Andrea Szandra', '1220706288', '1.a'),
('Makhajda Dominik', '2016.04.24', 'Nagy Zsuzsanna Lídia', '1223008946', '1.a'),
('Molnár Bence', '2014.05.31', 'Zagyi-Tóth Anita Mária', '1223008982', '1.a'),
('Kovács Sára', '2016.04.23', 'Nemes Orsolya', '1223008991', '1.a'),
('Lesi Kevin Zsolt', '2015.12.26', 'Juhász Nikolett', '1223009017', '1.a'),
('Magyar Natasa Ajsa', '2016.07.26', 'Soós Aletta', '1223009026', '1.a'),
('Miczura Dzsenifer', '2015.07.14', 'Jeremiás Ágnes', '1223009044', '1.a'),
('Kéri János', '2016.02.01', 'Kéri Katalin', '1223009062', '1.a'),
('Kovács Dániel', '2015.02.17', 'Furkó Csilla', '1223696033', '2.b'),
('Márton Krisztián ', '2010.07.16', 'Lázár Terézia', '1223717546', '6.b'),
('Szabó Julianna ', '2011.09.10', 'Csipkés Melinda', '1225283340', '5.a'),
('Szabó Regina ', '2007.09.05', 'Dede Csilla', '1225355147', '6.a'),
('Horváth Imre István', '2015.03.25', 'Gorbai Nikolett Erika', '1227525415', '1.a'),
('Lakatos Ákos', '2014.07.21', 'Nagy Erzsébet', '1229390850', '3.a'),
('Rostás Zsolt', '2015.01.09', 'Bakos Ilona', '1230858871', '3.b'),
('Szennyesi Máté', '2008.05.09', 'Nagy Adrienn', '1234146786', '7.b'),
('Nagy Jázmin', '2007.08.02', 'Juhász Ágnes', '1235596957', '8.a'),
('Pálóczi Kevin', '2010.01.23', 'Szőke Beatrix', '1235596966', '7.a'),
('Bakó Lajos', '2013.07.27', 'Tóth Mónika', '1235596984', '3.b'),
('Árva Richárd', '2008.01.03', 'Fehér Ilona', '1235596993', '7.a'),
('Kozma Dorina', '2011.04.01', 'Kiss Szilvia', '1235597000', '6.b'),
('Soós Kitti', '2007.10.25', 'Tamás Krisztina', '1235597019', '8.a'),
('Molnár Dániel', '2009.07.27', 'Kerényi Zsuzsanna', '1235597028', '8.a'),
('Fazekas Dorina', '2009.12.23', 'Hódos Krisztina', '1235597037', '6.a'),
('Molnár Lili', '2014.01.09', 'Pintye Mónika', '1235597233', '2.a'),
('Szabó Márk', '2008.12.29', 'Nagy Mária', '1235597242', '6.a'),
('Bordán Barnabás', '2013.06.25', 'Pál Szilvia', '1235597260', '4.a'),
('Juhász Fanni', '2008.06.19', 'Nagy Ibolya', '1235845037', '7.a'),
('Székely Tamás', '2012.06.03', 'Nagy Krisztina', '1236115804', '4.a'),
('Bordán Hanna', '2015.10.01', 'Czeglédi Anikó', '1236118721', '1.b'),
('Horváth József', '2008.10.04', 'Kovács Anita', '1236118730', '8.a'),
('Milák Szilárd', '2014.01.16', 'Jóna Marianna', '1236118749', '2.a'),
('Turi Csaba', '2013.08.27', 'Kerekes Tímea', '1236118758', '3.b'),
('Décsei Viktor', '2014.06.13', 'Tóth Éva', '1236118767', '2.b'),
('Németh Zoltán', '2013.05.19', 'Kökény Diána', '1236124082', '3.a'),
('Szűcs Ákos', '2008.04.22', 'Hunyadi Alida', '1236590354', '8.a'),
('Varjú Nikolett', '2010.03.19', 'Varga Emese', '1237169861', '5.a'),
('Hajdu János', '2014.05.25', 'Szarvas Erika', '1237169870', '2.b'),
('Molnár Gergő', '2015.05.21', 'Balogh Margit', '1237317880', '2.b'),
('Schmiedt Barbara', '2012.05.18', 'Vadas Erzsébet', '1238410722', '4.b'),
('Vajas Kornél', '2010.03.31', 'Nagy Szilvia', '1239019823', '6.b'),
('Jakab László ', '2013.09.15', 'Balogh Edit', '1239086457', '3.a'),
('Pálóczi Kevin', '2012.05.17', 'Szilágyi Katalin', '1239086545', '4.b'),
('Mihók Bernadett ', '2008.10.03', 'Baranyai Erika', '1239086572', '8.b'),
('Kovács Péter', '2013.02.28', 'Bende Irma', '1239086634', '4.a'),
('Mihók Tibor ', '2008.02.13', 'Szőke Erika', '1240161729', '8.a'),
('Petrohai Pálma', '2011.01.27', 'Harangozó Csenge', '1240853198', '6.a'),
('Varjú Richárd', '2007.09.26', 'Komódi Bernadett', '1240853223', '8.a'),
('Lakatos Krisztián', '2014.07.21', 'Sándor Krisztina', '1240853376', '6.a'),
('Milák Ilona', '2012.07.23', 'Oláh Mónika', '1240853394', '7.a'),
('Milák Krisztián', '2010.06.05', 'Furkó Emese', '1240853410', '7.a'),
('Szilágyi Ferenc', '2014.05.30', 'Juhász Réka', '1240986045', '4.b'),
('Mesznikov Mária', '2015.09.07', 'Hosodi Erika', '1241437155', '1.b'),
('Miklós Béla', '2014.07.29', 'Kecskés Borbála', '1241717003', '2.a'),
('NagyJázmin ', '2011.07.17', 'Tóth Adrienn', '1241717012', '4.a'),
('Balla  Anikó', '2012.09.01', 'Varga Andrea', '1241717691', '4.b'),
('Szabó Csilla', '2010.08.25', 'Magyar Anikó', '1241717708', '5.a'),
('Sóvágó Kinga', '2011.03.22', 'Szabó Emese', '1241717717', '5.a'),
('Miklós Lajos', '2010.04.28', 'Fehér Ivett', '1241922013', '7.b'),
('Zahorján Vivien', '2010.06.30', 'Kiss Róza', '1242951275', '6.b'),
('Nagy Levente ', '2012.08.11', 'Tóth Adrienn', '1243719935', '4.a'),
('Pintér Zara ', '2012.06.07', 'Sánta Anita', '1244648369', '4.b'),
('Tukacs Tibor ', '2007.01.07', 'Nagy Mária', '1244648396', '8.b'),
('Végh Zoltán Marcell ', '2011.11.26', 'Tóth Judit', '1244681884', '5.a'),
('Csobi Nikolett', '2014.03.12', 'Kiss Noémi', '1245142900', '2.a'),
('Mezei Anett ', '2013.06.15', 'Kiss Piroska', '1246242248', '5.a'),
('Fekete Kevin', '2008.05.06', 'Sin Gabriella', '1246302245', '7.a'),
('Zahorján Gergő ', '2008.04.26', 'Uri Gyöngyi', '1246316141', '8.b'),
('Bak Lili ', '2012.03.21', 'Rácz Anita', '1246485244', '4.b'),
('Kaszás Dorina', '2008.01.23', 'Jób Nikolett', '1246729455', '8.b'),
('﻿Név', 'Születési dátum', 'Anyja születési neve', 'Diákigazolvány szám', 'Osztály');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `dock`
--

CREATE TABLE `dock` (
  `ID` int(11) NOT NULL,
  `Diak_ID` varchar(255) NOT NULL,
  `Dock_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `dock`
--

INSERT INTO `dock` (`ID`, `Diak_ID`, `Dock_ID`) VALUES
(0, '1246242248', 2),
(1, '1246302245', 2),
(3, '1246242248', 1),
(4, '1225283340', 3),
(5, '1246729455', 3),
(6, '1223696033', 1),
(7, '1223717546', 2),
(8, '1237317880', 1),
(9, '1244648369', 3),
(10, '1225283340', 4),
(11, '1244681884', 1),
(12, '1244648396', 1),
(13, '1236118730', 1),
(14, '1239086457', 1),
(15, '1246242248', 2),
(16, '1239086572', 1),
(17, '1243719935', 1),
(18, '1235596957', 1),
(19, '1240161729', 1),
(20, '1229390850', 1),
(21, '1246302245', 2),
(22, '1225355147', 3),
(23, '1240853376', 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `dokumentum`
--

CREATE TABLE `dokumentum` (
  `DocK_ID` int(11) NOT NULL,
  `Dock_Nev` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `dokumentum`
--

INSERT INTO `dokumentum` (`DocK_ID`, `Dock_Nev`) VALUES
(1, 'Of_jell'),
(2, 'Visszajell_lap'),
(3, 'Hianyzas'),
(4, 'Elhelyezes_Ugy');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `alt_iskolak`
--
ALTER TABLE `alt_iskolak`
  ADD PRIMARY KEY (`Isk_ID`);

--
-- A tábla indexei `be_ki_iratkozas`
--
ALTER TABLE `be_ki_iratkozas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Diak_ID` (`Diak_ID`),
  ADD KEY `Isk_ID` (`Isk_ID`);

--
-- A tábla indexei `diak`
--
ALTER TABLE `diak`
  ADD PRIMARY KEY (`Diak_ID`);

--
-- A tábla indexei `dock`
--
ALTER TABLE `dock`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Diak_ID` (`Diak_ID`),
  ADD KEY `Dock_ID` (`Dock_ID`);

--
-- A tábla indexei `dokumentum`
--
ALTER TABLE `dokumentum`
  ADD PRIMARY KEY (`DocK_ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `alt_iskolak`
--
ALTER TABLE `alt_iskolak`
  MODIFY `Isk_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT a táblához `be_ki_iratkozas`
--
ALTER TABLE `be_ki_iratkozas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT a táblához `dokumentum`
--
ALTER TABLE `dokumentum`
  MODIFY `DocK_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `be_ki_iratkozas`
--
ALTER TABLE `be_ki_iratkozas`
  ADD CONSTRAINT `be_ki_iratkozas_ibfk_1` FOREIGN KEY (`Diak_ID`) REFERENCES `diak` (`Diak_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `be_ki_iratkozas_ibfk_2` FOREIGN KEY (`Isk_ID`) REFERENCES `alt_iskolak` (`Isk_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Megkötések a táblához `dock`
--
ALTER TABLE `dock`
  ADD CONSTRAINT `dock_ibfk_1` FOREIGN KEY (`Dock_ID`) REFERENCES `dokumentum` (`DocK_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `dock_ibfk_2` FOREIGN KEY (`Diak_ID`) REFERENCES `diak` (`Diak_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
