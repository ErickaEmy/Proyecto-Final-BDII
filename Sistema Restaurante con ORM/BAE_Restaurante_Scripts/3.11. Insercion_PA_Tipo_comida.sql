USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Tipo_comida_I]
		@pnombre = N'Carnes'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Tipo_comida_I]
		@pnombre = N'Bebidas'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Tipo_comida_I]
		@pnombre = N'Postres'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Tipo_comida_I]
		@pnombre = N'Criollo'

SELECT	'Return Value' = @return_value

GO