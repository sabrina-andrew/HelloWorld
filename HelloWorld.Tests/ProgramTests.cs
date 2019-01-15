using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Hello_World_Test()
        {
            string message = "I am Sam";
            Console.WriteLine(message); // prints "I am Sam"
        }
    }
}
