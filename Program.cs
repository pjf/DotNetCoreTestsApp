using System;
using Xunit;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sut = new SystemUnderTest();
            var hello = sut.HelloWorld();
            Console.WriteLine(hello);
        }
    }

    public class SystemUnderTest
    {
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }

    public class TestClass
    {
        [Fact]
        public void TestMethod()
        {
            var sut = new SystemUnderTest();
            Assert.Equal("Hello World!", sut.HelloWorld());
        }
    }
}
