public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                int tar = nums[i] + nums[j];
                if (target == tar)
                {
                    Console.WriteLine($"Index 1: {i}, Index 2: {j}");

                    // Return the indices of the two numbers
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No two sum solution found");

    }


    public static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int[] nums = new int[size];
        Console.WriteLine("nums: ");
        for (int i = 0; i < size; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int target = int.Parse(Console.ReadLine());
        Solution solution = new Solution();
        try
        {
            int[] result = solution.TwoSum(nums, target);

            // Output the result
            Console.WriteLine($"Indices of the two numbers that add up to {target} are: {result[0]} and {result[1]}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
