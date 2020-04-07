using System;
namespace Laboratorio_3
{
    public class Product
    {
        private string name;
        private string brand;
        private readonly int price;
        public int Stock;
        public Product(string name, string brand, int price, int Stock)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.Stock = Stock;
        }
        public string Name{
            get { return name; }
        }
        public string Brand
        {
            get { return brand; }
        }
        public int Price
        {
            get { return price; }
        }
    }
}
