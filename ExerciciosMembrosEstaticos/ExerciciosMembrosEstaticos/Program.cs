using System;

namespace ExerciciosMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Instancias i = new Instancias();
            Instancias i1 = new Instancias();

            Console.WriteLine(Instancias.ObterNumeroInstancias());
        }
    }

}