-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- RESERVA_MESA -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Reserva_Mesa_I
	@pid_mesa INT,
	@pid_reserva INT
as
begin
	begin tran
		begin try
			insert into Reserva_Mesa
			values(@pid_mesa,@pid_reserva)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE  usp_Reserva_Mesa_S
as
begin
	select *from Reserva_Mesa
end
go

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Reserva_Mesa_D
	@pid_mesa INT,
	@pid_reserva INT
as
begin
	begin tran
		begin try
			DELETE Reserva_Mesa
			Where id_mesa=@pid_mesa
			and id_reserva=@pid_reserva
	commit
		end try
		begin catch
			rollback
		end catch
	end
go