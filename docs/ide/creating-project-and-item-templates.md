---
title: Visual Studio templates for projects and files
ms.date: 01/02/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "templates [Visual Studio], project"
  - "templates [Visual Studio], item"
  - "item templates [Visual Studio]"
  - "project templates [Visual Studio]"
author: gewarren
ms.author: gewarren
manager: douge
---
# Project and item templates

Project and item templates provide reusable stubs that give users some basic code and structure, that they can customize for their own purposes.

## Visual Studio templates

A number of predefined project and item templates are installed with Visual Studio. For example, the Visual Basic and C# **Windows Forms App** and **Class Library** templates that are shown in the **New Project** dialog box are project templates. Item templates show in the **Add New Item** dialog box, and include items such as code files, XML files, HTML pages, and Style Sheets.

These templates provide a starting point for users to begin creating projects, or to expand existing projects. Project templates provide the files that are required for a particular project type, include standard assembly references, and set default project properties and compiler options. Item templates can range in complexity from a single empty file that has a certain file extension, to multiple source code files with stub code, designer information files, and embedded resources.

You can use installed templates in the **New Project** and **Add New Item** dialog boxes, author your own templates, or download and use templates created by the community. For more information, see [How to: Create project templates](../ide/how-to-create-project-templates.md) and [How to: Create item templates](../ide/how-to-create-item-templates.md).

## Contents of a template

All project and item templates, whether installed with Visual Studio or created by you, function using the same principles and have similar contents. All templates contain the following items:

- The files to be created when the template is used. These files include source code files, embedded resources, project files, and so on.

- One *.vstemplate* file, containing the metadata needed to display the template in the **New Project** and **Add New Item** dialog boxes and create a project or item from the template. For more information about *.vstemplate* files, see [Template parameters](../ide/template-parameters.md).

When these files are compressed into a *.zip* file and put in the correct folder, Visual Studio automatically displays them in the following places:

- Project templates appear in the **New Project** dialog box.

- Item templates appear in the **Add New Item** dialog box.

For more information about template folders, see [How to: Locate and organize templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

## Starter Kits

Starter Kits are enhanced templates that can be shared with other members of the community. Starter Kits include compilable code samples, documentation, and other resources to help users learn new tools and programming techniques while building useful, real-world applications. The basic contents and procedures for Starter Kits are the same as for templates. For more information, see [How to: Create Starter Kits](../ide/how-to-create-starter-kits.md).

## See also

- [How to: Create project templates](../ide/how-to-create-project-templates.md)
- [How to: Create item templates](../ide/how-to-create-item-templates.md)
- [Template parameters](../ide/template-parameters.md)
- [Customizing templates](../ide/customizing-project-and-item-templates.md)
- [NuGet packages in Visual Studio templates](/nuget/visual-studio-extensibility/visual-studio-templates)