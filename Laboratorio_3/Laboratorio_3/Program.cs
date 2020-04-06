using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool controlt = true;
            bool controlc = true;
            int contratados = 0;
            int moneyleft;
            int[,] superprod_num = { { 5849, 20 }, { 1199, 5 }, { 989, 10 }, { 799, 5 }, { 1000, 14 }, { 2189, 6 }, {1499 ,7 }, {769 ,22 }, {1000 ,4 }, {1699 ,12 }, { 1249,5 }, {1410 ,8 }, {640 ,20 }, {995 ,50 }, {945 ,50 }, {1199 ,20 }, {1990 ,30 }, { 545,30 }, {1799 ,10 }, {2259 ,10 }, { 3599,10 }, {2620 ,20 }, {2000 ,20 }, {3099 ,10 }, { 989,20 }, {4890 ,10 }, {760 ,10 }, {725 ,100 }, {750 ,100 }, {2069 ,10 } };
            string[,] superprod_st = { { "Aceite de Oliva", "Gualmart" }, { "Jurel al natural", "San Jose" }, { "Arroz grado 2", "Tucapel" }, { "Azucar blanca granulada", "Iansa" }, { "Spaghetti Nº5", "Carozzi" }, { "Papel Higienico normal doble hoja", "Confort" }, {"Papel Highienico Rinde máx" ,"Scott" }, {"Fideos Nº5 tricolor" ,"Trattoria" }, {"Azucar" ,"Gualmart" }, {"Aceite de Maravilla" ,"Miraflores" }, {"Arroz Grado 1" ,"Banquete" }, {"Té Rojo,20 bolsitas " ,"Supremo" }, {"Té Ceylán,20 bolsitas" ,"Mildred Tea" }, {"Manzana Royal Gala granel","Gualmart" }, {"Tomate Hidropónico Racimo granel" ,"Gualmart" }, {"Lechuga Española Hidropónica unid." ,"Gualmart" }, {"Limón Malla 1kg." ,"Gualmart" }, {"Plátano granel" ,"Gualmart" }, {"Jabón en barra" ,"Le Sancy" }, {"Jabón líquido" ,"Dove" }, {"Pasta de dientes" , "Colgate", }, { "Pasta de dientes intense white", "Aquafresh"}, { "Desodorante Masculino Fresh Speed", "2000"}, { "Desodorante Femenino  pack 2 unid.", "Etiquet"}, { "Toallas Highienicas Nocturnas", "Kotex"}, { "Café Instantaneo Espresso", "Nescafé"}, { "Agua Mineral Sin gas 1L", "Cachantun"}, {"Pan Hallulla granel", "Gualmart"}, { "Pan Marraqueta granel", "gualmart"},{"Mantequilla Con Sal 250gr.","Colun" } };
            string[] nombres = { "Miguel", "Jose", "Joaquin", "Antonio", "Vicente", "Claudo", "Andres", "Alvaro", "Nicolas", "Tarek", "Raimundo", "Pedro", "Raul", "Sebastian", "Moises", "Benjamin", "Tomas", "Larson", "Pablo", "Javier" };
            string[] apellidos = { "Diaz","Calderon","Valenzuela","Morales","Ruz","Duran","Barrales","Aillapan","Santana","Michels","Meier","Rodriguez","Heufemann","Sarro","Espinoza","Perez","Middleton","Aramundiz","Rojas","Barraza" };
            string[] rut = { "19.293.950-k", "17.298.304-2", "18.079.694-k","17.098.652-1","18.290.341-9","12.364.298-1","7.988.131-7","15.982.829-2","18.209.356-k","17.230.590-5","19.402.673-5","18.198.571-4","19.689.163-1","18.578.241-k","19.352.732-1","18.582.952-6","17.264.298-3","19.873.235-1","20.345.123.-7","19.361.024-2" };
            string[] nacionalidad = { "Chileno","Hatiano","Colombiano","Chileno","Chileno","Chileno","Haitiano","Haitiano","Haitiano","Peruano","Chileno","Chileno","Venezolano","Venezolano","Haitiano","Chileno","Colombano","Chileno","Chileno","Chileno" };
            string[] trabajo = {"Cashier","Employee","Cashier","Cashier","Supervisor","Auxiliar"};
            int[] sueldo = {300000,350000,380000,800000,700000,370000,390000,400000,500000,600000,670000,780000,770000,350000,300000,300000,320000,480000,400000,390000};
            int[] horarios = { 16, 16, 8, 8, 8, 7, 10, 11, 15, 16, 18, 16, 12, 13, 11, 15, 9, 8, 16, 8 };
            int[] compras = { 100000, 90000, 80000, 70000, 60000, 50000, 40000, 200000, 150000, 30000,180000,100000,50000,60000,80000,100000,120000,80000,50000,30000 };
            Inventory inv = new Inventory();
            Customer Marce = new Customer(2000,"Marcela","Aranda","20381204-7","Chilean");
            Boss jefazo = new Boss(1000000, 8, "Boss", "Joaquin","Concha","10.049.870-7","Mexicano");
            Gualmart super = new Gualmart();
            Random nombrepers = new Random();
            Random apellidopers = new Random();
            Random rutpers = new Random();
            Random nacionalidadpers = new Random();
            Random roltrabajador = new Random();
            Random sueldotrabajador = new Random();
            Random horariotrabajador = new Random();
            Random chauchas = new Random();
            Random numcompra = new Random();
            Random cantidaddecompras = new Random();
            while (controlt) {
                if (contratados == 12)
                {
                    controlt = false;
                }
                int nombret = nombrepers.Next(0, nombres.Length);
                int apellidot = apellidopers.Next(0, apellidos.Length);
                int rutt = rutpers.Next(0, rut.Length);
                int nacionalidadt = nacionalidadpers.Next(0,nacionalidad.Length);
                int rolt = roltrabajador.Next(0, trabajo.Length);
                int sueldot = sueldotrabajador.Next(0, sueldo.Length);
                int horariot = horariotrabajador.Next(0, horarios.Length);
                if (jefazo.HireWorker(sueldo[sueldot], horarios[horariot], trabajo[rolt], contratados, super))
                {
                    Worker contratado = new Worker(sueldo[sueldot], horarios[horariot], trabajo[rolt],nombres[nombret], apellidos[apellidot], rut[rutt], nacionalidad[nacionalidadt]);
                    super.AddWorker(contratado);
                    super.AddPerson(contratado);
                    contratados++;
                }
            }
            while (controlc)
            {
                int nombrec = nombrepers.Next(0, trabajo.Length);
                int apellidoc = apellidopers.Next(0, apellidos.Length);
                int rutc = rutpers.Next(0, rut.Length);
                int nacionalidadc = nacionalidadpers.Next(0, nacionalidad.Length);
                int chauchasc = chauchas.Next(0, compras.Length);
                int cdc = cantidaddecompras.Next(0, 10);
                Customer cliente_persona = new Customer(compras[chauchasc],nombres[nombrec],apellidos[apellidoc],rut[rutc],nacionalidad[nacionalidadc]);
                moneyleft = cliente_persona.Currentmoney;
                for (int h = 0; h < cdc; h++)
                {
                    int producto = numcompra.Next(0, 30);
                    while (moneyleft > inv.Lproducts[producto].Price)
                    {
                        if (cliente_persona.AvailableStock(inv, inv.Lproducts[producto]))
                        {
                            super.Lpurchaseitems.Add(inv.Lproducts[producto]);
                        }
                    }
                }
            }
            for (int i = 0; i < 30; i++)
            {
                Product stockgen = new Product(superprod_st[i, 0], superprod_st[i, 1], superprod_num[i, 0], superprod_num[i, 1]);
                inv.AddProduct(stockgen.Name, stockgen.Brand, stockgen.Price, stockgen.Stock);
            }
            foreach (Product k in inv.Lproducts)
            {
                Marce.AvailableStock(inv, k);
                Console.WriteLine("Nombre:{0};Marca:{1};Precio:{2};Stock:{3}\n",k.Name,k.Brand,k.Price,k.Stock);
            }
            foreach(Worker w in super.Lwork)
            {
                Console.WriteLine("Nombre:{0};Apellido:{1};Rut:{2};Cargo:{3};Sueldo:{4};Horario:{5}.\n",w.Name,w.Lastname,w.ID,w.Position,w.Salary,w.Schedule);
            }
        }
    }
}
