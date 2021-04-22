-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 28 DIC 2020

------------------------------------------------------------------
----------------------- MESA -------------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Mesa_I
	@pcodigo varchar(50),
	@pestado bit,
	@pasientos int
as
begin
	begin tran
		begin try
			insert into Mesa
			values(@pcodigo,@pestado,@pasientos)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Mesa_U
	@pid_mesa int,
	@pcodigo varchar(50),
	@pestado bit,
	@pasientos int
as
begin
	begin tran
		begin try
			update Mesa
				set
					codigo=@pcodigo,
					estado=@pestado,
					asientos=@pasientos
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Mesa_D
	@pid_mesa int
as
begin
	begin tran
		begin try
			DELETE Mesa 
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Mesa_S
as
begin
	select * FROM Mesa
end
go


--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Mesa_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select id_mesa,codigo,estado,asientos
	from Mesa
	where codigo=@pbusqueda
end
go


--Procedimiento almacenado de activar
CREATE PROCEDURE  usp_Mesa_Activar
	@pid_mesa int
as
begin
	begin tran
		begin try
			update Mesa
				set
					estado=1
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de desactivar
CREATE PROCEDURE usp_Mesa_Desactivar
	@pid_mesa int
as
begin
	begin tran
		begin try
			update Mesa 
				set
					estado=0
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Mesa_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select codigo from Mesa
				where codigo=LTRIM(rtrim(@pvalor)))
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
