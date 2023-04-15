using System;
using System.Collections.Generic;

class Program
{
    public static int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> D = new Dictionary<int,int>();
        
        for(int i=0; i< nums.Length; i++)
        {
            int val = target-nums[i];
            if(D.ContainsKey(val) && D[val] !=i)
            {
                return new int[] {i, D[val]};
            }
            D[nums[i]] = i;
        }
        return null;
    }
    static void Main()
    {
        int[] A = {2,11,15,7};
        int[] B = TwoSum(A,9);
        Console.WriteLine(B[0] + "," + B[1]);
    }
}
