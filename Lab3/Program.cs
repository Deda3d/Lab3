using System;
using System.IO;
using System.Text.Json;

namespace Lab3
{
    class Numbers
    {
        public int a { get; set; }
        public int b { get; set; }

        public Numbers() { }

        public Numbers(int x, int y)
        {
            a = x;
            b = y;
        }

        public void Sum()
        {
            Console.WriteLine("a + b = " + (a + b));
        }

        public void Print()
        {
            Console.Write("a = " + a + ", ");
            Console.WriteLine("b = " + b);
        }

        public void Max()
        {
            Console.Write("Найбiльше значення: ");
            if (a > b) Console.WriteLine(a);
            else Console.WriteLine(b);
        }

        public void Change(int x, int y)
        {
            a = x;
            b = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\kokok\OneDrive\Рабочий стол\lab3.json";
            string jsontext = File.ReadAllText(path);

            void Save(object o)
            {
                File.WriteAllText(path, JsonSerializer.Serialize(o));
            }
            Numbers Load()
            {
                return JsonSerializer.Deserialize<Numbers>(jsontext);
            }

            Numbers num = new Numbers(1, 2);
            num.Print();
            num.Sum();
            num.Max();
            num.Change(3, 4);
            num.Print();
            num.Sum();
            num.Max();
            num.Print();
            Save(num);
            num = Load();
            Console.WriteLine();
            num.Print();
            num.Sum();
        }
    }
}
