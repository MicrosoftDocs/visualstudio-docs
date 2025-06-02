---
title: Options, Text Editor, File Extension
description: Learn how to use the File Extension page to specify how all files with certain file extensions will be handled by the Visual Studio IDE.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.File_Extension
helpviewer_keywords:
- file extensions, associating to editor
- Editing Experience
- Options dialog box
- Editing Experience, selecting
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, File Extension

This Options dialog allows you to specify how all files with certain file extensions will be handled by the Visual Studio integrated development environment (IDE). For each **Extension** that you enter, you can select an Editing Experience. This allows you to choose the IDE editor or designer in which documents of a certain type will open. To display these options, choose **Options** from the **Tools** menu, expand the **Text Editor** node, and select **File Extension**.

When you select an option "with Encoding," a dialog will be displayed whenever you open a document of that type that allows you to select an encoding scheme for that document. This can be helpful if you are preparing versions of your project documents for use on different platforms or in different target languages.

## UIElement list

**Extension**

Type the file extension whose Editing Experience in the IDE you wish to define.

**Editor**

Select the IDE editor or designer in which documents with this file extension will open. When you select an option "with ncoding," a dialog will be displayed whenever you open such a document that allows you to select an encoding scheme.

**Add**

Adds an entry that includes the specified **Extension** and **Editing Experience** to the Extension List.

**Remove**

Deletes the selected entry from the Extension List.

**Extension List**

Lists all extensions for which an Editing Experience has been specified.

**Map extensionless files to**

Select this option if you wish to specify how files without an extension will be handled by the IDE.

**Extensionless file options**

Provides the same list as **Editor**. Select the IDE editor or designer in which documents without file extensions will open.

## See also

- [How to: Manage Editor Modes](../../ide/how-to-manage-editor-modes.md)
