---
title: "Programmatically save workbooks"
description: Save Microsoft Excel workbooks without changing the path and save a copy without modifying the open workbook in memory programmatically in Visual Studio.
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, saving in XML format"
  - "workbooks, saving"
  - "workbooks, saving backup copies"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically save workbooks

  There are several ways to save a workbook. You can save a workbook without changing the path. If the workbook has not been saved before, you should save the workbook by specifying a path. Without an explicit path, Microsoft Office Excel saves the file in the current folder with the name it was given when it was created. You can also save a copy of the workbook without modifying the open workbook in memory.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Save a workbook without changing the path

### To save a workbook associated with a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Excel.Workbook.Save%2A> method of the `ThisWorkbook` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb" id="Snippet4":::
     ---

### To save the active workbook in a VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Excel._Workbook.Save%2A> method to save the active workbook. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet3":::
     ---

## Save a workbook with a new path
 You can save the specified workbook to a new location or with a new name, optionally specifying a file format, a password, an access mode, and more.

> [!NOTE]
> You might want to set the <xref:Microsoft.Office.Interop.Excel._Application.DisplayAlerts%2A> property to **False** before saving the workbook with a new path because saving in some formats requires interaction. Setting this property to **False** causes Excel to use all defaults.

### To save a workbook associated with a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Excel.Workbook.SaveAs%2A> method of the `ThisWorkbook` class. To use the following code example, run it in the `ThisWorkbook` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb" id="Snippet5":::
     ---

### To save the active workbook in a VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Excel._Workbook.SaveAs%2A> method to save the active workbook to a new path. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet4":::
     ---

## Save a copy of the workbook
 You can save a copy of the workbook to a file without modifying the open workbook in memory. This is useful when you want to create a backup copy without modifying the location of the workbook.

### To save a workbook associated with a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Excel.Workbook.SaveCopyAs%2A> method of the `ThisWorkbook` class. To use the following code example, run it in the `ThisWorkbook` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb" id="Snippet6":::
     ---

### To save the active workbook in a VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Excel._Workbook.SaveCopyAs%2A> method to save a copy of the active workbook. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet5":::
     ---
### To verify that the save was successful
 You can use some of the [DocumentProperties](/dotnet/api/microsoft.office.tools.excel.workbook.builtindocumentproperties) like the **Last Save Time** to verify that the save was successful.  

## Robust programming
 Interactively canceling any of the methods that save or copy the workbook raises a run-time error in your code. For example, if your procedure calls the <xref:Microsoft.Office.Tools.Excel.Workbook.SaveAs%2A> method but does not disable prompts from Excel, and your user clicks **Cancel** when prompted, Excel raises a run-time error.

## Related content
- [Work with workbooks](../vsto/working-with-workbooks.md)
- [Workbook host item](../vsto/workbook-host-item.md)
- [How to: Programmatically close workbooks](../vsto/how-to-programmatically-close-workbooks.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
