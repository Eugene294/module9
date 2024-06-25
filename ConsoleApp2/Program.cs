using ConsoleApp2;
using System;
using System.Collections;

public class Program
{
    public delegate void SortDel(string[] names, int a);
    public event SortDel? Notify;
    public static void Main(string[] args)
    {
        string[] names = ["Иванов", "Петров", "Кузнецов", "Сидоров", "Александров"];

        Sorting sorting = new Sorting(names);
        sorting.Notify += Sort;
        sorting.Sort(sorting.names, 2);



        foreach (string i in names) {
            Console.WriteLine(i);
        }
        
    }
    


public static void Sort(string [] names, int a)
{
    switch (a)
    {
        case 1:
            Array.Sort(names);
            break;
        case 2:
            Array.Sort(names);
            Array.Reverse(names);
            break;
        default:
            Console.WriteLine("Должны быть введены 1 или 2");
            break;
    }


}
}
