---
title: Providing Automation for VSPackages
description: Learn about how to provide automation for your VSPackages by implementing VSPackage-specific objects and by implementing standard automation objects.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- VSPackages, automation [Visual Studio SDK]
- automation [Visual Studio SDK], VSPackages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Providing Automation for VSPackages

There are two main ways to provide automation for your VSPackages: by implementing VSPackage-specific objects and by implementing standard automation objects. Generally, these are used together to extend the automation model of the environment.

## VSPackage-Specific Objects
 Certain places within the automation model require you to provide automation objects that are unique to your VSPackage. For instance, new projects require distinct objects that only your VSPackage provides. The names of these objects are entered in the registry and obtained through calls to the environment `DTE` object.

 VSPackage-specific objects can also be obtained when an automation consumer uses the object provided through the Object property of a standard object. For example, the standard `Window` object has an `Object` property, known commonly as the `Windows.Object` property. When consumers call the `Window.Object` on a window implemented in your VSPackage, you pass back a specific automation object of your own design.

#### Projects
 VSPackages can extend the automation model for new project types through their own VSPackage-specific objects. The primary purpose of providing new automation objects for your VSPackage is to differentiate your unique project objects from a <xref:Microsoft.VisualStudio.VCProjectEngine.VCProject> or a <xref:VSLangProj80.VSProject2> object. This differentiation is handy when you want to provide a way to single out or iterate your type of project apart from other project types, should they appear side-by-side in a solution. For more information, see [Exposing Project Objects](../../extensibility/internals/exposing-project-objects.md).

#### Events
 The event architecture of the environment offers another place for you to append your own VSPackage-specific objects. For example, by creating your own unique event objects, you can extend the environment's event model for projects. You might want to provide your own events when a new item is added to your own project type. For more information, see [Exposing Events](../../extensibility/internals/exposing-events-in-the-visual-studio-sdk.md).

#### Window Objects
 Windows can pass back a VSPackage-specific automation object back to the environment when called. You implement an object that is derived from <xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject>, <xref:EnvDTE.IExtensibleObject> or `IDispatch` that hands back properties, extending the window object in which it is sited. For example, you can use this approach to provide automation for a control sited in a window frame. The semantics of this object and any other objects that it might extend are yours to design. For more information, see [How to: Provide Automation for Windows](../../extensibility/internals/how-to-provide-automation-for-windows.md).

#### Options pages on the Tools menu
 You can create pages to extend the Tools, Options automation model through implementing pages and adding information to the registry to create your own options. Your pages can then be called through the environment object model like any other options pages. If the design of the feature you are adding to the environment through VSPackages requires options pages, then you should add the automation support as well. For more information, see [Automation Support for Options Pages](../../extensibility/internals/automation-support-for-options-pages.md).

## Standard Automation Objects
 To extend the automation for projects, you also implement standard automation objects (derived from `IDispatch`) that stand beside the other project objects and implement standard methods and properties. Examples of standard objects include the project objects that are inserted into the solution hierarchy such as `Projects`, `Project`, `ProjectItem`, and `ProjectItems`. Every new project type should implement these objects (and possibly other ones depending on the semantics of your project).

 In a sense, these objects provide the opposite advantage of the VSPackage-specific project objects. The standard automation objects allow your project to be used in a generalized way like any other project supporting the same objects. Thus, an add-in that is written against general `Project` and `ProjectItem` objects can function against projects of any type. For more information, see [Project Modeling](../../extensibility/internals/project-modeling.md).
