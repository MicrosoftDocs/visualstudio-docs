---
title: Adding Project and Project Item Templates
description: Learn about adding project and project item templates to the dialog boxes in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- projects [Visual Studio SDK], adding
- project items [Visual Studio], adding
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add project and project item templates

When you create your own project types, you must provide support for adding new projects and project items by using the standard Visual Studio integrated development environment (IDE) dialog boxes. The following topics discuss different techniques for adding projects and project items.

## In this section
- [Project context](../../extensibility/internals/project-context.md)

 Explains that the project provides most of the context information for what transpires in the environment.

- [Project priority](../../extensibility/internals/project-priority.md)

 Explains that a project item is usually a member of one project to help avoid ambiguity about which project is used to open the item.

- [Miscellaneous Files project](../../extensibility/internals/miscellaneous-files-project.md)

 Provides information about the two types of editors that can be used to open files in a project and the role the project plays in determining which editor to use when a project item is opened.

- [Register project and item templates](../../extensibility/internals/registering-project-and-item-templates.md)

 Explains what occurs when a Visual Studio project is created.

- [Add items to the Add New Item dialog box](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md)

 Explains the process for adding items to the **Add New Item** dialog box.

- [Add directories to the New Project dialog Box](../../extensibility/internals/adding-directories-to-the-new-project-dialog-box.md)

 Provides an example of registering a new directory that contains custom templates made available by a VSPackage.

- [Add directories to the Add New Item dialog box](../../extensibility/internals/adding-directories-to-the-add-new-item-dialog-box.md)

 Provides an example of registering a new set of directories for the **Add New Item** dialog box.

- [IDE-defined commands for extending project systems](../../extensibility/internals/ide-defined-commands-for-extending-project-systems.md)

 Lists different types of command items used for extending project systems.

- [CATIDs for objects that are typically used to extend projects](../../extensibility/internals/catids-for-objects-that-are-typically-used-to-extend-projects.md)

 Lists CATIDs for objects that are used to extend Visual C++, Visual C#, and Visual Basic project systems.

## Related sections
- [How to: Open project-specific editors](../../extensibility/how-to-open-project-specific-editors.md)

 Provides step-by-step instructions for opening an item intrinsically bound to a specific editor for a project.

- [How to: Open standard editors](../../extensibility/how-to-open-standard-editors.md)

 Provides step-by-step instructions for opening a standard editor.

- [Project subtypes](../../extensibility/internals/project-subtypes.md)

 Provides links to project subtype conceptual topics. Project subtypes extend existing Visual C# and Visual Basic projects.

- [Project types](../../extensibility/internals/project-types.md)

 Provides links to additional topics that offer information about how to design new project types.
