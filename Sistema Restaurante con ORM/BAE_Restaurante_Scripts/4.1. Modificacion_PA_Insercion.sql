USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_S]    Script Date: 29/12/2020 16:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
ALTER PROCEDURE [dbo].[usp_Usuario_S]
as
begin
	select u.id_usuario,u.usuario,u.contrasena,u.rol,u.estado,e.nombres,e.apellidos,e.id_empleado
	from Usuario as u
	inner join Empleado as e
	on e.id_empleado=u.id_empleado
end

USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_S]    Script Date: 29/12/2020 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Empleado_S]
as
begin
	select e.id_empleado,e.dni,e.nombres,e.apellidos,e.fecha_nacimiento,e.direccion,e.celular,e.email,e.estado,c.nombre,c.id_cargo
	from Empleado as e
	inner join Cargo as c
	on e.id_cargo=c.id_cargo
end

USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Control_S]    Script Date: 29/12/2020 16:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Control_S]
as
begin
	select c.id_control,c.fecha,c.hora_inicio,c.hora_fin,c.falta,e.nombres,e.apellidos,e.id_empleado
	from Control as c
	inner join Empleado as e
	on e.id_empleado=c.id_empleado
end

USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Comida_S]    Script Date: 29/12/2020 16:56:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
ALTER PROCEDURE [dbo].[usp_Comida_S]
as
begin
	select c.id_comida,c.nombre,c.precio,c.cantidad,c.comentario,tc.nombre,tc.id_tipo_comida
	from Comida as c
	inner join Tipo_comida as tc
	on c.id_tipo_comida=tc.id_tipo_comida
end


USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_S]    Script Date: 29/12/2020 16:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
ALTER PROCEDURE [dbo].[usp_Producto_S]
as
begin
	select p.nombre,p.precio,p.cantidad,p.fecha_vencimiento,p.num_medida,tm.nombre,tp.nombre,p.comentario,tm.id_tipo_medida,tp.id_tipo_producto
	from Producto as p
	inner join Tipo_producto as tp
	on p.id_tipo_producto=tp.id_tipo_producto
	inner join Tipo_medida as tm
	on p.id_tipo_medida=tm.id_tipo_medida
end

USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_S]    Script Date: 29/12/2020 16:58:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento almacenado de Listar
ALTER PROCEDURE [dbo].[usp_Doc_venta_S]
as
begin
	select dv.id_pedido,dv.tipo_doc_venta,dv.num_doc_venta,dv.venta_total,dv.fecha,dv.comentario,
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombres cliente',c.apellidos as 'Apellidos cliente',p.id_pedido,c.id_cliente
	from Doc_venta as dv
	
	inner join Pedido as p
	on dv.id_pedido=p.id_pedido

	inner join Cliente as c
	on p.id_cliente=c.id_cliente
end

USE [BAE_Restaurante]
GO
/****** Object:  StoredProcedure [dbo].[usp_Ingrediente_S]    Script Date: 29/12/2020 16:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
ALTER PROCEDURE [dbo].[usp_Ingrediente_S]
as
begin
	select i.nombre,i.precio,i.cantidad,tm.nombre,i.comentario,tm.id_tipo_medida
	from Ingrediente as i
	inner join Tipo_medida as tm
	on i.id_tipo_medida=tm.id_tipo_medida
end
