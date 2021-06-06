use VanillaBD
---------------------------------------------------------------------------------------
--Mostrar Huesped
go
create procedure sp_Mostrarhuesped
as 
begin
SET NOCOUNT ON;
Select * from Huespedes
	
end
GO
---------------------------------------------------------------------------------------
--Insertar Huesped
Create procedure sp_insertarHuesped
@nombres varchar(50),
@apellidos varchar(50),
@direccion varchar(255),
@telefono varchar(20),
@Correo varchar(100),
@idEstado_Fk int

as 
begin
set nocount on
insert into Huespedes values(@nombres,@apellidos,@direccion,@telefono,@Correo,@idEstado_Fk)
end
go
----------------------------------------------------------------------------------------
--Eliminar Huesped

create procedure sp_eliminarhuesped
@id int
as 
begin
	set nocount on;
	Delete from Huespedes where idHuesped = @id
end
go
---------------------------------------------------------------------------------------
--Procediminto de Actualizar Huesped
create procedure sp_actualizarHuesped
@idHuesped int,
@nombres varchar(50),
@apellidos varchar(50),
@direccion varchar(255),
@telefono varchar(20),
@idEstado_fk int
as 
begin
set nocount on;
update  Huespedes set
    nombres=@nombres, apellidos=@apellidos, direccion=@direccion,telefono=@telefono, idEstado_FK = @idEstado_fk
	where idHuesped=@idHuesped
end
go
