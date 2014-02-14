using System;
using MySql.Data.Types;
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
        ///A test for addEntry
        ///</summary>
        [TestMethod()]
        public void addEntryTest()
        {
            DBMgr target = new DBMgr("root", pw);
            string name = "Null value saved";
            string value = null;
            bool expected = true;
            bool actual;
            actual = target.addEntry(name, value);
            Assert.AreEqual(expected, actual);

            name = "TestSearch";
            value = "TestValue";
            actual = target.addEntry(name, value);
            string msg = "key: " + target.last_key;
            Assert.AreEqual(expected, actual);
            Console.WriteLine(msg);

            target.selfDestruct();
        }

        /// <summary>
        ///A test for searchForValue
        ///</summary>
        [TestMethod()]
        public void searchForValueTest()
        {
            DBMgr target = new DBMgr("root",pw);

            // setup
            string name = "Null value saved";
            string value = null;
            target.addEntry(name, value);
            long key1 = target.last_key;
            string msg = "added key: " + target.last_key;
            Console.WriteLine(msg);

            name = "TestSearch";
            value = "TestValue";
            target.addEntry(name, value);
            long key2 = target.last_key;
            msg = "added key: " + target.last_key;
            Console.WriteLine(msg);

            //test
            string Name = "Null value saved";
            string expected = "";
            string actual;
            actual = target.searchForValue(Name);
            msg = "key: " + target.last_key;
            Assert.AreEqual(expected, actual,msg);
            Assert.AreEqual(key1,target.last_key);
            Console.WriteLine(msg);

            Name = "Not in datatbase";
            expected = null;
            actual = target.searchForValue(Name);
            msg = "key: " + target.last_key;
            Assert.AreEqual(expected, actual, msg);
            Console.WriteLine(msg);

            Name = "TestSearch";
            expected = "TestValue";
            actual = target.searchForValue(Name);
            msg = "key: " + target.last_key;
            Assert.AreEqual(expected, actual, msg);
            Assert.AreEqual(key2, target.last_key);
            Console.WriteLine(msg);

            target.selfDestruct();
        }

        /// <summary>
        ///A test for editEntry
        ///</summary>
        [TestMethod()]
        public void editEntryTest()
        {
            DBMgr target = new DBMgr("root", pw);
            // setup
            string name = "TestEdit";
            string value = "TestVal";
            target.addEntry(name, value);

            long key = target.insert_id_hook.LastInsertedId;

            name = "TestEdit";
            value = "editedValue";
            bool expected = true;
            bool actual;
            actual = target.editEntry(key, name, value);
            Assert.AreEqual(expected, actual);

            target.selfDestruct();
        }

        /// <summary>
        ///A test for deleteEntry
        ///</summary>
        [TestMethod()]
        public void deleteEntryTest()
        {
            DBMgr target = new DBMgr("root", pw);

            // setup
            string name = "TestDelete";
            string value = "TestVal";
            target.addEntry(name, value);
            
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
    }
}
