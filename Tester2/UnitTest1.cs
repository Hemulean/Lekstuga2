using System;
using Xunit;

namespace Tester2
{
    public class UnitTest1
    {
        [Fact] // visar att vi testar n�nting h�r, utan fact s� hittar inte compliatorn testet.
        public void Test1()
        {
            //h�r kan vi testa kod
            
            Assert.NotEqual(4, 5);
            
            Assert.True(False);
        }
        [Fact]  
        public void Test2() 
        {
            Assert.Equal(4, 4);
            Assert.NotEqual(4,5);
            Assert.True(True);
            Assert.True(False);
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(3,3);
            Assert.NotEqual(2, -2);
            Assert.True(!True);
            Assert.True(True);
        }
    }
}
