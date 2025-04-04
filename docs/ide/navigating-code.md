---
title: Options for Browsing Code in the Editor
description: Explore the options for using the Visual Studio editor for browsing your code, including the Navigation bar and Navigate Backward and Forward commands.
ms.date: 04/04/2025
ms.topic: conceptual
helpviewer_keywords:
- code editor, navigation
- code editor, go to
- code editor, go to definition
- code editor, go to line
- code editor, peek definition
- code editor, navigation bar
- go to definition
- peek definition
- go to line
- go to
author: ghogen
ms.author: ghogen
manager: j-martens

#customer intent: As a developer, I want to learn about browsing code in Visual Studio so that I can write code more efficiently.
---
# Navigate code

Visual Studio provides numerous ways to navigate code in the editor. This article summarizes the different ways you can navigate your code. It also provides links to articles that go into more detail.

## Navigate Backward and Navigate Forward commands

You can use the **Navigate Backward** (**Ctrl**+**-**) and **Navigate Forward** (**Ctrl**+**Shift**+**-**) buttons on the toolbar to move the insertion point to previous locations or to return to a more recent location from a previous location. These commands retain the last 20 locations of the insertion point.

:::image type="content" source="../ide/media/vs2017_nav_buttons.png" alt-text="Screenshot that shows the forward and back navigation buttons." lightbox="../ide/media/vs2017_nav_buttons.png":::

## Navigation bar

You can use the **navigation bar** (the drop-down boxes at the top of the code window) to navigate to code in a codebase. You can select a type or member to go directly to it. The navigation bar appears when you edit code in a Visual Basic, C#, or C++ codebase. In a partial class, members that are defined outside the current code file might be disabled (grayed out).

:::image type="content" source="../ide/media/vside_navigation_bar.png" alt-text="Screenshot that shows the code navigation bar." lightbox="../ide/media/vside_navigation_bar.png":::

You can use the navigation drop-down boxes in the following ways:

- To navigate to another project that the current file belongs to, select it in the left drop-down list.

- To navigate to a class or type, select it in the middle drop-down list.

- To navigate directly to a procedure or other member of a class, select it in the right drop-down list.

- To shift focus from the code window to the navigation bar, select the shortcut key combination **Ctrl**+**F2**.

- To shift focus from box to box on the navigation bar, select the **Tab** key.

- To select the navigation bar item that has focus and return to the code window, select the **Enter** key.

- To return focus from the navigation bar to the code  without selecting anything, select the **Esc** key.

To hide the navigation bar, change the **Navigation bar** option in the **Text Editor All Languages** settings (**Tools** > **Options** > **Text Editor** > **All Languages**). Alternatively, you can change the settings for individual languages.

## Find all references

You can use **Find all references** to locate references to the selected element in the solution. You can use this feature to check possible side-effects of a large refactoring, or to verify "dead" code. Select the **F8** key to jump among results. For more information, see [Find references in your code](finding-references.md).

Input method | Steps
------------ | ---
**Keyboard** | Place your text cursor somewhere inside the type name, and then select **Shift**+**F12**
**Mouse** | Right-click the element and then select **Find All References**

## Reference highlighting

When you select a symbol in source code, all instances of that symbol are highlighted in the document. The highlighted symbols can include declarations and references, and many other symbols that **Find All References** would return. These symbols include the names of classes, objects, variables, methods, and properties. In Visual Basic code, keywords for many control structures are also highlighted. To move to the next or previous highlighted symbol, select **Ctrl**+**Shift**+**Down Arrow** or **Ctrl**+**Shift**+**Up Arrow**. You can change the highlight color by going to **Tools** > **Options** > **Environment** > **Fonts and Colors** > **Highlighted Reference**.

## Go To commands

The following commands are available on the **Edit** menu under **Go To**:

:::moniker range="<=vs-2019"
- **Go To Line** (**Ctrl**+**G**): Move to the specified line number in the active document.

- **Go To All** (**Ctrl**+**T** or **Ctrl**+**,**): Move to the specified line, type, file, member, or symbol. Selecting this option opens a search window. For more information, see [Visual Studio search](./visual-studio-search.md).

- **Go To File** (**Ctrl**+**Shift**, **T**): Move to the specified file in the solution.

- **Go To Recent File** (**Ctrl**+**1**, **Ctrl**+**R**): Move to the specified recently visited file in the solution.

- **Go To Type** (**Ctrl**+**1**, **Ctrl**+**T**): Move to the specified type in the solution.

- **Go To Member** (**Alt**+**\\**): Move to the specified member in the solution.

- **Go To Symbol** (**Ctrl**+**1**, **Ctrl**+**S**): Move to the specified symbol in the solution.

- **Go To Next Issue in File** (**Alt**+**PgDn**) and **Go To Previous Issue in File** (**Alt**+**PgUp**)

- **Go To Last Edit Location** (**Ctrl**+**Shift**+**Backspace**)

For more information about these commands, see [Find code using Go To commands](../ide/go-to.md).

:::moniker-end

:::moniker range=">=vs-2022"

- **Go To Line** (**Ctrl**+**G**): Move to the specified line number in the active document.

- **Go To File** (**Ctrl**+**Shift**, **T**): Move to the specified file in the solution.

- **Go To Next Issue in File** (**Alt**+**PgDn**) and **Go To Previous Issue in File** (**Alt**+**PgUp**)

- **Go To Last Edit Location** (**Ctrl**+**Shift**+**Backspace**)

The following commands work differently in Visual Studio 2022 version 17.10 and later (and in earlier versions if the optional feature **All in One Search** is enabled). For more information, see [All in One Search experience](visual-studio-search.md#about-the-all-in-one-search-experience). With **All in One Search**, the search dialog opens, and you can search for any code element. In earlier versions of Visual Studio, a UI tool in which you can enter the search text appears.

- **Go To All** (**Ctrl**+**T** or **Ctrl**+**,**): Move to the specified line, type, file, member, or symbol. Selecting this option opens a search window. For more information, see [Visual Studio search](./visual-studio-search.md).

- **Go To Type** (**Ctrl**+**1**, **Ctrl**+**T**): Move to the specified type in the solution.

- **Go To Member** (**Alt**+**\\**): Move to the specified member in the solution.

For more information about these commands, see [Find code using Go To commands](../ide/go-to.md).

:::moniker-end

## Go To Definition

Go To Definition takes you to the definition of the selected element. For more information, see [Go To Definition and Peek Definition](../ide/go-to-and-peek-definition.md).

Input method| Steps
------------ | ---
**Keyboard** | Place the cursor somewhere in the type name, and then select **F12**
**Mouse** | Right-click the type name and then select **Go To Definition**,  or select **Ctrl** and then select the type name

## Peek Definition

Peek Definition displays the definition of the selected element in a window without navigating away from your current location in the code editor. For more information, see [How to: View and edit code by using Peek Definition](../ide/how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md) and [Go To Definition and Peek Definition](../ide/go-to-and-peek-definition.md).

Input method| Steps
------------ | ---
**Keyboard** | Place the cursor somewhere in the type name, and then select **Alt**+**F12**
**Mouse** | Right-click the type name and then select **Peek Definition**, or select **Ctrl** and then select the type name (if you have the **Open definition in peek view** option selected)

## Go To Implementation

You can use Go To Implementation to navigate from a base class or type to its implementations. If there are multiple implementations, you'll see them listed in the **Find Symbol Results** window.

Input method| Steps
------------ | ---
**Keyboard** | Place the cursor somewhere in the type name, and then select **Ctrl**+**F12**
**Mouse** | Right-click the type name and then select **Go To Implementation**

## Go To Base

You can use Go To Base to navigate up the inheritance chain of the selected element. If there are multiple results, you'll see them listed in the **Go To Base** window.

Input method| Steps
------------ | ---
**Keyboard** | Place the cursor somewhere in the type name, and then select **Alt**+**Home**
**Mouse** | Right-click the type name and then select **Go To Base**

## Call Hierarchy

You can view calls to and from a method in the [Call Hierarchy window](../ide/reference/call-hierarchy.md):

Input method| Steps
------------ | ---
**Keyboard** | Place the cursor somewhere in the type name, and then press **Ctrl**+**K**, **Ctrl**+**T**
**Mouse** | Right-click the member name and then select **View Call Hierarchy**

## Next Method and Previous Method commands (Visual Basic)

In Visual Basic code files, you can use the Next Method and Previous Method commands to move the insertion point to different methods. Select **Edit** > **Next Method** or **Edit** > **Previous Method**.

## Structure Visualizer

The Structure Visualizer in the code editor shows *structure guide lines*, which are vertical dashed lines that indicate matching curly braces in your codebase. These lines make it easier to see where logical blocks begin and end.

:::image type="content" source="../ide/media/vside_structure_visualizer.png" alt-text="Screenshot that shows the Structure Visualizer guide lines." lightbox="../ide/media/vside_structure_visualizer.png":::

To disable structure guide lines, go to **Tools** > **Options** > **Text Editor** > **General** and clear the **Show structure guide lines** checkbox.

## Enhanced scroll bar

You can use the enhanced scroll bar in a code window to get a bird's-eye view of your code. In map mode, you can see previews of the code when you move the cursor up and down the scroll bar. For more information, see [How to: Track your code by customizing the scroll bar](../ide/how-to-track-your-code-by-customizing-the-scrollbar.md).

## CodeLens information

You can get info about specific code, like changes and who made the changes, references, bugs, work items, code reviews, and unit test status by using CodeLens in the code editor. CodeLens works like a heads-up display when you use Visual Studio Enterprise with a version control provider. For more information, see [Find code changes and other history](../ide/find-code-changes-and-other-history-with-codelens.md).

## Related content

- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)
- [View call hierarchy](../ide/reference/call-hierarchy.md)
