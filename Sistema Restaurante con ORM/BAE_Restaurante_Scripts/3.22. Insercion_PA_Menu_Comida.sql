USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Menu_Comida_I]
		@pid_menu = 1,
		@pid_comida = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Menu_Comida_I]
		@pid_menu = 1,
		@pid_comida = 2

SELECT	'Return Value' = @return_value

GO
