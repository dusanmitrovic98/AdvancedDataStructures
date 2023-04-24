using DataStructures.Collections.Array;

// Arrays
// Static arrays
var array = new Array<int>(20);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
// }
// array.Add(22);

Console.WriteLine("Number of elements: " + array.Length);
Console.WriteLine(array);

// * ------------------------------------------------------------------

var array2 = array.Copy(10);
Console.WriteLine("Number of elements 2: " + array2.Length);
Console.WriteLine("Index: " + array2.IndexOf(256));
Console.WriteLine(array2);