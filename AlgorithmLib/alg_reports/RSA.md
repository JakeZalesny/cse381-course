# Algorithm Report

Author: Jake Zalesny

Date: 3/9/2024

## 1. Name
RSA Encryption

## 2. Overview & Purpose
The purpose of this is to encrypt and decrypt data using a private, public key, and a good bit of math.  

## 3. Methodology
The RSA primarily works off of creating two keys. A Private and a Public key. The Public key is distributed everywhere, the private is kept. The Private Key is generated off of a Euclidian function.  

## 6. Analysis Results

The performance for the modular exponentiation (where $n$ is the exponent value)

* Worst Case: $O(n)$
* Best Case: $\Omega(log n)$

## 5. AI Report

### 5.1 Research

Research this algorithm on ChatGPT by asking at least 5 questions (e.g. follow-up questions from the previous response, things from the reading or class that was confusing).  Identify at least 2 things that you learned about the algorithm from your research:

1. It's nearly impossible to break a well implemented RSA encryption assuming it has a bit size of 2048. 
2. This is something that's been around since the 70's and is still effective.

### 5.2 Code Comparison

Ask ChatGPT to write code for this algorithm in C#.  Compare the code that you wrote with the code that ChatGPT responded with.  Identify any differences from your code, explain why they are different, and determine if the differences should be adopted.

1. It didn't separate the encrypt and decrypt functions
2. It looks like it did everything in the Euclidian function. 

### 5.3 Code Use

Identify any fixes or improvements you made to your code after reviewing the code provided by the ChatGPT:

1. N/A
2. N/A

### 5.4 Reference

Provide the URL for your discussion in ChatGPT:
https://gemini.google.com/app/2b1caffd2464845f
