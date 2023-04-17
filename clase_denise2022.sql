/*todo aqui*/
--PASO 1
---OJOOO FIJARSE QUE EN EL DESPLEGABE DE ARRIBA ESTE SELECICIONADA LA BACE DE DATOS "BDESCUELA" PARA CONFIRMAR DATOS
CREATE DATABASE BDESCUELA 

–--coloca la BD TURISMO en memoria para poder hacer modificaciones
---PASO 2
USE BDESCUELA
---PASO 3

CREATE TABLE MOD_MODULO
(MOD_ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
MOD_NOMBRE VARCHAR(255) NOT NULL,
MOD_CODIGO VARCHAR(255) NOT NULL,
MOD_ACTIVO BIT NOT NULL);

---LUEGO  QUE ESTE PASO 4

CREATE PROCEDURE InsertaModulo
@NombreModulo Varchar(255),
@Codigo Varchar(255),
@Activo Bit
AS
BEGIN
	INSERT INTO MOD_MODULO(MOD_NOMBRE,MOD_CODIGO,MOD_ACTIVO)
		   VALUES (@NombreModulo, @Codigo, @Activo)
END
---FIN PASO 4       FUNCIONAAAA

---OJO HICE EL PASO 5 PERO LUEGO CREE LAS SIGUIENTES TABLAS.XD


---PASO 5   EJECUTE ESTE 
create procedure ListaModulo    /*es para listar los modulos en el " combobox " */
as
begin
select 
MOD_ID,
mod_nombre+' '+mod_codigo as Nombre/*el AS es para darle otro nombre en este caso en ves de llamarlo 
                                     por mod_nombre y mod_codigo ;
                                     se llama por solo "Nombre"*/
from 
MOD_MODULO
where 
mod_activo=1;
end
--FIN PASO 5

--PASO 6 
CREATE TABLE MOD_LABORATORIO
(
lab_id int not null primary key identity (1,1) ,
lab_capacidad varchar(255),
lab_piso varchar(255),
lab_esinformatica bit,
)

select* from MOD_MODULO;
select*from MOD_LABORATORIO;
--FIN PASO 6


--PASO 7 
create procedure Listalaboratorio
as 
begin
select /*debe estar tal cual en el combo box*/
lab_id,
lab_capacidad,
lab_piso,
lab_esinformatica as Capasidad
from
MOD_LABORATORIO
where/*es la restricsion*/
lab_esinformatica=1;/*restriccion*/
end

--FIN PASO 7
--PASO 8 INSETA  LABORATORIO realizado
CREATE PROCEDURE InsertaLaboratorio
@CapasidadLaboratorio varchar(255),
@pisoLaboratorio Varchar(255),
@esinformatica Bit
AS
BEGIN
	INSERT INTO MOD_LABORATORIO(lab_capacidad,lab_piso,lab_esinformatica)
		   VALUES (@CapasidadLaboratorio, @pisoLaboratorio,@esinformatica)
END

--FIN PASO8
--funcionaaaaaaaa 

--------DESDE AQUI SOLO ESTAN LOS EJEMPLOS PARA GUIARSE.

---->>>>CODIGO COMPAÑERO<<<<<<---------
/*importante las claves primarias*/
                                                     /*ordenar todo*/
CREATE TABLE MOD_LABORATORIO
(
lab_id int not null primary key identity (1,1) ,
lab_capacidad varchar(255),
lab_piso varchar(255),
lab_esinformatica bit,
)

CREATE PROCEDURE INSERTAR_MODULO
@NombreModulo Varchar(255),
@Codigo Varchar(255),
@Activo bit
AS
BEGIN
INSERT
INTO
MOD_MODULO
(
mod_nombre,
mod_codigo,
mod_activo
)
VALUES
(
@NombreModulo,
@Codigo,
@Activo
)
END

exec INSERTAR_MODULO 'BACE DE DATOS','BD-0085',1
exec INSERTAR_MODULO 'NET','BD-0090',2

select*from MOD_MODULO
select*from MOD_LABORATORIO

--inserto un lavoratorio directamente
exec InsertaLaboratorio '23', 'Piso 1', 1
--fin 


exec InsertaModulo 'Base de Datos', 'BD-0085', 1
---AÑADIDO MIO TABLALABORATORIO

---FIN MIO
CREATE PROCEDURE InsertaModulo
@NombreModulo Varchar(255),
@Codigo Varchar(255),
@Activo Bit
AS
BEGIN
	INSERT INTO MOD_MODULO(MOD_NOMBRE,MOD_CODIGO,MOD_ACTIVO)
		   VALUES (@NombreModulo, @Codigo, @Activo)
END

exec InsertaModulo 'Base de Datos', 'BD-0085', 1



create procedure ListaModulo  
as
begin
select 
MOD_ID,
mod_nombre+' '+mod_codigo as Nombre
from 
MOD_MODULO
where 
mod_activo=1;
end
-----------------------AQUIIIIIIIII ESTOY
create procedure ListalaboratorioTodo
as 
begin
select
lab_id,
lab_capacidad+lab_piso+'',
lab_esinformatica as Capasidad
from
MOD_LABORATORIO
where
lab_esinformatica=1;
end

drop procedure ListaLaboratorioTodo;
---------AQUIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII ESTOY



---


select * from MOD_LABORATORIO;
select * from MOD_MODULO;


---lista los laboratorios clase 28 sep pasos profesora paso 1
create procedure ListaLaboratorioTodo
as
begin 
select 
lab_id,
lab_piso
from
MOD_LABORATORIO
end

----!!!!!!!!!!
drop procedure ListaLaboratorioTodo;
----!!!!!!!!!!!

--de lap profe
create procedure ListaLaboratorioTodo
as
begin 
select 
lab_id,
lab_piso
from
MOD_LABORATORIO
end
--paso 2
select*from MOD_LABORATORIO;
select* from MOD_MODULO;

CREATE PROCEDURE [dbo].[ListaEstudiante]
AS
BEGIN
   SELECT
       lab_id,
       lab_piso
   FROM
       MOD_LABORATORIO
END
--paso 2
select*from MOD_LABORATORIO;
select* from MOD_MODULO;

---carga laboratorio
create procedure CargalaboratorioTodo
@LaboratorioID int
as
begin 
select 
lab_id,
lab_piso
from
MOD_LABORATORIO
end

CREATE PROCEDURE CargaLaboratorioFormulario /*nos basamos solo en 1 aspecto en particular,un registro,
                                              no se actualiza todo de todo,
                                              solo una fila*/
@LaboratorioID int/*en este caso el ID*/
AS
BEGIN
   SELECT
      *
   FROM
       MOD_LABORATORIO
   WHERE
       lab_id=@LaboratorioID
END


/*-----------------------------*/
/*TAREA 03 OCT*/
CREATE PROCEDURE CargarModuloFormulario
@ModuloID int
AS
BEGIN
SELECT
*
FROM
MOD_MODULO
WHERE
MOD_ID=@ModuloID
END


/*FIN TAREA*/


select*from MOD_MODULO /*datos del form 1 Ingreso de modulo Funciona*/
select*from MOD_LABORATORIO

/*procedimiento almacenado clase 03 de octubre.*/
/*funcionaaaaa*/

/*CUANDO SE REALIZA LA TABLA="CargaLaboratorioFormulario" SE REALIZA EL ="ActualizarLaboratorio"   */

CREATE PROCEDURE ActualizarLaboratorio

@LaboratorioID int,/*EL ID ES MUY IMPORTANTE*/
@Capacidad Varchar(255),/*SE PASAN TODOS LOS DATOS , DEBIDO  A QUE PUEDE CAMBIAR 1 DATO O TODOS LOS DATOS*/
@Piso Varchar(255),
@esInformatica bit
AS
BEGIN
   UPDATE 
   MOD_LABORATORIO
     SET/*las columna que se actualizan*/
	 lab_capacidad=@Capacidad,
	 lab_piso=@Piso,
	 lab_esinformatica=@esInformatica
	 where /*la condicion siempre es requerido, siempre debe estar incluido.*/
	 lab_id=@LaboratorioID
	 end


	 /*fin 03/10*/
CREATE PROCEDURE ActualizarModulo
@mod_moduloId int,
@mod_nombre varchar(255),
@mod_codigo varchar(255),
@mod_Activo bit
AS
BEGIN
UPDATE
MOD_MODULO
SET
MOD_NOMBRE=@mod_nombre,
MOD_CODIGO=@mod_codigo,
MOD_ACTIVO=@mod_Activo
WHERE
MOD_ID=@mod_moduloId
end




SELECT * FROM MOD_MODULO

/*PROC PRA CARGAR EN LA GRILLA*/

CREATE PROCEDURE CARGAGRILLA
AS
BEGIN
SELECT
*
FROM
MOD_MODULO;
END







select*from MOD_LABORATORIO;