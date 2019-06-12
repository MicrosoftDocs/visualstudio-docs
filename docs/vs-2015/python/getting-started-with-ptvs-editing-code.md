---
title: "Getting Started with PTVS: Editing Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-python
ms.topic: conceptual
ms.assetid: b412c87c-2f09-4e25-9cc8-ab54f4c44412
caps.latest.revision: 5
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# Getting Started with PTVS: Editing Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

PTVS provides the productive Visual Studio editor experience for Python.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=uZGZNEyyeKs&index=3&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff).  
  
 Start with the basic empty Python Application project template.  
  
 Start typing a `from … import` line in the editor.  You see the pop-up completion list has a full list of the modules that are available for import.  This list varies based on your version of Python and what libraries you installed.  Use the math library as an example.  You'll notice that as you type the list of completions filters to those items including the characters you’ve typed.  Complete the statement by importing the `sin` identifier.  
  
```python  
from math import sin  
  
```  
  
 While coding, if you use an identifier that is unbound but that can be found in your libraries, PTVS offers a pop-up quick fix to add the appropriate import statement you need.  For example, if you typed `cos`, then you would see **import from math** offered.  
  
 You can use a snippet to generate code.  Under the Edit menu, choose IntelliSense and then Insert Snippet.  Now choose Python, and then def.  Call the function `make_dot_string` and add one parameter `x`.  You can add assertions to the file now for test driven development, and you see PTVS already can offer the new function in completion lists.  
  
```python  
assert make_dot_string(90) == '          o'  
assert make_dot_string(180) == 'o'  
  
```  
  
 Now go back to the new function and begin to writing the following body:  
  
```python  
return " " * int(10 * cos(radians(x)) + 10) + "o"  
  
```  
  
 You see that PTVS assumes the parameter is an integer because PTVS has analyzed the call sites to this function.   You will also need to use the quick fix to import `radians`.  
  
 Use another snippet to create a main block by typing `main` at top-level, invoking the smart tag UI, and using tab to choose “def main ….”  Write a basic loop to call `make_dot_string`.  You see PTVS knows the function returns a string by if you press period and see the offered completions.  This type information will flow throughout your entire program, so wherever your values end up, we can provide tooltips and completions that will help you to better understand and write your code.  
  
 Add a call to print, and you should have a main similar to the following:  
  
```python  
def main ():  
    for i in range(10000000):  
        s = make_dot_string(i)  
        print(s)  
```  
  
 If you press F5, the code runs in a cmd.exe window, and you see a dot oscillating back and forth.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=uZGZNEyyeKs&index=3&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff).  
  
## See Also  
 [Wiki documentation](https://github.com/Microsoft/PTVS/wiki/Editor-Features)   
 [PTVS Getting Started and Deep Dive Videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)
