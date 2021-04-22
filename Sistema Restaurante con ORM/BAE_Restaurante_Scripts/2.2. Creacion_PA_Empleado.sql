-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- EMPLEADO ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Empleado_I
	@pdni varchar(8),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pfecha_nacimiento date,
	@pdireccion text,
	@pcelular varchar(15),
	@pemail text,
	@pestado bit,
    @pid_cargo int
as
begin
	begin tran
		begin try
			insert into Empleado
			values(@pdni,@pnombres,@papellidos,@pfecha_nacimiento,@pdireccion,@pcelular,@pemail,@pestado,@pid_cargo)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Empleado_U
	@pid_empleado int,
	@pdni varchar(8),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pfecha_nacimiento date,
	@pdireccion text,
	@pcelular varchar(15),
	@pemail text,
	@pestado bit,
    @pid_cargo int
as
begin
	begin tran
		begin try
			update Empleado
				set
					dni=@pdni,
					nombres=@pnombres,
					apellidos=@papellidos,
					fecha_nacimiento=@pfecha_nacimiento,
					direccion=@pdireccion,
					celular=@pcelular,
					email=@pemail,
					estado=@pestado,
					id_cargo=@pid_cargo
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Empleado_D
	@pid_empleado int
as
begin
	begin tran
		begin try
			DELETE Empleado
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Empleado_S
as
begin
	select e.id_empleado,e.dni,e.nombres,e.apellidos,e.fecha_nacimiento,e.direccion,e.celular,e.email,e.estado,c.nombre
	from Empleado as e
	inner join Cargo as c
	on e.id_cargo=c.id_cargo
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Empleado_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select e.id_empleado,e.dni,e.nombres,e.apellidos,e.fecha_nacimiento,e.direccion,e.celular,e.email,e.estado,c.nombre
	from Empleado as e
	inner join Cargo as c
	on e.id_cargo=c.id_cargo
	where e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
go


--Procedimiento almacenado de activar
CREATE PROCEDURE usp_Empleado_Activar
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Empleado
				set
					estado=1
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de desactivar
CREATE PROCEDURE usp_Empleado_Desactivar
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Empleado 
				set
					estado=0
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Empleado_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select dni from Empleado
				where dni=LTRIM(rtrim(@pvalor)))
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

