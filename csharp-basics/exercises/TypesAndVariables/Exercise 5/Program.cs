namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] classNames = {
            "English III",
            "Precalculus",
            "Music Theory",
            "Biotechnology",
            "Principles of Technology I",
            "Latin II",
            "AP US History",
            "Business Computer Information Systems"
        };

            string[] teacherNames = {
            "Ms. Lapan",
            "Mrs. Gideon",
            "Mr. Davis",
            "Ms. Palmer",
            "Ms. Garcia",
            "Mrs. Barnett",
            "Ms. Johannessen",
            "Mr. James"
        };

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("| 1 | " + classNames[0].PadRight(26) + " | " + teacherNames[0].PadRight(15) + " |");
            Console.WriteLine("| 2 | " + classNames[1].PadRight(26) + " | " + teacherNames[1].PadRight(15) + " |");
            Console.WriteLine("| 3 | " + classNames[2].PadRight(26) + " | " + teacherNames[2].PadRight(15) + " |");
            Console.WriteLine("| 4 | " + classNames[3].PadRight(26) + " | " + teacherNames[3].PadRight(15) + " |");
            Console.WriteLine("| 5 | " + classNames[4].PadRight(26) + " | " + teacherNames[4].PadRight(15) + " |");
            Console.WriteLine("| 6 | " + classNames[5].PadRight(26) + " | " + teacherNames[5].PadRight(15) + " |");
            Console.WriteLine("| 7 | " + classNames[6].PadRight(26) + " | " + teacherNames[6].PadRight(15) + " |");
            Console.WriteLine("| 8 | " + classNames[7].PadRight(26) + " | " + teacherNames[7].PadRight(15) + " |");
            Console.WriteLine("+------------------------------------------------------------+");
        }
    }
}