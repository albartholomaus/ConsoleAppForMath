using System.Transactions;

public class LinkedLists
{
    public ListNode ReverseList(ListNode? head)
    {
        ListNode? previous = null;

        while (head != null)
        {
            ListNode? temp = head.next;
            head.next = previous;
            previous = head;
            head = temp;
        }
        return previous;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new();
        ListNode returnList = head;

        while (list1 != null || list2 != null)
        {
            if (list1 == null)
            {
                head.next = list2;
                break;
            }

            else if (list2 == null)
            {
                head.next = list1;
                break;
            }

            if (list1.val <= list2.val)
            {
                head.next = list1;
                list1 = list1.next;
            }
            else if (list2.val <= list1.val)
            {
                head.next = list2;
                list2 = list2.next;

            }
            head = head.next;
        }
        return returnList.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    public ListNode CreateLinklist()
    {
        ListNode head = new(0);
        ListNode current = head;

        for (int i = 1; i < 5; i++)
        {
            current.next = new(i);
            current = current.next;
        }
        return head;
    }



}

public class MyLinkedList
{
    DoubleListNode head = new();
    DoubleListNode tail = new(-1);
    public MyLinkedList()
    {
        head.next = tail;
        tail.prev = head;
    }

    public int Get(int index)
    {
        DoubleListNode toReturnNode = FindNode(index);
        return toReturnNode.val;
    }

    public void AddAtHead(int val)
    {
        DoubleListNode newNode = new(val);
        DoubleListNode temp = head.next;

        head.next = newNode;
        newNode.prev = head;
        newNode.next = temp;
        temp.prev = newNode;
    }

    public void AddAtTail(int val)
    {

        DoubleListNode newNode = new(val);
        DoubleListNode temp = tail.prev;

        tail.prev = newNode;
        newNode.next = tail;
        newNode.prev = temp;
        temp.next = newNode;
    }

    public void AddAtIndex(int index, int val)
    {
        DoubleListNode newNode = new(val);
        DoubleListNode current = FindNode(index);
        DoubleListNode temp = current.prev;

        temp.next = newNode;
        newNode.prev = temp;
        newNode.next = current;
        current.prev = newNode;
    }

    public void DeleteAtIndex(int index)
    { //       to delete ==2, temp = 3 

        DoubleListNode toDelete = FindNode(index);
        if (toDelete.val != -1)
        {
            DoubleListNode pre = toDelete.prev;
            DoubleListNode post = toDelete.next;

            pre.next = post;
            post.prev = pre;
        }


    }
    private DoubleListNode FindNode(int val)
    {
        DoubleListNode current = head.next;
        for (int i = 0; i < val; i++)
        {
            current = current.next;
            if (current == tail)
            {
                return tail;
            }
        }
        return current;
    }
}

public class BrowserHistory
{
    DoubleListBrowser head = new();
    DoubleListBrowser tail = new();
    DoubleListBrowser currentPage = new();

    public BrowserHistory(string homepage)
    {
        head.url = homepage;
        head.next = tail;
        tail.prev = head;
        currentPage = head;
    }

    public void Visit(string url)
    {       //currentpage, new page, tail 
        DoubleListBrowser newPage = new(url);

        currentPage.next = newPage;
        newPage.prev = currentPage;
        tail.prev = newPage;
        newPage.next = tail;

        currentPage = newPage;
    }

    public string Back(int steps)
    {
        DoubleListBrowser current = currentPage;

        for (int i = 0; i < steps; i++)
        {
            if (current.url == head.url) return head.url;
            current = current.prev;

        }
        currentPage = current;
        return current.url;
    }

    public string Forward(int steps)
    {
        DoubleListBrowser current = currentPage;

        for (int i = 0; i < steps; i++)
        {
            current = current.next;

            if (current.url == tail.url)
            {
                currentPage = current.prev;
                return currentPage.url;
            }
        }
        currentPage = current;
        return currentPage.url;
    }
}



public class DoubleListBrowser
{
    public DoubleListBrowser prev;
    public DoubleListBrowser next;
    public string url = null;

    public DoubleListBrowser(string url = null, DoubleListBrowser prev = null, DoubleListBrowser next = null)
    {
        this.url = url;
        this.prev = prev;
        this.next = next;
    }
}




public class DoubleListNode
{
    public DoubleListNode prev;
    public DoubleListNode next;
    public int val;

    public DoubleListNode(int val = 0, DoubleListNode prev = null, DoubleListNode next = null)
    {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}
