---
title: "How to: Add ListObject Controls to Worksheets | Microsoft Docs"
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
  - "ListObject control, adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add ListObject Controls to Worksheets
  You can add <xref:Microsoft.Office.Tools.Excel.ListObject> controls to a Microsoft Office Excel worksheet at design time and at run time in document-level projects.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 You can also add <xref:Microsoft.Office.Tools.Excel.ListObject> controls at run time in VSTO Add-in projects.  
  
 This topic describes the following tasks:  
  
-   [Adding ListObject controls at design time](#designtime)  
  
-   [Adding ListObject controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding ListObject controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For more information about <xref:Microsoft.Office.Tools.Excel.ListObject> controls, see [ListObject Control](../vsto/listobject-control.md).  
  
##  <a name="designtime"></a> Adding ListObject Controls at Design Time  
 There are several ways to add <xref:Microsoft.Office.Tools.Excel.ListObject> controls to a worksheet in a document-level project at design time: From within Excel, from the Visual Studio **Toolbox**, and from the **Data Sources** window.  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
#### To use the Ribbon in Excel  
  
1.  On the **Insert** tab, in the **Tables** group, click **Table**.  
  
2.  Select the cell or cells you want to include in the list and click **OK**.  
  
#### To use the Toolbox  
  
1.  From the **Excel Controls** tab of the **Toolbox**, drag a <xref:Microsoft.Office.Tools.Excel.ListObject> to the worksheet.  
  
     The **Add ListObject Control** dialog box appears.  
  
2.  Select the cell or cells you want to include in the list and click **OK**.  
  
     If you do not want to keep the default name, you can change the name in the **Properties** window.  
  
#### To use the Data Sources window  
  
1.  Open the **Data Sources** window and create a data source for your project. For more information, see [Add new connections](../data-tools/add-new-connections.md).  
  
2.  Drag a table from the **Data Sources** window to your worksheet.  
  
     A data-bound <xref:Microsoft.Office.Tools.Excel.ListObject> control is added to the worksheet. For more information, see [Data Binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms).  
  
##  <a name="runtimedoclevel"></a> Adding ListObject Controls at Run Time in a Document-Level Project  
 You can add the <xref:Microsoft.Office.Tools.Excel.ListObject> control dynamically at run time. This enables you to create the host controls in response to events. Dynamically created list objects are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a ListObject control to a worksheet programmatically  
  
1.  In the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler of `Sheet1`, insert the following code to add a <xref:Microsoft.Office.Tools.Excel.ListObject> control to cells **A1** through **A4**.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#2](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs#2)]
     [!code-vb[Trin_VstcoreHostControlsExcel#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb#2)]  
  
##  <a name="runtimeaddin"></a> Adding ListObject Controls at Run Time in an VSTO Add-in project  
 You can add a <xref:Microsoft.Office.Tools.Excel.ListObject> control programmatically to any open worksheet in an VSTO Add-in project. Dynamically created list objects are not persisted in the worksheet as host controls when the worksheet is saved and then closed. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
#### To add a ListObject control to a worksheet programmatically  
  
1.  The following code generates a worksheet host item that is based on the open worksheet, and then adds a <xref:Microsoft.Office.Tools.Excel.ListObject> control to cells **A1** through **A4**.  
  
     [!code-csharp[Trin_Excel_Dynamic_Controls#8](../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs#8)]
     [!code-vb[Trin_Excel_Dynamic_Controls#8](../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb#8)]  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [ListObject Control](../vsto/listobject-control.md)   
 [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [How to: Resize ListObject Controls](../vsto/how-to-resize-listobject-controls.md)   
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  