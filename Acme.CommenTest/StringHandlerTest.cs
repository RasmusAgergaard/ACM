using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommenTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "SoniceScrew";
            var expected = "Sonice Screw";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestValidWithExistingSpace()
        {
            var source = "Sonice Screw";
            var expected = "Sonice Screw";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
