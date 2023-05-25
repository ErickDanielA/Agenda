-- MySqlBackup.NET 2.3.4
-- Dump Time: 2023-05-24 21:17:35
-- --------------------------------------
-- Server version 8.0.22 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of tbcontato
-- 

DROP TABLE IF EXISTS `tbcontato`;
CREATE TABLE IF NOT EXISTS `tbcontato` (
  `codcontato` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `telefone` char(14) DEFAULT NULL,
  `celular` char(15) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codcontato`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table tbcontato
-- 

/*!40000 ALTER TABLE `tbcontato` DISABLE KEYS */;
INSERT INTO `tbcontato`(`codcontato`,`nome`,`telefone`,`celular`,`email`) VALUES
(1,'Samara Pereira','(11) 5555-4444','(11) 97777-8888','samara.ferreira27@gmail.com'),
(2,'Samara Oliveira','(11) 5555-4444','(11) 97777-8888','samara.ferreira27@gmail.com'),
(3,'Erick','(11) 9454-5465','(11) 02222-2222','rijaslk@asfasdf');
/*!40000 ALTER TABLE `tbcontato` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-05-24 21:17:35
-- Total time: 0:0:0:0:914 (d:h:m:s:ms)
