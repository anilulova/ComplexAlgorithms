using NUnit.Framework;
using NUnitTestProject1;

namespace NUnitTestProject2
{
    [TestFixture]

    public class Tests
    {
        MergeTwoWords merge;

        [SetUp]
        public void Setup()
        {
            merge = new MergeTwoWords();
        }

        [Test]
        public void Test1()
        {
            string a = "Ani";
            string b = "Bani";

            var result = merge.MergeTwo(a, b);

            Assert.IsNotNull(result);
        }
    }
}