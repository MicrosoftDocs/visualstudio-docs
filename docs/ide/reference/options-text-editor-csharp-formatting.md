---
title: Options, Text Editor, C#, Formatting
ms.date: 07/25/2018
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

Use the **Formatting** options page to set options for formatting code in the code editor. To access this options page, choose **Tools** > **Options**, and then choose **Text Editor** > **C#** > **Code Style** > **Formatting**.

## General settings

The General settings affect how the code editor applies formatting options to code.

### General UI element list

|Label|Description|
|-----------|-----------------|
|**Automatically format when typing**|When deselected, the **format statement on ;** and **format block  on }** options are disabled.|
|**Automatically format statement on ;**|When selected, formats statements at completion according to the formatting options selected for the editor.|
|**Automatically format block on }**|When selected, formats code blocks according to the formatting options selected for the editor as soon as you complete the code block.|
|**Automatically format on return**|When selected, formats text when **Enter** is pressed, to fit the formatting options selected for the editor.|
|**Automatically format on paste**|When selected, formats text that is pasted into the editor to fit the formatting options selected for the editor.|

### Format Document Settings UI element list

In Visual Studio 2017 version 15.8 and later, you can use these settings to configure the **Edit** > **Format Document** menu option to perform additional code cleanup on a file, such as remove and sort usings or apply code-style preferences. Code cleanup respects settings configured in an *.editorconfig* file, or lacking that rule or file, those set in **Tools** > **Options** > **Text Editor** > **C#** > [**Code Style** and **Formatting**]. Rules configured as **none** in an *.editorconfig* file don't participate in code cleanup, but can be individually applied via the **Quick Actions and Refactorings** menu.

> [!NOTE]
> The first time you trigger the **FormatDocument** command in Visual Studio 2017, a yellow info bar prompts you to configure your code cleanup settings.

[![Code cleanup settings for C# in Visual Studio](format-document-settings-inline.png)](format-document-settings-expanded.png#lightbox)

|Label|Description|EditorConfig Rule| Tools>Options Rule|
|-----------|-----------------|-----------------|-----------------|
|**Apply all C# formatting rules (indentation, wrapping, spacing)**|The Format Document command always fixes formatting issues. This setting can't be changed.| [Core EditorConfig options](../../ide/create-portable-custom-editor-options.md)<br/>[.NET EditorConfig formatting options](../../ide/editorconfig-code-style-settings-reference.md#formatting-conventions) | **Text Editor** > **C#** > **Formatting** > [**Indentation**, **New Lines**, **Spacing**, **Wrapping**]|
|**Perform addition code cleanup during formatting**|When selected, applies fixes for the rules specified below on the **Edit.FormatDocument** command.| N/A | N/A |
|**Remove unnecessary usings**|When selected, removes unnecessary `using` directives when **Edit.FormatDocument** is triggered.| N/A | N/A|
|**Sort usings**|When selected, sorts `using` directives when **Edit.FormatDocument** is triggered.| dotnet_sort_system_directives_first  | **Text Editor** > **C#** > **Advanced** > **Place 'System' directives first when sorting usings** |
|**Add/remove braces for single-line control statements**|When selected, adds or removes braces from single-line control statements when **Edit.FormatDocument** is triggered.| csharp_prefer_braces  | **Text Editor** > **C#** > **Code Style** > **Code block preferences** > **Prefer braces** |
|**Add accessibility modifiers**|When selected, adds missing accessibility modifiers when **Edit.FormatDocument** is triggered.| dotnet_style_require_accessibility_modifiers  | N/A |
|**Sort accessibility modifiers**|When selected, sorts accessibility modifiers when **Edit.FormatDocument** is triggered.| csharp_preferred_modifier_order, visual_basic_preferred_modifier_order  | N/A |
|**Apply expression/block body preferences**|When selected, converts expression-bodied members to block bodies, or vice versa, when **Edit.FormatDocument** is triggered.| [Expression-bodied member EditorConfig options](../../ide/editorconfig-code-style-settings-reference.md#expression_bodied_members)  | **Text Editor** > **C#** > **Code Style** > **Expression preferences** > **Use expression body for methods, constructors, etc.**  |
|**Apply implicit/explicit type preferences**|When selected, converts `var` to the explicit type, or vice versa, when **Edit.FormatDocument** is triggered.| [Explicit type EditorConfig options](../../ide/editorconfig-code-style-settings-reference.md#implicit-and-explicit-types)  | **Text Editor** > **C#** > **Code Style** > **'var' preferences**  |
|**Apply inline 'out' variables preferences**|When selected, inlines `out` variables where possible when **Edit.FormatDocument** is triggered.| csharp_style_inlined_variable_declaration | **Text Editor** > **C#** > **Code Style** > **Variable preferences** > **Prefer inlined variable declaration** |
|**Apply language/framework type preferences**|When selected, converts language types to framework types, or vice versa, when **Edit.FormatDocument** is triggered.| dotnet_style_predefined_type_for_locals_parameters_members<br/>dotnet_style_predefined_type_for_member_access  | **Text Editor** > **C#** > **Code Style** > **predefined type preferences** |
|**Apply object/collection initialization preferences**|When selected, uses object and collection initializers where possible when **Edit.FormatDocument** is triggered.| dotnet_style_object_initializer<br/>dotnet_style_collection_initializer | **Text Editor** > **C#** > **Code Style** > **Expression preferences** > **Prefer [object | collection] initializer** |
|**Apply 'this.' qualification preferences**|When selected, applies `this.` preferences when **Edit.FormatDocument** is triggered.| [this. qualification EditorConfig options](../../ide/editorconfig-code-style-settings-reference.md#this_and_me) | **Text Editor** > **C#** > **Code Style** > **'this.' preferences**  |
|**Make private fields readonly when possible**|When selected, makes private fields `readonly` where possible when **Edit.FormatDocument** is triggered.| dotnet_style_readonly_field | **Text Editor** > **C#** > **Code Style** > **Field preferences** > **Prefer readonly** |
|**Remove unnecessary casts**|When selected, removes unnecessary casts where possible when **Edit.FormatDocument** is triggered.| N/A | N/A |
|**Remove unused variables**|When selected, removes variables that are unused when **Edit.FormatDocument** is triggered.| N/A | N/A |

## Preview window

The **Indentation**, **New Lines**, **Spacing**, and **Wrapping** options panes each display a preview window. The preview window shows the effect of each option. To use the preview window, select a formatting option. The preview window shows an example of the selected option. When you change a setting by selecting a radio button or check box, the preview window updates to show the effect of the new setting.

## Remarks

Indentation options on the **Tabs** pages for each language only determine where the code editor places the cursor when you press **Enter** at the end of a line. Indentation options under **Formatting** apply when code is formatted automatically, for example, when you paste code into the file while **Automatically format on paste** is selected, and when the block being formatted is typed manually.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described here, depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## See also

- [General, Environment, Options dialog box](../../ide/reference/general-environment-options-dialog-box.md)