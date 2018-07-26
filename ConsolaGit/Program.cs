using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGit;

namespace ConsolaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            user.Nombre = "Alexis Aravena";

            Profesion prof = new Profesion();
            prof.NombreProfesion = "Ingenieria en Informatica";

            Colegio col = new Colegio();
            col.Nombre = "Duoc UC";
            col.AnnoInicio = 1950;

            prof.Colegio = col;
            user.MiProfesion = prof;


            Console.WriteLine("Avance del codigo version 1.2.3");
            Console.WriteLine("Nombre:{0}    Profesión{1}   Colegio:{2}", user.Nombre, user.MiProfesion.NombreProfesion, user.MiProfesion.Colegio.Nombre);



            Console.ReadKey();
        }
    }
}
