---
title: Debug language integrated query (LINQ)
description: Debug language integrated query (LINQ) in Visual Studio. View LINQ results. Understand behavioral differences when stepping into LINQ code.
ms.date: "11/04/2016"
ms.topic: how-to
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging, LINQ"
  - "LINQ, viewing results in debugger"
  - "LINQ, debugging"
  - "LINQ, stepping"
  - "LINQ, edit and continue"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugging LINQ

Visual Studio supports the debugging of language integrated query (LINQ) code, with some limitations. Most debugging features work with LINQ statements, including stepping, setting breakpoints, and viewing results in debugger windows. This topic describes the major limitations of LINQ debugging.

## <a name="BKMK_ViewingLINQResults"></a> Viewing LINQ Results
 You can view the result of a LINQ statement by using DataTips, the Watch window, and the QuickWatch dialog box. When you use a source window, you can pause the pointer on a query in the source window and a DataTip will appear. You can copy a LINQ variable and paste it into the Watch window or QuickWatch dialog box.

 In LINQ, a query is not evaluated when it is created or declared, but only when the query is used. Therefore, the query does not have a value until it is evaluated. For a full description of query creation and evaluation, see [Introduction to LINQ Queries (C#)](/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries) or [Writing Your First LINQ Query](/dotnet/visual-basic/programming-guide/concepts/linq/writing-your-first-linq-query).

 To display the result of a query, the debugger must evaluate it. This implicit evaluation, which occurs when you view a LINQ query result in the debugger, has some effects you should consider:

- Each evaluation of the query takes time. Expanding the results node takes time. For some queries, repeated evaluation might result in a noticeable performance penalty.

- Evaluating a query can result in side effects, which are changes to the value of data or the state of your program. Not all queries have side effects. To determine whether a query may be safely evaluated without side effects, you must understand the code that implements the query.

## <a name="BKMK_SteppingAndLinq"></a> Stepping and LINQ
 When you are debugging LINQ code, stepping has some behavioral differences you should know about.

### LINQ to SQL
 In LINQ to SQL queries, the predicate code is beyond the control of the debugger. Therefore, you cannot step into the predicate code. Any query that compiles to an expression tree produces code that is beyond the control of the debugger.

### Stepping in Visual Basic
 When you are stepping through a Visual Basic program and the debugger encounters a query declaration, it does not step into the declaration but highlights the entire declaration as a single statement. This behavior occurs because the query is not evaluated until it is called. For more information, see [Introduction to LINQ in Visual Basic](/dotnet/visual-basic/programming-guide/language-features/linq/introduction-to-linq).

 If you step through the following example code, the debugger highlights the query declaration, or query creation, as a single statement.

```vb
Function MyFunction(ByVal x As Char)
    Return True
End Function

Sub Main()
    'Query creation
    Dim x = From it In "faoaoeua" _
            Where MyFunction(it) _
            Select New With {.a = it}

    ' Query execution
    For Each cur In x
        Console.WriteLine(cur.ToString())
    Next
End Sub
```

 When you step again, the debugger highlights `For Each cur In x`. On the next step, it steps into the function `MyFunction`. After stepping through `MyFunction`, it jumps back to `Console.WriteLine(cur.ToSting())`. At no point does it step through the predicate code in the query declaration, although the debugger does evaluate that code.

### Replacing a Predicate with a Function to Enable Stepping (Visual Basic)
 If you have to step through predicate code for debugging purposes, you can replace the predicate with a call to a function that contains the original predicate code. For example, suppose you have this code:

```vb
Dim items() as integer ={1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

' Get the even numbers
Dim query = From nextInt in items Where nextInt Mod 2 = 0 Select nextInt

For each item in query
      Console.WriteLine(item)
Next
```

 You can move the predicate code to a new function, called `IsEven`:

```vb
Dim items () as integer ={1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

' Get the even numbers
Dim query = From nextInt in items Where IsEven(nextInt) Select nextInt

For each item in query
      Console.WriteLine(item)
Next
...
Function IsEven(item As =Integer) as Boolean
      Return item Mod 2 = 0
End Function
```

 The revised query calls the function `IsEven` on each pass through the `items`. You can use the debugger windows to see whether each item meets the specified condition, and you can step through the code in `IsEven`. The predicate in this example is fairly simple. However, if you have a more difficult predicate you have to debug, this technique can be very useful.

## <a name="BKMK_EditandContinueNotSupportedforLINQ"></a> Edit and Continue Not Supported for LINQ
 Edit and Continue supports changes to LINQ queries with limitations. For details, see [EnC Supported Changes](https://github.com/dotnet/roslyn/blob/main/docs/wiki/EnC-Supported-Edits.md)

## Related content

- [Debugging SQL](/previous-versions/visualstudio/visual-studio-2010/zefbf0t6\(v\=vs.100\))
- [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md)
- [Introduction to LINQ Queries (C#)](/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)
- [Introduction to LINQ in Visual Basic](/dotnet/visual-basic/programming-guide/language-features/linq/introduction-to-linq)
