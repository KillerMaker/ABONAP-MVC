CREATE OR ALTER PROCEDURE SP_GET_LOAN_AMOUNT
(
	@LOAN_CODE VARCHAR(30)
)AS
BEGIN
	SELECT
		P.MONTO,
		PS.NOMBRES
	FROM PRESTAMO P 
	INNER JOIN CLIENTE C ON C.ID_CLIENTE = P.ID_CLIENTE
	INNER JOIN PERSONA PS ON PS.ID_PERSONA = C.ID_PERSONA
	WHERE P.CODIGO = @LOAN_CODE;
END;

--EXEC SP_GET_LOAN_AMOUNT 'PRES00003';