using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int var1;
            List<Empresa> empresas = new List<Empresa>();
            Console.WriteLine("1) Cargar y mostrar infromacion");
            Console.WriteLine("2) Crear una empresa");
            Console.WriteLine("3) Cerrar programa");
            var1 =Convert.ToInt32(Console.ReadLine());

            while (var1 != 3)
            {


                if (var1 == 1)
                {
                    empresas = Load();
                    showEmpresas(empresas);
                }
                else if (var1 == 2)
                {
                    addEmpresa(empresas);
                    Save(empresas);
                }
                else
                {
                    Console.WriteLine("Numero no valido");
                }
                Console.WriteLine("1) Cargar y mostrar infromacion");
                Console.WriteLine("2) Mostrar informacion");
                Console.WriteLine("3) Cerrar programa");
                var1 = Convert.ToInt32(Console.ReadLine());

            }
        }

        static public void addEmpresa(List<Empresa> empresas)
        {
            string name;
            int ID;
            Console.Write("Nombre de la empresa: ");
            name = Console.ReadLine();
            Console.Write("ID de la empresa: ");
            ID = Convert.ToInt32(Console.ReadLine());
            empresas.Add(new Empresa(name, ID));
        }

        static public void showEmpresas(List<Empresa> empresas)
        {
            foreach (Empresa nombre in empresas)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine();
        }

        static private void Save(List<Empresa> empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
        }

        static private List<Empresa> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresas = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return empresas;
        }
    }
}