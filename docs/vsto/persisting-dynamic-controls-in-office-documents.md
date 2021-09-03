---
title: "Persist dynamic controls in Office documents"
description: Learn how you can add code to your solution to re-create persistent dynamic controls when a user reopens a closed document.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office documents [Office development in Visual Studio, Windows Forms controls"
  - "Office documents [Office development in Visual Studio, host controls"
  - "controls [Office development in Visual Studio], persisting in the document"
  - "Windows Forms controls [Office development in Visual Studio], persisting in the document"
  - "documents [Office development in Visual Studio], Windows Forms controls"
  - "documents [Office development in Visual Studio], host controls"
  - "host controls [Office development in Visual Studio], persisting in the document"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Persist dynamic controls in Office documents

Controls that are added at run time are not persisted when the document or workbook is saved and closed. The exact behavior is different for host controls and Windows Forms controls. In both cases, you can add code to your solution to re-create the controls when the user reopens the document.

Controls that you add to documents at run time are called *dynamic controls*. For more information about dynamic controls, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

[!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]

## Persist host controls in the document

When a document is saved and then closed, all dynamic host controls are removed from the document. Only the underlying native Office objects remain behind. For example, a <xref:Microsoft.Office.Tools.Excel.ListObject?displayProperty=fullName> host control becomes a <xref:Microsoft.Office.Interop.Excel.ListObject?displayProperty=fullName>. The native Office objects are not connected to the host control events, and they do not have the data binding functionality of the host control.

The following table lists the native Office object that is left behind in a document for each type of host control.

|Host control type|Native Office object type|
|-----------------------|-------------------------------|
|<xref:Microsoft.Office.Tools.Excel.Chart>|<xref:Microsoft.Office.Interop.Excel.Chart>|
|<xref:Microsoft.Office.Tools.Excel.ListObject>|<xref:Microsoft.Office.Interop.Excel.ListObject>|
|<xref:Microsoft.Office.Tools.Excel.NamedRange>|<xref:Microsoft.Office.Interop.Excel.Range>|
|<xref:Microsoft.Office.Tools.Word.Bookmark>|<xref:Microsoft.Office.Interop.Word.Bookmark>|
|<xref:Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.ContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.DatePickerContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.DropDownListContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.GroupContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.PictureContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.PlainTextContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.RichTextContentControl>|<xref:Microsoft.Office.Interop.Word.ContentControl>|

### Re-create dynamic host controls when documents are opened

You can re-create dynamic host controls in place of existing native controls every time a user opens the document. Creating host controls in this manner when a document is opened simulates the experience that users might expect.

To re-create a host control for Word, or a <xref:Microsoft.Office.Tools.Excel.NamedRange> or <xref:Microsoft.Office.Tools.Excel.ListObject> host control for Excel, use an `Add`\<*control class*> method of an <xref:Microsoft.Office.Tools.Excel.ControlCollection?displayProperty=fullName> or <xref:Microsoft.Office.Tools.Word.ControlCollection?displayProperty=fullName> object. Use a method that has a parameter for the native Office object.

For example, if you want to create a <xref:Microsoft.Office.Tools.Excel.ListObject?displayProperty=fullName> host control from an existing native <xref:Microsoft.Office.Interop.Excel.ListObject?displayProperty=fullName> when the document is opened, use the <xref:Microsoft.Office.Tools.Excel.ControlCollection.AddListObject%2A> method and pass in the existing <xref:Microsoft.Office.Interop.Excel.ListObject>. The following code example demonstrates this in a document-level project for Excel. The code re-creates a dynamic <xref:Microsoft.Office.Tools.Excel.ListObject> that is based on an existing <xref:Microsoft.Office.Interop.Excel.ListObject> named `MyListObject` in the `Sheet1` class.

:::code language="csharp" source="../vsto/codesnippet/CSharp/trin_excelworkbookdynamiccontrols4/Sheet1.cs" id="Snippet6":::
:::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_excelworkbookdynamiccontrols4/Sheet1.vb" id="Snippet6":::

### Re-create chart

To re-create a <xref:Microsoft.Office.Tools.Excel.Chart?displayProperty=fullName> host control, you must first delete the native <xref:Microsoft.Office.Interop.Excel.Chart?displayProperty=fullName>, and then re-create the <xref:Microsoft.Office.Tools.Excel.Chart?displayProperty=fullName> by using the <xref:Microsoft.Office.Tools.Excel.ControlCollection.AddChart%2A> method. There is no `Add`\<*control class*> method that enables you to create a new <xref:Microsoft.Office.Tools.Excel.Chart?displayProperty=fullName> based on an existing <xref:Microsoft.Office.Interop.Excel.Chart?displayProperty=fullName>.

If you do not first delete the native <xref:Microsoft.Office.Interop.Excel.Chart>, then you'll create a second, duplicate chart when you re-create the <xref:Microsoft.Office.Tools.Excel.Chart?displayProperty=fullName>.

## Persist Windows Forms controls in documents

When a document is saved and then closed, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] automatically removes all dynamically created Windows Forms controls from the document. However, the behavior is different for document-level and VSTO Add-in projects.

In document-level customizations, the controls and their underlying ActiveX wrappers (which are used to host the controls on the document) are removed the next time the document is opened. There is no indication that the controls were ever there.

In VSTO Add-ins, the controls are removed, but the ActiveX wrappers remain in the document. The next time the user opens the document, the ActiveX wrappers are visible. In Excel, the ActiveX wrappers display images of the controls as they appeared the last time the document was saved. In Word, the ActiveX wrappers are invisible unless the user clicks on them, in which case they display a dotted line that represents the border of the controls. There are several ways you can remove the ActiveX wrappers. For more information, see [Remove ActiveX Wrappers in an Add-in](#removingActiveX).

### Re-create Windows Forms controls when documents are opened

You can re-create deleted Windows Forms controls when the user reopens the document. To do this, your solution must perform the following tasks:

1. Store information about the size, location, and state of the controls when the document is saved or closed. In a document-level customization, you can save the data to the data cache in the document. In a VSTO Add-in, you can save the data to a custom XML part in the document.

2. Re-create the controls in an event that is raised when the document is opened. In document-level projects, you can do this in the `Sheet`*n*`_Startup` or `ThisDocument_Startup` event handlers. In VSTO Add-in projects, you can do this in the event handlers for the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookOpen> or <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> events.

### <a name="removingActiveX"></a> Remove ActiveX wrappers in an Add-in

When you add dynamic Windows Forms controls to documents by using a VSTO Add-in, you can prevent the ActiveX wrappers for the controls from appearing in the document the next time it is opened in the following ways.

#### Remove ActiveX wrappers when the document is opened

To remove all ActiveX wrappers, call the `GetVstoObject` method to generate a host item for the <xref:Microsoft.Office.Interop.Word.Document> or <xref:Microsoft.Office.Interop.Excel.Workbook> that represents the newly opened document. For example, to remove all ActiveX wrappers from a Word document, you can call the `GetVstoObject` method to generate a host item for the <xref:Microsoft.Office.Interop.Word.Document> object that is passed to the event handler for the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> event.

This procedure is useful when you know that the document will be opened only on computers that have the VSTO Add-in installed. If the document might be passed to other users who do not have the VSTO Add-in installed, consider removing the controls before closing the document instead.

The following code example demonstrates how to call the `GetVstoObject` method when the document is opened.

:::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb" id="Snippet11":::
:::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet11":::

Although the `GetVstoObject` method is used primarily to generate a new host item at run time, this method also clears all ActiveX wrappers from the document the first time it is called for a specific document. For more information about how to use the `GetVstoObject` method, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

If your VSTO Add-in creates dynamic controls when the document is opened, your VSTO Add-in will already call the `GetVstoObject` method as part of the process to create the controls. You do not need to add a separate call to the `GetVstoObject` method to remove the ActiveX wrappers in this scenario.

#### Remove the dynamic controls before the document is closed

Your VSTO Add-in can explicitly remove each dynamic control from the document before the document is closed. This procedure is useful for documents that might be passed to other users who do not have the VSTO Add-in installed.

The following code example demonstrates how to remove all of the Windows Forms controls from a Word document when the document is closed.

:::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb" id="Snippet10":::
:::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet10":::

## See also

- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
