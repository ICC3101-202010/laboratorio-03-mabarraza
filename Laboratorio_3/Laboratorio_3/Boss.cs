using System;
namespace Laboratorio_3
{
    public class Boss : Worker
    {
        public Boss(int salary, int schedule, string position, string name, string lastname, string id, string nationality) : base(salary, schedule, position, name, lastname, id, nationality)
        {
        }
        public bool HireWorker(int sl, int sch, string pos, int workersnumb, Gualmart super)
        {
            int count = 0;
            if (workersnumb == 7)
            {
                Console.WriteLine("Lo siento no estamos contratando.");
                return false;
            }
            else
            {
                if (pos == "Cashier")
                {
                    foreach (Worker w in super.Lwork)
                    {
                        if (pos == w.Position)
                        {
                            count++;
                        }
                    }
                    if (count < 3)
                    {
                        if ((380 <= sl) && (sl <= 500))
                        {
                            if ((8 <= sch) && (sch <= 14))
                            {
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.");
                                return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.");
                        return false;
                    }
                }
                else if (pos == "Auxiliar")
                {
                    foreach (Worker w in super.Lwork)
                    {
                        if (pos == w.Position)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        if ((300 <= sl) && (sl <= 400))
                        {
                            if ((8 <= sch) && (sch <= 14))
                            {
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.");
                                return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo");
                            return false;
                        }
                    }
                    else {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.");
                        return false;
                    }
                }
                else if (pos == "Supervisor")
                {
                    foreach (Worker w in super.Lwork)
                    {
                        if (pos == w.Position)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        if ((600 <= sl) && (sl <= 800))
                        {
                            if ((8 <= sch) && (sch <= 14))
                            {
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.");
                                return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo");
                            return false;
                        }
                    }
                    else {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.");
                        return false;
                    }
                }
                else if (pos == "Employee")
                {
                    foreach (Worker w in super.Lwork)
                    {
                        if (pos == w.Position)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        if ((380 <= sl) && (sl <= 500))
                        {
                            if ((8 <= sch) && (sch <= 14))
                            {
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.");
                                return false;
                            }
                        }
                        else {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("No ofrecemos ese puesto de trabajo, gracias.");
                    return false;
                }
            }
        }
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
