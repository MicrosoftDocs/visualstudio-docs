---
title: Program VSTO add-ins with the ThisAddIn class
description: Program VSTO add-ins with the ThisAddIn class to perform tasks such as accessing the object model of the Microsoft Office host application.
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VST.ProjectItem.Addin"
  - "VST.ProjectItem.AddinProject"
  - "thisAddIn"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ICustomTaskPaneConsumer interface"
  - "add-ins [Office development in Visual Studio], programming"
  - "IRibbonExtensibility interface"
  - "UI customizing [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], application-level add-ins"
  - "programming [Office development in Visual Studio], application-level add-ins"
  - "ThisAddIn class"
  - "user interfaces [Office development in Visual Studio], customizing"
  - "writing code for Office solutions"
  - "host items [Office development in Visual Studio], AddIn"
  - "application development [Office development in Visual Studio], application-level add-ins"
  - "add-ins [Office development in Visual Studio], ThisAddIn class"
  - "application-level add-ins [Office development in Visual Studio], ThisAddIn class"
  - "FormRegionStartup interface"
  - "ThisAddIn_Startup"
  - "application-level add-ins [Office development in Visual Studio], programming"
  - "ThisAddIn_Shutdown"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Program VSTO Add-ins

  When you extend a Microsoft Office application by creating a VSTO Add-in, you write code directly against the `ThisAddIn` class in your project. You can use this class to perform tasks such as accessing the object model of the Microsoft Office host application, customizing the user interface (UI) of the application, and exposing objects in your VSTO Add-in to other Office solutions.

 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]

 Some aspects of writing code in VSTO Add-in projects are different from other types of projects in Visual Studio. Many of these differences are caused by the way the Office object models are exposed to managed code. For more information, see [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md).

 For general information about VSTO Add-ins and other types of solutions you can create by using the Office development tools in Visual Studio, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

## Use the ThisAddIn class
 You can start writing your VSTO Add-in code in the `ThisAddIn` class. Visual Studio automatically generates this class in the *ThisAddIn.vb* (in Visual Basic) or *ThisAddIn.cs* (in C#) code file in your VSTO Add-in project. The  Visual Studio Tools for Office runtime  automatically instantiates this class for you when the Microsoft Office application loads your VSTO Add-in.

 There are two default event handlers in the `ThisAddIn` class. To run code when the VSTO Add-in is loaded, add code to the `ThisAddIn_Startup` event handler. To run code just before the VSTO Add-in is unloaded, add code to the `ThisAddIn_Shutdown` event handler. For more information about these event handlers, see [Events in Office projects](../vsto/events-in-office-projects.md).

> [!NOTE]
> In Outlook, by default the `ThisAddIn_Shutdown` event handler is not always called when the VSTO Add-in is unloaded. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### Access the object model of the host application
 To access the object model of the host application, use the `Application` field of the `ThisAddIn` class. This field returns an object that represents the current instance of the host application. The following table lists the type of the return value for the `Application` field in each VSTO Add-in project.

|Host application|Return value type|
|----------------------|-----------------------|
|Microsoft Office Excel|<xref:Microsoft.Office.Interop.Excel.Application>|
|Microsoft Office InfoPath|<xref:Microsoft.Office.Interop.InfoPath.Application>|
|Microsoft Office Outlook|<xref:Microsoft.Office.Interop.Outlook.Application>|
|Microsoft Office PowerPoint|[Application](/previous-versions/office/developer/office-2010/ff764034(v=office.14))|
|Microsoft Office Project|Microsoft.Office.Interop.MSProject.Application|
|Microsoft Office Visio|Microsoft.Office.Interop.Visio.Application|
|Microsoft Office Word|<xref:Microsoft.Office.Interop.Word.Application>|

 The following code example shows how to use the `Application` field to create a new workbook in a VSTO Add-in for Microsoft Office Excel. This example is intended to be run from the `ThisAddIn` class.

### [C#](#tab/csharp)
```csharp
Excel.Workbook newWorkbook = this.Application.Workbooks.Add(System.Type.Missing);
```

### [VB](#tab/vb)
```vb
Dim newWorkbook As Excel.Workbook = Me.Application.Workbooks.Add()
```
---

 To do the same thing from outside the `ThisAddIn` class, use the `Globals` object to access the `ThisAddIn` class. For more information about the `Globals` object, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

### [C#](#tab/csharp)
```csharp
Excel.Workbook newWorkbook = Globals.ThisAddIn.Application.Workbooks.Add(System.Type.Missing);
```

### [VB](#tab/vb)
```vb
Dim newWorkbook As Excel.Workbook = Globals.ThisAddIn.Application.Workbooks.Add()
```
---

 For more information about the object models of specific Microsoft Office applications, see the following topics:

- [Excel object model overview](../vsto/excel-object-model-overview.md)

- [Word object model overview](../vsto/word-object-model-overview.md)

- [Outlook object model overview](../vsto/outlook-object-model-overview.md)

- [InfoPath solutions](../vsto/infopath-solutions.md)

- [PowerPoint solutions](../vsto/powerpoint-solutions.md)

- [Project solutions](../vsto/project-solutions.md)

- [Visio object model overview](../vsto/visio-object-model-overview.md)

### <a name="AccessingDocuments"></a> Access a document when the Office application starts
 Not all Office 2010 applications automatically open a document when you start them, and none of the  Office 2013  applications open a document when you start them. Therefore, don't add code in the `ThisAdd-In_Startup` event handler if the code requires a document to be open. Instead, add that code to an event that the Office application raises when a user creates or opens a document. That way, you can guarantee that a document is open before your code performs operations on it.

 The following code example works with a document in Word only when the user creates a document or opens an existing document.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordaddin_menus.cs/thisaddin.cs" id="Snippet3":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddin_menus.vb/thisaddin.vb" id="Snippet3":::
 ---

### ThisAddIn members to use for other tasks
 The following table describes other common tasks and shows which members of the `ThisAddIn` class you can use to perform the tasks.

|Task|Member to use|
|----------|-------------------|
|Run code to initialize the VSTO Add-in when the VSTO Add-in is loaded.|Add code to the `ThisAddIn_Startup` method. This is the default event handler for the <xref:Microsoft.Office.Tools.AddInBase.Startup> event. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).|
|Run code to clean up resources used by the VSTO Add-in before the VSTO Add-in is unloaded.|Add code to the `ThisAddIn_Shutdown` method. This is the default event handler for the <xref:Microsoft.Office.Tools.AddInBase.Shutdown> event. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md). **Note:**  In Outlook, by default the `ThisAddIn_Shutdown` event handler is not always called when the VSTO Add-in is unloaded. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).|
|Display a custom task pane.|Use the `CustomTaskPanes` field. For more information, see [Custom task panes](../vsto/custom-task-panes.md).|
|Expose objects in your VSTO Add-in to other Microsoft Office solutions.|Override the <xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService%2A> method. For more information, see [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md).|
|Customize a feature in the Microsoft Office system by implementing an extensibility interface.|Override the <xref:Microsoft.Office.Tools.AddInBase.RequestService%2A> method to return an instance of a class that implements the interface. For more information, see [Customize UI features by using extensibility interfaces](../vsto/customizing-ui-features-by-using-extensibility-interfaces.md). **Note:**  To customize the ribbon UI, you can also override the <xref:Microsoft.Office.Tools.AddInBase.CreateRibbonExtensibilityObject%2A> method.|

### Understand the design of the ThisAddIn class
 In projects that target the .NET Framework 4, <xref:Microsoft.Office.Tools.AddIn> is an interface. The `ThisAddIn` class derives from the <xref:Microsoft.Office.Tools.AddInBase> class. This base class redirects all calls to its members to an internal implementation of the <xref:Microsoft.Office.Tools.AddIn> interface in the  Visual Studio Tools for Office runtime .

 In VSTO Add-in projects for Outlook, the `ThisAddIn` class derives from the `Microsoft.Office.Tools.Outlook.OutlookAddIn` class in projects that target the .NET Framework 3.5, and from <xref:Microsoft.Office.Tools.Outlook.OutlookAddInBase> in projects that target the .NET Framework 4. These base classes provide some additional functionality to support form regions. For more information about form regions, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

## Customize the user interface of Microsoft Office applications
 You can programmatically customize the UI of Microsoft Office applications by using a VSTO Add-in. For example, you can customize the ribbon, display a custom task pane, or create a custom form region in Outlook. For more information, see [Office UI customization](../vsto/office-ui-customization.md).

 Visual Studio provides designers and classes that you can use to create custom task panes, ribbon customizations, and Outlook form regions. These designers and classes help to simplify the process of customizing these features. For more information, see [Custom task panes](../vsto/custom-task-panes.md), [Ribbon Designer](../vsto/ribbon-designer.md), and [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

 If you want to customize one of these features in a way that is not supported by the classes and designers, you can also customize these features by implementing an *extensibility interface* in your VSTO Add-in. For more information, see [Customize UI features by using extensibility interfaces](../vsto/customizing-ui-features-by-using-extensibility-interfaces.md).

 In addition, you can modify the UI of Word documents and Excel workbooks by generating host items that extend the behavior of documents and workbooks. This enables you to add managed controls to documents and worksheets. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## Call code in VSTO Add-ins from other solutions
 You can expose objects in your VSTO Add-in to other solutions, including other Office solutions. This is useful if your VSTO Add-in provides a service that you want to enable other solutions to use. For example, if you have a VSTO Add-in for Microsoft Office Excel that performs calculations on financial data from a web service, other solutions can perform these calculations by calling into the Excel VSTO Add-in at run time.

 For more information, see [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md).

## Related content
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md)
- [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md)
- [Customize UI features By using extensibility interfaces](../vsto/customizing-ui-features-by-using-extensibility-interfaces.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
