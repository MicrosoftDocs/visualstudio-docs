---
title: Problem Details Window
description: Learn about the Problem Details window and how to use it to navigate structured diagnostics.
ms.date: 10/24/2023
ms.topic: reference
helpviewer_keywords:
- Problem Details window
- build errors
- Error List window../
ms.custom: "ide-ref"
author:tartanllama
ms.author: sybrand
manager: mluparu
ms.subservice: general-ide
---

# Problem Details window

The **Problem Details** window shows structured diagnostics issued by the MSVC compiler or [code analysis for C/C++](/cpp/code-quality/code-analysis-for-c-cpp-overview).

Select entries in the [**Error List** window](error-list-window.md) that show an icon in the **Details** column to open the **Problem Details** window. The **Problem Details** window shows the structured diagnostics for the selected entry.

:::image type="complex" source="media/error-list-details-column.png" alt-text="Screenshot of the Visual Studio Error List with one entry that has an icon in its details column.":::
   Screenshot of the Visual Studio Error List. It shows a table with a single row. The row represents a compiler error and contains the error code C2665, the description "pet: no overloaded function could convert all the argument types", and an icon of a square with the corner magnified in the column named Details. This icon is highlighted.
:::image-end:::

Two scenarios produce these diagnostics:

- C++ compilations using [**MSBuild**](/cpp/build/creating-and-managing-visual-cpp-projects) and the MSVC compiler may emit structured diagnostics.
- Code analysis warnings that support [**Key Event**](https://devblogs.microsoft.com/cppblog/microsoft-cpp-code-analysis-warnings-with-key-events) data emit structured diagnostics.

Open the **Problem Details** window by doing one of the following:

- While the entry is highlighted, double-click it or press **Enter**. Disable this behavior with **Tools** > **Options** > **Text Editor** > **C/C++** > **Advanced** > **Show Problem Details on Double Click**.
- Select the icon in the **Details** column.
- Open the shortcut menu for the entry and select the **Open Problem Details** option.

By default, the **Problem Details** window opens in the same location as the **Error List** window. Change where the **Problem Details** window opens by moving it to the desired position.

The **Problem Details** window displays structured information that may be nested. When the window opens, all entries that have nested children begin collapsed.

:::image type="complex" source="media/problem-details-collapsed.png" alt-text="Screenshot of the Visual Studio Problem Details window with all children collapsed.":::
   Screenshot of the Visual Studio Problem Details window. There is a header showing the same error code and description as the Error List entry from before. There is also a selectable link with the text cppcon-diag.cpp (Line 23). Below this header there are entries explaining that the potential overloads are void pet(cat), void pet(dog), or void pet(_T0). The final entry states "while trying to match the argument list (lizard)." To the right of each line is grey text showing the file and line numbers for each entry. All of them belong to cppcon-diag.cpp and the line numbers are 7, 6, 18, and 23, respectively. To the left of the first three entries are small hollow arrows pointing right that signify that these entries can be expanded, but are currently not.
:::image-end:::

Expand an entry to view its children by either selecting the arrow at the left-hand side of an entry, or by pressing **Right** with the entry highlighted.

:::image type="complex" source="media/problem-details-expanded.png" alt-text="Screenshot of the Visual Studio Problem Details window with some children expanded.":::
Screenshot of the Visual Studio Problem Details window. The contents are mostly the same as the previous screenshot, however some of the entries are expanded so their child entries are visible. The first entry is expanded. There is a nested entry with the text "void pet(cat) cannot convert argument 1 from lizard to cat." This entry is indented and can be expanded. The second line from before is expanded, revealing an unexpanded entry reading "void pet(dog) cannot convert argument 1 from lizard to dog." The third entry is expanded, revealing an entry reading "the associated constraints are not satisfied." This entry has an expanded child reading "the concept pettable lizard evaluated to false." This entry has two children. The first is unexpanded and reads "the concept has_member_pet lizard evaluated to false." The second is expanded and reads "the concept has_default_pet lizard evaluated to false." This second child has two children, neither of which is expandable. They read "is_pettable is not a member of lizard" and "see declaration of lizard."
:::image-end:::

Enable or disable structured diagnostics with the **Project** > **Properties** > **Advanced** > **Enable MSVC Structured Output** option. You can affect several projects by creating a [Directory.Build.props](/visualstudio/msbuild/customize-by-directory) file with the **UseStructuredOutput** property defined to true or false.
