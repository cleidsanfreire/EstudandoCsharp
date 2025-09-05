namespace ExtensionMethodsDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 01, 01, 00, 00, 00);
            Console.WriteLine(dt.ElapsedTime());


            string st = "Manda pra mim que eu mando pra ele";
            Console.WriteLine(st.Cut(9));

        }
    }
}