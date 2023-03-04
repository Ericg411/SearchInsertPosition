namespace SearchInsertPosition;
public class Class1
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Contains(target))
        {
            return Array.IndexOf(nums, target);
        }

        for (int i = 0; i <= nums.Length; i++)
        {
            if (nums[i] > target)
            {
                return i;
            }
            else if (i == nums.Length - 1)
            {
                return nums.Length;
            }

        }

        return 0;
    }
}
