namespace LeetCode
{
    public static class Solution
    {
        public static void Rotate(int[] nums, int k) 
        {
            while(nums.Length < k)
                k -= nums.Length;

            if (k > 0)
            {
                int[] ints = new int[nums.Length];
                k = nums.Length - k;

                for (int i = 0; i < nums.Length; i++)
                {
                    ints[i] = nums[k + i];
                    if ((k + i) == (nums.Length - 1))
                        k = -(i + 1);
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = ints[i];
                }
            }
        }
    }
}
