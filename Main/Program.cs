// * Script used to showcase examples for each DLL library.
// * 1) Arrays
// *    a) Static array
// *    b) Dynamic array
// * 2) Linked lists
// * 3) Stacks
// * 4) Queues
// * 5) Trees
// * 10) Sets
// todo add Directed Graph examples

using DataStructures.Collections.DynamicArray;
using DataStructures.Collections.List;
using DataStructures.Collections.Sets;

// * 1) Arrays
// * a) Static array

// * b) Dynamic array
// Create a new dynamic array with initial capacity of 2
DynamicArray<int> dynamicArray = new DynamicArray<int>(2);

// Add some elements to the dynamic array
dynamicArray.Add(1);
dynamicArray.Add(2);
dynamicArray.Add(3);
Console.WriteLine(dynamicArray);

// Get the size and capacity of the dynamic array
int size = dynamicArray.Size; // size = 3
int capacity = dynamicArray.Capacity; // capacity = 4
Console.WriteLine("Size: " + size);
Console.WriteLine("Capacity: " + size);

// Get and set an element in the dynamic array
int firstElement = dynamicArray[0]; // firstElement = 1
dynamicArray[1] = 5; // dynamicArray is now [1, 5, 3]
Console.WriteLine("First Element: " + firstElement);
Console.WriteLine(dynamicArray);

// Check if an element exists in the dynamic array
bool containsThree = dynamicArray.Contains(3); // containsThree = true
bool containsFour = dynamicArray.Contains(4); // containsFour = false
Console.WriteLine("Contains Three: " + containsThree);
Console.WriteLine("Contains Four: " + containsFour);

// Get the index of an element in the dynamic array
int index = dynamicArray.IndexOf(5); // index = 1
Console.WriteLine("Index: " + index);

// Insert an element at a specific index in the dynamic array
dynamicArray.Insert(1, 4); // dynamicArray is now [1, 4, 5, 3]
Console.WriteLine(dynamicArray);

// Remove an element from the dynamic array
bool removed = dynamicArray.Remove(4); // removed = true, dynamicArray is now [1, 5, 3]
Console.WriteLine(dynamicArray);

// Remove an element at a specific index from the dynamic array
dynamicArray.RemoveAt(1); // dynamicArray is now [1, 3]
Console.WriteLine(dynamicArray);

// Clear all elements from the dynamic array
dynamicArray.Clear(); // dynamicArray is now []
Console.WriteLine(dynamicArray);

// Trim the excess capacity from the dynamic array
DynamicArray<string> stringArray = new DynamicArray<string>(10);
stringArray.Add("hello");
stringArray.Add("world");
stringArray.TrimExcess(); // stringArray has capacity of 2 now
Console.WriteLine(stringArray);

// * 2) Linked list
// Create a new list
DataStructures.Collections.List.List<int> myList = new DataStructures.Collections.List.List<int>();

// Add some items to the list
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
myList.Add(5);
Console.WriteLine(myList);

// Add a range of items to the list
myList.AddRange(new int[] { 6, 7, 8, 9, 10 });
Console.WriteLine(myList);

// Clear the list
myList.Clear();
Console.WriteLine(myList);

// Check if an item is in the list
bool containsItem = myList.Contains(5);
Console.WriteLine("List Contains Item: " + containsItem);

// * 3) Stacks

// Creating a new stack of integers
Stack<int> myStack = new Stack<int>();

// Adding elements to the stack
myStack.Push(10);
myStack.Push(20);
myStack.Push(30);
myStack.Push(40);

// Checking if the stack contains an element
bool contains20 = myStack.Contains(20); // true

// Peeking at the top element of the stack
int topElement = myStack.Peek(); // 40

// Removing the top element from the stack
int removedElement = myStack.Pop(); // 40

// Checking the count of elements in the stack
int count = myStack.Count; // 3

// Converting the stack to an array
int[] stackArray = myStack.ToArray();

// Clearing all elements from the stack
myStack.Clear();

// Adding a range of elements to the stack
int[] numbers = { 1, 2, 3, 4, 5 };
myStack = new Stack<int>(numbers);

// Using the foreach loop to iterate through the stack
foreach (int number in myStack)
{
    Console.WriteLine(number);
}

// Output:
// 5
// 4
// 3
// 2
// 1

// * 4) Queues

Queue<string> q = new Queue<string>(5);
q.Enqueue("Alice");
q.Enqueue("Bob");
q.Enqueue("Charlie");
Console.WriteLine("Count: " + q.Count);
Console.WriteLine("Peek: " + q.Peek());
Console.WriteLine("Dequeue: " + q.Dequeue());
Console.WriteLine("Dequeue: " + q.Dequeue());
Console.WriteLine("Count: " + q.Count);
q.Enqueue("Dave");
Console.WriteLine("Enqueue: " + "Dave");
Console.WriteLine("Count: " + q.Count);
Console.WriteLine("Peek: " + q.Peek());
Console.WriteLine("Dequeue: " + q.Dequeue());
Console.WriteLine("Dequeue: " + q.Dequeue());
Console.WriteLine("Count: " + q.Count);

// * 5) Trees

// * 10) Sets
Set<int> setA = new Set<int>();
Set<int> setB = new Set<int>();

// Add items to setA
setA.Add(1);
setA.Add(2);
setA.Add(3);

// Add items to setB
setB.Add(2);
setB.Add(3);
setB.Add(4);