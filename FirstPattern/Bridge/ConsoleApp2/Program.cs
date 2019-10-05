using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadingApp readingApp = new Windows10App(new NormalDisplay()) { Text = "Read this text" };
            readingApp.Display();

            ReadingApp readingAppon8 = new Windows8App(new NormalDisplay()) { Text = "Read this text" };
            readingAppon8.Display();

            ReadingApp readingAppR = new Windows10App(new ReverseDisplay()) { Text = "Read this text" };
            readingAppR.Display();

            ReadingApp readingAppon8R = new Windows8App(new ReverseDisplay()) { Text = "Read this text" };
            readingAppon8R.Display();

            Console.ReadKey();
        }
    }
}
