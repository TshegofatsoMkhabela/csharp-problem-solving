using System;
using ContainsDuplicateApp.Solutions;

namespace ContainsDuplicateApp
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 1, 2, 1, 2, 3, 4, 5 };

            // Call List-based solution
            bool listResult = ContainsDuplicate_List.ContainsDuplicate(nums);
            Console.WriteLine($"List method: duplicates exist? {listResult}");

            // Call HashSet-based solution
            bool hashSetResult = ContainsDuplicate_HashSet.ContainsDuplicate(nums);
            Console.WriteLine($"HashSet method: duplicates exist? {hashSetResult}");
        }
    }
}
