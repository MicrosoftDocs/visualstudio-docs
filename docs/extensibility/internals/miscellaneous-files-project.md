---
title: Miscellaneous Files Project | Microsoft Docs
description: Learn about the two types of editors that can be used to open files in a Visual Studio project and the role of the project in determining which editor to use.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- files, adding existing files to solutions
- Miscellaneous Files project
- Solution Items folder
- files, opening with Miscellaneous Files project
ms.assetid: 93a278a8-d4f4-400b-8945-4f1b0a2b5bac
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Miscellaneous Files Project
When a user opens project items, the IDE assigns to the Miscellaneous Files project any items that are not members of any projects in a solution.

 Projects play a significant role in determining which editor is used when a user opens a project item. A project can be designed to open certain files by using a project-specific editor or a standard editor.

 A project-specific editor typically requires that the user have special knowledge or use special interfaces from the project. For more information, see [How to: Open Project-Specific Editors](../../extensibility/how-to-open-project-specific-editors.md).

 A standard editor can open any file of a specific extension in any project. The user can customize some standard editors, such as the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] text editor, for projects but still retain their public character. Standard editors are created by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A> method.

 If no project in the solution responds that it can open a project item, the IDE provides a special project called the Miscellaneous Files project that opens any file.

 This special project provides for opening of a file outside the context of a project. During the processing of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenDocumentViaProject%2A> method, the Miscellaneous Files project always responds with a very low priority. Therefore, the Miscellaneous Files project always yields to any higher-priority project that can open files.

 The Miscellaneous Files project does not require the user to explicitly create it with the **New Project** dialog box. Also, the Miscellaneous Files project does not permanently manage a list of project members. It uses an optional feature to record a list of most recently used files for each user.

## See also
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument>
- <xref:Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY>
- [How to: Open Project-Specific Editors](../../extensibility/how-to-open-project-specific-editors.md)
- [How to: Open Standard Editors](../../extensibility/how-to-open-standard-editors.md)
- [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)
- [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)
