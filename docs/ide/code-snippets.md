---
title: "Code Snippets | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.topic: "article"
f1_keywords: 
  - "vs.ExpansionManagerImport"
  - "vs.codesnippetmanager"
helpviewer_keywords:
  - "surround with"
  - "code snippets"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
dev_langs:
 - CSharp
 - VB
 - CPP
ms.workload: 
  - "multiple"
---
# Code snippets

Code snippets are small blocks of reusable code that can be inserted in a code file using a context menu command or a combination of hotkeys. They typically contain commonly-used code blocks such as `try-finally` or `if-else` blocks, but they can be used to insert entire classes or methods.

Code snippets are available for a multitude of programming languages, including C#, C++, Visual Basic, XML, and T-SQL, to name a few. To view all the available installed snippets for a language, open the **Code Snippets Manager** from the **Tools** menu in Visual Studio, and choose the language from the drop-down menu at the top.

![Code Snippets Manager dialog box](media/code-snippets-manager.png)

Code snippets can be accessed in the following general ways:

- On the menu bar, choose **Edit** > **IntelliSense** > **Insert Snippet...**

- From the right-click or context menu in the code editor, choose **Snippet** > **Insert Snippet...**

- From the keyboard, press **Ctrl**+**K**+**X**

## Expansion snippets and surround-with snippets

In Visual Studio there are two kinds of code snippet: expansion snippets, which are added at a specified insertion point and may replace a snippet shortcut, and surround-with snippets (C# and C++ only), which are added around a selected block of code.

An example of an insertion snippet: in C# the shortcut tryf is used to insert a try-finally block:

```csharp
try
{

}
finally
{

}
```

You can insert this snippet by clicking **Insert Snippet** in the context menu of the code window, then **Visual C#**, then type `tryf`, and then press **Tab**. Or, you can type `tryf` and press **Tab** twice.

An example of a surround-with snippet: in C++ the shortcut `if` can be used either as an insertion snippet or as a surround-with snippet. If you select a line of code (for example `return FALSE;`), and then click **Surround With**, then **if**, the snippet is expanded around the line:

```cpp
if (true)
{
    return FALSE;
}
```

## Snippet replacement parameters

Snippets can contain replacement parameters, which are placeholders that you must replace to fit the precise code you are writing. In the previous example `true` is a replacement parameter, which you would replace with the appropriate condition. The replacement you make is repeated for every instance of the same replacement parameter in the snippet.

For example, in Visual Basic there is a code snippet that inserts a property. Click **Insert Snippet** on the context menu of the code window, then **Code Patterns**, then **Properties, Procedures, Events**, then **Define a Property**. The following code is inserted:

```vb
Private newPropertyValue As String
Public Property NewProperty() As String
    Get
        Return newPropertyValue
    End Get
    Set(ByVal value As String)
        newPropertyValue = value
    End Set
End Property
```

If you change `newPropertyValue` to `m_property`, then every instance of `newPropertyValue` is changed. If you change `String` to `Int` in the property declaration, then the value in the set method is also changed to `Int`.

## See also

[Walkthrough: Creating a Code Snippet](../ide/walkthrough-creating-a-code-snippet.md)  
[How to: Distribute Code Snippets](../ide/how-to-distribute-code-snippets.md)  
[Best Practices for Using Code Snippets](../ide/best-practices-for-using-code-snippets.md)  
[Troubleshooting Snippets](../ide/troubleshooting-snippets.md)  
[Visual C# Code Snippets](../ide/visual-csharp-code-snippets.md)  
[Visual C++ Code Snippets](../ide/visual-cpp-code-snippets.md)  
[Code Snippets Schema Reference](../ide/code-snippets-schema-reference.md)