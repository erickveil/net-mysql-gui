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
            DBMgr target = new DBMgr("root",pw);
            string Name = "TestSearch"; // TODO: Insert the test value in the database before testing
            string expected = "TestValue";
            string actual;
            actual = target.searchForValue(Name);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Finalize
        ///</summary>
        [TestMethod()]
        [DeploymentItem("net_gui_mysql_demo.exe")]
        public void FinalizeTest()
        {
            DBMgr_Accessor target = new DBMgr_Accessor("root", pw);
            target.Finalize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for editEntry
        ///</summary>
        [TestMethod()]
        public void editEntryTest()
        {
            DBMgr target = new DBMgr("root", pw);
            int key = 0; // TODO: Insert the test value in the database before testing
            string name = "TestEdit";
            string value = "TestValue";
            bool expected = true;
            bool actual;
            actual = target.editEntry(key, name, value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for deleteEntry
        ///</summary>
        [TestMethod()]
        public void deleteEntryTest()
        {
            DBMgr target = new DBMgr("root", pw);
            string name = "TestDelete"; // TODO: Insert the test value in the database before testing
            bool expected = true;
            bool actual;
            actual = target.deleteEntry(name);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for databaseConnect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("net_gui_mysql_demo.exe")]
        public void databaseConnectTest()
        {
            DBMgr_Accessor target = new DBMgr_Accessor("root", pw);
            bool expected = true;
            bool actual;
            actual = target.databaseConnect();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for addEntry
        ///</summary>
        [TestMethod()]
        public void addEntryTest()
        {
            DBMgr target = new DBMgr("root", pw);
            string name = "TestAdd";
            string value = "TestValue";
            bool expected = true;
            bool actual;
            actual = target.addEntry(name, value);
            Assert.AreEqual(expected, actual); // TODO: clean up this add after the test
        }

        /// <summary>
        ///A test for DBMgr Constructor
        ///</summary>
        [TestMethod()]
        public void DBMgrConstructorTest()
        {
            DBMgr target = new DBMgr("root", pw);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
