---
title: "How to: Programmatically close Visio documents"
description:  Learn how you can close the active Microsoft Office Visio document by using the Microsoft.Office.Interop.Visio.Document.Close method.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], closing Visio documents"
  - "Visio [Office development in Visual Studio], closing Visio documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
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

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs" id="Snippet7":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb" id="Snippet7":::

## See also
- [Visio solutions](../vsto/visio-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [How to: Programmatically create new Visio documents](../vsto/how-to-programmatically-create-new-visio-documents.md)
- [How to: Programmatically open Visio documents](../vsto/how-to-programmatically-open-visio-documents.md)
- [How to: Programmatically save Visio documents](../vsto/how-to-programmatically-save-visio-documents.md)
- [How to: Programmatically print Visio documents](../vsto/how-to-programmatically-print-visio-documents.md)
