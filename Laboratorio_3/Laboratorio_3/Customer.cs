using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    public class Customer:People,ICreditcard,IDebitcard,ICash
    {
        public int PaymentMethod { get; set; }
        public int Currentmoney;
        public Customer(int Currentmoney,string name, string lastname, string id, string nationality) : base(name, lastname, id, nationality)
        {
            this.Currentmoney = Currentmoney;
        }
        public void Creditcard()
        {
            Console.WriteLine("Yo pago con tarjeta de credito");
        }
        public void Debitcard()
        {
            Console.WriteLine("Yo pago con tarjeta de debito");
        }
        public void Cash()
        {
            Console.WriteLine("Yo pago con efectivo");
        }
        public bool AvailableStock(Inventory any, Product wannabuy)
        {
            foreach (Product k in any.Lproducts)
            {
                if (wannabuy.Name == k.Name)
                {
                    if (k.Stock == 0)
                    {
                        //Console.WriteLine("No queda stock del articulo buscado!");
                        return false;
                    }
                    else
                    {
                        //Console.WriteLine("Quedan: {0} articulos\n ",k.Stock);
                        k.Stock -= 1; // with this we update the stock of the object that the person just got.
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Buy(Product productprice) //function too determine if the person buys or not
        {
            switch (PaymentMethod) {
                case 1:
                    Creditcard();
                    break;
                case 2:
                    Debitcard();
                    break;
                case 3:
                    Cash();
                    break;
            }
            if (Currentmoney>= productprice.Price)//waiting for the other clases to be done...
            {
                Currentmoney -= productprice.Price;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
