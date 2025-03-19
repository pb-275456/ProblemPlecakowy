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
            
            var result = problem.Solve(capacity);

            Assert.IsFalse(result.ids.Count == 0);
            Assert.IsTrue(result.value > 0);
            Assert.IsTrue(result.weight > 0);
        }

        [TestMethod]
        public void TestNoValidOption()
        {
            Problem problem = new Problem(3, 6);
            int capacity = 2;
            int maxValue = 10;
           
            var result = problem.Solve(capacity);

            Assert.IsTrue(result.ids.Count == 0);
            Assert.AreEqual(0, result.value);
            Assert.AreEqual(0, result.weight);
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


            CollectionAssert.AreEquivalent(expectedResult.ids, result.ids);
            Assert.AreEqual(expectedResult.value, result.value);
            Assert.AreEqual(expectedResult.weight, result.weight);
        }

        [TestMethod]
        public void TestCorrectInstance()
        {
            Problem problem = new Problem(20, 4);
            
            foreach(Item i in problem.items)
            {
                Assert.IsTrue(i.weight > 0 && i.weight <= 10);
                Assert.IsTrue(i.value > 0 && i.value <= 10);
            }
        }

        [TestMethod]
        public void TestEmptyProblem()
        {
            Problem problem = new Problem(0, 4);

            var result = problem.Solve(10);

            Assert.IsTrue(result.ids.Count == 0);
            Assert.AreEqual(0, result.weight);
            Assert.AreEqual(0, result.value);
        }
    }
}

