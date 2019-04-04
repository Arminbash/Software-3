create database Software3

use Software3

create table DatosUsuario(
Id int identity(1,1) primary key,
Nombre nvarchar(500),
Estatus bit
)
create table  DatosEmpresa(
Id int identity(1,1) primary key,
Nombre nvarchar(500),
Proposito nvarchar(1000),
Estatus bit
)

create table Proceso(
Id int identity(1,1) primary key,
CodigoProceso nvarchar(1000),
NombreProceso nvarchar(1000),
PropositoProceso nvarchar(1000),
Estatus bit
)

create table ProcesoEmpresa(
Id int identity(1,1) primary key,
IdProceso int foreign key  references Proceso(id),
IdEmpresa int foreign  key references DatosEmpresa(id),
Nivel0 decimal(18,2),
Nivel1 decimal(18,2),
Nivel2 decimal(18,2),
Nivel3 decimal(18,2),
Nivel4 decimal(18,2),
Nivel5 decimal(18,2),
Estatus bit
)

create table Nivel(
Id int identity(1,1) primary key,
IdProceso int foreign  key references Proceso(Id),
CodigoNivel nvarchar(1000),
Detalles nvarchar(1000),
Estatus bit
)
create table PropositoNivel(
Id int identity(1,1) primary key,
IdNivel int foreign  key references Nivel(Id),
Proposito nvarchar(1000),
Estatus bit
)

create table Criterio(
Id int identity(1,1) primary key,
IdNivel int foreign  key references Nivel(Id),
DetalleCriterio nvarchar(1000),
Estatus bit
)

create table CriterioEmpresa(
Id int identity(1,1) primary key,
IdCriterio int foreign  key references Criterio(Id),
IdEmpresa int foreign  key references DatosEmpresa(id),
SeCumple bit,
Comentario nvarchar(1000),
NoConseguido decimal(18,2),
Parcialmente decimal(18,2),
ParteConseguido decimal(18,2),
Totalidad decimal(18,2),
Estatus bit
)