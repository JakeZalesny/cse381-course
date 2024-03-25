# Algorithm Report

Author: Jake Zalesny

Date: 2/26/24

## 1. Name
Bellman Ford Shortest Path

## 2. Overview & Purpose
The Bellman Ford Shortest Path is built specifically to handle negative cycles. It does this by using Djikstras shortest path and implementing a check and handling system for a Negative Cycle. 

## 3. Methodology
So the first thing that you need to do is initialize your distance and predecessor arrays to having all infinite values except for the starting vertex. You'll iterate v-1 times through all edges in the graph relaxing the weights as you go. This part is the same as Djikstra's where you'll have multiple paths branch out but there will be one that's less than the others based off of the values. The main difference is this will detect a negative cycle if there is one.   

## 4. Performance

The performance for the shortest path (where $V$ is the number of verticies in the graph and $E$ is the number of edges):

* Worst Case: $O(VE)$
* Best Case: $\Omega(V + E)$

## 5. AI Report

I needed a bit of help here figuring out what I was doing wrong so I used AI to help me debug. 

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. It's possible to parallelize this. You'll need to do this in the relaxation steps however. Given that the relaxation happens twice around, this could be pretty useful. 
2. BellmanFord is not the only algorithm built to handle Negative Cycles. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. It did the check for a negative cycle last. 
2. It also set INF as a constant. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. N/A
2. N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:

https://gemini.google.com/app/f4533a472e77fe53

