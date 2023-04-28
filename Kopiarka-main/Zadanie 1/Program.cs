namespace Zadanie_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*var xerox = new Copier();
            xerox.PowerOn();
            IDocument doc1 = new PDFDocument("aaa.pdf");
            xerox.Print(in doc1);

            IDocument doc2;
            xerox.Scan(out doc2, IDocument.FormatType.PDF);

            xerox.ScanAndPrint();
            System.Console.WriteLine(xerox.Counter);
            System.Console.WriteLine(xerox.PrintCounter);
            System.Console.WriteLine(xerox.ScanCounter);*/


            var copier = new Copier();
            copier.PowerOn();
            Console.WriteLine(copier.GetState());

            IDocument doc1 = new PDFDocument("aaa.pdf");
            copier.Print(in doc1);
        }
    }
}