-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
-------------------------- MENU ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Menu_I
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			insert into Menu
			values(@pfecha,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE usp_Menu_U
	@pid_menu int,
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			update Menu
				set
					fecha=@pfecha,
					comentario=@pcomentario

			Where id_menu=@pid_menu
	commit
		end try
		begin catch
			rollback
		end catch
	end
go


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Menu_D
	@pid_menu int
as
begin
	begin tran
		begin try
			DELETE Menu
			Where id_menu=@pid_menu
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE usp_Menu_S
as
begin
	select * from Menu
end
go



