CREATE SCHEMA [StructuredError]
    AUTHORIZATION [dbo]
;
GO

EXECUTE sp_addextendedproperty
    @name = N'MS_Description',
    @value = N'Contains the objects that provide SQL Structured Error services.',
    @level0type = N'SCHEMA',
    @level0name = N'StructuredError'
;
GO
