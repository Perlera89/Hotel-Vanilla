--============================================================================================
-- Triggers para insertar sucesos de la tabla Usuarios --
--============================================================================================
use VanillaBD;
--Trigger para Insertar Usuarios
 
create TRIGGER tg_InsertarUsuario
    ON Usuarios
    AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombre varchar(20), @correo varchar(30), @clave varchar(20);

	SELECT @id = i.idUsuario,
	@nombre = i.nombre,
	@correo = i.correo,
	@clave = i.clave

	FROM inserted i

	INSERT INTO Suceso VALUES(GETDATE(), 'Usuarios', 'Se ha Insertado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombre: ' +@nombre+ 
	', Correo: ' +@correo+
	' y Clave: ' +@clave);
END
GO

--Trigger para Actualizar Usuario
 
create TRIGGER tg_ActualizarUsuario
    ON Usuarios
    AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombre varchar(20), @correo varchar(30), @clave varchar(20);

	SELECT @id = i.idUsuario,
	@nombre = i.nombre,
	@correo = i.correo,
	@clave = i.clave

	FROM inserted i

	INSERT INTO Suceso VALUES(GETDATE(), 'Usuarios', 'Se ha Actualizado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombre: ' +@nombre+ 
	', Correo: ' +@correo+
	' y Clave: ' +@clave);
END
GO
 
--Trigger para Eliminar Usuario
 
create TRIGGER tg_EliminarUsuario
    ON Usuarios
    AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @id int, @nombre varchar(20), @correo varchar(30), @clave varchar(20);

	SELECT @id = i.idUsuario,
	@nombre = i.nombre,
	@correo = i.correo,
	@clave = i.clave

	FROM deleted i

	INSERT INTO Suceso VALUES(GETDATE(), 'Usuarios', 'Se ha Eliminado el registro con Id: ' + cast(@id as varchar)+ 
	', Nombre: ' +@nombre+ 
	', Correo: ' +@correo+
	' y Clave: ' +@clave);
END