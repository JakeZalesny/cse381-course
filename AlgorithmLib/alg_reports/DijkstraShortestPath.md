# Algorithm Report

Author: Jake Zalesny 

Date: 2/17/2024

## 1. Name
Dijkstra Shortest Path

## 2. Overview & Purpose
Djikstra's shortest path is used to find the shortest path in cyclic graphs, meaning: Graphs that have verticies with loops in them. 

## 3. Methodology
This to me at least is essentially an adapted version of DAGShortest path for cyclic graphs. DAGShortest path isn't built for cycles, this one is. It works by putting an index and a priority in a queue and constantly doing comparisons including, when it runs into a cycle, comparing to itself. 

## 4. Analysis Results

The performance for the shortest path (where $V$ is the number of verticies in the graph and $E$ is the number of edges):

* Using an Array:
    * Worst Case: $O(V^2 + E)$
    * Best Case: $\Omega(V + E)$

* Using a Priority Queue:
    * Worst Case: $O(V Log E)$
    * Best Case: $\Omega(V Log V + E)$

## 5. AI Report
I needed a bit of help figuring out how to implement the decrease key method so I compared to the AI. 

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Djikstra's shortest path is something that could be implemented in Video Game bad-guy pathing. 
2. It's possible to parallelize Djikstra's shortest path and explore multiple sources. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. They did it in .NET 6 when PriorityQueues had a .Remove() method. That was a pretty big difference. 
2. They set INF to the max value, making the code a lot more legible. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. Working on a parallel version... 
2. N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:

https://gemini.google.com/app/97acf2c10935a224