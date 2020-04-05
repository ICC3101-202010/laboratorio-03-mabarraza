using System;
namespace Laboratorio_3
{
    public class Boss:Worker
    {
        public Boss(int salary, int schedule, string position, string name, string lastname, string id, string nationality) : base(salary, schedule, position, name, lastname, id, nationality)
        {
        }
        //public bool HireWorker() { }
        /*public bool FireWorker() {
            Random option = new Random();
            option.Next(0, 1);
            if (Convert.ToInt32(option) == 0)
            {
                return false;
            }
            else {

            }
        }*/
        //public bool RiseSalary() { }
    }
}
