USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Tipo_producto_I]
		@pnombre = N'Gaseosas'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Tipo_producto_I]
		@pnombre = N'Cerveza'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Tipo_producto_I]
		@pnombre = N'Helado'

SELECT	'Return Value' = @return_value

GO
