---
title: "How to: Add NamedRange controls to worksheets"
description: Learn how you can add NamedRange controls to a Microsoft Office Excel worksheet at design time and at run time in document-level projects.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, adding to worksheets"
  - "NamedRange control, adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Add NamedRange controls to worksheets
  You can add <xref:Microsoft.Office.Tools.Excel.NamedRange> controls to a Microsoft Office Excel worksheet at design time and at run time in document-level projects.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 You can also add <xref:Microsoft.Office.Tools.Excel.NamedRange> controls at run time in VSTO Add-in projects.

 This topic describes the following tasks:

- [Add NamedRange controls at design time](#designtime)

- [Add NamedRange controls at run time in a document-level project](#runtimedoclevel)

- [Add NamedRange controls at run time in a VSTO Add-in project](#runtimeaddin)

  For more information about <xref:Microsoft.Office.Tools.Excel.NamedRange> controls, see [NamedRange control](../vsto/namedrange-control.md).

## <a name="designtime"></a> Add NamedRange controls at design time
 There are several ways to add <xref:Microsoft.Office.Tools.Excel.NamedRange> controls to a worksheet in a document-level project at design time: from within Excel, from the Visual Studio **Toolbox**, and from the **Data Sources** window.

 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

### To add a NamedRange control to a worksheet using the Name Box in Excel

1. Select the cell or cells you want to include in the named range.

2. In the **Name Box**, type a name for the range and press **Enter**.

     The **Name Box** is located beside the formula bar, just above column **A** of the worksheet.

### To add a NamedRange control to a worksheet using the Toolbox

1. Open the **Toolbox** and click the **Excel Controls** tab.

2. Click <xref:Microsoft.Office.Tools.Excel.NamedRange> and drag it to a worksheet.

     The **Add Named Range** dialog box appears.

3. Select the cell or cells you want to include in the named range.

4. Click **OK**.

     If you do not want the default name that is given to the control, you can change the name in the **Properties** window.

### To add a NamedRange control to a worksheet using the Data Sources window

1. Open the **Data Sources** window and create a data source for your project. For more information, see [Add new connections](../data-tools/add-new-connections.md).

2. Drag a single field from the **Data Sources** window to your worksheet.

     A data-bound <xref:Microsoft.Office.Tools.Excel.NamedRange> control is added to the worksheet. For more information, see [Data binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms).

## <a name="runtimedoclevel"></a> Add NamedRange controls at run time in a document-level project
 You can add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control programmatically to your worksheet at run time. This enables you to create the host controls in response to events. Dynamically created named ranges are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

### To add a NamedRange control to a worksheet programmatically

1. In the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler of `Sheet1`, insert the following code to add the <xref:Microsoft.Office.Tools.Excel.NamedRange> control to cell **A1** and set its <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property to `Hello world!`

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet3":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet3":::

## <a name="runtimeaddin"></a> Add NamedRange controls at run time in a VSTO Add-in project
 You can add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control programmatically to any open worksheet in a VSTO Add-in project. Dynamically created named ranges are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

### To add a NamedRange control to a worksheet programmatically

1. The following code generates a worksheet host item that is based on the open worksheet, and then adds a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to cell **A1** and sets its <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property to `Hello world`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs" id="Snippet7":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb" id="Snippet7":::

## See also
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [How to: Resize NamedRange controls](../vsto/how-to-resize-namedrange-controls.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
