namespace NeetCode150._01_ArraysHashing.ContainsDuplicate
{
    public class ContainsDuplicate
    {
        // 01. Brute Force
        // Compare each number with every number after it.
        // Time : O(n²)
        // Reason: Nested loops perform
        //         (n-1) + (n-2) + ... + 1 comparisons.
        // Space: O(1)
        // Reason: No extra data structure is used.
        public bool HasDuplicateBruteForceApproach(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        return true;
                }
            }

            return false;
        }

        // 02. Sorting
        // Sort the array and compare adjacent elements.
        // Duplicates become neighbors after sorting.
        // Time : O(n log n)
        // Reason: Array.Sort() takes O(n log n).
        //         The subsequent loop is O(n),
        //         so the overall complexity remains O(n log n).
        // Space: O(1)
        // Reason: No additional collection is created.
        //         (Technically Array.Sort uses a small stack internally.)
        public bool HasDuplicateSortingApproach(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }

            return false;
        }

        // 03. HashSet (Iterative)
        // Store each number in a HashSet.
        // If Add() returns false, the number already exists.
        // Time : O(n)
        // Reason: We iterate through the array once and
        //         each HashSet.Add() is O(1) on average.
        // Space: O(n)
        // Reason: In the worst case all elements are unique,
        //         so the HashSet stores n elements.
        public bool HasDuplicateHashSetApproach(int[] nums)
        {
            var seen = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!seen.Add(num))
                    return true;
            }

            return false;
        }

        // 04. HashSet One-Liner (Best Solutuon)
        // Create a HashSet from the array and compare counts.
        // If the HashSet count is smaller, duplicates existed.
        // Time : O(n)
        // Reason: The constructor adds all n elements and
        //         each insertion is O(1) on average.
        // Space: O(n)
        // Reason: The HashSet may need to store all n elements.
        public bool HasDuplicateHashSetOneLinerApproach(int[] nums)
        {
            return new HashSet<int>(nums).Count < nums.Length;
        }
    }
}
