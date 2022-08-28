namespace MergeSort.Tests;

public class MergeSortAlgTests
{
  ISortAlg sortAlg = new MergeSortAlg();

  [Theory]
  [InlineData(null, null)]
  [InlineData(new int[0], new int[0])]
  [InlineData(new[] { 4, 20, 12, 1 }, new[] { 1, 4, 12, 20 })]
  [InlineData(new[] { -9, -3, -20, -1, -8 }, new[] { -20, -9, -8, -3, -1 })]
  public void CanSortInputsCorrectly(int[] input, int[] expected)
  {
    sortAlg.Sort(input).Should().Equal(expected);
  }
}
