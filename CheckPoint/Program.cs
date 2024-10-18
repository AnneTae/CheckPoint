using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Task 1
        //CustomStack<string> stack = new CustomStack<string>();

        //stack.Push("apple");
        //stack.Push("banana");
        //stack.Push("cherry");

        //Console.WriteLine(stack.Peek());
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Count);

        //stack.Clear();
        //Console.WriteLine(stack.IsEmpty());


        //stack.Push("number");
        //stack.Push("yellow");

        //List<string> items = stack.ToList();
        //Console.WriteLine(string.Join(", ", items));


        // Task 2
        int[] array = { 35, 20, 55, 3, 10, 80, 40 };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", array));

        MergeSort.Sort(array);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", array));

    }
}
//public class Stack<T>
//{
//    public T Value { get; set; }
//    public Stack<T> Next { get; set; }

//    public Stack(T value)
//    {
//        Value = value;
//        Next = null;
//    }
//}

//public class CustomStack<T>
//{
//    private Stack<T> _top;
//    private int _count;

//    public CustomStack()
//    {
//        _top = null;
//        _count = 0;
//    }

//    public void Push(T item)
//    {
//        Stack<T> newNode = new 
//            Stack<T>(item)
//        {
//            Next = _top
//        };
//        _top = newNode;
//        _count++;
//    }

//    public T Pop()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("Stack is empty.");
//        }
//        T value = _top.Value;
//        _top = _top.Next;
//        _count--;
//        return value;
//    }

//    public T Peek()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("Stack is empty.");
//        }
//        return _top.Value;
//    }

//    public bool IsEmpty() => _top == null;

//    public int Count => _count;

//    public void Clear()
//    {
//        _top = null;
//        _count = 0;
//    }

//    public List<T> ToList()
//    {
//        List<T> items = new List<T>();
//        Stack<T> current = _top;
//        while (current != null)
//        {
//            items.Add(current.Value);
//            current = current.Next;
//        }
//        return items;
//    }
//}

public class MergeSort
{
    public static void Sort(int[] array)
    {
        if (array.Length < 2)
            return;

        int mid = array.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        Sort(left);
        Sort(right);

        Merge(array, left, right);
    }

    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k++] = left[i++];
            }
            else
            {
                array[k++] = right[j++];
            }
        }


        while (i < left.Length)
        {
            array[k++] = left[i++];
        }

        while (j < right.Length)
        {
            array[k++] = right[j++];
        }
    }
}


