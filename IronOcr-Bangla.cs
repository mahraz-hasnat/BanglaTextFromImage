using IronOcr;

namespace iron
{
    internal class IronBangla
    {
        static void Main(string[] args)
        {
            var Ocr = new IronTesseract();
            Ocr.Language = OcrLanguage.BenglaiBest;

            using (var Input = new OcrInput(@"C:\Users\hp\Desktop\IronOcr\mixed.png")) // path to image
            {
                var Result = Ocr.Read(Input);
                Result.SaveAsTextFile(@"C:\Users\hp\Desktop\IronOcr\mixed.txt"); // output path to save the txt file
                //var AllText = Result.Text;
                
            }
        }
    }
}
