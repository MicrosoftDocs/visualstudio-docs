---
title: "Create portable, custom editor settings with EditorConfig | Microsoft Docs"
ms.custom: ""
ms.date: "10/27/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "editor"
ms.assetid: 
caps.latest.revision: 29
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: 
  - "vs-ide-general"
---
# Create portable, custom editor settings with EditorConfig
Text editor settings in Visual Studio apply to all projects of a given type. So, for example, if you change a C# text editor setting, that setting applies to *all* C# projects in Visual Studio. However, in some cases, you may need to use conventions that differ from your own personal editor preferences. [EditorConfig](http://editorconfig.org/) files enable you to do this by providing common text editor options on a per-project basis. EditorConfig settings, which are contained in an .editorconfig file added to your codebase, supersede global Visual Studio text editor settings. This means that you can tailor each codebase to use the text editor settings you prefer. No plug-in is required to use this functionality in Visual Studio.

## Coding consistency
Settings in EditorConfig files enable you to maintain consistent coding styles and settings for a language, such as indent style, tab width, end of line characters, encoding, and more, in a codebase regardless of the editor or IDE you use. For example, when coding in C#, if your codebase has a convention to prefer that indents always consist of five space characters, documents use UTF-8 encoding, and each line always ends with a CR/LF, you can configure an .editorconfig file to do that.

Coding conventions you use on your personal projects may differ from those used on your team's projects. For example, you might prefer that when you're coding, pressing the Tab key adds a TAB character. However, your team might prefer that indenting adds four space characters instead of a TAB character. EditorConfig files resolve this problem by enabling you to have a configuration for each scenario.

Because the settings are contained in a file in the codebase, they travel along with that codebase. As long as you open the code file in an EditorConfig-compliant editor, the text editor settings are implemented. For more information about EditorConfig files, see the [EditorConfig.org](http://editorconfig.org/) website. If you edit a lot of .editorconfig files, you may find the [EditorConfig Language Service](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.EditorConfig) extension helpful.

## Override EditorConfig settings
When you add a .editorconfig file to a folder in your file hierarchy, its settings apply to all applicable files at that level and below. To override EditorConfig settings for a particular project or codebase such that it uses different conventions than the top-level .editorconfig file, just add a .editorconfig file to the root of your codebase's repo or project directory. Make sure to put the ```root=true``` property in the file so Visual Studio doesn't look for any .editorconfig files further up the directory structure. The new .editorconfig file settings will apply to the level in which it is located and files in any subdirectories.

```
# top-most EditorConfig file
root = true
```

![EditorConfig hierarchy](../ide/media/vside_editorconfig_hierarchy.png)

## Supported settings
The editor in Visual Studio supports the following from the core set of [EditorConfig properties](http://editorconfig.org/#supported-properties):  

- indent_style
- indent_size
- tab_width
- end_of_line
- charset
- root

In addition, it supports the [.NET code style conventions](../ide/editorconfig-code-style-settings-reference.md).  

EditorConfig settings are supported in all Visual Studio-supported languages except for XML.

## Example
Here is an example that shows the indent state of a C# code snippet before and after adding a .editorconfig file to the project. The **Tabs** setting in the **Options** dialog box for the Visual Studio text editor is set to produce space characters when you press the **Tab** key in your code.

![Text Editor tab setting](../ide/media/vside_editorconfig_tabsetting.png)

As expected, pressing the **Tab** key on the next line indents the line by adding four additional white space characters.

![Code before using EditorConfig](../ide/media/vside_editorconfig_before.png)

We'll add a new file called .editorconfig to the project, with the following contents. The `[*.cs]` setting means that this change will apply only to .cs files in this project.  

![Added .editorconfig file to project](../ide/media/vside_editorconfig_addconfig.png)

Now, when you press the **Tab** key, you get tab characters instead of spaces.

![TAB adds Tab character](../ide/media/vside_editorconfig_tab.png)

> [!NOTE]
>  Adding a .editorconfig file to your project or codebase will not convert the existing styles to the new ones, it will only apply to newly-added lines. If you remove a .editorconfig file from your project or codebase, you must reload the code file(s) for the editor settings to revert back to global settings. Any errors in .editorconfig files are reported in the Error List window in Visual studio.

## Troubleshooting EditorConfig settings
If there is an EditorConfig file anywhere in the directory structure at or above your project's location, Visual Studio will apply the editor settings in that file to your editor. In this case, you may see the following message in the status bar:

**"User preferences for this file type are overridden by this project's coding conventions."**

This means that if any editor settings in **Tools**, **Options**, **Text Editor** (such as indent size, tab size, indent style &mdash; tabs or spaces, or coding conventions such as the use of `var`) are specified in an EditorConfig file at or above the project in the directory structure, the settings in the EditorConfig file will override the settings in **Tools**, **Options**, **Text Editor**.

You can find any EditorConfig files in parent directories by opening a command prompt and running the following command from the root of the disk that contains your project:

```
dir *.editorconfig /s
```

You can control the scope of your EditorConfig conventions by setting the ```root=true``` property in the .editorconfig file at the root of your repo or in the directory that your project resides. Visual Studio looks for a file named .editorconfig in the directory of the opened file and in every parent directory. Visual Studio stops searching if the root filepath is reached, or if a .editorconfig file with ```root=true``` is found.

EditorConfig files are read top to bottom, and the closest EditorConfig files are read last. Conventions from matching EditorConfig sections are applied in the order they were read, so conventions in closer files take precedence.

## Support EditorConfig for your language service
In most cases when you implement a Visual Studio language service, no additional work is needed to support EditorConfig universal properties. The core editor automatically discovers and reads the .editorconfig file when users open files, and it sets the appropriate text buffer and view options. However, some language services opt to use an appropriate contextual text view option rather than using global settings for items such as tabs and spaces when a user edits or formats text. In these cases, the language service must be updated to support EditorConfig files.

Following are the changes needed to update a language service to support EditorConfig files, by replacing a global _language-specific_ option with a _contextual_ option:  

### Indent style
Replace:  

Microsoft.VisualStudio.TextManager.Interop.LANGPREFERENCES.fInsertTabs  
_or_  
Microsoft.VisualStudio.Package.LanguagePreferences.InsertTabs  

With:  

!textBufferOptions.GetOptionValue(DefaultOptions.ConvertTabsToSpacesOptionId)  
_or_  
!textView.Options.GetOptionValue(DefaultOptions.ConvertTabsToSpacesOptionId)  

### Indent size
Replace:  

Microsoft.VisualStudio.TextManager.Interop.LANGPREFERENCES.uIndentSize  
_or_  
Microsoft.VisualStudio.Package.LanguagePreferences.InsertTabs.IndentSize  

With:  

textBufferOptions.GetOptionValue(DefaultOptions.IndentSizeOptionId)  
_or_  
textView.Options.GetOptionValue(DefaultOptions.IndentSizeOptionId)  

### Tab size
Replace:  

Microsoft.VisualStudio.TextManager.Interop.LANGPREFERENCES.uTabSize  
_or_  
Microsoft.VisualStudio.Package.LanguagePreferences.InsertTabs.TabSize  

With:  

textBufferOptions.GetOptionValue(DefaultOptions.TabSizeOptionId)  
_or_  
textView.Options.GetOptionValue(DefaultOptions.TabSizeOptionId)  

## See also
[Create Portable Custom Editor Options with EditorConfig](create-portable-custom-editor-options.md)