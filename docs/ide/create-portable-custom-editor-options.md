---
title: "Create portable, custom editor options | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "editor"  
ms.assetid:
caps.latest.revision: 29
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Create portable, custom editor options
Text editor settings in Visual Studio are personal to you, but apply to all projects of a given type. So, for example, if you change a C# text editor setting, that setting applies to *all* C# projects. However, in many cases, especially when working with a team on a project, you’ll have conventions that you’d like to adhere to that might clash with your own personal preferences. [EditorConfig](http://editorconfig.org/) files let you accommodate this by providing common text editor options on a per-project basis. EditorConfig settings, which are contained in an .editorconfig file added to your codebase, supersede global Visual Studio text editor settings. This means that you can tailor each codebase to use the text editor settings you prefer. No plug-in is required to use this functionality in Visual Studio.

## Coding consistency
Settings in EditorConfig files enable you to maintain consistent coding styles and settings for a language, such as indent style, tab width, end of line characters, encoding, and more, in a codebase regardless of the editor or IDE you use. For example, when coding in C#, if your codebase has a convention to prefer that indents always consist of five space characters, documents use UTF-8 encoding, and each line always ends with a CR/LF, you can configure an .editorconfig file to do that.

Coding conventions you use on your personal projects may differ from those used on your team's projects. For example, you might prefer that when you're coding, pressing the Tab key adds a TAB character. However, your team might prefer that indenting adds four space characters instead of a TAB character. EditorConfig files resolve this problem by enabling you to have a configuration for each scenario.

Because the settings are contained in a file in the codebase, they travel along with that codebase. As long as you open the code file in an EditorConfig-compliant editor, the text editor settings are implemented. For more information about EditorConfig files, see the [EditorConfig.org](http://editorconfig.org/) website.

## Supported settings
The editor in Visual Studio supports the core set of EditorConfig options.
- indent_style
- indent_size
- tab_width
- end_of_line
- charset
- trim_trailing_whitespace
- insert_final_newline
- root

## Example
Here is an example that shows the indent state of a C# code snippet before and after adding a .editorconfig file to the project. The **Tabs** setting in the **Options** dialog box for the Visual Studio text editor is set to produce four spaces when you press the TAB key in your code.

![Text Editor tab setting](../ide/media/vside_editorconfig_tabsetting.png)

As expected, pressing the TAB key on the next line produces white space characters.

![Code before using EditorConfig](../ide/media/vside_editorconfig_before.png)

We'll add the following to a new file called .editorconfig to the project. (The `[*.cs]` setting means that this change will apply only to .cs files in this project.)

![Added .editorconfig file to project](../ide/media/vside_editorconfig_addconfig.png)

Now, when you press the TAB key, you get Tab characters instead of spaces.

![TAB adds Tab character](../ide/media/vside_editorconfig_tab.png)

> [!NOTE]
>  Adding a .editorconfig to your project will not convert the existing styles to the new ones, it will only apply to newly-added lines. If you remove a .editorconfig file from your project, you must reload the code file(s) for the editor settings to revert back to global settings. Any errors in .editorconfig files are reported in the Error window in Visual studio.
