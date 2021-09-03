---
title: Nesting Projects | Microsoft Docs
description: Learn about nesting projects, which allows application developers who use your VSPackage to group similar types of projects together in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- project nesting
- nested projects
- projects [Visual Studio SDK], child projects
- projects [Visual Studio SDK], nesting
ms.assetid: 12cce037-9840-4761-845e-5abd5fb317b0
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Nesting Projects
Enterprise application developers who use your VS Package can conveniently group similar types of projects together in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] by using *project nesting*. For example, the Enterprise Template project uses nested projects to group projects into categories. Business facade projects, Web UI projects, and so on are grouped together in one category.

 In this scenario, there is no limit to the number of projects the developer can nest under each parent project, although the developer can programmatically provide limits. This type of grouping can also be made recursive, in which case the projects of the same type as a child project can be nested under the child to become a subproject of the child, which is a subproject of the parent.

 Project nesting is not an intrinsic part of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. You have to write the code to enable nesting and subproject nesting within child projects. The parent project is a special VSPackage, or project type, created and registered with its own GUID that includes the code that is required to implement project nesting.

 You can find an example on how to nest projects in the [How to: Implement nested projects](../../extensibility/internals/how-to-implement-nested-projects.md).

## Nested projects example
 ![Nested Projects Solution](../../extensibility/internals/media/vsnestedprojects.gif "vsNestedProjects")
Nested projects example

## See also
- [Considerations for Unloading and Reloading Nested Projects](../../extensibility/internals/considerations-for-unloading-and-reloading-nested-projects.md)
- [Wizard Support for Nested Projects](../../extensibility/internals/wizard-support-for-nested-projects.md)
- [Registering Project and Item Templates](../../extensibility/internals/registering-project-and-item-templates.md)
- [Implementing Command Handling for Nested Projects](../../extensibility/internals/implementing-command-handling-for-nested-projects.md)
- [Filtering the AddItem Dialog Box for Nested Projects](../../extensibility/internals/filtering-the-additem-dialog-box-for-nested-projects.md)
- [Checklist: Creating New Project Types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Context Parameters](../../extensibility/internals/context-parameters.md)
- [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md)
