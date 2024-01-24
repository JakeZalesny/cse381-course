# Notes: 
```csharp
//1 
for(var i = 1; i < data.Count; i++) {
    //2
    if(data[i] == x) {
        //3
        answer = i
    }
    //4
    return answer
}

```

Worst case scenario:
1. N + 1
2. N
3. N
4. 1

Best case scenario: 
1. N + 1
2. N
3. N
4. 1

Better Linear Search

```csharp
//1
for(var i = 1; i < data.Count; i++){
    //2
    if(data[i] == x){
        //3
        return i 
    }
}
//4
return -1
```

Worst Case: 
1. N+1
2. N
3. 0
4. 1

Best Case: 
1. 1
2. 1
3. 1
4. 0 

Big O ratings: 
O(1) - Constant
O(log n) - Logarithmic
O(n) - Linear
O(n log n) - Loglinear
O(n^k) - Polynomial
O(k^n) - Exponential
O(n!) - Factorial

### Bubble Sort: 
```csharp
//1
for(var i = 1; i < data.Count; i++) {
    //a
    var swap = false; 
    //b
    for(var j = 1; j < data.Count; j++) {
        //c1
        if(data[j] > data[j+1]) {
            //c2
            swap data[j] and data[j+1];
            //c3
            swap = True;
        }
    }
    //d
    if(swap == false) {
       //e
        return;
    }
}
```
Worst case
1. N

a. N-1

b. N + (N-1) + (N-2)... + 2 For loops run one extra time. It's a summation i = 2 to n; i or i = 1 to n i = n(n + 1) / 2 - 1

c1. (N-1) + (N-2)... = n(n-1) / 2

c2. same as c1

c3. same as c1 

d. N-1

e. 0 

Best Case
1. 1

a. 1

b. N

c. N - 1

c2. 0

c3. 0

d. 1

e. 1

look for when n is big! Don't mess with the size of N


