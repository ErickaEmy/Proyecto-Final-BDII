-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
------------------- PRODUCTO_DOC_COMPRA --------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Producto_Doc_compra_I
	@pid_producto INT,
	@pid_doc_compra INT
as
begin
	begin tran
		begin try
			insert into Producto_Doc_compra
			values(@pid_producto,@pid_doc_compra)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE  usp_Producto_Doc_compra_S
as
begin
	select *from Producto_Doc_compra
end
go

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Producto_Doc_compra_D
	@pid_producto INT,
	@pid_doc_compra INT
as
begin
	begin tran
		begin try
			DELETE Producto_Doc_compra
			Where id_producto=@pid_producto
			and id_doc_compra=@pid_doc_compra
	commit
		end try
		begin catch
			rollback
		end catch
	end
go