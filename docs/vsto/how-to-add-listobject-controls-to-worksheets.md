---
title: "How to: Add ListObject controls to worksheets"
description: Learn how you can add ListObject controls to a Microsoft Office Excel worksheet at design time and at run time in document-level projects.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ListObject control, adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Add ListObject controls to worksheets
  You can add <xref:Microsoft.Office.Tools.Excel.ListObject> controls to a Microsoft Office Excel worksheet at design time and at run time in document-level projects.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 You can also add <xref:Microsoft.Office.Tools.Excel.ListObject> controls at run time in VSTO Add-in projects.

 This topic describes the following tasks:

- [Add ListObject controls at design time](#designtime)

- [Add ListObject controls at run time in a document-level project](#runtimedoclevel)

- [Add ListObject controls at run time in a VSTO Add-in project](#runtimeaddin)

  For more information about <xref:Microsoft.Office.Tools.Excel.ListObject> controls, see [ListObject control](../vsto/listobject-control.md).

## <a name="designtime"></a> Add ListObject controls at design time
 There are several ways to add <xref:Microsoft.Office.Tools.Excel.ListObject> controls to a worksheet in a document-level project at design time: From within Excel, from the Visual Studio **Toolbox**, and from the **Data Sources** window.

 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

### To use the Ribbon in Excel

1. On the **Insert** tab, in the **Tables** group, click **Table**.

2. Select the cell or cells you want to include in the list and click **OK**.

#### To use the Toolbox

1. From the **Excel Controls** tab of the **Toolbox**, drag a <xref:Microsoft.Office.Tools.Excel.ListObject> to the worksheet.

     The **Add ListObject Control** dialog box appears.

2. Select the cell or cells you want to include in the list and click **OK**.

     If you do not want to keep the default name, you can change the name in the **Properties** window.

#### To use the Data Sources window

1. Open the **Data Sources** window and create a data source for your project. For more information, see [Add new connections](../data-tools/add-new-connections.md).

2. Drag a table from the **Data Sources** window to your worksheet.

     A data-bound <xref:Microsoft.Office.Tools.Excel.ListObject> control is added to the worksheet. For more information, see [Data binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms).

## <a name="runtimedoclevel"></a> Add ListObject controls at run time in a document-level project
 You can add the <xref:Microsoft.Office.Tools.Excel.ListObject> control dynamically at run time. This enables you to create the host controls in response to events. Dynamically created list objects are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

#### To add a ListObject control to a worksheet programmatically

1. In the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler of `Sheet1`, insert the following code to add a <xref:Microsoft.Office.Tools.Excel.ListObject> control to cells **A1** through **A4**.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet2":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet2":::

## <a name="runtimeaddin"></a> Add ListObject controls at run time in a VSTO Add-in project
 You can add a <xref:Microsoft.Office.Tools.Excel.ListObject> control programmatically to any open worksheet in a VSTO Add-in project. Dynamically created list objects are not persisted in the worksheet as host controls when the worksheet is saved and then closed. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

#### To add a ListObject control to a worksheet programmatically

1. The following code generates a worksheet host item that is based on the open worksheet, and then adds a <xref:Microsoft.Office.Tools.Excel.ListObject> control to cells **A1** through **A4**.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs" id="Snippet8":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb" id="Snippet8":::

## See also
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [ListObject control](../vsto/listobject-control.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [How to: Resize ListObject controls](../vsto/how-to-resize-listobject-controls.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
