namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var first = 0;
        var last = data.Count - 1;
        while (first <= last)
        {
            var middle = (first + last) / 2;
            if (target.Equals(data[middle]))
            {
                return middle; 
            }

            if ((int)target < (int)data[middle])
            {
                last = middle - 1;
            }

            else
            {
                first = middle + 1;
            }
        }
        return -1;
    }
    // this is O(log n) and it's normally log 10, lg is log 2 n
    public static int RecursiveSearch(List<IComparable> data, IComparable target)
    {
        return _RecursiveSearch(data, target, 0, data.Count - 1);
    }

    private static int _RecursiveSearch(List<IComparable> data, IComparable target, int first, int last)
    {
        if (first > last)
        {
            return -1;
        }
        var middle = (first + last) / 2;
        
        if (target.Equals(data[middle]))
        {
            return middle;
        }

        if ((int)target <= (int)data[middle])
        {
            return _RecursiveSearch(data, target, first, middle - 1);
        }

        else
        {
            return _RecursiveSearch(data, target, middle + 1, last);
        }
        return -1; 
    }
}

// Master Theorem of Reccurence: T(n) = aT(n/b) + 0(n^d)
// Constant beforehand is how many recursive calls are made. 
// T = Performance 
// a = how many recursive calls we make. 
// b = division of the data. 
// n^d = polynomial time for each recursive call. 
// Binary search: T(n) = 1 * T(n/2) + 0(n^0)