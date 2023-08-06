namespace Exercise_11
{
    internal class Program
    {
        static string FindNemo(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                    if (words[i].ToLower() == "nemo")
                    {
                        return $"I found Nemo at {i + 1}!";
                    }
                }

                return "I can't find Nemo :(";
            }

            static void Main(string[] args)
        {
            Console.WriteLine(FindNemo("I am finding the fish NEMO deep in the ocean Nemo !"));
            Console.WriteLine(FindNemo("Nemo is me"));
            Console.WriteLine(FindNemo("I Nemo am"));
            Console.WriteLine(FindNemo("Just a random sentence"));
        }
    }
}