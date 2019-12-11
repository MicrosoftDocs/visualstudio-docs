---
title: "Creating Project and Item Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "templates [Visual Studio], projects"
  - "item templates, about item templates"
  - "templates [Visual Studio], item"
  - "Visual Studio templates, item"
  - "Visual Studio templates, about templates"
  - "project templates [Visual Studio], about project templates"
  - "Visual Studio templates, project"
  - "templates [Visual Studio], about templates"
ms.assetid: a6ce501a-699b-4e3e-ade8-c81895645c20
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# Creating Project and Item Templates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project and item templates provide reusable stubs that give users some basic code and structure that they can use for their own purposes.

## Visual Studio Templates
 A number of predefined project and item templates are installed when you install [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. The [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] and [!INCLUDE[csprcs](../includes/csprcs-md.md)] Windows Forms Application and Class Library templates that are available in the **New Project** dialog box are examples of project templates. Installed item templates are available in the **Add New Item** dialog box, and include items such as code files, XML files, HTML pages, and Style Sheets.

 These templates provide a starting point for users to begin creating projects or expanding current projects. Project templates provide the files that are required for a particular project type, include standard assembly references, and set default project properties and compiler options. Item templates can range in complexity from just one empty file that has the correct file name extension to a multi-file item that contains, for example, source code files that have stub code, designer information files, and embedded resources.

 In addition to the installed templates in the **New Project** and **Add New Item** dialog boxes, you can author your own templates or download and use templates created by the community. For more information, see [How to: Create Project Templates](../ide/how-to-create-project-templates.md) and [How to: Create Item Templates](../ide/how-to-create-item-templates.md).

## Contents of a Template
 All project and item templates, whether installed together with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] or created by you, function by using the same principles and have similar contents. All templates contain the following items:

- The files to be created when the template is used. This includes source code files, embedded resources, project files, and so on.

- One .vstemplate file. This file contains the metadata that provides [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] the information it needs to display the template in the **New Project** and **Add New Item** dialog boxes and create a project or item from the template. For more information about .vstemplate files, see [Template Parameters](../ide/template-parameters.md).

  When these files are compressed into a .zip file and put in the correct folder, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] automatically displays them. Project templates appear in the **My Templates** section of the **New Project** dialog boxes, and item templates appear in the **Add New Item** dialog boxes. For more information about template folders, see [How to: Locate and Organize Templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

## Starter Kits
 Starter Kits are enhanced templates that can be shared with other members of the community. A Starter Kit includes code samples that compile, documentation, and other resources to help users learn new tools and programming techniques while they build useful, real-world applications. The basic contents and procedures for Starter Kits are identical to those for templates. For more information, see [How to: Create Starter Kits](../ide/how-to-create-starter-kits.md).

## See Also
 [How to: Create Project Templates](../ide/how-to-create-project-templates.md)
 [How to: Create Item Templates](../ide/how-to-create-item-templates.md)
 [Template Parameters](../ide/template-parameters.md)
 [Customizing Templates](../ide/customizing-project-and-item-templates.md)
 [How to: Create Starter Kits](../ide/how-to-create-starter-kits.md)
