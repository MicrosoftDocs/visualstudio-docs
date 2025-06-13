---
title: Extending Properties
description: Learn about the interfaces that you must implement and call to extend the list of properties in the Visual Studio Properties window.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Properties window, providing support
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extend properties

The Visual Studio **Properties** window is a universal property browser for COM and COM+ components and supports all Visual Studio products. The **Properties** window works with `ITypeInfo` type information and COM+ metadata to list the design-time properties for the currently selected object in any other window in the integrated development environment (IDE).

 The **Properties** window, which can be opened by pressing **F4** on the keyboard, or selecting **Properties Window** on the **View** menu, is used to view and edit configuration-independent, design-time properties and events of selected objects. Configuration-dependent properties, associated with solutions and projects, are displayed on [Property pages](../../extensibility/internals/property-pages.md). For more information, [Manage configuration options](../../extensibility/internals/managing-configuration-options.md).

 ![Properties window overview](../../extensibility/internals/media/vspropertieswindow.png "vsPropertiesWindow")
 
 Properties window

 This section provides detailed information that relates to the individual areas of the **Properties** window and the interfaces that you must implement and call to populate the window.

## In this section

- [Properties window overview](../../extensibility/internals/properties-window-overview.md) explains the purpose of the **Properties** window relative to the tool window and the document window.

- [Template policy and the Properties window](../../extensibility/internals/template-policy-and-the-properties-window.md) discusses how a project is contained in an enterprise template project, and how that enterprise template project can enforce policy.

- [Properties window fields and interfaces](../../extensibility/internals/properties-window-fields-and-interfaces.md) explains the basis for selection that determines what information is displayed in the **Properties** window.

- [Properties window object list](../../extensibility/internals/properties-window-object-list.md) describes the purpose of the **Properties** window object list, describing how, when a different object from this list triggers a call, the environment is informed that a new object has been selected.

- [Properties window buttons](../../extensibility/internals/properties-window-buttons.md) explains the purpose of the four default buttons displayed on the **Properties** window toolbar.

- [Properties display grid](../../extensibility/internals/properties-display-grid.md) explains where the property names and property values fields are found in the grid.

## Related sections

- [Project types](../../extensibility/internals/project-types.md) discusses projects as the building blocks of the Visual Studio IDE.

- [Compile and build](../../ide/compiling-and-building-in-visual-studio.md) describes how you can use the Visual Studio platform for continuously testing and debugging applications as you build them.

- [IDispatch](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch) describes the `IDispatch` interface, which was first designed to support automation, providing a late-bound mechanism to access and retrieve information about the methods and properties of an object.

- [Manage application settings (.NET)](../../ide/managing-application-settings-dotnet.md) provides an overview of application settings that let you configure your application so that property values are stored in an external configuration file instead of the application's compiled code.

- [Solutions and projects](../../ide/solutions-and-projects-in-visual-studio.md) explains how Visual Studio efficiently manages the items such as references, data connections, folders, and files that are required by your development effort through solutions and projects.

- [Extend other parts of Visual Studio](../../extensibility/extending-other-parts-of-visual-studio.md) explains how to use Visual Studio services to create UI elements that match the rest of Visual Studio.
