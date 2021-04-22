USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Doc_compra_I]
		@ptipo_doc_compra = N'Boleta',
		@pnum_doc_compra = 1,
		@pventa_total = 312.90,
		@pfecha = '16-05-2020',
		@pcomentario = N'Compra mercado del dia'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Doc_compra_I]
		@ptipo_doc_compra = N'Boleta',
		@pnum_doc_compra = 2,
		@pventa_total = 250.30,
		@pfecha = '20-05-2020',
		@pcomentario = N'Compra mercado del dia'

SELECT	'Return Value' = @return_value

GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Doc_compra_I]
		@ptipo_doc_compra = N'Boleta',
		@pnum_doc_compra = 3,
		@pventa_total = 550,
		@pfecha = '21-05-2020',
		@pcomentario = N'Compra en Polvos Rosados C-98'

SELECT	'Return Value' = @return_value

GO