---
title: "How to: Programmatically open workbooks"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, opening"
  - "Excel [Office development in Visual Studio], opening workbooks"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically open workbooks
  The <xref:Microsoft.Office.Interop.Excel.Workbooks> collection in Microsoft Office Excel makes it possible to work with all open workbooks and to open workbooks.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To open an existing workbook

1. Use the <xref:Microsoft.Office.Interop.Excel.Workbooks.Open%2A> method of the <xref:Microsoft.Office.Interop.Excel.Workbooks> collection, passing in the path to the workbook.

     [!code-csharp[Trin_VstcoreExcelAutomation#2](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#2)]
     [!code-vb[Trin_VstcoreExcelAutomation#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#2)]

## Compile the code
 This code example requires the following:

- A workbook named `YourWorkbook.xls` must exist in a directory named `Test` on drive C.

## See also
- [Work with workbooks](../vsto/working-with-workbooks.md)
- [How to: Programmatically open text files as workbooks](../vsto/how-to-programmatically-open-text-files-as-workbooks.md)
- [How to: Programmatically create new workbooks](../vsto/how-to-programmatically-create-new-workbooks.md)
- [How to: Programmatically save workbooks](../vsto/how-to-programmatically-save-workbooks.md)
- [How to: Programmatically close workbooks](../vsto/how-to-programmatically-close-workbooks.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
