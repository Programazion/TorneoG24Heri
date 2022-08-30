﻿using Torneo.App.Dominio;
using Torneo.App.Persistencia;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioDT _repoDT = new RepositorioDT();
        static void Main(string[] args)
        {
            int opcion = 0;
            do{
                Console.WriteLine("2. Insertar director tecnico");
                Console.WriteLine("0. Salir");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 2:
                        AddDT();
                        break;
                }
            } while(opcion != 0);
        }

        private static void AddDT()
        {
            Console.WriteLine("Escriba el nombre del DT");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el documento del DT");
            string documento = Console.ReadLine();
            Console.WriteLine("Escriba el telefono del DT");
            string telefono = Console.ReadLine();
            var directorTecnico = new DirectorTecnico
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,
            };
            _repoDT.AddDT(directorTecnico);
        }

    }
}