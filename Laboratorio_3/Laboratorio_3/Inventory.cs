using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    public class Inventory
    {
        public List<Product> Lproducts = new List<Product>();
        public Inventory()
        {
        }
        public void AddProduct(Product inventario) {
            Lproducts.Add(inventario);
        }
        public void showstock(List<Product>st_ock) {
            foreach(Product s in st_ock)
            {
                Console.WriteLine("Nombre del producto:{0}", s.Name);
                Console.WriteLine("Marca del producto:{0}", s.Brand);
                Console.WriteLine("Stock del producto:{0}", s.Stock);
            }
        }
    }
}
