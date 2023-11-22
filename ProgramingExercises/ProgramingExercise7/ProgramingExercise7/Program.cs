namespace ProgramingExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(divisibleSumPairs(6, 2, list));
            string result = kangaroo(0, 3, 4, 2);
            Console.WriteLine(result);
            List<int> list1 = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine(sockMerchant(9, list1));
        }

        // 1 Given an array of integers and a positive integer k, determine the number of (i,j) pairs where i<j and ar[i]+ar[j] is divisible by k
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        // 2 You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction
        // (i.e, toward positive infinity). The first kangaroo starts at location  x1 and moves at a rate of  v1 meters per jump.The second kangaroo starts at
        // location x2  and moves at a rate of  v2 meters per jump. You have to figure out a way to get both kangaroos at the same location at the same time as part of
        // the show.If it is possible, return YES, otherwise return NO.

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string message = "";
            if ((x1 < x2) && (v1 <= v2))
            {
                return message = "NO"; // İlk kanguru ikinci kangurudan daha geride ve daha yavaşsa, bir daha ona yetişemez.
            }
            else if ((x1 > x2) && (v1 >= v2))
            {
                return message = "NO"; // İkinci kanguru ilk kangurudan daha geride ve daha yavaşsa, bir daha ona yetişemez.
            }
            else if ((x1 != x2) && (v1 == v2))
            {
                return message = "NO"; // Hızları aynı ancak başlangıç konumları farklı ise bir daha birbirine yetişemezler.
            }
            else if ((x2 - x1) % (v1 - v2) == 0)
            {
                return message = "YES"; // Diğer durumlarda, bir zamanlar aynı konuma gelebilirler.
            }
            else
            {
                return message = "NO";
            }

        }

        // 3 There is a large pile of socks that must be paired by color. Given an array of integers
        // representing the color of each sock, determine how many pairs of socks with matching colors there are.

        public static int sockMerchant(int n, List<int> ar)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] == ar[j] && ar[i] != -1)
                    {
                        ar[j] = -1;
                        counter++;
                    }
                }
                if (counter != 1 && counter % 2 == 0)
                {
                    result += (counter / 2);
                }
                if (counter != 1 && counter % 2 != 0)
                {
                    result += ((counter - 1) / 2);
                }
            }
            return result;
        }
    }
}
