using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tdd_new;

namespace TddNUnittest
{
    [TestFixture]
    public class FiboNUnitTests
    {
        private Fibo fibo;

        [SetUp]
        public void Setup()
        {
            fibo = new Fibo();
        }


        [Test]
        public void TestFibSeries_Range1()
        {
            fibo.Range = 1;
            List<int> result = fibo.GetFiboSeries();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Empty);
                Assert.That(result, Is.Ordered);
                Assert.That(result, Does.Contain(0));
            });

        }
        [Test]
        public void TestFibSeries_Range6()
        {
            fibo.Range = 6;
            List<int> result = fibo.GetFiboSeries();

            List<int> ExpectedRange = new List<int>() { 0, 1, 1, 2, 3, 5 };

            Assert.Multiple(() =>
            {
                Assert.That(result.Count, Is.EqualTo(6));
                Assert.That(result, Does.Not.Contain(4));
                Assert.That(result, Does.Contain(3));
                Assert.That(result, Is.EquivalentTo(ExpectedRange));
            });

        }
    }
}
