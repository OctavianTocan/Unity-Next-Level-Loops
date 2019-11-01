# Welcome to NextLevelLoops

NextLevelLoops is a utility package for Unity3D that provides you with the tools to speed up your C# development by having easier to use loops!


It is open-source and cross platform. 

# First Look

NextLevelLoops allows your to write loops that take a lot less space, and will push your code to the next level.

It allows you to convert ugly looking code like this:

```c#
for (int i = 0; i < array.Length; i++)
{
    Do Something...
}
```
Into much nicer code, like this: 

```c#
//Loop trough the string array, calling AFunction each time.
Loops.Do(aStringArray, AFunction);

private static void AFunction(string someString)
{
    Do Something...
}
```

The reason why this is so important is that sometimes you might not really need the index of a loop, or the value, with NextLevelLoops you get only what you need, and it looks a lot nicer too!

# Features

NextLevelLoops offers multiple functions that you can use to improve your code, one very important one is the basic reverse loop function that you can use like this: 

```c#
//Loop trough the string array, calling AFunction each time.
RLoops.Do(aStringArray, AFunction);

private static void AFunction(string someString)
{
    Do Something...
}
```

This will go trough the array in reverse order, providing you with each of the strings contained in it.
