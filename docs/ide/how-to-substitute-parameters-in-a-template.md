---
title: Add name parameters to project and item templates
description: Learn how to modify template parameters to replace identifiers like class names and namespaces.
ms.custom: SEO-VS-2020
ms.date: 01/02/2018
ms.topic: how-to
helpviewer_keywords:
- template parameters
- template parameters, substituting
- Visual Studio templates, using parameters
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
---
# How to: Substitute parameters in a template

Template parameters let you replace identifiers such as class names and namespaces when a file is created from a template. You can add template parameters to existing templates, or create your own templates with template parameters.

Template parameters are written in the format $*parameter*$. For a complete list of template parameters, see [Template parameters](../ide/template-parameters.md).

The following section shows you how to modify a template to replace the name of a namespace with the "safe project name".

## Example - namespace name

1. Insert the parameter in one or more of the code files in the template. For example:

    ```csharp
    namespace $safeprojectname$
    ```

1. In the *vstemplate* file for the template, locate the `ProjectItem` element that includes this file.

1. Set the `ReplaceParameters` attribute to `true` for the `ProjectItem` element:

    ```xml
    <ProjectItem ReplaceParameters="true">Class1.cs</ProjectItem>
    ```

## See also

- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [Template parameters](../ide/template-parameters.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [ProjectItem element (Visual Studio item templates)](../extensibility/projectitem-element-visual-studio-item-templates.md)
