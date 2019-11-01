---
title: "How to: Programmatically close Visio documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], closing Visio documents"
  - "Visio [Office development in Visual Studio], closing Visio documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically close Visio documents
  You can close the active Microsoft Office Visio document by using the `Microsoft.Office.Interop.Visio.Document.Close` method.

 For details about this method, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Document.Close](/office/vba/api/Visio.Document.Close) method.

## Close the active document

### To close the active document

- Call the `Microsoft.Office.Interop.Visio.Document.Close` method to close the active document.

     To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Visio.

     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#7](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#7)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#7](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#7)]

## See also
- [Visio solutions](../vsto/visio-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [How to: Programmatically create new Visio documents](../vsto/how-to-programmatically-create-new-visio-documents.md)
- [How to: Programmatically open Visio documents](../vsto/how-to-programmatically-open-visio-documents.md)
- [How to: Programmatically save Visio documents](../vsto/how-to-programmatically-save-visio-documents.md)
- [How to: Programmatically print Visio documents](../vsto/how-to-programmatically-print-visio-documents.md)
