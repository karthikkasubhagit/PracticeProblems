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
            int z = 'Z';

            // shorter way input.Count(c => c >= a && c <= z);
            foreach (char c in input)
            {
                int C = c;
                if (C >= a &&  C <= z)
                {
                    count++;
                }
            }

            return count;
           
        }
    }
}
