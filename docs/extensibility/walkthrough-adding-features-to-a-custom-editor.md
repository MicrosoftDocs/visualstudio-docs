---
title: 'Walkthrough: Adding Features to a Custom Editor'
description: Learn how to add more features to a custom editor after you create the editor by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], custom - add features
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Add features to a custom editor

After you create a custom editor, you can add more features to it.

## To create an editor for a VSPackage

1. Create a custom editor by using the Visual Studio Package project template.

     For more information, see [Walkthrough: Create a custom editor](../extensibility/walkthrough-creating-a-custom-editor.md).

2. Decide whether you want your editor to support a single view or multiple views.

     An editor that supports the **New Window** command, or has form view and code view, requires separate document data objects and document view objects. In an editor that supports only a single view, the document data object, and the document view object can be implemented on the same object.

     For an example of multiple views, see [Support multiple document views](../extensibility/supporting-multiple-document-views.md).

3. Implement an editor factory by setting up the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> interface.

     For more information, see [Editor factories](/previous-versions/visualstudio/visual-studio-2015/extensibility/editor-factories?preserve-view=true&view=vs-2015).

4. Decide whether you want your editor to use in-place activation or simplified embedding to manage the document view object window.

     A simplified embedding editor window hosts a standard document view, while an in-place activation editor window hosts an ActiveX control or other active object as its document view. For more information, see [Simplified Embedding](../extensibility/simplified-embedding.md) and [In-place activation](/previous-versions/visualstudio/visual-studio-2015/misc/in-place-activation?preserve-view=true&view=vs-2015).

5. Implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface to handle commands.

6. Provide document persistence and response to external file changes:

    1. To persist the file, implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2> and <xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat> on your editor's document data object.

    2. To respond to external file changes, implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsFileChangeEx> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsDocDataFileChangeControl> on your editor's document data object.

        > [!NOTE]
        > Call `QueryService` on <xref:Microsoft.VisualStudio.Shell.Interop.SVsFileChangeEx> to get a pointer to `IVsFileChangeEx`.

7. Coordinate document edit events with source code control. Follow these steps:

    1. Get a pointer to `IVsQueryEditQuerySave2` by calling `QueryService` on <xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave>.

    2. When the first edit event occurs, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> method.

         This method prompts the user to check out the file if it's not already checked out. Be sure to handle a "file not checked out" condition to avert errors.

    3. Similarly, before saving the file, call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QuerySaveFile%2A> method.

         This method prompts the user to save the file if it hasn't been saved or if it changed since the last save.

8. Enable the **Properties** window to display properties for text selected in the editor. Follow these steps:

    1. Call <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection.OnSelectChange%2A> each time text selection changes, passing in your implementation of <xref:Microsoft.VisualStudio.Shell.Interop.ISelectionContainer>.

    2. Call `QueryService` on <xref:Microsoft.VisualStudio.Shell.Interop.STrackSelection> service to obtain a pointer to <xref:Microsoft.VisualStudio.Shell.Interop.ITrackSelection>.

9. Enable users to drag and drop items between the editor and the **Toolbox**, or between external editors (like Microsoft Word) and the **Toolbox**. Follow these steps:

    1. Implement `IDropTarget` on your editor to alert the IDE that your editor is a drop target.

    2. Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolboxUser> interface on the view so your editor can enable and disable items in the **Toolbox**.

    3. Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.ResetDefaults%2A> and call `QueryService` on <xref:Microsoft.VisualStudio.Shell.Interop.SVsToolbox> service to obtain a pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox3> interfaces.

         These steps enable your VSPackage to add new items to the **Toolbox**.

10. Decide whether you want any other optional features for your editor.

    - If you want your editor to support find and replace commands, implement <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget>.

    - If you want to use a document outline tool window in your editor, implement `IVsDocOutlineProvider`.

    - If you want to use a status bar in your editor, implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser> and call `QueryService` for <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar> to get a pointer to `IVsStatusBar`.

         For example, an editor can display line / column information, selection mode (stream / box), and insertion mode (insert / overstrike).

    - If you want your editor to support the `Undo` command, the recommended method is to use the OLE undo manager model. As an alternative, you can have the editor handle the `Undo` command directly.

11. Create registry Information, including the GUIDs for the VSPackage, the menus, the editor, and other features.

     The following is a generic example of code that you would put in your *.rgs* file script to demonstrate how to properly register an editor.

    ```csharp
    NoRemove Editors
    {
          ForceRemove {...guidEditor...} = s 'RTF Editor'
          {
             val Package = s '{...guidVsPackage...}'
             ForceRemove Extensions
             {
                val rtf = d 50
             }
          }
    }
    NoRemove Menus
    {
          val {...guidVsPackage...} = s ',203,11'
    }
    ```

12. Implement context-sensitive Help support.

     This step allows you to provide F1 Help and Dynamic Help window support for items in your editor. For more information, see [How to: Provide context for editors](/previous-versions/visualstudio/visual-studio-2015/extensibility/how-to-provide-context-for-editors?preserve-view=true&view=vs-2015).

13. Expose an Automation Object Model from your editor by implementing the `IDispatch` interface.

     For more information, see [Automation model overview](../extensibility/internals/automation-model-overview.md).

## Robust programming

- The editor instance is created when the IDE calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method. If the editor supports multiple views, `CreateEditorInstance` creates both the document data and the document view objects. If the document data object is already open, a non-null `punkDocDataExisting` value is passed to `IVsEditorFactory::CreateEditorInstance`. Your editor factory implementation must determine whether an existing document data object is compatible by querying for appropriate interfaces on it. For more information, see [Supporting Multiple Document Views](../extensibility/supporting-multiple-document-views.md).

- If you use the simplified embedding approach, implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane> interface.

- If you decide to use in-place activation, implement the following interfaces:

   <xref:Microsoft.VisualStudio.OLE.Interop.IOleObject>

   <xref:Microsoft.VisualStudio.OLE.Interop.IOleInPlaceActiveObject>

   <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponent>

  > [!NOTE]
  > The `IOleInPlaceComponent` interface is used to avoid OLE 2 menu merging.

   Your `IOleCommandTarget` implementation handles commands such as **Cut**, **Copy**, and **Paste**. When implementing `IOleCommandTarget`, decide whether your editor requires its own *.vsct* file to define its own command menu structure or if it can implement standard commands defined by Visual Studio. Typically, editors use and extend the IDE's menus and define their own toolbars. However, it's often necessary for an editor to define its own specific commands in addition to using the IDE's standard command set. Your editor must declare the standard commands it uses and then define any new commands, context menus, top-level menus, and toolbars in a *.vsct* file. If you create an in-place activation editor, implement <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponent> and define the menus and toolbars for the editor in a *.vsct* file instead of using OLE 2 menu merging.

- To prevent menu command crowding in the UI, you should use the existing commands in the IDE before inventing new commands. Shared commands are defined in *SharedCmdDef.vsct* and *ShellCmdDef.vsct*. These files are installed by default in the VisualStudioIntegration\Common\Inc subdirectory of your Visual Studio SDK installation.

- `ISelectionContainer` can express both single and multiple selections. Each selected object is implemented as an `IDispatch` object.

- The IDE implements `IOleUndoManager` as a service accessible from a <xref:Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2.CreateInstance%2A> or as an object that can be instantiated through <xref:Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2.CreateInstance%2A>. Your editor implements the `IOleUndoUnit` interface for each `Undo` action.

- There are two places a custom editor can expose automation objects:

  - `Document.Object`

  - `Window.Object`

## Related content

- [Automation model overview](../extensibility/internals/automation-model-overview.md)