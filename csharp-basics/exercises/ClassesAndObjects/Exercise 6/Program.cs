using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male");
            Dog rocky = new Dog("Rocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female");

            max.SetMother(lady);
            max.SetFather(rocky);

            coco.SetMother(molly);
            coco.SetFather(buster);

            rocky.SetMother(molly);
            rocky.SetFather(sam);

            buster.SetMother(lady);
            buster.SetFather(sparky);

            Console.WriteLine("Coco's father's name: " + coco.FathersName());
            Console.WriteLine("Sparky's father's name: " + sparky.FathersName());

            bool hasSameMother = coco.HasSameMotherAs(rocky);
            Console.WriteLine("Coco has same mother as Rocky: " + hasSameMother);
        }
    }
}