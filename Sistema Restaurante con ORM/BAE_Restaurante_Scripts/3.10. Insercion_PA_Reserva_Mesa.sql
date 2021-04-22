USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Reserva_Mesa_I]
		@pid_mesa = 3,
		@pid_reserva = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Reserva_Mesa_I]
		@pid_mesa = 1,
		@pid_reserva = 2

SELECT	'Return Value' = @return_value

GO
