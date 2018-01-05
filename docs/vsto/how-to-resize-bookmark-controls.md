---
title: "How to: Resize Bookmark Controls | Microsoft Docs"
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
  - "Bookmark control, resizing"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Resize Bookmark Controls
  You set the size of a <xref:Microsoft.Office.Tools.Word.Bookmark> control when you add it to a Microsoft Office Word document. You can also resize it at a later time.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 There are three ways to resize a bookmark:  
  
-   Add or remove text in the <xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
     Whenever you add text in a bookmark, the size of the bookmark automatically increases to contain the new text. When you delete text, the size of the bookmark automatically decreases.  
  
-   Change the <xref:Microsoft.Office.Tools.Word.Bookmark.Start%2A> and <xref:Microsoft.Office.Tools.Word.Bookmark.End%2A> properties of the <xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
     This is useful if you are changing the size by only a few characters.  
  
-   Recreate the <xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
     This is useful if there is a substantial change in the size or location of a bookmark.  
  
 In document-level projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in your project at design time or at run time. In VSTO Add-in projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to any open document at run time. For more information, see [How to: Add Bookmark Controls to Word Documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md).  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
## Changing the Start and End Properties  
  
#### To resize a bookmark in a document-level project at design time  
  
1.  Select the bookmark in the **Properties** window.  
  
2.  Increase or decrease the value of the <xref:Microsoft.Office.Tools.Word.Bookmark.Start%2A> property.  
  
3.  Increase or decrease the value of the <xref:Microsoft.Office.Tools.Word.Bookmark.End%2A> property.  
  
#### To resize a bookmark in a document-level project at run time  
  
1.  Modify the <xref:Microsoft.Office.Tools.Word.Bookmark.Start%2A> and <xref:Microsoft.Office.Tools.Word.Bookmark.End%2A> properties of a <xref:Microsoft.Office.Tools.Word.Bookmark> you created at run time or at design time.  
  
     The following code example adds five characters to the start of a bookmark named `SampleBookmark`. This code assumes that there are at least five characters of text before the bookmark.  
  
     [!code-csharp[Trin_VstcoreHostControlsWord#2](../vsto/codesnippet/CSharp/trin_vstcorehostcontrolsword/ThisDocument.cs#2)]
     [!code-vb[Trin_VstcoreHostControlsWord#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsWordVB/ThisDocument.vb#2)]  
  
     The following code example adds five characters to the end of the same bookmark. This code assumes that there are at least five characters of text after the bookmark.  
  
     [!code-csharp[Trin_VstcoreHostControlsWord#3](../vsto/codesnippet/CSharp/trin_vstcorehostcontrolsword/ThisDocument.cs#3)]
     [!code-vb[Trin_VstcoreHostControlsWord#3](../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsWordVB/ThisDocument.vb#3)]  
  
#### To resize a bookmark in an VSTO Add-in project at run time  
  
1.  Modify the <xref:Microsoft.Office.Tools.Word.Bookmark.Start%2A> and <xref:Microsoft.Office.Tools.Word.Bookmark.End%2A> properties of a <xref:Microsoft.Office.Tools.Word.Bookmark> you created at run time.  
  
     The following code example creates a <xref:Microsoft.Office.Tools.Word.Bookmark> that contains the text in the first paragraph of the active document, and then removes five characters from the start and end of the <xref:Microsoft.Office.Tools.Word.Bookmark>.  
  
     [!code-vb[Trin_WordAddInDynamicControls#16](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#16)]
     [!code-csharp[Trin_WordAddInDynamicControls#16](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#16)]  
  
## Recreating the Bookmark  
 You can resize a bookmark in a document-level project by adding a new bookmark that has the same name as the existing bookmark, but that has a different size.  
  
#### To recreate a bookmark in a document-level project at design time  
  
1.  Select the text to be included in the new <xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
2.  On the **Insert** menu, click **Bookmark**.  
  
3.  In the **Bookmark** dialog box, select the name of the bookmark that you want to resize and click **Add**.  
  
## See Also  
 [How to: Add Bookmark Controls to Word Documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)   
 [Automating Word by Using Extended Objects](../vsto/automating-word-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [How to: Resize NamedRange Controls](../vsto/how-to-resize-namedrange-controls.md)   
 [How to: Resize ListObject Controls](../vsto/how-to-resize-listobject-controls.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  