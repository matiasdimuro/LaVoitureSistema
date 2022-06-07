DROP DATABASE IF EXISTS LaVoiture;
CREATE DATABASE LaVoiture;
USE LaVoiture;

CREATE TABLE Vehiculos(
    idvehiculo INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    modelo VARCHAR(70),
    color VARCHAR(70),
    patente VARCHAR(15) UNIQUE,
    costo FLOAT,
    disponible BOOLEAN,
    CONSTRAINT PK_Vehiculos PRIMARY KEY (idVehiculo)
);

INSERT INTO Vehiculos VALUES

('', "Berlingo", "Gris", "AA976CD", 1500000, 0),
('', "C5 Aircross", "Negro", "AC321GH", 2000000, 0),
('', "C3", "Gris", "AD432GF", 1700000, 0),
('', "Berlingo", "Blanco", "AA333DJ", 1500000, 1),
('', "C4 Cactus", "Negro", "AD674LM", 2500000, 1),
('', "C4 Lounge", "Rojo", "AE549EM", 2100000, 1),
('', "DS3 Crossback", "Turquesa", "AB721OP", 3000000, 0),
('', "C5 Aircross", "Naranja", "AC499SD", 2000000, 0),
('', "DS3 Crossback", "Turquesa", "AB666GS", 3000000, 1),
('', "DS7 Crossback", "Blanco", "AF702JL", 3500000, 1);

CREATE TABLE Clientes(
    idCliente INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    nomyape VARCHAR(200),
    tel VARCHAR(50),
    mail VARCHAR(50),
    dom VARCHAR(50),
    DNI INT(11),
    CONSTRAINT PK_Clientes PRIMARY KEY (idCliente)
);

INSERT INTO Clientes VALUES 

('', "Alan Gómez", "11-8229-5792", "alanngomezz@gmail.com", "Av. Lacrose 6382", 29834274),
('', "Raquel Arruabarrena", "11-2801-8372", "arruabarrenaraq@hotmail.com", "Elpidio González 8341", 31892372),
('', "Joaquín Suriano", "11-9212-9213", "joaspeedy@gmail.com", "Concordia 1459", 21748192),
('', "Ramon Eriberto", "11-2431-2222", "ramoneriberto@gmail.com", "Melincue 5089", 11111111),
('', "Josefina Maria De las nieves", "11-8888-7777", "delasnievesJosema", "La cueva 9241", 17240918),
('', "Leonardo Di Ugarriza", "11-1010-0101", "DiugaugaLeo@hotmail.com", "Tenorio 8232", 32875923),
('', "Mariana Perú", "11-4512-1492", "PeruMarianaa@gmail.com", "Av. Álvarez Jonte 6234", 29834278),
('', "José Ricardo Tarantini", "11-2216-8091", "tarantiniJoseRick@hotmail.com", "Echegaray 4521", 32321754),
('', "Graciela De Nadia", "11-8892-1672", "gracieladenadia82@gmail.com", "Rio Cuarto 2661", 24920791),
('', "Sebastián Anaya", "11-9921-8261", "anayasebastiananaya037@yahoo.com.ar", "De Messi 2543", 95872217);


CREATE TABLE Propuestas(
    codPropuesta INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    descmediopago VARCHAR(50),
    idVehiculo INT(11),
    idCliente INT(11),
    monto FLOAT,
    CONSTRAINT PK_Propuestas PRIMARY KEY (codpropuesta),
    CONSTRAINT FK_Propuestas_Vehiculo FOREIGN KEY (idVehiculo) REFERENCES Vehiculos (idVehiculo),
    CONSTRAINT FK_Propuestas_Cliente FOREIGN KEY (idCliente) REFERENCES Clientes (idCliente)
);

INSERT INTO Propuestas VALUES 

('', "Contado-Cheque-1", 1, 1, 1300000),
('', "Contado-Cheque-1", 2, 2, 1950000),
('', "Contado-Cheque-1", 3, 3, 1600000),
('', "Financiado-Efectivo-6", 1, 4, 1500000),  -- ACEPTADAS
('', "Financiado-Efectivo-6", 2, 5, 2000000),  -- ACEPTADAS
('', "Financiado-Efectivo-6", 3, 6, 1700000),  -- ACEPTADAS
('', "Financiado-Efectivo-6", 7, 7, 1500000), -- ACEPTADAS
('', "Financiado-Efectivo-6", 8, 8, 2500000), -- ACEPTADAS
('', "Financiado-Efectivo-12", 6, 9, 2000000),
('', "Financiado-Efectivo-12", 1, 10, 1200000);

CREATE TABLE Accesorios(
    codAcces INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    nomaccesorio VARCHAR(100),
    costoextra FLOAT,
	idvehiculo INT NOT NULL,
    CONSTRAINT PK_Accesorios PRIMARY KEY (codAcces),
	CONSTRAINT FK_Accesorios_Vehiculo FOREIGN KEY (idvehiculo) REFERENCES vehiculos (idvehiculo)
);

INSERT INTO Accesorios VALUES 

('', "Polarizado Negro", 8000, 1),
('', "Polarizado Negro", 8000, 2),
('', "Polarizado Negro", 8000, 3),
('', "Polarizado Azul", 6000, 4),
('', "Polarizado Azul", 6000, 5),
('', "Polarizado Azul", 6000, 6),
('', "Alarma XSounder", 3000, 1),
('', "Alarma XSounder", 3000, 2),
('', "Alarma XSounder", 3000, 3),
('', "Asiento SmashComfortable", 4000, 1),
('', "Asiento SmashComfortable", 4000, 4),
('', "Asiento SmashComfortable", 4000, 5);

CREATE TABLE MediosPago(
    idMedioPago INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    tipo VARCHAR(20),
    medio VARCHAR(20),
    cuotas VARCHAR(5),
    CONSTRAINT PK_MediosPago PRIMARY KEY (idMedioPago)
);

INSERT INTO MediosPago VALUES 

('', "Contado", "Efectivo", 1),
('', "Contado", "Cheque", 1),
('', "Contado", "Transferencia", 1),
('', "Financiado", "Efectivo", 6),
('', "Financiado", "Cheque", 6),
('', "Financiado", "Transferencia", 6),
('', "Financiado", "Efectivo", 12),
('', "Financiado", "Cheque", 12),
('', "Financiado", "Transferencia", 12),
('', "Financiado", "Efectivo", 18),
('', "Financiado", "Cheque", 18),
('', "Financiado", "Transferencia", 18);


CREATE TABLE FacturasVenta(
    idFacturaVenta INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    FEVE DATE,
    tipo VARCHAR(5),
    monto FLOAT, 
    descrip VARCHAR(200),
    idMedioPago INT(11),
    codPropuesta INT(11),
    CONSTRAINT PK_FacturasVenta PRIMARY KEY (idFacturaVenta),
    CONSTRAINT FK_FacturasVenta_MedioPago FOREIGN KEY (idMedioPago) REFERENCES MediosPago (idMedioPago),
    CONSTRAINT FK_FacturasVenta_Propuesta FOREIGN KEY (codPropuesta) REFERENCES Propuestas (codPropuesta)
);

INSERT INTO FacturasVenta VALUES 

('', "2021/05/01", "B", 1500000, "Berlingo Gris con Polarizado Negro", 4, 4),
('', "2021/05/01", "B", 2000000, "C5 Aircross Negro con Polarizado Negro", 4, 5),
('', "2021/05/01", "B", 1700000, "C3 Gris con Polarizado Azul", 4, 6),
('', "2021/05/01", "B", 1500000, "Berlingo Blanco con Polarizado Azul", 2, 7),
('', "2021/05/01", "B", 2500000, "C4 Cactus Negro con Polarizado Negro, Alarma XSounder y Asiento SmashComfortable", 2, 8);

CREATE TABLE RecibosVenta(
    idReciboVenta INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    FReciboV DATE,
    idFacturaVenta INT(11),
	monto FLOAT,
    CONSTRAINT PK_RecibosVenta PRIMARY KEY (idReciboVenta),
    CONSTRAINT FK_RecibosVenta_FacturaVenta FOREIGN KEY (idFacturaVenta) REFERENCES FacturasVenta (idFacturaVenta)
);

INSERT INTO RecibosVenta VALUES 

('', "2021/05/02", 1, 250000), -- 6 cuotas de 1500000
('', "2021/05/02", 2, 333333), -- 6 cuotas 2000000
('', "2021/05/02", 3, 283333), -- 6 cuotas 1700000
('', "2021/05/02", 4, 1500000), -- Contado
('', "2021/05/02", 5, 2500000); -- Contado

CREATE TABLE ChequesVenta(
    codChequeV INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    feChequeV DATE,
    fvChequeV DATE,
    monto FLOAT,
    idReciboVenta INT(11),
    CONSTRAINT PK_ChequesVenta PRIMARY KEY (codChequeV),
    CONSTRAINT FK_ChequesVenta_ReciboVenta FOREIGN KEY (idReciboVenta) REFERENCES RecibosVenta (idReciboVenta)
);

INSERT INTO ChequesVenta VALUES 

('', "2021/05/02", "2021/06/02", 1500000, 4),
('', "2021/05/02", "2021/06/02", 2500000, 5);

CREATE TABLE Proveedores(
    idProveedor INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    nomProv VARCHAR(50),
    direc VARCHAR(50),
    tel VARCHAR(50),
    mail VARCHAR(50),
    descrip VARCHAR(200),
    CONSTRAINT PK_Proveedor PRIMARY KEY (idProveedor) 
);

INSERT INTO Proveedores VALUES 

('', "Citroen", "Av. Triunvirato 3534", "11-4787-8878", "CitroenTriunvirato@gmail.com", null),
('', "Polarizados CARS", "Moliere 2669", "11-5050-3030", "carspolis@gmail.com", null),
('', "Formulate Uno Accesorios", "Lascano 301", "11-1122-2211", "formulat1@gmail.com", null);

CREATE TABLE OrdenesCompra(
    codOC INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    FEOC DATE,
    FROC DATE,
    producto VARCHAR(50),
    cantidad INT(11),
    estado TINYINT(1),
    idProveedor INT(11),
    CONSTRAINT PK_OrdenesCompra PRIMARY KEY (codOC),
    CONSTRAINT FK_OrdenesCompra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedores (idProveedor) 
);

INSERT INTO OrdenesCompra VALUES 

('', "2021/04/01", null, "Pedido de vehiculo a Citroen", 1, 1, 1),
('', "2021/04/01", null, "Polarizado Negro", 3, 1, 2),
('', "2021/04/01", null, "Polarizado Azul", 3, 1, 2),
('', "2021/04/01", null, "Alarma XSounder", 3, 1, 3);

CREATE TABLE FacturasCompra(
    idFacturaCompra INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    FEFC DATE,
    tipo VARCHAR(5),
    monto FLOAT,
    descrip VARCHAR(200),
    Proveedor VARCHAR(50),
    idMedioPago INT(11),
    codOC INT(11),
    CONSTRAINT PK_FacturasCompra PRIMARY KEY (idFacturaCompra),
    CONSTRAINT FK_FacturasCompra_MedioPago FOREIGN KEY (idMedioPago) REFERENCES MediosPago (idMedioPago),
    CONSTRAINT FK_FacturasCompra_OrdenCompra FOREIGN KEY (codOC) REFERENCES OrdenesCompra (codOC)
);

INSERT INTO FacturasCompra VALUES 

('', "2021/04/05", "A", 3500000, "", "Citroen", 3, 1),
('', "2021/04/05", "A", 8000, "", "Polarizados CARS", 3, 2),
('', "2021/04/05", "A", 6000, "", "Polarizados CARS", 3, 3),
('', "2021/04/05", "A", 3000, "", "Formulate Uno Accesorios", 3, 4);

CREATE TABLE RemitosCompra(
    codRemito INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    FRemito DATE,
    descrip VARCHAR(200),
    firmado TINYINT(1),
    idFacturaCompra INT(11),
    CONSTRAINT PK_RemitosCompra PRIMARY KEY (codRemito),
    CONSTRAINT FK_RemitosCompra_FacturaCompra FOREIGN KEY (idFacturaCompra) REFERENCES FacturasCompra (idFacturaCompra)
);

INSERT INTO RemitosCompra VALUES 

('', "2021/04/05", "", 1, 1),
('', "2021/04/05", "", 1, 2),
('', "2021/04/05", "", 1, 3),
('', "2021/04/05", "", 1, 4);

CREATE TABLE RecibosCompra(
    idReciboCompra INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    FReciboC DATE,
    monto FLOAT,
    idFacturaCompra INT(11),
    CONSTRAINT PK_RecibosCompra PRIMARY KEY (idReciboCompra),
    CONSTRAINT FK_RecibosCompra_FacturaCompra FOREIGN KEY (idFacturaCompra) REFERENCES FacturasCompra (idFacturaCompra) 
);

INSERT INTO RecibosCompra VALUES 

('', "2021/04/06", 3500000, 1),
('', "2021/04/06", 8000, 2),
('', "2021/04/06", 6000, 3),
('', "2021/04/06", 3000, 4);

CREATE TABLE ChequesCompra(
    codChequeC INT(11) AUTO_INCREMENT NOT NULL UNIQUE,
    feChequeC DATE,
    fvChequeC DATE, 
    monto FLOAT,
    idFacturaCompra INT(11),
    CONSTRAINT PK_ChequesCompra PRIMARY KEY (codChequeC),
    CONSTRAINT FK_ChequesCompra_FacturaCompra FOREIGN KEY (idFacturaCompra) REFERENCES FacturasCompra (idFacturaCompra) 
);