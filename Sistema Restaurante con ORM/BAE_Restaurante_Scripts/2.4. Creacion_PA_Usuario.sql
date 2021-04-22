-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- USUARIO ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Usuario_I
	@pusuario varchar(50),
	@pcontrasena varchar(30),
	@prol varchar(30),
	@pestado bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			insert into Usuario
			values(@pusuario,@pcontrasena,@prol,@pestado,@pid_empleado)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Usuario_U
	@pid_usuario int,
	@pusuario varchar(50),
	@pcontrasena varchar(30),
	@prol varchar(30),
	@pestado bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Usuario
				set
					usuario=@pusuario,
					contrasena=@pcontrasena,
					rol=@prol,
					estado=@pestado,
					id_empleado=@pid_empleado
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Usuario_D
	@pid_usuario int
as
begin
	begin tran
		begin try
			DELETE Usuario 
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Usuario_S
as
begin
	select u.id_usuario,u.usuario,u.contrasena,u.rol,u.estado,e.nombres,e.apellidos
	from Usuario as u
	inner join Empleado as e
	on e.id_empleado=u.id_empleado
end
go


--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Usuario_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select u.id_usuario,u.usuario,u.contrasena,u.rol,u.estado,e.nombres,e.apellidos
	from Usuario as u
	inner join Empleado as e
	on e.id_empleado=u.id_empleado
	where u.usuario like '%'+@pbusqueda+'%'
	or e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
go


--Procedimiento almacenado de activar
CREATE PROCEDURE  usp_Usuario_Activar
	@pid_usuario int
as
begin
	begin tran
		begin try
			update Usuario
				set
					estado=1
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de desactivar
CREATE PROCEDURE usp_Usuario_Desactivar
	@pid_usuario int
as
begin
	begin tran
		begin try
			update Usuario 
				set
					estado=0
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Usuario_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select usuario from Usuario
				where usuario=LTRIM(rtrim(@pvalor)))
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
