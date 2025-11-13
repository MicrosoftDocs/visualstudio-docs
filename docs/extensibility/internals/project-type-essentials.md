---
title: Project Type Essentials
description: Learn about when you must create a project type and when you can extend an existing project type by using project subtypes.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- project types [Visual Studio SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Type Essentials

Visual Studio includes several project types for languages such as Visual C# or Visual Basic. Visual Studio also lets you create your own project types.

 If you just want to add custom commands, editors, or tool windows to Visual Studio, you can do so without creating a new project type. For more information, see the following topics:

- [Commands, Menus, and Toolbars](../../extensibility/internals/commands-menus-and-toolbars.md)

- [Editor and Language Service Extensions](../../extensibility/editor-and-language-service-extensions.md)

- [Extending and Customizing Tool Windows](../../extensibility/extending-and-customizing-tool-windows.md)

  Likewise, if you want to customize the behavior of the supplied Visual C# and Visual Basic project types, you can do so using project subtypes. For more information, see [Project Subtypes](../../extensibility/internals/project-subtypes.md).

  You must create a new project type for projects that are based on a language other than Visual C# and Visual Basic if you want to support one or more of the following:

- Build

- Deployment

- Multiple configurations

- Source control

- Debugging

- Project items in Solution Explorer

- The **Open Project** or **New Project** dialog boxes

- Project nesting

- For more information about the capabilities of project types, see the following:

- Project types are objects in a VSPackage that implement the set of interfaces Visual Studio expects. If you are using C# to develop a project type, the Managed Package Framework project classes implement the necessary interfaces for you and let you inherit that implementation. For more information, see [Using the Managed Package Framework to Implement a Project Type (C#)](../../extensibility/internals/using-the-managed-package-framework-to-implement-a-project-type-csharp.md).

- For C++ developers, the classes in the HierUtil library work in a similar manner. For more information, see [Not in Build: Using HierUtil7 Project Classes to Implement a Project Type (C++)](/previous-versions/bb166212(v=vs.100)).

- Project types can support data other than typical source code files that build into an .exe or .dll assembly. For example, Visual Studio database projects contain references to script and query files stored on disk and add commands to **Solution Explorer** to execute the scripts and queries against a database, but the projects do not support build behavior. For more information, see [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md).

- A project type does not have to use files at all. For example, a project type could store all its data in a database. Visual Studio gives project types complete control over how they persist data for projects and project items. For more information, see [Project Type Design Decisions](../../extensibility/internals/project-type-design-decisions.md).

- Project types must provide a *project factory*, which is an object that creates an instance of the project type whenever Visual Studio is told to open or create a project that is based on that project type. For more information, see [Creating Project Instances By Using Project Factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md).

- Project types must supply templates for projects and project items. Visual Studio uses the templates when users create new projects and add new items to existing projects. For more information, see [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md).

- Project types can support multiple configurations, such as Debug and Release. Users can change the different configurations of a project by using property pages that you supply. For more information, see [Managing Configuration Options](../../extensibility/internals/managing-configuration-options.md).

## See also
- [Deploying Project Types](../../extensibility/internals/deploying-project-types.md)