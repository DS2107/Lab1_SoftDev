using System;
using NUnit.Framework;
using Lab1_Stru_IVT_7_V8;

namespace Lab_1_Test
{
    [TestFixture]
    public class ArrayProcessorTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 5, 9, 10 }, new int[] { 1, 2, 5, 9, 10 })]
      
        public void TestPosition(int[] expectedResult, int[] obtainedResult)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(expectedResult, arrayProcessor.SortAndFilter(obtainedResult));
        }
            

        [Test]
        [TestCase(new int[] { 1001, 5000 }, new int[] { 1001, 5000, -5000, 23, 32 })]
        public void Removing_excess(int[] expectedResult, int[] obtainedResult)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(expectedResult, arrayProcessor.CreateNewArray(obtainedResult));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 5, 9, 10 }, new int[] { 1, 2, 9, 5, 10 })]

        public void SortTest(int[] expectedResult, int[] obtainedResult)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(expectedResult, arrayProcessor.SortArray(obtainedResult));
        }

    }
}
