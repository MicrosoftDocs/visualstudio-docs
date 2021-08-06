---
title: "How to: Programmatically open Visio documents"
description: Learn how you can use Visual Studio to programmatically open a Visio document with the Open or OpenEx methods.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], opening Visio documents"
  - "Visio [Office development in Visual Studio], opening Visio documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically open Visio documents
  There are two methods for opening existing Microsoft Office Visio documents: Open and OpenEx. The OpenEx method is identical to the Open method, except that it provides arguments in which the caller can specify how the document opens.

 For details about the object model, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Documents.Open](/office/vba/api/Visio.Documents.Open) method and [Microsoft.Office.Interop.Visio.Documents.OpenEx](/office/vba/api/Visio.Documents.OpenEx) method.

## Open a Visio document

### To open a Visio document

- Call the `Microsoft.Office.Interop.Visio.Documents.Open` method and supply the fully qualified path of the Visio document.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs" id="Snippet5":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb" id="Snippet5":::

## Open a Visio document with specified arguments

### To open a Visio document as read-only and docked

- Call the `Microsoft.Office.Interop.Visio.Documents.OpenEx` method, supply the fully qualified path of the Visio document, and include the arguments you want to use—in this case, Docked and Read-only.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs" id="Snippet6":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb" id="Snippet6":::

## Compile the code
 This code example requires the following:

- A Visio document named `myDrawing.vsd` must be located in a directory named `Test` in the *My Documents* folder (for Windows XP and earlier) or the *Documents* folder (for Windows Vista).

## See also
- [Visio solutions](../vsto/visio-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [How to: Programmatically create new Visio documents](../vsto/how-to-programmatically-create-new-visio-documents.md)
- [How to: Programmatically close Visio documents](../vsto/how-to-programmatically-close-visio-documents.md)
- [How to: Programmatically save Visio documents](../vsto/how-to-programmatically-save-visio-documents.md)
- [How to: Programmatically print Visio documents](../vsto/how-to-programmatically-print-visio-documents.md)
