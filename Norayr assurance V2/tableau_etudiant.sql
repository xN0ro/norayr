-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 22 avr. 2021 à 03:01
-- Version du serveur :  10.4.18-MariaDB
-- Version de PHP : 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `etudiant`
--

-- --------------------------------------------------------

--
-- Structure de la table `tableau_etudiant`
--

CREATE TABLE `tableau_etudiant` (
  `id` int(11) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Cours` varchar(50) NOT NULL,
  `Notes` varchar(50) NOT NULL,
  `Cree` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `tableau_etudiant`
--

INSERT INTO `tableau_etudiant` (`id`, `Prenom`, `Nom`, `Cours`, `Notes`, `Cree`) VALUES
(4, 'dffdg', 'dfg', 'fdg', 'df', '2021-04-22 00:03:23'),
(6, 'sdjds', 'asdasd', 'sdds', 'sdsdd', '2021-04-22 00:49:11'),
(7, 'skjasd', 'asdasd', 'asasd', 'asdasd', '2021-04-22 00:50:31');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `tableau_etudiant`
--
ALTER TABLE `tableau_etudiant`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `tableau_etudiant`
--
ALTER TABLE `tableau_etudiant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
