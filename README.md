# Welcome to NextLevelLoops

NextLevelLoops is a utility package for Unity3D that provides you with the tools to speed up your C# development by having easier to use loops!


It is open-source and cross platform. 

# First Look

NextLevelLoops allows your to write loops that take a lot less space, and will push your code to the next level.

It allows you to convert ugly code like this:

```c#
for (int i = 0; i < someString.Length; i++)
{
    //Uppercase the string.
    someString = someString.ToUpper();
    Debug.Log(someString);
}
```
Into much nicer code, like this: 

```c#
//Make every string uppercase.
Loops.Do(someStrings, ToUpperCase);

private static void ToUpperCase(string someString)
{
    //Uppercase the string.
    someString = someString.ToUpper();
    Debug.Log(someString);
}
```
