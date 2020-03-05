---
title: "Document Data and Document View in Custom Editors | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], custom - document data and document view"
ms.assetid: 71eea623-f566-4feb-84cd-ca1ba71bc493
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Document data and document view in custom editors
A custom editor consists of two parts: a document data object and a document view object. As the names suggest, the document data object represents the text data to be displayed. Similarly, the document view object (or "view") represents one or more windows in which to display the document data object.

## Document data object
 A document data object is a data representation of text in the text buffer. It is a COM object that stores document text and other information. The document data object also handles document persistence and enables multiple views of its data. For more information, see

 <xref:EnvDTE80.Window2.DocumentData%2A> and [Document Windows](../extensibility/internals/document-windows.md).

 Custom editors and designers can opt to use the <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> object or their own custom buffer. <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer> follows the simplified embedding model for a standard editor, supports multiple views, and provides event interfaces that are used to manage multiple views.

## Document view object
 A window that displays code and other text is known as a document view or view. When you create an editor, you can choose either a single view, in which text is displayed in a single window. Or you can choose a multiple view, in which text is displayed in more than one window. Your choice depends on your application. For example, if you need side-by-side editing, you would choose multiple view. Each view is associated with an entry in the integrated development environment's (IDE) running document table (RDT). View windows belong to a project or an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> object.

 If your editor supports multiple views of a document data object, then your document data and document view objects must be separate. Otherwise, they can be grouped together. For more information, see [Support multiple document views](../extensibility/supporting-multiple-document-views.md).

 The IDE notifies views about events (for example, when a solution containing a document is closed) by matching an item identifier (ItemID) for each entry in the running document table. For more information on this, see [Running document table](../extensibility/internals/running-document-table.md).

 There are two options for creating a view for a custom editor. One is the in-place activation model, where the view is hosted in a window using either an ActiveX control or a document data object. The second is the simplified embedding model, where the view is hosted by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane> is implemented to handle window commands. For information about the in-place activation model, see [In-place activation](/visualstudio/misc/in-place-activation?view=vs-2015). For information about the simplified embedding model, see [Simplified embedding](../extensibility/simplified-embedding.md).

## See also

- [Support multiple document views](../extensibility/supporting-multiple-document-views.md)
- [Simplified embedding](../extensibility/simplified-embedding.md)
- [How to: Attach views to document data](../extensibility/how-to-attach-views-to-document-data.md)
- [Document lock holder management](../extensibility/document-lock-holder-management.md)
- [Single and multi-tab views](../extensibility/single-and-multi-tab-views.md)
- [Save a standard document](../extensibility/internals/saving-a-standard-document.md)
- [Persistence and the running document table](../extensibility/internals/persistence-and-the-running-document-table.md)
- [Determine which editor opens a file in a project](../extensibility/internals/determining-which-editor-opens-a-file-in-a-project.md)