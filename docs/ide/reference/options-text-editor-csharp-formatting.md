---
title: Options, Text Editor, C#, Formatting
ms.date: 02/09/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting.Spacing"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting.NewLines"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting.Indentation"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting.Wrapping"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting"
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Formatting.General"
helpviewer_keywords:
  - "formatting options [C#]"
  - "Text editor Options dialog box, formatting"
ms.assetid: 5a7bb668-1d0c-4ffe-9508-24592813162e
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Options, Text Editor, C#, Formatting

Use the **Formatting** options page to set options for formatting code in the Code Editor. To access this options page, choose **Tools** > **Options**, and then choose **Text Editor** > **C#** > **Code Style** > **Formatting**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## General settings

The General settings affect how the Code Editor applies formatting options to code.

## UIElement list

|Label|Description|
|-----------|-----------------|
|**Automatically format when typing**|When deselected, the **format statement on ;** and **format block  on }** options are disabled.|
|**Automatically format statement on ;**|When selected, formats statements at completion according to the formatting options selected for the editor.|
|**Automatically format block on }**|When selected, formats code blocks according to the formatting options selected for the editor as soon as you complete the code block.|
|**Automatically format on return**|When selected, formats text when **Enter** is pressed, to fit the formatting options selected for the editor.|
|**Automatically format on paste**|When selected, formats text that is pasted into the editor to fit the formatting options selected for the editor.|

## Preview window

The **Indentation**, **New Lines**, **Spacing**, and **Wrapping** options panes each display a preview window. The preview window shows the effect of each option. To use the preview window, select a formatting option. The preview window shows an example of the selected option. When you change a setting by selecting a radio button or check box, the preview window updates to show the effect of the new setting.

## Remarks

Indentation options on the **Tabs** pages for each language only determine where the Code Editor places the cursor when you press **Enter** at the end of a line. Indentation options under **Formatting** apply when code is formatted automatically, for example, when you paste code into the file while **Automatically format on paste** is selected, and when the block being formatted is typed manually.

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
