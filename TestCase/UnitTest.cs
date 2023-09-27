
using BlackBoxTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase(2, -4, 2.0)] // Phương trình có nghiệm duy nhất
        [TestCase(1, 0, 0)]// Phương trình có nghiệm duy nhất x = 0
        [TestCase(0, 4, double.NegativeInfinity)] // Phương trình vô nghiệm
        [TestCase(0, 0, double.PositiveInfinity)] // Phương trình có vô số nghiệm


        [TestCase(double.NegativeInfinity, 4, 0.0)] // Trường hợp 1: a tiến đến âm vô cùng
        [TestCase(-0.01, 4, 400.0)] // Trường hợp 2: a tiến đến giá trị âm nhỏ
        [TestCase(0.0, 4, double.NegativeInfinity)] // Trường hợp 3: a bằng 0
        [TestCase(0.01, 4, -400.0)] // Trường hợp 4: a tiến đến giá trị dương nhỏ
        [TestCase(double.PositiveInfinity, 4, -0.0)] // Trường hợp 5: a tiến đến dương vô cùng


        [TestCase(2, double.NegativeInfinity, double.PositiveInfinity)] // Trường hợp 6: b tiến đến âm vô cùng
        [TestCase(2, -0.01, 0.005)] // Trường hợp 7: b tiến đến giá trị âm nhỏ
        [TestCase(2, 0.0, 0.0)] // Trường hợp 8: b bằng 0
        [TestCase(2, 0.01, -0.005)] // Trường hợp 9: b tiến đến giá trị dương nhỏ
        [TestCase(2, double.PositiveInfinity, double.NegativeInfinity)] // Trường hợp 10: b tiến đến dương vô cùng

        public void TestSolve(double a, double b, double expected)
        {
            double result = Equation.Solve(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}
