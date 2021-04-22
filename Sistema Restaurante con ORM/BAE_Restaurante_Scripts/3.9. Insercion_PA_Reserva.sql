USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Reserva_I]
		@pfecha = '15-05-2020',
		@phora_inicio = '09:30:00',
		@phora_fin = '15:50:00',
		@pid_cliente = 1

SELECT	'Return Value' = @return_value

GO


USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Reserva_I]
		@pfecha = '26-06-2020',
		@phora_inicio = '15:30:00',
		@phora_fin = '20:00:00',
		@pid_cliente = 2

SELECT	'Return Value' = @return_value

GO
