---
title: Delayed Document Loading
description: Learn about delayed document loading in Visual Studio, and how to code extensions so that they do not query elements in a document before it is loaded.
ms.date: 11/04/2016
ms.topic: conceptual
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Delayed document loading

When a user reopens a Visual Studio solution, most of the associated documents are not loaded immediately. The document window frame is created in a pending-initialization state, and a placeholder document (called a stub frame) is placed in the Running Document table (RDT).

Your extension may cause project documents to be loaded unnecessarily by querying elements in the documents before they are loaded, which can increase the overall memory footprint for Visual Studio.

## Document loading

The stub frame and document are fully initialized when the user accesses the document, for example by selecting the tab of the window frame. The document can also be initialized by an extension that requests the document's data, either by accessing the RDT directly to acquire the document data, or accessing the RDT indirectly by making one of the following calls:

- The window frame <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show%2A> method.

- The window frame <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> method on any of the following properties:

  - [__VSFPROPID.VSFPROPID_DocView](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_DocView>)

  - [__VSFPROPID.VSFPROPID_ViewHelper](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_ViewHelper>)

  - [__VSFPROPID.VSFPROPID_DocData](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_DocData>)

  - [__VSFPROPID.VSFPROPID_AltDocData](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_AltDocData>)

  - [__VSFPROPID.VSFPROPID_RDTDocData](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_RDTDocData>)

  - [__VSFPROPID.VSFPROPID_SPProjContext](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_SPProjContext>)

- If your extension uses managed code, you should not call <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.GetDocumentInfo%2A> unless you are certain that the document is not in the pending-initialization state, or you want the document to be fully initialized. The reason is because the method always returns the doc data object, creating it if necessary. Instead, you should call one of the methods on the `IVsRunningDocumentTable4` interface.

- If your extension uses C++, you can pass `null` for the parameters you don't want.

- You can avoid unnecessary document loading by calling one of the following methods before you ask for the relevant properties before you ask for other properties:

  - <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> using [__VSFPROPID6.VSFPROPID_PendingInitialization](<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID6.VSFPROPID_PendingInitialization>).

  - <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable4.GetDocumentFlags%2A>. This method returns a <xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS4> object that includes a value for [_VSRDTFLAGS4.RDT_PendingInitialization](<xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS4.RDT_PendingInitialization>) if the document has not yet been initialized.

You can find out when a document has been loaded by subscribing to the RDT event that is raised when a document is fully initialized. There are two possibilities:

- If the event sink implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents2>, you can subscribe to <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents2.OnAfterAttributeChangeEx%2A>,

- Otherwise, you can subscribe to <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents.OnAfterAttributeChange%2A>.

The following example is a hypothetical document access scenario: A Visual Studio extension wants to display some information about open documents, for instance the edit lock count and something about the document data. It enumerates the documents in the RDT using <xref:Microsoft.VisualStudio.Shell.Interop.IEnumRunningDocuments>, then calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.GetDocumentInfo%2A> for each document in order to retrieve the edit lock count and document data. If the document is in the pending-initialization state, requesting the document data causes it to be unnecessarily initialized.

A more efficient way of accessing a document is to use <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable4.GetDocumentEditLockCount%2A> to get the edit lock count, and then use <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable4.GetDocumentFlags%2A> to determine whether the document has been initialized. If the flags do not include [_VSRDTFLAGS4.RDT_PendingInitialization](<xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS4.RDT_PendingInitialization>), the document has already been initialized, and requesting the document data with <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable4.GetDocumentData%2A> does not cause any unnecessary initialization. If the flags do include [_VSRDTFLAGS4.RDT_PendingInitialization](<xref:Microsoft.VisualStudio.Shell.Interop._VSRDTFLAGS4.RDT_PendingInitialization>), the extension should avoid requesting the document data until the document is initialized. This initialization can be detected in the `OnAfterAttributeChange(Ex)` event handler.

## Test extensions to see if they force initialization

There is no visible cue to indicate whether a document has been initialized, so it can be difficult to find out if your extension is forcing initialization. You can set a registry key that makes verification easier, because it causes the title of every document that is not fully initialized to have the text *[Stub]* in the title.

In **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\14.0\BackgroundSolutionLoad**, set **StubTabTitleFormatString** to *{0} [Stub]*.
