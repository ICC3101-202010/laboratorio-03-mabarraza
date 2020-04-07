using System;
using System.Collections.Generic;

namespace Laboratorio_3
{
    class MainClass
    {
        public static void Simulación()
        {
            bool controlt = true;
            bool controlc = true;
            int contratados = 0;
            int compradores = 0;
            int moneyleft;
            int[,] superprod_num = { { 5849, 20 }, { 1199, 5 }, { 989, 10 }, { 799, 5 }, { 1000, 14 }, { 2189, 6 }, { 1499, 7 }, { 769, 22 }, { 1000, 4 }, { 1699, 12 }, { 1249, 5 }, { 1410, 8 }, { 640, 20 }, { 995, 50 }, { 945, 50 }, { 1199, 20 }, { 1990, 30 }, { 545, 30 }, { 1799, 10 }, { 2259, 10 }, { 3599, 10 }, { 2620, 20 }, { 2000, 20 }, { 3099, 10 }, { 989, 20 }, { 4890, 10 }, { 760, 10 }, { 725, 100 }, { 750, 100 }, { 2069, 10 } };
            string[,] superprod_st = { { "Aceite de Oliva", "Gualmart" }, { "Jurel al natural", "San Jose" }, { "Arroz grado 2", "Tucapel" }, { "Azucar blanca granulada", "Iansa" }, { "Spaghetti Nº5", "Carozzi" }, { "Papel Higienico normal doble hoja", "Confort" }, { "Papel Highienico Rinde máx", "Scott" }, { "Fideos Nº5 tricolor", "Trattoria" }, { "Azucar", "Gualmart" }, { "Aceite de Maravilla", "Miraflores" }, { "Arroz Grado 1", "Banquete" }, { "Té Rojo,20 bolsitas ", "Supremo" }, { "Té Ceylán,20 bolsitas", "Mildred Tea" }, { "Manzana Royal Gala granel", "Gualmart" }, { "Tomate Hidropónico Racimo granel", "Gualmart" }, { "Lechuga Española Hidropónica unid.", "Gualmart" }, { "Limón Malla 1kg.", "Gualmart" }, { "Plátano granel", "Gualmart" }, { "Jabón en barra", "Le Sancy" }, { "Jabón líquido", "Dove" }, { "Pasta de dientes", "Colgate", }, { "Pasta de dientes intense white", "Aquafresh" }, { "Desodorante Masculino Fresh Speed", "2000" }, { "Desodorante Femenino  pack 2 unid.", "Etiquet" }, { "Toallas Highienicas Nocturnas", "Kotex" }, { "Café Instantaneo Espresso", "Nescafé" }, { "Agua Mineral Sin gas 1L", "Cachantun" }, { "Pan Hallulla granel", "Gualmart" }, { "Pan Marraqueta granel", "gualmart" }, { "Mantequilla Con Sal 250gr.", "Colun" } };
            string[] nombres = { "Miguel", "Jose", "Joaquin", "Antonio", "Vicente", "Claudo", "Andres", "Alvaro", "Nicolas", "Tarek", "Raimundo", "Pedro", "Raul", "Sebastian", "Moises", "Benjamin", "Tomas", "Larson", "Pablo", "Javier" };
            string[] apellidos = { "Diaz", "Calderon", "Valenzuela", "Morales", "Ruz", "Duran", "Barrales", "Aillapan", "Santana", "Michels", "Meier", "Rodriguez", "Heufemann", "Sarro", "Espinoza", "Perez", "Middleton", "Aramundiz", "Rojas", "Barraza" };
            string[] rut = { "19.293.950-k", "17.298.304-2", "18.079.694-k", "17.098.652-1", "18.290.341-9", "12.364.298-1", "7.988.131-7", "15.982.829-2", "18.209.356-k", "17.230.590-5", "19.402.673-5", "18.198.571-4", "19.689.163-1", "18.578.241-k", "19.352.732-1", "18.582.952-6", "17.264.298-3", "19.873.235-1", "20.345.123.-7", "19.361.024-2" };
            string[] nacionalidad = { "Chileno", "Hatiano", "Colombiano", "Chileno", "Chileno", "Chileno", "Haitiano", "Haitiano", "Haitiano", "Peruano", "Chileno", "Chileno", "Venezolano", "Venezolano", "Haitiano", "Chileno", "Colombano", "Chileno", "Chileno", "Chileno" };
            string[] trabajo = { "Cashier", "Employee", "Cashier", "Cashier", "Supervisor", "Auxiliar" };
            int[] sueldo = { 300000, 350000, 380000, 800000, 700000, 370000, 390000, 400000, 500000, 600000, 670000, 780000, 770000, 350000, 300000, 300000, 320000, 480000, 400000, 390000 };
            int[] horarios = { 16, 16, 8, 8, 8, 7, 10, 11, 15, 16, 18, 16, 12, 13, 11, 15, 9, 8, 16, 8 };
            int[] compras = { 100000, 90000, 80000, 70000, 60000, 50000, 40000, 200000, 150000, 30000, 180000, 100000, 50000, 60000, 80000, 100000, 120000, 80000, 50000, 30000 };
            Inventory inv = new Inventory();
            Boss jefazo = new Boss(1000000, 8, "Boss", "Joaquin", "Concha", "10.049.870-7", "Mexicano");
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
            Random quienatiende = new Random();
            while (controlt)
            {
                if (contratados == 12)
                {
                    controlt = false;
                }
                int nombret = nombrepers.Next(0, nombres.Length);
                int apellidot = apellidopers.Next(0, apellidos.Length);
                int rutt = rutpers.Next(0, rut.Length);
                int nacionalidadt = nacionalidadpers.Next(0, nacionalidad.Length);
                int rolt = roltrabajador.Next(0, trabajo.Length);
                int sueldot = sueldotrabajador.Next(0, sueldo.Length);
                int horariot = horariotrabajador.Next(0, horarios.Length);
                if (jefazo.HireWorker(sueldo[sueldot], horarios[horariot], trabajo[rolt], contratados, super))
                {
                    Worker contratado = new Worker(sueldo[sueldot], horarios[horariot], trabajo[rolt], nombres[nombret], apellidos[apellidot], rut[rutt], nacionalidad[nacionalidadt]);
                    super.AddWorker(contratado);
                    super.AddPerson(contratado);
                    if (contratado.Position == "Cashier")
                    {
                        super.AddCashier(contratado);
                    }
                    contratados++;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                Product stockgen = new Product(superprod_st[i, 0], superprod_st[i, 1], superprod_num[i, 0], superprod_num[i, 1]);
                inv.AddProduct(stockgen);
            }
            Console.WriteLine("*****************Stock Inicial.*****************\n");
            inv.showstock(inv.Lproducts);
            Console.WriteLine("\n*****************Fin Stock Inicial.*****************\n");
            while (controlc)
            {
                int nombrec = nombrepers.Next(0, trabajo.Length);
                int apellidoc = apellidopers.Next(0, apellidos.Length);
                int rutc = rutpers.Next(0, rut.Length);
                int nacionalidadc = nacionalidadpers.Next(0, nacionalidad.Length);
                int chauchasc = chauchas.Next(0, compras.Length);
                int cdc = cantidaddecompras.Next(30, 50);
                Customer cliente_persona = new Customer(compras[chauchasc], nombres[nombrec], apellidos[apellidoc], rut[rutc], nacionalidad[nacionalidadc]);
                Inventory registrodecompra = new Inventory();
                super.AddCustomer(cliente_persona);
                super.AddPerson(cliente_persona);
                moneyleft = cliente_persona.Currentmoney;
                for (int h = 0; h < cdc; h++)
                {
                    int producto = numcompra.Next(0, 30);
                    if (cliente_persona.AvailableStock(inv, inv.Lproducts[producto]))
                    {
                        if (moneyleft >= inv.Lproducts[producto].Price)
                        {
                            registrodecompra.AddProduct(inv.Lproducts[producto]);
                            moneyleft -= inv.Lproducts[producto].Price;
                        }
                    }
                }
                super.AddBill(registrodecompra);
                compradores++;
                if (compradores == 5)
                {
                    controlc = false;
                }
            }
            for (int j = 0; j < 5; j++)
            {
                int contadorcj = 0;
                foreach (Worker  w in super.Lcashiers)
                {
                        contadorcj++;
                }
                Console.WriteLine("este es el contador" + contadorcj);
                int ca = quienatiende.Next(0, contadorcj - 1);
                super.boleta(super.Lcustom[j], super.Lbills[j], DateTime.Now, super.Lcashiers[ca]);
            }
            Console.WriteLine("\n*****************Stock Actualizado:*****************\n");
            inv.showstock(inv.Lproducts);
            Console.WriteLine("\n*****************Fin Stock Actualizado.*****************");
        }
        public static void Main(string[] args)
        {
            bool a = true;
            bool e = true;
            //bool f = true;
            //bool g = true;
            //bool h = true;
            string seleccion;
            Random cualquier_cajero = new Random();
            Inventory bodega = new Inventory();
            Inventory boleeta = new Inventory();
            Gualmart gual_mart = new Gualmart();
            Console.WriteLine("*****************************Bienvenido a Gualmart******************************");
            Console.WriteLine("Presione uno de los siguientes numeros:\n"+"1 para crear productos.\n"+"2 para agregar trabajadores.\n"+"3 para agregar clientes.\n"+"4 para realizar una compra.\n"+"5 para ver las boletas de la compras hechas.\n"+"6 para ver el stock que queda de productos\n"+"7 para cambiar los datos de los trabajadores.\n"+"8 para ejecutar la simulación(BONUS).\n"+"9 para terminar el programa.");
            last:
            while (a)
            {
                seleccion = Console.ReadLine();
                if (seleccion == "1")
                {
                    bool b = true;
                    while (b)
                    {
                        Console.WriteLine("Ingrese el nombre del producto:");
                        string nombreprod = Console.ReadLine();
                        Console.WriteLine("Ingrese la marca del producto:");
                        string marcaprod = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio del producto:");
                        int precioprod = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el stock del producto:");
                        int stockprod = Convert.ToInt32(Console.ReadLine());
                        Product userstock = new Product(nombreprod, marcaprod, precioprod, stockprod);
                        bodega.AddProduct(userstock);
                        Console.WriteLine("¿Desea agregar mas productos?\n" + "presione y para agregar mas productos o n para continuar:");
                        string masproductos = Console.ReadLine();
                        if (masproductos == "n")
                        {
                            b = false;
                        }
                    }
                }
                else if (seleccion == "2")
                {
                    bool c = true;
                    Console.WriteLine("Al momento de asignar un rol al trabajador estas son las posibilidades:\n"+"Jefe.\n"+"Supervisor.\n"+"Cajero.\n"+"Empleado.\n"+"Auxiliar.\n"+ "porfavor note que todas empiezan con mayúscula.\n");
                    while (c)
                    {
                        Console.WriteLine("Ingrese el nombre del trabajador:");
                        string nombre_trabajador = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del trabajador:");
                        string apellido_trabajador = Console.ReadLine();
                        Console.WriteLine("Ingrese la nacionalidad del trabajador:");
                        string nacionalidad_trabajador = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut del trabajador:");
                        string rut_trabajador = Console.ReadLine();
                        Console.WriteLine("Ingrese el rol del trabajador:");
                        string rol_trabajador = Console.ReadLine();
                        Console.WriteLine("Ingrese el sueldo del trabajador:");
                        int sueldo_trabajador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el horario de ingreso del trabajador:");
                        int horario_trabajador = Convert.ToInt32(Console.ReadLine());
                        Worker trabajador = new Worker(sueldo_trabajador, horario_trabajador, rol_trabajador, nombre_trabajador, apellido_trabajador, rut_trabajador, nacionalidad_trabajador);
                        gual_mart.AddWorker(trabajador);
                        gual_mart.AddPerson(trabajador);
                        if (trabajador.Position == "Cajero")
                        {
                            gual_mart.AddCashier(trabajador);
                        }
                        Console.WriteLine("¿Desea agregar mas trabajadores?\n" + "presione y para agregar mas trabajadores o n para continuar:");
                        string mastrabajadores = Console.ReadLine();
                        if (mastrabajadores == "n")
                        {
                            c = false;
                        }
                    }
                }
                else if (seleccion == "3")
                {
                    bool d = true;
                    while (d)
                    {
                        Console.WriteLine("Ingrese el nombre del cliente:");
                        string nombre_cliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del cliente:");
                        string apellido_cliente = Console.ReadLine();
                        Console.WriteLine("Ingrese la nacionalidad del cliente:");
                        string nacionalidad_cliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut del cliente:");
                        string rut_cliente = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de dinero que porta el cliente:");
                        int dinero_cliente = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Elija el metodo de pago.\n"+"1 para tarjeta de debito\n"+"2 para tarjeta de credito\n"+"3 para efectivo\n");
                        Customer clientela = new Customer(dinero_cliente, nombre_cliente, apellido_cliente, rut_cliente, nacionalidad_cliente);
                        clientela.PaymentMethod = Convert.ToInt32(Console.ReadLine());
                        gual_mart.AddCustomer(clientela);
                        gual_mart.AddPerson(clientela);
                        Console.WriteLine("¿Desea agregar mas clientes?\n" + "presione y para agregar mas clientes o n para continuar:");
                        string masclientes = Console.ReadLine();
                        if (masclientes == "n")
                        {
                            d = false;
                        }
                    }
                }
                else if (seleccion == "4")
                {
                    Console.WriteLine("¿Quien realizara la compra?");
                    reset:
                    foreach (Customer pepe in gual_mart.Lcustom)
                    {
                        Console.WriteLine("Nombre:{0};Dinero:{1}\n", pepe.Name, pepe.Currentmoney);
                        Console.WriteLine("Presiona y para elegir a esta persona, presiona n para ver la informacion de la siguiente persona.");
                        string elegido = Console.ReadLine();
                        if (elegido == "y")
                        {
                            Console.WriteLine("¿Que producto llevara?");
                            reset2:
                            int numero_producto = 0;
                            foreach (Product paracomprar in bodega.Lproducts)
                            {
                                Console.WriteLine("Nombre:{0};marca:{1};stock:{2},precio:{3}.\n", paracomprar.Name, paracomprar.Brand, paracomprar.Stock, paracomprar.Price);
                                Console.WriteLine("Presiona y para elegir  este producto, presiona n para continuar:.");
                                string producto_elegido = Console.ReadLine();
                                if (producto_elegido == "y")
                                {
                                    if (pepe.AvailableStock(bodega, bodega.Lproducts[numero_producto]))
                                    {
                                        Console.WriteLine("Hay Stock!");
                                        if (pepe.Buy(bodega.Lproducts[numero_producto]))
                                        {
                                            boleeta.AddProduct(bodega.Lproducts[numero_producto]);
                                            gual_mart.AddBill(boleeta);
                                            Console.WriteLine("¿Desea agregar mas productos al carrito?\n" + "presione y para agregar mas productos o n para continuar");
                                            string mas_productos = Console.ReadLine();
                                            if (mas_productos == "y")
                                            {
                                                goto reset2;
                                            }
                                            else
                                            {
                                                goto reset3;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No tienes dinero suficiente para esta compra!\n"+"¿Desea seguir buscando productos?"+ "presione y para buscar mas productos o n para continuar");
                                            string nocompra = Console.ReadLine();
                                            if (nocompra == "y")
                                            {
                                                goto reset2;
                                            }
                                            else
                                            {
                                                goto reset3;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Revisas el estante y no encuentras el producto que buscabas...");
                                        Console.WriteLine("¿Revisar si hay mas productos?" + "presione y para seguir buscando o n para continuar:");
                                        string peores_nada = Console.ReadLine();
                                        if (peores_nada == "y")
                                        {
                                            goto reset2;
                                        }
                                        else
                                        {
                                            goto reset3;
                                        }
                                    }
                                }
                                numero_producto++;
                            }
                            reset3:
                            Console.WriteLine("¿Desea realizar compras con otra persona?"+ "presione y para elegir otra persona o n para continuar:");
                            string otra_persona = Console.ReadLine();
                            if (otra_persona == "y")
                            {
                                goto reset;
                            }
                            else
                            {
                                goto choice;
                            }
                        }
                    }
                    }
                else if (seleccion == "5")
                {
                    int contador_boletas = 0;
                    foreach (Customer c in gual_mart.Lcustom)
                    {
                        int contador_cajeros = 0;
                        foreach (Worker w in gual_mart.Lcashiers)
                        {
                                contador_cajeros++;
                        }
                        if (contador_cajeros >= 0) {
                            int cc = cualquier_cajero.Next(0, contador_cajeros-1);
                            gual_mart.boleta(c, gual_mart.Lbills[contador_boletas], DateTime.Now, gual_mart.Lcashiers[cc]);
                            contador_boletas++;
                        }
                        else
                        {
                            Console.WriteLine("No ha agregado ningun trabajador con el rol de cajero"+"No se puede hacer la boleta!"+"vuelva al menu y agregue uno!");
                            goto choice;
                        }
                    }
                }
                else if (seleccion == "6")
                {
                    Console.WriteLine("\n*****************Stock Actualizado:*****************\n");
                    bodega.showstock(bodega.Lproducts);
                    Console.WriteLine("\n*****************Fin Stock Actualizado.*****************");
                }
                else if(seleccion == "7")
                {
                    while (e)
                    {
                        foreach (Worker j in gual_mart.Lwork)
                        {
                            if (j.Position == "Jefe")
                            {
                                Boss jefesito = new Boss(j.Salary, j.Schedule, j.Position, j.Name, j.Lastname, j.ID, j.Nationality);
                                Console.WriteLine("¿A quien quiere cambiarle la ingormación?\n");
                                foreach (Worker g in gual_mart.Lwork)
                                {
                                    seleccion:
                                    Console.WriteLine("Nombre:" + g.Name+"\n"+ "Posicion" + j.Position+"\n" + "Horario de ingreso\n" + j.Schedule+"\n" + "Sueldo\n" + j.Salary);
                                    Console.WriteLine("Presione y para elegir a este trabajador o n para continuar");
                                    string este = Console.ReadLine();
                                    if (este == "y")
                                    {
                                    seleccion2:
                                        jefesito.ChangeInfo(g);
                                        Console.WriteLine("¿Desea cambiarle algo mas a este trabajador?" + " Presione y para seguir cambiando el estdo del trabajador o n para continuar:");
                                        string este2 = Console.ReadLine();
                                        if (este2 == "y")
                                        {
                                            goto seleccion2;
                                        }
                                        else
                                        {
                                            Console.WriteLine("¿Desea cambiarle algo a otro trabajador?" + " Presione y para elejir a otro trabajador o n para continuar:");
                                            string este3 = Console.ReadLine();
                                            if (este3 == "y")
                                            {
                                                goto seleccion;
                                            }
                                            else
                                            {
                                                goto choice;
                                            }
                                        }
                                    }
                                }
                            }
                        } 
                    }
                }
                else if (seleccion == "8")
                {
                    Simulación();
                }
                else if (seleccion == "9")
                {
                    a = false;
                    goto last;
                }
                else
                {
                    Console.WriteLine("El comando ingresado es incorrecto, porfavor vuelvalo a intentar");
                }
                choice:
                Console.WriteLine("Presione uno de los siguientes numeros:\n" + "1 para crear productos.\n" + "2 para agregar trabajadores.\n" + "3 para agregar clientes.\n" + "4 para realizar una compra.\n" +"5 para ver las boletas de las compras hechas.\n"+"6 para ver el stock que queda de productos\n"+"7 para cambiar los datos de los trabajadores.\n"+ "8 para ejecutar la simulación(BONUS).\n" + "9 para terminar el programa.");
            }
            Console.WriteLine("Gracias por revisar!!");
        }
    }
}

                