---
title: "How to: Create Starter Kits | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Starter Kits, creating"
ms.assetid: ed7d1844-7c01-424a-a831-5003efe0f7bc
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Starter Kits
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A Starter Kit contains code for a complete application and documentation on how to modify or expand the application. Creating a Starter Kit is fundamentally the same as creating a normal project template, the only difference being that a Starter Kit contains documentation files that are set to open when a project based on the Starter Kit is created.

## Designing and Developing a Starter Kit
 First, you must identify the type of Starter Kit that you want to develop and define your target audience. Next, design the project and documentation to meet your objectives.

 If you are creating a sample application or plug-in:

- Create a project that builds without errors.

- Add template code to implement additional tasks (optional).

- Prepare the documentation.

  If you are creating a learning tool:

- Create a project that builds without errors.

- Organize the resources, such as code snippets and item templates.

- Prepare the documentation.

## Creating a Template
 After you have completed the project and the documentation, you are ready to create the project template for the Starter Kit. This process is exactly the same as creating a project template.

 The following topics contain information about creating templates.

 [How to: Create Project Templates](../ide/how-to-create-project-templates.md)
 Explains how to use the **Export Template** wizard to create a template.

 [How to: Update Existing Templates](../ide/how-to-update-existing-templates.md)
 Describes how to edit an exported template. Use this procedure to modify the .vstemplate file to customize your Starter Kit.

## See Also
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
 [Customizing Templates](../ide/customizing-project-and-item-templates.md)
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
