-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- TIPO_COMIDA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Tipo_comida_I
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			insert into Tipo_comida
			values(@pnombre)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Tipo_comida_U
	@pid_tipo_comida int,
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			update Tipo_comida
				set
					nombre=@pnombre

			Where id_tipo_comida=@pid_tipo_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Tipo_comida_D
	@pid_tipo_comida int
as
begin
	begin tran
		begin try
			DELETE Tipo_comida
			Where id_tipo_comida=@pid_tipo_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Tipo_comida_S
as
begin
	select * from Tipo_comida
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Tipo_comida_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select id_tipo_comida,nombre
	from Tipo_comida
	where nombre like '%'+@pbusqueda+'%'
end
go

--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Tipo_comida_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Tipo_comida
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