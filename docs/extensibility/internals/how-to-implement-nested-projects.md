---
title: 'How to: Implement Nested Projects | Microsoft Docs'
description: Learn how to implement nested projects in Visual Studio by raising events from the solution and parent projects to build a project hierarchy.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- nested projects, implementing
- projects [Visual Studio SDK], nesting
ms.assetid: d20b8d6a-f0e0-4115-b3a3-edda893ae678
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# How to: Implement nested projects

When you create a nested project type, there are several additional steps that must be implemented. A parent project takes on some of the same responsibilities that the solution has for its nested (child) projects. The parent project is a container of projects similar to a solution. In particular, there are several events that must be raised by the solution and by the parent projects to build the hierarchy of nested projects. These events are described in the following process for creating nested projects.

## Create nested projects

1. The integrated development environment (IDE) loads the parent project's project file and startup information by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory> interface. The parent project is created and added to the solution.

    > [!NOTE]
    > At this point, it is too early in the process for the parent project to create the nested project because the parent project must be created before the child projects can be created. Following this sequence, the parent project can apply settings to the child projects and the child projects can acquire information from the parent projects if needed. This sequence is if it is needed on by clients such as source code control (SCC) and **Solution Explorer**.

     The parent project must wait for the <xref:Microsoft.VisualStudio.Shell.Interop.IVsParentProject.OpenChildren%2A> method to be called by the IDE before it can create its nested (child) project or projects.

2. The IDE calls `QueryInterface` on the parent project for <xref:Microsoft.VisualStudio.Shell.Interop.IVsParentProject>. If this call succeeds, the IDE calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsParentProject.OpenChildren%2A> method of the parent to open all of the nested projects for the parent project.

3. The parent project calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFireSolutionEvents.FireOnBeforeOpeningChildren%2A> method to notify listeners that nested projects are about to be created. SCC, for example, is listening to those events to know if the steps in the solution and project creation process are occurring in order. If the steps occur out of order, the solution might not be registered with source code control correctly.

4. The parent project calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.AddVirtualProject%2A> method or the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.AddVirtualProjectEx%2A> method on each of its child projects.

     You pass <xref:Microsoft.VisualStudio.Shell.Interop.__VSADDVPFLAGS> to the `AddVirtualProject` method to indicate that the virtual (nested) project should be added to the project window, excluded from the build, added to source code control, and so on. `VSADDVPFLAGS` lets you control the visibility of the nested project and indicate what functionality is associated with it.

     If you reload a previously existing child project that has a project GUID stored in the parent project's project file, the parent project calls `AddVirtualProjectEx`. The only difference between `AddVirtualProject` and `AddVirtualProjectEX` is that `AddVirtualProjectEX` has a parameter to enable the parent project to specify a per instance `guidProjectID` for the child project to enable <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.GetProjectOfGuid%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.GetProjectOfProjref%2A> to function correctly.

     If there is no GUID available, such as when you add a new nested project, the solution creates one for the project at the time it is added to the parent. It is the responsibility of the parent project to persist that project GUID in its project file. If you delete a nested project, the GUID for that project can also be deleted.

5. The IDE calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsParentProject.OpenChildren> method on each child project of the parent project.

     The parent project must implement `IVsParentProject` if you want to nest projects. But the parent project never calls `QueryInterface` for `IVsParentProject` even if it has parent projects underneath it. The solution handles the call to `IVsParentProject` and, if it is implemented, calls `OpenChildren` to create the nested projects. `AddVirtualProjectEX` is always called from `OpenChildren`. It should never be called by the parent project to keep the hierarchy creation events in order.

6. The IDE calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterOpenProject%2A> method on the child project.

7. The parent project calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFireSolutionEvents.FireOnAfterOpeningChildren%2A> method to notify listeners that the child projects for the parent have been created.

8. The IDE calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFireSolutionEvents.FireOnAfterOpenProject%2A> method on the parent project after all child projects have been opened.

     If it does not already exist, the parent project creates a GUID for each nested project by calling `CoCreateGuid`.

    > [!NOTE]
    > `CoCreateGuid` is a COM API called when a GUID is to be created. For more information, see `CoCreateGuid` and GUIDs in the MSDN Library.

     The parent project stores this GUID in its project file to be retrieved the next time that it is opened in the IDE. See step 4 for more information relating to the calling of `AddVirtualProjectEX` to retrieve the `guidProjectID` for the child project.

9. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> method is then called for the parent ItemID that by convention you delegate in to the nested project. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> retrieves the properties of the node that nests a project that you want to delegate in when it is called on the parent.

     Because parent and child projects are instantiated programmatically, you can set properties for nested projects at this point.

    > [!NOTE]
    > Not only do you receive the context information from the nested project, but you can also ask if the parent project has any context for that item by checking [__VSHPROPID.VSHPROPID_UserContext](<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_UserContext>). In that way, you can add extra dynamic help attributes and menu options specific to individual nested projects.

10. The hierarchy is built for display in **Solution Explorer** with a call to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetNestedHierarchy%2A> method.

     You pass the hierarchy to the environment through `GetNestedHierarchy` to build the hierarchy for display in Solution Explorer. In this manner, the solution knows that the project exists and can be managed for building by the build manager, or can allow files in the project to be put under source code control.

11. When all the nested projects for Project1 have been created, control is passed back to the solution and the process is repeated for Project2.

     This same process for creating nested projects occurs for a child project that has a child. In this case, if BuildProject1, which is a child of Project1, had child projects, they would be created after BuildProject1 and before Project2. The process is recursive and the hierarchy is built from the top down.

     When a nested project is closed because the user closed the solution or the specific project itself, the other method on `IVsParentProject`, <xref:Microsoft.VisualStudio.Shell.Interop.IVsParentProject.CloseChildren%2A>, is called. The parent project wraps calls to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution.RemoveVirtualProject%2A> method with the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnBeforeClosingChildren%2A> and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterClosingChildren%2A> methods to notify listeners to solution events that the nested projects are being closed.

The following topics deal with several other concepts to consider when you implement nested projects:

- [Considerations for unloading and reloading nested projects](../../extensibility/internals/considerations-for-unloading-and-reloading-nested-projects.md)
- [Wizard support for nested projects](../../extensibility/internals/wizard-support-for-nested-projects.md)
- [Implement command handling for nested projects](../../extensibility/internals/implementing-command-handling-for-nested-projects.md)
- [Filter the AddItem dialog box for nested projects](../../extensibility/internals/filtering-the-additem-dialog-box-for-nested-projects.md)

## See also

- [Add items to the Add New Item dialog box](../../extensibility/internals/adding-items-to-the-add-new-item-dialog-boxes.md)
- [Register project and item templates](../../extensibility/internals/registering-project-and-item-templates.md)
- [Checklist: Create new project types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Context parameters](../../extensibility/internals/context-parameters.md)
- [Wizard (.vsz) file](../../extensibility/internals/wizard-dot-vsz-file.md)
