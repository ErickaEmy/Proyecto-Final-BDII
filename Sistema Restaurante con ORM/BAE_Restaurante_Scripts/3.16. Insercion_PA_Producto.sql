USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Producto_I]
		@pnombre = N'Inca Kola',
		@pprecio = 8.50,
		@pcantidad = 4,
		@pfecha_vencimiento = '12-03-2022',
		@pnum_medida = 500,
		@pcomentario = N'Ninguno',
		@pid_tipo_producto = 1,
		@pid_tipo_medida = 4

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Producto_I]
		@pnombre = N'Coca Cola',
		@pprecio = 10.50,
		@pcantidad = 7,
		@pfecha_vencimiento = '20-11-2021',
		@pnum_medida = 3,
		@pcomentario = N'Ninguno',
		@pid_tipo_producto = 1,
		@pid_tipo_medida = 3

SELECT	'Return Value' = @return_value

GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Producto_I]
		@pnombre = N'Coca Cola',
		@pprecio = 4.00,
		@pcantidad = 7,
		@pfecha_vencimiento = '20-11-2021',
		@pnum_medida = 1,
		@pcomentario = N'Ninguno',
		@pid_tipo_producto = 1,
		@pid_tipo_medida = 3

SELECT	'Return Value' = @return_value

GO
