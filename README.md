# MindBox.CalcSquareLib

## 1) Библиотека на C#

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Дополнительные критерии:

 - Юнит тесты
 - Легкость добавления других фигур.
     Для добавления новой фигуры нужно: создать класс новой фигуры, реализовав интерфейс IShape (только метод подсчета площади).
 - Вычисление площади фигуры без знания типа фигуры в compile-time. Реализуется благодаря интерфейсу IShape.
 - Проверку на то, является ли треугольник прямоугольным. Реализуется вызовом соответствующего метода.


## 2) SQL

 В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
 Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```
CREATE TABLE Products (
	Id INT,
	Name NVARCHAR(255) NOT NULL,
	CONSTRAINT PK_Products_Id PRIMARY KEY (Id)
)

CREATE TABLE Categories (
	Id INT,
	Name NVARCHAR(255) NOT NULL,
	CONSTRAINT PK_Categories_Id PRIMARY KEY (Id)
)

CREATE TABLE Relations (
	Product_Id INT,	
	Category_Id INT,
	PRIMARY KEY(Product_Id, Category_Id),
	CONSTRAINT FK_Relations_Product_Id FOREIGN KEY (Product_Id) REFERENCES Products (Id),
	CONSTRAINT FK_Relations_Category_Id FOREIGN KEY (Category_Id) REFERENCES Categories (Id)
)

INSERT INTO Products(Id, Name) VALUES
(1, 'ASP.NET'),
(2, 'C#'),
(3, 'Java'),
(4, 'Spring'),
(5, 'JS'),
(6, 'House')

INSERT INTO Categories(Id, Name) VALUES
(1, 'Framework'),
(2, 'Language'),
(3, 'Backend'),
(4, 'Frontend')

INSERT INTO Relations(Product_Id, Category_Id) VALUES
(1, 1),
(1, 3),
(2, 2),
(2, 3),
(3, 2),
(3, 3),
(4, 1),
(4, 3),
(5, 2),
(5, 4)



SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN Relations ON Products.Id = Relations.Product_Id
LEFT JOIN Categories ON Categories.Id = Relations.Category_Id
ORDER BY Products.Name
```

### Результат
![изображение](https://github.com/user-attachments/assets/07c83ee7-7617-4375-8225-444a04d8b64e)
