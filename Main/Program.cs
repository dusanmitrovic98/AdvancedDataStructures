using DataStructures.Collections.Array;

// Arrays
// Static arrays
var array = new Array<int>(20);
var array2 = new Array<int>(20);

for (int i = 0; i < array.Length; i++)
{
    array[i] = i * i;
}

Console.WriteLine("Number of elements: " + array.Length);
Console.WriteLine(array);

// * ------------------------------------------------------------------

array.CopyTo(array2, 10);
Console.WriteLine("Number of elements 2: " + array2.Length);
Console.WriteLine(array2);