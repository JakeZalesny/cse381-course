# Algorithm Report

Author: Jake Zalesny

Date: 3/16/2024

## 1. Name
Huffman Tree Compression

## 2. Overview & Purpose
The Huffman Tree Compression algorithm takes a string and breaks it by letter and uses a Huffman tree to encode each unique character. It does this because each character is worth 8 bits whereas a number is worth 2. The hope is that because we're changing the character into a string it will drop the size the text occupies. 

## 3. Methodology
It does this by creating a unique encoded binary string for each letter. These strings are created using a profile and a huffman tree. The more the letter pops up in any given text the "higher up" on the profile it will be and the shorter the encoded string will be. It then reads the text and converts every single letter to their unique encoded string and saves that as the new encoded file. 


## 4. Analysis Results

The performance for the encode and decode (where $m$ is the number of huffman codes and $n$ is the length of text to encode or decode)

* Encode:
    * Worst Case: $O(n)$
    * Best Case: $\Omega(n)$
* Decode:
    * Worst Case: $O(n*m)$
    * Best Case: $\Omega(n)$

## 5. AI Report
I didn't have to use any AI for help on this one. 

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. The Huffman Tree compression isn't as widely used, but it's a great foundation. 
2. It's really good for cases with uneven letter frequencies

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. It did everything in one function rather than modularizing it into other functions which was an interesting choice. 
2. It also did it entirely recursively which could have performance impact and is not nearly as understandable. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. N/A
2. N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:
https://gemini.google.com/app/777929157ee5fa67


