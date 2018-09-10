using Version2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections;

namespace Version2Test
{
    
    
    /// <summary>
    ///This is a test class for NodeTest and is intended
    ///to contain all NodeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NodeTest
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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
        ///A test for Parent
        ///</summary>
        [TestMethod()]
        public void ParentTest()
        {
            Node parent = null; // TODO: Initialize to an appropriate value
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            Node target = new Node(parent, di); // TODO: Initialize to an appropriate value
            Node expected = null; // TODO: Initialize to an appropriate value
            Node actual;
            target.Parent = expected;
            actual = target.Parent;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Info
        ///</summary>
        [TestMethod()]
        public void InfoTest()
        {
            Node parent = null; // TODO: Initialize to an appropriate value
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            Node target = new Node(parent, di); // TODO: Initialize to an appropriate value
            DirectoryInfo actual;
            actual = target.Info;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Children
        ///</summary>
        [TestMethod()]
        public void ChildrenTest()
        {
            Node parent = null; // TODO: Initialize to an appropriate value
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            Node target = new Node(parent, di); // TODO: Initialize to an appropriate value
            DirectoryInfo[] expected = null; // TODO: Initialize to an appropriate value
            DirectoryInfo[] actual;
            target.Children = expected;
            actual = target.Children;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NextChild
        ///</summary>
        [TestMethod()]
        public void NextChildTest()
        {
            Node parent = null; // TODO: Initialize to an appropriate value
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            Node target = new Node(parent, di); // TODO: Initialize to an appropriate value
            DirectoryInfo expected = null; // TODO: Initialize to an appropriate value
            DirectoryInfo actual;
            actual = target.NextChild();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        [TestMethod()]
        public void GetEnumeratorTest()
        {
            Node parent = null; // TODO: Initialize to an appropriate value
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            Node target = new Node(parent, di); // TODO: Initialize to an appropriate value
            IEnumerator expected = null; // TODO: Initialize to an appropriate value
            IEnumerator actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Node Constructor
        ///</summary>
        [TestMethod()]
        public void NodeConstructorTest()
        {
            Node parent = null; // TODO: Initialize to an appropriate value
            DirectoryInfo di = null; // TODO: Initialize to an appropriate value
            Node target = new Node(parent, di);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
