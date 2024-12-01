using Algorithms;

Console.WriteLine("Insert int numbers: ");
int[] array = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
Console.WriteLine("Insert target number: ");
int target = Console.ReadLine().Split(",").Select(int.Parse).First();

BinarySearch binarySearch = new BinarySearch();
int result = binarySearch.Search(array, target);

Console.WriteLine("target number on index: " + result);
