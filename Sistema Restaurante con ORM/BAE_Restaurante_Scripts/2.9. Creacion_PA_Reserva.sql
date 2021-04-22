-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
----------------------- RESERVA ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Reserva_I
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pid_cliente int
as
begin
	begin tran
		begin try
			insert into Reserva
			values(@pfecha,@phora_inicio,@phora_fin,@pid_cliente)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Reserva_U
	@pid_reserva int,
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pid_cliente int
as
begin
	begin tran
		begin try
			update Reserva
				set
					fecha=@pfecha,
					hora_inicio=@phora_inicio,
					hora_fin=@phora_fin,
					id_cliente=@pid_cliente

			Where id_reserva=@pid_reserva
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Reserva_D
	@pid_reserva int
as
begin
	begin tran
		begin try
			DELETE Reserva
			Where id_reserva=@pid_reserva
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Reserva_S
as
begin
	select r.id_reserva,r.fecha,r.hora_inicio,r.hora_fin,c.num_documento,c.nombres,c.apellidos
	from Reserva as r
	inner join Cliente as c
	on r.id_cliente=c.id_cliente
end
go


--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Reserva_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select r.id_reserva,r.fecha,r.hora_inicio,r.hora_fin,c.num_documento,c.nombres,c.apellidos
	from Reserva as r
	inner join Cliente as c
	on r.id_cliente=c.id_cliente
	where c.nombres like '%'+@pbusqueda+'%'
	or c.apellidos like '%'+@pbusqueda+'%'
end
go

