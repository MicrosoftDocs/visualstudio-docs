---
title: "Getting Started with PTVS: Debugging | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-python
ms.topic: conceptual
ms.assetid: 82803559-1d60-4c57-98fb-2dc1e0182b42
caps.latest.revision: 5
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# Getting Started with PTVS: Debugging
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio's interactive debugger makes it easy to diagnose and resolve issues in your Python code.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=bO7wpzgy74A&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=4).  
  
 In the previous getting started topic, you create an empty Python Application project and entered the following code into PythonApplication1.py:  
  
```python  
from math import sin, cos, radians  
import sys  
  
def make_dot_string(x):  
    return ' ' * int(10 * cos(radians(x)) + 10) + 'o'  
  
assert make_dot_string(90) == "          o"  
assert make_dot_string(180) == "o"  
  
def main():  
    for i in range(10000000):  
        s = make_dot_string(i)  
        print(s)  
  
if __name__ == "__main__":  
    sys.exit(int(main() or 0))  
```  
  
 Normally when you’re working on code in Visual Studio, you’ll start running your code by pressing F5.  This command builds any parts of your project that need to be built and starts running the code under the debugger.  You can press Ctrl+F5 to build and launch your code without the debugger.  With the debugger, your code runs a bit slower, but you get great debugging features for that cost.  
  
 Another way to launch your code is with the Step In command (normally bound to F11).  It is like F5, but it pauses the execution at each statement.  If you want to break the program at a certain point, you can press the left pointer button in the left margin of the code editor to set a breakpoint.  When you press F5, the program’s execution will break or stop at the line with the breakpoint.  The Debug menu has more options for stepping; for example, step over function calls (F10), step into function calls (F11), or skip at the end of a function (shift-F11).  
  
 There is more you can do when broken in the debugger.  The Locals window shows the current values of local variables.  As you step your code, the locals display automatically updates.  The Autos window that shows variables near the current line where execution stopped.  In the Watch window you can type any Python expression that the debugger will automatically update each time execution stops.  You can also hover the pointer over variables in editor windows to see a pop-up display of the variable’s values, and this data tip display allows you to inspect into objects.  Some data types have special visualizers that are accessible from the data tip display (for example, strings with special formatting such as HTML, XML, or JSON).  
  
 The Call Stack window shows the pending function calls that led to the current statement where the debugger is stopped.  You can choose different stack frames (lines in the call stack) to jump to where the code will continue executing in each function, look a values of variables, and so on.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=bO7wpzgy74A&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=4).  
  
## See Also  
 [Wiki documentation](https://github.com/Microsoft/PTVS/wiki/Debugging)   
 [PTVS Getting Started and Deep Dive Videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)
