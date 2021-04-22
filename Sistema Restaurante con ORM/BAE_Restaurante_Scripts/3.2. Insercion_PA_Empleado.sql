USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Empleado_I]
		@pdni = N'73231433',
		@pnombres = N'Ericka',
		@papellidos = N'Martinez',
		@pfecha_nacimiento = '01-11-1978',
		@pdireccion = N'Av. Leguia 1032',
		@pcelular = N'952904011',
		@pemail = N'ericka@gmail.com',
		@pestado = 1,
		@pid_cargo = 2

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Empleado_I]
		@pdni = N'00478965',
		@pnombres = N'Miguel',
		@papellidos = N'Cardenas',
		@pfecha_nacimiento = '05-01-1985',
		@pdireccion = N'Psje Jose Gomez 112',
		@pcelular = N'952748596',
		@pemail = N'miguel123@gmail.com',
		@pestado = 1,
		@pid_cargo = 1

SELECT	'Return Value' = @return_value

GO
