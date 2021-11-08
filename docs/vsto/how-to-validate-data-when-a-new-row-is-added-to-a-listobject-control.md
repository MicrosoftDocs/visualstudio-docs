---
title: "Validate data when new row is added to ListObject control"
description: Learn how you can use Visual Studio to validate data when a new row is added to a ListObject control.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "controls [Office development in Visual Studio], validating data"
  - "ListObject control, new row"
  - "ListObject control, validating data"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Validate data when a new row is added to a ListObject control
  Users can add new rows to a <xref:Microsoft.Office.Tools.Excel.ListObject> control that is bound to data. You can validate the user's data before committing the changes to the data source.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Data validation
 Whenever a row is added to a <xref:Microsoft.Office.Tools.Excel.ListObject> that is bound to data, the <xref:Microsoft.Office.Tools.Excel.ListObject.BeforeAddDataBoundRow> event is raised. You can handle this event to perform your data validation. For example, if your application requires that only employees between the ages of 18 and 65 can be added to the data source, verify that the age entered falls within that range before the row is added.

> [!NOTE]
> You should always check user input on the server in addition to the client. For more information, see [Secure client applications](/dotnet/framework/data/adonet/secure-client-applications).

### To validate data when a new row is added to data-bound ListObject

1. Create variables for the ID and <xref:System.Data.DataTable> at the class level.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet8":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet8":::

2. Create a new <xref:System.Data.DataTable> and add sample columns and data in the `Startup` event handler of the `Sheet1` class (in a document-level project) or `ThisAddIn` class (in a VSTO Add-in project).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet9":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet9":::

3. Add code to the `list1_BeforeAddDataBoundRow` event handler to check whether the age entered falls within the acceptable range.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet10":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet10":::

## Compile the code
 This code example assumes that you have an existing <xref:Microsoft.Office.Tools.Excel.ListObject> named `list1` on the worksheet in which this code appears.

## See also
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [ListObject control](../vsto/listobject-control.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [How to: Map ListObject columns to data](../vsto/how-to-map-listobject-columns-to-data.md)
