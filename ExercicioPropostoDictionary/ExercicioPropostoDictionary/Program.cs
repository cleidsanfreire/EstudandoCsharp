namespace ExercicioPropostoDictionary
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full path file: ");
            string path = Console.ReadLine();
            
            Dictionary<string, int> dict = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(',');
                        string name = lines[0];
                        int qtyV = int.Parse(lines[1]);
                        
                        if (dict.ContainsKey(name))
                        {
                            dict[name] += qtyV;
                        }
                        else
                        {
                            dict.Add(name, qtyV);
                        }
                    }
                }
                foreach (KeyValuePair<string, int> kv in dict)
                {
                    Console.WriteLine(kv.Key + ": " + kv.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}