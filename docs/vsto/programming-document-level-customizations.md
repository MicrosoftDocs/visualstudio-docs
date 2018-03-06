---
title: "Programming Document-Level Customizations | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Programming Document-Level Customizations
  When you extend Microsoft Office Word or Microsoft Office Excel by using a document-level customization, you can perform the following tasks:  
  
-   Automate the application by using its object model.  
  
-   Add controls to the surface of the document.  
  
-   Call Visual Basic for Applications (VBA) code in the document from the customization assembly.  
  
-   Call code in the customization assembly from VBA.  
  
-   Manage certain aspects of the document while it is on a server that does not have Microsoft Office installed.  
  
-   Customize the user interface (UI) of the application.  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
 Some aspects of writing code in document-level projects are different from other types of projects in Visual Studio. Many of these differences are caused by the way the Office object models are exposed to managed code. For more information, see [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md).  
  
 For general information about document-level customizations and other types of solutions you can create by using the Office development tools in Visual Studio, see [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).  
  
## Using the Generated Classes in Document-Level Projects  
 When you create a document-level project, Visual Studio automatically generates a class in the project that you can use to start writing your code. Visual Studio generates different classes for Word and Excel:  
  
-   In document-level projects for Word, the class is called `ThisDocument` by default.  
  
-   Document-level projects for Excel have multiple generated classes: one for the workbook itself, and one for each worksheet. By default, these classes have the following names:  
  
    -   `ThisWorkbook`  
  
    -   `Sheet1`  
  
    -   `Sheet2`  
  
    -   `Sheet3`  
  
 The generated class includes event handlers that are called when the document is opened or closed. To run code when the document is opened, add code to the `Startup` event handler. To run code just before the document is closed, add code to the `Shutdown` event handler. For more information, see [Events in Office Projects](../vsto/events-in-office-projects.md).  
  
### Understanding the Design of the Generated Classes  
 In projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)], the host item types in the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] are interfaces, so the generated classes cannot derive their implementation from them. Instead, the generated classes derive most of their members from the following base classes:  
  
-   `ThisDocument`: derives from <xref:Microsoft.Office.Tools.Word.DocumentBase>.  
  
-   `ThisWorkbook`: derives from <xref:Microsoft.Office.Tools.Excel.WorkbookBase>.  
  
-   `Sheet` *n*: derives from <xref:Microsoft.Office.Tools.Excel.WorksheetBase>.  
  
 These base classes redirect all calls to their members to internal implementations of the corresponding host item interfaces in the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]. For example, if you call the <xref:Microsoft.Office.Tools.Word.DocumentBase.Protect%2A> method of the `ThisDocument` class, the <xref:Microsoft.Office.Tools.Word.DocumentBase> class redirects this call to the internal implementation of the <xref:Microsoft.Office.Tools.Word.Document> interface in the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)].  
  
## Accessing the Object Model of the Host Application  
 To access the object model of the host application, use members of the generated class in your project. Each of these classes corresponds to an object in the object model of Excel or Word, and they contain most of the same properties, methods, and events. For example, the `ThisDocument` class in a document-level project for Word provides most of the same members as the <xref:Microsoft.Office.Interop.Word.Document> object in the Word object model.  
  
 The following code example shows how to use the Word object model to save the document that is part of a document-level customization for Word. This example is intended to be run from the `ThisDocument` class.  
  
```vb  
Me.Save()  
```  
  
```csharp  
this.Save();  
```  
  
 To do the same thing from outside the `ThisDocument` class, use the `Globals` object to access the `ThisDocument` class. For example, you can add this code to an actions pane code file if you want to include a **Save** button in the actions pane UI.  
  
```vb  
Globals.ThisDocument.Save()  
```  
  
```csharp  
Globals.ThisDocument.Save();  
```  
  
 Because the `ThisDocument` class obtains most of its members from the <xref:Microsoft.Office.Tools.Word.Document> host item, the `Save` method that is called in this code is really the <xref:Microsoft.Office.Tools.Word.Document.Save%2A> method of the <xref:Microsoft.Office.Tools.Word.Document> host item. This method corresponds to the <xref:Microsoft.Office.Interop.Word._Document.Save%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> object in the Word object model.  
  
 For more information about using the object models of Word and Excel, see [Word Object Model Overview](../vsto/word-object-model-overview.md) and [Excel Object Model Overview](../vsto/excel-object-model-overview.md).  
  
 For more information about the `Globals` object, see [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md).  
  
## Adding Controls to Documents  
 To customize the UI of the document, you can add Windows Forms controls or *host controls* to the document surface. By combining different sets of controls and writing code, you can bind the controls to data, collect information from the user, and respond to user actions.  
  
 Host controls are classes that extend some of the objects in the Word and Excel object model. For example, the <xref:Microsoft.Office.Tools.Excel.ListObject> host control provides all of the functionality of the <xref:Microsoft.Office.Interop.Excel.ListObject> in Excel. However, the <xref:Microsoft.Office.Tools.Excel.ListObject> host control also has additional events and data binding capabilities.  
  
 For more information, see [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md) and [Windows Forms Controls on Office Documents Overview](../vsto/windows-forms-controls-on-office-documents-overview.md).  
  
## Combining VBA and Document-Level Customizations  
 You can use VBA code in a document that is part of a document-level customization. You can call VBA code in the document from the customization assembly, and you can also configure your project to enable VBA code in the document to call code in the customization assembly.  
  
 For more information, see [Combining VBA and Document-Level Customizations](../vsto/combining-vba-and-document-level-customizations.md).  
  
## Managing Documents on a Server  
 You can manage several different aspects of document-level customizations on a server that does not have Microsoft Office Word or Microsoft Office Excel installed. For example, you can access and modify data in the data cache of the document. You can also manage the customization assembly that is associated with the document. For example, you can programmatically remove the assembly from the document so that the document no longer runs your code, or you can programmatically attach an assembly to a document.  
  
 For more information, see [Managing Documents on a Server by Using the ServerDocument Class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md).  
  
## Customizing the User Interface of Microsoft Office Applications  
 You can customize the UI of Word and Excel in the following ways by using a document-level customization:  
  
-   Add host controls or Windows Forms controls to the document surface.  
  
     For more information, see [Automating Word by Using Extended Objects](../vsto/automating-word-by-using-extended-objects.md), [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md), and [Windows Forms Controls on Office Documents Overview](../vsto/windows-forms-controls-on-office-documents-overview.md).  
  
-   Add an actions pane to the document.  
  
     For more information, see [Actions Pane Overview](../vsto/actions-pane-overview.md).  
  
-   Add custom tabs to the ribbon.  
  
     For more information, see [Ribbon Overview](../vsto/ribbon-overview.md).  
  
-   Add custom groups to a built-in tab on the ribbon.  
  
     For more information, see [How to: Customize a Built-in Tab](../vsto/how-to-customize-a-built-in-tab.md).  
  
 For more information about customizing the UI of Microsoft Office applications, see [Office UI Customization](../vsto/office-ui-customization.md).  
  
## Getting Extended Objects from Native Office Objects in Document-Level Customizations  
 Many event handlers for Office events receive a native Office object that represents the workbook, worksheet, or document that raised the event. In some cases, you might want to run some code only if the workbook or document in your document-level customization raised the event. For example, in a document-level customization for Excel, you might want to run some code when the user activates one of the worksheets in the customized workbook, but not when the user activates a worksheet in some other workbook that happens to be open at the same time.  
  
 When you have a native Office object, you can test whether that object has been extended into a *host item* or *host control* in a document-level customization. Host items and host controls are types provided by the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] that add functionality to objects that exist natively in the Word or Excel object models (called *native Office objects*). Collectively, host items and host controls are also called *extended objects*. For more information about host items and host controls, see [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md).  
  
## Understanding the GetVstoObject and HasVstoObject Methods  
 To test a native Office object, use the HasVstoObject and GetVstoObject methods in your project:  
  
-   Use the HasVstoObject method if you want to determine whether the native Office object has an extended object in your customization. This method returns **true** if the native Office object has an extended object, and **false** otherwise.  
  
-   Use the GetVstoObject method if you want to get the extended object for a native Office object. This method returns a <xref:Microsoft.Office.Tools.Excel.ListObject>, <xref:Microsoft.Office.Tools.Excel.Workbook>, <xref:Microsoft.Office.Tools.Excel.Worksheet>, or <xref:Microsoft.Office.Tools.Word.Document> object if the specified native Office object has one. Otherwise, GetVstoObject returns **null**. For example, the GetVstoObject method returns a <xref:Microsoft.Office.Tools.Word.Document> if the specified <xref:Microsoft.Office.Interop.Word.Document> is the underlying object for the document in your Word document project.  
  
 In document-level projects, you cannot use the GetVstoObject method to create a new <xref:Microsoft.Office.Tools.Excel.Workbook>, <xref:Microsoft.Office.Tools.Excel.Worksheet>, or <xref:Microsoft.Office.Tools.Word.Document> host item at run time. You can use this method only to access existing host items that are generated in your project at design time. If you want to create new host items at run time, you must develop an VSTO Add-in project. For more information, see [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md) and [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
## Using the GetVstoObject and HasVstoObject Methods  
 To call the HasVstoObject and GetVstoObject method, use the Globals.Factory.GetVstoObject or Globals.Factory.HasVstoObject method, and pass in the native Word or Excel object (such as a <xref:Microsoft.Office.Interop.Word.Document> or <xref:Microsoft.Office.Interop.Excel.Worksheet>) that you want to test.  
  
## See Also  
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [Combining VBA and Document-Level Customizations](../vsto/combining-vba-and-document-level-customizations.md)   
 [Managing Documents on a Server by Using the ServerDocument Class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md)   
 [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)  
  
  