-- Creación de tablas
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

--Crear base de datos
CREATE DATABASE BAE_Restaurante
go

--Seleccionar y usar la base de datos "Biblioteca"
USE BAE_Restaurante

/*Se procede a crear las tablas y asignando los atributos correspondientes que se
desarrollaron en el diseño de la base de datos*/


/*Creación de la tabla "Cargo"*/
if (not exists(select 1 from SYS.tables where name='Cargo'))
create table Cargo(
	id_cargo INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(45) not null unique,
	sueldo int not null
);

/*Creación de la tabla "Empleado"*/
if (not exists(select 1 from SYS.tables where name='Empleado'))
create table Empleado(
	id_empleado INT IDENTITY (1, 1) PRIMARY KEY,
	dni varchar(8) not null unique,
	nombres varchar(45) not null,
	apellidos varchar(45) not null,
	fecha_nacimiento date,
	direccion text,
	celular varchar(15),
	email text,
	estado bit not null,

    id_cargo int not null,
	FOREIGN KEY (id_cargo) 
		REFERENCES Cargo(id_cargo)
);

/*Creación de la tabla "Control"*/
if (not exists(select 1 from SYS.tables where name='Control'))
create table Control(
	id_control INT IDENTITY (1, 1) PRIMARY KEY,
	fecha date not null,
	hora_inicio time not null,
	hora_fin time null,
	falta bit null,

	id_empleado int not null,
	FOREIGN KEY (id_empleado) 
		REFERENCES Empleado(id_empleado)
);

/*Creación de la tabla "Usuario"*/
if (not exists(select 1 from SYS.tables where name='Usuario'))
create table Usuario(
	id_usuario INT IDENTITY (1, 1) PRIMARY KEY,
	usuario varchar(50) not null unique,
	contrasena varchar(30) not null,
	rol varchar(30) not null,
	estado bit not null,

	id_empleado int not null unique,
	FOREIGN KEY (id_empleado) 
		REFERENCES Empleado(id_empleado)
);

/*Creación de la tabla "Mesa"*/
if (not exists(select 1 from SYS.tables where name='Mesa'))
create table Mesa(
	id_mesa INT IDENTITY (1, 1) PRIMARY KEY,
	codigo varchar(50) not null unique,
	estado bit not null
);

/*Creación de la tabla "Cliente"*/
if (not exists(select 1 from SYS.tables where name='Cliente'))
create table Cliente(
	id_cliente INT IDENTITY (1, 1) PRIMARY KEY,
	num_documento varchar(8) not null unique,
	tipo_documento varchar(30) not null,
	nombres varchar(45) not null,
	apellidos varchar(45) not null,
	direccion text,
	celular varchar(15)
);

/*Creación de la tabla "Pedido"*/
if (not exists(select 1 from SYS.tables where name='Pedido'))
create table Pedido(
	id_pedido INT IDENTITY (1, 1) PRIMARY KEY,
	fecha date not null,
	tipo_pedido varchar(30) not null,
	tipo_pago varchar(30) not null,
	imagen_pago varbinary(max) not null,
	estado varchar not null,
	comentario text,

	id_empleado int not null,
	FOREIGN KEY (id_empleado) 
		REFERENCES Empleado(id_empleado),
	id_cliente int not null,
	FOREIGN KEY (id_cliente) 
		REFERENCES Cliente(id_cliente),
	id_mesa int,
	FOREIGN KEY (id_mesa) 
		REFERENCES Mesa(id_mesa)
);

/*Creación de la tabla "Doc_venta"*/
if (not exists(select 1 from SYS.tables where name='Doc_venta'))
create table Doc_venta(
	id_doc_venta INT IDENTITY (1, 1) PRIMARY KEY,
	tipo_doc_venta varchar(20) not null,
	num_doc_venta int not null unique,
	venta_total numeric(10,3) not null,
	fecha date not null,
	comentario text,

	id_pedido int not null unique,
	FOREIGN KEY (id_pedido) 
		REFERENCES Pedido(id_pedido)
);

/*Creación de la tabla "Reserva"*/
if (not exists(select 1 from SYS.tables where name='Reserva'))
create table Reserva(
	id_reserva INT IDENTITY (1, 1) PRIMARY KEY,
	fecha date not null,
	hora_inicio time not null,
	hora_fin time,

	id_cliente int not null,
	FOREIGN KEY (id_cliente) 
		REFERENCES Cliente(id_cliente)
);

/*Creación de la tabla "Reserva_Mesa"*/
if (not exists(select 1 from SYS.tables where name='Reserva_Mesa'))
create table Reserva_Mesa(
	id_mesa INT not null,
	id_reserva INT not null,
	PRIMARY KEY (id_reserva, id_mesa),

	FOREIGN KEY (id_reserva) 
        REFERENCES Reserva (id_reserva),
	FOREIGN KEY (id_mesa) 
        REFERENCES Mesa (id_mesa)
);

/*Creación de la tabla "Tipo_comida"*/
if (not exists(select 1 from SYS.tables where name='Tipo_comida'))
create table Tipo_comida(
	id_tipo_comida INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(35) not null
);

/*Creación de la tabla "Comida"*/
if (not exists(select 1 from SYS.tables where name='Comida'))
create table Comida(
	id_comida INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(100) not null,
	precio numeric(10,3) not null,
	cantidad int not null,
	comentario text,

	id_tipo_comida int not null,
	FOREIGN KEY (id_tipo_comida) 
		REFERENCES Tipo_comida(id_tipo_comida)
);

/*Creación de la tabla "Pedido_Comida"*/
if (not exists(select 1 from SYS.tables where name='Pedido_Comida'))
create table Pedido_Comida(
	id_pedido INT not null,
	id_comida INT not null,
	PRIMARY KEY (id_comida, id_pedido),

	FOREIGN KEY (id_comida)
        REFERENCES Comida (id_comida),
	FOREIGN KEY (id_pedido) 
        REFERENCES Pedido (id_pedido)
);

/*Creación de la tabla "Tipo_producto"*/
if (not exists(select 1 from SYS.tables where name='Tipo_producto'))
create table Tipo_producto(
	id_tipo_producto INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(35) not null
);

/*Creación de la tabla "Tipo_medida"*/
if (not exists(select 1 from SYS.tables where name='Tipo_medida'))
create table Tipo_medida(
	id_tipo_medida INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(35) not null
);


/*Creación de la tabla "Producto"*/
if (not exists(select 1 from SYS.tables where name='Producto'))
create table Producto(
	id_producto INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(100) not null,
	precio numeric(10,3) not null,
	cantidad int not null,
	fecha_vencimiento date not null,
	num_medida numeric (10,3) not null,
	comentario text,

	id_tipo_producto int not null,
	FOREIGN KEY (id_tipo_producto) 
		REFERENCES Tipo_producto(id_tipo_producto),
	id_tipo_medida int not null,
	FOREIGN KEY (id_tipo_medida) 
		REFERENCES Tipo_medida(id_tipo_medida)
);

/*Creación de la tabla "Pedido_Producto"*/
if (not exists(select 1 from SYS.tables where name='Pedido_Producto'))
create table Pedido_Producto(
	id_pedido INT not null,
	id_producto INT not null,
	PRIMARY KEY (id_producto, id_pedido),

	FOREIGN KEY (id_producto) 
        REFERENCES Producto (id_producto),
	FOREIGN KEY (id_pedido) 
        REFERENCES Pedido (id_pedido)
);

/*Creación de la tabla "Doc_compra"*/
if (not exists(select 1 from SYS.tables where name='Doc_compra'))
create table Doc_compra(
	id_doc_compra INT IDENTITY (1, 1) PRIMARY KEY,
	tipo_doc_compra varchar(20) not null,
	num_doc_compra int not null unique,
	venta_total numeric(10,3) not null,
	fecha date not null,
	comentario text,
);

/*Creación de la tabla "Producto_Doc_compra"*/
if (not exists(select 1 from SYS.tables where name='Producto_Doc_compra'))
create table Producto_Doc_compra(
	id_doc_compra INT not null,
	id_producto INT not null,
	PRIMARY KEY (id_producto, id_doc_compra),

	FOREIGN KEY (id_producto) 
        REFERENCES Producto (id_producto),
	FOREIGN KEY (id_doc_compra) 
        REFERENCES Doc_compra (id_doc_compra)
);

/*Creación de la tabla "Ingrediente"*/
if (not exists(select 1 from SYS.tables where name='Ingrediente'))
create table Ingrediente(
	id_ingrediente INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(100) not null,
	precio numeric(10,3) not null,
	cantidad int,
	comentario text,

	id_tipo_medida int,
	FOREIGN KEY (id_tipo_medida) 
		REFERENCES Tipo_medida(id_tipo_medida)
);

/*Creación de la tabla "Menu"*/
if (not exists(select 1 from SYS.tables where name='Menu'))
create table Menu(
	id_menu INT IDENTITY (1, 1) PRIMARY KEY,
	fecha date not null,
	comentario text,
);

/*Creación de la tabla "Menu_Comida"*/
if (not exists(select 1 from SYS.tables where name='Menu_Comida'))
create table Menu_Comida(
	id_menu INT not null,
	id_comida INT not null,
	PRIMARY KEY (id_menu, id_comida),

	FOREIGN KEY (id_menu) 
        REFERENCES Menu (id_menu),
	FOREIGN KEY (id_comida) 
        REFERENCES Comida (id_comida)
);

/*Creación de la tabla "Contactos"*/
if (not exists(select 1 from SYS.tables where name='Contactos'))
create table Contactos(
	id_contactos INT IDENTITY (1, 1) PRIMARY KEY,
	nombre varchar(100) not null,
	tipo_contacto varchar(50) not null,
	celular varchar(15),
	email text,
	fecha date not null,
	comentario text
);

/*Creación de la tabla "Empresa"*/
if (not exists(select 1 from SYS.tables where name='Empresa'))
create table Empresa(
	id_empresa INT IDENTITY (1, 1) PRIMARY KEY,
	caracteristica text not null,
	descripcion text not null
);