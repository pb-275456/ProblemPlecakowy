using ProblemPlecakowy;

namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMinOneValidOption()
        {
            Problem problem = new Problem(10, 1);
            int capacity = 10;
            int maxValue = 10;
            var validItemsCount = problem.items.Count(i => i.weight <= capacity && i.weight > 0 && i.value <= maxValue && i.value > 0);

            var result = problem.Solve(capacity);

            Assert.IsTrue(validItemsCount > 0);
            if(validItemsCount > 0)
                Assert.IsTrue(result.ids.Count > 0);
        }

        [TestMethod]
        public void TestNoValidOption()
        {
            Problem problem = new Problem(10, 2);
            int capacity = 0;
            int maxValue = 10;
            var validItemsCount = problem.items.Count(i => i.weight <= capacity && i.weight > 0 && i.value <= maxValue && i.value > 0);

            var result = problem.Solve(capacity);

            Assert.IsFalse(validItemsCount > 0);
            if (validItemsCount == 0)
                Assert.AreEqual(0, result.ids.Count);
        }

        [TestMethod]
        public void TestCorrectSolution()
        {
            Problem problem = new Problem(10, 3);
            int capacity = 20;
            Result expectedResult = new Result();
            expectedResult.ids = [6, 1, 2, 4, 9];
            expectedResult.value = 32;
            expectedResult.weight = 14;

            var result = problem.Solve(capacity);
            expectedResult.ids.Sort();
            result.ids.Sort();


            CollectionAssert.AreEqual(expectedResult.ids, result.ids);
            Assert.AreEqual(expectedResult.value, result.value);
            Assert.AreEqual(expectedResult.weight, result.weight);
        }

        [TestMethod]
        public void Test3()
        {

        }

        [TestMethod]
        public void Test2()
        {

        }
    }
}

