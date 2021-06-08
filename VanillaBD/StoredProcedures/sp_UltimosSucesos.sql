CREATE PROC sp_UltimoSucesos

AS
BEGIN
	SELECT top 20 * from Suceso
	order by idSuceso desc;
END