use VanillaBD
---------------------------------------------------------------------------------------
--Mostrar Huesped
go
Alter procedure sp_Mostrarhuesped
as 
begin
	SET NOCOUNT ON;
	Select a.idHuesped, a.nombres, a.apellidos, a.direccion, a.telefono, a.correo, b.nombreEstado from Huespedes a
	inner join Estados b on a.idEstado_FK = b.idEstado
end
GO
---------------------------------------------------------------------------------------
--Insertar Huesped
Alter procedure sp_InsertarHuesped
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

create procedure sp_Eliminarhuesped
@id int
as 
begin
	set nocount on;
	Delete from Huespedes where idHuesped = @id
end
go
---------------------------------------------------------------------------------------
--Procediminto de Actualizar Huesped
create procedure sp_ActualizarHuesped
@idHuesped int,
@nombres varchar(50),
@apellidos varchar(50),
@direccion varchar(255),
@telefono varchar(20),
@Correo varchar(100),
@idEstado_fk int
as 
begin
set nocount on;
update  Huespedes set
    nombres=@nombres, apellidos=@apellidos, direccion=@direccion,telefono=@telefono, idEstado_FK = @idEstado_fk
	where idHuesped=@idHuesped
end
go
