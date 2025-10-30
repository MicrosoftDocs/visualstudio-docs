---
title: "Program document-level customizations"
description: Learn how to extend Microsoft Word or Excel by using a document-level customization so you can perform various tasks.
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "Sheet3"
  - "thisWorkbook"
  - "thisDocument"
  - "Sheet1"
  - "Sheet2"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ThisDocument class"
  - "Sheet3 class"
  - "ThisWorkbook class"
  - "writing code for Office solutions"
  - "programming [Office development in Visual Studio], document-level customizations"
  - "Sheet1 class"
  - "Office applications [Office development in Visual Studio], document-level customizations"
  - "Sheet2 class"
  - "document-level customizations [Office development in Visual Studio], programming"
  - "application development [Office development in Visual Studio], document-level customizations"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Program document-level customizations

  When you extend Microsoft Office Word or Microsoft Office Excel by using a document-level customization, you can perform the following tasks:

- Automate the application by using its object model.

- Add controls to the surface of the document.

- Call Visual Basic for Applications (VBA) code in the document from the customization assembly.

- Call code in the customization assembly from VBA.

- Manage certain aspects of the document while it is on a server that does not have Microsoft Office installed.

- Customize the user interface (UI) of the application.

  [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

  Some aspects of writing code in document-level projects are different from other types of projects in Visual Studio. Many of these differences are caused by the way the Office object models are exposed to managed code. For more information, see [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md).

  For general information about document-level customizations and other types of solutions you can create by using the Office development tools in Visual Studio, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

## Use the generated classes in document-level projects
 When you create a document-level project, Visual Studio automatically generates a class in the project that you can use to start writing your code. Visual Studio generates different classes for Word and Excel:

- In document-level projects for Word, the class is called `ThisDocument` by default.

- Document-level projects for Excel have multiple generated classes: one for the workbook itself, and one for each worksheet. By default, these classes have the following names:

  - `ThisWorkbook`

  - `Sheet1`

  - `Sheet2`

  - `Sheet3`

  The generated class includes event handlers that are called when the document is opened or closed. To run code when the document is opened, add code to the `Startup` event handler. To run code just before the document is closed, add code to the `Shutdown` event handler. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### Understand the design of the generated classes
 In projects that target the .NET Framework 4 or the .NET Framework 4.5, the host item types in the  Visual Studio Tools for Office runtime  are interfaces, so the generated classes cannot derive their implementation from them. Instead, the generated classes derive most of their members from the following base classes:

- `ThisDocument`: derives from <xref:Microsoft.Office.Tools.Word.DocumentBase>.

- `ThisWorkbook`: derives from <xref:Microsoft.Office.Tools.Excel.WorkbookBase>.

- `Sheet` *n*: derives from <xref:Microsoft.Office.Tools.Excel.WorksheetBase>.

  These base classes redirect all calls to their members to internal implementations of the corresponding host item interfaces in the  Visual Studio Tools for Office runtime . For example, if you call the <xref:Microsoft.Office.Tools.Word.DocumentBase.Protect%2A> method of the `ThisDocument` class, the <xref:Microsoft.Office.Tools.Word.DocumentBase> class redirects this call to the internal implementation of the <xref:Microsoft.Office.Tools.Word.Document> interface in the  Visual Studio Tools for Office runtime .

## Access the object model of the host application
 To access the object model of the host application, use members of the generated class in your project. Each of these classes corresponds to an object in the object model of Excel or Word, and they contain most of the same properties, methods, and events. For example, the `ThisDocument` class in a document-level project for Word provides most of the same members as the <xref:Microsoft.Office.Interop.Word.Document> object in the Word object model.

 The following code example shows how to use the Word object model to save the document that is part of a document-level customization for Word. This example is intended to be run from the `ThisDocument` class.

### [C#](#tab/csharp)
```csharp
this.Save();
```

### [VB](#tab/vb)
```vb
Me.Save()
```
---

 To do the same thing from outside the `ThisDocument` class, use the `Globals` object to access the `ThisDocument` class. For example, you can add this code to an actions pane code file if you want to include a **Save** button in the actions pane UI.

### [C#](#tab/csharp)
```csharp
Globals.ThisDocument.Save();
```

### [VB](#tab/vb)
```vb
Globals.ThisDocument.Save()
```
---

 Because the `ThisDocument` class obtains most of its members from the <xref:Microsoft.Office.Tools.Word.Document> host item, the `Save` method that is called in this code is really the <xref:Microsoft.Office.Tools.Word.Document.Save%2A> method of the <xref:Microsoft.Office.Tools.Word.Document> host item. This method corresponds to the <xref:Microsoft.Office.Interop.Word._Document.Save%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> object in the Word object model.

 For more information about using the object models of Word and Excel, see [Word object model overview](../vsto/word-object-model-overview.md) and [Excel object model overview](../vsto/excel-object-model-overview.md).

 For more information about the `Globals` object, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

## Add controls to documents
 To customize the UI of the document, you can add Windows Forms controls or *host controls* to the document surface. By combining different sets of controls and writing code, you can bind the controls to data, collect information from the user, and respond to user actions.

 Host controls are classes that extend some of the objects in the Word and Excel object model. For example, the <xref:Microsoft.Office.Tools.Excel.ListObject> host control provides all of the functionality of the <xref:Microsoft.Office.Interop.Excel.ListObject> in Excel. However, the <xref:Microsoft.Office.Tools.Excel.ListObject> host control also has additional events and data binding capabilities.

 For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md) and [Windows forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md).

## Combine VBA and document-level customizations
 You can use VBA code in a document that is part of a document-level customization. You can call VBA code in the document from the customization assembly, and you can also configure your project to enable VBA code in the document to call code in the customization assembly.

 For more information, see [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md).

## Manage documents on a server
 You can manage several different aspects of document-level customizations on a server that does not have Microsoft Office Word or Microsoft Office Excel installed. For example, you can access and modify data in the data cache of the document. You can also manage the customization assembly that is associated with the document. For example, you can programmatically remove the assembly from the document so that the document no longer runs your code, or you can programmatically attach an assembly to a document.

 For more information, see [Manage documents on a server by using the ServerDocument class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md).

## Customize the user interface of Microsoft Office applications
 You can customize the UI of Word and Excel in the following ways by using a document-level customization:

- Add host controls or Windows Forms controls to the document surface.

   For more information, see [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md), [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md), and [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md).

- Add an actions pane to the document.

   For more information, see [Actions pane overview](../vsto/actions-pane-overview.md).

- Add custom tabs to the ribbon.

   For more information, see [Ribbon overview](../vsto/ribbon-overview.md).

- Add custom groups to a built-in tab on the ribbon.

   For more information, see [How to: Customize a built-in tab](../vsto/how-to-customize-a-built-in-tab.md).

  For more information about customizing the UI of Microsoft Office applications, see [Office UI customization](../vsto/office-ui-customization.md).

## Get extended objects from native Office objects in document-level customizations
 Many event handlers for Office events receive a native Office object that represents the workbook, worksheet, or document that raised the event. In some cases, you might want to run some code only if the workbook or document in your document-level customization raised the event. For example, in a document-level customization for Excel, you might want to run some code when the user activates one of the worksheets in the customized workbook, but not when the user activates a worksheet in some other workbook that happens to be open at the same time.

 When you have a native Office object, you can test whether that object has been extended into a *host item* or *host control* in a document-level customization. Host items and host controls are types provided by the  Visual Studio Tools for Office runtime  that add functionality to objects that exist natively in the Word or Excel object models (called *native Office objects*). Collectively, host items and host controls are also called *extended objects*. For more information about host items and host controls, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

## Understand the GetVstoObject and HasVstoObject methods
 To test a native Office object, use the `HasVstoObject` and `GetVstoObject` methods in your project:

- Use the `HasVstoObject` method if you want to determine whether the native Office object has an extended object in your customization. This method returns **true** if the native Office object has an extended object, and **false** otherwise.

- Use the `GetVstoObject` method if you want to get the extended object for a native Office object. This method returns a <xref:Microsoft.Office.Tools.Excel.ListObject>, <xref:Microsoft.Office.Tools.Excel.Workbook>, <xref:Microsoft.Office.Tools.Excel.Worksheet>, or <xref:Microsoft.Office.Tools.Word.Document> object if the specified native Office object has one. Otherwise, `GetVstoObject` returns **null**. For example, the `GetVstoObject` method returns a <xref:Microsoft.Office.Tools.Word.Document> if the specified <xref:Microsoft.Office.Interop.Word.Document> is the underlying object for the document in your Word document project.

  In document-level projects, you cannot use the `GetVstoObject` method to create a new <xref:Microsoft.Office.Tools.Excel.Workbook>, <xref:Microsoft.Office.Tools.Excel.Worksheet>, or <xref:Microsoft.Office.Tools.Word.Document> host item at run time. You can use this method only to access existing host items that are generated in your project at design time. If you want to create new host items at run time, you must develop a VSTO Add-in project. For more information, see [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md) and [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## Use the GetVstoObject and HasVstoObject methods
 To call the `HasVstoObject` and `GetVstoObject` method, use the `Globals.Factory.GetVstoObject` or `Globals.Factory.HasVstoObject` method, and pass in the native Word or Excel object (such as a <xref:Microsoft.Office.Interop.Word.Document> or <xref:Microsoft.Office.Interop.Excel.Worksheet>) that you want to test.

## Related content
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md)
- [Manage documents on a server by using the ServerDocument class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
