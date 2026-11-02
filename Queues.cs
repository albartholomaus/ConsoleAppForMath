public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        int sandwichPointer = 0;
        int rejected = 0;
        Queue<int> studentQueue = new Queue<int>(students);

        while (sandwiches.Length >= sandwichPointer - 1 && studentQueue.Count() > 0 && rejected < studentQueue.Count())
        {
            int student = studentQueue.Dequeue();

            if (student != sandwiches[sandwichPointer])
            {
                studentQueue.Enqueue(student);
                rejected++;

            }
            else
            {
                sandwichPointer++;
                rejected = 0;
            }

        }
        return studentQueue.Count();
    }
}
public class MyStack
{
    int top;
    Queue<int> queueStack1;
    Queue<int> queueStack2;

    public MyStack()
    {
        
        queueStack1 = new();
        queueStack2 = new();
    }

    public void Push(int x)
    {
        queueStack1.Enqueue(x);
        top = x;
    }

    public int Pop()
    {
        while (queueStack1.Count != 1)
        {
            top = queueStack1.Dequeue();
            queueStack2.Enqueue(top);
        }
        (queueStack1, queueStack2) = (queueStack2, queueStack1);
        return queueStack2.Dequeue();
    }

    public int Top()
    {
        return top;
    }

    public bool Empty()
    {
        bool isEmpty = queueStack1.Count() == 0;
        return isEmpty;
    }
}

//queue1 push 