# Useful Arrays
This repository includes a class of useful extention methods to make your life so much easier when working with arrays.
I am very active and are up to improvements and even more extentions to make this class as usefull as it can be!
Below are guides on how to use each extention.

# Arrays.RemoveAt(this source, index)
Removes an index from array and resizes the array: someArray = someArray.RemoveAt(4)

# Arrays.RandomIndexOf(source, element)
Similar to Array.IndexOf or Array.LastIndexOf but picks a random one instead of the first or last: int someVariable = Arrays.RandomIndexOf(someArray, someInteger)

# Arrays.ClearArray(this source)
Passes an empty array. Good for releasing things from memory: someArray = someArray.ClearArray()

# Arrays.Append(this source)
Returns an array with an extra value at the end: someArray = someArray.Append(5) or someArray = someArray.Append("string")
