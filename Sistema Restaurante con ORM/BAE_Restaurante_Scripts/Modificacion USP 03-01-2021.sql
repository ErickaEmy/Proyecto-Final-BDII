--NUEVOS PROCEDIMIENTOS ALMACENADOS


USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_U]    Script Date: 03/01/2021 23:04:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
ALTER PROCEDURE [dbo].[usp_Doc_venta_U]
	@pid_doc_venta int,
	@ptipo_doc_venta varchar(20),
	@pnum_doc_venta int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text,
	@pid_pedido int
as
begin
	begin tran
		begin try
			update Doc_venta
				set
					tipo_doc_venta=@ptipo_doc_venta,
					num_doc_venta=@pnum_doc_venta,
					venta_total=@pventa_total,
					fecha=@pfecha,
					comentario=@pcomentario,
					id_pedido=@pid_pedido

			Where id_pedido=@pid_doc_venta
	commit
		end try
		begin catch
			rollback
		end catch
	end


-------------------