# Merge Sort Algorithm in C#

This project contains an implementation of the **Merge Sort** algorithm in C#. The Merge Sort algorithm is a classic divide-and-conquer sorting algorithm that recursively splits the list into smaller sublists, sorts them, and merges them back together.

## Project Structure

- **[MergeSort.cs](./MergeSort.cs)**: This file contains the implementation of the Merge Sort algorithm. It defines two main methods:
    - `MergeSplit<T>(List<T> list)` - Recursively splits the list into sublists, sorts them, and merges them.
    - `Merge<T>(List<T> leftList, List<T> rightList)` - Merges two sorted lists into one sorted list.

## How the Merge Sort Works

1. **Split Phase**:
    - The input list is recursively divided into two halves until each sublist has fewer than 2 elements.
    - This is done using the `MergeSplit` method, which finds the midpoint and splits the list into two smaller lists.

2. **Merge Phase**:
    - After the list has been split into individual elements (base case of the recursion), the algorithm starts merging the sublists back together in sorted order.
    - The `Merge` method compares elements from two sublists and merges them into a single sorted list.

## Usage

### Requirements

- C# 7.0 or later
- .NET SDK

### Running the Program

1. Clone the repository or copy the code to your local machine.
2. Compile the program using the .NET SDK or your preferred IDE.
3. The `RunClass` method in the `MergeSort` class can be used as the entry point to run the program.

The `RunClass` method sorts the following list:

```csharp
new List<int> { 1, 2, 33, 3, 11, 4, 5, 6 };
new List<string> { "apple", "orange", "banana", "grape" };
new List<double> { 1.0, 2.0, 33.2, 3.5, 11.0, 4.8, 5.8, 6.1 };
