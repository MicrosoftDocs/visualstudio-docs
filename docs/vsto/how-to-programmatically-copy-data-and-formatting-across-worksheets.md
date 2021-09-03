---
title: "Copy data and formatting across worksheets programmatically"
description: Learn how you can copy data from a range on one sheet to all the other sheets in a workbook by using the FillAcrossSheets method.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, copying data"
  - "formatting [Office development in Visual Studio]"
  - "data [Office development in Visual Studio], copying across worksheets"
  - "copying data, Office development in Visual Studio"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically copy data and formatting across worksheets
  You can copy data from a range on one sheet to all the other sheets in a workbook by using the <xref:Microsoft.Office.Interop.Excel.Worksheets.FillAcrossSheets%2A> method. Specify a range, and whether you want to copy data, formatting, or both.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Example
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet44":::
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet44":::

## Compile the code
 This example requires a range named `rangeData` in a worksheet.

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically add new worksheets to workbooks](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md)
- [How to: Programmatically change formatting in worksheet rows containing selected cells](../vsto/how-to-programmatically-change-formatting-in-worksheet-rows-containing-selected-cells.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
