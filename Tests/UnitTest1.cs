using Lab1.Controllers;
using System;
using System.Linq;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var controller = new ValuesController();
            var values = controller.Get();

            Assert.Equal(2, values.Value.Count());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(0)]
        public void Test3(int id)
        {
            var controller = new ValuesController();
            var values = controller.Get(id);

            Assert.Equal($"Hello World! {id}", values.Value);
        }
    }
}
