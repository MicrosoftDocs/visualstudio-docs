---
title: "How to: Programmatically check spelling in worksheets"
description: Learn how you can programmatically check the spelling of words in a Microsoft Excel worksheet.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "spellchecking"
  - "spelling checker, worksheets"
  - "worksheets, checking spelling"
  - "spelling, checking in worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically check spelling in worksheets
  You can programmatically check the spelling of words in a worksheet. The **Spelling** dialog box automatically appears if there are any incorrectly spelled words in the worksheet.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To check spelling in a worksheet in a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.CheckSpelling%2A> method of the worksheet.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet45":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet45":::

## To check spelling in a worksheet in a VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.CheckSpelling%2A> method of the active worksheet.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet22":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet22":::

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically run Excel calculations](../vsto/how-to-programmatically-run-excel-calculations-programmatically.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
