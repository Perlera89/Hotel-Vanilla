--======================================================================================
-- Procedimientos almacenados para Usuarios
--======================================================================================

-- Procedimiento para mostrar Usuarios
Create PROC sp_MostrarUsuarios
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Usuarios;
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarUsuarios
go
-------------------------------------------------------------------------------------------------

--Procedimiento para insertar Usuario
CREATE PROC sp_InsertarUsuario
@nombre varchar (20),
@correo varchar(30),
@clave varchar(20)

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Usuarios VALUES(@nombre, @correo, @clave)
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarUsuario 'master123', 'masterito@gmail.com', 'creeper_18';
go
-------------------------------------------------------------------------------------------------

--Procedimiento para eliminar Usuario
CREATE PROC sp_EliminarUsuario
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Usuarios WHERE idUsuario = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarUsuario 4
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar Usuario
CREATE PROC sp_ActualizarUsuario
@id int,
@nombre varchar (20),
@correo varchar(30),
@clave varchar(20)

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Usuarios SET 
	nombre = @nombre, correo = @correo, clave = @clave
	WHERE idUsuario = @id
END
go
-------------------------------------------------------------------------------------------------
select * from Habitaciones
--Prueba
EXEC sp_ActualizarUsuario 4, 'master1234', 'masterito@gmail.com', 'creeper_18';

-------------------------------------------------------------------------------------------------
--Procedimiento para comprobar datos de usuario

CREATE PROC sp_ComprobarDatos
@correo varchar(255),
@clave varchar(50)

AS
BEGIN
	SET NOCOUNT ON;
	exec dbo.fn_ComprobarDatos @correo, @clave
END
go

-------------------------------------------------------------------
--Función para comprobar los datos del usuario
drop Function fn_ComprobarDatos
Create Function fn_ComprobarDatos(
	@correo varchar(255), @clave varchar(50)
)
returns varchar(50)
as
begin

declare @nombre varchar(50)

Select @nombre = (select nombre from Usuarios where correo = @correo and clave = @clave)

return @nombre
end
go

declare @prueba varchar(50)
dbo.fn_ComprobarDatos('gris231@gmail.com', '123')
select prueba = dbo.fn_ComprobarDatos('gris231@gmail.com', '123')

exec sp_ComprobarDatos 'gris231@gmail.com', '123' 

select * from Usuarios