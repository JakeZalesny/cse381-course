# Algorithm Report

Author: 

Date: 

## 1. Name

Quick Sort

## 2. Overview & Purpose
A quicksort is kind of self explanatory. It's meant to sort data very quickly using principles of partitioning and comparison. 

## 3. Methodology
A quick sort sets a partition in the data and compares each piece of data on either side of the partition to use for comparing. It does this recursively so it goes all the way down until there's a list of one, and a list of one is sorted so it goes back up the recursion and sorts using the comparison made to the partition. 

## 4. Analysis Results

The performance of the sort (where $n$ is the number of items in the list):

* Worst Case: $O(n^2)$
* Best Case: $\Omega(n log n)$

## 5. AI Report
I needed a bit of help translating to C# again. I was able to succesfully sort unsorted data, but I couldn't sort sorted data. as it turned out my for loop had a "<=" when it should've been "<". Here's the link: 
https://bard.google.com/chat/2239794ca755f07c 

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. It's very good at saving memory due to it being an In-Place sorting method. 
2. It's average case performance is almost always better than a merge sort. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. It used a "Swap" method instead of using a tuple swap. 
2. It set a checker up top to make sure that the item coming into the method was an "IComparable" 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. I think I'm going to implement the Swap method next time I use it. 
2.  N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:
https://bard.google.com/chat/2239794ca755f07c
