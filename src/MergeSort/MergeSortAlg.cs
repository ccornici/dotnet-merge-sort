public class MergeSortAlg : ISortAlg
{

  public int[] Sort(int[] inputArr)
  {
    int inputArrLength = inputArr.Length;
    if (inputArr is null || inputArrLength <= 1)
    {
      return inputArr;
    }

    int[] inputArrCopy = new int[inputArrLength];
    Array.Copy(inputArr, inputArrCopy, inputArrLength);

    TopDownSplitMerge(inputArrCopy, 0, inputArrLength, inputArr);

    return inputArr;
  }

  private void TopDownSplitMerge(int[] inputArrCopy, int iBegin, int iEnd, int[] inputArr)
  {
    if (iEnd - iBegin <= 1)
    {
      return;
    }

    int iMiddle = (iEnd + iBegin) / 2;
    TopDownSplitMerge(inputArr, iBegin, iMiddle, inputArrCopy);
    TopDownSplitMerge(inputArr, iMiddle, iEnd, inputArrCopy);

    TopDownMerge(inputArrCopy, iBegin, iMiddle, iEnd, inputArr);
  }

  private void TopDownMerge(int[] inputArr, int iBegin, int iMiddle, int iEnd, int[] inputArrCopy)
  {
    int i = iBegin;
    int j = iMiddle;

    for (int k = iBegin; k < iEnd; k++)
    {
      // If left run head exists and is <= existing right run head.
      if (i < iMiddle && (j >= iEnd || inputArr[i] <= inputArr[j]))
      {
        inputArrCopy[k] = inputArr[i++];
      }
      else
      {
        inputArrCopy[k] = inputArr[j++];
      }
    }
  }
}
