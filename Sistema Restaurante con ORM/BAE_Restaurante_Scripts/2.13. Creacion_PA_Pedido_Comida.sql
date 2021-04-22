-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- PEDIDO_COMIDA ------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Pedido_Comida_I
	@pid_pedido INT,
	@pid_comida INT,
	@pcantidad int
as
begin
	begin tran
		begin try
			insert into Pedido_Comida
			values(@pid_pedido,@pid_comida,@pcantidad)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Pedido_Comida_D
	@pid_pedido INT,
	@pid_comida INT
as
begin
	begin tran
		begin try
			DELETE Pedido_Comida
			Where id_pedido=@pid_pedido
			and id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Pedido_Comida_S
as
begin
	select * from Pedido_Comida
end
go