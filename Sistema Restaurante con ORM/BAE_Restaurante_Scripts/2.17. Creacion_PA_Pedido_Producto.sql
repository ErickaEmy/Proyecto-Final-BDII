-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- PEDIDO_PRODUCTO ----------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Pedido_Producto_I
	@pid_pedido INT,
	@pid_producto INT,
	@pcantidad int
as
begin
	begin tran
		begin try
			insert into Pedido_Producto
			values(@pid_pedido,@pid_producto,@pcantidad)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Pedido_Producto_D
	@pid_pedido INT,
	@pid_producto INT
as
begin
	begin tran
		begin try
			DELETE Pedido_Producto
			Where id_pedido=@pid_pedido
			and id_producto=@pid_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Pedido_Producto_S
as
begin
	select * from Pedido_Producto
end
go