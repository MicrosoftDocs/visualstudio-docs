---
title: "Programmatically add shapes to a Visio document"
description: Add shapes to a Microsoft Office Visio document by retrieving the original pattern from a stencil and dropping the shapes on the active page.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Visio [Office development in Visual Studio], adding Visio shapes"
  - "shapes [Office development in Visual Studio], adding Visio shapes"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically add shapes to a Visio document

  You can add shapes to a Microsoft Office Visio document by retrieving the masters from a stencil and dropping the shapes on the active page.

 For more information, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Documents.Add](/office/vba/api/Visio.Documents.Add) method, [Microsoft.Office.Interop.Visio.Application.ActivePage](/office/vba/api/Visio.Application.ActivePage) property, and [Microsoft.Office.Interop.Visio.Page.Drop](/office/vba/api/Visio.Page.Drop) method.

## Add shapes to a Visio Document

### To add shapes to a Visio document

- With a document active, retrieve the masters from the Documents.Masters collection and drop the shapes on the active document. You can retrieve a master by using the index or master name.

     The following code example creates a blank Visio document, and then opens it with the **Basic Shapes** stencil docked. The code then retrieves several shapes and drops them on the active page.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb" id="Snippet13":::
     ---

## Related content
- [Visio solutions](../vsto/visio-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [Work with Visio shapes](../vsto/working-with-visio-shapes.md)
- [How to: Programmatically copy and paste shapes in a Visio document](/previous-versions/visualstudio/visual-studio-2017/vsto/how-to-programmatically-copy-and-paste-shapes-in-a-visio-document)
