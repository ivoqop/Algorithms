using Algorithms;

#region BinarySearch
/*
Console.WriteLine("Insert int numbers: ");
int[] array = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
Console.WriteLine("Insert target number: ");
int target = Console.ReadLine().Split(",").Select(int.Parse).First();

Search search = new Search();
int result = search.BinarySearch(array, target);

Console.WriteLine("target number on index: " + result);*/

#endregion

#region SelectionSort

var array = new int[] { 64, 25, 12, 22, 11 };

Console.WriteLine("Antes da ordenação: " + string.Join(", ", array));

var sorter = new Sort();
sorter.SelectionSort(array);

Console.WriteLine("Depois da ordenação: " + string.Join(", ", array));

#endregion

