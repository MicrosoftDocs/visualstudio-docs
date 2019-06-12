---
title: "Copy and paste shapes in Visio document programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "shapes [Office development in Visual Studio], copying and pasting Visio shapes"
  - "Visio [Office development in Visual Studio], copying and pasting Visio shapes"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically copy and paste shapes in a Visio document
  You can programmatically copy shapes on one page of a document and paste them into a new page in the same document. You can choose to paste them into the default location (the center of the active window) or into the same coordinate locations as they had on the original page.

## Copy and paste shapes
 For details about the object model, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Shape.DrawRectangle](/office/vba/api/Visio.Shape.DrawRectangle), [Microsoft.Office.Interop.Visio.Shape.DrawOval](/office/vba/api/Visio.Shape.DrawOval), [Microsoft.Office.Interop.Visio.Shape.Copy](/office/vba/api/Visio.Shape.Copy), and [Microsoft.Office.Interop.Visio.Shape.Paste](/office/vba/api/Visio.Shape.Paste) methods and the [Microsoft.Office.Interop.Visio.VisCutCopyPasteCodes.visCopyPasteNormal](/office/vba/api/Visio.viscutcopypastecodes) flag.

### To copy shapes to the center of another page

- The following example demonstrates how to copy the shapes from the first page and paste them into the center of the second page.

     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#14](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#14)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#14](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#14)]

## Copy and paste shapes with the same positions
 For details about the object model, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Shape.DrawRectangle](/office/vba/api/Visio.Shape.DrawRectangle), [Microsoft.Office.Interop.Visio.Shape.DrawOval](/office/vba/api/Visio.Shape.DrawOval), [Microsoft.Office.Interop.Visio.Shape.Copy](/office/vba/api/Visio.Shape.Copy), and [Microsoft.Office.Interop.Visio.Shape.Paste](/office/vba/api/Visio.Shape.Paste) methods and the [Microsoft.Office.Interop.Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate](/office/vba/api/Visio.viscutcopypastecodes) flag.

 If you need to control the format of the pasted information and (optionally) establish a link to a source file (for example, a Microsoft Office Word document), use the PasteSpecial method.

### To copy shapes and shape locations to another page

- The following example demonstrates how to copy the shapes from the first page and paste them into the second page with their original coordinate locations.

     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#15](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#15)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#15](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#15)]

## See also
- [Visio solutions](../vsto/visio-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [Work with Visio shapes](../vsto/working-with-visio-shapes.md)
- [How to: Programmatically add shapes to a Visio document](../vsto/how-to-programmatically-add-shapes-to-a-visio-document.md)
