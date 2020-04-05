using System;
namespace Laboratorio_3
{
    public class Cashier:Worker
    {
        public Cashier(int salary, int schedule, string position, string name, string lastname, string id, string nationality) : base(salary, schedule, position, name, lastname, id, nationality)
        {
        }
        //public bool  AvailableStock() { }
        //public void ActualizeStock() { }
    }
}
