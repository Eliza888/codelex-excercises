using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public string Title { get; }
        public bool CheckedOut { get; private set; }
        private List<int> _ratings;

        public Video(string title)
        {
            Title = title;
            CheckedOut = false;
            _ratings = new List<int>();
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
            _ratings.Add(rating);
        }

        public double GetAverageRating()
        {
            if (_ratings.Count == 0)
                return 0;

            double sum = 0;
            foreach (int rating in _ratings)
            {
                sum += rating;
            }
            
            return sum / _ratings.Count;
        }
    }
}