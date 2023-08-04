namespace Exercise_9
{
    internal class Program
    {
        static string[] CapMe(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1).ToLower();
            }

            return names;
        }

        static void Main(string[] args)
        {
            string[] names1 = { "mavis", "senaida", "letty" };
            string[] names2 = { "samuel", "MABELLE", "letitia", "meridith" };
            string[] names3 = { "Slyvia", "Kristal", "Sharilyn", "Calista" };

            string[] result1 = CapMe(names1);
            string[] result2 = CapMe(names2);
            string[] result3 = CapMe(names3);

            Console.WriteLine(string.Join(", ", result1));
            Console.WriteLine(string.Join(", ", result2));
            Console.WriteLine(string.Join(", ", result3));
        }
    }
}