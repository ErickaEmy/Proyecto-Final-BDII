USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Doc_venta_I]
		@ptipo_doc_venta = N'Boleta',
		@pnum_doc_venta = 1,
		@pventa_total = 250.00,
		@pfecha = '30-06-2020',
		@pcomentario = N'Ninguno',
		@pid_pedido = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Doc_venta_I]
		@ptipo_doc_venta = N'Boleta',
		@pnum_doc_venta = 2,
		@pventa_total = 126.00,
		@pfecha = '07-08-2020',
		@pcomentario = N'Ninguno',
		@pid_pedido = 2

SELECT	'Return Value' = @return_value

GO
