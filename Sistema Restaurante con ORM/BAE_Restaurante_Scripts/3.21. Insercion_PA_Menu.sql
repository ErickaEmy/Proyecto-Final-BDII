USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Menu_I]
		@pfecha = '15-05-2020',
		@pcomentario = N'Ninguno'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Menu_I]
		@pfecha = '16-05-2020',
		@pcomentario = N'Ninguno'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Menu_I]
		@pfecha = '17-05-2020',
		@pcomentario = N'Ninguno'

SELECT	'Return Value' = @return_value

GO