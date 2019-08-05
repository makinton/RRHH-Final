CREATE DATABASE RRHH

USE RRHH

CREATE TABLE MantEmpleados(
IDEmpleados INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CodEmpleado AS ('CE'+RIGHT ('00' + CONVERT(VARCHAR,IDEmpleados),(2))),
Nombre NVARCHAR(30) NOT NULL,
Apellido NVARCHAR(30) NOT NULL,
Telefono NVARCHAR(20),
Departamento NVARCHAR(50) NOT NULL,
Cargo NVARCHAR(20) NOT NULL,
FIngreso NVARCHAR(30) NOT NULL,
Salario float NOT NULL,
Estatus NVARCHAR(10) 

)

alter table MantEmpleados
alter column Salario int not null

INSERT INTO MantEmpleados VALUES ('Julian','Alvarez',8090001111,'Contabilidad','Supervisor','01/08/2000','8000','Activo')
INSERT INTO MantEmpleados VALUES ('Carlos','Mejia',80900011122,'Contabilidad','Digitador','04/08/2005',8000,'Activo')
INSERT INTO MantEmpleados VALUES ('JULIO','MENDEZ',849444000,'INFORMATICA','SUPERVISOR','06/22/2009',40000,'Inactivo')
insert into MantEmpleados values ('Michael','Mejia',8294587896,'Almacen Heeramientas','Encargado','08/25/2012',15000,'Inactivo')

SELECT * FROM MantEmpleados


--Procedimiento Almacenado Buscar Empleado--

create proc BuscarEmpleados
@Buscar nvarchar(30)
as
select * from MantEmpleados
where Nombre like @Buscar + '%'

--Procedimiento Almacenado Insertar Empleado--

create proc InsertarEmpleado
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Telefono nvarchar(20),
@Departamento nvarchar(50),
@Cargo nvarchar(20),
@FIngreso date,
@Salario int,
@Estatus nvarchar(10)
as
insert into MantEmpleados values (@Nombre,@Apellido,@Telefono,@Departamento,@Cargo,@FIngreso,@Salario,@Estatus)

--Procedimiento Almacenado Editar Empleados--

create proc EditarEmpleado
@IDEmpleados int,
@Nombre nvarchar(30),
@Apellido nvarchar(30),
@Telefono nvarchar(20),
@Departamento nvarchar(50),
@Cargo nvarchar(20),
@FIngreso date,
@Salario int,
@Estatus nvarchar(10)
as 
update MantEmpleados set Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Departamento = @Departamento, Cargo = @Cargo, FIngreso = @FIngreso, Salario = @Salario, Estatus = @Estatus
where IDEmpleados = @IDEmpleados

--Precedimientos Almacenado Eliminar Empleados--

create proc EliminarEmpleado
@IDEmpleados int
as 
Delete MantEmpleados
where IDEmpleados = @IDEmpleados


--......................--

create table MantDepartamentos(
IDDepartamentos INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CodDepartamentos AS ('CD'+RIGHT ('00' + CONVERT(VARCHAR,IDDepartamentos),(2))),
Nombre nvarchar(30) not null,
Encargado nvarchar(30) null
 
)

insert into MantDepartamentos values ('Contabilidad','Julian')

select * from MantDepartamentos

--Procedimiento Almacenado Buscar Departamentos--

create proc BuscarDepartamentos
@Buscar nvarchar(30)
as
select * from MantDepartamentos
where Nombre like @Buscar + '%'

--Procedimiento Almacenado Insertar Departamentos--

create proc InsertarDepartamentos
@Nombre nvarchar(30),
@Encargado nvarchar(30)
as
insert into MantDepartamentos values (@Nombre, @Encargado)

--Procedimiento Almacenado Editar Departamentos--

create proc EditarDepartamentos
@IDDepartamentos int,
@Nombre nvarchar(30),
@Encargado nvarchar(30)
as 
update MantDepartamentos set Nombre = @Nombre, Encargado = @Encargado
where IDDepartamentos = @IDDepartamentos

--Precedimientos Almacenado Eliminar Departamentos--

create proc EliminarDepartamentos
@IDDepartamentos int
as 
Delete MantDepartamentos
where IDDepartamentos = @IDDepartamentos


--................--

create table MantCargos(
IDCargos INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CodCargos AS ('CC'+RIGHT ('00' + CONVERT(VARCHAR,IDCargos),(2))),
Cargo nvarchar(30) not null,

)

insert into MantCargos values ('Supervisor')
insert into MantCargos values ('Digitador')

--Procedimiento Almacenado Buscar Cargos--

create proc BuscarCargos
@Buscar nvarchar(30)
as
select * from MantCargos
where Cargo like @Buscar + '%'

--Procedimiento Almacenado Insertar Cargos--

create proc InsertarCargos
@Cargo nvarchar(30)
as
insert into MantCargos values (@Cargo)

--Procedimiento Almacenado Editar Cargos--

create proc EditarCargos
@IDCargos int,
@Cargo nvarchar(30)
as 
update MantCargos set Cargo = @Cargo
where IDCargos = @IDCargos

--Precedimientos Almacenado Eliminar Cargos--

create proc EliminarCargos
@IDCargos int
as 
Delete MantCargos
where IDCargos = @IDCargos

--......................--

create table Nominas(
IDNominas INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CODNominas AS ('CM'+RIGHT ('00' + CONVERT(VARCHAR,IDNominas),(2))),
Mes nvarchar(30) not null,
MontoTotal varchar(50)

)

create proc CalcularNominaActivo
as begin
select sum(Salario) as MontoTotalA from MantEmpleados where Estatus='Activo'
end

create proc CalcularNominaInactivo
as begin
select sum(Salario) as MontoTotalI from MantEmpleados where Estatus='Inactivo'
end

create proc CalcularNominaActivo
as begin
select sum(Salario) as MontoTotalA from MantEmpleados where Estatus='Activo'
end



--..................--

create table SalidaEmpleados(
IDSalidas int identity(1,1) primary key not null,
CODSalidas as ('CS'+right ('00' + convert(varchar,IDSalidas),(2))),
TipoSalida nvarchar(30) not null,
Motivo nvarchar(100),
IDEmpleados int
constraint FK_IDEmpleado foreign key(IDEmpleados) references MantEmpleados (IDEmpleados)
)

select * from SalidaEmpleados

create proc SalidaEmpleadosProc
@_CodEmpleados int

as begin
update MantEmpleados set Estatus='Inactivo' where CodEmpleado=@_CodEmpleados
end

create proc InsertarSalidas
@TipoSalida nvarchar(30),
@Motivo nvarchar(100)
as 
insert into SalidaEmpleados values (@TipoSalida, @Motivo)

create proc EmpleadosInactivosTotal
@TotalInactivo nvarchar(30)
as
select * from MantEmpleados 
where Estatus=@TotalInactivo

create proc EmpleadosActivos
@TotalActivo nvarchar(30)
as 
select * from MantEmpleados
where Estatus=@TotalActivo

--000000000000000--

create proc ObtenerEmpleados

as begin
select * from MantEmpleados
end