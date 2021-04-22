USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Pedido_Producto_I]
		@pid_pedido = 1,
		@pid_producto = 3,
		@pcantidad = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Pedido_Producto_I]
		@pid_pedido = 2,
		@pid_producto = 1,
		@pcantidad = 3

SELECT	'Return Value' = @return_value

GO
