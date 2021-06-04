--**********************************************************
-- Trigger para hacer calculos del control de total y check out en ManejoReservas
Create TRIGGER tg_ControlarReserva
   ON  ManejoReservas
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	Declare @id int, @tarifa money, @dias money, @adelantado money, @descuento money, @checkin date;

	select @id=i.idReserva,
	@tarifa = a.tarifa,
	@dias = i.numeroDias,
	@adelantado = i.pagoAdelantado,
	@descuento = i.descuento,
	@checkin = i.fechaCheckIn
	from inserted i
	inner join Habitaciones a on
	i.idHabitacion_FK = a.idHabitacion;

	EXEC sp_ControlReserva @id, @checkin, @tarifa, @dias, @adelantado, @descuento
END
GO

--*******************************************

CREATE Proc sp_ControlReserva
@id int,
@checkin date,
@tarifa money,
@dias int,
@adelantado money,
@descuento money

as
begin 
	SET NOCOUNT ON;
	Declare @checkout date;
	Declare @total money;

	Select @checkout = dbo.fn_CalcularCheckout(@checkin, @dias);
	Select @total = dbo.fn_CalcularTotal(@tarifa, @dias, @adelantado, @descuento);
	
	Update ManejoReservas set fechaCheckOut = @checkout, 
	total =  @total

	where idReserva = @id
end

Exec sp_ControlReserva 5, '2021-07-04', 25, 12, 200, 50
--*********************************

--------------------------------------------------------------------------------------------

-- Funcion para calcular total

CREATE FUNCTION fn_CalcularTotal
(
@tarifa money,
@dias int,
@adelantado money,
@descuento money
)
RETURNS money
AS
BEGIN
DECLARE @total money

SET @total = cast((@tarifa * @dias) - @adelantado - @descuento as money)

RETURN @total
END

select dbo.fn_CalcularTotal(25, 12, 200, 50)

--------------------------------------------------------------------------------------------

-- Funcion para calcular checkout
CREATE FUNCTION fn_CalcularCheckout
(
@checkin date,
@dias int
)
RETURNS date
AS
BEGIN
DECLARE @checkout date

SET @checkout = cast((SELECT DATEADD(DAY, @dias, @checkin)) as date)

RETURN @checkout
END

select dbo.fn_CalcularCheckout(GETDATE(), 10);