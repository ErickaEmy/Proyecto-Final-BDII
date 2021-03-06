USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_S_Buscar]    Script Date: 29/12/2020 18:31:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
ALTER PROCEDURE [dbo].[usp_Doc_compra_S_Buscar]
	@pbusqueda int
as
begin
	select *from Doc_compra
	where num_doc_compra=@pbusqueda
end



USE [BAE_Restaurante]
GO

/****** Object:  StoredProcedure [dbo].[usp_Caja_Verificar]    Script Date: 29/12/2020 18:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
ALTER PROCEDURE [dbo].[usp_Caja_Verificar]
	@pvalor date,
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


USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_S_Buscar]    Script Date: 29/12/2020 18:34:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
ALTER PROCEDURE [dbo].[usp_Doc_compra_S_Buscar]
	@pbusqueda int
as
begin
	select *from Doc_compra
	where num_doc_compra=@pbusqueda
end

USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_Verificar]    Script Date: 29/12/2020 18:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar
ALTER PROCEDURE [dbo].[usp_Doc_venta_Verificar]
	@pvalor int,
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select num_doc_venta from Doc_venta
				where num_doc_venta=LTRIM(rtrim(@pvalor)))
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


USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Verificar]    Script Date: 29/12/2020 18:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
ALTER PROCEDURE [dbo].[usp_Empleado_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select dni from Empleado
				where dni=LTRIM(rtrim(@pvalor)))
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

