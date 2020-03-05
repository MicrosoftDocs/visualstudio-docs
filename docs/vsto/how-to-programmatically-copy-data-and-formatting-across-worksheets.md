---
title: "Copy data and formatting across worksheets programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
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
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically copy data and formatting across worksheets
  You can copy data from a range on one sheet to all the other sheets in a workbook by using the <xref:Microsoft.Office.Interop.Excel.Worksheets.FillAcrossSheets%2A> method. Specify a range, and whether you want to copy data, formatting, or both.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Example
 [!code-csharp[Trin_VstcoreExcelAutomation#44](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#44)]
 [!code-vb[Trin_VstcoreExcelAutomation#44](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#44)]

## Compile the code
 This example requires a range named `rangeData` in a worksheet.

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically add new worksheets to workbooks](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md)
- [How to: Programmatically change formatting in worksheet rows containing selected cells](../vsto/how-to-programmatically-change-formatting-in-worksheet-rows-containing-selected-cells.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
