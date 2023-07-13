using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Task1
{
    public static class FindAndReplaceManager
    {
      

        public static void FindNext(string str)
        {
            if (Book.Notes.text.Contains(str))
            {
                Console.WriteLine(str);
            }
        }
    }
    public class Book
    {
        public static class Notes
        {
            public static string text = "";
            public static string Text 
            { 
                get 
                { 
                    return text;
                } 
                set 
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                } 
            }
        }
    }
}
