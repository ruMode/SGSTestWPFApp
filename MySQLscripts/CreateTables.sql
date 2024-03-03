CREATE TABLE `containers` (
   `id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `number` INT NULL,
  `type` VARCHAR(45) NULL,
  `length` INT NULL DEFAULT 0,
  `width` INT NULL DEFAULT 0,
  `height` INT NULL DEFAULT 0,
  `weight` INT NULL DEFAULT 0,
  `b_empty` BIT NULL DEFAULT 0,
 `receipt_date` DATETIME NULL;

CREATE TABLE `operations` (
  `id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `container_id` INT NOT NULL,
  `start_date` DATETIME NULL,
  `end_date` DATETIME NULL,
  `operation_type` VARCHAR(45) NULL,
  `operator_fullname` VARCHAR(128) NULL,
  `inspection_place` VARCHAR(128) NULL,
  CONSTRAINT `container_id`
    FOREIGN KEY (`container_id`)
    REFERENCES `containers` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
