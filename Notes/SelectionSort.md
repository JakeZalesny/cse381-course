# Selection Sort Notes: 

Array: 6 2 1 7 4 5 3

Find the smallest in 0...n-1

Swap smallest with index 0

Start with 1- n-1

Then pretty much will wind up 2- n-1 up to n-2 - n-1

## Psuedocode: 

loop index 0 --> len(data) - 2

smallest = data[index]

loop search index + 1 --> len(data) - 1

if data[search] < data[smallest]
    data[smallest] = data[search]

swap data[smallest] w/ data[index]