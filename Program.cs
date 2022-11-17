using System;

namespace SherlockAndCost
{
    class Sherlock
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                Console.WriteLine(cost(arr));
            }
        }

        public static int cost(int[] B)
        {
            int[] S = new int[2];
            int[] oS = new int[2];
            for(int i = 1; i < B.Length; i++)
            {
                S[0] = Math.Max(oS[0] + Math.Abs(B[i] - B[i - 1]), oS[1] + Math.Abs(B[i] - 1));
                S[1] = Math.Max(oS[0] + Math.Abs(B[i - 1] - 1), oS[1]);
                //Console.WriteLine("idx {0} : max({1} + abs({2} - {3}), {4} + abs({5} - 1)) = {6}", i, oS[0], B[i], B[i - 1], oS[1], B[i], S[0]);
                //Console.WriteLine("idx {0} : max({1} + abs({2} - 1), {3} = {4}", i, oS[0], B[i - 1], oS[1], S[1]);
                Array.Copy(S, oS, 2);
            }
            return Math.Max(S[0], S[1]);
        }
    }
}
