-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
---------------------- MENU_COMIDA -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE usp_Menu_Comida_I
	@pid_menu INT,
	@pid_comida INT
as
begin
	begin tran
		begin try
			insert into Menu_Comida
			values(@pid_menu,@pid_comida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
go

--Procedimiento almacenado de Listar
CREATE PROCEDURE  usp_Menu_Comida_S
as
begin
	select *from Menu_Comida
end
go

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE usp_Menu_Comida_D
	@pid_menu INT,
	@pid_comida INT
as
begin
	begin tran
		begin try
			DELETE Menu_Comida
			Where id_menu=@pid_menu
			and id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
go