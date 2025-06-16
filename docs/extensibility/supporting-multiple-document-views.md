---
title: Supporting Multiple Document Views
description: Learn how to provide more than one view of a document by using separate document data and document view objects for your custom editor in the Visual Studio SDK. 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- editors [Visual Studio SDK], custom - multiple document views
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Supporting Multiple Document Views

You can provide more than one view of a document by creating separate document data and document view objects for your editor. Some cases in which an additional document view would be useful are:

- New window support: You want your editor to provide two or more views of the same type, so that a user who already has a window open in the editor can open a new window by selecting the **New Window** command from the **Window** menu.

- Form and code view support: You want your editor to provide views of different types. Visual Basic, for example, provides both a form view and a code view.

  For more information about this, see the CreateEditorInstance procedure in the EditorFactory.cs file in the custom editor project created by the Visual Studio Package Template. For more information about this project, see [Walkthrough: Creating a Custom Editor](../extensibility/walkthrough-creating-a-custom-editor.md).

## Synchronizing Views
 When you implement multiple views, the document data object is responsible for keeping all views synchronized with the data. You can use the event handling interfaces on <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> to synchronize multiple views with the data.

 If you do not use the <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> object to synchronize multiple views, then you must implement your own event system to handle changes made to the document data object. You can use different levels of granularity to keep multiple views up to date. With a setting of maximum granularity, as you type in one view the other views are updated immediately. With minimum granularity, other views are not updated until they are activated.

## Determining Whether Document Data is Already Open
 The running document table (RDT) in the integrated development environment (IDE) helps track whether the data for a document is already open, as shown in the following diagram.

![DocDataView graphic](../extensibility/media/docdataview.gif "Docdataview")
 
Multiple views

 By default, each view (document view object) is contained in its own window frame (<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame>). As already noted, however, document data can be displayed in multiple views. To enable this, Visual Studio checks the RDT to determine whether the document in question is already open in an editor. When the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> to create the editor, a non-NULL value returned in the `punkDocDataExisting` parameter indicates that the document is already open in another editor. For more information about how the RDT functions, see [Running Document Table](../extensibility/internals/running-document-table.md).

 In your <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory> implementation, examine the document data object returned in `punkDocDataExisting` to determine whether the document data is appropriate for your editor. (For example, only HTML data should be displayed by an HTML editor.) If it is appropriate, then your editor factory should provide a second view for the data. If the `punkDocDataExisting` parameter is not `NULL`, it is possible either that the document data object is open in another editor, or, more likely, that the document data is already open in a different view with same the editor. If the document data is open in a different editor that your editor factory does not support, then Visual Studio fails to open your editor factory. For more information, see [How to: Attach Views to Document Data](../extensibility/how-to-attach-views-to-document-data.md).
