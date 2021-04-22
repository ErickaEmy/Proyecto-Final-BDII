-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
---------------------- INGREDIENTE -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Ingrediente_I
	@pnombre varchar(100),
	@pprecio numeric(10,3)  ,
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			insert into Ingrediente
			values(@pnombre,@pprecio,@pcantidad,@pcomentario,@pid_tipo_medida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Ingrediente_U
	@pid_ingrediente int,
	@pnombre varchar(100),
	@pprecio numeric(10,3)  ,
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			update Ingrediente
				set
					nombre=@pnombre,
					precio=@pprecio,
					cantidad=@pcantidad,
					comentario=@pcomentario,
					id_tipo_medida=@pid_tipo_medida

			Where id_ingrediente=@pid_ingrediente
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Ingrediente_D
	@pid_ingrediente int
as
begin
	begin tran
		begin try
			DELETE Ingrediente
			Where id_ingrediente=@pid_ingrediente
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Ingrediente_S
as
begin
	select i.nombre,i.precio,i.cantidad,tm.nombre,i.comentario
	from Ingrediente as i
	inner join Tipo_medida as tm
	on i.id_tipo_medida=tm.id_tipo_medida
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Ingrediente_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select i.nombre,i.precio,i.cantidad,tm.nombre,i.comentario
	from Ingrediente as i
	inner join Tipo_medida as tm
	on i.id_tipo_medida=tm.id_tipo_medida
	where i.nombre like '%'+@pbusqueda+'%'
end
go

--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Ingrediente_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Ingrediente
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
