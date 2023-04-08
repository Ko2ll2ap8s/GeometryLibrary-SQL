SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategories ON Products.ProductId = ProductCategories.ProductId
LEFT JOIN Categories ON ProductCategories.CategoryId = Categories.CategoryId
ORDER BY Products.ProductName;

