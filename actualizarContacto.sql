USE Agenda;

DROP PROCEDURE IF EXISTS dbo.ActualizarContacto;

GO

CREATE PROCEDURE dbo.ActualizarContacto
(
    @Id					INT,
    @Nombre				VARCHAR(100),
    @FechaNacimiento	DATE,
	@Telefono			VARCHAR(9),
	@Observaciones		VARCHAR(500)
)
AS
BEGIN;

	SET NOCOUNT ON;

    BEGIN TRANSACTION;

		BEGIN TRY

			UPDATE Contactos
			SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Observaciones = @Observaciones
			WHERE Id = @Id;

			COMMIT;

		END TRY
		BEGIN CATCH

			ROLLBACK;
			RAISERROR('Error updating contact. Transaction rolled back.', 16, 1);

		END CATCH;
END;
