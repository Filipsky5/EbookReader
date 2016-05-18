using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EbookReader;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestItCanReadAPDF()
        {
            EbookReader.PDFReader r = new EbookReader.PDFReader();
            StringAssert.Contains(r.read(), "pdf book");
        }
    }
}
