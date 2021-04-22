USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Cliente_I]
		@pnum_documento = N'12457896',
		@ptipo_documento = N'DNI',
		@pnombres = N'Maria',
		@papellidos = N'Dominguez',
		@pdireccion = N'Av. Rosas 123',
		@pcelular = N'952638574'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Cliente_I]
		@pnum_documento = N'74125896',
		@ptipo_documento = N'DNI',
		@pnombres = N'Jose Carlos',
		@papellidos = N'Estela Zantalla',
		@pdireccion = N'Av. San Martin 96',
		@pcelular = N'952698574'

SELECT	'Return Value' = @return_value

GO


DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Cliente_I]
		@pnum_documento = N'73231465',
		@ptipo_documento = N'DNI',
		@pnombres = N'Jorge',
		@papellidos = N'Gutierrez Boca',
		@pdireccion = N'Av. Zela 123',
		@pcelular = N'920142536'

SELECT	'Return Value' = @return_value

GO


DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Cliente_I]
		@pnum_documento = N'73231411',
		@ptipo_documento = N'DNI',
		@pnombres = N'Bruno',
		@papellidos = N'Salas Garcia',
		@pdireccion = N'Av. Ola 123',
		@pcelular = N'952475820'

SELECT	'Return Value' = @return_value

GO