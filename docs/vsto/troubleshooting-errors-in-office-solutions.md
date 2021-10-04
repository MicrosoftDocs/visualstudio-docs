---
title: "Troubleshoot errors in Office solutions"
description: Learn how you can troubleshoot errors that may occur while you develop Microsoft Office solutions in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "troubleshooting"
f1_keywords:
  - "VST.Project.DesignerDisabled"
  - "VST.Designer.CannotActivate"
  - "VST.Project.ExcelBusy"
  - "VST.SelectDocWizard.AlreadyCustomized"
  - "VST.SelectDocWizard.DocPath"
  - "VST.Project.CannotOpen"
  - "VST.Designer.ErrorsOccurred"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "troubleshooting [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Troubleshoot errors in Office solutions
  You might encounter issues when you perform the following tasks while you develop Office solutions in Visual Studio:

- [Create, upgrade, and open projects](#creating)

- [Use the designers](#designers)

- [Write code](#code)

- [Build projects](#building)

- [Debug projects](#debugging)

## <a name="creating"></a> Create, upgrade, and open projects
 You might encounter the following errors when you create or open Office projects.

### The project cannot be created
 An error occurred when you tried to create or open an Office project, but Visual Studio did not have enough information to determine the cause. Try closing your project, exiting Visual Studio, and starting again.

 If you are trying to create a document-level project, it is possible that another document with the same name as the document in the new project is already open in Excel or Word. Make sure that all other instances of Excel or Word are closed.

### Control properties are lost when you create a new project based on a document from an existing project
 If you create a new Office project based on a document from an existing project, the properties for any controls that are on the document are not copied into the new project. You must reset the properties for any preexisting controls manually. Alternatively, you can preserve the control properties by creating a copy of the existing project instead of creating a new project, or by loading the existing project into the new solution (in the designer) and copying and pasting the controls from the existing document to the new document.

### Errors when you create an Excel workbook project based on an existing workbook
 If you create a new Excel workbook project based on an existing workbook, you might see a combination of the following errors.

 From Excel: "Privacy warning: This document contains macros, ActiveX controls, XML expansion pack information, or Web components. These may include personal information that cannot be removed by the Document Inspector."

 From Visual Studio: "Designer failed to load correctly."

 These errors can occur you try to create a project that is based on a workbook that had its personal information removed by using the Document Inspector. To avoid this error, perform the following steps before creating the project.

1. Open the workbook in Excel.

2. In Excel, open the Trust Center.

3. On the **Privacy Options** tab clear the **Remove personal information from file properties on save** check box.

4. Save the workbook and close Excel.

### Cannot open a project after migration
 After an Office solution is migrated to Microsoft Office 2010, the project cannot be opened on a development computer with only the 2007 Microsoft Office system installed. You may see the following errors.

 "One or more projects in the solution were not loaded correctly. Please see the Output Window for details."

 "Cannot create the project because the application associated with this project type is not installed on this computer. You must install the Microsoft Office application that is associated with this project type."

 To resolve this issue, edit the *.vbproj* or *.csproj* file. For a Word project, replace HostPackage="{763FDC83-64E5-4651-AC9B-28C4FEB985A1}" with HostPackage="{6CE98B71-D55A-4305-87A8-0D6E368D9600}". For an Excel project, replace HostPackage="{B284B16A-C42C-4438-BDCD-B72F4AC43CFB}" with HostPackage="{825100CF-0BA7-47EA-A084-DCF3308DAF74}". For an Outlook project, replace HostPackage="{D2B20FF5-A6E5-47E1-90E8-463C6860CB05}" with HostPackage="{20A848B8-E01F-4801-962E-25DB0FF57389}".

 Alternatively, ensure that migrated projects are only opened on development computers with Microsoft Office 2010 already installed.

### Errors in upgraded Office 2003 document-level projects that contain Windows Forms controls
 If you upgrade a Microsoft Office 2003 document-level project, and the document contains Windows Forms controls, the upgraded project might have compile or runtime errors. To avoid this issue, install the Visual Studio 2005 Tools for Office Second Edition Runtime on the development computer before you upgrade the project. This version of the runtime is available as a redistributable package from the Microsoft Download Center at Microsoft Visual Studio 2005 Tools for Office Second Edition Runtime (VSTO 2005 SE) (x86).

 After you finish upgrading the project, you can uninstall the Visual Studio 2005 Tools for Office Second Edition Runtime from the development computer if it is not being used by any other Office solutions.

## <a name="designers"></a> Use the designers
 You might encounter the following errors when you work with the document, workbook, or worksheet designer in document-level projects.

### Designer failed to load correctly
 Visual Studio cannot open the designer in the following cases:

- Excel or Word is already open and is displaying a modal dialog box. To open the designer, check to see if Excel or Word has a modal dialog box open, and close any open modal dialog boxes. If there are no modal dialog boxes open, there might be some other action required before Excel or Word responds.

- The project is currently being debugged. To open the designer, stop or finish debugging.

- An Excel VSTO Add-in that is installed on the development computer is displaying a dialog box when Excel starts. To create an Excel document-level project, you must first disable the VSTO Add-in.

### Controls appear as black rectangles on the document or worksheet
 If you group controls on a document or worksheet, Visual Studio no longer recognizes the controls. Grouped controls cannot be accessed in the **Properties** window and they appear as black rectangles on the document or worksheet. You must ungroup the controls in order to restore their functionality.

### Controls on a Word template are not visible in Visual Studio
 If you open a Word template in the Visual Studio designer, controls on the template that are not in line with text might not be visible. This is because Visual Studio opens Word templates in **Normal** view. To view the controls, click the **View** menu, point to **Microsoft Office Word View** and then click **Print Layout**.

### Insert clip art command does nothing in the Visual Studio designer
 When Excel or Word is open in the Visual Studio designer, clicking the **Clip Art** button on the **Illustrations** tab in the ribbon does not open the **Clip Art** task pane. To add clip art, you must open the copy of the workbook or document that is in the main project folder (not the copy that is in the *\bin* folder) outside of Visual Studio, add the clip art, and then save the workbook or document.

## <a name="code"></a> Write code
 You might encounter the following errors when you write code in Office projects.

### Some events of Office objects are not accessible when using C\#
 In some cases, you might see a compiler error like the following when you try to access a particular event of an instance of an Office primary interop assembly (PIA) type in a Visual C# project.

 "Ambiguity between 'Microsoft.Office.Interop.Excel._Application.NewWorkbook' and 'Microsoft.Office.Interop.Excel.AppEvents_Event.NewWorkbook'"

 This error means that you are trying to access an event that has the same name as another property or method of the object. To access the event, you must cast the object to its *event interface*.

 Office PIA types that have events implement two interfaces: a core interface with all the properties and methods, and an event interface that contains the events that are exposed by the object. These event interfaces use the naming convention *objectname*Events*n*_Event, such as <xref:Microsoft.Office.Interop.Excel.AppEvents_Event> and <xref:Microsoft.Office.Interop.Word.ApplicationEvents2_Event>. If you cannot access an event that you expect to find on an object, cast the object to its event interface.

 For example, <xref:Microsoft.Office.Interop.Excel.Application> objects have a <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.NewWorkbook> event and a <xref:Microsoft.Office.Interop.Excel._Application.NewWorkbook%2A> property. To handle the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.NewWorkbook> event, cast the <xref:Microsoft.Office.Interop.Excel.Application> to the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event> interface. The following code example demonstrates how to do this in a document-level project for Excel.

 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreTroubleshootingExcelCS/ThisWorkbook.cs" id="Snippet1":::

 For more information about event interfaces in the Office PIAs, see [Overview of classes and interfaces in the Office primary interop assemblies](/previous-versions/office/office-12//ms247299(v=office.12)).

### Cannot reference Office PIA classes in projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)]
 In projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)], code that references a class that is defined in an Office PIA will not compile by default. Classes in the PIAs use the naming convention *objectname*Class, such as <xref:Microsoft.Office.Interop.Word.DocumentClass> and <xref:Microsoft.Office.Interop.Excel.WorkbookClass>. For example, the following code from a Word VSTO Add-in project will not compile.

```vb
Dim document As Word.DocumentClass = Globals.ThisAddIn.Application.ActiveDocument
```

```csharp
Word.DocumentClass document = (Word.DocumentClass) Globals.ThisAddIn.Application.ActiveDocument;
```

 This code results in the following compile errors:

- Visual Basic: "Reference to class 'DocumentClass' is not allowed when its assembly is linked using No-PIA mode."

- Visual C#: "Interop type 'Microsoft.Office.Interop.Word.DocumentClass' cannot be embedded. Use the applicable interface instead."

  To resolve this error, modify the code to reference the corresponding interface instead. For example, rather than reference a <xref:Microsoft.Office.Interop.Word.DocumentClass> object, reference an instance of the <xref:Microsoft.Office.Interop.Word.Document> interface instead.

```vb
Dim document As Word.Document = Globals.ThisAddIn.Application.ActiveDocument
```

```csharp
Word.Document document = Globals.ThisAddIn.Application.ActiveDocument;
```

 Projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)], automatically embed all interop types from the Office PIAs by default. This compile error occurs because the embedded interop types feature only works with interfaces, not classes. For more information about interfaces and classes in the Office PIAs, see [Overview of classes and interfaces in the Office primary interop assemblies](/previous-versions/office/office-12/ms247299(v=office.12)). For more information about the embedded interop types feature in Office projects, see [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md).

### References to Office classes are not recognized
 Some class names, for example Application, are in multiple namespaces such as <xref:Microsoft.Office.Interop.Word> and <xref:System.Windows.Forms>. For this reason, the **Imports**/**using** statement at the top of the project templates includes a shorthand qualifying constant, for example:

 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreTroubleshootingWordCS/ThisDocument.cs" id="Snippet2":::
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreTroubleshootingWordVB/ThisDocument.vb" id="Snippet2":::

 This usage of the **Imports**/**using** statement requires that you differentiate references to Office classes with the Word or Excel qualifier, for example:

 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreTroubleshootingWordCS/ThisDocument.cs" id="Snippet3":::
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreTroubleshootingWordVB/ThisDocument.vb" id="Snippet3":::

 You will get errors if you use an unqualified declaration, for example:

 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreTroubleshootingWordCS/ThisDocument.cs" id="Snippet4":::
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreTroubleshootingWordVB/ThisDocument.vb" id="Snippet4":::

 Even though you have imported the Word or Excel namespace and have access to all the classes inside it, you must fully qualify all the types with Word or Excel to remove namespace ambiguity.

## <a name="building"></a> Build projects
 You might encounter the following errors when you build Office projects.

### Cannot build a document-level project that is based on a document with restricted permissions
 Visual Studio cannot build document-level projects if the document has restricted permissions. If your project contains a document that has restricted permissions, the project will not compile, and you will receive the following message in the **Error List** window.

 "Failed to add the customization."

 If you want to include a document that has restricted permissions, use an unrestricted document while you develop and build the solution. Then, apply the restricted permissions to the document in the publish location, after you publish the solution.

### Compiler errors occur after a NamedRange control is deleted
 If you delete a <xref:Microsoft.Office.Tools.Excel.NamedRange> control from a worksheet that is not the active worksheet in the designer, the auto-generated code might not be removed from your project and compiler errors might occur. To make sure the code is removed, you should always select the worksheet that contains the <xref:Microsoft.Office.Tools.Excel.NamedRange> control to make it the active worksheet before deleting the control. If auto-generated code is not deleted when you delete the control, you can cause the designer to delete the code by activating the worksheet and making a change so that the worksheet becomes marked as modified. When you rebuild the project, the code is removed.

## <a name="debugging"></a> Debug projects
 You might encounter the following errors when you debug Office projects.

### Prompt to uninstall appears when you publish and install a solution on the development computer
 When you debug an Office solution, you might see the following error.

 "The customization cannot be installed because another version is currently installed and cannot be upgraded from this location."

 This error indicates that you have previously published and installed the Office solution on your development computer. To prevent the message from appearing, uninstall the solution from the list of installed programs on the computer before you debug the solution. Alternatively, you can create another user account on your development computer to test the installation of the published solution.

### Document-level projects created at UNC network locations do not run from Visual Studio
 If you create a document-level project for Excel or Word at a UNC network location, you must add the location of the document to the trusted locations list in Excel or Word. Otherwise, the customization will not be loaded when you try to run or debug the project in Visual Studio. For more information about trusted locations, see [Grant trust to documents](../vsto/granting-trust-to-documents.md).

### Threads are not stopped correctly after debugging
 Office projects in Visual Studio follow a thread naming convention that enables the debugger to close the program correctly. If you create threads in your solution, you should name each thread with the prefix VSTA_ to ensure that these threads are handled correctly when you stop debugging. For example, you might set the `Name` property of a thread that waits for a network event to **VSTA_NetworkListener**.

### Cannot run or debug any Office solution on the development computer
 If you cannot run or develop an Office project on your development computer, you may see the following error message.

 "Customization could not be loaded because the application domain could not be created."

 Visual Studio uses Fusion, the .NET Framework assembly loader, to cache the assemblies before loading Office solutions. Ensure that Visual Studio can write to the Fusion cache, and try again. For more information, see [Shadow copy assemblies](/dotnet/framework/app-domains/shadow-copy-assemblies).

### Error when stopping the debugger in a document-level project after using Edit and Continue
 If you use **Edit** and **Continue** to make changes to code in a document-level project for Excel or Word while the project is in break mode, you might see a dialog box with the following error message if you subsequently stop the debugger.

 "Terminating the process in its current state can cause undesired results including the loss of data and system instability."

 Whether you click **Yes** or **No** in the dialog box, Visual Studio terminates the Excel or Word process and stops the debugger. To stop debugging the project without displaying this dialog box, exit Excel or Word directly rather than stopping the debugger in Visual Studio.

## See also
- [Troubleshoot Office solutions](../vsto/troubleshooting-office-solutions.md)
- [Troubleshoot Office solution security](../vsto/troubleshooting-office-solution-security.md)
- [Troubleshoot Office solution deployment](../vsto/troubleshooting-office-solution-deployment.md)
- [Visual Studio troubleshooting](/troubleshoot/visualstudio/welcome-visual-studio/)
