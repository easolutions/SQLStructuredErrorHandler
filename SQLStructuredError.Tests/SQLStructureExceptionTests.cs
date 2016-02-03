using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SQLStructureError.Support;

namespace SQLStructuredError.Tests
{
    /// <summary>
    /// Summary description for SQLStructureExceptionTests
    /// </summary>
    [TestClass]
    public class SQLStructureExceptionTests
    {
        public SQLStructureExceptionTests()
        {
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

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
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SQLStructureException_Normal()
        {
            string SqlMessage = @"
                    <E N='1003' M='System is currently busy, please try again later.'
                                D='Database deadlock error occurred. Special message to developer.'
                                P='ErrorHandler'>
                      <T CalledBy='ErrorHandler' ThrownBy='' ThrownLine='14' DB='SQLStructuredError.Tests' SPID='52' />
                      <T ErrorMessage='Special message to developer.' someValue1='1' someValue2='0' someValue3='&#xD;&#xA;' />
                      <E N='1002' M='Unable to perform this operation because there is another record with the same name at the same location.'
                                  D='Special message to developer.' P='ErrorHandler'>
                        <T CalledBy='ErrorHandler' ThrownBy='' ThrownLine='14' DB='SQLStructuredError.Tests' SPID='52' />
                        <T ErrorMessage='Special message to developer.' someValue1='1' someValue2='0' someValue3='&#xD;&#xA;' />
                        <E N='1002' M='Unable to perform this operation because there is another record with the same name at the same location.'
                                    D='Special message to developer.'
                                    P='ErrorHandler'>
                          <T CalledBy='ErrorHandler' ThrownBy='' ThrownLine='14' DB='SQLStructuredError.Tests' SPID='52' />
                          <T ErrorMessage='Special message to developer.' someValue1='1' someValue2='0' someValue3='&#xD;&#xA;' />
                        </E>
                        <E N='1000' M='Unknown error message &quot;UnknownError&quot; for procedure &quot;#ProcedueName#&quot; is not defined in the error table. '
                                    P='ErrorHandler'>
                          <T CalledBy='ErrorHandler' ThrownBy='' ThrownLine='14' DB='SQLStructuredError.Tests' SPID='52' />
                          <T ErrorMessage='Special message to developer.' someValue1='1' someValue2='0' someValue3='&#xD;&#xA;' />
                        </E>
                        <E N='1001' M='Unknown SQL Server error on server #ServerName# from database #DB#. Special message to developer.' P='ErrorHandler'>
                          <T CalledBy='ErrorHandler' ThrownBy='' ThrownLine='14' DB='SQLStructuredError.Tests' SPID='52' />
                          <T ErrorMessage='Special message to developer.' someValue1='1' someValue2='0' someValue3='&#xD;&#xA;' />
                        </E>
                      </E>
                      <E N='1000' M='Unknown error message &quot;UnknownError&quot; for procedure &quot;#ProcedueName#&quot; is not defined in the error table. '
                                  P='ErrorHandler'>
                        <T CalledBy='ErrorHandler' ThrownBy='' ThrownLine='14' DB='SQLStructuredError.Tests' SPID='52' />
                        <T ErrorMessage='Special message to developer.' someValue1='1' someValue2='0' someValue3='&#xD;&#xA;' />
                      </E>
                      <E N='1001' M='Unknown SQL Server error on server #ServerName# from database #DB#. Special message to developer.'
                                  P='ErrorHandler'>
                        <T CalledBy='ErrorHandler' ThrownBy='' ThrownLine='14' DB='SQLStructuredError.Tests' SPID='52' />
                        <T ErrorMessage='Special message to developer.' someValue1='1' someValue2='0' someValue3='&#xD;&#xA;' />
                      </E>
                    </E>";
            var sqlex = new Exception(SqlMessage);
            var sqlStrEx = new SqlStructureException(sqlex);
            Assert.AreEqual(@"System is currently busy, please try again later.", sqlStrEx.Message, @"Exception message should be set to message within structured error.");
            Assert.AreEqual(@"Database deadlock error occurred. Special message to developer.", sqlStrEx.DeveloperMessage, @"Developer message should be set to developer message within structured error.");

            sqlStrEx = new SqlStructureException(SqlMessage);
            Assert.AreEqual(@"System is currently busy, please try again later.", sqlStrEx.Message, @"Exception message should be set to message within structured error.");
            Assert.AreEqual(@"Database deadlock error occurred. Special message to developer.", sqlStrEx.DeveloperMessage, @"Developer message should be set to developer message within structured error.");

            sqlStrEx = new SqlStructureException(@"Test message.");
            Assert.AreEqual(@"Test message.", sqlStrEx.Message, @"Exception message should be set to message provided.");
            Assert.IsNull(sqlStrEx.DeveloperMessage, @"Developer message should be null.");
        }
    }
}
