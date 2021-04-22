-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- PRODUCTO ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Producto_I
	@pnombre varchar(100),
	@pprecio numeric(10,3) ,
	@pcantidad int  ,
	@pfecha_vencimiento date  ,
	@pnum_medida numeric (10,3) ,
	@pcomentario text,
	@pid_tipo_producto int ,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			insert into Producto
			values(@pnombre,@pprecio,@pcantidad,@pfecha_vencimiento,@pnum_medida,@pcomentario,@pid_tipo_producto,@pid_tipo_medida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Producto_U
	@pid_producto int,
	@pnombre varchar(100),
	@pprecio numeric(10,3) ,
	@pcantidad int  ,
	@pfecha_vencimiento date  ,
	@pnum_medida numeric (10,3) ,
	@pcomentario text,
	@pid_tipo_producto int ,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			update Producto
				set
					nombre=@pnombre,
					precio=@pprecio,
					cantidad=@pcantidad,
					fecha_vencimiento=@pfecha_vencimiento,
					num_medida=@pnum_medida,
					comentario=@pcomentario,
					id_tipo_producto=@pid_tipo_producto,
					id_tipo_medida=@pid_tipo_medida

			Where id_producto=@pid_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
go



--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Producto_D
	@pid_producto int
as
begin
	begin tran
		begin try
			DELETE Producto
			Where id_producto=@pid_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Producto_S
as
begin
	select p.nombre,p.precio,p.cantidad,p.fecha_vencimiento,p.num_medida,tm.nombre,tp.nombre,p.comentario
	from Producto as p
	inner join Tipo_producto as tp
	on p.id_tipo_producto=tp.id_tipo_producto
	inner join Tipo_medida as tm
	on p.id_tipo_medida=tm.id_tipo_medida
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Producto_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select p.nombre,p.precio,p.cantidad,p.fecha_vencimiento,p.num_medida,tm.nombre,tp.nombre,p.comentario
	from Producto as p
	inner join Tipo_producto as tp
	on p.id_tipo_producto=tp.id_tipo_producto
	inner join Tipo_medida as tm
	on p.id_tipo_medida=tm.id_tipo_medida
	where p.nombre like '%'+@pbusqueda+'%'
end
go





