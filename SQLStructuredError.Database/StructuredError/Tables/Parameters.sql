CREATE TABLE [StructuredError].[Parameters] (
    [ParameterName]        NVARCHAR (255) NOT NULL,
    [ParameterValue]       NVARCHAR (MAX) NULL,
    [ParameterDescription] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Parameters] PRIMARY KEY CLUSTERED ([ParameterName] ASC)
);

