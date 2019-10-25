using System;

namespace Padrao_ISO_8601
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("200-08-15T13:05:58Z");


            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
