RecursionClass rec = new();

ListNode head = new(0, new(1, new(2, new(3))));
ListNode? reversedHead = rec.ReverseListIteritive(head);

for (ListNode? current = reversedHead; current != null; current = current.next)
{
    Console.Write(current.val);
    Console.Write(current.next == null ? Environment.NewLine : " -> ");
}

int[] numbers = { 5, 2, 9, 1, 5, 6 };
Sorting.MergeSort(numbers);
Console.WriteLine(string.Join(", ", numbers));

int[] nums1 = { 10, 20, 20, 40, 0, 0 };
int[] nums2 = { 1, 2 };
Sorting.Merge(nums1, 4, nums2, 2);
Console.WriteLine(string.Join(", ", nums1));

int stop=0;
