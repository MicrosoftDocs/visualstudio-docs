---
title: Projects | Microsoft Docs
description: Learn about the ways that VSPackages can extend the Visual Studio project system, including project types, project subtypes, and custom tools.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- solutions [Visual Studio]
- custom tools [Visual Studio SDK]
- project subtypes [Visual Studio SDK]
- projects [Visual Studio SDK]
- project types [Visual Studio SDK]
ms.assetid: 237742e4-a638-4d5b-a9b3-6a69d627763c
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Projects
In Visual Studio, projects are the containers that developers use to organize source code files and other resources that appear in **Solution Explorer**. Typically, projects are files (for example, a .csproj file for a C# project) that store references to source code files and resources like bitmap files. Projects let you organize, build, debug, and deploy source code, references to Web services and databases, and other resources. VSPackages can extend the Visual Studio project system in three main ways: *project types*, *project subtypes*, and *custom tools*.

## In This Section
- [Project Types](../../extensibility/internals/project-types.md)

 *Project types* add support for new kinds of projects, such as programming languages. For example, each language that Visual Studio supports has its own project type, and the IronPython integration sample includes a project type for the IronPython language. You must create a project type for languages other than C# or Visual Basic to customize how items are built, debugged, deployed, and displayed in **Solution Explorer**. For more information, see [Project Types](../../extensibility/internals/project-types.md).

- [Project Subtypes](../../extensibility/internals/project-subtypes.md)

 *Project subtypes* are based on project types and can be used to customize the way projects are built, debugged, and deployed. Visual Studio uses project subtypes with Smart Device projects; they customize deployment by copying a newly-built program from a development computer to the target device. The C# and Visual Basic project types can be used as the basis for project subtypes; C++ project types cannot. Your own project types can also be used as the basis for project subtypes. For more information, see [Project Subtypes](../../extensibility/internals/project-subtypes.md).

- [Web Projects](../../extensibility/internals/web-projects.md)

 Explains Web project, which in turn create Web applications.

- [New Project Generation: Under the Hood, Part One](../../extensibility/internals/new-project-generation-under-the-hood-part-one.md) and [New Project Generation: Under the Hood, Part Two](../../extensibility/internals/new-project-generation-under-the-hood-part-two.md)

 Explains what actually occurs when you create a new project.

- [VSSDK Samples](https://github.com/Microsoft/VSSDK-Extensibility-Samples)
 Contains the samples in the VSSDK that deal with projects and solutions.

## Related Sections
- [Inside the Visual Studio SDK](../../extensibility/internals/inside-the-visual-studio-sdk.md)

 Explain different aspects of Visual Studio extensibility.
