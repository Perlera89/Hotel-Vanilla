--======================================================================================
-- Procedimientos almacenados para Estados
--======================================================================================

-- Procedimiento para mostrar Estados
Create PROC sp_MostrarEstados
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Estados;
END
go
------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_MostrarEstados
go
-------------------------------------------------------------------------------------------------

--Procedimiento para insertar Estado
CREATE PROC sp_InsertarEstado
@nombre varchar (50)

AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Estados VALUES(@nombre)
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_InsertarEstado 'Embarazado';
go
-------------------------------------------------------------------------------------------------

--Procedimiento para eliminar Estado
CREATE PROC sp_EliminarEstado
@id int

AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Estados WHERE idEstado = @id
END
go
-------------------------------------------------------------------------------------------------

--Prueba
EXEC sp_EliminarEstado 7
go
-------------------------------------------------------------------------------------------------

--Procedimiento de Actualizar Estado
CREATE PROC sp_ActualizarEstado
@id int,
@nombre varchar (50)

AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Estados SET 
	nombreEstado = @nombre
	WHERE idEstado = @id
END
go
-------------------------------------------------------------------------------------------------
--Prueba
EXEC sp_ActualizarEstado 4, 'Vencida';