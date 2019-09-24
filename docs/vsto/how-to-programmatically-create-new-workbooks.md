---
title: "How to: Programmatically create new workbooks"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Excel [Office development in Visual Studio], creating workbooks"
  - "workbooks, creating"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically create new workbooks
  When you create a workbook programmatically, it is a native <xref:Microsoft.Office.Interop.Excel.Workbook> object, not a <xref:Microsoft.Office.Tools.Excel.Workbook> host item.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 You can generate a <xref:Microsoft.Office.Tools.Excel.Workbook> host item for a <xref:Microsoft.Office.Interop.Excel.Workbook> object in VSTO Add-in project. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## To create a new workbook

1. Use the <xref:Microsoft.Office.Interop.Excel.Workbooks.Add%2A> method of the <xref:Microsoft.Office.Interop.Excel.Workbooks> collection.

     [!code-csharp[Trin_VstcoreExcelAutomation#1](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#1)]
     [!code-vb[Trin_VstcoreExcelAutomation#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#1)]

    > [!NOTE]
    > You can create a workbook based on a template other than the default template: pass the template you want to use as a parameter to the <xref:Microsoft.Office.Interop.Excel.Workbooks.Add%2A> method.

## See also
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Work with workbooks](../vsto/working-with-workbooks.md)
- [How to: Programmatically open workbooks](../vsto/how-to-programmatically-open-workbooks.md)
- [How to: Programmatically save workbooks](../vsto/how-to-programmatically-save-workbooks.md)
- [How to: Programmatically close workbooks](../vsto/how-to-programmatically-close-workbooks.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
