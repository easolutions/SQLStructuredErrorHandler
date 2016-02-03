CREATE TABLE [StructuredError].[AuditLog] (
    [AuditLogId]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [ProcedureName]  VARCHAR (255) NULL,
    [InputData]      XML           NULL,
    [OuputData]      XML           NULL,
    [ErrorMessage]   XML           NULL,
    [AuditStartTime] DATETIME2 (7) CONSTRAINT [DF_AuditLog_AuditTime] DEFAULT (getutcdate()) NOT NULL,
    [AuditEndTime]   DATETIME2 (7) NULL,
    CONSTRAINT [PK_AuditLog] PRIMARY KEY CLUSTERED ([AuditLogId] ASC)
);

