-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 28 DIC 2020

------------------------------------------------------------------
----------------------- DOC_VENTA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Doc_venta_I
	@ptipo_doc_venta varchar(20),
	@pnum_doc_venta int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text,
	@pid_pedido int
as
begin
	begin tran
		begin try
			insert into Doc_venta
			values(@ptipo_doc_venta,@pnum_doc_venta,@pventa_total,@pfecha,@pcomentario,@pid_pedido)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Doc_venta_U
	@pid_doc_venta int,
	@ptipo_doc_venta varchar(20),
	@pnum_doc_venta int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text,
	@pid_pedido int
as
begin
	begin tran
		begin try
			update Doc_venta
				set
					tipo_doc_venta=@ptipo_doc_venta,
					num_doc_venta=@pnum_doc_venta,
					venta_total=@pventa_total,
					fecha=@pfecha,
					comentario=@pcomentario,
					id_pedido=@pid_pedido

			Where id_doc_venta=@pid_doc_venta
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Doc_venta_D
	@pid_doc_venta int
as
begin
	begin tran
		begin try
			DELETE Doc_venta
			Where id_doc_venta=@pid_doc_venta
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Doc_venta_S
as
begin
	select dv.id_pedido,dv.tipo_doc_venta,dv.num_doc_venta,dv.venta_total,dv.fecha,dv.comentario,
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombres cliente',c.apellidos as 'Apellidos cliente'
	from Doc_venta as dv
	
	inner join Pedido as p
	on dv.id_pedido=p.id_pedido

	inner join Cliente as c
	on p.id_cliente=c.id_cliente
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Doc_venta_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select dv.id_pedido,dv.tipo_doc_venta,dv.num_doc_venta,dv.venta_total,dv.fecha,dv.comentario,
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombres cliente',c.apellidos as 'Apellidos cliente'
	from Doc_venta as dv
	
	inner join Pedido as p
	on dv.id_pedido=p.id_pedido

	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	where c.nombres like '%'+@pbusqueda+'%'
	or c.apellidos like '%'+@pbusqueda+'%'
end
go

--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Doc_venta_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select num_doc_venta from Doc_venta
				where num_doc_venta=LTRIM(rtrim(@pvalor)))
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

