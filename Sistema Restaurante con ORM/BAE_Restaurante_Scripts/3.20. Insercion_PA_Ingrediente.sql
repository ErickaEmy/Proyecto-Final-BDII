USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Ingrediente_I]
		@pnombre = N'Papa',
		@pprecio = 1.5,
		@pcantidad = 50,
		@pcomentario = N'Precio xKg',
		@pid_tipo_medida = 2

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Ingrediente_I]
		@pnombre = N'Cordero',
		@pprecio = 14.00,
		@pcantidad = 30,
		@pcomentario = N'Precio xKg',
		@pid_tipo_medida = 2

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Ingrediente_I]
		@pnombre = N'Aceite de oliva',
		@pprecio = 10.00,
		@pcantidad = 10,
		@pcomentario = N'Precio xlitro',
		@pid_tipo_medida = 3

SELECT	'Return Value' = @return_value

GO