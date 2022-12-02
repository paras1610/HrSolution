using static System.Net.Mime.MediaTypeNames;

namespace OCR_Implementation.Models
{
    public class StringManager
    {
        public string GenerateString(string test)
        {
            if (test.Contains("\n"))
            {
                test = test.Replace("\n", " ");

                Console.WriteLine("\n" + test);
            }

        
            while (test.Contains("  ") || test.Contains("\r") || test.Contains("\t"))
            {
                test = test.Replace("  ", " ");
                test = test.Replace("\r", " ");
                test = test.Replace("\t", " ");
            }

            return test;
        }



    }
}
