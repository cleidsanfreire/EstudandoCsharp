using System;

namespace TimeSpanCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan t1 = new TimeSpan(); // construtor vazio
            //TimeSpan t2 = new TimeSpan(900000000); // construtor com Ticks
            //TimeSpan t3 = new TimeSpan(10,20,30); //construtor com Horas, minutos, segundos
            //TimeSpan t4 = new TimeSpan(15,10,30,45); // construtor com dias, horas, minutos, segundos
            //TimeSpan t5 = new TimeSpan(10, 5, 30, 20, 350); //construtor com dias, horas, minutos, segundos, milisegundos
            //TimeSpan t6 = new TimeSpan(90, 15, 35, 20, 350, 5600); // construtor com dias, horas, minutos, segundos, milisegundos, microsegundos

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);

            TimeSpan s1 = TimeSpan.FromDays(1.5);
            TimeSpan s2 = TimeSpan.FromHours(1.5);
            TimeSpan s3 = TimeSpan.FromMinutes(1.5);
            TimeSpan s4 = TimeSpan.FromSeconds(1.5);
            TimeSpan s5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan s6 = TimeSpan.FromMicroseconds(1.5);
            TimeSpan s7 = TimeSpan.FromTicks(150000L);


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
    }
}