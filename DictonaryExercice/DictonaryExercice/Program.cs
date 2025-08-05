using DictonaryExercice.Entities;
using System.Globalization;

namespace DictonaryExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path file: ");
            string sourcePath = Console.ReadLine();

            try 
            {
                string[] lines = File.ReadAllLines(sourcePath);

                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(string l in lines)
                    {
                        string[] folders = l.Split(',');
                        string name = folders[0];
                        double price = double.Parse(folders[1],CultureInfo.InvariantCulture);
                        int quantity = int.Parse(folders[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message); 
            }

        }
    }
}