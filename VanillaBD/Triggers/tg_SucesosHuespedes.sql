--============================================================================================
-- Triggers para insertar sucesos de la tabla Huespedes --
--============================================================================================
use VanillaBD;
--Trigger para Insertar Huesped
 
create TRIGGER tg_InsertarHuesped
    ON Huespedes
    AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombres varchar(10), @apellidos varchar(50), @direccion varchar(100), 
	@telefono varchar(20), @correo varchar(30), @estado varchar(20);

	SELECT @id = i.idHuesped,
	@nombres = i.nombres,
	@apellidos = i.apellidos,
	@direccion = i.direccion,
	@telefono = i.telefono,
	@correo = i.correo,
	@estado = a.nombreEstado
	FROM inserted i
	inner join Estados a
	on i.idEstado_FK = a.idEstado

	INSERT INTO Suceso VALUES(GETDATE(), 'Huespedes', 'Se ha Insertado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombres: ' +@nombres+ 
	', Apellidos: ' +@apellidos+
	', Direccion: ' +@direccion+
	', Telefono: ' +@telefono+
	', Correo: ' +@correo+
	' y Estado: ' +@estado);
END
GO

--Trigger para Actualizar Huesped
 
create TRIGGER tg_ActualizarHuesped
    ON Huespedes
    AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombres varchar(10), @apellidos varchar(50), @direccion varchar(100), 
	@telefono varchar(20), @correo varchar(30), @estado varchar(20);

	SELECT @id = i.idHuesped,
	@nombres = i.nombres,
	@apellidos = i.apellidos,
	@direccion = i.direccion,
	@telefono = i.telefono,
	@correo = i.correo,
	@estado = a.nombreEstado
	FROM inserted i
	inner join Estados a
	on i.idEstado_FK = a.idEstado

	INSERT INTO Suceso VALUES(GETDATE(), 'Huespedes', 'Se ha Actualizado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombres: ' +@nombres+ 
	', Apellidos: ' +@apellidos+
	', Direccion: ' +@direccion+
	', Telefono: ' +@telefono+
	', Correo: ' +@correo+
	' y Estado: ' +@estado);
END
GO
 
--Trigger para Eliminar Huesped
 
create TRIGGER tg_EliminarHuesped
    ON Huespedes
    AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombres varchar(10), @apellidos varchar(50), @direccion varchar(100), 
	@telefono varchar(20), @correo varchar(30), @estado varchar(20);

	SELECT @id = i.idHuesped	,
	@nombres = i.nombres,
	@apellidos = i.apellidos,
	@direccion = i.direccion,
	@telefono = i.telefono,
	@correo = i.correo,
	@estado = a.nombreEstado
	FROM deleted i
	inner join Estados a
	on i.idEstado_FK = a.idEstado

	INSERT INTO Suceso VALUES(GETDATE(), 'Huespedes', 'Se ha Eliminado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombres: ' +@nombres+ 
	', Apellidos: ' +@apellidos+
	', Direccion: ' +@direccion+
	', Telefono: ' +@telefono+
	', Correo: ' +@correo+
	' y Estado: ' +@estado);
END