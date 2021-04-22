-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- CLIENTE ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Cliente_I
	@pnum_documento varchar(8),
	@ptipo_documento varchar(30),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pdireccion text,
	@pcelular varchar(15)
as
begin
	begin tran
		begin try
			insert into Cliente
			values(@pnum_documento,@ptipo_documento,@pnombres,@papellidos,@pdireccion,@pcelular)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Cliente_U
	@pid_cliente int,
	@pnum_documento varchar(8),
	@ptipo_documento varchar(30),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pdireccion text,
	@pcelular varchar(15)
as
begin
	begin tran
		begin try
			update Cliente
				set
					num_documento=@pnum_documento,
					tipo_documento=@ptipo_documento,
					nombres=@pnombres,
					apellidos=@papellidos,
					direccion=@pdireccion,
					celular=@pcelular
			Where id_cliente=@pid_cliente
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Cliente_D
	@pid_cliente int
as
begin
	begin tran
		begin try
			DELETE Cliente
			Where id_cliente=@pid_cliente
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Cliente_S
as
begin
	select * from Cliente
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Cliente_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select id_cliente,num_documento,tipo_documento,nombres,apellidos,direccion,celular
	from Cliente
	where nombres like '%'+@pbusqueda+'%'
	or apellidos like '%'+@pbusqueda+'%'
end
go

--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Cliente_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select num_documento from Cliente
				where num_documento=LTRIM(rtrim(@pvalor)))
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
