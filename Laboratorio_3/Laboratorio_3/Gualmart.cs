using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    public class Gualmart
    {
        public List<Customer> Lcustom = new List<Customer>();
        public List<Worker> Lwork = new List<Worker>();
        public List<People> Leverybody = new List<People>();
        public List<Inventory> Lbills = new List<Inventory>();
        public List<Worker> Lcashiers = new List<Worker>();
        public Gualmart()
        {
        }
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
        public void AddBill(Inventory boletas)
        {
            Lbills.Add(boletas);
        }
        public void AddCashier(Worker cajero)
        {
            Lcashiers.Add(cajero);
        }
        public int Totalcompra(Inventory sumaboleta) {
            int total = 0;
            foreach(Product t in sumaboleta.Lproducts)
            {
                total += t.Price;
            }
            return total;
        }
        public List<string> boleta(Customer comprador,Inventory boletita,DateTime horacompra,Worker cajero)
        {
            string[] inp = { horacompra.ToString(),comprador.Name, comprador.Lastname, comprador.ID, comprador.Nationality };
            List<string> Boleta_final = new List<string>(inp);
            Console.WriteLine("*********Inicio de la boleta.*********\n");
            Console.WriteLine("Hora de la compra:\n" + horacompra);
            Console.WriteLine("Nombre del comprador:{0}\n;Apellido:{1}\n;Rut:{2}\n;Nacionalidad:{3}\n", comprador.Name, comprador.Lastname, comprador.ID, comprador.Nationality);
            Console.WriteLine("Nombre del cajero/a:{0}\n;Apellido:{1}\n;Rut:{2}\n;Nacionalidad:{3}\n", cajero.Name, cajero.Lastname, cajero.ID, cajero.Nationality);
            foreach (Product z in boletita.Lproducts)
            {
                Boleta_final.Add(z.Name);
                Console.WriteLine("*Nombre del producto:{0}", z.Name);
                Boleta_final.Add(z.Brand);
                Console.WriteLine("*Marca del producto:{0}", z.Brand);
                Boleta_final.Add(z.Price.ToString());
                Console.WriteLine("*Precio del producto:{0}", z.Price);
            }
            Console.WriteLine("Total:{0}",Totalcompra(boletita));
            Console.WriteLine("*********Fin de la boleta.*********\n");
            Boleta_final.Add(Totalcompra(boletita).ToString());
            return Boleta_final;
        }
    }
}
