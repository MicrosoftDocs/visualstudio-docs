---
title: Project Context
description: Learn how the Visual Studio IDE uses project context to determine how to perform operations when the user adds or works with projects and project items.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- projects [Visual Studio SDK], opening items
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Context

When the user adds or works with projects and project items, the IDE uses the notion of project context to determine how various operations should be performed.

 Typically, files are the standard project objects that the user explicitly creates by selecting the **New Project** command or makes available by selecting the **Open Project** command on the **File** menu. In these cases, files are created and opened in the context of a project and the project type defines the context for editing the document.

 Some projects provide a very rich context. For example, the project manages a project-scoped, programmatic namespace or project-scoped database connection for data binding. The user can frequently open files or database connections directly by using a particular project object, such as a project item displayed in Solution Explorer.

 At other times, the project context of an item is not explicitly specified. For example, the context of an item is not available when the user opens a file by selecting the **Open Existing File** command on the **File** menu, when the debugger operates on a file, or when the user clicks the **Find In Files** command in the **Find and Replace** dialog box. To handle these situations, the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument> to manage the process of finding the best project to open a document.

## See also
- [Project Priority](../../extensibility/internals/project-priority.md)
- [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)
