using System.Collections;

namespace Theory
{
    class MonthCollection : IEnumerable
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "Jily", "August", "September", "October", "November", "December" };

        public IEnumerator GetEnumerator()
        {
            foreach(string element in months)
            {
                yield return element;
            }
        }
    }
}
