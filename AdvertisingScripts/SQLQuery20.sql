CREATE TABLE Category
(
 Id INT IDENTITY (1,1) PRIMARY KEY,
 ParrentCategoryId INT,
 Name VARCHAR(25),
 CategoryImage IMAGE,
 Active bit
)



 
 INSERT INTO Category (Name, ParrentCategoryId) VALUES ('Mobiteli', null)
  INSERT INTO Category (Name, ParrentCategoryId) VALUES ('Kuæe', 1)


 SELECT TOP 1000 * FROM category

 SELECT @@VERSION