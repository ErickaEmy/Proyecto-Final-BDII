-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
------------------------- CARGO-----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Cargo_I
	@pnombre varchar(45),
	@psueldo int
as
begin
	begin tran
		begin try
			insert into Cargo
			values(@pnombre,@psueldo)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Cargo_U
	@pidCargo int,
	@pnombre varchar(45),
	@psueldo int
as
begin
	begin tran
		begin try
			update Cargo 
				set
					nombre=@pnombre,
					sueldo=@psueldo
			Where id_cargo=@pidCargo
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Cargo_D
	@pidCargo int
as
begin
	begin tran
		begin try
			DELETE Cargo 
			Where id_cargo=@pidCargo
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Cargo_S
as
begin
	SELECT *FROM Cargo
end
go


--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Cargo_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select c.id_cargo,c.nombre,c.sueldo
	from Cargo as c
	where c.nombre like '%'+@pbusqueda+'%'
	or c.nombre=@pbusqueda
end
go

--Procedimiento almacenado de Verificar 
CREATE PROCEDURE usp_Cargo_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Cargo 
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

