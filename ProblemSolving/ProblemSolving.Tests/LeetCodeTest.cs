using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using ProblemSolving.LeetCode;

namespace ProblemSolving.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class LeetCodeTest
    {


        [OneTimeSetUp]
        public void ClassSetup()
        {
            
        }

        [OneTimeTearDown]
        public void ClassTearDown() 
        {
        
        }


        [SetUp]
        public void TestSetup()
        {
        }

        [TearDown]
        public void TestCleanup()
        {

        }

        [Test]
        public void SubsetXORSum_Test()
        {
            // Arrange
            int[] nums = { 5, 1, 6 };
            int total = 28;

            // Act
            var result = Leetcode.SubsetXORSum(nums);

            // Assert

            Assert.That(result,Is.EqualTo(total));
        }
    }
}