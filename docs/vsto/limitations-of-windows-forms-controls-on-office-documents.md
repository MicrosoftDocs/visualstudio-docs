---
title: "Limitations of Windows Forms controls on Office documents"
description: Learn about the limitations of Windows Forms control methods and properties on Microsoft Office documents. 
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office documents [Office development in Visual Studio, Windows Forms controls"
  - "Windows Forms controls [Office development in Visual Studio], ActiveX legacy"
  - "ActiveX controls [Office development in Visual Studio]"
  - "Windows Forms controls [Office development in Visual Studio], limitations"
  - "controls [Office development in Visual Studio], Windows Forms controls"
  - "Windows Forms controls [Office development in Visual Studio], unsupported properties and methods"
  - "Toolbox [Office development in Visual Studio], unsupported controls"
  - "user controls [Office development in Visual Studio], grouping controls"
  - "Windows Forms controls [Office development in Visual Studio], Toolbox"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Limitations of Windows Forms controls on Office documents

There are some differences between Windows Forms controls that are added to Microsoft Office Word documents or Microsoft Office Excel worksheets, and Windows Forms controls that are added to Windows Forms. For example, when you add a <xref:Microsoft.Office.Tools.Word.Controls.Button> control to a document, properties such as <xref:System.Windows.Forms.Control.Dock>, <xref:System.Windows.Forms.Control.Anchor>, and <xref:System.Windows.Forms.Control.TabIndex> do not behave as you might expect.

Many of these differences are caused by the way that Windows Forms controls are hosted on documents. When a Windows Forms control is added to a document, the  Visual Studio Tools for Office runtime  embeds an ActiveX control that then hosts the Windows Forms control in the document. The Windows Forms control is not embedded directly in the document.

[!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]

## Limitations of methods and properties of Windows Forms controls

There are a number of methods and properties of Windows Forms controls that do not work the same way on a document as they would on a Windows Form and, therefore, it is recommended that they not be used. For example, setting properties such as <xref:System.Windows.Forms.Control.Dock> and <xref:System.Windows.Forms.Control.Anchor> only affects the position of the control with respect to the container ActiveX control, rather than the document. The following is a list of unsupported methods and properties of Windows Forms controls for Word and Excel:

- Unsupported properties of Excel controls:

  - <xref:System.Windows.Forms.Control.Anchor>
  - <xref:System.Windows.Forms.Control.Dock>
  - <xref:System.Windows.Forms.Control.Location>
  - <xref:System.Windows.Forms.Control.TabIndex>
  - <xref:System.Windows.Forms.Control.TabStop>
  - <xref:System.Windows.Forms.Control.TopLevelControl>

- Unsupported methods and properties of Word controls:

  - <xref:System.Windows.Forms.Control.Hide%2A>
  - <xref:System.Windows.Forms.Control.Show%2A>
  - <xref:System.Windows.Forms.Control.Anchor>
  - <xref:System.Windows.Forms.Control.Dock>
  - <xref:System.Windows.Forms.Control.Location>
  - <xref:System.Windows.Forms.Control.TabIndex>
  - <xref:System.Windows.Forms.Control.TabStop>
  - <xref:System.Windows.Forms.Control.TopLevelControl>
  - <xref:System.Windows.Forms.Control.Visible>

You also cannot set the <xref:System.Windows.Forms.Control.Left> or <xref:System.Windows.Forms.Control.Top> property of Windows Forms controls that are in line with text on a Word document. Windows Forms controls are added in line with text in the following cases:

- You programmatically add a control to a Word document and use a method that specifies a range for the location.

- You add a Windows Forms control to a Word document at design time. You can change this by modifying the control in the designer.

## Differences in Windows Forms controls on Office documents

Windows Forms controls generally have the same behavior on an Office document as they do on a Windows Form, but some differences do exist. The following table describes the differences that exist for Windows Forms controls on Office documents.

|Functionality|Difference|
|-------------------|----------------|
|Control tab order|You cannot tab through controls placed on an Excel worksheet or Word document.|
|Control grouping|You cannot use a <xref:System.Windows.Forms.GroupBox> control to contain other controls on an Office document. When you add multiple radio buttons directly to the document, the radio buttons are not mutually exclusive. You can write code to make the radio buttons mutually exclusive; however, the preferred approach is to add the radio buttons to a user control and then add the user control to the document. For more information, see the Word Controls Sample or Excel Controls Sample at [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).|
|Control type|Windows Forms controls used on documents are wrapped in a class provided by the  Visual Studio Tools for Office runtime  that gives the controls additional functionality specific to the Excel worksheet or Word document. For example, if you have a **Button** control on an Excel worksheet, be sure to specify the type as <xref:Microsoft.Office.Tools.Excel.Controls.Button> rather than <xref:System.Windows.Forms.Button> when referencing or casting the object.|
|Control position and size|The size and position of the control is determined by properties that are part of the container ActiveX control. The ActiveX control properties take different values than the equivalent properties of a Windows Forms control. When you set the `Top`, `Left`, `Height`, or `Width` properties of a control, it is measured in points, rather than pixels.|
|Control position on Word documents|If you add controls to a flow-based layout, keep in mind that the controls will flow with the content as the content changes. You cannot anchor the control to a paragraph when you drag it from the **Toolbox** because the control is added to the Word document in line with text. If you use another method to add the control, such as double-clicking the control, the control is inserted according to the Word option you have set for inserting pictures.<br /><br /> You cannot set the `Left` or `Top` property of a control that is inline with text.<br /><br /> You cannot place controls in a header or footer, or within a subdocument.|
|Control events|When the control is selected, it raises events in the following order:<br /><br /> 1.  `Enter`<br />2.  `GotFocus`<br /><br /> When the control is deselected, it raises events in the following order:<br /><br /> 1.  `Leave`<br />2.  `Validating`<br />3.  `Validated`<br />4.  `LostFocus`|
|Control scaling|When you change the zoom setting of a document to anything other than 100%, controls are disabled, although they appear to scale with the document. For example, if you click a button when your document is at 130% zoom, it will show a message that the control has been disabled until zoom is set to 100%. The controls will function correctly when you change the zoom to 100%.|
|Control property values|Although the properties of controls on a Windows Form are set to an integer value, they are set to a single for controls on a Word document. In Excel, the property values of controls are set to a double. If the `Height` and `Width` property of a control on a worksheet exceeds the size of the worksheet or screen, the value is truncated.|
|Control resizing|If you resize a control on the document using one of the eight sizing handles, the new control dimensions are not reflected in the **Properties** window until the control is reselected.|
|Control behavior|Controls on an Excel worksheet might behave unpredictably when the worksheet window is split. For example, access to a <xref:Microsoft.Office.Tools.Excel.Controls.TextBox> on the worksheet might only be available in one of the windows.|
|Control naming|You cannot use reserved words to name controls. For example, if you add a <xref:Microsoft.Office.Tools.Excel.Controls.Button> to a worksheet and change the name to **System**, errors occur when you build the project.|
|Programmatically adding controls|Do not use the control's constructor to add a control to your document at run time. Instead, use the helper methods provided by the  Visual Studio Tools for Office runtime . For example, use the <xref:Microsoft.Office.Tools.Excel.ControlExtensions.AddButton%2A> method to add a button to a worksheet. If you want to add a control that is not supported by these helper methods, you can use the `AddControl` method. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).|
|Copying controls|If you copy a Windows Forms control and paste it into a document at run time, an empty container ActiveX control is pasted into the document. The Windows Forms control does not appear in the new location, and code behind the original control is not copied to the container ActiveX control.|

## Limitations in document-level projects

Some limitations of using Windows Forms controls on documents are unique to document-level projects.

### Control support at design time

Certain Windows Forms controls are removed from the **Toolbox** when an Excel worksheet or Word document is open in the Visual Studio designer. This is because of technical limitations or because the functionality is already available within Word or Excel. Excel and Word projects support all of the Windows Forms controls and other components that appear in the **Toolbox** when the document has focus, and you can also add third-party controls to a worksheet or document.

> [!NOTE]
> All controls are removed from the **Toolbox** when a document is protected. For information about document protection, see [Document protection in document-level solutions](/previous-versions/visualstudio/visual-studio-2017/vsto/document-protection-in-document-level-solutions).

> [!NOTE]
> Third-party controls must have the <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute set to **true** in order to be used in an Office solution.

The following controls and components are not available in the **Toolbox**:

- <xref:System.Windows.Forms.BindingNavigator>

- <xref:System.Windows.Forms.ContextMenuStrip>

- <xref:System.Windows.Forms.DataGrid>

- <xref:System.DirectoryServices.DirectoryEntry>

- <xref:System.DirectoryServices.DirectorySearcher>

- <xref:System.Windows.Forms.ErrorProvider>

- <xref:System.Diagnostics.EventLog>

- <xref:System.IO.FileSystemWatcher>

- <xref:System.Windows.Forms.FlowLayoutPanel>

- <xref:System.Windows.Forms.GroupBox>

- <xref:System.Windows.Forms.MainMenu>

- <xref:System.Windows.Forms.MenuStrip>

- <xref:System.Messaging.MessageQueue>

- <xref:System.Windows.Forms.NotifyIcon>

- <xref:System.Windows.Forms.PageSetupDialog>

- <xref:System.Windows.Forms.Panel>

- <xref:System.Diagnostics.PerformanceCounter>

- <xref:System.Windows.Forms.PrintDialog>

- <xref:System.Drawing.Printing.PrintDocument>

- <xref:System.Windows.Forms.PrintPreviewControl>

- <xref:System.Diagnostics.Process>

- <xref:System.Windows.Forms.RichTextBox>

- <xref:System.IO.Ports.SerialPort>

- <xref:System.ServiceProcess.ServiceController>

- <xref:System.Windows.Forms.SplitContainer>

- <xref:System.Windows.Forms.Splitter>

- <xref:System.Windows.Forms.StatusBar>

- <xref:System.Windows.Forms.StatusStrip>

- <xref:System.Windows.Forms.TabControl>

- <xref:System.Windows.Forms.TableLayoutPanel>

- <xref:System.Timers.Timer>

- <xref:System.Windows.Forms.Timer>

- <xref:System.Windows.Forms.ToolBar>

- <xref:System.Windows.Forms.ToolStrip>

- <xref:System.Windows.Forms.ToolStripContainer>

- <xref:System.Windows.Forms.ToolStripDropDown>

- <xref:System.Windows.Forms.ToolStripDropDownMenu>

- <xref:System.Windows.Forms.ToolStripPanel>

### Support for legacy ActiveX controls

If you create a document-level Office project that uses an existing Word document or Excel workbook that contains ActiveX controls, the functionality of the ActiveX controls is not lost; however, there is no support for adding new ActiveX controls to your documents from within Visual Studio. For example, if your Word document has a button from the **Control** toolbox that runs a Visual Basic for Applications (VBA) macro, it will continue to run the macro after the document has been used in an Office project. However, it is recommended that you remove ActiveX controls and VBA macros and replace them with Windows Forms controls and managed code.

## Related content

- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [How to: Add Windows Forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)
