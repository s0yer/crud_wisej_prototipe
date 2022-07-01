crud_wisej_prototipe






--------- Consultas DB:


SELECT * FROM mydb.lucknumber;
SELECT * FROM mydb.numeros;

ALTER TABLE `mydb`.`lucknumber` 
ADD COLUMN `datatempo` DATETIME NOT NULL AFTER `numero`;

ALTER TABLE `mydb`.`lucknumber` 
CHANGE COLUMN `datatempo` `datatempo` VARCHAR(45) NULL DEFAULT NULL ;

ALTER TABLE `mydb`.`lucknumber` 
DROP COLUMN `datatempo`;

-----
