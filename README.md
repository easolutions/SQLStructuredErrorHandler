# SQL Server Structured Error Handling
Add rich reporting of exceptions to improve error reporting to users and diagnostics to development.
## Introduction
SQL features for report exceptions are very limiting; all that is really available is the single text string passed as an argument to the “RAISERROR” error statement.  As a developer I would very much like to include the information below, but require very little coding when reporting the error.

•	A unique error number to identify the error. This is required for application documentation, where a list of error message and some unique error number is commonly required.

•	A message that can be displayed to a general user of the application.

•	A specific message to a developer using the SQL code what the problem is.

•	Any relevant variable data or status information.

•	Name of the procedure reporting the error.

•	Trace back information of the procedure calls to the point of exception.
