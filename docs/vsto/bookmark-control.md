---
title: "Bookmark Control | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.Toolbox.Bookmark"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "bookmarks, controlling"
  - "Bookmark control, data binding"
  - "Bookmark control, events"
  - "Bookmark control"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Bookmark Control
  The <xref:Microsoft.Office.Tools.Word.Bookmark> control is a bookmark that has a unique name, exposes events, and can be bound to data. The bookmark can be used as a placeholder to mark an item or location in a Microsoft Office Word document. The <xref:Microsoft.Office.Tools.Word.Bookmark> control is a combination of a <xref:Microsoft.Office.Interop.Word.Bookmark> object and a <xref:Microsoft.Office.Interop.Word.Range> object.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 In document-level projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to your document at design time or at run time. In VSTO Add-in projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to any open document at run time. For more information, see [How to: Add Bookmark Controls to Word Documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md).  
  
## Binding Data to the Control  
 A <xref:Microsoft.Office.Tools.Word.Bookmark> control supports simple data binding. The bookmark should be bound to a data source using the <xref:System.Windows.Forms.IBindableComponent.DataBindings%2A> property. The default data binding property of the bookmark is the <xref:Microsoft.Office.Tools.Word.Bookmark.Text%2A> property.  
  
 If the data in the bound dataset is updated, the <xref:Microsoft.Office.Tools.Word.Bookmark> control reflects the changes.  
  
 In document-level projects, you can also bind data to bookmarks by using the **Data Sources** window. For more information, see [How to: Populate Documents with Data from Objects](../vsto/how-to-populate-documents-with-data-from-objects.md).  
  
## Formatting  
 Formatting that can be applied to a <xref:Microsoft.Office.Interop.Word.Bookmark> can be applied to a <xref:Microsoft.Office.Tools.Word.Bookmark> control. This includes fonts, indents, spacing, numbering, and styles.  
  
## Assigning Text to the Bookmark  
 An additional difference between a <xref:Microsoft.Office.Interop.Word.Bookmark> object and a <xref:Microsoft.Office.Tools.Word.Bookmark> control is how it behaves when text is assigned to the bookmark. If you assign text to a zero-length <xref:Microsoft.Office.Interop.Word.Bookmark>, the text is appended to the right of the bookmark and the bookmark remains zero-length. However, if you assign text to a zero-length <xref:Microsoft.Office.Tools.Word.Bookmark>, the text is inserted into the bookmark and the bookmark's length expands to the total number of characters inserted.  
  
 The <xref:Microsoft.Office.Tools.Word.Bookmark> control also has the <xref:Microsoft.Office.Tools.Word.Bookmark.Text%2A> property. This is different from the <xref:Microsoft.Office.Interop.Word.Range.Text%2A> property that is available on the <xref:Microsoft.Office.Tools.Word.Bookmark.Range%2A> property of a <xref:Microsoft.Office.Tools.Word.Bookmark> control or the <xref:Microsoft.Office.Interop.Word.Bookmark.Range%2A> property of a <xref:Microsoft.Office.Interop.Word.Bookmark> object.  
  
|Text Property|Description|  
|-------------------|-----------------|  
|<xref:Microsoft.Office.Tools.Word.Bookmark.Text%2A>|Use this property to display text within the bookmark and leave the bookmark on the document. Assigning text to the bookmark expands the bookmark range and does not delete the bookmark.<br /><br /> For example, `Bookmark1.Text = "Hello world"` inserts the text into the bookmark and leaves the bookmark intact.|  
|<xref:Microsoft.Office.Interop.Word.Range.Text%2A>|Use this property to display text at the bookmark location and automatically delete the bookmark. For example, `Bookmark1.Range.Text = "Hello world"` inserts the text into the bookmark and deletes the bookmark.|  
  
## Renaming the Control at Design Time  
 In document-level projects, when you drag a <xref:Microsoft.Office.Tools.Word.Bookmark> control from the **Toolbox** to your document, Visual Studio automatically generates a name for the control. You can change the name of the control in the **Properties** window.  
  
## Overlapping Controls  
 Bookmark controls can overlap each other; that is, the same text can be shared by more than one bookmark. When you assign new text to one of the overlapping bookmarks, it will contain only the new text and the bookmarks will no longer overlap. The other bookmark will now contain only the text that was not shared between the original overlapping bookmarks.  
  
 The following table shows how the sentence "This is sample text." is shared by two overlapping bookmarks.  
  
|Bookmark|Text|  
|--------------|----------|  
|Overlapping bookmarks|[this is {sample] text.}|  
|Bookmark1|This is sample|  
|Bookmark2|sample text.|  
  
 If you assign the new text "This is replacement." to Bookmark1, the bookmarks are no longer overlapping and Bookmark2 retains only the text that was not originally part of Bookmark1.  
  
|Bookmark|Text|  
|--------------|----------|  
|Two separate bookmarks|[this is replacement]{ text.}|  
|Bookmark1|This is replacement|  
|Bookmark2|text.|  
  
 If one bookmark is fully contained within another bookmark and you change the text of the outer bookmark, the inner bookmark is not deleted. However, the inner bookmark becomes an empty bookmark that is moved to the end of the outer bookmark. The following table shows how the sentence "This is sample text." is shared by a bookmark that is contained within another bookmark.  
  
|Bookmark|Text|  
|--------------|----------|  
|Overlapping bookmarks|[this is {sample} text.]|  
|Bookmark1|This is sample text.|  
|Bookmark2|sample|  
  
 If you assign the new text "This is replacement." to Bookmark1, the bookmarks are no longer overlapping and Bookmark2 becomes an empty bookmark that is located at the end of Bookmark1.  
  
|Bookmark|Text|  
|--------------|----------|  
|Two separate bookmarks|[this is replacement.]{}|  
|Bookmark1|This is replacement.|  
|Bookmark2|*\<empty>*|  
  
## Events  
 The following events are available for the <xref:Microsoft.Office.Tools.Word.Bookmark> control:  
  
-   <xref:Microsoft.Office.Tools.Word.Bookmark.BeforeDoubleClick>  
  
-   <xref:Microsoft.Office.Tools.Word.Bookmark.BeforeRightClick>  
  
-   <xref:Microsoft.Office.Tools.Word.Bookmark.BindingContextChanged>  
  
-   <xref:Microsoft.Office.Tools.Word.Bookmark.Deselected>  
  
-   <xref:System.ComponentModel.IComponent.Disposed>  
  
-   <xref:Microsoft.Office.Tools.Word.Bookmark.Selected>  
  
-   <xref:Microsoft.Office.Tools.Word.Bookmark.SelectionChange>  
  
## See Also  
 [Automating Word by Using Extended Objects](../vsto/automating-word-by-using-extended-objects.md)   
 [How to: Add Bookmark Controls to Word Documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)   
 [Walkthrough: Creating Shortcut Menus for Bookmarks](../vsto/walkthrough-creating-shortcut-menus-for-bookmarks.md)   
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  