using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public string Title { get; }
        public bool CheckedOut { get; private set; }
        private List<int> Ratings;

        public Video(string title)
        {
            Title = title;
            CheckedOut = false;
            Ratings = new List<int>();
        }

        public bool CheckOut()
        {
            if (!CheckedOut)
            {
                CheckedOut = true;
                return true;
            }
            return false;
        }

        public bool ReturnVideo()
        {
            if (CheckedOut)
            {
                CheckedOut = false;
                return true;
            }
            return false;
        }

        public void ReceiveRating(int rating)
        {
            Ratings.Add(rating);
        }

        public double GetAverageRating()
        {
            if (Ratings.Count == 0)
                return 0;

            double sum = 0;
            foreach (int rating in Ratings)
            {
                sum += rating;
            }
            return sum / Ratings.Count;
        }
    }
}