using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    public class Page
    {
        public Page(uint number, string text)
        {
            Number = number;
            Text = text;
        }
        public string Text { get; } = string.Empty;
        public uint Number { get; }
    }
}