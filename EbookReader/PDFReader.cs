using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookReader
{
    public class PDFReader
    {
        public PDFReader()
        {

        }
        public string read()
        {
            return new PDFBook().read();
        }
    }

    public class PDFBook
    {
        public string read()
        {
            return "reading a pdf book";
        }
    }
}
