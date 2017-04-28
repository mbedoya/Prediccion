using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prediccion.Model;

namespace Prediccion.Tests
{
    [TestClass]
    public class WebDownloaderTest
    {
        [TestMethod]
        public void GetContent_ContentWasFound_HtmlHasContent()
        {
            WebDownloaderResult result  = WebDownloader.GetContent("http://laboru.co/hello.txt");
            Assert.AreEqual(true, !String.IsNullOrEmpty(result.HtmlContent));
        }
        
        [TestMethod]
        public void GetContent_ContentWasFound_ContentIsCorrect()
        {
            WebDownloaderResult result = WebDownloader.GetContent("http://laboru.co/hello.txt");
            Assert.AreEqual("hello", result.HtmlContent);
        }

        [TestMethod]
        public void GetContent_UrlIsNotFound_ResponseStatusIsUrlNotFound()
        {
            WebDownloaderResult result = WebDownloader.GetContent("http://laboru.co/hello.tx");
            Assert.AreEqual(true, result.Status == DownloadResultStatus.UrlNotFound);
        }
        
    }
}
