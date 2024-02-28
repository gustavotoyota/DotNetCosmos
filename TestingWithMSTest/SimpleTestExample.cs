namespace TestingWithMSTest
{
    [TestClass] // Marks a class as containing unit tests.
    public class SimpleTestExample
    {
        [ClassInitialize] // Method to be called once before any tests are run in the test class
        public static void ClassInitialize(TestContext context)
        {
        }

        [ClassCleanup] // Method to be called once after all tests in the test class have run
        public static void ClassCleanup()
        {
        }

        [TestInitialize] // Method to be called before each test is run
        public void TestInitialize()
        {
        }

        [TestCleanup] // Method to be called after each test is run
        public void TestCleanup()
        {
        }

        [TestMethod] // Marks a method as a unit test
        public void TestMethod()
        {
        }
    }
}