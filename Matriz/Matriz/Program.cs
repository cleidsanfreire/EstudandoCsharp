namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) // n linhas
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) // n colunas 
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("\nNegative numbers = " + count);
        }
    }
}