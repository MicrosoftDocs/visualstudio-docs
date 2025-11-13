---
title: Creating Project Types
description: Learn how to extend Visual Studio by designing, creating, and registering a new project type that supports programming tasks.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- project types, new
- projects [Visual Studio SDK], new project types
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create project types

You can extend Visual Studio by creating a new project type. To create a new project type, you must understand several concepts and complete a number of steps. The following topics provide an overview of how to create project types.

## In this section
- [Project type design decisions](../../extensibility/internals/project-type-design-decisions.md)

 Discusses the item, project file persistence, and commitment mechanic design decisions that you have to make before creating a new project type.

- [Checklist: Create new project types](../../extensibility/internals/checklist-creating-new-project-types.md)

 Provides an overview of the steps that you must follow to create a new project type that supports such programming tasks as editing code and compiling, building, debugging, and deploying applications in your project.

- [Create project instances by using project factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md)

 Provides information about how to provide and use a project factory to create instances of a new project.

- [Register a project type](../../extensibility/internals/registering-a-project-type.md)

 Provides code samples of statements from the registry that provide default paths and data, and a table that contain entries from the registry script for each statement.

- [Project persistence](../../extensibility/internals/project-persistence.md)

 Discusses the use of `IPersistFileFormat` to persist both file and non-file-based project objects.

- [Use MSBuild](../../extensibility/internals/using-msbuild.md)

 Describes how your project type can use the MSBuild build engine to let users build from Visual Studio and at the command line.

## Related sections
- [Support symbol-browsing tools](../../extensibility/internals/supporting-symbol-browsing-tools.md)

 Explains the architecture of code viewing tools such as the **Object Browser** and **Class View** window. Describes the interfaces and methods that are used to implement object browsing in a VSPackage.

- [Add project and project item templates](../../extensibility/internals/adding-project-and-project-item-templates.md)

 Discusses the significance that projects play in determining which editor is used when a project item is opened and how project resources can be manipulated.

- [Install VSPackages with Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md)

 Shows how to give your VSPackage its own unique identity and how to wrap your VSPackage DLLs and other information in a Windows Installer package (*.MSI* file) for deployment to your customers.

- [Hierarchies in Visual Studio](../../extensibility/internals/hierarchies-in-visual-studio.md)

 Describes how Visual Studio views and addresses hierarchies.

- [VSPackages](../../extensibility/internals/vspackages.md)

 Provides an overview of a VSPackage, an installable COM object that extends the Visual Studio environment and discusses how to implement your own VSPackage.

- [Project types](../../extensibility/internals/project-types.md)

 Discusses how to use projects to modify code, compile and build code, and run and debug code, and provides links to detailed topics about how to create project types.
