USE Agenda;

DROP PROCEDURE IF EXISTS dbo.EliminarContacto;

GO

CREATE PROCEDURE dbo.EliminarContacto
(
    @Id					INT
)
AS
BEGIN;

	SET NOCOUNT ON;

    BEGIN TRANSACTION;

		BEGIN TRY

			DELETE FROM Contactos
			WHERE Id = @Id;

			COMMIT;

		END TRY
		BEGIN CATCH

			ROLLBACK;
			RAISERROR('Error deleting contact. Transaction rolled back.', 16, 1);

		END CATCH;
END;
