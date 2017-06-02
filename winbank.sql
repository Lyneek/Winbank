-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Ven 02 Juin 2017 à 06:54
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `winbank`
--

-- --------------------------------------------------------

--
-- Structure de la table `t_client`
--

CREATE TABLE `t_client` (
  `CLI_Id` int(11) NOT NULL,
  `CLI_Nom` varchar(20) NOT NULL,
  `CLI_Prenom` varchar(20) NOT NULL,
  `CLI_Adresse` varchar(100) NOT NULL,
  `CLI_Cp` int(5) NOT NULL,
  `CLI_Ville` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Informations sur les clients';

--
-- Contenu de la table `t_client`
--

INSERT INTO `t_client` (`CLI_Id`, `CLI_Nom`, `CLI_Prenom`, `CLI_Adresse`, `CLI_Cp`, `CLI_Ville`) VALUES
(1, 'Dupont', 'Jean', '27 rue des oliviers', 97480, 'Saint Joseph'),
(2, 'Garnier', 'Valérie', '3 Avn Maréchal Jean', 47620, 'Lille'),
(3, 'Bourgin', 'Lucas', '22 rue des acassias', 12850, 'Marseille'),
(4, 'Pierre', 'Marc', '1 rue des arbousiers', 66450, 'Pollestres'),
(5, 'Villa', 'Silvie', '12 Avn des Cannes', 47620, 'Lille');

-- --------------------------------------------------------

--
-- Structure de la table `t_compte`
--

CREATE TABLE `t_compte` (
  `CPT_IdClientCompte` int(5) NOT NULL,
  `CPT_Numero` int(11) NOT NULL,
  `CPT_Solde` float NOT NULL,
  `CPT_TauxAgios` float DEFAULT NULL,
  `CPT_MontantDecouvert` int(11) DEFAULT NULL,
  `CPT_TauxInterets` float DEFAULT NULL,
  `CPT_MontantPlafond` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_compte`
--

INSERT INTO `t_compte` (`CPT_IdClientCompte`, `CPT_Numero`, `CPT_Solde`, `CPT_TauxAgios`, `CPT_MontantDecouvert`, `CPT_TauxInterets`, `CPT_MontantPlafond`) VALUES
(1, 5, 50.84, 3, 0, 1.7, 1000),
(4, 1, 2500.98, 1.2, 1000, 2.7, 5000),
(4, 2, 8000, 0, 0, 3, 25000),
(5, 1, 756, 1.2, 500, 2.5, 2500);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `t_client`
--
ALTER TABLE `t_client`
  ADD PRIMARY KEY (`CLI_Id`);

--
-- Index pour la table `t_compte`
--
ALTER TABLE `t_compte`
  ADD PRIMARY KEY (`CPT_IdClientCompte`,`CPT_Numero`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `t_client`
--
ALTER TABLE `t_client`
  MODIFY `CLI_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `t_compte`
--
ALTER TABLE `t_compte`
  ADD CONSTRAINT `IdClientCompte` FOREIGN KEY (`CPT_IdClientCompte`) REFERENCES `t_client` (`CLI_Id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
