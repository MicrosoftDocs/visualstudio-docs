---
title: Understand and use code snippets
description: Explore code snippets, which are small blocks of reusable code you can insert into a code file, and learn how to find and use them.
ms.date: 04/25/2025
ms.topic: conceptual
f1_keywords:
- vs.ExpansionManagerImport
- vs.codesnippetmanager
helpviewer_keywords:
- surround with
- code snippets
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
dev_langs:
- CSharp
- VB
- CPP
---

# Code snippets and how to use them

Code snippets are small blocks of reusable code that you can add to a code file. Snippets usually contain often-used code blocks such as `Try...Finally` or `If...Else` blocks. You can also use code snippets to add entire classes or methods.

A code snippet has a title that you use to select the snippet, and can have a shortcut name you can type to insert the snippet. Snippets can also contain replacement parameters, which act as placeholders. Snippets are available for many languages, including C#, C++, and Visual Basic.

## Expansion snippets and surround-with snippets

You can add two kinds of code snippets to your code:

- An *expansion* snippet is added at a specified insertion point.
- A *surround-with* snippet is added around selected code, and is available only for C# and C++.

## Find available snippets

To view the available snippets for a language, select **Tools** > **Code Snippets Manager** from the menu bar, or press **Ctrl**+**K**, **B**, and then select the language you want from the dropdown menu.

![Screenshot of the Code Snippets Manager dialog box.](media/code-snippets-manager.png)

To create and import your own snippet so it appears in the snippet list, see [Walkthrough: Create a code snippet in Visual Studio](walkthrough-creating-a-code-snippet.md).

## Add a snippet to a code file

To add a snippet to a code file:

1. In the code editor, place your cursor or select C# or C++ code where you want to add the snippet.

1. Take one of the following actions:

   - On the Visual Studio menu bar, choose **Edit** > **IntelliSense** > **Insert Snippet** or **Edit** > **IntelliSense** > **Surround With**.
   - Right-click, and choose **Snippet** > **Insert Snippet** or **Snippet** > **Surround With** from the context menu.
   - From the keyboard, press **Ctrl**+**K**, **X** for an expansion snippet, or **Ctrl**+**K**, **S** for a surround-with snippet.

1. Double-click the snippet you want in the dropdown list, or type the snippet shortcut and press **Tab** or **Enter**.

### Add an expansion snippet

For example, the C# expansion snippet `tryf` adds the following `Try...Finally` block:

```csharp
try
{

}
finally
{

}
```

To add this expansion snippet:

1. In the code editor, position your cursor where you want to add the snippet.
1. Right-click and select **Insert Snippet** from the right-click context menu, or use the menu bar or keyboard commands.
1. Open the **Visual C#** folder, and then double-click **tryf** in the dropdown list, or select **tryf** and press **Tab** or **Enter**.

>[!TIP]
>You can also place your cursor at the insertion point, type *tryf*, and then press **Tab** twice.

### Add a surround-with snippet

In the following example of a C++ snippet, the shortcut `if` can be used either as an insertion snippet or a surround-with snippet. If you select the code line `return FALSE;` and then choose **Surround With** > **if**, the snippet is expanded around the line.

```cpp
if (true)
{
    return FALSE;
}
```

## Snippet replacement parameters

Snippets can contain replacement parameters, which are placeholders you must replace to fit the code you're writing. In the previous example, `true` is a replacement parameter, which you replace with the appropriate condition. The replacement repeats for every instance of that replacement parameter in the snippet.

For example, Visual Basic has a code snippet that defines a property. To insert the snippet:

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

If you change `newPropertyValue` to `m_property`, every instance of `newPropertyValue` changes. If you change `String` to `Int` in the property declaration, the value in the `Set` method also changes to `Int`.

## Best practices for using code snippets

The code in a code snippet shows only the most basic way to do something. For most applications, the code must be modified to suit the application.

### Exception handling

Typically, code snippet `Try...Catch` blocks catch and rethrow all exceptions, but that might not be the right choice for your project. For each exception, there are several ways to respond. For examples, see [How to handle an exception using try/catch (C#)](/dotnet/csharp/programming-guide/exceptions/how-to-handle-an-exception-using-try-catch) and [Try...Catch...Finally statement (Visual Basic)](/dotnet/visual-basic/language-reference/statements/try-catch-finally-statement).

### File locations

When you adapt file locations to your application, be sure to consider the following factors.

- Find an accessible location. Users might not have access to the computer's *Program Files* folder, so storing user files with the application files might not work.

- Find a secure location. Storing files in the root folder like *C:\\* isn't secure. For application data, it's best to use the *Application Data* folder. For individual user data, the application can create a file in each user's *Documents* folder.

- Use a valid file name. You can use the <xref:System.Windows.Forms.OpenFileDialog> and <xref:System.Windows.Forms.SaveFileDialog> controls to reduce the likelihood of invalid file names.

- Be aware that a user-selected file could be deleted before your code can manipulate the file. Also, a user might not have permission to write to the file.

### Security

The security of a snippet depends on where you use it in the source code and how you modify it once it's in the code. The following list contains a few areas to consider:

- File and database access
- Code access security
- Protecting resources such as event logs and registry
- Storing secrets
- Verifying inputs
- Passing data to scripting technologies

For more information, see [Secure applications](securing-applications.md).

### Downloaded code snippets

Code snippets installed by Visual Studio aren't security hazards themselves. However, they can create security risks in your application. Snippets downloaded from the internet should be treated with extreme caution, like any other downloaded content. Download snippets only from sites you trust, and use up-to-date virus software.

Open all downloaded snippet files in Notepad or the XML editor of Visual Studio and review them carefully before installing them. Beware of the following issues:

  - Snippet code that could damage your system if you execute it. Read the source code carefully before running it.

  - `HelpURL` blocks in snippet files containing URLs that execute malicious script files or display offensive websites.

  - Snippets containing references that are added silently to your project and can be loaded from anywhere on your system. You might download these references from the same location you download a snippet from. The snippet could then call a method in the reference that executes malicious code. To detect such references, review the `Imports` and `References` blocks of the snippet file.

## Related content

- [Walkthrough: Create a code snippet in Visual Studio](walkthrough-creating-a-code-snippet.md)
- [Distribute code snippets as a Visual Studio extension](how-to-distribute-code-snippets.md)
- [C# code snippets](visual-csharp-code-snippets.md)
- [Visual C++ code snippets](visual-cpp-code-snippets.md)
- [Code snippets schema reference](code-snippets-schema-reference.md)

