using net_gui_mysql_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DBMTest
{
    

    /// <summary>
    ///This is a test class for DBMgrTest and is intended
    ///to contain all DBMgrTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DBMgrTest
    {
        public static string pw;

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            PWForm pw_form = new PWForm();
            pw_form.ShowDialog();
            pw = pw_form.pw;
        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            pw = "";
        }
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for searchForValue
        ///</summary>
        [TestMethod()]
        public void searchForValueTest()
        {
            DBMgr target = new DBMgr(); // TODO: Initialize to an appropriate value
            string Name = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.searchForValue(Name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Finalize
        ///</summary>
        [TestMethod()]
        [DeploymentItem("net_gui_mysql_demo.exe")]
        public void FinalizeTest()
        {
            DBMgr_Accessor target = new DBMgr_Accessor(); // TODO: Initialize to an appropriate value
            target.Finalize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for editEntry
        ///</summary>
        [TestMethod()]
        public void editEntryTest()
        {
            DBMgr target = new DBMgr(); // TODO: Initialize to an appropriate value
            int key = 0; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.editEntry(key, name, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for deleteEntry
        ///</summary>
        [TestMethod()]
        public void deleteEntryTest()
        {
            DBMgr target = new DBMgr(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.deleteEntry(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for databaseConnect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("net_gui_mysql_demo.exe")]
        public void databaseConnectTest()
        {
            DBMgr_Accessor target = new DBMgr_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.databaseConnect();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for addEntry
        ///</summary>
        [TestMethod()]
        public void addEntryTest()
        {
            DBMgr target = new DBMgr(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.addEntry(name, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DBMgr Constructor
        ///</summary>
        [TestMethod()]
        public void DBMgrConstructorTest()
        {
            DBMgr target = new DBMgr();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
