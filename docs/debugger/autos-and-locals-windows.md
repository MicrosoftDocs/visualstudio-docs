---
title: "Inspect variables in the Autos and Locals windows | Microsoft Docs"
ms.custom: "H1Hack27Feb2017"
ms.date: "04/17/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
f1_keywords: 
  - "vs.debug.autos"
  - "vs.debug.locals"
helpviewer_keywords: 
  - "debugger, variable windows"
  - "debugging [Visual Studio], variable windows"
ms.assetid: bb6291e1-596d-4af0-9f22-5fd713d6b84b
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Inspect variables in the Autos and Locals windows in Visual Studio

The **Autos** window and the **Locals** window show variable values while you are debugging. The **Autos** window displays variables used around the current line where the debugger is stopped. The **Locals** window displays variables that are defined in the local scope, which is usually the function or method currently being executed.  
  
To open the **Autos** window, while debugging, select **Debug** > **Windows** > **Autos** or press **Ctrl**+**Alt**+**V** > **A**.  

To open the **Locals** window, while debugging, select **Debug** > **Windows** > **Locals** or press **Alt**+**4**.

If you need more information about basic debugging, see [Getting started with the Debugger](../debugger/getting-started-with-the-debugger.md).  
  

## Use the Autos and Locals windows

The default numeric format in debugger windows is decimal. To change it to hexadecimal, right-click in the **Locals** or **Autos** window and select **Hexadecimal Display**. The change affects all debugger windows. 
 
Arrays and objects show in the **Autos** and **Locals** windows as tree controls. Select the arrow to the left of a variable name to expand the view to show fields and properties. Here is an example of a <xref:System.IO.FileStream?displayProperty=fullName> object in the **Locals** window:  
  
![Locals-FileStream](../debugger/media/locals-filestream.png "Locals-FileStream")  
  
The value of a variable is sometimes red in the **Locals** and **Autos** windows. These are variable values that have been changed since the last evaluation. The change could be from a previous debugging session, or because the value was changed in the window.  
  
## Edit variable values in the Autos or Locals window  
To edit the values of most variables in the **Autos** or **Locals** windows, double-click the value you want to change and type the new value.  
  
You can enter an expression for a value, for example `a + b`. The debugger accepts most valid language expressions.  
  
In native C++ code, you might have to qualify the context of a variable name. For more information, see [Context operator (C++)](../debugger/context-operator-cpp.md).  
 
You should exercise caution when changing values. Here are some possible issues:  
  
-   Evaluating some expressions can change the value of a variable or otherwise affect the state of your program. For example, evaluating `var1 = ++var2` changes the value of both `var1` and `var2`.  
  
    Expressions that change data are said to have [side effects](https://en.wikipedia.org/wiki/Side_effect_\(computer_science\)), which can produce unexpected results if you are not aware of them. Make sure you understand the consequences before you make these changes.  
  
-   Editing floating-point values can result in minor inaccuracies because of decimal-to-binary conversion of fractional components. Even a seemingly harmless edit can result in changes to some of the bits in the floating-point variable.  
  
### Change the context for the Autos or Locals window 

You can use the **Debug Location** toolbar to select a desired function, thread, or process, which changes the context for the **Autos** and **Locals** windows. 

To enable the **Debug Location** toolbar, click in an empty part of the toolbar area and select **Debug Location** from the dropdown, or select **View** > **Toolbars** > **Debug Location**. 

Set a breakpoint and start debugging. When the breakpoint is hit, execution stops and you can see the location in the **Debug Location** toolbar.
  
![Debug Location toolbar](../debugger/media/debuglocationtoolbar.png "Debug Location toolbar")   

## <a name="bkmk_whatvariables"></a> Variables in the Autos window  

 You can use the **Autos** window in C#, Visual Basic, and C++ code, but not JavaScript or F#. 
 
 Different code languages display different variables in the **Autos** window. 
  
 In C# and Visual Basic, the **Autos** window displays any variable used on the current or preceding line. For example, in C# or Visual Basic code, declare four variables as follows:

```csharp
    public static void Main()
    {
       int a, b, c, d;
       a = 1;
       b = 2;
       c = 3;
       d = 4;
    }
```

 Set a breakpoint on the line `c = 3`; and run the debugger. When execution stops, the **Autos** window will look like this:  

 ![Autos-CSharp](../debugger/media/autos-csharp.png "Autos-CSharp")  

 The value of `c` is 0, because the line `c = 3` has not yet been executed.  

 In C++, the **Autos** window displays the variables used at least three lines before the current line where execution is stopped. For example, in C++ code, declare six variables:

```C++
    void main() {
        int a, b, c, d, e, f;
        a = 1;
        b = 2;
        c = 3;
        d = 4;
        e = 5;
        f = 6;
    }
```

 Set a breakpoint on the line `e = 5;` and run the debugger. When execution stops, the **Autos** window will look like this:  
  
 ![Autos-C++](../debugger/media/autos-cplus.png "Autos-C++")  
  
 The variable `e` is uninitialized, because the line `e = 5` has not yet been executed.  
  
###  <a name="bkmk_returnValue"></a> View return values of method calls  
 In .NET and C++ code, you can examine return values in the **Autos** window when you step over or out of a method call. Viewing return values is useful when the results of the call are not stored in local variables; for example, when a method is used as a parameter or as a return value of another method.  
  
 The following C# code adds the return values of two functions:  

```csharp
static void Main(string[] args)  
{  
    int a, b, c, d;  
    a = 1;  
    b = 2;  
    c = 3;  
    d = 4;  
    int x = sumVars(a, b) + subtractVars(c, d);  
}  
  
private static int sumVars(int i, int j)  
{  
    return i + j;  
}  
  
private static int subtractVars(int i, int j)  
{  
    return j - i;  
}  
```

 Set a breakpoint on the `int x = sumVars(a, b) + subtractVars(c, d);` line.  
  
 Start debugging, and when execution pauses at the breakpoint, select **Step Over** or press **F10**. You should see the following in the **Autos** window:  
  
 ![Autos return value C#](../debugger/media/autosreturnvaluecsharp2.png "Autos return value C#")  
  
## See also  
 [Debugger windows](../debugger/debugger-windows.md)
