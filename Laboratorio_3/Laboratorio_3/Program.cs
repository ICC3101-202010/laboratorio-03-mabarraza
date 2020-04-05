using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool control = true;
            Inventory inv = new Inventory();
            while (control) { 
                int[,] superprod_num = { { 1, 2 }, { 4, 5 }, { 7, 8 }, { 10, 11 }, { 13, 14 }, { 16, 17 } };
                string[,] superprod_st = { { "Aceite", "cd" }, { "Atun", "gh" }, { "Arroz", "kl" }, { "Azucar", "op" }, { "Fideos", "st" }, { "Papel Higienico", "wx" } };
                for (int i = 0; i < 6; i++)
                {
                    Product stockgen = new Product(superprod_st[i, 0], superprod_st[i, 1], superprod_num[i, 0], superprod_num[i, 1]);
                    inv.AddProduct(stockgen.Name, stockgen.Brand, stockgen.Price, stockgen.Price);
                }
                control = false;
            }
            foreach(Product k in inv.Lproducts)
            {
                Console.WriteLine(k.Name);
            }
        }
    }
}
