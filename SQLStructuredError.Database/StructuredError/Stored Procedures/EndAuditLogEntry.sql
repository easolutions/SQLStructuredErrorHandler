CREATE PROCEDURE StructuredError.EndAuditLogEntry
        @AuditLogId             bigint
AS
/**********************************************************************************************************************************
    DESCRIPTON:
        End audit entry for a store procedure.

    AUTHOR:     Michael Erickson, Erickson and Associates.
    CREATED:    2016-01
    WEBSITE:    http://www.merickson.com/
    CONTACT:    support@merickson.com

    PARAMETERS:
        @AuditLogId                 Output identifier of audit log entry that was created.

    RETURN CODES:
        Always zero.

    NOTES:
        The caller should call "StructuredError.EndAuditLogEntry" or "StructuredError.ErrorHandler" when the procedure is done.

    EXAMPLE:
        See example in procedure "StructuredError.ErrorHandler".
**********************************************************************************************************************************/
SET NOCOUNT ON
;
BEGIN
    IF @AuditLogId IS NOT NULL
    BEGIN
        UPDATE  a
        SET     AuditEndTime = GETUTCDATE()
        FROM    StructuredError.AuditLog                    a
        WHERE   a.AuditLogId = @AuditLogId
        ;
    END

    RETURN 0;
END

