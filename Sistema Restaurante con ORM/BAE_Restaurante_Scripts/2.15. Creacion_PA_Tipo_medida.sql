-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- TIPO_MEDIDA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Tipo_medida_I
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			insert into Tipo_medida
			values(@pnombre)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Tipo_medida_U
	@pid_tipo_medida int,
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			update Tipo_medida
				set
					nombre=@pnombre

			Where id_tipo_medida=@pid_tipo_medida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Tipo_medida_D
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			DELETE Tipo_medida
			Where id_tipo_medida=@pid_tipo_medida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Tipo_medida_S
as
begin
	select * from Tipo_medida
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Tipo_medida_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select id_tipo_medida,nombre
	from Tipo_medida
	where nombre like '%'+@pbusqueda+'%'
end
go

--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Tipo_medida_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Tipo_medida
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