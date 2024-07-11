public class NextNumber
{
    /*
    NextNumber

    Given an input array (A) of N elements, and a target integer K, write a method that will:
    - find the smallest number greater than K which is not present in the given array.
    */

    public static void Main(string[] args)
    {
        int[] Ns = {7, 3, 1, 2};
        List<int[]> As = new List<int[]>();
        As.Add([1, 2, 3, 4, 5, 6, 7]);
        As.Add([2, 4, 6]);
        As.Add([3]);
        As.Add([4, 5]);
        int[] Ks = {4, 4, 4, 2};
        int[] answers = {8, 5, 5, 3};

        for (int i = 0; i < Ns.Length; i ++)
        {
            int result = notInArray(Ns[i], As[i], Ks[i]);
            Console.WriteLine((result == answers[i]) ? "Pass" : "Fail");
        }
    }

    static int notInArray(int N, int[] A, int K)
    {
        return -1;
    }
}