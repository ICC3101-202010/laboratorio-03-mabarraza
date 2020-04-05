using System;

namespace Laboratorio_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            People ppl = new People("Miguel", "Barraza", "19361024.2", "Chileno");
            Console.WriteLine("Hola soy " + ppl.Name +" " +  ppl.Lastname + " mi rut es " + ppl.ID + " y soy " + ppl.Nationality);
        }
    }
}
