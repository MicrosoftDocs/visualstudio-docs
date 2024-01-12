---
title: Create and reuse code block snippets
description: Explore code snippets, which are small blocks of reusable code that you can insert into a code file, such as `try-finally` or `if-else` blocks, classes, or methods.
ms.date: 12/14/2022
ms.topic: conceptual
f1_keywords:
- vs.ExpansionManagerImport
- vs.codesnippetmanager
helpviewer_keywords:
- surround with
- code snippets
author: Mikejo5000
ms.author: mikejo
manager: jmartens
ms.subservice: general-ide
dev_langs:
- CSharp
- VB
- CPP
---

# Code snippets: what they are and how to add one

Code snippets are small blocks of reusable code that you can add to a code file. Snippets most commonly contain often-used code blocks such as `try-finally` or `if-else` blocks. However, you can also use them to add entire classes or methods. Your snippets can even contain replacement parameters, which act as placeholders. Snippets are available for many languages, including C#, C++, and Visual Basic, to name a few.

## Find available snippets

Before you (create a snippet of your own)[walkthrough-creating-a-code-snippet.md], you can check the available snippets for a language, select **Tools** > **Code Snippets Manager** from the menu bar (or, press **Ctrl**+**K**, **Ctrl**+**B**) and then select the language you want from the drop-down menu at the top of the dialog box.

![Screenshot of the Code Snippets Manager dialog box.](media/code-snippets-manager.png)

## Add a snippet to your code file

In Visual Studio, there are several different ways you can add a code snippet to a code file:

- On the menu bar, choose **Edit** > **IntelliSense** > **Insert Snippet**

- From the right-click or context menu in the code editor, choose **Snippet** > **Insert Snippet**

- From the keyboard, press **Ctrl**+**K**,**Ctrl**+**X**

## Expansion snippets and surround-with snippets

There are two kinds of code snippets you can add to your code.

|Snippet type  | How it's used  |
|---------|---------|
|*expansion* | Added at a specified insertion point and might replace a snippet shortcut |
|*surround-with* | Added around a selected block of code (available for C# and C++ only) |

In the following example of an expansion snippet in C#, the shortcut `tryf` adds a try-finally block:

```csharp
try
{

}
finally
{

}
```

Here's how to add this expansion snippet:

1. In the code window, position your cursor where you want to add the snippet.

1. Select **Insert Snippet** from the right-click context menu.

   Alternatively, from the **Edit** menu, select **IntelliSense** and then select the **Surround With** command.

1. Select **Visual C#**, then type `tryf`, and then press **Tab**. (Or, you can type `tryf` and press **Tab** twice.)

In the following example of a surround-with snippet in C++, the shortcut `if` can be used either as an insertion snippet or as a surround-with snippet. If you select a line of code (for example `return FALSE;`), and then choose **Surround With** > **if**, the snippet is expanded around the line:

```cpp
if (true)
{
    return FALSE;
}
```

::: moniker range="<=vs-2019"
> [!TIP]
> In Visual Studio 2019, you can use the **Ctrl**+**K**, **Ctrl**+**S** keyboard shortcut to insert a surround-with code snippet.
::: moniker-end

## Snippet replacement parameters

Snippets can contain replacement parameters, which are placeholders that you must replace to fit the code you're writing. In the previous example, `true` is a replacement parameter, which you'd replace with the appropriate condition. The replacement you make is repeated for every instance of the same replacement parameter in the snippet.

For example, in Visual Basic there's a code snippet that inserts a property. 

To insert the snippet:

1. In the right-click context menu in a Visual Basic code file, select **Snippet** > **Insert Snippet**.
2. Select **Code Patterns** > **Properties, Procedures, Events** > **Define a Property**.

![Screenshot of the code snippet menu for Define a Property.](media/code-snippets-vb-property.png)

The following code is inserted:

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

## Best practices for using code snippets

The code in a code snippet shows only the most basic way to do something. For most applications, the code must be modified to suit the application.

### Handling exceptions

Typically, code snippet Try...Catch blocks catch and rethrow all exceptions. That may not be the right choice for your project. For each exception, there are several ways to respond. For examples, see [How to: Handle an exception using try/catch (C#)](/dotnet/csharp/programming-guide/exceptions/how-to-handle-an-exception-using-try-catch) and [Try...Catch...Finally statement (Visual Basic)](/dotnet/visual-basic/language-reference/statements/try-catch-finally-statement).

### File locations

When you adapt file locations to your application, you should think about the following:

- Finding an accessible location. Users may not have access to the *Program Files* folder of the computer, so storing files with the application files may not work.

- Finding a secure location. Storing files in the root folder (*C:\\*) is not secure. For application data, we recommend the *Application Data* folder. For individual user data, the application can create a file for each user in the *Documents* folder.

- Using a valid file name. You can use the <xref:System.Windows.Forms.OpenFileDialog> and <xref:System.Windows.Forms.SaveFileDialog> controls to reduce the likelihood of invalid file names. Be aware that between the time the user selects a file and the time your code manipulates the file, the file may be deleted. In addition, the user may not have permissions to write to the file.

### Security

How secure a snippet is depends on where it is used in the source code and how it is modified once it is in the code. The following list contains a few of the areas that must be considered.

- File and database access

- Code access security

- Protecting resources (such as event logs, registry)

- Storing secrets

- Verifying inputs

- Passing data to scripting technologies

For more information, see [Securing applications](../ide/securing-applications.md).

### Downloaded code snippets

IntelliSense code snippets installed by Visual Studio are not in themselves a security hazard. However, they can create security risks in your application. Snippets downloaded from the Internet should be treated like any other downloaded content - with extreme caution.

- Download snippets only from sites you trust, and use up-to-date virus software.

- Open all downloaded snippet files in Notepad or the XML editor of Visual Studio and review them carefully before installing them. Look for the following issues:

  - The snippet code could damage your system if you execute it. Read the source code carefully before running it.

  - The Help URL block of the snippet file can contain URLs that execute a malicious script file or display an offensive website.

  - The snippet may contain references that are added silently to your project and may be loaded from anywhere on your system. These references may have been downloaded to your computer from where you downloaded the snippet. The snippet may then make a call to a method in the reference that executes malicious code. To protect yourself against such an attack, review the Imports and References blocks of the snippet file.

## Related content

- [Create a code snippet](walkthrough-creating-a-code-snippet.md).
- [Distribute code snippets](how-to-distribute-code-snippets.md)
- [C# code snippets](visual-csharp-code-snippets.md)
- [C++ code snippets](visual-cpp-code-snippets.md)
- [Code snippets schema reference](code-snippets-schema-reference.md)

