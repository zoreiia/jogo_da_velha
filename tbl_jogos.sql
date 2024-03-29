-- MySQL Script generated by MySQL Workbench
-- Wed Mar  6 16:44:30 2024
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema rankjogos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema rankjogos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `rankjogos` DEFAULT CHARACTER SET utf8 ;
USE `rankjogos` ;

-- -----------------------------------------------------
-- Table `rankjogos`.`tbl_ranks`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rankjogos`.`tbl_ranks` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nick` VARCHAR(45) NULL,
  `pontuacao` VARCHAR(45) NULL,
  `data_recorde` VARCHAR(45) NULL,
  `jogo` VARCHAR(45) NULL,
  `senha` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
