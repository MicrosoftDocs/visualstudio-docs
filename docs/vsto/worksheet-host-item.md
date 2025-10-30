---
title: "Worksheet host item"
description: Learn that the Worksheet host item is a type that extends the Worksheet type from the primary interop assembly for Excel.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "host items [Office development in Visual Studio], Worksheet"
  - "Excel [Office development in Visual Studio], worksheets"
  - "Worksheet host items"
  - "worksheets, events"
  - "Worksheet host items, events"
  - "Excel worksheets"
  - "worksheets, Excel"
  - "worksheets"
  - "events [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Worksheet host item

  The <xref:Microsoft.Office.Tools.Excel.Worksheet> host item is a type that extends the <xref:Microsoft.Office.Interop.Excel.Worksheet> type from the primary interop assembly for Excel. The <xref:Microsoft.Office.Tools.Excel.Worksheet> host item provides all of the same properties, methods, and events as a <xref:Microsoft.Office.Interop.Excel.Worksheet> object, but it also exposes additional events and acts as a container for host controls and Windows Forms controls.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 In document-level projects, you can add <xref:Microsoft.Office.Tools.Excel.Worksheet> host items to your project at design time. In VSTO Add-in projects, you can generate <xref:Microsoft.Office.Tools.Excel.Worksheet> host items at run time.

## Understand worksheet host items in document-level projects
 When you create a document-level project for Excel, Visual Studio automatically creates three <xref:Microsoft.Office.Tools.Excel.Worksheet> host items in the project. The default names of the worksheets are `Sheet1`, `Sheet2`, and `Sheet3`. If you create a project based on an existing workbook, the number of host items depends on the number of worksheets in the workbook.

 These worksheet classes give you access to members of the <xref:Microsoft.Office.Tools.Excel.Worksheet> host item to perform basic tasks in your customization, such as modifying the contents of a worksheet. You can also use these classes to add controls to worksheets. By combining different sets of controls and writing code, you can bind the controls to data, collect information from the user, and respond to user actions. For more information, see [Program document-level customizations](../vsto/programming-document-level-customizations.md).

 The worksheet classes provide a location in which you can start writing code in your project. Because the class provides all of the same properties, methods, and events as the <xref:Microsoft.Office.Interop.Excel.Worksheet> object in the primary interop assembly for Excel, you can also use these classes to access the object model of Excel. For more information, see [Excel object model overview](../vsto/excel-object-model-overview.md).

 In document-level projects, you can add additional <xref:Microsoft.Office.Tools.Excel.Worksheet> host items to the project at design time by adding a new worksheet to the workbook in the designer.

### Rename worksheets
 In a document-level project, you can rename the worksheets in the Visual Studio designer, but this only changes the display name of the worksheet. The programmatic name is still the default name of the worksheet. If you rename the worksheet in the **Properties** window, only the programmatic name is changed.

### Limitations of the worksheet host item in document-level projects
 You cannot create new <xref:Microsoft.Office.Tools.Excel.Worksheet> host items at run time in a document-level project. If you create a new Excel worksheet at run time, it will be of the type <xref:Microsoft.Office.Interop.Excel.Worksheet>. Because it is not a host item, it cannot contain any host controls or Windows Forms controls. For more information about creating documents at run time, see [How to: Programmatically add new worksheets to workbooks](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md).

## Understand worksheet host items in VSTO Add-in projects
 In application-level projects, you can generate a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item at run time for any worksheet that is open in Excel. You can use the <xref:Microsoft.Office.Tools.Excel.Worksheet> host item to add controls to the associated worksheet, or to handle events that are not available on <xref:Microsoft.Office.Interop.Excel.Worksheet> objects.

 To generate a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item, use the `GetVstoObject` method. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## Related content
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Workbook host item](../vsto/workbook-host-item.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
