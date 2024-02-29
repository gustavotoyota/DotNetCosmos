namespace TestingWithMSTest
{
    /*
     * TestClass: Marks a class as containing unit tests
     */

    [TestClass]
    public class SimpleTestExample
    {
        /*
         * ClassInitialize: Method to be called once before any tests are run in the test class
         */

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
        }

        /*
         * ClassCleanup: Method to be called once after all tests in the test class have run
         */

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        /*
         * TestInitialize: Method to be called before each test is run
         */

        [TestInitialize]
        public void TestInitialize()
        {
        }

        /*
         * TestCleanup: Method to be called after each test is run
         */

        [TestCleanup]
        public void TestCleanup()
        {
        }

        /*
         * TestMethod: Marks a method as a unit test
         */

        [TestMethod]
        public void TestMethod()
        {
        }
    }
}