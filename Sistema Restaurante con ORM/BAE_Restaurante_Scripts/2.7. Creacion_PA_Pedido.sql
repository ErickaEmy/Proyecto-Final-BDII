-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- PEDIDO ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Pedido_I
	@pfecha date,
	@ptipo_pedido varchar(30),
	@ptipo_pago varchar(30),
	@pimagen_pago varbinary(max),
	@pestado varchar,
	@pcomentario text,
	@pid_empleado int,
	@pid_cliente int,
	@pid_mesa int,
	@direccion_envio text
as
begin
	begin tran
		begin try
			insert into Pedido
			values(@pfecha,@ptipo_pedido,@ptipo_pago,@pimagen_pago,@pestado,@pcomentario,
			@pid_empleado,@pid_cliente,@pid_mesa,@direccion_envio)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Pedido_U
	@pid_pedido int,
	@pfecha date,
	@ptipo_pedido varchar(30),
	@ptipo_pago varchar(30),
	@pimagen_pago varbinary(max),
	@pestado varchar,
	@pcomentario text,
	@pid_empleado int,
	@pid_cliente int,
	@pid_mesa int,
	@direccion_envio text
as
begin
	begin tran
		begin try
			update Pedido
				set
					fecha=@pfecha,
					tipo_pedido=@ptipo_pedido,
					tipo_pago=@ptipo_pago,
					imagen_pago=@pimagen_pago,
					estado=@pestado,
					comentario=@pcomentario,
					id_empleado=@pid_empleado,
					id_cliente=@pid_cliente,
					id_mesa=@pid_mesa,
					direccion_envio= @direccion_envio

			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
go



--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Pedido_D
	@pid_pedido int
as
begin
	begin tran
		begin try
			DELETE Pedido
			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Pedido_S
as
begin
	select p.id_pedido,p.fecha,p.tipo_pedido,p.tipo_pago,p.imagen_pago,p.estado,p.direccion_envio,p.comentario,
	e.nombres as 'Nombre Empleado',e.apellidos as 'Apellido Empleado',
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombre Cliente',c.apellidos as 'Apellido Cliente',
	m.codigo as 'Codigo mesa'

	from Pedido as p
	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	inner join Empleado as e
	on p.id_empleado=e.id_empleado

	inner join Mesa as m
	on p.id_mesa=m.id_mesa
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Pedido_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select p.id_pedido,p.fecha,p.tipo_pedido,p.tipo_pago,p.imagen_pago,p.estado,p.direccion_envio,p.comentario,
	e.nombres as 'Nombre Empleado',e.apellidos as 'Apellido Empleado',
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombre Cliente',c.apellidos as 'Apellido Cliente',
	m.codigo as 'Codigo mesa'

	from Pedido as p
	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	inner join Empleado as e
	on p.id_empleado=e.id_empleado

	inner join Mesa as m
	on p.id_mesa=m.id_mesa

	where e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
go


--Procedimiento almacenado de activar
CREATE PROCEDURE usp_Pedido_Activar
	@pid_pedido int
as
begin
	begin tran
		begin try
			update Pedido
				set
					estado=1
			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de desactivar
CREATE PROCEDURE usp_Pedido_Desactivar
	@pid_pedido int
as
begin
	begin tran
		begin try
			update Pedido 
				set
					estado=0
			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

