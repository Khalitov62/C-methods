using System;

namespace C_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "bU tasKI metHodla yAzmAliSiz";
            sentence = sentence.Replace("bU tasKI metHodla yAzmAliSiz" ,"Bu Taski Methodla Yazmalisiniz");
            
            Console.WriteLine(sentence);
        }
    }
}
