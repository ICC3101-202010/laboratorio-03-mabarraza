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
        public void AddProduct(string nm, string br, int pr, int stk) {
            Product inventoryadd = new Product(nm, br, pr, stk);
            Lproducts.Add(inventoryadd);
        }
        /*public bool RemoveProduct(bool comprado) {
            if (comprado)
            {
                Lproducts.
            }
        }*/
    }
}
