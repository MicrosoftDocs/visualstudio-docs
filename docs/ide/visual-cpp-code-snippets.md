---
title: Visual C++ code snippets
description: Learn how to use code snippets to add commonly used code to your C++ code files.
ms.date: 04/05/2024
ms.topic: reference
author: tylermsft
ms.author: twhitney
manager: coxford
dev_langs:
 - CPP
---
# Visual C++ code snippets

In Visual Studio, you can use code snippets to add commonly used code to your C++ code files. Code snippets can make writing program code quicker, easier, and more reliable.

## Complete list of C++ code snippets

Code snippets work much the same way in C++ and C#, but the set of default code snippets is different. To see the list of available C++ code snippets, select **Tools** > **Code Snippets Manager** from the Visual Studio menu bar, or press **Ctrl**+**K**, **B**, and then select **Visual C++** from the **Language** dropdown menu.

Expand the **Visual C++** folder to see the names of all the C++ code snippets in alphabetical order. Select a snippet to see information about the snippet. For more information about code snippets, see [Code snippets](code-snippets.md).

## Expansion snippets and surround-with snippets

You can insert *expansion* code snippets at particular locations in your code, or surround selected code with *surround-with* code snippets. 

### Insert a code snippet

To insert a C++ code snippet:

1. Open a C++ *.cpp* or *.h* file and put your insertion point somewhere in the file.

1. Take one of the following actions:

   - Right-click and select **Insert Snippet** from the context menu.
   - On the Visual Studio menu bar, select **Edit** > **IntelliSense** > **Insert Snippet**.
   - Press **Ctrl**+**K**, **X**.

1. Double-click **#if** in the dropdown list, or type *#if* and press **Enter** or **Tab**. The following code is added at the insertion point:

   ```cpp
   #if 0
   
   #endif // 0
   ```

1. Replace the `0` with the correct condition.

### Surround selected code with a code snippet

To surround selected code with a code snippet:

1. Open a C++ *.cpp* or *.h* file and select some code. In the following example, the line `#include "pch.h"` is selected.

1. Take one of the following actions:

   - Right-click and select **Surround With** from the context menu.
   - On the Visual Studio menu bar, select **Edit** > **IntelliSense** > **Surround With**.
   - Press **Ctrl**+**K**, **S**.

1. Double-click **#if** in the dropdown list, or type *#if* and press **Enter** or **Tab**. The code surrounds the selected line.

   ```cpp
   #if 0
   #include "pch.h"  // or whatever line you had selected
   #endif // 0
   ```

1. Replace the `0` with the correct condition.

## C++ code snippet usage

The names of most C++ code snippets are self-explanatory, but some names might be confusing.

### Class, classi

The `class` snippet provides the definition of a class named `MyClass`. The definitions of the appropriate default constructor and destructor are located outside the class.

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

The `classi` code snippet also provides the definition of a class named `MyClass`, but the default constructor and destructor are defined inside the class definition.

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

### For, forr, rfor

The three different `for` snippets provide different kinds of `for` loops.

- The `rfor` snippet provides a [range-based for loop](/cpp/cpp/range-based-for-statement-cpp). This construct is preferred over index-based `for` loops.

  ```cpp
  for (auto& i : v)
  {
  
  }
  ```

- The `for` snippet provides a `for` loop in which the condition is based on the length of an object in `size_t`.

  ```cpp
  for (size_t i = 0; i < length; i++)
  {
  
  }
  ```

- The `forr` snippet provides a reverse `for` loop in which the condition is based on the length of an object in integers.

  ```cpp
  for (int i = length - 1; i >= 0; i--)
  {
  
  }
  ```

### The destructor snippet (~)

The destructor snippet `~` shows different behavior in different contexts. If you insert this snippet inside a class, it provides a destructor for that class.

For example, if you insert the destructor snippet inside a class named `SomeClass`, it provides a destructor for `SomeClass`.

```cpp
class SomeClass {
    ~SomeClass()
    {

    }
};
```

If you insert the destructor snippet outside a class, it provides a destructor with a placeholder name.

  ```cpp
~TypeNamePlaceholder()
{

}
  ```

## Related content

- [Code snippets](code-snippets.md)
- [Code snippets schema reference](code-snippets-schema-reference.md)
