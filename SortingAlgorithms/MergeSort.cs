using System.Collections;

namespace SortingAlgorithms;

public class MergeSort
{
    List<T> MergeSplit<T>(List<T> list) where T : IComparable<T>
    {
        if (list.Count < 2)
            return list;
        int midPoint = list.Count / 2;
        var leftArray = list.GetRange(0, midPoint);
        var rightArray = list.GetRange(midPoint, list.Count - midPoint);

        leftArray = MergeSplit<T>(leftArray);
        rightArray = MergeSplit<T>(rightArray);

        return Merge(leftArray, rightArray);
    }

    private static List<T> Merge<T>(List<T> leftList, List<T> rightList) where T : IComparable<T>
    {
        List<T> result = new List<T>();
        int leftPointer = 0, rightPointer = 0;
        for (; leftPointer < leftList.Count && rightPointer < rightList.Count;)
        {
            if (leftList[leftPointer].CompareTo(rightList[rightPointer]) <= 0)
            {
                result.Add(leftList[leftPointer]);
                leftPointer++;
            }
            else
            {
                result.Add(rightList[rightPointer]);
                rightPointer++;
            }
        }
        
        // Add any remaining elements to the List
        result.AddRange(leftList.GetRange(leftPointer, leftList.Count - leftPointer));
        result.AddRange(rightList.GetRange(rightPointer, rightList.Count - rightPointer));
        return result;
    }

    public static void RunClass()
    {
        var mergeSort = new MergeSort();
        // var result = mergeSort.MergeSplit(new List<double > {1.0, 2.0, 33.2, 3.5, 11.0, 4.8, 5.8, 6.1} );
        var result = mergeSort.MergeSplit(new List<string>
        {
            "apple", "orange", "banana", "grape"
        });
        // var result = mergeSort.MergeSplit(new List<int>{1, 2, 33,3,11,232,32,323,2323,2323,232, 4, 5, 6});
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}