CREATE PROCEDURE SP_GET_HISTORICO_EQUIPOS
   @PV_CEDULA VARCHAR(50)


AS
BEGIN

SELECT F.NOMBRES, E.NOMBRE_EQUIPO, H.FECHA_INICIO, H.FECHA_FIN
FROM FUTBOLISTA AS F
INNER JOIN HISTORICO_EQUIPOS AS H ON H.CEDULA=F.CEDULA
INNER JOIN EQUIPOS AS E ON E.ID_EQUIPOS=H.ID_EQUIPO


WHERE F.CEDULA = @PV_CEDULA

END
GO