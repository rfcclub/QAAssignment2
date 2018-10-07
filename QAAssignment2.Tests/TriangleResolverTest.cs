using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment2.Tests
{
    [TestFixture]
    public class TriangleResolverTest
    {
        [Test]
        public void Analyze_Input1And2And3_ReturnInvalid()
        {
            string result = TriangleResolver.Analyze(1, 3, 4);
            Assert.AreEqual("invalid", result);
        }

        /*[Test]
        public void Analyze_InputMinus3AndMinus4AndMinus5_ReturnInvalid()
        {
            string result = TriangleResolver.Analyze(-3, -4, -5);
            Assert.AreEqual("invalid", result);
        }

        [Test]
        public void Analyze_Input3And1And0_ReturnInvalid()
        {
            string result = TriangleResolver.Analyze(3, 1, 0);
            Assert.AreEqual("invalid", result);
        }

        [Test]
        public void Analyze_Input3And4And5_ReturnScalene()
        {
            string result = TriangleResolver.Analyze(3, 4, 5);
            Assert.AreEqual("scalene", result);
        }

        [Test]
        public void Analyze_Input3And3And4_ReturnIsosceles()
        {
            string result = TriangleResolver.Analyze(3, 3, 4);
            Assert.AreEqual("isosceles", result);
        }

        [Test]
        public void Analyze_Input4And3And3_ReturnIsosceles()
        {
            string result = TriangleResolver.Analyze(4, 3, 3);
            Assert.AreEqual("isosceles", result);
        }

        [Test]
        public void Analyze_Input3And4And3_ReturnIsosceles()
        {
            string result = TriangleResolver.Analyze(3, 4, 3);
            Assert.AreEqual("isosceles", result);
        }

        [Test]
        public void Analyze_Input4And4And4_ReturnEquilateral()
        {
            string result = TriangleResolver.Analyze(4, 4, 4);
            Assert.AreEqual("equilateral", result);
        }*/
    }
}
