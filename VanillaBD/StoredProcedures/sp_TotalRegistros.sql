-- Procedimiento para Mostrar total Habitaciones
Create PROC sp_TotalHabitaciones
AS
BEGIN
	SET NOCOUNT ON;
	SELECT count(idHabitacion) as 'Total Habitaciones' 
	FROM Habitaciones
END
go

Exec sp_TotalHabitaciones
go

-- Procedimiento para Mostrar total Huespedes
Create PROC sp_TotalHuespedes
AS
BEGIN
	SET NOCOUNT ON;
	SELECT count(idHuesped) as 'Total Huespedes' 
	FROM Huespedes
	WHERE idEstado_FK = 1
END
go

Exec sp_TotalHuespedes