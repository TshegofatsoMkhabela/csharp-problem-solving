using System;

// Example input
int[] nums = { 3, 3, 4, 7, 11, 15, -2, 9, 4, 6, -1 };
int target = 13;

// Get the solution
int[] solution = TwoSum(nums, target);

// Print the solution
Console.WriteLine($"The indeces of your TwoSum solution are [{string.Join(",", solution)}]");

int[]? TwoSum(int[] nums, int target)
{
    // Get the length of the input list
    int listLength = nums.Length;

    for (int i = 0; i<listLength; i++)
    {
        int gapToTarget = target - nums[i];

        // Look for the gap in the rest of the list
        int j = Array.IndexOf(nums, gapToTarget, i + 1);

        // If we found a valid answer, return the indeces
        if (j != -1)
        {
            return [i, j];
        }
    }
    return null;
}
