using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5,2+3);
        }

        [Fact]
        public void Test3()
        {
            int bigNumber = 2147483647;
            int biggerNumber = bigNumber + 1;
            Assert.True(biggerNumber > bigNumber);
        }

        [Fact]
        public void Test2()
        {
            Assert.True("Jag har fyllt " + 29 == "Jag har fyllt 29");
        }

        [Fact]
        public void drink()
        {
            string purchasedDrink;
            int age = 28;

            if (age > 18)
            {
                purchasedDrink = "Beer";
            }
            else
            {
                purchasedDrink = "Coca-cola";
            }

            Assert.Equal("Beer",purchasedDrink);
            
                
            
        }

        [Fact]
        public void lengthRestriction()
        {
            int height = 160;
            int age = 15;

            if (height >= 160 && age >= 15)
            {
                bool legalAgeAndHeight = true;
            }


            Assert.True(age >= 15);

        }
    }
}
