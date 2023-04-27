﻿using DataStructures.Collections.Array;
using DataStructures.Collections.DynamicArray;

// Arrays
// Static arrays
// var array = new Array<int>(20);
// Console.WriteLine("Number of elements: " + array.Length);
// Console.WriteLine(array);

// Dynamic Arrays
// Create a new dynamic array with initial capacity of 2
DynamicArray<int> dynamicArray = new DynamicArray<int>(2);

// Add some elements to the dynamic array
dynamicArray.Add(1);
dynamicArray.Add(2);
dynamicArray.Add(3);



// Get the size and capacity of the dynamic array
int size = dynamicArray.Size; // size = 3
int capacity = dynamicArray.Capacity; // capacity = 4

// Get and set an element in the dynamic array
int firstElement = dynamicArray[0]; // firstElement = 1
dynamicArray[1] = 5; // dynamicArray is now [1, 5, 3]

// Check if an element exists in the dynamic array
bool containsThree = dynamicArray.Contains(3); // containsThree = true
bool containsFour = dynamicArray.Contains(4); // containsFour = false

// Get the index of an element in the dynamic array
int index = dynamicArray.IndexOf(5); // index = 1

// Insert an element at a specific index in the dynamic array
dynamicArray.Insert(1, 4); // dynamicArray is now [1, 4, 5, 3]

// Remove an element from the dynamic array
bool removed = dynamicArray.Remove(4); // removed = true, dynamicArray is now [1, 5, 3]

// Remove an element at a specific index from the dynamic array
dynamicArray.RemoveAt(1); // dynamicArray is now [1, 3]

// Clear all elements from the dynamic array
dynamicArray.Clear(); // dynamicArray is now []

// Trim the excess capacity from the dynamic array
DynamicArray<string> stringArray = new DynamicArray<string>(10);
stringArray.Add("hello");
stringArray.Add("world");
stringArray.TrimExcess(); // stringArray has capacity of 2 now