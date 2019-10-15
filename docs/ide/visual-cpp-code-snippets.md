---
title: Visual C++ code snippets
ms.date: 11/04/2016
ms.topic: reference
author: mikeblome
ms.author: mblome
manager: markl
dev_langs:
 - CPP
ms.workload:
  - "cplusplus"
---
# Visual C++ code snippets

In Visual Studio, you can use code snippets to add commonly-used code to your C++ code files. In general, you can use code snippets in much the same way as in C#, but the set of default code snippets is different.

You can either add a code snippet at a particular location in your code (insertion) or surround some selected code with a code snippet.

## Insert a code snippet

To insert a code snippet, open a C++ code file (*.cpp* or *.h*), click somewhere inside the file, and do one of the following:

- Right-click to get the context menu and select **Insert Snippet**

- In the **Edit / IntelliSense** menu, select **Insert Snippet**

- Use the hotkeys: **Ctrl**+**K**+**X**

You should see a list of choices beginning with **#if**. When you select **#if**, you should see the following code added to the file:

```cpp
#if 0

#endif // 0
```

You can then replace the **0** with the correct condition.

## Use a code snippet to surround selected code

To use a code snippet to surround selected code, select a line (or multiple lines) and do one of the following:

- Right-click to get the context menu, and select **Surround With**

- From the **Edit** > **IntelliSense** menu, select **Surround With**

- Using a keyboard, press: **Ctrl**+**K**+**S**

Select **#if**. You should see something like this:

```cpp
#if 0
#include "pch.h"  // or whatever line you had selected
#endif // 0
```

You can then replace the 0 with the correct condition.

## Where can I find a complete list of the C++ code snippets?

You can find the complete list of C++ code snippets by going to the **Code Snippets Manager** (on the **Tools** menu) and setting the **Language** to **Visual C++**. In the window below, expand **Visual C++**. You should see the names of all the C++ code snippets in alphabetical order.

The names of most code snippets are self-explanatory, but some names might be confusing.

## Class vs. classi

The **class** snippet provides the definition of a class named `MyClass`, with the appropriate default constructor and destructor, where the definitions of the constructor and destructor are located outside the class:

```cpp
class MyClass
{
public:
    MyClass();
    ~MyClass();

private:

};

MyClass::MyClass()
{
}

MyClass::~MyClass()
{
}
```

The **classi** code snippet also provides the definition of a class named `MyClass`, but the default constructor and destructor are defined inside the class definition:

```cpp
class MyClass
{
public:
    MyClass()
    {
    }

    ~MyClass()
    {
    }

private:

};
```

## for vs. forr vs rfor

There are three different **for** snippets that provide different kinds of `for` loops.

The **rfor** snippet provides a [range-based](/cpp/cpp/range-based-for-statement-cpp) for loop (link). This construct is preferred over index-based `for` loops.

```cpp
for (auto& i : v)
{

}
```

The **for** snippet provides a `for` loop in which the condition is based on the length (in `size_t`) of an object.

```cpp
for (size_t i = 0; i < length; i++)
{

}
```

The **forr** snippet provides a reverse `for` loop in which the condition is based on the length (in integers) of an object.

```cpp
for (int i = length - 1; i >= 0; i--)
{

}
```

## The destructor snippet (~)

The destructor snippet (**~**) shows different behavior in different contexts. If you insert this snippet inside a class, it provides a destructor for that class. For example, given the following code:

```cpp
class SomeClass {

};
```

If you insert the destructor snippet, it provides a destructor for `SomeClass`:

```cpp
class SomeClass {
    ~SomeClass()
    {

    }
};
```

If you try to insert the destructor snippet outside a class, it provides a destructor with a placeholder name:

```cpp
~TypeNamePlaceholder()
{
```

## See also

- [Code snippets](../ide/code-snippets.md)