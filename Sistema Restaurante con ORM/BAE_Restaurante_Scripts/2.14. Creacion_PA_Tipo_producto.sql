-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
-------------------- TIPO_PRODUCTO -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Tipo_producto_I
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			insert into Tipo_producto
			values(@pnombre)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Tipo_producto_U
	@pid_tipo_producto int,
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			update Tipo_producto
				set
					nombre=@pnombre

			Where id_tipo_producto=@pid_tipo_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Tipo_producto_D
	@pid_tipo_producto int
as
begin
	begin tran
		begin try
			DELETE Tipo_producto
			Where id_tipo_producto=@pid_tipo_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Tipo_producto_S
as
begin
	select * from Tipo_producto
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Tipo_producto_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select id_tipo_producto,nombre
	from Tipo_producto
	where nombre like '%'+@pbusqueda+'%'
end
go

--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Tipo_producto_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Tipo_producto
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