namespace AlgorithmLib;

public static class MergeSort
{
    private static void Merge(List<IComparable> data, int first, int mid, int last)
    {
        //Make the sub-lists. 
        List<IComparable> sa1 = data.GetRange(first, mid - first + 1);
        List<IComparable> sa2 = data.GetRange(mid + 1, last - mid);
        
        //set up indexes 
        int i = first; 
        int sa1Index = 0;
        int sa2Index = 0;
        
        // While we still have stuff in the list
        while (sa1Index < sa1.Count && sa2Index < sa2.Count)
        {
            //If first is smaller put it in the list
            if (sa1[sa1Index].CompareTo(sa2[sa2Index]) == -1)
            {
                data[i++] = sa1[sa1Index++];
            }
            
            //If second is smaller put it in list
            else
            {
                data[i++] = sa2[sa2Index++];
            }
        }

        // Copy remaining elements from sa1 (if any)
        while (sa1Index < sa1.Count)
        {
            data[i++] = sa1[sa1Index++];
        }

        // Copy remaining elements from sa2 (if any)
        while (sa2Index < sa2.Count)
        {
            data[i++] = sa2[sa2Index++];
        }
        // This was my first attempt at translating the code from Python:
        // for (int mIndex = first; mIndex < last + 1; mIndex++)
        // {
        //     if (sa1Index >= sa1.Count)
        //     {
        //         data[mIndex] = sa2[sa2Index];
        //         Console.WriteLine($"sa2[sa2Index]: {sa2[sa2Index]}");
        //         Console.WriteLine($"data[mIndex]: {data[mIndex]}");
        //         sa2Index++;
        //         
        //     }
        //     
        //     else if (sa2Index >= sa2.Count)
        //     {
        //         data[mIndex] = sa1[sa1Index];
        //         Console.WriteLine($"sa2[sa2Index]: {sa1[sa1Index]}");
        //         Console.WriteLine($"data[mIndex]: {data[mIndex]}");
        //         sa1Index++;
        //     }
        //     
        //     else if (sa1[sa1Index].CompareTo(sa2[sa2Index]) == -1)
        //     {
        //         data[mIndex] = sa2[sa2Index];
        //         Console.WriteLine($"sa2[sa2Index]: {sa2[sa2Index]}");
        //         Console.WriteLine($"data[mIndex]: {data[mIndex]}");
        //         sa2Index++;
        //     }
        //     else
        //     {
        //         data[mIndex] = sa2[sa2Index];
        //         Console.WriteLine($"sa2[sa2Index]: {sa2[sa2Index]}");
        //         Console.WriteLine($"data[mIndex]: {data[mIndex]}");
        //         sa2Index++;
        //     }

    }

    private static void _Sort(List<IComparable> data, int first, int last)
    {
        if (first >= last)
        {
            return;
        }

        int mid = (first + last) / 2;
        _Sort(data, first, mid);
        _Sort(data, mid+1, last);
        Merge(data, first, mid, last);
        
    }

    public static void Sort(List<IComparable> data)
    {
        _Sort(data, 0, data.Count - 1);
    }
    
}

