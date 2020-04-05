using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    public class Customer:People,ICreditcard,IDebitcard,ICash
    {
        protected List<string> LCustomers;
        private int PaymentMethod { get; set; }
        private int currentmoney { get; set; }
        public Customer(int currentmoney, string name, string lastname, string id, string nationality) : base(name, lastname, id, nationality)
        {
            this.currentmoney = currentmoney;
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
        /*public bool Buy() //function too determine if the person buys or not
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
            if ()//waiting for the other clases to be done...
            {
                for (int i = 0; i < 4; i++)  // if the person buys will be added to the list of customers.
                {
                    switch (i){
                        case 0:
                            LCustomers.Add(name);
                            break;
                        case 1:
                            LCustomers.Add(lastname);
                            break;
                        case 2:
                            LCustomers.Add(id);
                            break;
                        case 3:
                            LCustomers.Add(nationality);
                            break;
                    }
                }
                return true; // if not then i won't be added.
            }
            else {
                return false;
            }
        }*/
    }
}
