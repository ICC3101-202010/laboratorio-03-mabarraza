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
            int morningshift = 0;
            int eveningshift = 0;
            if (workersnumb == 12)
            {
                Console.WriteLine("Lo siento no estamos contratando.\n");
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
                            switch (sch)
                            {
                                case 8:
                                    morningshift++;
                                    break;
                                case 16:
                                    eveningshift++;
                                    break;
                                default:
                                    Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.\n");
                                    return false;
                            }
                        }
                    }
                    if ((morningshift < 3)||(eveningshift<3))
                    {
                        if (sl <= 500000)
                        {

                            Console.WriteLine("Contratado!\n");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo\n");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.\n");
                        return false;
                    }
                }
                else if (pos == "Auxiliar")
                {
                    foreach (Worker w in super.Lwork)
                    {
                        switch (sch)
                        {
                            case 8:
                                morningshift++;
                                break;
                            case 16:
                                eveningshift++;
                                break;
                            default:
                                Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.\n");
                                return false;
                        }
                    }
                    if ((morningshift == 0) || (eveningshift == 0))
                    {
                        if (sl <= 400000)
                        {
                            Console.WriteLine("Contratado!\n");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo\n");
                            return false;
                        }
                    }
                    else {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.\n");
                        return false;
                    }
                }
                else if (pos == "Supervisor")
                {
                    foreach (Worker w in super.Lwork)
                    {
                        switch (sch)
                        {
                            case 8:
                                morningshift++;
                                break;
                            case 16:
                                eveningshift++;
                                break;
                            default:
                                Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.\n");
                                return false;
                        }
                    }
                    if ((morningshift == 0) || (eveningshift == 0))
                    {
                        if (sl <= 800000)
                        {
                            Console.WriteLine("Contratado!\n");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo\n");
                            return false;
                        }
                    }
                    else {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.\n");
                        return false;
                    }
                }
                else if (pos == "Employee")
                {
                    foreach (Worker w in super.Lwork)
                    {
                        switch (sch)
                        {
                            case 8:
                                morningshift++;
                                break;
                            case 16:
                                eveningshift++;
                                break;
                            default:
                                Console.WriteLine("Lo Sentimos pero no necesitmos personal a esa hora.\n");
                                return false;
                        }
                    }
                    if ((morningshift == 0) || (eveningshift == 0))
                    {
                        if (sl <= 500000)
                        {
                            Console.WriteLine("Contratado!\n");
                            return true;
                        }
                        else {
                            Console.WriteLine("Lo sentimos pero no ofrecemos ese puesto de trabajo por ese sueldo\n");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos no necesitamos empleados en esa area.\n");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("No ofrecemos ese puesto de trabajo, gracias.\n");
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
