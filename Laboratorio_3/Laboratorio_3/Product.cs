using System;
namespace Laboratorio_3
{
    public class Product
    {
        private string name;
        private string brand;
        private int price;
        private int stock;
        public Product(string name, string brand, int price, int stock)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.stock = stock;
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
        public int Stock
        {
            get { return stock; }
        }
    }
}
