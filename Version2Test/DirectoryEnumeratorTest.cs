using Version2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Version2Test
{
    
    
    /// <summary>
    ///This is a test class for DirectoryEnumeratorTest and is intended
    ///to contain all DirectoryEnumeratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DirectoryEnumeratorTest
    {


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
            string working_dir = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
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
        ///A test for Current
        ///</summary>
        [TestMethod()]
        public void CurrentTest()
        {
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            DirectoryEnumerator target = new DirectoryEnumerator(di); // TODO: Initialize to an appropriate value
            Node actual;
            actual = target.Current;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        [TestMethod()]
        public void ResetTest()
        {
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            DirectoryEnumerator target = new DirectoryEnumerator(di); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MoveNext
        ///</summary>
        [TestMethod()]
        public void MoveNextTest()
        {
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            DirectoryEnumerator target = new DirectoryEnumerator(di); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveNext();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DirectoryEnumerator Constructor
        ///</summary>
        [TestMethod()]
        public void DirectoryEnumeratorConstructorTest1()
        {
            DirectoryInfo di = new DirectoryInfo("C:\\test");
            DirectoryEnumerator target = new DirectoryEnumerator(di);
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for DirectoryEnumerator Constructor
        ///</summary>
        [TestMethod()]
        public void DirectoryEnumeratorConstructorTest()
        {
            DirectoryInfo di = new DirectoryInfo("C:\\test");
            Node node = new Node(null, di);
            DirectoryEnumerator target = new DirectoryEnumerator(node);
            Assert.IsNotNull(target);
        }
    }
}
