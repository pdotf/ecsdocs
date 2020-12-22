 
CREATE PROCEDURE dbo.Sp_UpdateCustomersComment
    @id int ,
    @COMMENT nvarchar(max)=NULL
AS
BEGIN
UPDATE EcsDocs.dbo.Customers 
			SET 
			Comment=@Comment
Where Id=@Id 
END
 