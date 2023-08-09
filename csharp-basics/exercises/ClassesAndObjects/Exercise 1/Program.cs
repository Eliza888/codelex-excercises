namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", 70.00, 14);
            Product iphone = new Product("iPhone 5s", 999.99, 3);
            Product projector = new Product("Epson EB-U05", 440.46, 1);

            mouse.PrintProduct();
            iphone.PrintProduct();
            projector.PrintProduct();

            Console.WriteLine();

            mouse.ChangeQuantity(20);
            iphone.ChangePrice(899.99);
            projector.ChangeQuantity(2);

            mouse.PrintProduct();
            iphone.PrintProduct();
            projector.PrintProduct();
        }
    }
}