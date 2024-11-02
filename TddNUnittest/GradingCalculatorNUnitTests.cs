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
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator Gcalc;

        [SetUp]
        public void Setup() {
            Gcalc = new GradingCalculator();
        }

        [Test]
        public void ProvideScoreAttendance_GetCorrectGrade_95_90()
        {
            Gcalc.Score = 95;
            Gcalc.AttendancePercentage = 90;

            string result = Gcalc.GetGrade();

            Assert.That(result, Is.EqualTo("A"));
        }
        [Test]
        public void ProvideScoreAttendance_GetCorrectGrade_85_90()
        {
            Gcalc.Score = 85;
            Gcalc.AttendancePercentage = 90;

            string result = Gcalc.GetGrade();

            Assert.That(result, Is.EqualTo("B"));
        }
        [Test]
        public void ProvideScoreAttendance_GetCorrectGrade_65_90()
        {
            Gcalc.Score = 65;
            Gcalc.AttendancePercentage = 90;

            string result = Gcalc.GetGrade();

            Assert.That(result, Is.EqualTo("C"));
        }
        [Test]
        public void ProvideScoreAttendance_GetCorrectGrade_95_65()
        {
            Gcalc.Score = 95;
            Gcalc.AttendancePercentage = 65;

            string result = Gcalc.GetGrade();

            Assert.That(result, Is.EqualTo("B"));
        }
        [Test]
        [TestCase(95,55)]
        [TestCase(65, 55)]
        [TestCase(50, 90)]
        public void ProvideScoreAttendance_GetCorrectGrade_MultiCombined(int score, int attendance)
        {
            Gcalc.Score = score;
            Gcalc.AttendancePercentage = attendance;

            string result = Gcalc.GetGrade();

            Assert.That(result, Is.EqualTo("F"));
        }

        [Test]
        [TestCase(95, 55, ExpectedResult ="F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]
        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(95, 65, ExpectedResult = "B")]
        public string ProvideScoreAttendance_GetCorrectGrade_AllTestCasesCombined(int score, int attendance)
        {
            Gcalc.Score = score;
            Gcalc.AttendancePercentage = attendance;

           return Gcalc.GetGrade();

        }
    }
}
