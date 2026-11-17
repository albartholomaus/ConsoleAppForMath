public class Sorting
{
    public static int[] MergeSort(int[] arr)
    {
        ArgumentNullException.ThrowIfNull(arr);
        int[] temp = new int[arr.Length];
        MergeSort(arr, temp, 0, arr.Length - 1);
        return arr;
    }

    private static void MergeSort(int[] arr, int[] temp, int start, int end)
    {
        if (start >= end) return;

        int mid = start + (end - start) / 2;
        MergeSort(arr, temp, start, mid);
        MergeSort(arr, temp, mid + 1, end);
        Merge(arr, temp, start, mid, end);
    }

    private static void Merge(int[] arr, int[] temp, int start, int mid, int end)
    {
        Array.Copy(arr, start, temp, start, end - start + 1);

        int left = start;
        int right = mid + 1;

        for (int i = start; i <= end; i++)
        {
            if (left > mid)
            {
                arr[i] = temp[right++];
            }
            else if (right > end)
            {
                arr[i] = temp[left++];
            }
            else if (temp[left] <= temp[right])
            {
                arr[i] = temp[left++];
            }
            else
            {
                arr[i] = temp[right++];
            }
        }
    }

    public static int[] QuickSorting(int[] arr)
    {
        ArgumentNullException.ThrowIfNull(arr);
        QuickSorting(arr, 0, arr.Length - 1);
        return arr;
    }

    private static void QuickSorting(int[] arr, int start, int end)
    {
        if (start >= end) return;

        int pivot = arr[end];
        int left = start;

        for (int i = start; i < end; i++)
        {
            if (arr[i] < pivot)
            {
                (arr[left], arr[i]) = (arr[i], arr[left]);
                left++;
            }
        }

        // The pivot is now in its final sorted position.
        (arr[left], arr[end]) = (arr[end], arr[left]);

        QuickSorting(arr, start, left - 1);
        QuickSorting(arr, left + 1, end);
    }


    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);
    }

    public int Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        int mid = 0;

        while (left <= right)
        {
            mid = (left + right) / 2;
            if (target > nums[mid])
            {
                left = mid + 1;
            }
            else if (target < nums[mid])
            {
                right = mid - 1;
            }
            else return mid;

        }
        return -1;
    }





}
