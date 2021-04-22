USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Caja_I]
		@pfecha = '15-05-2020',
		@preserva = 1500,
		@pingreso = 2000,
		@pegreso = 500,
		@pcomentario = N'Ninguno'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Caja_I]
		@pfecha = '16-05-2020',
		@preserva = 1800,
		@pingreso = 1750,
		@pegreso = 630,
		@pcomentario = N'Ninguno'

SELECT	'Return Value' = @return_value

GO