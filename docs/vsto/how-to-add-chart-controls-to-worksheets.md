---
title: "How to: Add Chart Controls to Worksheets | Microsoft Docs"
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
  - "Chart control [Office development in Visual Studio], adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add Chart Controls to Worksheets
  You can add <xref:Microsoft.Office.Tools.Excel.Chart> controls to a Microsoft Office Excel worksheet at design time and at run time in document-level customizations. You can also add <xref:Microsoft.Office.Tools.Excel.Chart> controls at run time in VSTO Add-ins.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 This topic describes the following tasks:  
  
-   [Adding Chart controls at design time](#designtime)  
  
-   [Adding Chart controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding Chart controls at run time in a VSTO Add-in project](#runtimeaddin)  
  
 For more information about <xref:Microsoft.Office.Tools.Excel.Chart> controls, see [Chart Control](../vsto/chart-control.md).  
  
##  <a name="designtime"></a> Adding Chart Controls at Design Time  
 You can add the <xref:Microsoft.Office.Tools.Excel.Chart> control to your worksheet in the same manner you would add a chart from within the application.  
  
> [!NOTE]  
>  The <xref:Microsoft.Office.Tools.Excel.Chart> control is not available from the **Toolbox** or the **Data Sources** window.  
  
#### To add a Chart host control to a worksheet in Excel  
  
1.  On the **Insert** tab, in the **Charts** group, click **Column**, click a category of charts, and then click the type of chart you want.  
  
2.  In the **Insert Chart** dialog box, click **OK**.  
  
3.  On the **Design** tab, in the **Data** group, click **Select Data**.  
  
4.  In the **Select Data Source** dialog box, click in the **Chart** **data range** box and clear any default selection.  
  
5.  In the **Data for Chart** sheet, select the range of cells that contains the data for the chart (cells **A5** through **D8**).  
  
6.  In the **Select Data Source** dialog box, click **OK**.  
  
##  <a name="runtimedoclevel"></a> Adding Chart Controls at Run Time in a Document-Level Project  
 You can add the <xref:Microsoft.Office.Tools.Excel.Chart> control dynamically at run time. Dynamically created charts are not persisted in the document as host controls when the document is closed. For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a Chart control to a worksheet programmatically  
  
1.  In the <xref:Microsoft.Office.Tools.Excel.Worksheet.Startup> event handler of `Sheet1`, insert the following code to add the <xref:Microsoft.Office.Tools.Excel.Chart> control.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#1](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs#1)]
     [!code-vb[Trin_VstcoreHostControlsExcel#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb#1)]  
  
##  <a name="runtimeaddin"></a> Adding Chart Controls at Run Time in a VSTO Add-in Project  
 You can add a <xref:Microsoft.Office.Tools.Excel.Chart> control programmatically to any open worksheet in a VSTO Add-in project. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
 Dynamically created chart controls are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a Chart control to a worksheet programmatically  
  
1.  The following code generates a worksheet host item that is based on the open worksheet, and then adds a <xref:Microsoft.Office.Tools.Excel.Chart> control.  
  
     [!code-csharp[Trin_Excel_Dynamic_Controls#9](../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs#9)]
     [!code-vb[Trin_Excel_Dynamic_Controls#9](../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb#9)]  
  
## Compiling the Code  
 This example has the following requirements:  
  
-   Data to be charted, stored in the range from A5 to D8 in the worksheet.  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [Chart Control](../vsto/chart-control.md)   
 [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  