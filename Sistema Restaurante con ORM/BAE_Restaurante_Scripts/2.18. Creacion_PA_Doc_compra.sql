-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
----------------------- DOC_COMPRA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Doc_compra_I
	@ptipo_doc_compra varchar(20),
	@pnum_doc_compra int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			insert into Doc_compra
			values(@ptipo_doc_compra,@pnum_doc_compra,@pventa_total,@pfecha,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Doc_compra_U
	@pid_doc_compra int,
	@ptipo_doc_compra varchar(20),
	@pnum_doc_compra int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			update Doc_compra
				set
					tipo_doc_compra=@ptipo_doc_compra,
					num_doc_compra=@pnum_doc_compra,
					venta_total=@pventa_total,
					fecha=@pfecha,
					comentario=@pcomentario

			Where id_doc_compra=@pid_doc_compra
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Doc_compra_D
	@pid_doc_compra int
as
begin
	begin tran
		begin try
			DELETE Doc_compra
			Where id_doc_compra=@pid_doc_compra
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Doc_compra_S
as
begin
	select *from Doc_compra
end
go

--Procedimiento almacenado de Buscar
CREATE PROCEDURE usp_Doc_compra_S_Buscar
	@pbusqueda varchar(150)
as
begin
	select *from Doc_compra
	where tipo_doc_compra=@pbusqueda
end
go

--Procedimiento almacenado de Verificar
CREATE PROCEDURE usp_Doc_compra_Verificar
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select num_doc_compra from Doc_compra
				where num_doc_compra=LTRIM(rtrim(@pvalor)))
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

