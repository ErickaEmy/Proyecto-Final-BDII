USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Comida_I]
		@pnombre = N'Parrillada de cordero',
		@pprecio = 35.00,
		@pcantidad = 0,
		@pcomentario = N'Ninguno',
		@pid_tipo_comida = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Comida_I]
		@pnombre = N'Parrillada de pollo',
		@pprecio = 30.00,
		@pcantidad = 0,
		@pcomentario = N'Ninguno',
		@pid_tipo_comida = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Comida_I]
		@pnombre = N'Limonada frozen',
		@pprecio = 12.00,
		@pcantidad = 0,
		@pcomentario = N'Ninguno',
		@pid_tipo_comida = 2

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Comida_I]
		@pnombre = N'Ensalada de frutas',
		@pprecio = 8.00,
		@pcantidad = 0,
		@pcomentario = N'Ninguno',
		@pid_tipo_comida = 3

SELECT	'Return Value' = @return_value

GO