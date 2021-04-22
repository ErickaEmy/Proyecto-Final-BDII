-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
----------------------- CONTACTOS --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Contactos_I
	@pnombre varchar(100)  ,
	@ptipo_contacto varchar(50)  ,
	@pcelular varchar(15),
	@pemail text,
	@pfecha date  ,
	@pcomentario text
as
begin
	begin tran
		begin try
			insert into Contactos
			values(@pnombre,@ptipo_contacto,@pcelular,@pemail,@pfecha,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Contactos_U
	@id_contactos int,
	@pnombre varchar(100)  ,
	@ptipo_contacto varchar(50)  ,
	@pcelular varchar(15),
	@pemail text,
	@pfecha date  ,
	@pcomentario text
as
begin
	begin tran
		begin try
			update Contactos
				set
					nombre=@pnombre,
					tipo_contacto=@ptipo_contacto,
					celular=@pcelular,
					email=@pemail,
					fecha=@pfecha,
					comentario=@pcomentario

			Where id_contactos=@id_contactos
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Contactos_D
	@id_contactos int
as
begin
	begin tran
		begin try
			DELETE Contactos
			Where id_contactos=@id_contactos
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Contactos_S
as
begin
	select *from Contactos 
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Contactos_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select id_contactos,nombre,tipo_contacto,celular,email,fecha,comentario
	from Contactos
	where nombre like '%'+@pbusqueda+'%'
end
go


--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Contactos_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Contactos
				where nombre=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

