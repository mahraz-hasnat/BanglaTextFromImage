using IronOcr;

namespace iron
{
    internal class IronBangla
    {
        static void Main(string[] args)
        {
            var Ocr = new IronTesseract();
            //Ocr.Language = OcrLanguage.;

            Ocr.Language = OcrLanguage.BengaliBest;
            Ocr.AddSecondaryLanguage(OcrLanguage.EnglishBest);

            using (var Input = new OcrInput(@"C:\Users\hp\Desktop\IronOcr\mixed.png"))
            {
                var Result = Ocr.Read(Input);
                Result.SaveAsTextFile(@"C:\Users\hp\Desktop\IronOcr\mixed.txt");
                //var AllText = Result.Text;
                
            }
        }
    }
}
