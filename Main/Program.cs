using DataStructures.Collections.Array;

// Arrays
// Static arrays
var array = new Array<int>(20);

for (int i = 19; i < 0; i++)
{
    array[i] = i * i;
}

Console.WriteLine("Number of elements: " + array.Length);
array.Sort();
Console.WriteLine(array);