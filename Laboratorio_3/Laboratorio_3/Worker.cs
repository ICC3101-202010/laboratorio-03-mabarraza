using System;
namespace Laboratorio_3
{
    public class Worker : People
    {
        public int Salary { get; set; }
        public int Schedule { get; set; }
        public string Position { get; set; }
        public Worker(int Salary, int Schedule, string Position, string name, string lastname, string id, string nationality) : base(name, lastname, id, nationality)
        {
            this.Salary = Salary;
            this.Schedule = Schedule;
            this.Position = Position;
        }
    }
}