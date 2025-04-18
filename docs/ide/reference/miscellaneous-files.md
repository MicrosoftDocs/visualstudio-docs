---
title: Miscellaneous files
description: Learn how to work on files that are not included in a Visual Studio project or solution.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.newfile
- VS.OpenWith
- MiscellaneousFilesProject
helpviewer_keywords:
- solutions, miscellaneous files
- standalone files
- Solution Explorer, miscellaneous files
- Miscellaneous Files folder
- files [Visual Studio], miscellaneous
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Miscellaneous files

You might want to use the Visual Studio editor to work on files independently from a project or solution. While you have a solution open, you can open and modify files without adding them to a solution or to a project. Files you want to work with independently are called miscellaneous files. Miscellaneous files are external to solutions and projects, are not included in builds, and cannot be included with a solution under source control.

Opening files independently from a project or solution is useful for a variety of reasons. You might have a file that you want to view while developing a project-based solution but that's not integral to the solution's development. Common examples include development notes or instructions, database schema, and code clips. In addition, you might want to create a stand-alone file.

![Solutions Projects](../../ide/reference/media/projects_solutions_misc.gif)

Solution Explorer can display a **Miscellaneous Files** folder for the files if the options for the folder are enabled. The options can be set from the [Documents, Environment, Options Dialog Box](../../ide/reference/documents-environment-options-dialog-box.md). After you close a miscellaneous file, it is not associated with any particular solution or project unless an option is enabled for that as well.

The **Miscellaneous Files** folder represents the files as links. Although this folder is not part of a solution, when you open a solution, some or all of the miscellaneous files that were opened when the solution was last closed are reopened, depending upon the settings for the folder.

> [!NOTE]
> Some of the files that do not appear in the **Miscellaneous Files** folder are files that you cannot modify within the IDE, such as .zip files and .doc files. The IDE doesn't track files that can only be modified through an external editor.

## Commands available in the IDE

The menus, toolbars, and the commands they contain change based on the format of the file you open. When you open a text file, for example, the Text Editor toolbar appears and its commands are available. If you then open an XML Schema file, the XML Schema toolbar appears. While editing your XML Schema, the Text Editor toolbar's commands (or the toolbar itself) are unavailable. The XML Schema is the active window and as such, has current selection context. When you switch between a project file and a miscellaneous file, all project-related commands disappear and only those that are directly related to the miscellaneous file appear.

## Folder display options

You can set display options for the **Miscellaneous Files** folder so that the folder appears even though you have not opened any miscellaneous files. The solution file does not permanently manage a list of miscellaneous files. It uses an optional feature that allows it to remember a per-user, most recently used (MRU) list of files.

## See also

- [Develop code in Visual Studio without projects or solutions](../develop-code-in-visual-studio-without-projects-or-solutions.md)
- [Solutions and Projects](../../ide/solutions-and-projects-in-visual-studio.md)
- [Documents, Environment, Options Dialog Box](../../ide/reference/documents-environment-options-dialog-box.md)
