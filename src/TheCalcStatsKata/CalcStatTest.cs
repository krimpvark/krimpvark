// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_project.TheCalcStatsKata
{
    /// <summary>
    /// Calc Stat tests
    /// </summary>
    [TestFixture]
    [Category("The CalcStats Kata")]
    public class CalcStatTest
    {
       private static IList<int> List(params int[] numbers) => numbers.ToList();

        /// <summary>
        /// Determines whether this instance [can find minum value].
        /// </summary>
        [Test]
        public void CanFindMinumValue()
        {
            var number = CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Minimum);
            number.Should().NotBeNull();
            number.Should().BeOfType<string>();
            number.Should().Be("-2");

            Assert.That("-2", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Minimum)));
        }

        [Test]
        public void AreSumsEqual()
        {
            var numbers = CalcStat.AreSumsEqual(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11));
            numbers.Should().BeTrue();

            Assert.That("-2", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Minimum)));
            var expected = true;
            Assert.AreEqual(expected, numbers);
        }

        /// <summary>
        /// Determines whether this instance [can find maximum value].
        /// </summary>
        [Test]
        public void CanFindMaximumValue() => Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.ElementCount)));

        /// <summary>
        /// Determines whether this instance [can get element count].
        /// </summary>
        [Test]
        public void CanGetElementCount() => Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.ElementCount)));

        /// <summary>
        /// Determines whether this instance [can get average of series].
        /// </summary>
        [Test]
        public void CanGetAverageOfSeries() => Assert.That("13.1", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Average)));
               
    }
}