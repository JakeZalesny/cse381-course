# Unstable Sort 

- Make a table with the value counts
- Make a new list and place them in order with the value counts.
- Equals list: 0 - m-1
- Order table to keep track of the order of the list. Order list is summing the two indexes of that list and putting them into the 
- It's O(m + n) but the m is small so drop it. 


Pseudocode: 
loop i i --> len(data) - 1
    
    result[order[data[i]] ] = data[i]
    order[data[i]]++


Counting: 
O(m + n)

Radix:
O(k(m + n))

n = # of data
m = range of data
k = len of data elements. 