-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- CONTROL ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Control_I
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pfalta bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			insert into Control
			values(@pfecha,@phora_inicio,@phora_fin,@pfalta,@pid_empleado)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Control_U
	@id_control int,
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pfalta bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Control
				set
					fecha= @pfecha,
					hora_inicio=@phora_inicio,
					hora_fin=@phora_fin,
					falta=@pfalta,
					id_empleado=@pid_empleado
			Where id_control=@id_control
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Control_D
	@id_control int
as
begin
	begin tran
		begin try
			DELETE Control 
			Where id_control=@id_control
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Control_S
as
begin
	select c.id_control,c.fecha,c.hora_inicio,c.hora_fin,c.falta,e.nombres,e.apellidos
	from Control as c
	inner join Empleado as e
	on e.id_empleado=c.id_empleado
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Control_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select c.id_control,c.fecha,c.hora_inicio,c.hora_fin,c.falta,e.nombres,e.apellidos
	from Control as c
	inner join Empleado as e
	on e.id_empleado=c.id_empleado
	where e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
go
