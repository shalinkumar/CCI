using CCIConsoleApp.ArraysandString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var chapters = new Question[] { new IsUnique() };

            foreach(var chapter in chapters)
            {
                //foreach(Question q in chapter)
                //{
                //    chapter.na
                //}
                Console.WriteLine("\n\n");
                Console.WriteLine($"//Executing: {chapter.Name}");
                Console.WriteLine("//-------------------       -----------------");

                chapter.Run();
            }
        }
    }
}
