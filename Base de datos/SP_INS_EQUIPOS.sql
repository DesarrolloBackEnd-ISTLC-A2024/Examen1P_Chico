USE [Examen]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_INS_EQUIPOS]
   @PV_NOMBRE_EQUIPO VARCHAR (50),
   @PV_DESCRIPCION VARCHAR (50),
   @PV_NUMERO_JUGADORES VARCHAR (50),
   @PV_PAIS VARCHAR (50),
   @PV_FALTAS VARCHAR(50),
   @PV_CIUDAD VARCHAR(50),
   @PV_ESTADIO VARCHAR(50)

AS
	DECLARE @CONTADOR_ID INTEGER;
BEGIN
   



	SELECT @CONTADOR_ID=(NOMBRE_EQUIPO)
	FROM EQUIPOS;

	INSERT INTO EQUIPOS(NOMBRE_EQUIPO,DESCRIPCION,NUMERO_JUGADORES,PAIS,FALTAS,CIUDAD,ESTADIO)
	VALUES(@PV_NOMBRE_EQUIPO,@PV_DESCRIPCION,@PV_NUMERO_JUGADORES,@PV_PAIS,@PV_FALTAS,@PV_CIUDAD,@PV_ESTADIO);


END