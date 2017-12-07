---
title: "Using EditorConfig settings in VisualStudio | Microsoft Docs"
ms.custom: ""
ms.date: "10/27/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "editorconfig [Visual Studio]"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: vs-ide-general
---
# Create portable, custom editor settings with EditorConfig

In Visual Studio 2017, you can add an [EditorConfig](http://editorconfig.org/) file to your project or codebase to enforce consistent coding styles for everyone that works in the codebase. EditorConfig settings take precedence over global Visual Studio text editor settings. While you may have personal coding style preferences set in Visual Studio options, you can still abide by varying style guidelines for different codebases, if the codebase includes an .editorconfig file. An example of such a preference is indent style&mdash;tabs or spaces. EditorConfig settings are supported by numerous code editors and IDEs, including Visual Studio, so it's a portable component that travels  with your code and can be used elsewhere.

## Coding consistency

Settings in EditorConfig files enable you to maintain consistent coding styles and settings in a codebase, such as indent style, tab width, end of line characters, encoding, and more, regardless of the editor or IDE you use. For example, when coding in C#, if your codebase has a convention to prefer that indents always consist of five space characters, documents use UTF-8 encoding, and each line always ends with a CR/LF, you can configure an .editorconfig file to do that.

Coding conventions you use on your personal projects may differ from those used on your team's projects. For example, you might prefer that when you're coding, indenting adds a tab character. However, your team might prefer that indenting adds four space characters instead of a tab character. EditorConfig files resolve this problem by enabling you to have a configuration for each scenario.

Because the settings are contained in a file in the codebase, they travel along with that codebase. As long as you open the code file in an EditorConfig-compliant editor, the text editor settings are implemented. For more information about EditorConfig files, see the [EditorConfig.org](http://editorconfig.org/) website.

## Override EditorConfig settings

When you add an .editorconfig file to a folder in your file hierarchy, its settings apply to all applicable files at that level and below. To override EditorConfig settings for a particular project or codebase such that it uses different conventions than the top-level EditorConfig file, just add an .editorconfig file to the root of your codebase's repo or project directory. Make sure to put the ```root=true``` property in the file so Visual Studio doesn't look any further up the directory structure for .editorconfig files. The new EditorConfig file settings will apply to files in the same level and any subdirectories.

```
# top-most EditorConfig file
root = true
```

![EditorConfig hierarchy](../ide/media/vside_editorconfig_hierarchy.png)

EditorConfig files are read top to bottom, and the closest EditorConfig files are read last. Conventions from matching EditorConfig sections are applied in the order they were read, so conventions in closer files take precedence.

## Supported settings

The editor in Visual Studio supports the following from the core set of [EditorConfig properties](http://editorconfig.org/#supported-properties):

- indent_style
- indent_size
- tab_width
- end\_of_line
- charset
- root

EditorConfig editor settings are supported in all Visual Studio-supported languages except for XML. In addition, EditorConfig supports [code style](../ide/editorconfig-code-style-settings-reference.md) and [naming](../ide/editorconfig-naming-conventions.md) conventions for C# and Visual Basic.

## Editing EditorConfig files

Visual Studio provides some IntelliSense for editing .editorconfig files. If you edit a lot of .editorconfig files, you may find the [EditorConfig Language Service](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.EditorConfig) extension helpful.

After you've edited your EditorConfig file, you must reload your code files for the new settings to take effect.

## Adding and removing EditorConfig files

Adding an EditorConfig file to your project or codebase will not convert existing styles to the new ones. For example, if you have indents in your file that are formatted with tabs, and you add an EditorConfig file that indents with spaces, the indent characters will not get converted to spaces. However, any new lines of code will be formatted according to the EditorConfig file.

If you remove an EditorConfig file from your project or codebase, you must close and reopen any open code files to revert to the global editor settings for new lines of code.

## Example

The following is an example that shows the indent state of a C# code snippet before and after adding an .editorconfig file to the project. The **Tabs** setting in the **Options** dialog box for the Visual Studio text editor is set to produce space characters when you press the **Tab** key.

![Text Editor tab setting](../ide/media/vside_editorconfig_tabsetting.png)

As expected, pressing the **Tab** key on the next line indents the line by adding four additional white space characters.

![Code before using EditorConfig](../ide/media/vside_editorconfig_before.png)

We'll add a new file called .editorconfig to the project, with the following contents. The `[*.cs]` setting means that this change will apply only to C# code files in this project.

```
# Top-most EditorConfig file
root = true

# Tab indentation
[*.cs]
indent_style = tab
```

Now, when you press the **Tab** key, you get tab characters instead of spaces.

![Tab key adds Tab character](../ide/media/vside_editorconfig_tab.png)

## Troubleshooting EditorConfig settings

If there is an EditorConfig file anywhere in the directory structure at or above your project's location, Visual Studio will apply the editor settings in that file to your editor. In this case, you may see the following message in the status bar:

   **"User preferences for this file type are overridden by this project's coding conventions."**

This means that if any editor settings in **Tools**, **Options**, **Text Editor** (such as indent size and style, tab size, or coding conventions) are specified in an EditorConfig file at or above the project in the directory structure, the conventions in the EditorConfig file will override the settings in Options. You can control this behavior by toggling the **Follow project coding conventions** option in **Tools**, **Options**, **Text Editor**. Unchecking the option will turn off EditorConfig support for Visual Studio.

![Tools Options - follow project coding conventions](media/coding_conventions_option.png)

You can find any .editorconfig files in parent directories by opening a command prompt and running the following command from the root of the disk that contains your project:

```
dir .editorconfig /s
```

You can control the scope of your EditorConfig conventions by setting the ```root=true``` property in the .editorconfig file at the root of your repo or in the directory that your project resides. Visual Studio looks for a file named .editorconfig in the directory of the opened file and in every parent directory. Visual Studio stops searching if the root filepath is reached, or if an .editorconfig file with ```root=true``` is found.

## See also

[.NET code style conventions](../ide/editorconfig-code-style-settings-reference.md)  
[Supporting EditorConfig for a language service](../extensibility/supporting-editorconfig.md)  
[EditorConfig.org](http://editorconfig.org/)  
[Writing code in the editor](writing-code-in-the-code-and-text-editor.md)