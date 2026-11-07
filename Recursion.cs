public class Recursion
{

    public static int FactorialOfNumbers(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return number = number * FactorialOfNumbers(number - 1);
    }

}

public partial class RecursionClass
{
    // Reverse the list starting at head; ? allows an empty list (null).
    public ListNode? ReverseList(ListNode? head)
    {
        // head == null covers and epmpt list, head.next is the true base case. 
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode next = head.next;// need to move down the list
        ListNode newHead = ReverseList(next);//new haed as we call back up this is a l;ike a temp for iteration because it would be next.next.
        next.next = head; // the reason for head here is it take to 2 nodes we should now have 
        head.next = null;//because we are moving head the back, we are now neening to kill the like between the prev node and the 
        return newHead;
    }

    public ListNode? ReverseListIteritive(ListNode? head)
    {
        ListNode current = head;
        ListNode prev = null;

        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }

    public static int FibonacciSeries(int number)
    {
        if (number <= 1) return number;

        return FibonacciSeries(number - 1) + FibonacciSeries(number - 2);
    }

    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }
}
// 0 = current
// 1 with current.next