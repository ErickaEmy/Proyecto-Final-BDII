USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Pedido_I]
		@pfecha = '30-06-2020',
		@ptipo_pedido = N'Mesa',
		@ptipo_pago = N'Efectivo',
		@pimagen_pago = 1,
		@pestado = N'A',
		@pcomentario = N'Su pedido fue aceptado correctamente.',
		@pid_empleado = 1,
		@pid_cliente = 1,
		@pid_mesa = 2,
		@direccion_envio = N'Av. Coronel Mendoza 1789'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Pedido_I]
		@pfecha = '05-07-2020',
		@ptipo_pedido = N'Delivery',
		@ptipo_pago = N'Transferencia',
		@pimagen_pago = 2,
		@pestado = N'A',
		@pcomentario = N'Su pedido fue aceptado correctamente.',
		@pid_empleado = 1,
		@pid_cliente = 3,
		@pid_mesa = 3,
		@direccion_envio = N'Av. Rosas 47'

SELECT	'Return Value' = @return_value

GO
