-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 08, 2022 at 11:07 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penilaian`
--

-- --------------------------------------------------------

--
-- Table structure for table `bhs_indonesia`
--

CREATE TABLE `bhs_indonesia` (
  `id` int(11) NOT NULL,
  `id_siswa` int(11) NOT NULL,
  `id_mapel` int(11) NOT NULL DEFAULT 1,
  `nilai_uh` int(11) DEFAULT 0,
  `nilai_tugas` int(11) DEFAULT 0,
  `nilai_uts` int(11) DEFAULT 0,
  `nilai_uas` int(11) DEFAULT 0,
  `rata_rata` varchar(5) DEFAULT '-',
  `predikat` char(5) DEFAULT '-'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bhs_indonesia`
--

INSERT INTO `bhs_indonesia` (`id`, `id_siswa`, `id_mapel`, `nilai_uh`, `nilai_tugas`, `nilai_uts`, `nilai_uas`, `rata_rata`, `predikat`) VALUES
(1, 1, 1, 78, 60, 65, 80, '72', 'C'),
(2, 2, 1, 90, 90, 90, 98, '92', 'A'),
(3, 3, 1, 90, 90, 90, 80, '87', 'B'),
(13, 4, 1, 0, 0, 0, 0, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `bhs_inggris`
--

CREATE TABLE `bhs_inggris` (
  `id` int(11) NOT NULL,
  `id_siswa` int(11) NOT NULL,
  `id_mapel` int(11) NOT NULL DEFAULT 3,
  `nilai_uh` int(11) DEFAULT 0,
  `nilai_tugas` int(11) DEFAULT 0,
  `nilai_uts` int(11) DEFAULT 0,
  `nilai_uas` int(11) DEFAULT 0,
  `rata_rata` varchar(5) DEFAULT '-',
  `predikat` char(5) DEFAULT '-'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bhs_inggris`
--

INSERT INTO `bhs_inggris` (`id`, `id_siswa`, `id_mapel`, `nilai_uh`, `nilai_tugas`, `nilai_uts`, `nilai_uas`, `rata_rata`, `predikat`) VALUES
(1, 1, 3, 0, 0, 0, 0, '-', '-'),
(2, 2, 3, 0, 0, 0, 0, '-', '-'),
(3, 3, 3, 0, 0, 0, 0, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `guru`
--

CREATE TABLE `guru` (
  `idguru` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(200) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `id_mapel` int(11) NOT NULL,
  `alamat` text NOT NULL,
  `walas` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `guru`
--

INSERT INTO `guru` (`idguru`, `username`, `password`, `nama`, `no_telp`, `id_mapel`, `alamat`, `walas`) VALUES
(1, 'guru', 'guru', 'Guru 1', '1023545667', 1, 'disini', '12 Ips'),
(2, 'guru2', 'guru2', 'Guru 2', '123659841', 2, 'disitu', '12 Ipa'),
(3, 'guru3', 'guru3', 'Guru 3', '45345345', 3, 'asdfasdg', '11 Ips'),
(4, 'guru4', 'guru4', 'Guru 4', '123654987', 4, 'disini', '11 Ipa');

-- --------------------------------------------------------

--
-- Table structure for table `ipa`
--

CREATE TABLE `ipa` (
  `id` int(11) NOT NULL,
  `id_siswa` int(11) NOT NULL,
  `id_mapel` int(11) NOT NULL DEFAULT 2,
  `nilai_uh` int(11) DEFAULT 0,
  `nilai_tugas` int(11) DEFAULT 0,
  `nilai_uts` int(11) DEFAULT 0,
  `nilai_uas` int(11) DEFAULT 0,
  `rata_rata` varchar(5) DEFAULT '-',
  `predikat` char(5) DEFAULT '-'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ipa`
--

INSERT INTO `ipa` (`id`, `id_siswa`, `id_mapel`, `nilai_uh`, `nilai_tugas`, `nilai_uts`, `nilai_uas`, `rata_rata`, `predikat`) VALUES
(1, 1, 2, 0, 0, 0, 0, '-', '-'),
(2, 2, 2, 0, 0, 0, 0, '-', '-'),
(3, 3, 2, 0, 0, 0, 0, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `mapel`
--

CREATE TABLE `mapel` (
  `id_mapel` int(11) NOT NULL,
  `id_guru` int(11) DEFAULT NULL,
  `mapel` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mapel`
--

INSERT INTO `mapel` (`id_mapel`, `id_guru`, `mapel`) VALUES
(1, 1, 'bhs_indonesia'),
(2, 2, 'ipa'),
(3, 3, 'bhs_inggris'),
(4, 4, 'matematika');

-- --------------------------------------------------------

--
-- Table structure for table `matematika`
--

CREATE TABLE `matematika` (
  `id` int(11) NOT NULL,
  `id_siswa` int(11) NOT NULL,
  `id_mapel` int(11) NOT NULL DEFAULT 4,
  `nilai_uh` int(11) DEFAULT 0,
  `nilai_tugas` int(11) DEFAULT 0,
  `nilai_uts` int(11) DEFAULT 0,
  `nilai_uas` int(11) DEFAULT 0,
  `rata_rata` varchar(5) DEFAULT '-',
  `predikat` char(5) DEFAULT '-'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `matematika`
--

INSERT INTO `matematika` (`id`, `id_siswa`, `id_mapel`, `nilai_uh`, `nilai_tugas`, `nilai_uts`, `nilai_uas`, `rata_rata`, `predikat`) VALUES
(1, 1, 4, 0, 0, 0, 0, '-', '-'),
(2, 2, 4, 0, 0, 0, 0, '-', '-'),
(3, 3, 4, 0, 0, 0, 0, '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `nilai`
--

CREATE TABLE `nilai` (
  `id_nilai` int(11) NOT NULL,
  `id_guru` int(11) DEFAULT 0,
  `id_siswa` int(11) NOT NULL,
  `tgl_input` varchar(15) NOT NULL,
  `matematika` float DEFAULT NULL,
  `bhs_indonesia` float DEFAULT NULL,
  `bhs_inggris` float DEFAULT NULL,
  `ipa` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nilai`
--

INSERT INTO `nilai` (`id_nilai`, `id_guru`, `id_siswa`, `tgl_input`, `matematika`, `bhs_indonesia`, `bhs_inggris`, `ipa`) VALUES
(1, 1, 1, '2022-02-25', 1, 1, 1, 1),
(2, 2, 2, '2022-02-25', 2, 2, 2, 2),
(3, 5, 3, '2022-02-28', 3, 3, 3, 3);

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `id_siswa` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `nis` bigint(20) NOT NULL,
  `kelas` varchar(10) NOT NULL,
  `alamat` text NOT NULL,
  `tgl_lahir` varchar(15) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `password` varchar(200) NOT NULL,
  `id_nilai` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`id_siswa`, `nama`, `nis`, `kelas`, `alamat`, `tgl_lahir`, `no_telp`, `password`, `id_nilai`) VALUES
(1, 'Fanthom', 12345, '12 Ips', 'di sekolah', '2008-02-14', '123456789', 'siswa', 1),
(2, 'ampas', 123456987, '11 Ips', 'disini', '2022-02-03', '236549870', 'ampas', 2),
(3, 'daffa', 123654987, '10 Ipa', 'disini', '2022-02-02', '03269811254', 'daffa', 3);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `level` enum('kepsek','wakepsek','admin','tata_usaha') NOT NULL,
  `alamat` text NOT NULL,
  `no_telp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id_user`, `username`, `password`, `nama`, `level`, `alamat`, `no_telp`) VALUES
(1, 'kepsek', 'kepsek', 'Kepala Sekolah', 'kepsek', 'di sekolah', '123457689'),
(2, 'wakepsek', 'wakepsek', 'Wakil kepala sekolah', 'wakepsek', 'disekolah juga', '7894562310'),
(3, 'tatausaha', 'tatausaha', 'Tata Usaha', 'tata_usaha', 'ruang administrasi', '1234567899874'),
(4, 'admin', 'admin', 'admin', 'admin', 'unknown', '123456789');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bhs_indonesia`
--
ALTER TABLE `bhs_indonesia`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bhs_inggris`
--
ALTER TABLE `bhs_inggris`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `guru`
--
ALTER TABLE `guru`
  ADD PRIMARY KEY (`idguru`);

--
-- Indexes for table `ipa`
--
ALTER TABLE `ipa`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mapel`
--
ALTER TABLE `mapel`
  ADD PRIMARY KEY (`id_mapel`),
  ADD KEY `mapel_ibfk_1` (`id_guru`);

--
-- Indexes for table `matematika`
--
ALTER TABLE `matematika`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `nilai`
--
ALTER TABLE `nilai`
  ADD PRIMARY KEY (`id_nilai`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`id_siswa`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bhs_indonesia`
--
ALTER TABLE `bhs_indonesia`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `bhs_inggris`
--
ALTER TABLE `bhs_inggris`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `ipa`
--
ALTER TABLE `ipa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `matematika`
--
ALTER TABLE `matematika`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `mapel`
--
ALTER TABLE `mapel`
  ADD CONSTRAINT `mapel_ibfk_1` FOREIGN KEY (`id_guru`) REFERENCES `guru` (`idguru`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
