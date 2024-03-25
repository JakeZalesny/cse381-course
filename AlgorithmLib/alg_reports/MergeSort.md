# Algorithm Report

Author: Jake Zalesny

Date: 1/27/24

## 1. Name
Merge Sort

## 2. Overview & Purpose
This algorithm is primarily used to quickly sort a list in ascending order. 

## 3. Methodology
This algorithm sorts a list by taking it and continuously splitting it in half until each item is in a list of 1. Once everything is in a length of one list, it's already sorted (individually) it then works back up by comparing list to list until you get two big sublists. It then compares each item of those sublists and finally makes a sorted list. 

## 4. Analysis Results

The performance of the sort (where $n$ is the number of items in the list):

* Worst Case: $O(n log n)$
* Best Case: $\Omega(n)$

## 5. AI Report
I clearly didn't understand the differences between Python and C# loops so I needed a bit of help figuring out how to do the loops in the merge function but, I got everything else: https://bard.google.com/chat/0fa17b1c2e41b34b

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Merge sorts scale really well with larger amounts of data. 
2. This takes up a lot of memory, you have to use temporary storage for sub-lists during the process. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. It used ints instead of IComparables 
2. It didn't ever use 'var' it always specified the datatype

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. We pretty much did the exact same thing. 
2. N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:
I used Bard AI from google, here's the link: https://bard.google.com/chat/0fa17b1c2e41b34b
