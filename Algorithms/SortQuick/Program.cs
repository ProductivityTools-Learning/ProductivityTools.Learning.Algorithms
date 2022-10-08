// See https://aka.ms/new-console-template for more information
using SortQuick;

Console.WriteLine("Hello, World!");

int[] a =new int[4];
a[0] = 3;
a[1] = 2;
a[2] = 1;
a[3] = 0;
//a[4] = 6;
//a[5] = 9;
//a[6] = 2;
//a[7] = 5;
//a[8] = 4;
//a[9] = 2;

QuickSort quickSort = new QuickSort();    
quickSort.Sort(a);
Print(a);
Console.ReadLine();

static void Print(int[] a)
{
    foreach (var item in a)
    {
        Console.Write(item);
    }
    Console.WriteLine();
}


