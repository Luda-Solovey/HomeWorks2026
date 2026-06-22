using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    public class PagesEnumerator : IEnumerator<Page>
    {

        private readonly Page[] pages;

        private int position = -1;

        public PagesEnumerator(Page[] pages)
        {
            this.pages = pages;
        }

        public Page Current => pages[position];

        object IEnumerator.Current => pages[position];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (position < pages.Length - 1)
            {
                position++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
