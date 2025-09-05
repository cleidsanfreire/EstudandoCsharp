namespace DictionaryExercicioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicCookies = new Dictionary<string, string>();
            dicCookies["user"] = "maria";
            dicCookies["email"] = "maria@gmail.com";
            dicCookies["phone"] = "152451525";
            dicCookies["phone"] = "894986485";

            Console.WriteLine("User: " + dicCookies["user"]);
            Console.WriteLine("Email: " + dicCookies["email"]);
            Console.WriteLine("Phone: " + dicCookies["phone"]);

            dicCookies.Remove("email");


            try
            {
                Console.WriteLine("Email: " + dicCookies["email"]);

            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Size: " + dicCookies.Count);

            foreach (KeyValuePair<string, string> item in dicCookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}