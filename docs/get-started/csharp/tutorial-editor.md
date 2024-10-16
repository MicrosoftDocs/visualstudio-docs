---
title: "Tutorial: Editing for C# developers"
description: Explore the code editor in Visual Studio and learn some of the ways that Visual Studio makes writing, navigating, and understanding C# code easier.
ms.custom: vs-acquisition
ms.date: 09/14/2021
ms.subservice: general-ide
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: mijacobs
dev_langs:
- CSharp
---
# Learn to use the code editor with C\#

In this 10-minute introduction to the code editor in Visual Studio, we'll add code to a file to look at some of the ways that Visual Studio makes writing, navigating, and understanding C# code easier.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page to install it for free.

This article assumes you're already familiar with C#. If you aren't, we suggest you look at a tutorial such as [Get started with C# and ASP.NET Core in Visual Studio](tutorial-aspnet-core.md) first.

> [!TIP]
> To follow along with this article, make sure you have the C# settings selected for Visual Studio. For information about selecting settings for the integrated development environment (IDE), see [Select environment settings](visual-studio-ide.md#select-environment-settings).

## Create a new code file

Start by creating a new file and adding some code to it.

::: moniker range="vs-2019"

1. Open Visual Studio. Press **Esc** or click **Continue without code** on the start window to open the development environment.

1. From the **File** menu on the menu bar, choose **New** > **File**, or press **Ctrl**+**N**.

1. In the **New File** dialog box, under the **General** category, choose **Visual C# Class**, and then choose **Open**.

   A new file opens in the editor with the skeleton of a C# class. (Notice that we don't have to create a full Visual Studio project to gain some of the benefits that the code editor offers; all you need is a code file!)

   ![Screenshot of a C# code file in Visual Studio.](../media/tutorial-editor.png)

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio. Press **Esc**, or choose **Continue without code** on the start window, to open the development environment.

1. From the **File** menu on the menu bar, choose **New** > **File**, or press **Ctrl**+**N**.

1. In the **New File** dialog box, under the **General** category, choose **Visual C# Class**, and then choose **Open**.

   A new file opens in the editor with the skeleton of a C# class. You don't have to create a full Visual Studio project to gain some of the benefits that the code editor offers&mdash;all you need is a code file.

   :::image type="content" source="media/vs-2022/tutorial-editor.png" alt-text="Screenshot of a C# code file in Visual Studio 2022.":::

::: moniker-end

## Use code snippets

Visual Studio provides useful *code snippets* that you can use to quickly and easily generate commonly used code blocks. [Code snippets](../../ide/code-snippets.md) are available for different programming languages including C#, Visual Basic, and C++.

Let's add the C# `void Main` snippet to our file.

::: moniker range="<=vs-2019"

1. Place your cursor just above the final closing brace **}** in the file, and type the characters `svm` (which stands for `static void Main`&mdash;don't worry too much if you don't know what that means).

   A pop-up dialog box appears with information about the `svm` code snippet.

   ![Screenshot of an IntelliSense pop-up for a code snippet in Visual Studio.](../media/tutorial-intellisense-snippet.png)

1. Press **Tab** twice to insert the code snippet.

   You see the `static void Main()` method signature get added to the file. The [Main()](/dotnet/csharp/programming-guide/main-and-command-args/) method is the entry point for C# applications.

The available code snippets vary for different programming languages. You can look at the available code snippets for your language by choosing **Edit** > **IntelliSense** > **Insert Snippet** or pressing **Ctrl**+**K**, **Ctrl**+**X**, and then choosing your language's folder. For C#, the list looks like this:

![Screenshot of an IntelliSense pop-up for a C# code snippet list.](../media/tutorial-code-snippet-list.png)

::: moniker-end

::: moniker range=">=vs-2022"

1. Place your cursor just above the final closing brace **`}`** in the file, and type the characters `svm`. `svm` stands for `static void Main`&mdash;don't worry if you don't know what that means yet.

   A pop-up dialog box appears with information about the `svm` code snippet.

   :::image type="content" source="media/vs-2022/tutorial-intellisense-snippet.png" alt-text="Screenshot of an IntelliSense pop-up for a code snippet in Visual Studio 2022.":::

1. Press **Tab** twice to insert the code snippet.

   You'll see the `static void Main()` method signature get added to the file. The [Main()](/dotnet/csharp/programming-guide/main-and-command-args/) method is the entry point for C# applications.

Available code snippets vary for different programming languages. You can look at the available code snippets for your language by choosing **Edit** > **IntelliSense** > **Insert Snippet** or pressing **Ctrl**+**K**, **Ctrl**+**X**, and then choosing the folder for your programming language. For C#, the snippet list looks like this:

:::image type="content" source="media/vs-2022/tutorial-code-snippet-list.png" alt-text="Screenshot of an IntelliSense pop-up for a C# code snippet list.":::

::: moniker-end

The list includes snippets for creating a [class](/dotnet/csharp/fundamentals/types/classes), a [constructor](/dotnet/csharp/programming-guide/classes-and-structs/constructors), a [for](/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement) loop, an [if](/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement) or [switch](/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement) statement, and more.

## Comment out code

::: moniker range="<=vs-2019"

The toolbar, which is the row of buttons under the menu bar in Visual Studio, can help make you more productive as you code. For example, you can toggle IntelliSense completion mode ([IntelliSense](../../ide/using-intellisense.md) is a coding aid that displays a list of matching methods, amongst other things), increase or decrease a line indent, or comment out code that you don't want to compile. In this section, we'll comment out some code.

![Screenshot of the Editor toolbar in Visual Studio.](../media/tutorial-editor-toolbar.png)

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

1. We're not using the `morewords` variable, but we may use it later so we don't want to completely delete it. Instead, let's comment out those lines. Select the entire definition of `morewords` to the closing semicolon, and then choose the **Comment out the selected lines** button on the toolbar. If you prefer to use the keyboard, press **Ctrl**+**K**, **Ctrl**+**C**.

   ![Screenshot of the Comment out button in the Editor toolbar in Visual Studio.](../media/tutorial-comment-out.png)

   The C# comment characters `//` are added to the beginning of each selected line to comment out the code.

::: moniker-end

::: moniker range=">=vs-2022"

The toolbar, which is the row of buttons under the menu bar in Visual Studio, helps make you more productive as you code. For example, you can toggle [IntelliSense](../../ide/using-intellisense.md) completion mode, increase or decrease a line indent, or comment out code that you don't want to compile.

:::image type="content" source="media/vs-2022/tutorial-editor-toolbar.png" alt-text="Screenshot of the Text Editor toolbar in Visual Studio 2022.":::

Let's comment out some code.

1. Paste the following code into the `Main()` method body.

    ```csharp
    // someWords is a string array.
    string[] someWords = {
        "the",
        "quick",
        "brown",
        "fox",
        "jumps"
    };

    string[] moreWords = {
        "over",
        "the",
        "lazy",
        "dog"
    };

    // Alphabetically sort the words.
    IEnumerable<string> query = from word in someWords
                                orderby word
                                select word;
    ```

1. We're not using the `moreWords` variable, but we might use it later so we don't want to delete it. Instead, we'll comment out those lines. Select the entire definition of `moreWords` down to the closing semicolon, and then choose the **Comment out the selected lines** button on the toolbar. If you prefer to use the keyboard, press **Ctrl**+**E**, **Ctrl**+**C**.

   :::image type="content" source="media/vs-2022/tutorial-comment-out.png" alt-text="Screenshot of the Comment out button in the Text Editor toolbar in Visual Studio 2022.":::

   The C# comment characters `//` are added to the beginning of each selected line to comment out the code.

::: moniker-end

## Collapse code blocks

We don't want to see the empty [constructor](/dotnet/csharp/programming-guide/classes-and-structs/constructors) that was generated for `Class1`, so to unclutter our view of the code, let's collapse it. Choose the small gray box with the minus sign inside it in the margin of the first line of the constructor. Or, if you prefer to use the keyboard, place the cursor anywhere in the constructor code and press **Ctrl**+**M**, **Ctrl**+**M**.

::: moniker range="<=vs-2019"

![Screenshot of the Outlining collapse button in the Text Editor toolbar in Visual Studio.](../media/tutorial-collapse.png)

The code block collapses to just the first line, followed by an ellipsis (`...`). To expand the code block again, click the same gray box that now has a plus sign in it, or press **Ctrl**+**M**, **Ctrl**+**M** again. This feature is called [Outlining](../../ide/outlining.md) and is especially useful when you're collapsing long methods or entire classes.

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/tutorial-collapse.png" alt-text="Screenshot of the Outlining collapse button in the Text Editor toolbar in Visual Studio 2022.":::

The code block collapses to just the first line, followed by an ellipsis (`...`). To expand the code block again, select the same gray box that now has a plus sign in it, or press **Ctrl**+**M**, **Ctrl**+**M** again. This feature is called [Outlining](../../ide/outlining.md) and is especially useful when you're collapsing long methods or entire classes.

::: moniker-end

## View symbol definitions

::: moniker range="<=vs-2019"

The Visual Studio editor makes it easy to inspect the definition of a type, method, etc. One way is to navigate to the file that contains the definition, for example by choosing **Go to Definition** or pressing **F12** anywhere the symbol is referenced. An even quicker way that doesn't move your focus away from the file you're working in is to use [Peek Definition](../../ide/go-to-and-peek-definition.md#peek-at-a-definition). Let's peek at the definition of the `string` type.

1. Right-click on any occurrence of `string` and choose **Peek Definition** from the content menu. Or, press **Alt**+**F12**.

   A pop-up window appears with the definition of the `String` class. You can scroll within the pop-up window, or even peek at the definition of another type from the peeked code.

   ![Screenshot of a Peek definition window in Visual Studio.](../media/tutorial-peek-definition.png)

1. Close the peeked definition window by choosing the small box with an "x" at the top right of the pop-up window.

::: moniker-end

::: moniker range=">=vs-2022"

The Visual Studio editor makes it easy to inspect the definition of a type, method, or variable. One way is to go to the definition, in whichever file has it, by choosing **Go to Definition** or pressing **F12** anywhere a symbol is referenced. An even quicker way that doesn't move your focus away from the code you're working on is to use [Peek Definition](../../ide/go-to-and-peek-definition.md#peek-at-a-definition).

Let's peek at the definition of the `string` type.

1. Right-click on any occurrence of `string` and choose **Peek Definition** from the content menu. Or, press **Alt**+**F12**.

   A pop-up window appears with the definition of the `String` class. You can scroll within the pop-up window, or even peek at the definition of another type from the peeked code.

   :::image type="content" source="media/vs-2022/tutorial-peek-definition.png" alt-text="Screenshot of the Peek definition window in Visual Studio 2022.":::

1. Close the peek definition window by choosing the small box with an "x" at the top right of the pop-up window.

::: moniker-end

## Use IntelliSense to complete words

::: moniker range="<=vs-2019"

[IntelliSense](../../ide/using-intellisense.md) is an invaluable resource when you're coding. It can show you information about available members of a type, or parameter details for different overloads of a method. You can also use IntelliSense to complete a word after you type enough characters to disambiguate it. Let's add a line of code to print out the ordered strings to the console window, which is the standard place for output from the program to go.

1. Below the `query` variable, start typing the following code:

   ```csharp
   foreach (string str in qu
   ```

   You see IntelliSense show you **Quick Info** about the `query` symbol.

   ![Screenshot of an IntelliSense word completion pop-up in Visual Studio.](../media/tutorial-intellisense-completion-list.png)

1. To insert the rest of the word `query` by using IntelliSense's word completion functionality, press **Tab**.

1. Finish off the code block to look like the following code. You can even practice using code snippets again by entering `cw` and then pressing **Tab** twice to generate the `Console.WriteLine` code.

   ```csharp
   foreach (string str in query)
   {
      Console.WriteLine(str);
   }
   ```

::: moniker-end

::: moniker range=">=vs-2022"

[IntelliSense](../../ide/using-intellisense.md) is an invaluable resource when you're coding. It can show you information about available members of a type, or parameter details for different overloads of a method. You can also use IntelliSense to complete a word after you type enough characters to disambiguate it.

Let's add a line of code to print out the ordered strings to the console window, which is the standard place for output from the program to go.

1. Below the `query` variable, start typing the following code:

   ```csharp
   foreach (string str in qu
   ```

   You'll see an IntelliSense pop-up appear with information about the `query` symbol.

   :::image type="content" source="media/vs-2022/tutorial-intellisense-completion-list.png" alt-text="Screenshot of an IntelliSense word completion pop-up in Visual Studio 2022.":::

1. To insert the rest of the word `query` by using IntelliSense word completion, press **Tab**.

1. Finish off the code block to look like the following code. You can practice further with code snippets by entering `cw` and then pressing **Tab** twice to generate the `Console.WriteLine` statement.

   ```csharp
   foreach (string str in query)
   {
      Console.WriteLine(str);
   }
   ```

::: moniker-end

## Refactor a name

::: moniker range="<=vs-2019"

Nobody gets code right the first time, and one of the things you might have to change is the name of a variable or method. Let's try out Visual Studio's [refactor](../../ide/refactoring-in-visual-studio.md) functionality to rename the `_words` variable to `words`.

1. Place your cursor over the definition of the `_words` variable, and choose **Rename** from the right-click or context menu, or press **Ctrl**+**R**, **Ctrl**+**R**.

   A pop-up **Rename** dialog box appears at the top right of the editor.

1. Enter the desired name **words**. Notice that the reference to `words` in the query is also automatically renamed. Before you press **Enter**, select the **Include comments** checkbox in the **Rename** pop-up box.

   ![Screenshot of a Rename dialog box in Visual Studio.](../media/tutorial-rename.png)

1. Press **Enter**.

   Both occurrences of `words` have been renamed, as well as the reference to `words` in the code comment.

::: moniker-end

::: moniker range=">=vs-2022"

Nobody gets code right the first time, and one of the things you might have to change is the name of a variable or method. Let's try out Visual Studio's [refactor](../../ide/refactoring-in-visual-studio.md) functionality to rename the `someWords` variable to `unsortedWords`.

1. Place your cursor over the definition of the `someWords` variable, and choose **Rename** from the right-click or context menu, or press **F2**.

   A **Rename** dialog box appears at the top right of the editor.

   :::image type="content" source="media/vs-2022/tutorial-rename-start.png" alt-text="Screenshot of the Rename pop-up box within the editor of Visual Studio 2022.":::

1. Enter the desired name **unsortedWords**. You'll see that the reference to `unsortedWords` in the `query` assignment statement is also automatically renamed. Before you press **Enter**, select the **Include comments** checkbox in the **Rename** pop-up box.

   :::image type="content" source="media/vs-2022/tutorial-rename.png" alt-text="Screenshot of the Rename pop-up box in Visual Studio 2022.":::

1. Press **Enter**, or choose **Apply** in the **Rename** dialog box.

   Both occurrences of `someWords` in your code have been renamed, as well as the text `someWords` in your code comment.

::: moniker-end

## Next steps

> [!div class="nextstepaction"]
> [Learn about projects and solutions](../tutorial-projects-solutions.md)

## See also

- [Code snippets](../../ide/code-snippets.md)
- [Navigate code](../../ide/navigating-code.md)
- [Outlining](../../ide/outlining.md)
- [Go To Definition and Peek Definition](../../ide/go-to-and-peek-definition.md)
- [Refactoring](../../ide/refactoring-in-visual-studio.md)
- [Use IntelliSense](../../ide/using-intellisense.md)
