namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());

            //    int c = a / b;

            //    Console.WriteLine(c);
            //}
            //catch (DivideByZeroException) 
            //{
            //    Console.WriteLine("Error! Don't Divide by Zero ");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Formt Error! " + e.Message);
            //}

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\Users\loock\Downloads\testesa.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);

            }
            catch (FileNotFoundException e) 
            {
                Console.WriteLine("Error! " + e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}