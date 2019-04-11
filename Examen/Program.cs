using System;
using System.IO;
using System.Xml.Serialization;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Добро пожаловать в программу");
            Console.WriteLine("Нажмите клавишу пробел для добавления продукта");
            var keyinfo = Console.ReadKey();

            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                //Console.Write("CTL+");
                product.Action();
            }
            else
                Console.Write("Нажата неверная клавиша");

            XmlSerializer sr = new XmlSerializer(typeof(Product));
            string path = (@"C:\Prod.xml");

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                sr.Serialize(fs, product);
            }
        }
    }
}
