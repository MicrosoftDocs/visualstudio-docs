---
title: "How to: Substitute Parameters in a Template | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "template parameters, substituting"
  - "Visual Studio templates, using parameters"
ms.assetid: a62924a7-4ba0-413d-b606-fdbe1fcf2807
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Substitute Parameters in a Template
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You may replace template parameters such as class names and namespaces when a file based on a template is created. For a complete list of template parameters, see [Template Parameters](../ide/template-parameters.md).

## Procedure
 You may replace parameters in the files of a template whenever a project based on that template is created. This procedure explains how to create a template that replaces the name of a namespace with the safe project name when a new project is created with the template.

#### To use a parameter to replace namespace name with the project name

1. Insert the parameter in one or more of the code files in the template. For example:

    ```
    namespace $safeprojectname$
    ```

    > [!NOTE]
    > Template parameters are written in the format $*parameter*$.

2. In the .vstemplate file for the template, locate the `ProjectItem` element that includes this file.

3. Set the `ReplaceParameters` attribute to `true` for the `ProjectItem` element. For example:

    ```
    <ProjectItem ReplaceParameters="true">Class1.cs</ProjectItem>
    ```

## See Also
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
 [Template Parameters](../ide/template-parameters.md)
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
 [ProjectItem Element (Visual Studio Item Templates)](../extensibility/projectitem-element-visual-studio-item-templates.md)
