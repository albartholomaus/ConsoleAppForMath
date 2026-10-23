using System.Runtime.InteropServices;

namespace ConsoleAppForMath;

public class MyArray
{
    public void RemoveMiddle(int[] arr, int i, int length)
    {
        // Shift starting from i + 1 to end.
        for (int index = i + 1; index < length; index++)
        {
            arr[index - 1] = arr[index];
        }
        // No need to 'remove' arr[i], since we already shifted
    }
    public void InsertInTheMiddle(int[] arr, int i, int n, int length)
    {
        for (int index = length - 1; index > i - 1; i--)
        {
            arr[index + 1] = arr[index];
        }

        arr[i] = n;
    }


    public int FindMaxConsecutiveOnes1(int[] nums)
    {
        int highCount = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                if (count > highCount) highCount = count;
            }
            else count = 0;

        }
        return highCount;
    }

    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int highCount = 0, count = 0;

        foreach (var num in nums)
        {
            count = (num == 1) ? count + 1 : 0;

            highCount = Math.Max(count, highCount);
        }
        return highCount;
    }

    public int RemoveElement(int[] nums, int val)
    {
        // nums = [0, 1, 2, 2, 3, 0, 4, 2]
        //val = 2
        //move everything that is not 2 to the front
        //return the number of elements not equal to val 
        int frontPointer = 0, backPointer = nums.Length - 1;

        while (frontPointer <= backPointer)
        {
            if (nums[backPointer] == val)
            {
                backPointer--;
            }
            else if (nums[frontPointer] == val)
            {
                (nums[frontPointer], nums[backPointer]) = (nums[backPointer], nums[frontPointer]);
                frontPointer++;
                backPointer--;
            }
            else if (nums[frontPointer] != val)
            {
                frontPointer++;
            }
        }
        return frontPointer;
    }

    public int[] ReplaceElements(int[] arr)
    {
        int largentNumber = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (largentNumber < arr[j]) largentNumber = arr[j];
            }
            arr[i] = largentNumber;
            largentNumber = 0;
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }

    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = new int[nums.Length * 2];
        for (int i = 0; i < ans.Length / 2; i++)
        {
            ans[i] = nums[i];
            ans[nums.Length + i] = nums[i];
        }
        return ans;
    }
}



