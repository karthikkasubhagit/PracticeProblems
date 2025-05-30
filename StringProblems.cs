using System.Security.Cryptography.X509Certificates;

namespace PracticeProblems
{
    public class StringProblems
    {
        // Given a string, print the count of upper case characters

        public int CountUpper(string input)
        {
            int count = 0;
            int a = 'A';
            int b = 'Z';
            foreach (char c in input)
            {
                int C = c;
                if (C >= a &&  C <= b)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
