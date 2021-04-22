USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Cargo_I]
		@pnombre = N'Jefe de cocina',
		@psueldo = 1300

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Cargo_I]
		@pnombre = N'Gerente',
		@psueldo = 2100

SELECT	'Return Value' = @return_value

GO
