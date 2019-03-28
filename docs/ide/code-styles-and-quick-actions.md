---
title: Code style preferences
ms.date: 03/12/2019
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

Code style preferences can be set for your C# and Visual Basic projects by opening the **Options** dialog box from the **Tools** menu. In the **Options** dialog box, select **Text Editor** > [**C#** or  **Basic**] > **Code Style** > **General**.

Each item in the list shows a preview of the preference when selected:

::: moniker range="vs-2017"

![Code style options](media/code-style-quick-actions-dialog.png)

::: moniker-end

::: moniker range=">=vs-2019"

![Code style options](media/vs-2019/code-style-quick-actions-dialog.png)

::: moniker-end

Options set in this window are applicable to your Visual Studio personalization account and aren't associated with a particular project or codebase. In addition, they aren't enforced at build time, including in continuous integration (CI) builds. If you want to associate code style preferences with your project and have the styles enforced during build, specify the preferences in an [.editorconfig file](#editorconfig-files).

::: moniker range=">=vs-2019"

Click **Generate .editorconfig file from settings** to automatically generate a coding style .editorconfig file based on the options you've set on this **Options** page.

![Generate editorconfig file from settings in VS 2019](media/vs-2019/generate-editorconfig-file-small.png)

::: moniker-end

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Editor behavior in Visual Studio for Mac](/visualstudio/mac/editor-behavior).

## Preference and severity

For each item, you can set the **Preference** and **Severity** values using the drop-downs on each line. Severity can be set to **None**, **Suggestion**, **Warning**, or **Error**. If you want to enable [Quick Actions](../ide/quick-actions.md) for a code style, ensure that the **Severity** setting is set to something other than **None**. The **Quick Actions** light bulb ![light bulb](media/light-bulb-dropdown.png), error light bulb ![error light bulb](media/error-bulb.png), or screwdriver ![screwdriver](media/screwdriver.png) icon appears when a non-preferred style is used, and you can choose an option on the **Quick Actions** list to automatically rewrite code to the preferred style.

## EditorConfig files

Code style settings for .NET can also be specified by adding an [EditorConfig](../ide/editorconfig-code-style-settings-reference.md) file to your project. These files are associated with a codebase rather than a Visual Studio personalization account. Settings in the EditorConfig file take precedence over options selected in the **Options** dialog box. Use an EditorConfig file when you want to enforce coding styles for all contributors to your repo or project.

## Format Document command

You can configure the **Format Document** command (**Edit** > **Advanced** > **Format Document**) to perform additional code cleanup on a file, such as remove and sort usings or apply code-style preferences. You can define which settings you want **Format Document** to apply on the [Formatting options page](reference/options-text-editor-csharp-formatting.md#format-document-settings).

Code cleanup respects settings configured in an *.editorconfig* file, or lacking that rule or file, those set in **Tools** > **Options** > **Text Editor** > **C#** > [**Code Style** or **Formatting**].

The first time you trigger the **Format Document** command in Visual Studio, a yellow info bar prompts you to configure your code cleanup settings.

> [!TIP]
> Rules configured with a severity of **None** don't participate in code cleanup, but can be individually applied via the **Quick Actions and Refactorings** menu.

## See also

- [Quick Actions](../ide/quick-actions.md)
- [.NET coding convention settings for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)
- [Editor behavior (Visual Studio for Mac)](/visualstudio/mac/editor-behavior)