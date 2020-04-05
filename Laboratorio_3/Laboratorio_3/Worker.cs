using System;
namespace Laboratorio_3
{
    public class Worker:People
    {
        protected int salary;
        protected int schedule;
        protected string position;
        public Worker(int salary, int schedule, string position, string name, string lastname, string id, string nationality) : base(name, lastname, id, nationality)
        {
            this.salary = salary;
            this.schedule = schedule;
            this.position = position;
        }
    }
}
