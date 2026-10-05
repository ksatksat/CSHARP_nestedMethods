using System;
namespace NestedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app shows how methods can "
            + "\nbe nested one inside other.");
            int[] nums1 = { 1, 13, 65, 321, 12, 2 };
            int[] nums2 = { 88, 23, 4, 1, 300, 2 };
            NMethod nMethod = new NMethod();
            nMethod.Compare(nums1, nums2);
        }
    }
    class NMethod
    {
        public void Compare(int[] nums1, int[] nums2)
        {
            int nums1Sum = Sum(nums1);
            int nums2Sum = Sum(nums2);
            if (nums1Sum > nums2Sum)
            {
                Console.WriteLine("Sum of 1st array is bigger than sum of second");
            }
            else if (nums1Sum < nums2Sum)
            {
                Console.WriteLine("Sum of 2nd array is bigger than sum of first");
            }
            else
            {
                Console.WriteLine("The sum of two arrays are similar");
            }
            int Sum(int[] nums)
            {
                int result = 0;
                foreach (int n in nums)
                {
                    result += n;
                }
                return result;
            }
        }
    }
}