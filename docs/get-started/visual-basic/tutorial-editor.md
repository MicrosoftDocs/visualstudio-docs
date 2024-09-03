---
title: Get started coding with VB
description: Explore the code editor in Visual Studio and learn some ways that Visual Studio makes writing, navigating, and understanding Visual Basic code easier.
ms.custom: vs-acquisition
ms.date: 08/21/2024
ms.subservice: general-ide
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: mijacobs
dev_langs:
- VB

#customer intent: As a developer, I want to explore the code editor in Visual Studio to make writing Visual Basic code easier.
---

# Tutorial: Learn to use the code editor with Visual Basic

In this tutorial, you'll try out the code editor in Visual Studio. You'll add code to a file to learn some of the ways that Visual Studio makes writing, navigating, and understanding Visual Basic code easier.

This article assumes you're already familiar with Visual Basic. If you aren't, you might want to start with a tutorial like [Create a simple Visual Basic (VB) console app](tutorial-console.md).

To complete this tutorial, make sure you have the Visual Basic settings selected for Visual Studio. For information about selecting settings for the integrated development environment (IDE), see [Select environment settings](visual-studio-ide.md#select-environment-settings).

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page to install it for free.

## Create a code file

Start by creating a file and adding some code to it.

::: moniker range="vs-2019"

1. Open Visual Studio. Press **Esc** or select **Continue without code** on the start window to open the development environment.

1. On the **File** menu on the menu bar, select **New File**.

1. In the **New File** dialog, under the **General** category, select **Visual Basic Class**, and then select **Open**.

   A new file opens in the editor with the skeleton of a Visual Basic class. (You can already notice that you don't have to create a full Visual Studio project to gain some of the benefits that the code editor provides, such as syntax highlighting. All you need is a code file.)

   :::image type="content" source="media/tutorial-editor.png" alt-text="Screenshot of a new Visual Basic class file in the Visual Studio code editor.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio. Press **Esc** or select **Continue without code** on the start window to open the development environment.

1. On the **File** menu on the menu bar, select **New File**.

1. In the **New File** dialog, under the **General** category, select **Visual Basic Class**, and then select **Open**.

   A new file opens in the editor with the skeleton of a Visual Basic class. (You can already notice that you don't have to create a full Visual Studio project to gain some of the benefits that the code editor provides, such as syntax highlighting. All you need is a code file.)

   :::image type="content" source="media/vs-2022/tutorial-editor.png" alt-text="Screenshot of a new Visual Basic class file in the Visual Studio code editor.":::

::: moniker-end

## Use code snippets

Visual Studio provides *code snippets* that you can use to quickly and easily generate commonly used code blocks. [Code snippets](../../ide/code-snippets.md) are available for various programming languages, including Visual Basic, C#, and C++. You'll now add the Visual Basic **Sub** snippet to the file.

::: moniker range="<=vs-2019"

1. Place your cursor above the line that says `End Class`, and type **sub**.

   A pop-up dialog box appears with information about the `Sub` keyword and how to insert the **Sub** code snippet.

   :::image type="content" source="media/tutorial-intellisense-snippet.png" alt-text="Screenshot of the IntelliSense for a Sub code snippet in Visual Studio.":::

1. Press **Tab** twice to insert the code snippet.

   The outline for the Sub procedure `MySub()` is added to the file.

The available code snippets vary for different programming languages. You can look at the available code snippets for Visual Basic by choosing **Edit** > **IntelliSense** > **Insert Snippet** (or press **Ctrl**+**K**, **Ctrl**+**X**). For Visual Basic, code snippets are available for the following categories:

:::image type="content" source="media/tutorial-code-snippet-list.png" alt-text="Screenshot of the Insert Snippet window with a list of category folders that contain Visual Basic code snippets.":::

There are snippets for determining if a file exists on the computer, writing to a text file, reading a registry value, executing a SQL query, or creating a [For Each...Next statement](/dotnet/visual-basic/language-reference/statements/for-each-next-statement), and many more.

::: moniker-end

::: moniker range=">=vs-2022"

1. Place your cursor above the line that says `End Class`, and type **sub**.

   A pop-up window appears with information about the `Sub` keyword and how to insert the **Sub** code snippet.

   :::image type="content" source="media/vs-2022/tutorial-intellisense-snippet.png" alt-text="Screenshot of the IntelliSense for a Sub code snippet in Visual Studio.":::

1. Select **Tab** twice to insert the code snippet.

   The outline for the Sub procedure `MySub()` is added to the file.

The available code snippets vary for different programming languages. You can view the available code snippets for Visual Basic by right-clicking in the code editor and selecting **Snippet** > **Insert Snippet** (or by pressing **Ctrl**+**K**, **Ctrl**+**X**). For Visual Basic, code snippets are available for the following categories:

:::image type="content" source="media/vs-2022/tutorial-code-snippet-list.png" alt-text="Screenshot showing the Insert Snippet window with a list of category folders that contain Visual Basic code snippets.":::

::: moniker-end

## Comment out code

In this section, you'll comment out some code.

::: moniker range="<=vs-2019"

:::image type="content" source="media/tutorial-editor-toolbar.png" alt-text="Screenshot of the toolbar in Visual Studio, which includes buttons for adding and removing code comments.":::

1. Paste the following code into the `MySub()` procedure body.

   ```vb
   ' _words is a string array that we'll sort alphabetically
   Dim _words = New String() {
   "the",
   "quick",
   "brown",
   "fox",
   "jumps"
   }

   Dim morewords = New String() {
   "over",
   "the",
   "lazy",
   "dog"
   }

   Dim query = From word In _words
               Order By word.Length
               Select word
   ```

1. Say you're not using the `morewords` array, but you might use it later, so you don't want to delete it. Instead, you can comment out those lines. Select the entire definition of `morewords` to the closing curly brace, and then select the **Comment out the selected lines** button on the toolbar. If you prefer to use the keyboard, select **Ctrl**+**K**, **Ctrl**+**C**.

   :::image type="content" source="media/tutorial-comment-out.png" alt-text="Screenshot of the toolbar. The button for commenting out code is highlighted in red.":::

   The Visual Basic comment character `'` is added to the beginning of each selected line to comment out the code.

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/tutorial-editor-toolbar.png" alt-text="Screenshot of the toolbar in Visual Studio, which includes buttons for adding and removing code comments.":::

1. Paste the following code into the `MySub()` procedure body.

   ```vb
   ' _words is a string array that we'll sort alphabetically
   Dim _words = New String() {
   "the",
   "quick",
   "brown",
   "fox",
   "jumps"
   }

   Dim morewords = New String() {
   "over",
   "the",
   "lazy",
   "dog"
   }

   Dim query = From word In _words
               Order By word.Length
               Select word
   ```

1. Say you're not using the `morewords` array, but you might use it later, so you don't want to delete it. Instead, you can comment out those lines. Select the entire definition of `morewords` to the closing curly brace, and then select the **Comment out the selected lines** button on the toolbar. If you prefer to use the keyboard, select **Ctrl**+**K**, **Ctrl**+**C**.

   :::image type="content" source="media/vs-2022/tutorial-comment-out.png" alt-text="Screenshot of the toolbar. The button for commenting out code is highlighted in red.":::

   The Visual Basic comment character `'` is added to the beginning of each selected line to comment out the code.

::: moniker-end

## Collapse code blocks

::: moniker range="<=vs-2019"

You can collapse sections of code to focus just on the parts that interest you. To practice, try collapsing the `_words` array to one line of code. Select the small box with the minus sign inside it in the margin of the line that says `Dim _words = New String() {`. Or, if you're a keyboard user, place the cursor anywhere in the array definition and select **Ctrl**+**M**, **Ctrl**+**M**.

:::image type="content" source="media/tutorial-collapse.png" alt-text="Screenshot of the Visual Studio Code editor. The button for collapsing the outline of a section of code is highlighted in red.":::

The code block collapses to just the first line, followed by an ellipsis (`...`). To expand the code block, select the same box, which now has a plus sign in it, or select **Ctrl**+**M**, **Ctrl**+**M** again. This feature is called [outlining](../../ide/outlining.md) and is especially useful when you're collapsing long methods or entire classes.

::: moniker-end

::: moniker range=">=vs-2022"

You can collapse sections of code to focus just on the parts that interest you. To practice, try collapsing the `_words` array to one line of code. Select the down arrow in the margin of the line that says `Dim _words = New String() {`. Or, if you're a keyboard user, place the cursor anywhere in the array definition and select **Ctrl**+**M**, **Ctrl**+**M**.

:::image type="content" source="media/vs-2022/tutorial-collapse.png" alt-text="Screenshot of the Visual Studio Code editor. The button for collapsing the outline of a section of code is highlighted in red.":::

The code block collapses to just the first line, followed by an ellipsis (`...`). The down arrow in the margin is now an arrow that points to the right. To expand the code block, select the **>** arrow, or press **Ctrl**+**M**, **Ctrl**+**M** again. This feature is called [outlining](../../ide/outlining.md) and is especially useful when you're collapsing long methods or entire classes.

::: moniker-end
## View symbol definitions

::: moniker range="<=vs-2019"

The Visual Studio editor makes it easy to inspect the definition of a type or class member. You can do that by navigating to the file that contains the definition, for example by right-clicking and selecting **Go to Definition** anywhere the symbol is referenced. An even quicker way that doesn't move your focus away from the file you're working in is to use [Peek Definition](../../ide/go-to-and-peek-definition.md#peek-at-a-definition). You'll now peek at the definition of the `String` type.

1. Right-click the word `String` and select **Peek Definition**. Or press **Alt**+**F12**.

   A pop-up window containing the definition of the `String` class appears. You can scroll within the pop-up window, or even peek at the definition of another type from the peeked code.

   :::image type="content" source="media/tutorial-peek-definition.png" alt-text="Screenshot of a Peek Definition pop-up window that contains the definition of the String class." lightbox="media/tutorial-peek-definition.png":::

1. Close the Peek Definition window by selecting the close button at the upper-right corner of the pop-up window.

::: moniker-end

::: moniker range=">=vs-2022"

The Visual Studio editor makes it easy to inspect the definition of a type or class member. You can do that by navigating to the file that contains the definition, for example by right-clicking and selecting **Go to Definition** anywhere the symbol is referenced. An even quicker way that doesn't move your focus away from the file you're working in is to use [Peek Definition](../../ide/go-to-and-peek-definition.md#peek-at-a-definition). You'll now peek at the definition of the `String` type.

1. Right-click the word `String` and select **Peek Definition**. Or press **Alt**+**F12**.

   A pop-up window containing the definition of the `String` class appears. You can scroll within the pop-up window, or even peek at the definition of another type from the peeked code.

   :::image type="content" source="media/vs-2022/tutorial-peek-definition.png" alt-text="Screenshot of a Peek Definition pop-up window that contains the definition of the String class." lightbox="media/vs-2022/tutorial-peek-definition.png":::

1. Close the Peek Definition window by selecting the close button at the upper-right corner of the pop-up window.

::: moniker-end

## Use IntelliSense to complete words

::: moniker range="<=vs-2019"

[IntelliSense](../../ide/using-intellisense.md) is a valuable resource when you're coding. It can show you information about available members of a type, or parameter details for different overloads of a method. You can also use IntelliSense to complete a word after you type enough characters to disambiguate it. You'll now add a line of code to print the ordered strings to the console window, which is the standard place for output from a program to go.

1. Below the `query` variable, start typing the following code:

   ```vb
   For Each str In qu
   ```

   You see IntelliSense show you **Quick Info** about the `query` symbol.

   :::image type="content" source="media/tutorial-intellisense-completion-list.png" alt-text="Screenshot of the IntelliSense word completion window for the word 'query' in the Visual Studio code editor."::: 

1. To insert the rest of the word `query` by using IntelliSense's word completion functionality, press **Tab**.

1. Finish off the code block to look like the following code.

   ```vb
   For Each str In query
       Console.WriteLine(str)
   Next
   ```

::: moniker-end

::: moniker range=">=vs-2022"

[IntelliSense](../../ide/using-intellisense.md) is a valuable resource when you're coding. It can show you information about available members of a type, or parameter details for different overloads of a method. You can also use IntelliSense to complete a word after you type enough characters to disambiguate it. You'll now add a line of code to print the ordered strings to the console window, which is the standard place for output from the program to go.

1. Below the `query` variable, start typing the following code:

   ```vb
   For Each str In qu
   ```

   IntelliSense shows you Quick Info about the `query` symbol.

   :::image type="content" source="media/vs-2022/tutorial-intellisense-completion-list.png" alt-text="Screenshot of the IntelliSense word completion window for the word 'query' in the Visual Studio code editor.":::

1. To insert the rest of the word `query` by using the IntelliSense word completion functionality, select **Tab**.

1. Finish off the code block to look like the following code.

   ```vb
   For Each str In query
       Console.WriteLine(str)
   Next
   ```

::: moniker-end
## Refactor a name

::: moniker range="<=vs-2019"

Nobody gets code right the first time, and one of the things you might have to change is the name of a variable or method. You'll now try the Visual Studio [refactor](../../ide/refactoring-in-visual-studio.md) functionality to rename the `_words` variable to `words`.

1. Right-click the definition of the `_words` variable and select **Rename**.

   A **Rename** window appears at the upper-right corner of the editor.

1. With the variable `_words` still selected, enter the desired name: **words**. Notice that the reference to `words` in the query is automatically renamed. Before you press **Enter** or select **Apply**, select the **Include comments** checkbox in the **Rename** window.

   :::image type="content" source="media/tutorial-rename.png" alt-text="Screenshot of the Rename window for the variable '_words'. The Include comments checkbox is selected.":::

1. Press **Enter** or select **Apply**.

   Both occurrences of `words` are renamed, in addition to the reference to `words` in the code comment.

::: moniker-end

::: moniker range=">=vs-2022"

Nobody gets code right the first time, and one of the things you might have to change is the name of a variable or method. You'll now try the Visual Studio [refactor](../../ide/refactoring-in-visual-studio.md) functionality to rename the `_words` variable to `words`.

1. Right-click the definition of the `_words` variable and select **Rename**.

   A rename window appears.

1. With the variable `_words` still selected, enter the desired name: **words**. Notice that the reference to `words` in the query is automatically renamed. Before you select **Enter**, select the **Include comments** checkbox in the **Rename** window.

   :::image type="content" source="media/vs-2022/tutorial-rename.png" alt-text="Screenshot of the Rename window. The 'Include comments' checkbox is selected.":::

1. Select **Enter**.

   Both occurrences of `words` are renamed, in addition to the reference to `words` in the code comment.

::: moniker-end

## Related content

- [Code snippets](../../ide/code-snippets.md)
- [Navigate code](../../ide/navigating-code.md)
- [Outlining](../../ide/outlining.md)
- [Go To Definition and Peek Definition](../../ide/go-to-and-peek-definition.md)
- [Refactoring](../../ide/refactoring-in-visual-studio.md)
- [Use IntelliSense](../../ide/using-intellisense.md)

## Next step

> [!div class="nextstepaction"]
> [Learn about projects and solutions](tutorial-projects-solutions.md)
