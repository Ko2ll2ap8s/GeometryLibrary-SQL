CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName NVARCHAR(50)
);

CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY,
    CategoryName NVARCHAR(50)
);

CREATE TABLE ProductCategories (
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

INSERT INTO Products (ProductId, ProductName)
VALUES (1, 'Product 1'), (2, 'Product 2'), (3, 'Product 3');

INSERT INTO Categories (CategoryId, CategoryName)
VALUES (1, 'Category 1'), (2, 'Category 2'), (3, 'Category 3');

INSERT INTO ProductCategories (ProductId, CategoryId)
VALUES (1, 1), (1, 2), (2, 1), (3, 3);
