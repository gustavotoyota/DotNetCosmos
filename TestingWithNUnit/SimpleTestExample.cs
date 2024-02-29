namespace TestingWithNUnit
{
    /*
     * TestFixture: Marks a class that contains tests
     * 
     * Beginning with NUnit 2.5, it is optional for non-parameterized, non-generic fixtures
     * So long as the class contains at least one method marked with the Test, TestCase or TestCaseSource attribute, it will be treated as a test fixture.
     */

    [TestFixture]
    public class Tests
    {
        /*
         * Note: [TestFixtureSetUp] and [TestFixtureTearDown] have been deprecated
         * in favor of [OneTimeSetUp] and [OneTimeTearDown] respectively
         */

        /*
         * OneTimeSetUp: Method to be called once before any tests are run in the test class
         */

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        /*
         * OneTimeTearDown: Method to be called once after all tests in the test class have run
         */

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }

        /*
         * SetUp: Method to be called before each test is run
         */

        [SetUp]
        public void SetUp()
        {
        }

        /*
         * TearDown: Method to be called after each test is run
         * 
         * Guaranteed to be called, even if an exception is thrown
         */

        [TearDown]
        public void TearDown()
        {
        }

        /*
         * Test: Marks a method as a test case, callable from the NUnit test runner
         */

        [Test]
        public void Test()
        {
            Assert.Pass();
        }
    }
}