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
# Code style preferences and Code Cleanup

You can define code style settings per-project by using an [EditorConfig file](#code-styles-in-editorconfig-files), or for all code you edit in Visual Studio by setting preferences in the [**Options** dialog box](#code-styles-in-the-options-dialog-box). You can also configure Visual Studio to apply these code style preferences using the **Code Cleanup** (Visual Studio 2019) and **Format Document** (Visual Studio 2017) commands.

## Code styles in EditorConfig files

Code style settings for .NET can also be specified by adding an [EditorConfig](../ide/editorconfig-code-style-settings-reference.md) file to your project.

::: moniker range=">=vs-2019"

Click **Generate .editorconfig file from settings** to automatically generate a coding style .editorconfig file based on the options you've set on this **Options** page.

![Generate editorconfig file from settings in VS 2019](media/vs-2019/generate-editorconfig-file-small.png)

::: moniker-end

EditorConfig files are associated with a codebase rather than a Visual Studio personalization account. Settings in an EditorConfig file take precedence over options selected in the **Options** dialog box. Use an EditorConfig file when you want to enforce coding styles for all contributors to your repo or project.

## Code styles in the Options dialog box

Code style preferences can be set for your C# and Visual Basic projects by opening the **Options** dialog box from the **Tools** menu. In the **Options** dialog box, select **Text Editor** > [**C#** or  **Basic**] > **Code Style** > **General**.

Each item in the list shows a preview of the preference when selected:

::: moniker range="vs-2017"

![Code style options](media/code-style-quick-actions-dialog.png)

::: moniker-end

::: moniker range=">=vs-2019"

![Code style options](media/vs-2019/code-style-quick-actions-dialog.png)

::: moniker-end

Options set in this window are applicable to your Visual Studio personalization account and aren't associated with a particular project or codebase. In addition, they aren't enforced at build time, including in continuous integration (CI) builds. If you want to associate code style preferences with your project and have the styles enforced during build, specify the preferences in an [.editorconfig file](#code-styles-in-editorconfig-files).

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Editor behavior in Visual Studio for Mac](/visualstudio/mac/editor-behavior).

### Preference and severity

For each code style setting on this page, you can set the **Preference** and **Severity** values using the drop-downs on each line. Severity can be set to **None**, **Suggestion**, **Warning**, or **Error**. If you want to enable [Quick Actions](../ide/quick-actions.md) for a code style, ensure that the **Severity** setting is set to something other than **None**. The **Quick Actions** light bulb ![light bulb](media/light-bulb-dropdown.png), error light bulb ![error light bulb](media/error-bulb.png), or screwdriver ![screwdriver](media/screwdriver.png) icon appears when a non-preferred style is used, and you can choose an option on the **Quick Actions** list to automatically rewrite code to the preferred style.

## Apply code styles

::: moniker range="vs-2017"

You can configure the **Format Document** command (**Edit** > **Advanced** > **Format Document**) to apply your code style settings (from an EditorConfig file or **Code Style** options) along with the regular formatting that it does (such as indentation). If an *.editorconfig* file exists for the project, those are the settings that take precedence.

> [!NOTE]
> Applying code styles by using the **Format Document** command is only available for C# code files. This is an experimental feature.

Configure which settings you want **Format Document** to apply on the [Formatting options page](reference/options-text-editor-csharp-formatting.md#format-document-settings).

![Code style settings for format document in Visual Studio 2017](media/format-document-settings-experiment.png)

> [!TIP]
> The first time you trigger the **Format Document** command, a yellow info bar prompts you to configure your code cleanup settings.

::: moniker-end

::: moniker range=">=vs-2019"

For C# code files, Visual Studio 2019 has a **Code Cleanup** button at the bottom of the editor (keyboard: **Ctrl**+**K**, **Ctrl**+**E**) to apply code styles from an EditorConfig file or **Code Style** options. If an *.editorconfig* file exists for the project, those are the settings that take precedence.

Configure which code styles you want to apply (in one of two profiles) in the **Configure Code Cleanup** dialog box. To open this dialog box, click the expander arrow next to the code cleanup broom icon and then choose **Configure Code Cleanup**. Or, press **Ctrl**+**K**, **Ctrl**+**Q**.

![Configure Code Cleanup in Visual Studio 2019](media/configure-code-cleanup.png)

To run code cleanup, click the broom icon at the bottom of the editor or press **Ctrl**+**K**, **Ctrl**+**E**.

![Execute code cleanup in Visual Studio 2019](media/execute-code-cleanup.png)

If you want your code style settings to be applied every time you save a file, you may like the [Code Cleanup on Save](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.CodeCleanupOnSave) extension.

::: moniker-end

> [!TIP]
> Rules configured with a severity of **None** don't participate in code cleanup, but can be individually applied via the **Quick Actions and Refactorings** menu.

## See also

- [Quick Actions](../ide/quick-actions.md)
- [.NET coding convention settings for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)
- [Editor behavior (Visual Studio for Mac)](/visualstudio/mac/editor-behavior)