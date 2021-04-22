-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
------------------------ EMPRESA ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Empresa_I
	@pcaracteristica text,
	@pdescripcion text 
as
begin
	begin tran
		begin try
			insert into Empresa
			values(@pcaracteristica,@pdescripcion)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Empresa_U
	@id_empresa int,
	@pcaracteristica text,
	@pdescripcion text 
as
begin
	begin tran
		begin try
			update Empresa
				set
					caracteristica=@pcaracteristica,
					descripcion=@pdescripcion

			Where id_empresa=@id_empresa
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Empresa_D
	@pid_empresa int
as
begin
	begin tran
		begin try
			DELETE Empresa
			Where id_empresa=@pid_empresa
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Empresa_S
as
begin
	select *from Empresa
end
go
