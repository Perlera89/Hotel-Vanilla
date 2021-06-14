use VanillaBD;

--=======================
--METODO PARA CARGAR EL CB DE GESTION DE HABITACIONES
go
Create Proc sp_TipoHabitacion
as
	Select h.idTipoHabitacion, 
	h.tipo 'Tipodehabitacion'
	from TipoHabitaciones h
go

--=================================
--METODO PARA MOSTRAR LAS HABITACIONES
/****** Object:  StoredProcedure [dbo].[sp_MostrarHabitaciones]    Script Date: 9 jun. 2021 12:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_MostrarHabitaciones]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT a.idHabitacion,
			a.numeroHabitacion,
			a.tarifa,
			b.tipo 
	 FROM Habitaciones a inner join TipoHabitaciones b
			on a.idTipoHabitacion_FK=b.idTipoHabitacion;
END

--======================================

exec sp_TipoHabitacion
exec sp_MostrarHabitaciones

