Drop database if exists Concesionaria;
Create database Concesionaria;
Use Concesionaria;

delimiter //

Create table Usuarios(
	IdUs int primary key auto_increment,
	Nombre varchar(25) not null,
	Contra varchar(25) not null
);

Create table Clientes(
	IdCliente int primary key auto_increment,
	Nombre varchar(20) not null,
	Apellido varchar(20) not null,
	DNI varchar(8) not null,
	Domicilio varchar(50),
	Email varchar(50),
	Telefono int
);

Create table Precios(
	NPre int primary key auto_increment,
	Precio float not null
);

insert into Precios values
	(500,240000),
	('',450000),
	('',340000),
	('',300000),
	('',190000),
	('',240000),
	('',190000),
	('',240000),
	('',190000),
	('',240000);

Insert into Clientes values
	(0, "Alvaro", "Garcia", "43120120", null, null, null),
	('', "Abril", "Olivera", "43700890", null, null, null),
	('', "Martin", "Ortuño", "43815142", null, null, null);


Create table Autos(
	IdAuto int primary key auto_increment,
	Marca varchar(30) not null,
	Modelo varchar(30) not null,
	Precio int,
	foreign key(Precio) references Precios(NPre)
);

Insert into Autos values
	(120, "Renault", "Kangoo", 500),
	('', "Audi", "R8-E-TRON", 501),
	('', "Peugeot", "405", 502),
	('', "Fiat", "Fiorino" , 503),
	('', "Ford", "Fiesta", 504);


Create table Presupuestos(
	NPres int primary key auto_increment,
	IdCliente int,
	Tipo varchar(25), /*Venta/Compra*/
	FEmicion date, /*Fecha de emision*/
	FVen date, /*Fecha de vencimiento (2 meses despues de la de emision)*/
	Monto float, /*Campo calculado que se saca de hacer una suboconsulta que apunte a la tabla precios*/
	foreign key (IdCliente) references Clientes(IdCliente)
);

Insert into Presupuestos values 
	(100, 2, "Venta", "2019/05/12", "2019/07/12", 900000),
	('', 1, "Venta", "2019/08/22", curdate(), 450000);

Create table Almacen(
	IdAutoU int primary key auto_increment,
	Matricula varchar(7),
	Marca varchar(30),
	Modelo varchar(30),
	Color varchar(25),
	NBast varchar(10),
	Precio int,
	FechaI date, /*Ingreso*/
	KmU int not null,
	foreign key (Precio) references Precios(NPre)
);

Insert into Almacen values
	(320, "AB123CD", "Citroen", "C3 1.4", "Gris", "93HFB2680C000001", 505, "2014/02/18", 1501),
	('', "AC069ZT", "Renault", "Megane 1.6", "Blanco", "WDB2010242F068513", 506, "2016/06/29", 500),
	('', "AB141CE", "Fiat", "600R", "Azul", "93HFB2490C000001", 507, "2012/10/21", 3022),
	('', "AC083ZT", "Toyota", "Hilux Srv 4x2", "Negro", "WDB2010242F062113", 508, "2016/02/29", 678),
	('', "AC503CD", "Volkswagen", "Gol 1.6", "Blanco", "93HFB2680C021001", 509, "2011/04/25", 410);

Create table Autos_Presupuestos(
	Presupuesto int,
	Auto int,
	Color varchar(25),
	Interes float, /*Representa el valor del auto con intereses que se le cobraria al cliente si decide comprar el auto en credito, siempre se cobra 30% de intereses
	                 Se que se podria hacer mejor poniendo este atributo en la tabla presupuestos, pero eso tomaria mucho tiempo ya que tendriamos que editar todas las partes en el sistema
	                 donde se hace mension a este atributo en esta tabla*/
	primary key (Presupuesto, Auto),
	foreign key (Presupuesto) references Presupuestos(NPres),
	foreign key (Auto) references Autos(IdAuto)
);

Insert into Autos_Presupuestos values
	(101, 121, "Rosa", 6300000);

Create table AutosU_Presupuestos(
	Presupuesto int,
	AutoU int,
	Interes int, /*Representa el valor del auto con intereses que se le cobraria al cliente si decide comprar el auto en credito, siempre se cobra 30% de intereses*/
	primary key (Presupuesto, AutoU),
	foreign key (Presupuesto) references Presupuestos(NPres),
	foreign key (AutoU) references Almacen(IdAutoU)
);

Insert into AutosU_Presupuestos values
	(100, 322, 675000);

Create table Constancias_cp( /*Constancias compraventa*/
	IdCons int primary key auto_increment,
	Presupuesto int,
	Fecha date, /*La fecha en la que se emitio la constancia*/
	Monto float, /*Campo calculado, viene del precio del auto*/
	Metodo varchar(25), /*Efectivo/Credito*/
	foreign key (Presupuesto) references Presupuestos(NPres)
);

Create table Constancia_Auto(
	Constancia int,
	Auto int,
	primary key (Constancia, Auto),
	foreign key (Constancia) references Constancias_cp(IdCons),
	foreign key (Auto) references Autos(IdAuto)
);

Create table Constancia_AutoU(
	Constancia int,
	AutoU int,
	primary key (Constancia, AutoU),
	foreign key (Constancia) references Constancias_cp(IdCons),
	foreign key (AutoU) references Almacen(IdAutoU)
);

Create table Cheques(
	NCheque int primary key auto_increment,
	Nombre varchar(25), /*Nombre del que emite el cheque*/
	Numero_de_ruta int, /*9 digitos*/
	Numero_de_cuenta int, /*9 digitos*/
	Monto float,
	Fecha date, /*Fecha en la que se emitio el cheque*/
	Tipo varchar(25), /*Entrada, salida*/
	Motivo varchar(100) /*Motivo por el cual el cheque es emitido o recibido*/
);

Create table Cheques_Clientes(
	Cheque int,
	Cliente int,
	primary key (Cheque, Cliente),
	foreign key (Cheque) references Cheques(NCheque),
	foreign key (Cliente) references Clientes(IdCliente)
);

Create table Accesorios(
	IdAcc int primary key auto_increment,
	Descripcion varchar(50),/*Nombre del producto*/
	Stock int,
	Precio int,
	foreign key(Precio) references Precios(NPre)
);

Create table Contratos_cre( /*Contratos de credito prendiario. Los contratos se dan de 35 cuotas nada mas*/
	IdCont int primary key auto_increment,
	Cliente int,
	CP int,/*NUEVO*/
	Monto int, /*Campo calculado, viene del precio que tenga el presupuesto, con intereses ya puestos*/
	FechaE date, /*Dia que se emitio el contrato*/
	FechaV date, /*Fecha de vencimiento. Es la fecha en la que se emitio mas 28 meses*/
	foreign key (Cliente) references Clientes(IdCliente),
	foreign	key (CP) references	 Constancias_cp(IdCons) /*NUEVO*/
);

Create table Garantia(
	NGar int primary key auto_increment,
	Constancia int,
	Descripcion varchar(100),
	FechaI date,
	FechaF date,
	foreign key (Constancia) references Constancias_cp(IdCons)
);

Create table Seguros(
	NSeg int primary key auto_increment,
	NPoliza int not null,
	Aseguradora varchar(50), /*Este por lo general es una sola aseguradora la que hace todos los seguros*/
	Constancia int,
	FechaE date, /*Fecha de emision*/
	FechaR date, /*Fecha de renovacion, osea fecha en la que el cliente tiene que renovar el seguro*/
	foreign key (Constancia) references Constancias_cp(IdCons)
);

Create table Acc_Presupuestos(
	Presupuesto int,
	Accesorio int,
	primary key (Presupuesto, Accesorio),
	foreign key (Presupuesto) references Presupuestos(NPres),
	foreign key (Accesorio) references Accesorios(IdAcc)
);

Create table Cuotas(
	IdCuo int primary key auto_increment,
	Contrato int,
	FechaM date, /*Fecha maxima en la que el cliente puede que pagar*/
	Monto float,
	Debe boolean, /*null: Todavia no alcanzo el limite de tiempo*/
				  /*0: Pago*/
				  /*1: Debe*/
	foreign key (Contrato) references Contratos_cre(IdCont)
);

Create table Recibos(
	NRecibo int primary key auto_increment,
	Nombre varchar(25), /*Nombre del que recibe el recibo*/
	FechaE date /*Fecha de emision*/
);

Create table Recibos_Presupuestos(
	Recibo int,
	Presupuesto int,
	primary key (Presupuesto, Recibo),
	foreign key (Presupuesto) references Presupuestos(NPres),
	foreign key (Recibo) references Recibos(NRecibo)
);

Create table Recibos_Cuotas(
	Recibo int,
	IdCuo int,
	primary key (IdCuo, Recibo),
	foreign key (Recibo) references Recibos(NRecibo),
	foreign key (IdCuo) references Cuotas(IdCuo)
);

Create table Recibos_Cheques(
	Recibo int,
	Cheque int,
	primary key (Cheque, Recibo),
	foreign key (Recibo) references Recibos(NRecibo),
	foreign key (Cheque) references Cheques(NCheque)
);

Create table Nota_ins(/*Nota de instalacion*/
	IdNota int primary key auto_increment,
	Auto int,
	Descripcion varchar(70), /*Accesorios a instalar*/
	Estado boolean, /*True:Ya instalado/False:Pendiente*/
	foreign key (Auto) references Constancias_cp(IdCons)
);

Create table Facturas(
	NFact int primary key auto_increment,
	Nombre varchar(25), /*Nombre del que recibe la factura (Campo calculado)*/
	Tipo varchar(1) /*A,B,C*/
);

Create table OrdenCompra(
	IdOC int primary key auto_increment,
	Receptor varchar(25),
	Produtos varchar(150)
);

Create table Reparaciones(
	NReparacion int primary key auto_increment,
	Constancia int,
	Presupuesto int,
	Factura int,
	FechaI date, /*Fecha de ingreso del auto*/
	FechaS date, /*Fecha de salida del auto*/
	Descripcion varchar(100), /*Descripcion de los daños arreglados*/
	Tipo varchar(25),/*Con o sin garantia*/
	foreign key (Factura) references Facturas(NFact),
	foreign key (Presupuesto) references Presupuestos (NPres),
	foreign key (Constancia) references Constancias_cp(IdCons)
);

Create table Constancias_res(/*Constancias de reserva*/
	IdRes int primary key auto_increment,
	Presupuesto int,
	Metodo varchar(15), /*Efectivo/Credito*/
	Sena float, /*Puede ser null si el cliente paa en credito*/
	foreign key(Presupuesto) references Presupuestos(NPres)
);

Insert into Constancias_res values
	(600, 100, "Efectivo", 10000),
	('', 101, "Credito", null);

Create table ConsRes_0km(
	Reserva int,
	Auto int,
	primary key(Reserva, Auto),
	foreign key(Auto) references Autos(IdAuto),
	foreign key(Reserva) references Constancias_res(IdRes)
);

Create table ConsRes_U(
	Reserva int,
	AutoU int,
	primary key(Reserva, AutoU),
	foreign key(AutoU) references Almacen(IdAutoU),
	foreign key(Reserva) references Constancias_res(IdRes)
);

Insert into ConsRes_U values
	(600, 322);

Create Table Solicitud_Cre(/*Solicitudes de creditos prendiarios*/
	IdSolC int primary key auto_increment,
	Presupuesto int,
	CUIL varchar(11),
	Trabajo varchar(50), /*Donde trabaja*/
	Salario int,
	Estado varchar(11), /*Aprobado/Desaprobado/En tramite
						  Esto no lo cambiamos nosotros, lo cambia el sector de creditos*/
	Motivo varchar(100), /*Es null si esta aprobado o en tramite*/
	foreign key(Presupuesto) references Presupuestos(NPres)
);

Create Table Solicitudes_Pol(/*Solicitudes de poliza*/
	idSolP int primary key auto_increment,
	Pres int,
	Estado varchar(15), /*En tramite/Terminado
				          Esto lo cambia el sector de finansas*/
	foreign key(Pres) references Presupuestos(NPres)
);

insert into Solicitud_Cre values ('', 101, "39285910391", "Test jobs", 15000, "Aprobado", null);
//

delimiter ;


/*update solicitud_Cre set estado="Aprobado" where presupuesto=102;*/