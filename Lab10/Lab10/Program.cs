using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ClassLibrary1;

namespace Lab10
{

    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(1996, 11, 04);

            List<Person> personas = new List<Person>();
            List<Car> autos = new List<Car>();
            List<Address> direcciones = new List<Address>();

            

            Person persona1 = new Person("Seba","Gonzalez",fecha,null,"195672229",null,null);
            Address direccion1 = new Address("camino del ayuntamiento",2026,"Lo Barneche","Santiago",persona1,2000,6,3,true,true);
            Car auto1 = new Car("Ford","Explorer",2016,persona1,"aa6666",7,false);
            string opc, opc1;
            Console.WriteLine("Bienvenido a menu Registro Civil\n");
            while (true)
            {
                Console.WriteLine("1.Administrar Persona");
                Console.WriteLine("2.Administrar Residencia");
                Console.WriteLine("3.Administrar Vehiculo");
                Console.WriteLine("4.Salir");
                opc = Console.ReadLine();
                if (opc != "1" || opc != "2" || opc != "3" || opc != "4")
                {
                    Console.WriteLine("Ingrese Una Opcion Valida");
                };
                if (opc == "1")
                {
                    while (true)
                    {
                        int cont = 0, ind;
                        string nombre = "";
                        string apellido = "";
                        string inst = " ";
                        string titulo = " ";
                        DateTime birth;
                        string rut = "";
                        int ano, mes, dia;
                        Address vivienda;
                        Person padre, madre;

                        Console.WriteLine("1.Crear Nueva persona");
                        Console.WriteLine("2.Cambiar Nombre");
                        Console.WriteLine("3.Cambiar Apellido");
                        Console.WriteLine("4.Abandonar Persona");
                        Console.WriteLine("5.Adoptar Persona");
                        Console.WriteLine("6.Entregar Casa Actual");
                        Console.WriteLine("7.Asignar Educacion");
                        Console.WriteLine("8.Salir");
                        opc1 = Console.ReadLine();
                        if (opc1 != "1" || opc1 != "2" || opc1 != "3" || opc1 != "4" || opc1 != "5" || opc1 != "6" || opc1 != "7" || opc1 != "8")
                        {
                            Console.WriteLine("Ingrese Una Opcion Valida");
                        }
                        if (opc1 == "1")
                        {


                            Console.WriteLine("Ingrese Nombre: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese Apellido: ");
                            apellido = Console.ReadLine();
                            Console.WriteLine("Año de Nacimiento: ");
                            ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Mes de Nacimiento: ");
                            mes = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Dia de Nacimiento: ");
                            dia = Convert.ToInt32(Console.ReadLine());
                            birth = new DateTime(ano, mes, dia);
                            vivienda = null;
                            Console.WriteLine("RUT: ");
                            rut = Console.ReadLine();
                            if (personas.Count() == 0)
                            {
                                padre = null;
                            }
                            else
                            {
                                foreach (Person persona in personas)
                                {
                                    Console.WriteLine(cont + ". " + persona);
                                    cont++;
                                }
                                Console.Write("Seleccione Padre :");
                                ind = Convert.ToInt16(Console.ReadLine());
                                padre = new Person(personas[ind].First_name, personas[ind].Last_name, personas[ind].Birth_date, null, personas[ind].Rut, null, null);
                            }
                            if (personas.Count() == 0)
                            {
                                madre = null;
                            }
                            else
                            {
                                foreach (Person persona in personas)
                                {
                                    Console.WriteLine(cont + ". " + persona);
                                    cont++;
                                }
                                Console.Write("Seleccione Padre :");
                                ind = Convert.ToInt16(Console.ReadLine());
                                madre = new Person(personas[ind].First_name, personas[ind].Last_name, personas[ind].Birth_date, null, personas[ind].Rut, null, null);
                            }
                            Person a = new Person(nombre, apellido, birth, null, rut, padre, madre);
                            personas.Add(a);
                        }
                        else if (opc1 == "2")
                        {
                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona.First_name + " "+persona.Last_name);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Persona :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese Nuevo Nombre");
                            nombre = Console.ReadLine();
                            personas[ind].changeFirstName(nombre);
                        }
                        else if (opc1 == "3")
                        {
                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona.First_name + " " + persona.Last_name);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Persona :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese Nuevo Apellido");
                            apellido = Console.ReadLine();
                            personas[ind].changeFirstName(nombre);
                        }
                        else if (opc1 == "4")
                        {
                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona.First_name + " " + persona.Last_name);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Persona :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            personas[ind].getAbandoned();
                        }
                        else if (opc1 == "5")
                        {
                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona.First_name + " " + persona.Last_name);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Nuevo Padre :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            padre = new Person(personas[ind].First_name, personas[ind].Last_name, personas[ind].Birth_date, null, personas[ind].Rut, null, null);

                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona.First_name + " " + persona.Last_name);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Nueva Madre :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            madre = new Person(personas[ind].First_name, personas[ind].Last_name, personas[ind].Birth_date, null, personas[ind].Rut, null, null);

                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona.First_name + " " + persona.Last_name);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Adoptado :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            padre = new Person(personas[ind].First_name, personas[ind].Last_name, personas[ind].Birth_date, null, personas[ind].Rut, padre, madre);
                        }
                        else if (opc1 == "6")
                        {
                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Nuevo Propietario :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            padre = personas[ind];

                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Persona que entrega Casa :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            personas[ind].giveUpOwnershipToThirdParty(padre);

                        }
                        else if (opc1 == "7")
                        {
                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(cont + ". " + persona);
                                cont++;
                            }
                            cont = 0;
                            Console.Write("Seleccione Nuevo Graduado :");
                            ind = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese Casa de Estudio: ");
                            inst = Console.ReadLine();
                            Console.WriteLine("Ingrese Titulo del Graduado: ");
                            titulo = Console.ReadLine();
                            personas[ind].setEducation(inst, titulo);
                        }
                        else if (opc1 == "8")
                        {
                            break;
                        }
                    }
                }
                else if (opc == "2")
                {
                    while (true)
                    {
                        int cont = 0, ind;
                        string tiene;
                        string calle,comuna,ciudad;
                        int numero,piezas,baños,ano;
                        bool piscina, patio;

                        Console.WriteLine("1.Crear Nueva Casa");
                        Console.WriteLine("2.Agregar Baño");
                        Console.WriteLine("3.Agregar Pieza");
                        Console.WriteLine("4.Cambiar Dueño");
                        Console.WriteLine("5.Salir");
                        opc1 = Console.ReadLine();

                        if (opc1 != "1" || opc1 != "2" || opc1 != "3" || opc1 != "4" || opc1 != "5")
                        {
                            Console.WriteLine("Ingrese Una Opcion Valida");
                        }
                        else if (opc1 == "1")
                        {
                            Console.WriteLine("Ingrese Calle de la vivienda :");
                            calle = Console.ReadLine();
                            Console.WriteLine("Ingrese Numero de la vivienda :");
                            numero = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese Comuna de la vivienda :");
                            comuna = Console.ReadLine();
                            Console.WriteLine("Ingrese Ciudad de la vivienda :");
                            ciudad = Console.ReadLine();
                            Console.WriteLine("Ingrese Cantidad de baños :");
                            baños = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese Cantidad de piezas :");
                            piezas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese Año de Construccion");
                            ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Tiene Piscina T/F :");
                            tiene = Console.ReadLine();
                            if (tiene == "T")
                            {
                                piscina = true;
                            }
                            else
                            {
                                piscina = false;
                            }
                            Console.WriteLine("Tiene Patio T/F :");
                            tiene = Console.ReadLine();
                            if (tiene == "T")
                            {
                                patio = true;
                            }
                            else
                            {
                                patio = false;
                            }
                            Address a = new Address(calle, numero, comuna, ciudad, null, ano, piezas, baños, patio, piscina);
                            direcciones.Add(a);
                        }
                        else if (opc1 == "2")
                        {
                            foreach (Address direccion in direcciones)
                            {
                                Console.WriteLine(cont + ". " + direccion);
                                cont++;
                            }
                            cont = 0;
                            Console.WriteLine("Seleccione Una casa");
                            ind = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Cantidad De baños A agregar: ");
                            baños = Convert.ToInt32(Console.ReadLine());
                            direcciones[ind].addBathrooms(baños);
                        }
                        else if (opc1 == "3")
                        {
                            foreach (Address direccion in direcciones)
                            {
                                Console.WriteLine(cont + ". " + direccion);
                                cont++;
                            }
                            cont = 0;
                            Console.WriteLine("Seleccione Una casa");
                            ind = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Cantidad De Piezas A agregar: ");
                            piezas = Convert.ToInt32(Console.ReadLine());
                            direcciones[ind].addBeedrooms(piezas);
                        }
                        else if (opc1 == "4")
                        {
                            
                        }
                        else if (opc1 == "5")
                        {
                            break;
                        }
                    }
                }
                    
            };

        }
    }
}
