---
title: "How to: Add Bookmark Controls to Word Documents | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.Bookmark.Dialog"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Bookmark control, adding to documents"
  - "Create Bookmark Control dialog box"
  - "controls [Office development in Visual Studio], adding to documents"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add Bookmark Controls to Word Documents
  In document-level projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in your project at design time or at run time. In VSTO Add-in projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to any open document at run time.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 This topic describes the following tasks:  
  
-   [Adding Bookmark controls at design time](#designtime)  
  
-   [Adding Bookmark controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding Bookmark controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For more information about <xref:Microsoft.Office.Tools.Word.Bookmark> controls, see [Bookmark Control](../vsto/bookmark-control.md).  
  
##  <a name="designtime"></a> Adding Bookmark Controls at Design Time  
 There are several ways to add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in a document-level project at design time:  
  
-   From the Visual Studio **Toolbox**.  
  
     You can drag the <xref:Microsoft.Office.Tools.Word.Bookmark> control from the **Toolbox** to your document. You might want to choose this way if you are already using the **Toolbox** to add Windows Forms controls to your document.  
  
-   From within Word.  
  
     You can add the <xref:Microsoft.Office.Tools.Word.Bookmark> control to your document in the same manner you would add the native bookmark. The advantage of adding it this way is that you can name your control at the time you create it.  
  
-   From the **Data Sources** window.  
  
     You can drag the <xref:Microsoft.Office.Tools.Word.Bookmark> control to your document from the **Data Sources** window. This is useful when you want to bind the control to data at the same time. You can add the host control in the same way you would add a Windows Form control from the **Data Sources** window. For more information, see [Data Binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms).  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
#### To add a Bookmark control to a document from the Toolbox  
  
1.  Open the **Toolbox** and click the **Word Controls** tab.  
  
2.  Drag a <xref:Microsoft.Office.Tools.Word.Bookmark> control to the document.  
  
     The **Add Bookmark** dialog box appears.  
  
3.  Select the text or other items you want to include in the bookmark.  
  
4.  Click **OK**.  
  
     If you do not want to keep the default bookmark name, you can change the name in the **Properties** window.  
  
#### To add a Bookmark control to a document in Word  
  
1.  In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, put the cursor where you want to add the bookmark, or select the text that you want the bookmark to enclose.  
  
2.  On the **Insert** tab of the Ribbon, in the **Links** group, click the **Bookmark** button.  
  
3.  In the **Bookmark** dialog box, type the name of the new bookmark, and click **Add**.  
  
##  <a name="runtimedoclevel"></a> Adding Bookmark Controls at Run Time in a Document-Level Project  
 You can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls programmatically to your document at run time by using methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of the `ThisDocument` class in your project. There are two method overloads that you can use to add a <xref:Microsoft.Office.Tools.Word.Bookmark> control in the following ways:  
  
-   Add a <xref:Microsoft.Office.Tools.Word.Bookmark> at a specified range.  
  
-   Add a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark in the document (that is, a <xref:Microsoft.Office.Interop.Word.Bookmark>).  
  
 Dynamically created <xref:Microsoft.Office.Tools.Word.Bookmark> controls are not persisted in the document when the document is closed. However, a native <xref:Microsoft.Office.Interop.Word.Bookmark> remains in the document. You can recreate a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark the next time the document is opened. For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
#### To add a Bookmark control to a document programmatically  
  
1.  In the `ThisDocument_Startup` event handler in your project, insert the following code to add the <xref:Microsoft.Office.Tools.Word.Bookmark> control to the first paragraph in the document.  
  
     [!code-csharp[Trin_VstcoreHostControlsWord#1](../vsto/codesnippet/CSharp/trin_vstcorehostcontrolsword/ThisDocument.cs#1)]
     [!code-vb[Trin_VstcoreHostControlsWord#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsWordVB/ThisDocument.vb#1)]  
  
    > [!NOTE]  
    >  If you want create a <xref:Microsoft.Office.Tools.Word.Bookmark> control from an existing <xref:Microsoft.Office.Interop.Word.Bookmark>, use the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark%2A> method and pass in the existing <xref:Microsoft.Office.Interop.Word.Bookmark>.  
  
##  <a name="runtimeaddin"></a> Adding Bookmark Controls at Run Time in an VSTO Add-in project  
 You can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls programmatically to any open document at run time by using a VSTO Add-in. To do this, generate a <xref:Microsoft.Office.Tools.Word.Document> host item that is based on an open document, and then use methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of this host item. There are two method overloads that you can use to add a <xref:Microsoft.Office.Tools.Word.Bookmark> control in the following ways:  
  
-   Add a <xref:Microsoft.Office.Tools.Word.Bookmark> at a specified range.  
  
-   Add a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark in the document (that is, a <xref:Microsoft.Office.Interop.Word.Bookmark>).  
  
 Dynamically created <xref:Microsoft.Office.Tools.Word.Bookmark> controls are not persisted in the document when the document is closed. However, a native <xref:Microsoft.Office.Interop.Word.Bookmark> remains in the document. You can recreate a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark the next time the document is opened. For more information, see [Persisting Dynamic Controls in Office Documents](../vsto/persisting-dynamic-controls-in-office-documents.md).  
  
 For more information about generating host items in VSTO Add-in projects, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
#### To add a Bookmark control at a specified range  
  
1.  Use the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark%2A> method, and pass in the <xref:Microsoft.Office.Interop.Word.Range> where you want to add the <xref:Microsoft.Office.Tools.Word.Bookmark>.  
  
     The following code example adds a new <xref:Microsoft.Office.Tools.Word.Bookmark> to the beginning of the active document. To use this example, run the code from the `ThisAddIn_Startup` event handler in a Word VSTO Add-in project.  
  
     [!code-vb[Trin_WordAddInDynamicControls#4](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#4)]
     [!code-csharp[Trin_WordAddInDynamicControls#4](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#4)]  
  
#### To add a Bookmark control that is based on a native Bookmark control  
  
1.  Use the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark%2A> method, and pass in the existing <xref:Microsoft.Office.Interop.Word.Bookmark> that you want to use as the basis for the new <xref:Microsoft.Office.Tools.Word.Bookmark>.  
  
     The following code example creates a new <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on the first <xref:Microsoft.Office.Interop.Word.Bookmark> in the active document. To use this example, run the code from the `ThisAddIn_Startup` event handler in a Word VSTO Add-in project.  
  
     [!code-vb[Trin_WordAddInDynamicControls#5](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#5)]
     [!code-csharp[Trin_WordAddInDynamicControls#5](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#5)]  
  
## See Also  
 [Automating Word by Using Extended Objects](../vsto/automating-word-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)   
 [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md)   
 [How to: Resize Bookmark Controls](../vsto/how-to-resize-bookmark-controls.md)  
  
  