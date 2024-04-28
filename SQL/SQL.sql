CREATE TABLE Products(
	id INT IDENTITY(1, 1) PRIMARY KEY,
  	name nvarchar(150)
)

CREATE TABLE Categories(
	id INT IDENTITY(1, 1) PRIMARY KEY,
  	name nvarchar(150)
)

CREATE TABLE Products_Categories(
	id INT IDENTITY(1, 1) PRIMARY KEY,
  	id_products INT,
  	id_categories INT,
  	FOREIGN KEY (id_products) REFERENCES Products(id),
  	FOREIGN KEY (id_categories) REFERENCES Categories(id)
)

INSERT INTO Categories (name) VALUES 
('Категория1'),
('Категория2'),
('Категория3'); 

INSERT INTO Products (name) VALUES 
('Продукт1'),
('Продукт2'),
('Продукт3');

INSERT INTO Products_Categories (id_products, id_categories) VALUES 
(1,1),
(1,2),
(2,3); 

SELECT Products.name as 'Имя продукта', COALESCE(Categories.name,'Нет категории') as 'Имя категории'
FROM Products
LEFT JOIN Products_Categories on Products.id=Products_Categories.id_products
LEFT JOIN Categories ON Categories.id=Products_Categories.id_categories