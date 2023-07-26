namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string class1 = "English III";
            string class2 = "Precalculus";
            string class3 = "Music Theory";
            string class4 = "Biotechnology";
            string class5 = "Principles of Technology I";
            string class6 = "Latin II";
            string class7 = "AP US History";
            string class8 = "Business Computer Information Systems";

            string teacher1 = "Ms. Lapan";
            string teacher2 = "Mrs. Gideon";
            string teacher3 = "Mr. Davis";
            string teacher4 = "Ms. Palmer";
            string teacher5 = "Ms. Garcia";
            string teacher6 = "Mrs. Barnett";
            string teacher7 = "Ms. Johannessen";
            string teacher8 = "Mr. James";

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("| # | Class Name                  | Teacher Name    |");
            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("| 1 | " + class1.PadRight(26) + " | " + teacher1.PadRight(15) + " |");
            Console.WriteLine("| 2 | " + class2.PadRight(26) + " | " + teacher2.PadRight(15) + " |");
            Console.WriteLine("| 3 | " + class3.PadRight(26) + " | " + teacher3.PadRight(15) + " |");
            Console.WriteLine("| 4 | " + class4.PadRight(26) + " | " + teacher4.PadRight(15) + " |");
            Console.WriteLine("| 5 | " + class5.PadRight(26) + " | " + teacher5.PadRight(15) + " |");
            Console.WriteLine("| 6 | " + class6.PadRight(26) + " | " + teacher6.PadRight(15) + " |");
            Console.WriteLine("| 7 | " + class7.PadRight(26) + " | " + teacher7.PadRight(15) + " |");
            Console.WriteLine("| 8 | " + class8.PadRight(26) + " | " + teacher8.PadRight(15) + " |");
            Console.WriteLine("+------------------------------------------------------------+");
        }
    }
}