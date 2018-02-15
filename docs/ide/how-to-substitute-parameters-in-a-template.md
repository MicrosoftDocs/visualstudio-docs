---
title: "Add name parameters to project and item templates in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "template parameters"
  - "template parameters, substituting"
  - "Visual Studio templates, using parameters"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: Substitute parameters in a template

Template parameters enable you to replace identifiers such as class names and namespaces, when a file is created from a template. You can add template parameters to existing templates, or create your own templates with template parameters.

Template parameters are written in the format $*parameter*$. For a complete list of template parameters, see [Template parameters](../ide/template-parameters.md).

The following section shows you how to modify a template to replace the name of a namespace with the "safe project name".

## To use a parameter to replace the namespace name

1. Insert the parameter in one or more of the code files in the template. For example:

    ```csharp
    namespace $safeprojectname$
    ```

1. In the .vstemplate file for the template, locate the `ProjectItem` element that includes this file.

1. Set the `ReplaceParameters` attribute to `true` for the `ProjectItem` element:

    ```xml
    <ProjectItem ReplaceParameters="true">Class1.cs</ProjectItem>
    ```

## See also

[Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)  
[Template Parameters](../ide/template-parameters.md)  
[Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)  
[ProjectItem Element (Visual Studio Item Templates)](../extensibility/projectitem-element-visual-studio-item-templates.md)