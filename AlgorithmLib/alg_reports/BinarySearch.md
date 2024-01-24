# Algorithm Report

Author: 

Date: 

## 1. Name
Binary Search

## 2. Overview & Purpose
The point of a Binary Search is to split the data in half repeatedly and try to match the target to the actual value contained in the list. 

## 3. Methodology
I kind of stated this in the overview and purpose but it's splitting the list in half and searching through halves to find a targeted value. This splitting can be done either recursively or by using a while loop to split until the loop until the stopping condition is met. 

To do this recursively you just need to check if the target is less than or greater than the target value. If it's less than you drop the lower bound value by one, if it's greater, raise the upper bound value. 

To do this using a while loop you do relatively the same thing but rather than calling the function recursively, you just add onto the index or subtract. 

## 4. Analysis Results

The performance for the search (where $n$ is the number of items in the list):

* Worst Case: $O(log n)$
* Best Case: $\Omega(1)$

## 5. AI Report
I didn't use any AI to figure this on out. 
### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1.I learned that it's pretty consistently faster than a linear search because it's O(log n) vs O(n)
2. The divide and conquer approach is very good, it is really good breaking down big sorted lists. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. The first thing that it generated was a while loop example of a Binary Search. That's probably because recursion is very difficult to understand. 
2. I asked about making it more efficient and the only thing it cautioned me was to look for overflow on the int value for middle. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. It's pretty much the same so not really no. 
2.N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT: https://chat.openai.com/share/429dcabf-f81e-4b0c-9829-e5710d61a040