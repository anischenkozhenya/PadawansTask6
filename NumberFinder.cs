using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {

        public static int? NextBiggerThan(int number)
        {
            int newnumber;
            int n = 0;
            if (number < 9)
            {
                throw new NotImplementedException();
            }
            void swap(char[] arr, int a, int b)
            {
                char temp = arr[a];
                arr[a] = arr[b];
                arr[b] = temp;
            }
            char[] num = number.ToString().ToCharArray();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    return null;
                }
                if (num[i] > num[i - 1])
                {
                    n = i;
                    break;
                }
            }
            char x = num[n - 1];
            int smallest = n;
            for (int j = n; j < num.Length; j++)
            {
                if (num[j] > x && num[j] < num[smallest])
                {
                    smallest = j;

                }
            }
            swap(num, smallest, n - 1);
            for (int k = 0; k < num.Length; k++)
            {
                Console.WriteLine(num[k]);
            }
            bool checker = false;
            do
            {
                for (int h = n + 1; h < num.Length; h++)
                {
                    if (num[h] < num[h - 1])
                    {
                        swap(num, h, h - 1);
                        checker = true;
                        break;
                    }
                    if (num[h] >= num[h - 1] && h == num.Length - 1)
                    {
                        checker = false;
                    }
                }

            } while (checker == true);
            newnumber = int.Parse(new string(num));
            return newnumber;
        }

    }
}

