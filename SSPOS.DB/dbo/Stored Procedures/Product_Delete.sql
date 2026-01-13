-- Modified Stored Procedure: Product_Delete
CREATE PROCEDURE [dbo].[Product_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM Product WHERE ID = @ID;

    RETURN @@ROWCOUNT;
END;
