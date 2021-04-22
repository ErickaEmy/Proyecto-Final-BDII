USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Control_I]
		@pfecha = '15-05-2020',
		@phora_inicio = '09:18:25',
		@phora_fin = '21:30',
		@pfalta = 0,
		@pid_empleado = 1

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Control_I]
		@pfecha = '11-06-2020',
		@phora_inicio = '10:00',
		@phora_fin = '15:00',
		@pfalta = 0,
		@pid_empleado = 2

SELECT	'Return Value' = @return_value

GO
