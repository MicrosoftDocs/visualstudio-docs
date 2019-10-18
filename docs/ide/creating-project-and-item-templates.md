---
title: Templates for projects and files
ms.date: 01/02/2018
ms.topic: conceptual
helpviewer_keywords:
  - "templates [Visual Studio], project"
  - "templates [Visual Studio], item"
  - "item templates [Visual Studio]"
  - "project templates [Visual Studio]"
author: jillre
ms.author: jillfra
manager: jillfra
---
# Project and item templates

Project and item templates provide reusable stubs that give users some basic code and structure, that they can customize for their own purposes.

## Visual Studio templates

A number of predefined project and item templates are installed with Visual Studio. These templates, such as the **ASP.NET Web Application** and **Class Library** templates, are available to choose from when you create a new project. Item templates, such as code files, XML files, HTML pages, and Style Sheets, appear in the **Add New Item** window.

These templates provide a starting point for users to begin creating projects, or to expand existing projects. Project templates provide the files that are required for a particular project type, include standard assembly references, and set default project properties and compiler options. Item templates can range in complexity from a single empty file that has a certain file extension, to multiple source code files with stub code, designer information files, and embedded resources.

You can use installed templates, author your own custom templates, or download and use templates created by the community. For more information, see [How to: Create project templates](../ide/how-to-create-project-templates.md) and [How to: Create item templates](../ide/how-to-create-item-templates.md).

## Contents of a template

All project and item templates, whether installed with Visual Studio or created by you, function using the same principles and have similar contents. All templates contain the following items:

- The files to be created when the template is used. These files include source code files, embedded resources, project files, and so on.

::: moniker range="vs-2017"

- A *.vstemplate* file, which contains the metadata needed to create a project or item from the template and to display the template in the **New Project** and **Add New Item** windows.

::: moniker-end

::: moniker range=">=vs-2019"

- A *.vstemplate* file, which contains the metadata needed to create a project or item from the template and to display the template on the **Create a new project** page or in the **Add New Item** dialog box.

::: moniker-end

   For more information about *.vstemplate* files, see [Template tags](template-tags.md) and [Template parameters](../ide/template-parameters.md).

When these files are compressed into a *.zip* file and put in the correct folder, Visual Studio automatically displays them in the following places:

::: moniker range="vs-2017"

- Project templates appear in the **New Project** window.

::: moniker-end

::: moniker range=">=vs-2019"

- Project templates appear on the **Create a new project** page.

::: moniker-end

- Item templates appear in the **Add New Item** window.

For more information about template folders, see [How to: Locate and organize templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

## See also

- [How to: Create project templates](../ide/how-to-create-project-templates.md)
- [How to: Create item templates](../ide/how-to-create-item-templates.md)
- [Template tags](template-tags.md)
- [Template parameters](../ide/template-parameters.md)
- [Customize templates](../ide/customizing-project-and-item-templates.md)
- [NuGet packages in Visual Studio templates](/nuget/visual-studio-extensibility/visual-studio-templates)