namespace AlgorithmLib;

public static class QuickSort
{
    private static int Partition(List<IComparable> data, int first, int last)
    {
        int pivot = first + new Random().Next(last - first + 1);
        (data[pivot], data[last]) = (data[last], data[pivot]);

        var leftMostGreaterPivot = first;
        // int i = first;
        // while(i < last)
        for (var i = first; i < last; i++)
        {
            if (data[i].CompareTo(data[last]) <= 0)
            {
                (data[leftMostGreaterPivot], data[i]) = (data[i], data[leftMostGreaterPivot]);
                leftMostGreaterPivot++;
            }
        } 
        (data[leftMostGreaterPivot], data[last]) = (data[last], data[leftMostGreaterPivot]);
        return leftMostGreaterPivot;
    }

    public static void Sort(List<IComparable> data)
    {
        _Sort(data, 0, data.Count - 1);
    }

    public static void _Sort(List<IComparable> data, int first, int last)
    {
        if (first >= last)
        {
            return;
        }

        var pivotIndex = Partition(data, first, last);
        
        _Sort(data, first, pivotIndex - 1);
        _Sort(data, pivotIndex + 1, last);
    }

}