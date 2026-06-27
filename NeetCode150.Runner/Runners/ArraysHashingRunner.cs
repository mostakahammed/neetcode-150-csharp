using NeetCode150._01_ArraysHashing.ContainsDuplicate;

namespace NeetCode150.Runner.Runners
{
    public static class ArraysHashingRunner
    {
        public static void Run()
        {
            ContainsDuplicateRunner();
        }

        private static void ContainsDuplicateRunner()
        {
            var s = new ContainsDuplicate();

            Console.WriteLine($" BruteForece       [1,2,3,1]                    => {s.HasDuplicateBruteForceApproach(new[] { 1, 2, 3, 1 })}");
            Console.WriteLine($" Sorting           [1,2,3,4]                    => {s.HasDuplicateSortingApproach(new[] { 1, 2, 3, 4 })}");
            Console.WriteLine($" HashSet           [1, 1, 1, 3, 3, 4, 3, 2]     => {s.HasDuplicateHashSetApproach(new[] { 1, 1, 1, 3, 3, 4, 3, 2 })}");
            Console.WriteLine($" HashSetOneLiner   [1, 1, 3, 8, 4, 3, 9]        => {s.HasDuplicateHashSetOneLinerApproach(new[] { 1, 1, 3, 8, 4, 3, 9 })}");
            Console.WriteLine();
        }
    }
}
