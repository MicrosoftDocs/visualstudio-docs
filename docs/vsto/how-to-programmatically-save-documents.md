---
title: "Programmatically save documents"
description: Save a Microsoft Word document without changing the document name or by using a new name programmatically from Visual Basic or C# in Visual Studio.
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], saving"
  - "Word [Office development in Visual Studio], saving documents"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically save documents

There are several ways to save Microsoft Office Word documents. You can save a document without changing the name of the document, or you can save a document with a new name.

[!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Save a document without changing the name

### To save the document associated with a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Word.Document.Save%2A> method of the <xref:Microsoft.Office.Tools.Word.Document> class. To use this code example, run it from the `ThisDocument` class in your project.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet7":::
     ---

### To save the active document

1. Call the <xref:Microsoft.Office.Interop.Word._Document.Save%2A> method for the active document. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet8":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet8":::
    ---

   If you are not sure whether the document you want to save is the active document, you can refer to it by its name.

### To save a document specified by name

1. Use the document name as an argument to the <xref:Microsoft.Office.Interop.Word.Documents> collection. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet9":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet9":::
     ---

## Save a document with a new name

Use the `SaveAs` method to save a document with a new name. You can use this method of the <xref:Microsoft.Office.Tools.Word.Document> host item in a document-level Word project, or of a native <xref:Microsoft.Office.Interop.Word.Document> object in any Word project. This method requires that you specify the new file name, but other arguments are optional.

> [!NOTE]
> If you show the **SaveAs** dialog box inside of the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentBeforeSave> event handler of `ThisDocument` and set the *Cancel* parameter to **false**, the application might quit unexpectedly. If you set the *Cancel* parameter to **true**, an error message appears indicating that Autosave has been disabled.

### To save the document associated with a document-level customization with a new name

1. Call the `SaveAs` method of the `ThisDocument` class in your project, using a fully qualified path and file name. If a file by that name already exists in that folder, it is silently overwritten. To use this code example, run it from the `ThisDocument` class.

    > [!NOTE]
    > The `SaveAs` method throws an exception if a target directory does not exist or if there are other problems saving a file. It is a good practice to use a `try...catch` block around the `SaveAs` method or inside a calling method.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet10":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet10":::
     ---

### To save a native document with a new name

1. Call the <xref:Microsoft.Office.Interop.Word._Document.SaveAs%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> that you want to save, using a fully qualified path and file name. If a file by that name already exists in that folder, it is silently overwritten.

     The following code example saves the active document with a new name. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

    > [!NOTE]
    > The <xref:Microsoft.Office.Interop.Word._Document.SaveAs%2A> method throws an exception if a target directory does not exist or if there are other problems saving a file. It is a good practice to use a **try...catch** block around the <xref:Microsoft.Office.Interop.Word._Document.SaveAs%2A> method or inside a calling method.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet10":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet10":::
     ---

## Compile the code

This code example requires the following:

- To save a document by name, a document named *NewDocument.doc* must exist in a directory named *Test* on drive C.

- To save a document with a new name, a directory named *Test* must exist on drive C.

## Related content

- [How to: Programmatically close documents](../vsto/how-to-programmatically-close-documents.md)
- [How to: Programmatically open existing documents](../vsto/how-to-programmatically-open-existing-documents.md)
- [Document host item](../vsto/document-host-item.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
