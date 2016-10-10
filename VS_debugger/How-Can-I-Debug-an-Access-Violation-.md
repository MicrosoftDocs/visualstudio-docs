---
title: "How Can I Debug an Access Violation?"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9311d754-0ce9-4145-b147-88b6ca77ba63
caps.latest.revision: 18
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How Can I Debug an Access Violation?
## Problem Description  
 My program produces an access violation. How can I debug this?  
  
## Solution  
 If you get an access violation on a line of code that dereferences  multiple pointers, it can be difficult to find out which pointer caused the access violation. Starting in Visual Studio 2015 Update 1, the exception dialog box now explicitly names the pointer that caused the access violation.  
  
 For example, given the following code, you should get an access violation:  
  
```cpp  
#include <iostream>  
using namespace std;  
  
class ClassB {  
public:  
    	ClassC* C;  
    	ClassB() {  
		        C = new ClassC();  
    	}  
     void printHello() {  
		        cout << "hello world";  
    	}  
};  
  
class ClassA {  
public:  
    ClassB* B;  
	  ClassA() {  
		        B = nullptr;  
	    }  
};  
  
int main() {  
    ClassA* A = new ClassA();  
	  A->B->printHello();  
}  
```  
  
 If you run this code in Visual Studio 2015 Update 1, you should see the following exception dialog:  
  
 ![AccessViolationCPlus](../VS_debugger/media/AccessViolationCPlus.png "AccessViolationCPlus")  
  
 If you cannot determine why the pointer caused an access violation, trace through the code to make sure that the pointer causing the problem has been assigned correctly.  If it is passed as a parameter, make sure that it is  passed correctly, and you aren’t accidentally creating a [shallow copy](http://stackoverflow.com/questions/184710/what-is-the-difference-between-a-deep-copy-and-a-shallow-copy). Then verify that the values are not being unintentionally changed somewhere in the program by creating a Data Breakpoint for the pointer in question to make sure it isn’t being modified elsewhere in the program. For more information about data breakpoints, see the data breakpoint section in [Using Breakpoints](../VS_debugger/Using-Breakpoints.md).  
  
## See Also  
 [Debugging Native Code FAQs](../VS_debugger/Debugging-Native-Code-FAQs.md)