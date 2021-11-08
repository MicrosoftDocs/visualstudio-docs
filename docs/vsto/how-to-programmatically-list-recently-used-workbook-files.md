---
title: "How to: Programmatically list recently used workbook files"
description: Learn how you can programmatically list recently used Microsoft Excel workbook files by using Visual Studio.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, listing recently used"
  - "RecentFiles property"
  - "Excel [Office development in Visual Studio], recently used files listing"
  - "recent file list, Excel"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically list recently used workbook files
  The <xref:Microsoft.Office.Interop.Excel._Application.RecentFiles%2A> property returns a collection that contains the names of all the files that appear in the Microsoft Office Excel list of recently used files. The length of the list varies depending on the number of files the user has selected to retain. You can display the results in a range.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To list recently used workbooks in a range object

1. Loop through the list of recent files and display the names in cells relative to a <xref:Microsoft.Office.Interop.Excel.Range> object.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet9":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet9":::

## See also
- [Work with workbooks](../vsto/working-with-workbooks.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
