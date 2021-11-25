using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Computer Academy Step";
            int lastSpace = str.LastIndexOf(" ");
            string str1 = str.Substring(lastSpace);

            str = str.Substring(0, lastSpace);
            lastSpace = str.LastIndexOf(" ");

            string str2 = str.Substring(lastSpace);

            str = str.Substring(0, lastSpace);

            string str3 = str.Substring(0);

            Console.WriteLine(str1 + " " + str2 + " " + str3);
                                                                               //КАК ДОБАВЛЯТЬ ВСЕ ПРОЕКТЫ В ОДИН РЕПАЗИТОРИЙ????
            if (str1.Length > str2.Length && str1.Length > str3.Length)        //КАК ДОБАВЛЯТЬ ВСЕ ПРОЕКТЫ В ОДИН РЕПАЗИТОРИЙ????
            {                                                                   //КАК ДОБАВЛЯТЬ ВСЕ ПРОЕКТЫ В ОДИН РЕПАЗИТОРИЙ????
                Console.WriteLine(str1);
                if (str2.Length > str3.Length) 
                Console.WriteLine(str2);
                else 
                Console.WriteLine(str3);
            }
            if (str2.Length > str1.Length && str2.Length > str3.Length)
            {
                Console.WriteLine(str2);
                if (str1.Length > str3.Length)
                    Console.WriteLine(str1);
                else
                    Console.WriteLine(str3);
            }
            if (str3.Length > str1.Length && str3.Length > str2.Length)
            {
                Console.WriteLine(str3);
                if (str1.Length > str2.Length)
                    Console.WriteLine(str1);
                else
                    Console.WriteLine(str2);
            }
        }
    }
}
