# QuickSort Notes

- Partition: Find where something goes and make partitions to the left or right. 
- Pivot, the spot where we're splitting the list. 
- QuickSort: O(n log n) - uses O(1) Memory
- Spot where the thingy needs to go: LMGP
- Left Most Greater Pivot

6 1 3 7 2 5 8 |4

<= 4   |   > 4

1 3 2 6 7 5 8 | 4

6 is LMGP 

1 3 2 | 4 | 7 5 8 6

Repeat the process with the sub lists. 

Another example 

6 1 3 7 2 5 8 || 4 (6 is LMGP)

1 6 3 7 2 5 8 || 4 (6 is LMGP)

1 3 2 7 6 5 8 || 4 (7 is LMGP)

Swap pivot and LMGP 

1 3 2 4 6 5 8 7 

### Pseudocode:

Partition(Data, First, Last): 

LMGP = First

loop i first to last - 1

    if Data[i] <= Data[last]

        Swap Data[i] & Data[LMGP]
        LMGP++

Swap Data[LMGP] & Data[Last]

return LMGP
