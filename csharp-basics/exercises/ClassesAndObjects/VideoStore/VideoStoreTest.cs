using System;

namespace VideoStore
{

    class VideoStoreTest
    {
        private static VideoStore store = new VideoStore();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
                Console.WriteLine("Choose 5 to rate a video");

                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        RateVideo();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            Console.WriteLine("Inventory:");
            store.ListInventory();
        }

        private static void FillVideoStore()
        {
            Console.WriteLine("Enter video title:");
            string title = Console.ReadLine();
            store.AddVideo(title);
            Console.WriteLine($"Video '{title}' added to inventory.");
        }

        private static void RentVideo()
        {
            Console.WriteLine("Enter video title:");
            string title = Console.ReadLine();
            if (store.CheckOutVideo(title))
            {
                Console.WriteLine($"Video '{title}' rented.");
            }
            else
            {
                Console.WriteLine($"Video '{title}' not found or already rented.");
            }
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("Enter video title:");
            string title = Console.ReadLine();
            if (store.ReturnVideo(title))
            {
                Console.WriteLine($"Video '{title}' returned.");
            }
            else
            {
                Console.WriteLine($"Video '{title}' not found or not rented.");
            }
        }

        private static void RateVideo()
        {
            Console.WriteLine("Enter video title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter rating (1 to 5):");
            int rating = Convert.ToInt32(Console.ReadLine());

            if (rating < 1 || rating > 5)
            {
                Console.WriteLine("Invalid rating. Please enter a rating between 1 and 5.");
                return;
            }

            store.RateVideo(title, rating);
            Console.WriteLine($"Rating {rating} added for video '{title}'.");
        }
    }
}