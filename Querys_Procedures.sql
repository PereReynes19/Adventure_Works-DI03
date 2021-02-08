-- Pere Reynés Procedures --

CREATE PROCEDURE sp_getProductModel
@ID int
AS
BEGIN
	SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice FROM Production.ProductModel 
	JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID 
	JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID 
	JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
	WHERE Product.ProductModelID = @ID
	ORDER BY Product.ListPrice;
END
GO
-------------------
CREATE PROCEDURE sp_getProductModel_ID
AS
BEGIN
	SELECT DISTINCT ProductModel.ProductModelID
	FROM Production.ProductModel
	WHERE ProductModel.ProductModelID IS NOT NULL
	ORDER BY ProductModelID
END
GO
-----------------------------
CREATE PROCEDURE sp_getProductModel_Size
@ID int
AS
BEGIN
	SELECT Production.Product.ProductID , Product.Size
	FROM Production.Product
	WHERE Product.ProductModelID = @ID AND Product.ProductModelID IS NOT NULL
	ORDER BY Product.Size
END
GO