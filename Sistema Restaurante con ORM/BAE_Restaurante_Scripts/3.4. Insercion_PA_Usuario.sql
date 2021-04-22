USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Usuario_I]
		@pusuario = N'erickaMy',
		@pcontrasena = N'123456',
		@prol = N'Administrador',
		@pestado = 1,
		@pid_empleado = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Usuario_I]
		@pusuario = N'miguelCa',
		@pcontrasena = N'abcde',
		@prol = N'Cocina',
		@pestado = 1,
		@pid_empleado = 2

SELECT	'Return Value' = @return_value

GO
