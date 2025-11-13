---
title: 'Attach Views to Document Data'
description: You might be able to attach a new document view to an existing document data object. Use this procedure to determine if you can attach the view.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], custom - attach views to document data
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Attach views to document data

If you have a new document view, you may be able to attach it to an existing document data object.

## To determine if you can attach a view to an existing document data object

1. Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A>.

2. In your implementation of `IVsEditorFactory::CreateEditorInstance`, call `QueryInterface` on the existing document data object when the IDE calls your `CreateEditorInstance` implementation.

    Calling `QueryInterface` enables you to examine the existing document data object, which is specified in the `punkDocDataExisting` parameter.

    The exact interfaces you must query, however, depends upon the editor that is opening the document, as outlined in step 4.

3. If you do not find the appropriate interfaces on the existing document data object, then return an error code to your editor indicating that the document data object is incompatible with your editor.

    In the IDE's implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenStandardEditor%2A>, a message box notifies you that the document is open in another editor and asks if you want to close it.

4. If you close this document, then Visual Studio calls your editor factory for a second time. On this call, the `DocDataExisting` parameter is equal to NULL. Your editor factory implementation can then open the document data object in your own editor.

   > [!NOTE]
   > To determine whether you can work with an existing document data object, you can also use private knowledge of the interface implementation by casting a pointer to the actual Visual C++ class of your private implementation. For example, all standard editors implement `IVsPersistFileFormat`, which inherits from <xref:Microsoft.VisualStudio.OLE.Interop.IPersist>. Thus, you can call `QueryInterface` for <xref:Microsoft.VisualStudio.OLE.Interop.IPersist.GetClassID%2A>, and if the class ID on the existing document data object matches your implementation's class ID, then you can work with the document data object.

## Robust programming
 When Visual Studio calls your implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance%2A> method, it passes back a pointer to the existing document data object in the `punkDocDataExisting` parameter, if one exists. Examine the document data object returned in `punkDocDataExisting` to determine if the document data object is appropriate for your editor as outlined in the note in step 4 of the procedure in this topic. If it is appropriate, then your editor factory should provide a second view for the data as outlined in [Support multiple document views](../extensibility/supporting-multiple-document-views.md). If not, then it should display an appropriate error message.

## Related content
- [Support multiple document views](../extensibility/supporting-multiple-document-views.md)
- [Document data and document view in custom editors](../extensibility/document-data-and-document-view-in-custom-editors.md)
