# Algorithm Report

Author: Jake Zalesny

Date: 3/2/24

## 1. Name

String Matcher

## 2. Overview & Purpose
The point of this algorithm is to be able to take a sequence of characters and locate it or match it to any given text.

## 3. Methodology
This algorithm primarily functions off of 4 steps: 1. Comparison 2. Shifiting the window 3. Match identification 4. Iteration: To sum this up you have to take the first letter that you're looking for and try to match the second, third, fourth etc. in the sequence by building a tree and adding in the nodes. You compare and then shift the window when appropriate. The match identification is just making sure that it's actually a correct match and iteration is pretty self explanatory. 


## 4. Analysis Results

The performance of matching assuming the finite state machine table is already built (where $m$ is the length of the pattern and $n$ is the length of the text being checked)

* Worst Case: $O(n * m)$
* Best Case: $\Omega(n)$

## 5. AI Report

I couldn't remember very well the time performance of this. And the methodology eluded me a bit. 

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. Out of all of the String Matcher algorithms, O(n) is consistently the best time. 
2. If the pattern is longer than the given text this could cause a serious performance drop or error. 

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. It wrote a Naive string matcher which returned bools based on the pattern being found or not.
2. This one is going to consistently iterate n * m times instead of finding an n time possibility. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. N/A
2. N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:
https://gemini.google.com/app/713abf564d0f0710