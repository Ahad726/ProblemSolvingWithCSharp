using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using static ProblemSolving.LeetCode.LinkedList;

namespace ProblemSolving.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class LinkedLisTest
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
            var node8 = new ListNode(8);
            var node7 = new ListNode(7,node8);
            var node6 = new ListNode(6,node7);
            var node5 = new ListNode(5,node6);
            var node4 = new ListNode(4,node5);
            var node3 = new ListNode(3,node4);
            var node2 = new ListNode(2,node3);
            var node1 = new ListNode(1,node2);
            
        }

        [TearDown]
        public void TestCleanUp()
        {

        }

        [Test]
        public void HasCycle_Test()
        {

        }
    }
}
