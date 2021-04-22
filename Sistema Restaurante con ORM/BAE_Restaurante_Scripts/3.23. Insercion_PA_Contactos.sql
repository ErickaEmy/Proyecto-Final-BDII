USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Contactos_I]
		@pnombre = N'Juan Carlos Perez Casas',
		@ptipo_contacto = N'Proveedor',
		@pcelular = N'952415278',
		@pemail = N'josecarlos@gmail.com',
		@pfecha = '',
		@pcomentario = N'Ninguno'

SELECT	'Return Value' = @return_value

GO

USE [BAE_Restaurante]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[usp_Contactos_I]
		@pnombre = N'Diego Hernandez Mamani',
		@ptipo_contacto = N'Taxista',
		@pcelular = N'920145878',
		@pemail = N'diego@gmail.com',
		@pfecha = '',
		@pcomentario = N'Ninguno'

SELECT	'Return Value' = @return_value

GO

