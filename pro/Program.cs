using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace pro
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = new string[] {"Müşterimiz","Değerli","fjdujhf"};
            var newArr = Add(arr, "UYARI");

            string b = pdfText(Directory.GetCurrentDirectory() + "/v.pdf");

            for (int i = 0; i < newArr.Length; i++)
            {
                string a = newArr[i];
                int sonuc;
                sonuc = b.IndexOf(a, 0, b.Length);
                if (sonuc == -1)
                {
                    Console.WriteLine("not found");
                }
                else
                {
                    Console.WriteLine("found from " + sonuc.ToString() + ". character");
                }
            }

        }

        public static string[] Add(string[] array, string newValue)
        {
            int newLength = array.Length + 1;

            string[] result = new string[newLength];

            for (int i = 0; i < array.Length; i++)
                result[i] = array[i];

            result[newLength - 1] = newValue;

            return result;
        }

        public static string pdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            var dd = reader.GetPageContent(1);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                text += PdfTextExtractor.GetTextFromPage(reader, page);

            }
            reader.Close();
            return text;
        }
        
    }
}
