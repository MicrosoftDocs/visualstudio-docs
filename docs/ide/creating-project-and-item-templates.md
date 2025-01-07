---
title: Templates for projects and files
description: Explore how project and item templates in Visual Studio provide reusable stubs that give users some basic code and structure.
ms.date: 1/07/2025
ms.topic: conceptual
helpviewer_keywords:
- templates [Visual Studio], project
- templates [Visual Studio], item
- item templates [Visual Studio]
- project templates [Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# What are project and item templates?

Project and item templates are reusable stubs that give you some basic code and structure to customize for your own purposes. Typically, you start with a project template and then you add an item template.

## Visual Studio templates

There are many predefined project and item templates available to you when you [install Visual Studio](../install/install-visual-studio.md). Project templates, such as the **ASP.NET Core Web App** and **Class Library** templates, are available to choose from when you [create a new project](create-new-project.md). Item templates, such as code files, XML files, HTML pages, and Style Sheets, appear in the **Project** > **Add New Item** dialog box.

These templates provide a starting point for users to begin creating projects, or to expand existing projects. Project templates provide the files that are required for a particular project type, include standard assembly references, and set default project properties and compiler options. Item templates can range in complexity from a single empty file that has a specific file extension, to multiple source code files with stub code, designer information files, and embedded resources.

You can use installed templates, author your own custom templates, or download and use templates created by the community. For more information, see [How to: Create project templates](how-to-create-project-templates.md) and [How to: Create item templates](how-to-create-item-templates.md).

## Contents of a template

All project and item templates, whether installed with Visual Studio or created by you, function by using the same principles and have similar contents. All templates contain the following items:

- The files to be created when the template is used. These files include source code files, embedded resources, project files, and so on.

- A *.vstemplate* file, which contains the metadata needed to create a project or item from the template and to display the template on the **Create a new project** page or in the **Add New Item** dialog box.

   For more information about *.vstemplate* files, see [Template tags](template-tags.md) and [Template parameters](../ide/template-parameters.md).

When these files are compressed into a *.zip* file and put in the correct folder, Visual Studio automatically displays them in the following places:

- Project templates appear on the **Create a new project** page.

- Item templates appear in the **Add New Item** dialog box.

For more information about template folders, see [How to: Locate and organize project and item templates](how-to-locate-and-organize-project-and-item-templates.md).

## Related content

- [Customize templates](../ide/customizing-project-and-item-templates.md)
- [NuGet packages in Visual Studio templates](/nuget/visual-studio-extensibility/visual-studio-templates)
