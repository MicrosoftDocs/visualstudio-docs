---
title: Add New Item Command
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "project.addnewitem"
helpviewer_keywords:
  - "Add New Item command"
  - "File.AddNewItem command"
ms.assetid: 63b7df32-db83-463b-bbe7-7ff011fe5298
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Add New Item Command
Adds a new solution item, such as an .htm, .css, .txt, or frameset to the current solution and opens it.

## Syntax

```cmd
File.AddNewItem [filename] [/t:templatename] [/e:editorname]
```

## Arguments
`filename`\
Optional. The path and file name of the item to add to the solution.

## Switches
/t: `templatename`\
Optional. Specifies the type of file to be created. If no template name is given, a text file is created by default.

The /t:`templatename` argument syntax mirrors the information found in the **Add New Solution Item** dialog box. You must enter the complete category followed by the file type, separating the category name from the file type by a backslash (`\`) and enclosing the entire string in quotation marks.

For example, to create a new text file, you would enter the following for the /t:`templatename` argument.

```cmd
/t:"General\Style Sheet"
```

/e: `editorname`\
Optional. The name of the editor in which the file will be opened. If the argument is specified but no editor name is supplied, the **Open With** dialog box appears.

The /e:`editorname` argument syntax uses the editor names as they appear in the **Open With Dialog Box**, enclosed in quotation marks.

For example, to open a style sheet in the source code editor, you would enter the following for the /e:`editorname` argument.

```cmd
/e:"Source Code (text) Editor"
```

## Example
This example adds a new solution item, MyHTMLpg, to the current solution.

```cmd
>File.AddNewItem MyHTMLpg /t:"General\HTML Page"
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)