using System;

namespace Examen
{
    [Serializable]
    public class Product
    {
        public string Prod_name { get; set; }
        public string Manufact { get; set; }
        public int Prod_cnt { get; set; }

        public Product()
        {
            Prod_name = "";
            Manufact = "Unknow";
            Prod_cnt = 0;
        }
        public Product(string name, string Autor, int count)
        {
            Prod_name = name;
            Manufact = Autor;
            Prod_cnt = count;
        }

        public delegate void Add_product();
        public event Add_product Press_ctr;

        public void Action()
        {
            Console.WriteLine("Введите название продукта: ");
            Prod_name = Console.ReadLine();
            Console.WriteLine("Введите название производителя продукта: ");
            Manufact = Console.ReadLine();
            Console.WriteLine("Введите колличество продукта: ");
            Prod_cnt = int.Parse(Console.ReadLine());
            Show();
        }
        public void Show()
        {
            Console.WriteLine("Название продукта: " + Prod_name);
            Console.WriteLine("Производитель продукта: " + Manufact);
            Console.WriteLine("Колличество продукта: " + Prod_cnt);
        }
    }
}
