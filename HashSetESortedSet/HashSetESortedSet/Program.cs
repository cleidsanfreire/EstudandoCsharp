namespace HashSetESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            Console.WriteLine(set.Contains("Maria"));

            SortedSet<int> a = new SortedSet<int>() { 0, 3, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 1, 2, 4, 8, 7, 9, 11 };

            // UNION
            // UnionWith combina os elementos de 'a' com os de 'b',
            // removendo duplicados automaticamente e mantendo a ordenação.
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            // INTERSECTION
            // IntersectWith mantém apenas os elementos que aparecem em ambos os conjuntos (a ∩ b).
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); //d = a ∩ b / Símbolo ∩ (interseção) Significa “quais elementos são comuns entre dois conjuntos”.
            PrintCollection(d);

            // DIFFERENCE
            // ExceptWith remove do conjunto 'a' todos os elementos que também existam em 'b' (a - b).
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // e = a - b / Símbolo - (diferença de conjuntos) Significa “quais elementos estão em A mas não estão em B”.
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach (T obj in collection)
                {
                    Console.Write(obj + " ");
                }
                Console.WriteLine();
            }
        }
}