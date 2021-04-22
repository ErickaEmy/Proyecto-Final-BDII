-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
-------------------------- CAJA ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Caja_I
	@pfecha date  ,
	@preserva numeric(10,2)  ,
	@pingreso numeric(10,2),
	@pegreso	numeric(10,2),
	@pcomentario text 
as
begin
	begin tran
		begin try
			insert into Caja
			values(@pfecha,@preserva,@pingreso,@pegreso,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Caja_U
	@pid_caja int,
	@pfecha date  ,
	@preserva numeric(10,2)  ,
	@pingreso numeric(10,2),
	@pegreso	numeric(10,2),
	@pcomentario text 
as
begin
	begin tran
		begin try
			update Caja
				set
					fecha=@pfecha,
					reserva=@preserva,
					ingreso=@pingreso,
					egreso=@pegreso,
					comentario=@pcomentario

			Where id_caja=@pid_caja
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Caja_D
	@pid_caja int
as
begin
	begin tran
		begin try
			DELETE Caja
			Where id_caja=@pid_caja
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Caja_S
as
begin
	select *from Caja
end
go


--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Caja_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select fecha from Caja
				where fecha=LTRIM(rtrim(@pvalor)))
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