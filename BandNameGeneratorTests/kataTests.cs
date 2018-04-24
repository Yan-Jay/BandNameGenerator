using Microsoft.VisualStudio.TestTools.UnitTesting;
using BandNameGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandNameGenerator;

namespace BandNameGenerator.Tests
{
    [TestClass]
    public class kataTests
    {
        [TestMethod]
        public void BandNameGeneratorTest()
        {
            var test = new kata();
            var input = "knife";
            var actural = test.BandNameGenerator(input);
            var expect = "The Knife";
            Assert.AreEqual(actural,expect);
        }
        [TestMethod]
        public void BandNameGeneratorTest2()
        {
            var test = new kata();
            var input = "tart";
            var actural = test.BandNameGenerator(input);
            var expect = "Tartart";
            Assert.AreEqual(actural,expect);
        }
        [TestMethod]
        public void BandNameGeneratorTest3()
        {
            var test = new kata();
            var input = "sandles";
            var actural = test.BandNameGenerator(input);
            var expect = "Sandlesandles";
            Assert.AreEqual(actural, expect);
        }
        [TestMethod]
        public void BandNameGeneratorTest4()
        {
            var test = new kata();
            var input = "bed";
            var actural = test.BandNameGenerator(input);
            var expect = "The Bed";
            Assert.AreEqual(actural, expect);
        }
    }
}