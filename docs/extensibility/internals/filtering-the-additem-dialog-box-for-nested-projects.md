---
title: "Filtering the AddItem Dialog Box for Nested Projects | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "filtering, nested projects"
  - "nested projects, AddItem dialog box filtering"
ms.assetid: 5b3e352e-7f18-4f66-be16-b0ad55637ce5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Filter the AddItem dialog box for nested projects
When you display an **AddItem** dialog box for a nested project, the parent project can control what items are displayed in the dialog box.

 The <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2> interface lets you filter the nodes that will be in an **AddItem** dialog box. When the child project displays the **AddItem** dialog box, the parent can implement the `IVsFilterAddProjectItemDlg` interface and filter items that would otherwise be displayed in the child's project.

 When projects are grouped by function under specific parent projects, you can implement `IVsFilterAddProjectItemDlg` when the user selects **Add Project Item** on the shortcut menu in a nested project. Implementing `IvsFilterAddProjectItemDlg displays` only project items or files specific to that group. Project items for other groups are filtered out of the dialog box, even if they are stored in the same directory.

 When a user opens the **AddItem** dialog box for the child, the parent project's implementation of the `IVsFilterAddProjectItemDlg` interface is called.

 The `IVsFilterAddProjectItemDlg` interface can also implement filtering by category. For more information, see [Add items to the Add New Item dialog box](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md) and [Register project and item templates](../../extensibility/internals/registering-project-and-item-templates.md).

## See also
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2>
- [Add items to the Add New Item dialog box](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md)
- [Register project and item templates](../../extensibility/internals/registering-project-and-item-templates.md)
- [Nest projects](../../extensibility/internals/nesting-projects.md)