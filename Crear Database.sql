create database AppBanco
go
use AppBanco
go

create table Cliente(
id_cliente int not null identity,
nombre varchar(30),
apellido varchar(30),
dni int

constraint pk_cliente PRIMARY KEY(id_cliente)
)

create table Tipo_Cuenta(
id_tipo_cuenta int not null identity,
nombre varchar(30)
constraint pk_tipo_cuenta PRIMARY KEY(id_tipo_cuenta)
)

create table Cuenta(
id_cuenta int not null identity,
id_cliente int,
saldo decimal(18,0),
id_tipo_cuenta int,
ultimo_movimiento datetime,
cbu int
constraint pk_cuenta PRIMARY KEY(id_cuenta)
constraint fk_cuenta_id_cliente FOREIGN KEY(id_cliente) references Cliente(id_cliente),
constraint fk_cuenta_id_tipo FOREIGN KEY(id_tipo_cuenta) references Tipo_Cuenta(id_tipo_cuenta)
)