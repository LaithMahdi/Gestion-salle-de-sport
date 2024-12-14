-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : sam. 14 déc. 2024 à 16:41
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projet_gym`
--

-- --------------------------------------------------------

--
-- Structure de la table `coach`
--

CREATE TABLE `coach` (
  `CIN` int(8) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `email` varchar(60) NOT NULL,
  `phone` int(8) NOT NULL,
  `specialty` enum('Personal Training','Strength and Conditioning','Rehabilitation','Yoga and Flexibility Training','CrossFit and Functional Training','Group Fitness Instruction','Bodybuilding and Physique Training') DEFAULT NULL,
  `availability` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `coach`
--

INSERT INTO `coach` (`CIN`, `first_name`, `last_name`, `email`, `phone`, `specialty`, `availability`) VALUES
(9253602, 'Ben romdhane', 'Houssen', 'houusem@gmail.com', 99999999, 'CrossFit and Functional Training', 0),
(19999255, 'Ben azouz', 'Ofla', 'olfa@gmail.com', 55555555, 'Yoga and Flexibility Training', 1),
(63253662, 'Chatti', 'Ayoub', 'ayoub@gmail.com', 96253014, 'Group Fitness Instruction', 1);

-- --------------------------------------------------------

--
-- Structure de la table `course`
--

CREATE TABLE `course` (
  `id` int(11) NOT NULL,
  `name` varchar(40) NOT NULL,
  `description` text NOT NULL,
  `duration` int(11) NOT NULL DEFAULT 60,
  `created_at` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `course`
--

INSERT INTO `course` (`id`, `name`, `description`, `duration`, `created_at`) VALUES
(1, 'Cardio Blast', 'High-intensity cardio workout to burn calories.', 45, '2024-12-13'),
(2, 'Yoga Flow', 'Relaxing yoga session to improve flexibility.', 60, '2024-12-13'),
(3, 'Strength Training', 'Focused weightlifting to build muscle strength.', 50, '2024-12-13'),
(4, 'Zumba Dance', 'Fun dance-based workout to stay active.', 40, '2024-12-13'),
(5, 'Pilates Core', 'Strengthen core muscles with Pilates exercises.', 55, '2024-12-13'),
(6, 'HIIT Challenge', 'Short bursts of high-intensity interval training.', 30, '2024-12-13'),
(7, 'Spin Class', 'Energetic indoor cycling session.', 45, '2024-12-13'),
(8, 'Body Sculpt', 'Full-body toning exercises using weights.', 40, '2024-12-13');

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` text DEFAULT NULL,
  `deliveryDate` date DEFAULT NULL,
  `status` enum('Non Disponible','En Entretien','Disponible') DEFAULT 'Disponible',
  `category` enum('Équipements de musculation','Cardio-training','Équipements pour les cours collectifs','Équipements de fitness et d''entraînement') DEFAULT NULL,
  `emplacement` enum('Salle de musculation','Salle de cardio-training','Salle de cours collectifs','Salle de sports de combat ou arts martiaux','Salle de sport fonctionnel') DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `equipement`
--

INSERT INTO `equipement` (`id`, `name`, `description`, `deliveryDate`, `status`, `category`, `emplacement`) VALUES
(1, 'Treadmill Pro', 'High-quality treadmill for cardio workouts.', '2024-01-15', 'Disponible', 'Cardio-training', 'Salle de cardio-training'),
(2, 'Dumbbell Set', 'Adjustable dumbbell set for weight training.', '2024-12-10', 'Disponible', 'Équipements de musculation', 'Salle de musculation'),
(3, 'Yoga Mats', 'Comfortable mats for group yoga sessions.', '2024-03-05', 'Non Disponible', 'Équipements pour les cours collectifs', 'Salle de cours collectifs'),
(4, 'Punching Bag', 'Heavy bag for combat sports training.', '2024-02-18', 'En Entretien', 'Équipements de fitness et d\'entraînement', 'Salle de sports de combat ou arts martiaux'),
(5, 'Elliptical Trainer', 'Versatile machine for full-body cardio workouts.', '2024-11-20', 'Disponible', 'Cardio-training', 'Salle de cardio-training'),
(6, 'Kettlebell Set', 'Set of kettlebells for functional fitness training.', '2024-10-25', 'Non Disponible', 'Équipements de fitness et d\'entraînement', 'Salle de sport fonctionnel'),
(7, 'Rowing Machine', 'High-performance rowing machine for cardio.', '2024-12-01', 'En Entretien', 'Cardio-training', 'Salle de cardio-training');

-- --------------------------------------------------------

--
-- Structure de la table `membre`
--

CREATE TABLE `membre` (
  `id` int(11) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `gender` enum('Male','Female') NOT NULL,
  `date_birth` date NOT NULL,
  `phone` int(8) NOT NULL,
  `email` varchar(50) NOT NULL,
  `join_date` date NOT NULL,
  `membership_time` enum('1 Month','3 Month','6 Month','1 Year') DEFAULT '1 Month',
  `price` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `membre`
--

INSERT INTO `membre` (`id`, `full_name`, `gender`, `date_birth`, `phone`, `email`, `join_date`, `membership_time`, `price`) VALUES
(1, 'Laith Mahdi', 'Male', '2001-01-30', 53843799, 'mahdi@gmail.com', '2024-12-13', '1 Year', 360),
(2, 'Dalel loussaief', 'Female', '2002-01-01', 53843799, 'dalel@gmail.com', '2024-11-13', '6 Month', 180),
(3, 'Hamza Mani', 'Male', '2001-07-12', 99999999, 'hamza@gmail.com', '2024-12-13', '3 Month', 90),
(4, 'Ghaith Slama', 'Male', '2002-03-08', 52520001, 'ghaith@gmail.com', '2024-12-06', '3 Month', 90),
(5, 'Hajer Ghird', 'Female', '2002-08-23', 21580369, 'hajer@gmail.com', '2024-12-13', '1 Month', 30);

-- --------------------------------------------------------

--
-- Structure de la table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `category` enum('Fitness Equipment','Free Weights','Yoga & Pilates','Cardio Accessories','Sportswear & Apparel','Nutrition & Supplements') NOT NULL DEFAULT 'Nutrition & Supplements',
  `price` decimal(20,0) NOT NULL,
  `quantity` int(8) NOT NULL DEFAULT 1,
  `promotion` tinyint(1) NOT NULL DEFAULT 0,
  `created_at` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `product`
--

INSERT INTO `product` (`id`, `name`, `category`, `price`, `quantity`, `promotion`, `created_at`) VALUES
(1, 'Adjustable Dumbbells', 'Free Weights', 120, 14, 1, '2024-12-13'),
(2, 'Resistance Bands Set', 'Fitness Equipment', 25, 50, 1, '2024-12-13'),
(3, 'Yoga Mat Pro', 'Yoga & Pilates', 35, 20, 0, '2024-12-13'),
(4, 'Treadmill Lubricant Kit', 'Cardio Accessories', 18, 20, 0, '2024-12-13'),
(5, 'Men\'s Running T-Shirt', 'Sportswear & Apparel', 28, 95, 0, '2024-12-13'),
(6, 'Protein Powder (1kg)', 'Nutrition & Supplements', 45, 58, 1, '2024-12-13'),
(7, 'Kettlebell (16kg)', 'Free Weights', 70, 10, 0, '2024-12-13'),
(8, 'Foam Roller', 'Fitness Equipment', 20, 25, 0, '2024-12-13'),
(9, 'Pre-Workout Drink', 'Nutrition & Supplements', 30, 50, 1, '2024-12-13');

-- --------------------------------------------------------

--
-- Structure de la table `sales`
--

CREATE TABLE `sales` (
  `id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `total_price` decimal(11,0) NOT NULL,
  `sale_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `sales`
--

INSERT INTO `sales` (`id`, `customer_id`, `product_id`, `quantity`, `total_price`, `sale_date`) VALUES
(1, 1, 6, 2, 90, '2024-12-13 20:30:28'),
(2, 2, 1, 1, 120, '2024-12-13 20:31:27'),
(3, 3, 5, 5, 140, '2024-12-13 20:33:37');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `email` varchar(45) NOT NULL,
  `name` varchar(25) DEFAULT NULL,
  `password` varchar(30) NOT NULL,
  `role` enum('COACH','ADMIN','USER','') NOT NULL DEFAULT 'USER',
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `email`, `name`, `password`, `role`, `created_at`) VALUES
(1, 'laith@gmail.com', 'laith', '12345678', 'ADMIN', '2024-12-03 22:45:55');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `coach`
--
ALTER TABLE `coach`
  ADD PRIMARY KEY (`CIN`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Index pour la table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `membre`
--
ALTER TABLE `membre`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sales_product_id` (`product_id`),
  ADD KEY `sales_customer_id` (`customer_id`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `course`
--
ALTER TABLE `course`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `equipement`
--
ALTER TABLE `equipement`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `membre`
--
ALTER TABLE `membre`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `sales`
--
ALTER TABLE `sales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `sales_customer_id` FOREIGN KEY (`customer_id`) REFERENCES `membre` (`id`),
  ADD CONSTRAINT `sales_product_id` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
