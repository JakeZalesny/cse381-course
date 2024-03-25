# Bubble Selection and Insert

Divide, Conquer, Combine

A list of size 1 is sorted. 

Go back up the chain and sort 

How do you combine 2 sorted lists? 

Compare the first numbers and then insert into the list the smallest then compare again.

It's a lot easier to sort two sorted lists then 

Bubble, Selection, and Insert - O(n^2)

Merge Sort O(n log n)

It's the fastest we can sort. You won't get faster than O(n log n)

## Algorithm Steps: 

Step 1. Cut the data in half. 

Sort(Data)
if first == last return

if last < first return

mid = (first + last) / 2

sort(Data, first, mid)

sort(data, mid+1, last)

merge(data, first, mid, last)