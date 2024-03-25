# Algorithm Description Document

Author: Jake Zalesny 

Date: 2/10/2024

## 1. Name
Directed Acyclic Graph (DAG) Shortest Path

## 2. Overview & Purpose
From what I understand about this algorithm it can be used in two different ways mainly. It's used for seeing the quickest way through processing times, or in simpler terms, it's built to find the shortest path through a graph. The converse being the Critical Path, is also found by converting the weights into negatives and using the same algorithms. The critical path is the path that is going to take the longest.  

## 3. Methodology
First and foremost, the graphs data has to be sorted topologically. You then have to change every distance to infinity, the first distance you change to zero. You then go through all of its successors and change the distance to the original distance that you had for them. You do this all the way through and you'll find the shortest path. 

## 4. Analysis Results

The performance of the shortest path (where $V$ is the number of verticies and $E$ is the number of edges):

* Worst Case: $O(VE)$
* Best Case: $\Omega(V + E)$

## 5. AI Research
I needed a bit of help figuring out the right collection in the Topological sort and how to initialize the lists with infinity in them, or just zeros. It turns out I didn't need the zeros. Here's the link: https://gemini.google.com/app/109e9cefabbe4d00

### 5.1

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. DAGShortestPath algorithm is actually really good for network routing. It's also used in DecisionTrees and BayesianNetworks. 
2. DAGShortestPath doesn't work on negative cycles, so you have to use BellmanFord Shortest Path.

### 5.2

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. It was definitely a lot more modularized than mine. It had several built helper functions rather than what I was doing. 
2. Instead of setting predecessor values to max value it set them to -1, which is also going to be impossible to have in a DAGShortestPath. I'm not sure if this is for memory purposes or...

### 5.3

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

I didn't make any changes to my code. 

### 5.4

Provide the URL for your discussion in ChatGPT: 
https://gemini.google.com/app/109e9cefabbe4d00