using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptPractice
{
   public class CandiDistribution
    {

        // Function to find out the number of
        // candies every person received
       public static int[] GetCandies(int n, int k)
        {
            // Count number of complete turns
            int count = 0;
            
            // Get the last term
            int ind = 1;

            // Stores the number of candies
            int[] arr = new int[k];

            for (int i = 0; i < k; i++)
                arr[i] = 0;

            while (n > 0)
            {

                // Last term of last and
                // current series
                int f1 = (ind - 1) * k;
                int f2 = ind * k;

                // Sum of current and last series
                int sum1 = (f1 * (f1 + 1)) / 2;
                int sum2 = (f2 * (f2 + 1)) / 2;

                // Sum of current series only
                int res = sum2 - sum1;

                // If sum of current is less than N
                if (res <= n)
                {
                    count++;
                    n -= res;
                    ind++;
                }
                else // Individually distribute
                {
                    int i = 0;

                    // First term
                    int term = ((ind - 1) * k) + 1;

                    // Distribute candies till there
                    while (n > 0)
                    {
                        // Candies available
                        if (term <= n)
                        {
                            arr[i++] = term;
                            n -= term;
                            term++;
                        }
                        else // Not available
                        {
                            arr[i++] = n;
                            n = 0;
                        }
                    }
                }
            }

            // Count the total candies
            for (int i = 0; i < k; i++)
                arr[i] += (count * (i + 1)) + (k * (count * (count - 1)) / 2);

            Console.WriteLine("Input N =" + n);
            Console.WriteLine("Input K =" + k);
            // Print the total candies
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Output = " + arr[i] + " ");
            }
            return arr;
        }

    }
}
