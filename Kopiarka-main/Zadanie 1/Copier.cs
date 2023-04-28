using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    public class Copier : BaseDevice, IPrinter, IScanner
    {
        public int PrintCounter { get; private set; } = 0;
        public int ScanCounter { get; private set; } = 0;
        
        public void Print(in IDocument document)
        {
            Copier copier = this;
            if (copier.state == IDevice.State.on)
            {
                PrintCounter++;
                Console.WriteLine($"{DateTime.Now} Print: {document}.pdf");
            }
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.JPG)
        {
            document = null;

            Copier copier = this;

            if (copier.state == IDevice.State.on)
            {
                if (formatType == IDocument.FormatType.JPG)
                {
                    Console.WriteLine($"{DateTime.Now} Scan: ImageScan{ScanCounter}.jpg");
                }

                if (formatType == IDocument.FormatType.TXT)
                {
                    Console.WriteLine($"{DateTime.Now} Scan: TextScan{ScanCounter}.txt");
                }

                if (formatType == IDocument.FormatType.PDF)
                {
                    Console.WriteLine($"{DateTime.Now} Scan: PDFScan{ScanCounter}.pdf");
                }

                ScanCounter++;
            }
        }

        public void ScanAndPrint()
        {
            Copier copier = this;

            if (copier.state == IDevice.State.on)
            {

                IDocument document = null;
                Scan(out document, IDocument.FormatType.JPG);

                Console.WriteLine($"{DateTime.Now} Print: {document}.jpg");
                PrintCounter++;
            }
        }
    }
}
