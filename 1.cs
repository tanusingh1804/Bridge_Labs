using System;
using System.Collections;

class Program
{
    static void ReverseArrayList(ArrayList list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    static void Main()
    {
        ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
        ReverseArrayList(list);

        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}
