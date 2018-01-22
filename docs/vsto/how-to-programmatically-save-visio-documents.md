---
title: "How to: Programmatically Save Visio Documents | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents [Office development in Visual Studio], saving Visio documents"
  - "Visio [Office development in Visual Studio], saving Visio documents"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Save Visio Documents
  There are several ways to save Microsoft Office Visio documents:  
  
-   Save changes in an existing document.  
  
-   Save a new document, or save a document with a new name.  
  
-   Save a document with specified arguments.  
  
 For more information, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Document.Save](https://msdn.microsoft.com/library/office/ff766478.aspx) method, [Microsoft.Office.Interop.Visio.Document.SaveAs](https://msdn.microsoft.com/library/office/ff765824.aspx) method, and [Microsoft.Office.Interop.Visio.Document.SaveAsEx](https://msdn.microsoft.com/library/office/ff768149.aspx) method.  
  
## Saving an Existing Document  
  
#### To save a document  
  
-   Call the Microsoft.Office.Interop.Visio.Document.Save method of the Microsoft.Office.Tools.Visio.Document class of a document that has been previously saved.  
  
     To use this code example, run it from the `ThisAddIn` class in your project.  
  
    > [!NOTE]  
    >  The Microsoft.Office.Interop.Visio.Document.Save method throws an exception if a new Visio document has not yet been saved.  
  
     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#11](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#11)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#11](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#11)]  
  
## Saving a Document with a New Name  
 Use the Microsoft.Office.Interop.Visio.Document.SaveAs method to save a new document, or a document that has a new name. This method requires that you specify the new file name.  
  
#### To save the active Visio document with a new name  
  
-   Call the Microsoft.Office.Interop.Visio.Document.SaveAs method of the Microsoft.Office.Tools.Visio.Document that you want to save, by using a fully qualified path including a file name. If a file by that name already exists in that folder, it is silently overwritten.  
  
     To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#10](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#10)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#10](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#10)]  
  
## Saving a Document with a New Name and Specified Arguments  
 Use the Microsoft.Office.Interop.Visio.Document.SaveAsEx method to save a document with a new name, and specify any applicable arguments to apply to the document.  
  
#### To save document with a new name and specified arguments  
  
-   Call the Microsoft.Office.Interop.Visio.Document.SaveAsEx method of the Microsoft.Office.Tools.Visio.Document that you want to save, by using a fully qualified path including a file name. If a file by that name already exists in that folder, an exception is thrown.  
  
     The following code example saves the active document with a new name, marks the document as read-only, and shows the document in the Most Recently Used list of documents. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#12](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#12)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#12](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#12)]  
  
## Compiling the Code  
 This code example requires the following:  
  
-   To save a document that has a new name, a directory named `Test` must be located in the My Documents folder (for Windows XP and earlier) or the Documents folder (for Windows Vista).  
  
## See Also  
 [Visio Solutions](../vsto/visio-solutions.md)   
 [Visio Object Model Overview](../vsto/visio-object-model-overview.md)   
 [How to: Programmatically Create New Visio Documents](../vsto/how-to-programmatically-create-new-visio-documents.md)   
 [How to: Programmatically Open Visio Documents](../vsto/how-to-programmatically-open-visio-documents.md)   
 [How to: Programmatically Close Visio Documents](../vsto/how-to-programmatically-close-visio-documents.md)   
 [How to: Programmatically Print Visio Documents](../vsto/how-to-programmatically-print-visio-documents.md)  
  
  