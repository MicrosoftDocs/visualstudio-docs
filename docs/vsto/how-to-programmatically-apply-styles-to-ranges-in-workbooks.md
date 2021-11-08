---
title: "How to: Programmatically apply styles to ranges in workbooks"
description:  Learn how you can apply named styles to regions in workbooks. Excel supplies a number of predefined styles.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, styles"
  - "styles, workbook ranges"
  - "workbooks, styles"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically apply styles to ranges in workbooks
  You can apply named styles to regions in workbooks. Excel supplies a number of predefined styles.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 The **Format Cells** dialog box displays all the options you can use to format cells, and each of these options is available from your code. To display this dialog box in Excel, click **Cells** on the **Format** menu.

## To apply a style to a named range in a document-level customization

1. Create a new style and set its attributes.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet53":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet53":::

2. Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control, assign text to it, and then apply the new style. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet54":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet54":::

## To clear a style from a named range in a document-level customization

1. Apply the Normal style to the range. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet55":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet55":::

## To apply a style to a named range in a VSTO Add-in

1. Create a new style and set its attributes.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet28":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet28":::

2. Create a <xref:Microsoft.Office.Interop.Excel.Range>, assign text to it, and then apply the new style.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet29":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet29":::

## To clear a style from a named range in a VSTO Add-in

1. Apply the Normal style to the range.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet56":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet56":::

## See also
- [Work with ranges](../vsto/working-with-ranges.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
