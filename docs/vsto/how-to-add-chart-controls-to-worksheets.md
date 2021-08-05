---
title: "How to: Add Chart controls to worksheets"
description: Learn how you can add Chart controls to a Microsoft Office Excel worksheet at design time and at run time in document-level customizations.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Chart control [Office development in Visual Studio], adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Add Chart controls to worksheets
  You can add <xref:Microsoft.Office.Tools.Excel.Chart> controls to a Microsoft Office Excel worksheet at design time and at run time in document-level customizations. You can also add <xref:Microsoft.Office.Tools.Excel.Chart> controls at run time in VSTO Add-ins.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 This topic describes the following tasks:

- [Add Chart controls at design time](#designtime)

- [Add Chart controls at run time in a document-level project](#runtimedoclevel)

- [Add Chart controls at run time in a VSTO Add-in project](#runtimeaddin)

  For more information about <xref:Microsoft.Office.Tools.Excel.Chart> controls, see [Chart control](../vsto/chart-control.md).

## <a name="designtime"></a> Add Chart controls at design time
 You can add the <xref:Microsoft.Office.Tools.Excel.Chart> control to your worksheet in the same manner you would add a chart from within the application.

> [!NOTE]
> The <xref:Microsoft.Office.Tools.Excel.Chart> control is not available from the **Toolbox** or the **Data Sources** window.

### To add a Chart host control to a worksheet in Excel

1. On the **Insert** tab, in the **Charts** group, click **Column**, click a category of charts, and then click the type of chart you want.

2. In the **Insert Chart** dialog box, click **OK**.

3. On the **Design** tab, in the **Data** group, click **Select Data**.

4. In the **Select Data Source** dialog box, click in the **Chart** **data range** box and clear any default selection.

5. In the **Data for Chart** sheet, select the range of cells that contains the data for the chart (cells **A5** through **D8**).

6. In the **Select Data Source** dialog box, click **OK**.

## <a name="runtimedoclevel"></a> Add chart controls at run time in a document-level project
 You can add the <xref:Microsoft.Office.Tools.Excel.Chart> control dynamically at run time. Dynamically created charts are not persisted in the document as host controls when the document is closed. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

#### To add a Chart control to a worksheet programmatically

1. In the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler of `Sheet1`, insert the following code to add the <xref:Microsoft.Office.Tools.Excel.Chart> control.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet1":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet1":::

## <a name="runtimeaddin"></a> Add chart controls at run time in a VSTO Add-in project
 You can add a <xref:Microsoft.Office.Tools.Excel.Chart> control programmatically to any open worksheet in a VSTO Add-in project. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

 Dynamically created chart controls are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Add Controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

#### To add a Chart control to a worksheet programmatically

1. The following code generates a worksheet host item that is based on the open worksheet, and then adds a <xref:Microsoft.Office.Tools.Excel.Chart> control.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs" id="Snippet9":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb" id="Snippet9":::

## Compile the code
 This example has the following requirements:

- Data to be charted, stored in the range from A5 to D8 in the worksheet.

## See also
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Chart control](../vsto/chart-control.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
