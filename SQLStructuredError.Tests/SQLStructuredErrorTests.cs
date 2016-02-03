using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SQLStructuredError.Tests
{
    [TestClass()]
    public class SQLStructuredErrorTests : SqlDatabaseTestClass
    {

        public SQLStructuredErrorTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_SplitStringTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLStructuredErrorTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_ErrorConvertToStringTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition13;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_ErrorLookupTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_BeginAuditLogProcEntryTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_EndAuditLogEntryTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_ErrorHandlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_MaintenanceUpdatesTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition15;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition16;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StructuredError_ErrorConvertToXMLTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition14;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition5;
            this.StructuredError_SplitStringTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StructuredError_ErrorConvertToStringTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StructuredError_ErrorLookupTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StructuredError_BeginAuditLogProcEntryTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StructuredError_EndAuditLogEntryTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StructuredError_ErrorHandlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StructuredError_MaintenanceUpdatesTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StructuredError_ErrorConvertToXMLTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            StructuredError_SplitStringTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            emptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            emptyResultSetCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            emptyResultSetCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            StructuredError_ErrorConvertToStringTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition13 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            StructuredError_ErrorLookupTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            StructuredError_BeginAuditLogProcEntryTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            StructuredError_EndAuditLogEntryTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StructuredError_ErrorHandlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StructuredError_MaintenanceUpdatesTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition15 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition16 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            StructuredError_ErrorConvertToXMLTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition14 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            // 
            // StructuredError_SplitStringTest_TestAction
            // 
            StructuredError_SplitStringTest_TestAction.Conditions.Add(emptyResultSetCondition1);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(emptyResultSetCondition2);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(emptyResultSetCondition3);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(emptyResultSetCondition4);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(rowCountCondition1);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(rowCountCondition2);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(emptyResultSetCondition5);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(rowCountCondition3);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(rowCountCondition4);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(emptyResultSetCondition6);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(rowCountCondition5);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(rowCountCondition6);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(rowCountCondition7);
            StructuredError_SplitStringTest_TestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(StructuredError_SplitStringTest_TestAction, "StructuredError_SplitStringTest_TestAction");
            // 
            // emptyResultSetCondition1
            // 
            emptyResultSetCondition1.Enabled = true;
            emptyResultSetCondition1.Name = "emptyResultSetCondition1";
            emptyResultSetCondition1.ResultSet = 1;
            // 
            // emptyResultSetCondition2
            // 
            emptyResultSetCondition2.Enabled = true;
            emptyResultSetCondition2.Name = "emptyResultSetCondition2";
            emptyResultSetCondition2.ResultSet = 2;
            // 
            // emptyResultSetCondition3
            // 
            emptyResultSetCondition3.Enabled = true;
            emptyResultSetCondition3.Name = "emptyResultSetCondition3";
            emptyResultSetCondition3.ResultSet = 3;
            // 
            // emptyResultSetCondition4
            // 
            emptyResultSetCondition4.Enabled = true;
            emptyResultSetCondition4.Name = "emptyResultSetCondition4";
            emptyResultSetCondition4.ResultSet = 3;
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 4;
            rowCountCondition1.RowCount = 1;
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 5;
            rowCountCondition2.RowCount = 1;
            // 
            // emptyResultSetCondition5
            // 
            emptyResultSetCondition5.Enabled = true;
            emptyResultSetCondition5.Name = "emptyResultSetCondition5";
            emptyResultSetCondition5.ResultSet = 6;
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 7;
            rowCountCondition3.RowCount = 1;
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 8;
            rowCountCondition4.RowCount = 1;
            // 
            // emptyResultSetCondition6
            // 
            emptyResultSetCondition6.Enabled = true;
            emptyResultSetCondition6.Name = "emptyResultSetCondition6";
            emptyResultSetCondition6.ResultSet = 9;
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 10;
            rowCountCondition5.RowCount = 1;
            // 
            // rowCountCondition6
            // 
            rowCountCondition6.Enabled = true;
            rowCountCondition6.Name = "rowCountCondition6";
            rowCountCondition6.ResultSet = 11;
            rowCountCondition6.RowCount = 1;
            // 
            // rowCountCondition7
            // 
            rowCountCondition7.Enabled = true;
            rowCountCondition7.Name = "rowCountCondition7";
            rowCountCondition7.ResultSet = 12;
            rowCountCondition7.RowCount = 4;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "-138619099";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // StructuredError_ErrorConvertToStringTest_TestAction
            // 
            StructuredError_ErrorConvertToStringTest_TestAction.Conditions.Add(rowCountCondition13);
            StructuredError_ErrorConvertToStringTest_TestAction.Conditions.Add(checksumCondition4);
            resources.ApplyResources(StructuredError_ErrorConvertToStringTest_TestAction, "StructuredError_ErrorConvertToStringTest_TestAction");
            // 
            // rowCountCondition13
            // 
            rowCountCondition13.Enabled = true;
            rowCountCondition13.Name = "rowCountCondition13";
            rowCountCondition13.ResultSet = 1;
            rowCountCondition13.RowCount = 2;
            // 
            // checksumCondition4
            // 
            checksumCondition4.Checksum = "340935587";
            checksumCondition4.Enabled = true;
            checksumCondition4.Name = "checksumCondition4";
            // 
            // StructuredError_ErrorLookupTest_TestAction
            // 
            StructuredError_ErrorLookupTest_TestAction.Conditions.Add(rowCountCondition10);
            StructuredError_ErrorLookupTest_TestAction.Conditions.Add(checksumCondition2);
            resources.ApplyResources(StructuredError_ErrorLookupTest_TestAction, "StructuredError_ErrorLookupTest_TestAction");
            // 
            // rowCountCondition10
            // 
            rowCountCondition10.Enabled = true;
            rowCountCondition10.Name = "rowCountCondition10";
            rowCountCondition10.ResultSet = 1;
            rowCountCondition10.RowCount = 2;
            // 
            // checksumCondition2
            // 
            checksumCondition2.Checksum = "-736518073";
            checksumCondition2.Enabled = true;
            checksumCondition2.Name = "checksumCondition2";
            // 
            // StructuredError_BeginAuditLogProcEntryTest_TestAction
            // 
            StructuredError_BeginAuditLogProcEntryTest_TestAction.Conditions.Add(rowCountCondition8);
            StructuredError_BeginAuditLogProcEntryTest_TestAction.Conditions.Add(checksumCondition3);
            resources.ApplyResources(StructuredError_BeginAuditLogProcEntryTest_TestAction, "StructuredError_BeginAuditLogProcEntryTest_TestAction");
            // 
            // rowCountCondition8
            // 
            rowCountCondition8.Enabled = true;
            rowCountCondition8.Name = "rowCountCondition8";
            rowCountCondition8.ResultSet = 1;
            rowCountCondition8.RowCount = 1;
            // 
            // checksumCondition3
            // 
            checksumCondition3.Checksum = "-909019958";
            checksumCondition3.Enabled = true;
            checksumCondition3.Name = "checksumCondition3";
            // 
            // StructuredError_EndAuditLogEntryTest_TestAction
            // 
            StructuredError_EndAuditLogEntryTest_TestAction.Conditions.Add(rowCountCondition11);
            StructuredError_EndAuditLogEntryTest_TestAction.Conditions.Add(rowCountCondition12);
            resources.ApplyResources(StructuredError_EndAuditLogEntryTest_TestAction, "StructuredError_EndAuditLogEntryTest_TestAction");
            // 
            // rowCountCondition11
            // 
            rowCountCondition11.Enabled = true;
            rowCountCondition11.Name = "rowCountCondition11";
            rowCountCondition11.ResultSet = 1;
            rowCountCondition11.RowCount = 1;
            // 
            // rowCountCondition12
            // 
            rowCountCondition12.Enabled = true;
            rowCountCondition12.Name = "rowCountCondition12";
            rowCountCondition12.ResultSet = 1;
            rowCountCondition12.RowCount = 1;
            // 
            // StructuredError_ErrorHandlerTest_TestAction
            // 
            StructuredError_ErrorHandlerTest_TestAction.Conditions.Add(rowCountCondition9);
            resources.ApplyResources(StructuredError_ErrorHandlerTest_TestAction, "StructuredError_ErrorHandlerTest_TestAction");
            // 
            // rowCountCondition9
            // 
            rowCountCondition9.Enabled = true;
            rowCountCondition9.Name = "rowCountCondition9";
            rowCountCondition9.ResultSet = 1;
            rowCountCondition9.RowCount = 1;
            // 
            // StructuredError_MaintenanceUpdatesTest_TestAction
            // 
            StructuredError_MaintenanceUpdatesTest_TestAction.Conditions.Add(rowCountCondition15);
            StructuredError_MaintenanceUpdatesTest_TestAction.Conditions.Add(rowCountCondition16);
            StructuredError_MaintenanceUpdatesTest_TestAction.Conditions.Add(checksumCondition6);
            resources.ApplyResources(StructuredError_MaintenanceUpdatesTest_TestAction, "StructuredError_MaintenanceUpdatesTest_TestAction");
            // 
            // rowCountCondition15
            // 
            rowCountCondition15.Enabled = true;
            rowCountCondition15.Name = "rowCountCondition15";
            rowCountCondition15.ResultSet = 1;
            rowCountCondition15.RowCount = 0;
            // 
            // rowCountCondition16
            // 
            rowCountCondition16.Enabled = true;
            rowCountCondition16.Name = "rowCountCondition16";
            rowCountCondition16.ResultSet = 2;
            rowCountCondition16.RowCount = 1;
            // 
            // checksumCondition6
            // 
            checksumCondition6.Checksum = "-108243850";
            checksumCondition6.Enabled = true;
            checksumCondition6.Name = "checksumCondition6";
            // 
            // StructuredError_ErrorConvertToXMLTest_TestAction
            // 
            StructuredError_ErrorConvertToXMLTest_TestAction.Conditions.Add(rowCountCondition14);
            StructuredError_ErrorConvertToXMLTest_TestAction.Conditions.Add(checksumCondition5);
            resources.ApplyResources(StructuredError_ErrorConvertToXMLTest_TestAction, "StructuredError_ErrorConvertToXMLTest_TestAction");
            // 
            // rowCountCondition14
            // 
            rowCountCondition14.Enabled = true;
            rowCountCondition14.Name = "rowCountCondition14";
            rowCountCondition14.ResultSet = 1;
            rowCountCondition14.RowCount = 2;
            // 
            // checksumCondition5
            // 
            checksumCondition5.Checksum = "18519681";
            checksumCondition5.Enabled = true;
            checksumCondition5.Name = "checksumCondition5";
            // 
            // StructuredError_SplitStringTestData
            // 
            this.StructuredError_SplitStringTestData.PosttestAction = null;
            this.StructuredError_SplitStringTestData.PretestAction = null;
            this.StructuredError_SplitStringTestData.TestAction = StructuredError_SplitStringTest_TestAction;
            // 
            // StructuredError_ErrorConvertToStringTestData
            // 
            this.StructuredError_ErrorConvertToStringTestData.PosttestAction = null;
            this.StructuredError_ErrorConvertToStringTestData.PretestAction = null;
            this.StructuredError_ErrorConvertToStringTestData.TestAction = StructuredError_ErrorConvertToStringTest_TestAction;
            // 
            // StructuredError_ErrorLookupTestData
            // 
            this.StructuredError_ErrorLookupTestData.PosttestAction = null;
            this.StructuredError_ErrorLookupTestData.PretestAction = null;
            this.StructuredError_ErrorLookupTestData.TestAction = StructuredError_ErrorLookupTest_TestAction;
            // 
            // StructuredError_BeginAuditLogProcEntryTestData
            // 
            this.StructuredError_BeginAuditLogProcEntryTestData.PosttestAction = null;
            this.StructuredError_BeginAuditLogProcEntryTestData.PretestAction = null;
            this.StructuredError_BeginAuditLogProcEntryTestData.TestAction = StructuredError_BeginAuditLogProcEntryTest_TestAction;
            // 
            // StructuredError_EndAuditLogEntryTestData
            // 
            this.StructuredError_EndAuditLogEntryTestData.PosttestAction = null;
            this.StructuredError_EndAuditLogEntryTestData.PretestAction = null;
            this.StructuredError_EndAuditLogEntryTestData.TestAction = StructuredError_EndAuditLogEntryTest_TestAction;
            // 
            // StructuredError_ErrorHandlerTestData
            // 
            this.StructuredError_ErrorHandlerTestData.PosttestAction = null;
            this.StructuredError_ErrorHandlerTestData.PretestAction = null;
            this.StructuredError_ErrorHandlerTestData.TestAction = StructuredError_ErrorHandlerTest_TestAction;
            // 
            // StructuredError_MaintenanceUpdatesTestData
            // 
            this.StructuredError_MaintenanceUpdatesTestData.PosttestAction = null;
            this.StructuredError_MaintenanceUpdatesTestData.PretestAction = null;
            this.StructuredError_MaintenanceUpdatesTestData.TestAction = StructuredError_MaintenanceUpdatesTest_TestAction;
            // 
            // StructuredError_ErrorConvertToXMLTestData
            // 
            this.StructuredError_ErrorConvertToXMLTestData.PosttestAction = null;
            this.StructuredError_ErrorConvertToXMLTestData.PretestAction = null;
            this.StructuredError_ErrorConvertToXMLTestData.TestAction = StructuredError_ErrorConvertToXMLTest_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void StructuredError_SplitStringTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_SplitStringTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void StructuredError_ErrorConvertToStringTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_ErrorConvertToStringTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void StructuredError_ErrorLookupTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_ErrorLookupTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void StructuredError_BeginAuditLogProcEntryTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_BeginAuditLogProcEntryTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void StructuredError_EndAuditLogEntryTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_EndAuditLogEntryTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void StructuredError_ErrorHandlerTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_ErrorHandlerTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void StructuredError_MaintenanceUpdatesTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_MaintenanceUpdatesTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void StructuredError_ErrorConvertToXMLTest()
        {
            SqlDatabaseTestActions testActions = this.StructuredError_ErrorConvertToXMLTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }


        private SqlDatabaseTestActions StructuredError_SplitStringTestData;
        private SqlDatabaseTestActions StructuredError_ErrorConvertToStringTestData;
        private SqlDatabaseTestActions StructuredError_ErrorLookupTestData;
        private SqlDatabaseTestActions StructuredError_BeginAuditLogProcEntryTestData;
        private SqlDatabaseTestActions StructuredError_EndAuditLogEntryTestData;
        private SqlDatabaseTestActions StructuredError_ErrorHandlerTestData;
        private SqlDatabaseTestActions StructuredError_MaintenanceUpdatesTestData;
        private SqlDatabaseTestActions StructuredError_ErrorConvertToXMLTestData;
    }
}
