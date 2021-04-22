USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Empresa_I]
		@pcaracteristica = N'Nombre',
		@pdescripcion = N'Restaurante Tacna'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Empresa_I]
		@pcaracteristica = N'RUC',
		@pdescripcion = N'14785236996'

SELECT	'Return Value' = @return_value

GO
