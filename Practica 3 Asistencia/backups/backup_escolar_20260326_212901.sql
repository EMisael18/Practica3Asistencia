-- MySQL dump 10.13  Distrib 8.0.45, for Linux (x86_64)
--
-- Host: localhost    Database: escolar
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Alumnos`
--

DROP TABLE IF EXISTS `Alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Alumnos` (
  `IdAlumnos` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `ApellidoPat` varchar(45) DEFAULT NULL,
  `ApellidoMat` varchar(45) DEFAULT NULL,
  `NumeroControl` int DEFAULT NULL,
  `Semestre` int DEFAULT NULL,
  `Carrera` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IdAlumnos`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Alumnos`
--

LOCK TABLES `Alumnos` WRITE;
/*!40000 ALTER TABLE `Alumnos` DISABLE KEYS */;
/*!40000 ALTER TABLE `Alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Materias`
--

DROP TABLE IF EXISTS `Materias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Materias` (
  `idMaterias` int NOT NULL AUTO_INCREMENT,
  `Materias` varchar(45) DEFAULT NULL,
  `Creditos` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMaterias`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Materias`
--

LOCK TABLES `Materias` WRITE;
/*!40000 ALTER TABLE `Materias` DISABLE KEYS */;
/*!40000 ALTER TABLE `Materias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Profesores`
--

DROP TABLE IF EXISTS `Profesores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Profesores` (
  `IdProfesores` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `ApellidoPat` varchar(45) DEFAULT NULL,
  `ApellidoMat` varchar(45) DEFAULT NULL,
  `Area` varchar(45) DEFAULT NULL,
  `NoMaterias` int DEFAULT NULL,
  PRIMARY KEY (`IdProfesores`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Profesores`
--

LOCK TABLES `Profesores` WRITE;
/*!40000 ALTER TABLE `Profesores` DISABLE KEYS */;
INSERT INTO `Profesores` VALUES (1,'Misael','mont','e','mate',4),(2,'gabriel','dead','dsd','fisica',4);
/*!40000 ALTER TABLE `Profesores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asistencia` (
  `id` int NOT NULL AUTO_INCREMENT,
  `num_control` varchar(10) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `asistio` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `asistencia_ibfk_1` (`num_control`),
  CONSTRAINT `asistencia_ibfk_1` FOREIGN KEY (`num_control`) REFERENCES `estudiantes` (`num_control`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=116 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
INSERT INTO `asistencia` VALUES (3,'24130858','2026-03-15',1),(4,'24130858','2026-03-14',1),(5,'24130858','2026-03-25',1),(7,'24130678','2026-03-26',1),(8,'24130811','2026-03-26',1),(9,'24130805','2026-03-26',1),(10,'24130834','2026-03-26',1),(11,'24130824','2026-03-26',1),(12,'24130887','2026-03-26',1),(13,'24130860','2026-03-26',1),(14,'24130843','2026-03-26',1),(15,'24130866','2026-03-26',1),(16,'24130801','2026-03-26',1),(17,'24130833','2026-03-26',1),(18,'24130813','2026-03-26',1),(19,'24130831','2026-03-26',1),(20,'24130845','2026-03-26',1),(21,'24130868','2026-03-26',1),(22,'24130899','2026-03-26',1),(23,'24130734','2026-03-26',1),(24,'24130837','2026-03-26',1),(25,'24130823','2026-03-26',1),(26,'24130850','2026-03-26',1),(27,'24130851','2026-03-26',1),(28,'24130815','2026-03-26',1),(29,'24130867','2026-03-26',1),(30,'24130877','2026-03-26',1),(31,'24130890','2026-03-26',1),(32,'24180873','2026-03-26',1),(33,'24130734','2026-03-27',1),(34,'24130678','2026-03-27',1),(35,'24130805','2026-03-27',1),(36,'24130857','2026-03-27',1),(37,'24130811','2026-03-27',1),(38,'24130823','2026-03-27',1),(39,'24130833','2026-03-27',1),(40,'24130834','2026-03-27',1),(41,'24130850','2026-03-27',1),(42,'24130851','2026-03-27',1),(43,'24130815','2026-03-27',1),(44,'24130858','2026-03-27',1),(45,'24130877','2026-03-27',1),(46,'24130890','2026-03-27',1),(47,'24130867','2026-03-27',1),(48,'24130887','2026-03-27',1),(49,'24130813','2026-03-27',1),(50,'24130812','2026-03-27',1),(51,'24130831','2026-03-27',1),(52,'24130845','2026-03-27',1),(53,'24130860','2026-03-27',1),(54,'24130843','2026-03-27',1),(55,'24130868','2026-03-27',1),(56,'24130899','2026-03-27',1),(57,'24180873','2026-03-27',1),(58,'24130805','2026-03-28',1),(59,'24130811','2026-03-28',1),(60,'24130834','2026-03-28',1),(61,'24130858','2026-03-28',1),(62,'24130824','2026-03-28',1),(63,'24130887','2026-03-28',1),(64,'24130860','2026-03-28',1),(65,'24130843','2026-03-28',1),(66,'24130857','2026-03-28',1),(67,'24130801','2026-03-28',1),(68,'24130813','2026-03-28',1),(73,'24130899','2026-03-28',1),(74,'24130845','2026-03-28',1),(75,'24130837','2026-03-28',1),(76,'24130823','2026-03-28',1),(77,'24130734','2026-03-28',1),(78,'24130867','2026-03-28',1),(79,'24130877','2026-03-28',1),(80,'24130890','2026-03-28',1),(81,'24180873','2026-03-28',1),(82,'24130678','2026-03-29',1),(83,'24130805','2026-03-29',1),(84,'24130834','2026-03-29',1),(85,'24130858','2026-03-29',1),(86,'24130824','2026-03-29',1),(87,'24130866','2026-03-29',1),(88,'24130843','2026-03-29',1),(89,'24130857','2026-03-29',1),(90,'24130801','2026-03-29',1),(91,'24130833','2026-03-29',1),(92,'24130812','2026-03-29',1),(93,'24130899','2026-03-29',1),(94,'24130868','2026-03-29',1),(95,'24130845','2026-03-29',1),(96,'24130734','2026-03-29',1),(97,'24130823','2026-03-29',1),(98,'24130837','2026-03-29',0),(99,'24130850','2026-03-29',1),(100,'24130851','2026-03-29',1),(101,'24130815','2026-03-29',1),(102,'24130867','2026-03-29',1),(103,'24180873','2026-03-29',1),(104,'24130858','2026-03-26',0),(105,'24130805','2026-03-08',0),(106,'24130811','2026-03-08',0),(107,'24130834','2026-03-08',0),(108,'24130858','2026-03-08',0),(109,'24130824','2026-03-08',0),(110,'24130887','2026-03-08',0),(111,'24130860','2026-03-08',0),(112,'24130843','2026-03-08',0),(113,'24130866','2026-03-08',0),(114,'24130812','2026-03-26',0),(115,'24130857','2026-03-26',0);
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudiantes`
--

DROP TABLE IF EXISTS `estudiantes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estudiantes` (
  `num_control` varchar(10) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `ap_paterno` varchar(50) DEFAULT NULL,
  `ap_materno` varchar(50) DEFAULT NULL,
  `grupo` char(1) DEFAULT NULL,
  PRIMARY KEY (`num_control`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudiantes`
--

LOCK TABLES `estudiantes` WRITE;
/*!40000 ALTER TABLE `estudiantes` DISABLE KEYS */;
INSERT INTO `estudiantes` VALUES ('24130678','Manuel Alejandro','Echeverria','Hernandez','B'),('24130734','Erick Ulises','Serrano','Dominguez','C'),('24130801','Carla','Dominguez','Macias','B'),('24130805','Paula Maria','Espinoza','Hernandez','A'),('24130811','miri','Cepeda','Ruiz','A'),('24130812','Luisa','Espinoza','Hernandez','B'),('24130813','Marcela','Fernandez','Torres','B'),('24130815','Angel David','Palacios','Angel','C'),('24130823','Julio','Dominguez','nuñez','C'),('24130824','Antonio','Vaca','Del Toro','A'),('24130831','Diego Eduardo','Martinez','Medrano','B'),('24130833','Eduardo','Corchado','Palacios','B'),('24130834','Daniel','Montoya','Garcia','A'),('24130835','Fernando','Garza','Rodriguez','A'),('24130837','Jaquelin','Martinez','Soto','C'),('24130843','Brahiam','Gutierrez','Espinoza','A'),('24130845','David Andres','peralta','de la cruz','B'),('24130850','Daniel Julio','Rodriguez','Garcia','C'),('24130851','Eduardo','Montes','Torres','C'),('24130857','Luis Antonio','Garcia','Corchado','B'),('24130858','Eduardo Misael','Montoya','De La Cruz','A'),('24130860','Angel Giovani','Vargas','Perez','A'),('24130866','Manuel','Fernandez','ochoa','A'),('24130867','Federico','Montoya','Parra','C'),('24130868','Luis','Gutierrez','Garcia','B'),('24130877','Ramon','jimenez','Parra','C'),('24130887','Fernando','Perez','Fernandez','A'),('24130890','Diana Andrea','Garcia','fernandez','C'),('24130899','Daniel Abisai','Peralta','Luevanos','B'),('24180873','Sofia','fernandez','garcia','C');
/*!40000 ALTER TABLE `estudiantes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-27  3:29:03
