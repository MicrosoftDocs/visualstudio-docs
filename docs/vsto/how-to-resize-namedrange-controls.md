---
title: "How to: Resize NamedRange Controls | Microsoft Docs"
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
  - "controls [Office development in Visual Studio], resizing"
  - "NamedRange control, resizing"
  - "ranges, resizing in Excel"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Resize NamedRange Controls
  You can set the size of a <xref:Microsoft.Office.Tools.Excel.NamedRange> control when you add it to a Microsoft Office Excel document; however, you might want to resize it at a later time.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 You can resize a named range at design time or at run time in document-level projects. You can also resize named ranges at run time in application-level VSTO Add-ins.  
  
 This topic describes the following tasks:  
  
-   [Resizing NamedRange controls at design time](#designtime)  
  
-   [Resizing NamedRange controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Resizing NamedRange controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
##  <a name="designtime"></a> Resizing NamedRange Controls at Design Time  
 You can resize a named range by redefining its size in the **Define Name** dialog box.  
  
#### To resize a named range by using the Define Name dialog box  
  
1.  Right-click a <xref:Microsoft.Office.Tools.Excel.NamedRange> control.  
  
2.  Click **Manage Named Ranges** on the shortcut menu.  
  
     The **Define Name** dialog box appears.  
  
3.  Select the named range you want to resize.  
  
4.  Clear the **Refers to** box.  
  
5.  Select the cells you want to use to define the size of the named range.  
  
6.  Click **OK**.  
  
##  <a name="runtimedoclevel"></a> Resizing NamedRange Controls at Run Time in a Document-Level Project  
 You can resize a named range programmatically by using the <xref:Microsoft.Office.Tools.Excel.NamedRange.RefersTo%2A> property.  
  
> [!NOTE]  
>  In the **Properties** window, the <xref:Microsoft.Office.Tools.Excel.NamedRange.RefersTo%2A> property is marked as read-only.  
  
#### To resize a named range programmatically  
  
1.  Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on cell **A1** of `Sheet1`.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#4](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs#4)]
     [!code-vb[Trin_VstcoreHostControlsExcel#4](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb#4)]  
  
2.  Resize the named range to include cell **B1**.  
  
     [!code-csharp[Trin_VstcoreHostControlsExcel#5](../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs#5)]
     [!code-vb[Trin_VstcoreHostControlsExcel#5](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb#5)]  
  
##  <a name="runtimeaddin"></a> Resizing NamedRange Controls at Run Time in an VSTO Add-in project  
 You can resize a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on any open worksheet at run time. For more information about how to add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a worksheet by using an VSTO Add-in, see [How to: Add NamedRange Controls to Worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md).  
  
#### To resize a named range programmatically  
  
1.  Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on cell **A1** of `Sheet1`.  
  
     [!code-csharp[Trin_Excel_Dynamic_Controls#10](../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs#10)]
     [!code-vb[Trin_Excel_Dynamic_Controls#10](../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb#10)]  
  
2.  Resize the named range to include cell **B1**.  
  
     [!code-csharp[Trin_Excel_Dynamic_Controls#11](../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs#11)]
     [!code-vb[Trin_Excel_Dynamic_Controls#11](../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb#11)]  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)   
 [NamedRange Control](../vsto/namedrange-control.md)   
 [How to: Add NamedRange Controls to Worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)   
 [How to: Resize Bookmark Controls](../vsto/how-to-resize-bookmark-controls.md)   
 [How to: Resize ListObject Controls](../vsto/how-to-resize-listobject-controls.md)  
  
  