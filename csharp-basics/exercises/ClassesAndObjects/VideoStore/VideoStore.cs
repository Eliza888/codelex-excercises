using System.Collections.Generic;
using System;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> Inventory;

        public VideoStore()
        {
            Inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            Inventory.Add(new Video(title));
        }

        private Video FindVideoByTitle(string title)
        {
            return Inventory.Find(v => v.Title == title);
        }

        public bool CheckOutVideo(string title)
        {
            Video video = FindVideoByTitle(title);
            if (video != null && !video.CheckedOut)
            {
                return video.CheckOut();
            }
            return false;
        }

        public bool ReturnVideo(string title)
        {
            Video video = FindVideoByTitle(title);
            if (video != null && video.CheckedOut)
            {
                return video.ReturnVideo();
            }
            return false;
        }

        public void RateVideo(string title, int rating)
        {
            Video video = FindVideoByTitle(title);
            if (video != null)
            {
                video.ReceiveRating(rating);
            }
        }

        public void ListInventory()
        {
            foreach (var video in Inventory)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Average Rating: {video.GetAverageRating()}");
                Console.WriteLine($"Checked Out: {(video.CheckedOut ? "Yes" : "No")}");
            }
        }
    }
}