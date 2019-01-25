---
title: Code style preferences
ms.date: 03/10/2017
ms.prod: visual-studio-dev15
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: jillfra
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Code_Style.General"
  - "VS.ToolsOptionsPages.Text_Editor.Basic.Code_Style.General"
ms.workload:
  - "multiple"
---
# Code style preferences

Code style preferences can be set for your C# and Visual Basic projects by opening the **Options** dialog box from the **Tools** menu. In the **Options** dialog box, select **Text Editor** > [**C#** or  **Basic**] > **Code Style** > **General**. Options set in this window are applicable to the local machine only.

Each item in the list shows a preview of the preference when selected:

![Code style options](media/code-style-quick-actions-dialog.png)

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Editor behavior in Visual Studio for Mac](/visualstudio/mac/editor-behavior).

## Preference and severity

For each item, you can set the **Preference** and **Severity** values using the drop-downs on each line. Severity can be set to **None**, **Suggestion**, **Warning**, or **Error**. If you want to enable [Quick Actions](../ide/quick-actions.md) for a code style, ensure that the **Severity** setting is set to something other than **None**. The **Quick Actions** light bulb icon ![Small light bulb icon](media/vs2015_lightbulbsmall.png) appears when a non-preferred style is used, and you can choose an option on the **Quick Actions** list to automatically rewrite code to the preferred style.

## EditorConfig files

Code style settings for .NET can also be managed with an [EditorConfig](../ide/editorconfig-code-style-settings-reference.md) file. Settings in the EditorConfig file take precedence over options selected in the **Options** dialog box. You can use an EditorConfig file to enforce and configure the coding style for your entire repo or project.

## Format Document command

In Visual Studio 2017 version 15.8 and later, you can configure the **Format Document** command (**Edit** > **Advanced** > **Format Document**) to perform additional code cleanup on a file, such as remove and sort usings or apply code-style preferences. You can define which settings you want **Format Document** to apply on the [Formatting options page](reference/options-text-editor-csharp-formatting.md#format-document-settings).

Code cleanup respects settings configured in an *.editorconfig* file, or lacking that rule or file, those set in **Tools** > **Options** > **Text Editor** > **C#** > [**Code Style** or **Formatting**].

The first time you trigger the **Format Document** command in Visual Studio 2017, a yellow info bar prompts you to configure your code cleanup settings.

> [!TIP]
> Rules configured as **none** in an *.editorconfig* file don't participate in code cleanup, but can be individually applied via the **Quick Actions and Refactorings** menu.

## See also

- [Quick Actions](../ide/quick-actions.md)
- [.NET coding convention settings for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)
- [Editor behavior (Visual Studio for Mac)](/visualstudio/mac/editor-behavior)