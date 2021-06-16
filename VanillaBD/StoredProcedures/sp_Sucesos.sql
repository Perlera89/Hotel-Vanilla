use VanillaBD
CREATE PROC sp_UltimoSucesos

AS
BEGIN
	SELECT top 20 * from Sucesos
	order by idSuceso desc;
END


Alter PROC sp_UltimoSuceso
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TOP 1 * FROM Sucesos
	ORDER BY idSuceso DESC
END

CREATE PROC sp_TodosSucesos

AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Sucesos;
END
