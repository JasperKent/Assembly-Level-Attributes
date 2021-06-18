using AssemblyAttributes;
using Xunit;

namespace UnitTests
{
    public class MyTests
    {
        [Fact]
        public void FirstTest()
        {
            var publicClass = new PublicClass();

            var internalClass = new InternalClass();

            publicClass.SomeFunc(internalClass);
        }
    }
}
