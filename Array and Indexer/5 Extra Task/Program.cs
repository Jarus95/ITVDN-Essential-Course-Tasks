using System;

namespace _5_Extra_Task
{
    public class Dictionary
    {
        private string[] UaKey = new string[5];
        private string[] RuKey = new string[5];
        private string[] value = new string[5];

        public Dictionary()
        {
         UaKey[0] = "книга";       RuKey[0] = "книга";     value[0] = "book";
         UaKey[1] = "ручка";       RuKey[1] = "ручка";     value[1] = "pen";
         UaKey[2] = "олівець";     RuKey[2] = "карандаш";  value[2] = "pencil";
         UaKey[3] = "будинок";     RuKey[3] = "дом";       value[3] = "home";
         UaKey[4] = "ноутбук";     RuKey[4] = "ноутбук";   value[4] = "laptop";

        }

     

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < RuKey.Length; i++)
                {
                    if (RuKey[i] == index)
                        return "Ru: "+ RuKey[i] + " - " + value[i];

                    if (UaKey[i] == index)
                        return "UA:" + UaKey[i] + " - " + value[i];
                }
                return "notfound";
            }

        }

        public string this[int index]
        {
            get
            {

                if (index < 0 || index >= RuKey.Length)
                    return "IndexOutOfRange";

                return (UaKey[index] + "-" + RuKey[index] + " - " + value[index]);

            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["будинок"]);
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < 5; i++)
                Console.WriteLine(dictionary[i]);

            Console.ReadKey();
        }
    }
}


//Задание
//Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. Реализуйте возможность
//поиска не только по ключевым русским словам и словам на остальных языках