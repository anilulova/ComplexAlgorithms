using NUnit.Framework;
using OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    [TestFixture]
    
    public class MathFunctionTest
    {
        DivideTwoNumbers math;
        [SetUp]

        public void SetUp()
        {
            math = new DivideTwoNumbers();
        }

        [TearDown]
        public void TearDown()
        {
            math = null;
        }

        [OneTimeSetUp]

        public void OneTimeSetUp()
        {

        }

        [OneTimeTearDown]

        public void OneTimeTearDown()
        {

        }

        [Test]
        public void DivideTwoNumbers()
        {
            int a = 21;
            int b = 3;

            var result = math.DivideTwo(a, b);

            Assert.IsTrue(result == 7);


        }
    }
}
