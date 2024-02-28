namespace TestingWithXUnit
{
    // xUnit creates a new instance of the test class for every test
    public class SimpleTestExample : IDisposable // Implement IDisposable to perform teardown
    {
        // Setup is performed in the constructor
        public SimpleTestExample()
        {
        }

        // Teardown is performed in the Dispose method
        public void Dispose()
        {
        }

        [Fact] // Marks a simple test method with no parameters
        public void Fact()
        {
        }
    }
}