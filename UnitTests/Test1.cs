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
            Problem problem = new Problem(10, 1);
            int capacity = 0;
            int maxValue = 10;
            var validItemsCount = problem.items.Count(i => i.weight <= capacity && i.weight > 0 && i.value <= maxValue && i.value > 0);

            var result = problem.Solve(capacity);

            Assert.IsFalse(validItemsCount > 0);
            if (validItemsCount == 0)
                Assert.AreEqual(result.ids.Count, 0);
        }

        [TestMethod]
        public void TestCorrectSolution()
        {

        }
    }
}

