using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, PhoneEntry> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, PhoneEntry>();
        }

        public string GetNumber(string name)
        {
            if (_data.TryGetValue(name, out var entry))
            {
                return entry.number;
            }
            return null;
        }

        public void PutNumber(string name, string number)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number))
            {
                throw new Exception("name and number cannot be null or empty");
            }

            if (_data.ContainsKey(name))
            {
                _data[name].number = number;
            }
            else
            {
                var newEntry = new PhoneEntry { name = name, number = number };
                _data.Add(name, newEntry);
            }
        }
    }
}