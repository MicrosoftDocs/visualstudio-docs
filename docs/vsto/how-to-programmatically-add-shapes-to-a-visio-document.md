---
title: "How to: Programmatically add shapes to a Visio document"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Visio [Office development in Visual Studio], adding Visio shapes"
  - "shapes [Office development in Visual Studio], adding Visio shapes"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically add shapes to a Visio document
  You can add shapes to a Microsoft Office Visio document by retrieving the masters from a stencil and dropping the shapes on the active page.

 For more information, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Documents.Add](/office/vba/api/Visio.Documents.Add) method, [Microsoft.Office.Interop.Visio.Application.ActivePage](/office/vba/api/Visio.Application.ActivePage) property, and [Microsoft.Office.Interop.Visio.Page.Drop](/office/vba/api/Visio.Page.Drop) method.

## Add shapes to a Visio Document

### To add shapes to a Visio document

- With a document active, retrieve the masters from the Documents.Masters collection and drop the shapes on the active document. You can retrieve a master by using the index or master name.

     The following code example creates a blank Visio document, and then opens it with the **Basic Shapes** stencil docked. The code then retrieves several shapes and drops them on the active page.

     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#13](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#13)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#13](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#13)]

## See also
- [Visio solutions](../vsto/visio-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [Work with Visio shapes](../vsto/working-with-visio-shapes.md)
- [How to: Programmatically copy and paste shapes in a Visio document](../vsto/how-to-programmatically-copy-and-paste-shapes-in-a-visio-document.md)
