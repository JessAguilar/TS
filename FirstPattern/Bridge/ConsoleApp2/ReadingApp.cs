using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class ReadingApp
    {
        protected IDisplayFormatter displayformatter;
        public ReadingApp(IDisplayFormatter displayformatter)
        {
            this.displayformatter = displayformatter;
        }

        public string Text { get; set; }
        public abstract void Display();
    }

    public class Windows8App : ReadingApp
    {
        public Windows8App(IDisplayFormatter displayFormatter) : base(displayFormatter)
        {
        }

        public override void Display()
        {
            displayformatter.Display("This is for Windows8\n" + Text);
        }
    }

    public class Windows10App : ReadingApp
    {
        public Windows10App(IDisplayFormatter displayFormatter) : base(displayFormatter)
        {
        }

        public override void Display()
        {
            displayformatter.Display("This is for Windows10\n" + Text);
        }
    }

    public interface IDisplayFormatter
    {
        void Display(string text);
    }

    public class NormalDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class ReverseDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine(new String(text.Reverse().ToArray()));
        }
    }
}
