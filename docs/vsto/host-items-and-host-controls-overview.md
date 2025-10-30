---
title: "Host items and host controls overview"
description: Learn that host items and host controls are types that help provide the programming model for Office solutions.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "host controls [Office development in Visual Studio], adding"
  - "Office documents [Office development in Visual Studio, host controls"
  - "host items [Office development in Visual Studio]"
  - "application development [Office development in Visual Studio], host items"
  - "Office applications [Office development in Visual Studio], host items"
  - "host controls [Office development in Visual Studio], listed"
  - "Excel [Office development in Visual Studio], host items"
  - "host controls [Office Development in Visual Stuio], naming"
  - "host controls [Office development in Visual Studio]"
  - "host controls [Office development in Visual Studio], about host controls"
  - "document-level customizations [Office development in Visual Studio], host controls"
  - "Office applications [Office development in Visual Studio], host controls"
  - "documents [Office development in Visual Studio], host controls"
  - "controls [Office development in Visual Studio], host controls"
  - "application development [Office development in Visual Studio], host controls"
  - "Excel [Office development in Visual Studio], host controls"
  - "host items [Office development in Visual Studio], about host items"
  - "host items [Office development in Visual Studio], listed"
  - "documents [Office development in Visual Studio], host items"
  - "data binding [Office development in Visual Studio], host controls"
  - "Office documents [Office development in Visual Studio, host items"
  - "Word [Office development in Visual Studio], host items"
  - "document-level customizations [Office development in Visual Studio], host items"
  - "Word [Office development in Visual Studio], host controls"
  - "host controls [Office development in Visual Studio], deleting"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Host items and host controls overview

  Host items and host controls are types that help provide the programming model for Office solutions that are created by using the Office development tools in Visual Studio. Host items and host controls make interacting with the object models of Microsoft Office Word and Microsoft Office Excel, which are based on COM, more like interacting with managed objects such as Windows Forms controls.

 [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]

## Host items
 Host items are types that are at the top of object model hierarchies in Office projects. The  Visual Studio Tools for Office runtime  defines the following host items for Word and Excel solutions:

- <xref:Microsoft.Office.Tools.Word.Document>

- <xref:Microsoft.Office.Tools.Excel.Workbook>

- <xref:Microsoft.Office.Tools.Excel.Worksheet>

- <xref:Microsoft.Office.Tools.Excel.ChartSheet>

  Each of these types extends an object that exists natively in the Word or Excel object model, called a *native Office object*. For example, the <xref:Microsoft.Office.Tools.Word.Document> host item extends the <xref:Microsoft.Office.Interop.Word.Document> object, which is defined in the primary interop assembly for Word.

  Host items generally have the same base functionality as the corresponding Office objects, but are enhanced with the following features:

- The ability to host managed controls, including host controls and Windows Forms controls.

- Richer event models. Some document, workbook, and worksheet events in the native Word and Excel object models are raised only at the application level. Host items provide these events at the document level, so that it is easier to handle the events for a specific document.

### Understand host items in document-level projects
 In document-level projects, host items provide an entry point for your code, and they have designers that help you develop your solution.

 The <xref:Microsoft.Office.Tools.Word.Document> and <xref:Microsoft.Office.Tools.Excel.Worksheet> host items have associated designers that are the visual representation of the document or worksheet, like a Windows Forms designer. You can use this designer to modify the content of the document or worksheet directly in Word or Excel, and to drag controls onto the design surface. For more information, see [Document host item](../vsto/document-host-item.md) and [Worksheet host item](../vsto/worksheet-host-item.md).

 The <xref:Microsoft.Office.Tools.Excel.Workbook> host item does not act as a container for controls that have a user interface. Instead, the designer for this host item functions as a component tray, which enables you to drag a component, such as a <xref:System.Data.DataSet>, onto its design surface. For more information, see [Workbook host item](../vsto/workbook-host-item.md).

 Host items cannot be created programmatically in document-level projects. Instead, use the `ThisDocument`, `ThisWorkbook`, or `Sheet`*n* classes that Visual Studio automatically generates in your project at design time. These generated classes derive from the host items, and they provide an entry point for your code. For more information, see [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md).

### Understand host items in VSTO Add-in projects
 When you create a VSTO Add-in, you do not have access to any host items by default. However, you can generate <xref:Microsoft.Office.Tools.Word.Document>, <xref:Microsoft.Office.Tools.Excel.Workbook>, and <xref:Microsoft.Office.Tools.Excel.Worksheet> host items in Word and Excel VSTO Add-ins at run time.

 After you generate a host item, you can perform tasks such as adding controls to documents. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## Host controls
 Host controls extend various user interface (UI) objects in the Word and Excel object models, such as `Microsoft.Office.Interop.Word.ContentControl` and <xref:Microsoft.Office.Interop.Excel.Range> objects.

 The following host controls are available for Excel projects:

- [Chart control](../vsto/chart-control.md)

- [ListObject control](../vsto/listobject-control.md)

- [NamedRange control](../vsto/namedrange-control.md)

- [XmlMappedRange control](../vsto/xmlmappedrange-control.md)

  The following host controls are available for Word projects:

- [Bookmark control](../vsto/bookmark-control.md)

- [Content controls](../vsto/content-controls.md)

- [XMLNode control](../vsto/xmlnode-control.md)

- [XMLNodes control](../vsto/xmlnodes-control.md)

  Host controls that are added to Office documents behave like the native Office objects; however, host controls have additional functionality, including events and data-binding capabilities. For example, when you want to capture the events of a native <xref:Microsoft.Office.Interop.Excel.Range> object in Excel, you must first handle the change event of the worksheet. Then you must determine whether the change occurred within the <xref:Microsoft.Office.Interop.Excel.Range>. In contrast, the <xref:Microsoft.Office.Tools.Excel.NamedRange> host control has a <xref:Microsoft.Office.Tools.Excel.NamedRange.Change> event that you can handle directly.

  The relationship between a host item and host controls is similar to the relationship between a Windows Form and Windows Forms controls. Just as you would place a text box control on a Windows Form, you place a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item. The following illustration shows the relationship between host items and host controls.

  ![Relationship between host items and host controls](../vsto/media/hostitemscontrols.png "Relationship between host items and host controls")

  You can also use Windows Forms controls in your Office solutions by adding them directly to the Word and Excel document surface. For more information, see [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md).

> [!NOTE]
> Adding host controls or Windows Forms controls to a Word subdocument is not supported.

### Add host controls to your documents
 In document-level projects, you can add host controls to your Word documents or Excel worksheets at design time in the following ways:

- Add host controls to your document at design time in the same manner you would add a native object.

- Drag host controls from the **Toolbox** onto your documents and worksheets. Excel host controls are available in the **Excel Controls** tab in Excel projects, and Word host controls are available in the **Word Controls** tab in Word projects.

- Drag host controls from the **Data Sources** window onto your documents and worksheets. This enables you to add controls that are already bound to data. For more information, see [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

  In document-level and VSTO Add-in projects, you can also add some host controls to documents at run time. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

  For more information about how to add host controls to documents, see the following topics:

- [How to: Add Chart controls to worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md)

- [How to: Add ListObject controls to worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md)

- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)

- [How to: Add XMLMappedRange controls to worksheets](../vsto/how-to-add-xmlmappedrange-controls-to-worksheets.md)

- [How to: Add Bookmark controls to Word documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)

- [How to: Add Content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md)

- [How to: Add XMLNode controls to Word documents](../vsto/how-to-add-xmlnode-controls-to-word-documents.md)

- [How to: Add XMLNodes controls to Word documents](../vsto/how-to-add-xmlnodes-controls-to-word-documents.md)

### Name host controls
 When you drag a host control from the **Toolbox** to your document, the control is automatically named using the control type with an incremental number at the end. For example, bookmarks are named **bookmark1**, **bookmark2**, and so on. If you use the native functionality of Word or Excel to add the control, you can give it a specific name at the time that you create it. You can also rename your controls by changing the value of the **Name** property in the **Properties** window.

> [!NOTE]
> You cannot use reserved words to name host controls. For example, if you add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a worksheet and change the name to **System**, errors occur when you build the project.

### Delete host controls
 In document-level projects, you can delete host controls at design time by selecting the control on the Excel worksheet or Word document and pressing the **Delete** key. However, you must use the **Define Name** dialog box in Excel to delete <xref:Microsoft.Office.Tools.Excel.NamedRange> controls.

 If you add a host control to a document at design time, you should not remove it programmatically at run time because the next time you try to use the control in code, an exception is thrown. The `Delete` method of a host control only removes host controls that are added to the document at run time. If you call the `Delete` method of a host control that was created at design time, an exception is thrown.

 For example, the <xref:Microsoft.Office.Tools.Excel.NamedRange.Delete%2A> method of a <xref:Microsoft.Office.Tools.Excel.NamedRange> only successfully deletes the <xref:Microsoft.Office.Tools.Excel.NamedRange> if it was programmatically added to the worksheet, which is known as creating host controls dynamically. Dynamically created host controls can also be removed by passing the control name to the `Remove` method of the <xref:Microsoft.Office.Tools.Excel.Worksheet.Controls%2A> or <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

 If end users delete a host control from the document at run time, the solution might fail in unexpected ways. You can use the document protection features in Word and Excel to protect the host controls from being deleted. For more information, see [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).

> [!NOTE]
> Do not programmatically remove controls during the `Shutdown` event handler of the document or worksheet. The UI elements are no longer available when the `Shutdown` event occurs. If you want to remove controls before the application closes, add your code to another event handler such as `BeforeClose` or `BeforeSave`.

### Program against host control events
 One way that host controls extend Office objects is by adding events. For example, the <xref:Microsoft.Office.Interop.Excel.Range> object in Excel and <xref:Microsoft.Office.Interop.Word.Bookmark> object in Word do not have events, but the  Visual Studio Tools for Office runtime  extends these objects by adding programmable events. You can access and code against these events the same way you access events of controls on Windows Forms: through the event drop-down list in Visual Basic and the event property page in C#. For more information, see [Walkthrough: Program against events of a NamedRange control](../vsto/walkthrough-programming-against-events-of-a-namedrange-control.md).

> [!NOTE]
> You should not set the <xref:Microsoft.Office.Interop.Excel._Application.EnableEvents%2A> property of the <xref:Microsoft.Office.Interop.Excel.Application> object in Excel to **false**. Setting this property to **false** prevents Excel from raising any events, including the events of host controls.

## Related content
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
