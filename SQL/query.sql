SELECT SCHEMA_NAME(schema_id) As SchemaName 
      ,name As TableName 
   FROM sys.objects
   WHERE type = 'U'


SELECT Table_Name,Column_Name, Data_Type
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE Table_Name = 'Customer'

SELECT * FROM Customer