---
title: "How to: Programmatically print Visio documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Visio [Office development in Visual Studio], printing Visio documents"
  - "documents [Office development in Visual Studio], printing Visio documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically print Visio documents
  You can print a complete Microsoft Office Visio document or only a specific page.

 For details about the print methods, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Document.Print](/office/vba/api/Visio.Document.Print) method and [Microsoft.Office.Interop.Visio.Page.Print](/office/vba/api/Visio.Page.Print) method.

## Print a Visio document

### To print a complete document

- Call the `Microsoft.Office.Interop.Visio.Document.Print` method of the `Microsoft.Office.Interop.Visio.Document` object that you want to print.

     The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.

     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#8](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#8)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#8](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#8)]

## Print a page of a Visio document

### To print a page of a document

- Call the `Microsoft.Office.Interop.Visio.Pages.Print` method of the `Microsoft.Office.Interop.Visio.Pages` object that you want to print.

     The following code example prints the first page of the active document. To use this example, run the code from the `ThisAddIn` class in your project.

     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#9](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#9)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#9](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#9)]

## See also
- [Visio solutions](../vsto/visio-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [How to: Programmatically create new Visio documents](../vsto/how-to-programmatically-create-new-visio-documents.md)
- [How to: Programmatically open Visio documents](../vsto/how-to-programmatically-open-visio-documents.md)
- [How to: Programmatically close Visio documents](../vsto/how-to-programmatically-close-visio-documents.md)
- [How to: Programmatically save Visio documents](../vsto/how-to-programmatically-save-visio-documents.md)
