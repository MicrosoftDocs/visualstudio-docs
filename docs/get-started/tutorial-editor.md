---
title: Introduction to editing in the code editor
ms.date: 11/30/2017
ms.technology: vs-ide-general
ms.custom: get-started
ms.topic: tutorial
author: jillre
ms.author: jillfra
manager: jillfra
dev_langs:
  - "CSharp"
ms.workload:
  - "multiple"
---
# Learn to use the code editor

In this 10-minute introduction to the code editor in Visual Studio, we'll add code to a file to look at some of the ways that Visual Studio makes writing, navigating, and understanding code easier.

::: moniker range="vs-2017"

> [!TIP]
> If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range="vs-2019"

> [!TIP]
> If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

This article assumes you're already familiar with a programming language. If you aren't, we suggest you look at one of the programming quickstarts first, such as create a web app with [Python](../ide/quickstart-python.md) or [C#](../get-started/csharp/tutorial-aspnet-core.md), or create a console app with [Visual Basic](../ide/quickstart-visual-basic-console.md) or [C++](/cpp/get-started/tutorial-console-cpp).

## Create a new code file

Start by creating a new file and adding some code to it.

::: moniker range="vs-2017"

1. Open Visual Studio.

::: moniker-end

::: moniker range=">=vs-2019"

1. Open Visual Studio. Press **Esc** or click **Continue without code** on the start window to open the development environment.

::: moniker-end

2. From the **File** menu on the menu bar, choose **New** > **File**.

3. In the **New File** dialog box, under the **General** category, choose **Visual C# Class**, and then choose **Open**.

   A new file opens in the editor with the skeleton of a C# class. (Notice that we don't have to create a full Visual Studio project to gain some of the benefits that the code editor offers; all you need is a code file!)

   ![C# code file in Visual Studio](media/tutorial-editor.png)

## Use code snippets

Visual Studio provides useful *code snippets* that you can use to quickly and easily generate commonly used code blocks. [Code snippets](../ide/code-snippets.md) are available for different programming languages including C#, Visual Basic, and C++. Let's add the C# `void Main` snippet to our file.

1. Place your cursor just above the final closing brace **}** in the file, and type the characters `svm`. (`svm` stands for `static void Main`; the [Main()](/dotnet/csharp/programming-guide/main-and-command-args/) method is the entry point for C# applications.)

   A pop-up dialog box appears with information about the `svm` code snippet.

   ![IntelliSense for code snippet in Visual Studio](media/tutorial-intellisense-snippet.png)

1. Press **Tab** twice to insert the code snippet.

   You see the `static void Main()` method signature get added to the file.

The available code snippets vary for different programming languages. You can look at the available code snippets for your language by choosing **Edit** > **IntelliSense** > **Insert Snippet**, and then choosing your language's folder. For C#, the list looks like this:

![C# code snippet list](media/tutorial-code-snippet-list.png)

The list includes snippets for creating a [class](/dotnet/csharp/programming-guide/classes-and-structs/classes), a [constructor](/dotnet/csharp/programming-guide/classes-and-structs/constructors), a [for](/dotnet/csharp/language-reference/keywords/for) loop, an [if](/dotnet/csharp/language-reference/keywords/if-else) or [switch](/dotnet/csharp/language-reference/keywords/switch) statement, and more.

## Comment out code

The toolbar, which is the row of buttons under the menu bar in Visual Studio, can help make you more productive as you code. For example, you can toggle IntelliSense completion mode ([IntelliSense](../ide/using-intellisense.md) is a coding aid that displays a list of matching methods, amongst other things), increase or decrease a line indent, or comment out code that you don't want to compile. In this section, we'll comment out some code.

![Editor toolbar](media/tutorial-editor-toolbar.png)

1. Paste the following code into the `Main()` method body.

    ```csharp
    // _words is a string array that we'll sort alphabetically
    string[] _words = {
        "the",
        "quick",
        "brown",
        "fox",
        "jumps"
    };

    string[] morewords = {
        "over",
        "the",
        "lazy",
        "dog"
    };

    IEnumerable<string> query = from word in _words
                                orderby word.Length
                                select word;
    ```

1. We're not using the `morewords` variable, but we may use it later so we don't want to completely delete it. Instead, let's comment out those lines. Select the entire definition of `morewords` to the closing semi-colon, and then choose the **Comment out the selected lines** button on the toolbar. If you prefer to use the keyboard, press **Ctrl**+**K**, **Ctrl**+**C**.

   ![Comment out button](media/tutorial-comment-out.png)

   The C# comment characters `//` are added to the beginning of each selected line to comment out the code.

## Collapse code blocks

We don't want to see the empty [constructor](/dotnet/csharp/programming-guide/classes-and-structs/constructors) for `Class1` that was generated, so to unclutter our view of the code, let's collapse it. Choose the small gray box with the minus sign inside it in the margin of the first line of the constructor. Or, if you're a keyboard user, place the cursor anywhere in the constructor code and press **Ctrl**+**M**, **Ctrl**+**M**.

![Outlining collapse button](media/tutorial-collapse.png)

The code block collapses to just the first line, followed by an ellipsis (`...`). To expand the code block again, click the same gray box that now has a plus sign in it, or press **Ctrl**+**M**, **Ctrl**+**M** again. This feature is called [Outlining](../ide/outlining.md) and is especially useful when you're collapsing long methods or entire classes.

## View symbol definitions

The Visual Studio editor makes it easy to inspect the definition of a type, method, etc. One way is to navigate to the file that contains the definition, for example by choosing **Go to Definition** anywhere the symbol is referenced. An even quicker way that doesn't move your focus away from the file you're working in is to use [Peek Definition](../ide/go-to-and-peek-definition.md#peek-definition). Let's peek at the definition of the `string` type.

1. Right-click on any occurrence of `string` and choose **Peek Definition** from the content menu. Or, press **Alt**+**F12**.

   A pop-up window appears with the definition of the `String` class. You can scroll within the pop-up window, or even peek at the definition of another type from the peeked code.

   ![Peek definition window](media/tutorial-peek-definition.png)

1. Close the peeked definition window by choosing the small box with an "x" at the top right of the pop-up window.

## Use IntelliSense to complete words

[IntelliSense](../ide/using-intellisense.md) is an invaluable resource when you're coding. It can show you information about available members of a type, or parameter details for different overloads of a method. You can also use IntelliSense to complete a word after you type enough characters to disambiguate it. Let's add a line of code to print out the ordered strings to the console window, which is the standard place for output from the program to go.

1. Below the `query` variable, start typing the following code:

   ```csharp
   foreach (string str in qu
   ```

   You see IntelliSense show you **Quick Info** about the `query` symbol.

   ![IntelliSense word completion in Visual Studio](media/tutorial-intellisense-completion-list.png)

1. To insert the rest of the word `query` by using IntelliSense's word completion functionality, press **Tab**.

1. Finish off the code block to look like the following code. You can even practice using code snippets again by entering `cw` and then pressing **Tab** twice to generate the `Console.WriteLine` code.

   ```csharp
   foreach (string str in query)
   {
      Console.WriteLine(str);
   }
   ```

## Refactor a name

Nobody gets code right the first time, and one of the things you might have to change is the name of a variable or method. Let's try out Visual Studio's [refactor](../ide/refactoring-in-visual-studio.md) functionality to rename the `_words` variable to `words`.

1. Place your cursor over the definition of the `_words` variable, and choose **Rename** from the right-click or context menu, or press **Ctrl**+**R**, **Ctrl**+**R**.

   A pop-up **Rename** dialog box appears at the top right of the editor.

1. Enter the desired name **words**. Notice that the reference to `words` in the query is also automatically renamed. Before you press **Enter**, select the **Include comments** checkbox in the **Rename** pop-up box.

   ![Rename dialog box](media/tutorial-rename.png)

1. Press **Enter**.

   Both occurrences of `words` have been renamed, as well as the reference to `words` in the code comment.

## Next steps

> [!div class="nextstepaction"]
> [Learn about projects and solutions](../get-started/tutorial-projects-solutions.md)

## See also

- [Code snippets](../ide/code-snippets.md)
- [Navigate code](../ide/navigating-code.md)
- [Outlining](../ide/outlining.md)
- [Go To Definition and Peek Definition](../ide/go-to-and-peek-definition.md)
- [Refactoring](../ide/refactoring-in-visual-studio.md)
- [Use IntelliSense](../ide/using-intellisense.md)
