using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomeWork2
{
    public class Publisher
    {
        public string Name { get; }

        public required string Country { get; init; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public uint EstablishYear { get; set; }

        public Publisher(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Publisher name cannot be null or empty.");
            }
            Name = name;

        }
    }
}
