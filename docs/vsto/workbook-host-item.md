---
title: "Workbook host item"
description: Learn that the Workbook host item is a type that extends the Workbook type from the primary interop assembly for Microsoft Excel.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Excel workbooks"
  - "Workbook host items"
  - "host items [Office development in Visual Studio], Workbook"
  - "workbooks, Excel"
  - "Workbook host items, events"
  - "workbooks"
  - "Excel [Office development in Visual Studio], workbooks"
  - "workbooks, events"
  - "events [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Workbook host item

  The <xref:Microsoft.Office.Tools.Excel.Workbook> host item is a type that extends the <xref:Microsoft.Office.Interop.Excel.Workbook> type from the primary interop assembly for Excel. The <xref:Microsoft.Office.Tools.Excel.Workbook> host item provides all of the same properties, methods, and events as a <xref:Microsoft.Office.Interop.Excel.Workbook> object, but it also provides additional features.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 In document-level projects, there is a default <xref:Microsoft.Office.Tools.Excel.Workbook> host item that represents the workbook in your project. In VSTO Add-in projects, you can generate <xref:Microsoft.Office.Tools.Excel.Workbook> host items at run time.

## Understand the workbook host item in document-level projects
 To access the workbook in your project, use the `ThisWorkbook` class. The `ThisWorkbook` class gives you access to members of the <xref:Microsoft.Office.Tools.Excel.Workbook> host item to perform basic tasks in your customization, such as running code when the workbook is opened or closed. For more information, see [Program document-level customizations](../vsto/programming-document-level-customizations.md).

 The `ThisWorkbook` class provides a location in which you can start writing code in your project. Because the class provides all of the same properties, methods, and events as the <xref:Microsoft.Office.Interop.Excel.Workbook> object in the primary interop assembly for Excel, you can also use `ThisWorkbook` to access the object model of Excel. For more information, see [Excel object model overview](../vsto/excel-object-model-overview.md).

 Double-click the **ThisWorkbook** project item in **Solution Explorer** to display the workbook designer and to view the properties and events of the workbook in the **Properties** window.

### Limitations of the workbook host item in document-level projects
 A document-level project can contain only one <xref:Microsoft.Office.Tools.Excel.Workbook> host item (that is, the `ThisWorkbook` class). You cannot add new <xref:Microsoft.Office.Tools.Excel.Workbook> host items to your project at design time, and you cannot create new <xref:Microsoft.Office.Tools.Excel.Workbook> host items at run time from a document-level customization.

 If you create a new Excel workbook at run time, it will be of the type <xref:Microsoft.Office.Interop.Excel.Workbook>. Because it is not a host item, it cannot contain any host controls or Windows Forms controls. For more information about creating workbooks at run time, see [How to: Programmatically create new workbooks](../vsto/how-to-programmatically-create-new-workbooks.md).

 The <xref:Microsoft.Office.Tools.Excel.Workbook> host item does not act as a container for host controls. Therefore, you cannot add any visible controls to the workbook, but you can add components, such as a <xref:System.Data.DataSet>, so that the components can be shared by all worksheets. In a document-level project, components available to the workbook can be found on the **Component** tab, **Data** tab, and **All Windows Forms** tab of the **Toolbox**.

> [!NOTE]
> The Office development tools in Visual Studio do not support shared workbooks.

## Understand workbook host items in VSTO Add-in projects
 In VSTO Add-in projects, you can generate a <xref:Microsoft.Office.Tools.Excel.Workbook> host item at run time for any workbook that is open in Excel. To generate a <xref:Microsoft.Office.Tools.Excel.Workbook> host item, use the `GetVstoObject` method. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## Related content
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Worksheet host item](../vsto/worksheet-host-item.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
