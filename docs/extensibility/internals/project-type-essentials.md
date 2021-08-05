---
title: Project Type Essentials | Microsoft Docs
description: Learn about when you must create a project type and when you can extend an existing project type by using project subtypes.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- project types [Visual Studio SDK]
ms.assetid: 09991589-2300-430e-b6a4-7f2b95fe676f
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Project Type Essentials
[!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] includes several project types for languages such as [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] or [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)]. [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] also lets you create your own project types.

 If you just want to add custom commands, editors, or tool windows to [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], you can do so without creating a new project type. For more information, see the following topics:

- [Commands, Menus, and Toolbars](../../extensibility/internals/commands-menus-and-toolbars.md)

- [Editor and Language Service Extensions](../../extensibility/editor-and-language-service-extensions.md)

- [Extending and Customizing Tool Windows](../../extensibility/extending-and-customizing-tool-windows.md)

  Likewise, if you want to customize the behavior of the supplied [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] project types, you can do so using project subtypes. For more information, see [Project Subtypes](../../extensibility/internals/project-subtypes.md).

  You must create a new project type for projects that are based on a language other than [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] if you want to support one or more of the following:

- Build

- Deployment

- Multiple configurations

- Source control

- Debugging

- Project items in Solution Explorer

- The **Open Project** or **New Project** dialog boxes

- Project nesting

- For more information about the capabilities of project types, see the following:

- Project types are objects in a VSPackage that implement the set of interfaces [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] expects. If you are using C# to develop a project type, the Managed Package Framework project classes implement the necessary interfaces for you and let you inherit that implementation. For more information, see [Using the Managed Package Framework to Implement a Project Type (C#)](../../extensibility/internals/using-the-managed-package-framework-to-implement-a-project-type-csharp.md).

- For C++ developers, the classes in the HierUtil library work in a similar manner. For more information, see [Not in Build: Using HierUtil7 Project Classes to Implement a Project Type (C++)](/previous-versions/bb166212(v=vs.100)).

- Project types can support data other than typical source code files that build into an .exe or .dll assembly. For example, [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] database projects contain references to script and query files stored on disk and add commands to **Solution Explorer** to execute the scripts and queries against a database, but the projects do not support build behavior. For more information, see [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md).

- A project type does not have to use files at all. For example, a project type could store all its data in a database. [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] gives project types complete control over how they persist data for projects and project items. For more information, see [Project Type Design Decisions](../../extensibility/internals/project-type-design-decisions.md).

- Project types must provide a *project factory*, which is an object that creates an instance of the project type whenever [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is told to open or create a project that is based on that project type. For more information, see [Creating Project Instances By Using Project Factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md).

- Project types must supply templates for projects and project items. [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] uses the templates when users create new projects and add new items to existing projects. For more information, see [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md).

- Project types can support multiple configurations, such as Debug and Release. Users can change the different configurations of a project by using property pages that you supply. For more information, see [Managing Configuration Options](../../extensibility/internals/managing-configuration-options.md).

## See also
- [Deploying Project Types](../../extensibility/internals/deploying-project-types.md)