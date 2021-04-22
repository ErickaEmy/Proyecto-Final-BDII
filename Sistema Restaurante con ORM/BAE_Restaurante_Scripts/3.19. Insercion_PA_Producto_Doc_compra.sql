USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Producto_Doc_compra_D]
		@pid_producto = 1,
		@pid_doc_compra = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Producto_Doc_compra_D]
		@pid_producto = 2,
		@pid_doc_compra = 1

SELECT	'Return Value' = @return_value

GO
