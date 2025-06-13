---
title: Project Priority
description: Learn about the priority scheme that the Visual Studio IDE uses determine the best project for opening an item if the item is a member of more than one project.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- projects [Visual Studio SDK], opening items
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Priority

A project item usually is a member of only one project in the solution. Therefore, the IDE can easily determine which project is used to open the item. However, if an item is a member of more than one project, the IDE uses a priority scheme to determine the best project for opening the item.

 The following list shows the project priority scheme:

- The IDE calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject2.IsDocumentInProject%2A> method for each project in the solution to determine whether the document is a member of that project.

- If the document is a member of the project, the project responds with a priority that the project assigns according to its handling of that document. For example, a language project responds with a high priority for its language source files but responds with a lower priority for an unrecognized file type that is not used as part of its build process.

- Projects that provide custom, project-specific editors or designers for a document also receive a high priority.

- The <xref:Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY> enumeration provides the document priority values.

- The project that specifies the highest priority is given the context to open the document. If two projects return equal priority values, the active project is preferred. If no project in the solution responds that it can open the document, the IDE puts the document in the Miscellaneous Files project. For more information, see [Miscellaneous Files Project](../../extensibility/internals/miscellaneous-files-project.md).

## See also
- [Miscellaneous Files Project](../../extensibility/internals/miscellaneous-files-project.md)
- [How to: Open Editors for Open Documents](../../extensibility/how-to-open-editors-for-open-documents.md)
- [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)
