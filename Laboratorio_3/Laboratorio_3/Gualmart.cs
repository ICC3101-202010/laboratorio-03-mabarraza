using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    public class Gualmart
    {
        public List<Customer> Lcustom = new List<Customer>();
        public List<Worker> Lwork = new List<Worker>();
        public List<People> Leverybody = new List<People>();
        public List<Product> Lpurchaseitems = new List<Product>();
        private int todayearning;
        public Gualmart()
        {
        }
        //public bool HireBoss() { }
        /*public bool FireBoss(List<Product> earnings) {
            if ()
        }*/
        public void AddWorker(Worker newbie)
        {
            Lwork.Add(newbie);
        }
        public void AddCustomer(Customer newclient)
        {
            Lcustom.Add(newclient);
        }
        public void AddPerson(People newperson)
        {
            Leverybody.Add(newperson);
        }
        public void AddProduct(Product newpurchase)
        {
            Lpurchaseitems.Add(newpurchase);
        }
    }
}
