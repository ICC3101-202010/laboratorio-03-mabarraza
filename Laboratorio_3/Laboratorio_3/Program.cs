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
            Customer Marce = new Customer(2000,"Marcela","Aranda","20381204-7","Chilean");
            while (control) { 
                int[,] superprod_num = { { 1, 2 }, { 4, 5 }, { 7, 8 }, { 10, 11 }, { 13, 14 }, { 16, 17 } };
                string[,] superprod_st = { { "Aceite", "cd" }, { "Atun", "gh" }, { "Arroz", "kl" }, { "Azucar", "op" }, { "Fideos", "st" }, { "Papel Higienico", "wx" } };
                for (int i = 0; i < 6; i++)
                {
                    Product stockgen = new Product(superprod_st[i, 0], superprod_st[i, 1], superprod_num[i, 0], superprod_num[i, 1]);
                    inv.AddProduct(stockgen.Name, stockgen.Brand, stockgen.Price, stockgen.Stock);
                }
                control = false;
            }
            foreach(Product k in inv.Lproducts)
            {
                Marce.AvailableStock(inv, k);
                Console.WriteLine(k.Stock);
            }
        }
    }
}
