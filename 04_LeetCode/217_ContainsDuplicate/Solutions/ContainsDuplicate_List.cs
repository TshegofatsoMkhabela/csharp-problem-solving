using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainsDuplicateApp.Solutions
{
    public static class ContainsDuplicate_List
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            // Convert array to List for easier manipulation
            List<int> numsList = nums.ToList();


            // Loop through the array, remove the current number from the list, and check if it still exists to detect duplicates.
            // Stop one element before the end to avoid unnecessary checks
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int currentNum = nums[i];
                numsList.Remove(currentNum);
                if (numsList.Contains(currentNum))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
