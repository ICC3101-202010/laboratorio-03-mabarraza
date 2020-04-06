using System;
namespace Laboratorio_3
{
    public class Worker : People
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
        public string Position
        {
            get { return position; }
        }
        public int Salary {
            get { return salary; }
        }
        public int Schedule {
            get { return schedule; }
        }
    }
}
//3 cajeras
//1 auxiliar
//1 jefe
//1 supervisor
//1 empleado.