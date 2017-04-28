using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prediccion.Model;

namespace Prediccion.Tests
{
    [TestClass]
    public class WebParserTest
    {
        [TestMethod]
        public void Getelement_ElementHasContent_ContentOfElement()
        {
            WebParserResult result = WebParser.GetElementById("http://laboru.co/hello.tx");
            Assert.AreEqual(true, result.Status == WebParserResultStatus.Success);
        }

    }
}
