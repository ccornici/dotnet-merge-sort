int[] input = new int[] { 3, 1, 10, 2, 4 };

var print = (int[] input) => Console.WriteLine(string.Join(" ", input));

print(input);

ISortAlg sortAlg = new MergeSortAlg();
var sortedInput = sortAlg.Sort(input);

print(sortedInput);
