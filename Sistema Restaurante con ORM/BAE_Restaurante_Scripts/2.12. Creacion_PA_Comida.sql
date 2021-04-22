-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
------------------------ COMIDA ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Comida_I
	@pnombre varchar(100),
	@pprecio numeric(10,3),
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_comida int
as
begin
	begin tran
		begin try
			insert into Comida
			values(@pnombre,@pprecio,@pcantidad,@pcomentario,@pid_tipo_comida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Comida_U
	@pid_comida INT,
	@pnombre varchar(100),
	@pprecio numeric(10,3),
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_comida int
as
begin
	begin tran
		begin try
			update Comida
				set
					nombre=@pnombre,
					precio=@pprecio,
					cantidad=@pcantidad,
					comentario=@pcomentario,
					id_tipo_comida=@pid_tipo_comida

			Where id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Comida_D
	@pid_comida int
as
begin
	begin tran
		begin try
			DELETE Comida
			Where id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Comida_S
as
begin
	select c.id_comida,c.nombre,c.precio,c.cantidad,c.comentario,tc.nombre
	from Comida as c
	inner join Tipo_comida as tc
	on c.id_tipo_comida=tc.id_tipo_comida
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Comida_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select c.id_comida,c.nombre,c.precio,c.cantidad,c.comentario,tc.nombre
	from Comida as c
	inner join Tipo_comida as tc
	on c.id_tipo_comida=tc.id_tipo_comida
	where c.nombre like '%'+@pbusqueda+'%'
end
go


--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Comida_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Comida
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

