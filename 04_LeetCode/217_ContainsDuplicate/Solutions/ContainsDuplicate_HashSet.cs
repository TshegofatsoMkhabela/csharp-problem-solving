using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainsDuplicateApp.Solutions
{
    public static class ContainsDuplicate_HashSet
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            // Using HashSet to track unique elements
            HashSet<int> uniqueNums = new HashSet<int>(nums);

            // If the count of unique elements is less than the original array length, duplicates exist
            return uniqueNums.Count != nums.Length;
        }
    }
}
