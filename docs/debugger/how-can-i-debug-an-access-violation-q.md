---
title: Debug a C++ access violation | Microsoft Docs
description: See tips on troubleshooting an access violation when more than one pointer is a candidate. Recent versions of Visual Studio name the errant pointer.

ms.date: 02/05/2019
ms.topic: how-to
f1_keywords: 
  - vs.debug.access
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - access violation debugging
  - debugging [Visual Studio], access violations
ms.assetid: 9311d754-0ce9-4145-b147-88b6ca77ba63
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - cplusplus
---
# How Can I Debug a C++ Access Violation?

## Problem Description

My program produces an access violation. How can I debug this?

## Solution

If you get an access violation on a line of code that dereferences  multiple pointers, it can be difficult to find out which pointer caused the access violation. Starting in Visual Studio 2015 Update 1, the exception dialog box now explicitly names the pointer that caused the access violation.

For example, given the following code, you should get an access violation:

```C++
#include <iostream>
using namespace std;

class ClassC {
public:
  void printHello() {
    cout << "hello world";
  }
};

class ClassB {
public:
  ClassC* C;
  ClassB() {
    C = new ClassC();
  }
};

class ClassA {
public:
  ClassB* B;
  ClassA() {
    // Uncomment to fix
    // B = new ClassB();
  }
};

int main() {
  ClassA* A = new ClassA();
  A->B->C->printHello();

}
```

If you run this code in Visual Studio 2015 Update 1, you should see the following exception dialog:

![Screenshot of a Microsoft Visual Studio exception dialog, showing a read access violation for 'A->B was nullptr'. The Break button is selected.](../debugger/media/accessviolationcplus.png)

If you cannot determine why the pointer caused an access violation, trace through the code to make sure that the pointer causing the problem has been assigned correctly.  If it is passed as a parameter, make sure that it is  passed correctly, and you aren't accidentally creating a [shallow copy](https://stackoverflow.com/questions/184710/what-is-the-difference-between-a-deep-copy-and-a-shallow-copy). Then verify that the values are not being unintentionally changed somewhere in the program by creating a Data Breakpoint for the pointer in question to make sure it isn't being modified elsewhere in the program. For more information about data breakpoints, see the data breakpoint section in [Using Breakpoints](../debugger/using-breakpoints.md).

## See also
- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.md)