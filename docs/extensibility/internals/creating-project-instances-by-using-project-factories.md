---
title: Creating Project Instances By Using Project Factories
description: Learn how to create project class instances by using project factories in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- project factories
- projects [Visual Studio SDK], project factories
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create project instances by using project factories

Project types in Visual Studio use a *project factory* to create instances of project objects. A project factory is similar to a standard class factory for cocreatable COM objects. However, project objects are not cocreatable; they can only be created by using a project factory.

 The Visual Studio IDE calls the project factory implemented in your VSPackage when a user loads an existing project or creates a new project in Visual Studio. The new project object provides the IDE with enough information to populate **Solution Explorer**. The new project object also provides the required interfaces for supporting all relevant UI actions initiated by the IDE.

 You can implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory> interface in a class in your project. Typically, it resides in its own module.

 Projects that support being aggregated by an owner must persist an owner key in their project file. When the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject%2A> method is called on a project with an owner key, the owned project converts its owner key to a project factory GUID then calls the `CreateProject` method on this project factory to do the actual creation.

## Create an owned project
 An owner creates an owned project in two phases:

1. By calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOwnedProjectFactory.PreCreateForOwner%2A> method. This gives the owned project a chance to create an aggregated project object based on the input controlling `IUnknown`. The owned project passes the inner `IUnknown` and the aggregated object back to the owner project. This gives the owned project a chance to store the inner `IUnknown`.

2. By calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsOwnedProjectFactory.InitializeForOwner%2A> method. The owned project does all its instantiation when this method is called instead of calling `IVsProjectFactory::CreateProject` as would be the case for projects that are not owned. The input `VSOWNEDPROJECTOBJECT` enumeration is typically the aggregated owned project. The owned project can use this variable to determine whether its project object has already been created (cookie does not equal NULL) or must be created (cookie equals NULL).

   Project types are identified by a unique project GUID, similar to the CLSID of a cocreatable COM object. Typically, one project factory handles creating instances of a single project type, although it is possible to have one project factory handle more than one project type GUID.

   Project types are associated with a particular file name extension. When a user attempts to open an existing project file or attempts to create a new project by cloning a template, the IDE uses the extension on the file to determine the corresponding project GUID.

   As soon as the IDE determines whether it must create a new project or open an existing project of a particular type, the IDE uses the information in the system registry under **[HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\Projects]** to find which VSPackage implements the required project factory. The IDE loads this VSPackage. In the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A> method, the VSPackage must register its project factory with the IDE by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterProjectTypes.RegisterProjectType%2A> method.

   The primary method of the `IVsProjectFactory` interface is <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject%2A>, which should handle two scenarios: opening an existing project and creating a new project. Most projects store their project state in a project file. Typically, new projects are created by making a copy of the template file passed to the `CreateProject` method and then opening the copy. Existing projects are instantiated by directly opening the project file passed to `CreateProject` method. The `CreateProject` method can display additional UI features to the user as necessary.

   A project can also use no files and, instead, store its project state in a storage mechanism other than the file system, such as a database or Web server. In this case, the file name parameter passed to the `CreateProject` method is not actually a file system path but a unique string—a URL—to identify the project data. You do not need to copy the template files that are passed to `CreateProject` to trigger the appropriate construction sequence to be executed.

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsOwnedProjectFactory>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterProjectTypes>
- [Checklist: Create new project types](../../extensibility/internals/checklist-creating-new-project-types.md)
