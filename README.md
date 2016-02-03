# SQL Server Structured Error Handling
Add rich reporting of exceptions to improve error reporting to users and diagnostics to development.
## Introduction
SQL features for report exceptions are very limiting; all that is really available is the single text string passed as an argument to the “RAISERROR” error statement.  As a developer I would very much like to include the information below, but require very little coding when reporting the error.

-	A unique error number to identify the error. This is required for application documentation, where a list of error message and some unique error number is commonly required.
-	A message that can be displayed to a general user of the application.
-	A specific message to a developer using the SQL code what the problem is.
-	Any relevant variable data or status information.
-	Name of the procedure reporting the error.
-	Trace back information of the procedure calls to the point of exception.

## Approach
SQL really only provides two basic tools for reporting and processing exceptions, “RAISERROR” to report exceptions and TRY-CATCH block for exception processing. “RAISERROR” is limited to a single 2047 character string, an ambiguous severity code between 0 and 18 and an even more ambiguous state code between 0 and 255.  When constructing the single line of text for “RAISERROR”, one has to be careful what is included in the message because many times it is displayed directly to the end user.  The “TRY-CATCH” block first introduced in SQL Server 2008, provides a very powerful tool to capture and consolidate exception handling, report the procedure and line where the exception occurred and manage trace back of procedure calls.

I propose the best approach is to construct an XML document containing the error information required and send the XML document as a string within the “RAISERROR” mechanism.  In my design, a typical basic error message looks like the following.

```
<E N="2021003" M="The Branch specified was not found"
               D="Specified branch id not found or deleted."
               P="ArticleIsDeletable" L="103">
   <T EntityId="15" EntityType="2"/>
</E>
```

This has all the rich information I need to send to the caller all in a structured format that can be easily captured by the caller, which can then extract the information as required. We find it is extremely useful when these XML documents appear in any diagnostic or log output. This XML document contains the following:

-	The unique error number as attribute “N”, i.e. “2021003”. This is a common need in the industry for unique error numbers with error messages to provide to customers.
-	A message to display to the user as attribute “M”.
-	A message to display to the developer as attribute “D”.
-	Name of the procedure and line number as attribute “P” and “L”.
-	Special token variable and status information in element “T”, where there is some data name “EntityId” and “EntityType” with the values of 15 and 2 respectively.
