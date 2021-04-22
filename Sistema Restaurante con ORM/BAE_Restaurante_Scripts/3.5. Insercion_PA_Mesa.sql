USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Mesa_I]
		@pcodigo = N'A',
		@pestado = 0,
		@pasientos = 4

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Mesa_I]
		@pcodigo = N'B',
		@pestado = 0,
		@pasientos = 2

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Mesa_I]
		@pcodigo = N'C',
		@pestado = 0,
		@pasientos = 4

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Mesa_I]
		@pcodigo = N'D',
		@pestado = 0,
		@pasientos = 3

SELECT	'Return Value' = @return_value

GO



USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Mesa_I]
		@pcodigo = N'E',
		@pestado = 0,
		@pasientos = 8

SELECT	'Return Value' = @return_value

GO



