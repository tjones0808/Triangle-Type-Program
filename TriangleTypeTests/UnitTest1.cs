using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle_Type_Program;

namespace TriangleTypeTests
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
        }

        [TestMethod]
        public void IsScalene()
        {
            var result = Program.DetermineTriangleType(1, 2, 3);
            Assert.IsTrue(result.ToLower() == "scalene");
            result = Program.DetermineTriangleType(2, 1, 3);
            Assert.IsTrue(result.ToLower() == "scalene");
            result = Program.DetermineTriangleType(3,2,1);
            Assert.IsTrue(result.ToLower() == "scalene");
        }

        [TestMethod]
        public void IsEquilateral()
        {
            var result = Program.DetermineTriangleType(2, 2, 2);
            Assert.IsTrue(result.ToLower() == "equilateral");
        }

        [TestMethod]
        public void IsIsoceles()
        {
            var result = Program.DetermineTriangleType(2, 2, 3);
            Assert.IsTrue(result.ToLower() == "isosceles");
            result = Program.DetermineTriangleType(2, 3, 3);
            Assert.IsTrue(result.ToLower() == "isosceles");
            result = Program.DetermineTriangleType(2, 3, 2);
            Assert.IsTrue(result.ToLower() == "isosceles");
        }
    }
}
