---
title: "Adding Controls to Office Documents at Run Time | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office documents [Office development in Visual Studio, Windows Forms controls"
  - "host controls [Office development in Visual Studio], adding"
  - "Windows Forms controls [Office development in Visual Studio], adding"
  - "Office documents [Office development in Visual Studio, host controls"
  - "user controls [Office development in Visual Studio], adding at run time"
  - "documents [Office development in Visual Studio], Windows Forms controls"
  - "document-level customizations [Office development in Visual Studio], host controls"
  - "documents [Office development in Visual Studio], host controls"
  - "document-level customizations [Office development in Visual Studio], Windows Forms controls"
  - "controls [Office development in Visual Studio], adding at run time"
  - "helper methods [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Adding Controls to Office Documents at Run Time
  You can add controls to a Microsoft Office Word document and Microsoft Office Excel workbook at run time. You can also remove them at run time. Controls that you add or remove at run time are called *dynamic controls*.  
  
 [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]  
  
 This topic describes the following:  
  
-   [Managing controls at run time by using the control collections](#ControlsCollection).  
  
-   [Adding host controls to documents](#HostControls).  
  
-   [Adding Windows Forms controls to documents](#WindowsForms).  
  
 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [How Do I: Add Controls to a Document Surface at Runtime?](http://go.microsoft.com/fwlink/?LinkId=132782).  
  
##  <a name="ControlsCollection"></a> Managing Controls at Run Time by Using the Control Collections  
 To add, get, or remove controls at run time, use helper methods of <xref:Microsoft.Office.Tools.Excel.ControlCollection> and <xref:Microsoft.Office.Tools.Word.ControlCollection> objects.  
  
 The way that you access these objects depends on the type of project you are developing:  
  
-   In a document-level project for Excel, use the <xref:Microsoft.Office.Tools.Excel.Worksheet.Controls%2A> property of the `Sheet1`, `Sheet2`, and `Sheet3` classes. For more information about these classes, see [Worksheet Host Item](../vsto/worksheet-host-item.md).  
  
-   In a document-level project for Word, use the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of the `ThisDocument` class. For more information about this class, see [Document Host Item](../vsto/document-host-item.md).  
  
-   In an VSTO Add-in project for Excel or Word, use the Controls property of a <xref:Microsoft.Office.Tools.Excel.Worksheet> or <xref:Microsoft.Office.Tools.Word.Document> that you generate at run time. For more information about generating these objects at run time, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
### Adding Controls  
 The <xref:Microsoft.Office.Tools.Excel.ControlCollection> and <xref:Microsoft.Office.Tools.Word.ControlCollection> types include helper methods that you can use to add host controls and common Windows Forms controls to documents and worksheets. Each method name has the format `Add`*control class*, where *control class* is the class name of the control that you want to add. For example, to add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to your document, use the <xref:Microsoft.Office.Tools.Excel.ControlCollection.AddNamedRange%2A> method.  
  
 The following code example adds a <xref:Microsoft.Office.Tools.Excel.NamedRange> to `Sheet1` in a document-level project for Excel.  
  
 [!code-vb[Trin_ExcelWorkbookDynamicControls#3](../vsto/codesnippet/VisualBasic/trin_excelworkbookdynamiccontrols4/ThisWorkbook.vb#3)]
 [!code-csharp[Trin_ExcelWorkbookDynamicControls#3](../vsto/codesnippet/CSharp/trin_excelworkbookdynamiccontrols4/ThisWorkbook.cs#3)]  
  
### Accessing and Deleting Controls  
 You can use the Controls property of a <xref:Microsoft.Office.Tools.Excel.Worksheet> or <xref:Microsoft.Office.Tools.Word.Document> to iterate through all the controls in your document, including the controls you added at design time. Controls that you add at design time are also called *static controls*.  
  
 You can remove dynamic controls by calling the Delete method of the control, or by calling the Remove method of each Controls collection. The following code example uses the <xref:Microsoft.Office.Tools.Excel.ControlCollection.Remove%2A> method to remove a <xref:Microsoft.Office.Tools.Excel.NamedRange> from `Sheet1` in a document-level project for Excel.  
  
 [!code-vb[Trin_ExcelWorkbookDynamicControls#4](../vsto/codesnippet/VisualBasic/trin_excelworkbookdynamiccontrols4/ThisWorkbook.vb#4)]
 [!code-csharp[Trin_ExcelWorkbookDynamicControls#4](../vsto/codesnippet/CSharp/trin_excelworkbookdynamiccontrols4/ThisWorkbook.cs#4)]  
  
 You cannot remove static controls at run time. If you try to use the Delete or Remove method to remove a static control, a <xref:Microsoft.Office.Tools.CannotRemoveControlException> will be thrown.  
  
> [!NOTE]  
>  Do not programmatically remove controls in the `Shutdown` event handler of the document. The UI elements of the document are no longer available when the `Shutdown` event is raised. If you want to remove controls before the document closes, add your code to the event handler for another event, such as <xref:Microsoft.Office.Tools.Word.Document.BeforeClose> or <xref:Microsoft.Office.Tools.Word.Document.BeforeSave> for Word, or <xref:Microsoft.Office.Tools.Excel.Workbook.BeforeClose>, or <xref:Microsoft.Office.Tools.Excel.Workbook.BeforeSave> for Excel.  
  
##  <a name="HostControls"></a> Adding Host Controls to Documents  
 When you programmatically add host controls to documents, you must provide a name that uniquely identifies the control, and you must specify where to add the control on the document. For specific instructions, see the following topics:  
  
-   [How to: Add ListObject Controls to Worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md)  
  
-   [How to: Add NamedRange Controls to Worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)  
  
-   [How to: Add Chart Controls to Worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md)  
  
-   [How to: Add Content Controls to Word Documents](../vsto/how-to-add-content-controls-to-word-documents.md)  
  
-   [How to: Add Bookmark Controls to Word Documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)  
  
 For more information about host controls, see [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md).  
  
 When a document is saved and then closed, all dynamically created host controls are disconnected from their events and they lose their data binding functionality. You can add code to your solution to re-create the host controls when the document is reopened. For more information, see [Persisting Dynamic Controls in Office Documents](../vsto/persisting-dynamic-controls-in-office-documents.md).  
  
> [!NOTE]  
>  Helper methods are not provided for the following host controls, because these controls cannot be added programmatically to documents: <xref:Microsoft.Office.Tools.Excel.XmlMappedRange>, <xref:Microsoft.Office.Tools.Word.XMLNode>, and <xref:Microsoft.Office.Tools.Word.XMLNodes>.  
  
##  <a name="WindowsForms"></a> Adding Windows Forms Controls to Documents  
 When you programmatically add a Windows Forms control to a document, you must provide the location of the control and a name that uniquely identifies the control. The [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] provides helper methods for each control. These methods are overloaded so that you can pass either a range or specific coordinates for the location of the control.  
  
 When a document is saved and then closed, all dynamically created Windows Forms controls are removed from the document. You can add code to your solution to re-create the controls when the document is reopened. If you create dynamic Windows Forms controls by using an VSTO Add-in, the ActiveX wrappers for the controls are left in the document. For more information, see [Persisting Dynamic Controls in Office Documents](../vsto/persisting-dynamic-controls-in-office-documents.md).  
  
> [!NOTE]  
>  Windows Forms controls cannot be programmatically added to protected documents. If you programmatically unprotect a Word document or Excel worksheet to add a control, you must write additional code to remove the control's ActiveX wrapper when the document is closed. The control's ActiveX wrapper is not automatically deleted from protected documents.  
  
### Adding Custom Controls  
 If you want to add a <xref:System.Windows.Forms.Control> that is not supported by the available helper methods, such as a custom user control, use the following methods:  
  
-   For Excel, use one of the <xref:Microsoft.Office.Tools.Excel.ControlCollection.AddControl%2A> methods of a <xref:Microsoft.Office.Tools.Excel.ControlCollection> object.  
  
-   For Word, use one of the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddControl%2A> methods of a <xref:Microsoft.Office.Tools.Word.ControlCollection> object.  
  
 To add the control, pass the <xref:System.Windows.Forms.Control>, a location for the control, and a name that uniquely identifies the control to the AddControl method. The AddControl method returns an object that defines how the control interacts with the worksheet or document. The AddControl method returns a <xref:Microsoft.Office.Tools.Excel.ControlSite> (for Excel) or a <xref:Microsoft.Office.Tools.Word.ControlSite> object (for Word).  
  
 The following code example demonstrates how to use the <xref:Microsoft.Office.Tools.Excel.ControlCollection.AddControl%2A> method to dynamically add a custom user control to a worksheet in a document-level Excel project. In this example, the user control is named `UserControl1`, and the <xref:Microsoft.Office.Interop.Excel.Range> is named `range1`. To use this example, run it from a `Sheet`*n* class in the project.  
  
 [!code-vb[Trin_VstcoreProgrammingControlsExcel#2](../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb#2)]
 [!code-csharp[Trin_VstcoreProgrammingControlsExcel#2](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs#2)]  
  
### Using Members of Custom Controls  
 After using one of the AddControl methods to add a control to a worksheet or document, you now have two different control objects:  
  
-   The <xref:System.Windows.Forms.Control> that represents the custom control.  
  
-   The ControlSite, OLEObject, or OLEControl object that represents the control after it was added to the worksheet or document.  
  
 Many properties and methods are shared between these controls. It is important that you access these members through the appropriate control:  
  
-   To access members that belong only to the custom control, use the <xref:System.Windows.Forms.Control>.  
  
-   To access members that are shared by the controls, use the ControlSite, OLEObject, or OLEControl object.  
  
 If you access a shared member from the <xref:System.Windows.Forms.Control>, it might fail without warning or notification, or it can produce invalid results. Always use methods or properties of the ControlSite, OLEObject, or OLEControl object unless the method or property needed is not available; only then should you reference the <xref:System.Windows.Forms.Control>.  
  
 For example, both the <xref:Microsoft.Office.Tools.Excel.ControlSite> class and the <xref:System.Windows.Forms.Control> class have a Top property. To get or set the distance between the top of the control and the top of the document, use the <xref:Microsoft.Office.Tools.Excel.ControlSite.Top%2A> property of the <xref:Microsoft.Office.Tools.Excel.ControlSite>, not the <xref:System.Windows.Forms.Control.Top%2A> property of the <xref:System.Windows.Forms.Control>.  
  
 [!code-vb[Trin_VstcoreProgrammingControlsExcel#3](../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb#3)]
 [!code-csharp[Trin_VstcoreProgrammingControlsExcel#3](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs#3)]  
  
## See Also  
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [Persisting Dynamic Controls in Office Documents](../vsto/persisting-dynamic-controls-in-office-documents.md)   
 [How to: Add ListObject Controls to Worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md)   
 [How to: Add NamedRange Controls to Worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)   
 [How to: Add Chart Controls to Worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md)   
 [How to: Add Content Controls to Word Documents](../vsto/how-to-add-content-controls-to-word-documents.md)   
 [How to: Add Bookmark Controls to Word Documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)   
 [Windows Forms Controls on Office Documents Overview](../vsto/windows-forms-controls-on-office-documents-overview.md)   
 [How to: Add Windows Forms Controls to Office Documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)   
