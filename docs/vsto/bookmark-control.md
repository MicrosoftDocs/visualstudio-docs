---
title: "Bookmark control"
description: Learn how the Bookmark control is a bookmark that has a unique name, exposes events, and can be bound to data.
ms.date: 02/02/2017
ms.topic: article
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
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Bookmark control

  The <xref:Microsoft.Office.Tools.Word.Bookmark> control is a bookmark that has a unique name, exposes events, and can be bound to data. The bookmark can be used as a placeholder to mark an item or location in a Microsoft Office Word document. The <xref:Microsoft.Office.Tools.Word.Bookmark> control is a combination of a <xref:Microsoft.Office.Interop.Word.Bookmark> object and a <xref:Microsoft.Office.Interop.Word.Range> object.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 In document-level projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to your document at design time or at run time. In VSTO Add-in projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to any open document at run time. For more information, see [How to: Add Bookmark controls to Word documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md).

## Bind data to the control
 A <xref:Microsoft.Office.Tools.Word.Bookmark> control supports simple data binding. The bookmark should be bound to a data source using the <xref:System.Windows.Forms.IBindableComponent.DataBindings%2A> property. The default data binding property of the bookmark is the <xref:Microsoft.Office.Tools.Word.Bookmark.Text%2A> property.

 If the data in the bound dataset is updated, the <xref:Microsoft.Office.Tools.Word.Bookmark> control shows the changes.

 In document-level projects, you can also bind data to bookmarks by using the **Data Sources** window. For more information, see [How to: Populate documents with data from objects](../vsto/how-to-populate-documents-with-data-from-objects.md).

## Formatting
 Formatting that can be applied to a <xref:Microsoft.Office.Interop.Word.Bookmark> can be applied to a <xref:Microsoft.Office.Tools.Word.Bookmark> control. This formatting includes fonts, indents, spacing, numbering, and styles.

## Assign text to the bookmark
 An additional difference between a <xref:Microsoft.Office.Interop.Word.Bookmark?displayProperty=nameWithType> object and a <xref:Microsoft.Office.Tools.Word.Bookmark?displayProperty=nameWithType> control is how it behaves when text is assigned to the bookmark. If you assign text to a zero-length <xref:Microsoft.Office.Interop.Word.Bookmark?displayProperty=nameWithType>, the text is appended to the right of the bookmark and the bookmark remains zero-length. However, if you assign text to a zero-length <xref:Microsoft.Office.Tools.Word.Bookmark?displayProperty=nameWithType>, the text is inserted into the bookmark and the bookmark's length expands to the total number of characters inserted.

 The <xref:Microsoft.Office.Tools.Word.Bookmark?displayProperty=nameWithType> control also has the <xref:Microsoft.Office.Tools.Word.Bookmark.Text?displayProperty=nameWithType> property. This property is different from the <xref:Microsoft.Office.Interop.Word.Range.Text?displayProperty=nameWithType> property that is available on the <xref:Microsoft.Office.Tools.Word.Bookmark.Range?displayProperty=nameWithType> property of a <xref:Microsoft.Office.Tools.Word.Bookmark?displayProperty=nameWithType> control, or the <xref:Microsoft.Office.Interop.Word.Bookmark.Range?displayProperty=nameWithType> property of a <xref:Microsoft.Office.Interop.Word.Bookmark?displayProperty=nameWithType> object.

|Text Property|Description|
|-------------------|-----------------|
|<xref:Microsoft.Office.Tools.Word.Bookmark.Text?displayProperty=nameWithType>|Use this property to display text within the bookmark and leave the bookmark on the document. Assigning text to the bookmark expands the bookmark range and does not delete the bookmark.<br /><br /> For example, `Bookmark1.Text = "Hello world"` inserts the text into the bookmark and leaves the bookmark intact.|
|<xref:Microsoft.Office.Interop.Word.Range.Text?displayProperty=nameWithType>|Use this property to display text at the bookmark location and automatically delete the bookmark. For example, `Bookmark1.Range.Text = "Hello world"` inserts the text into the bookmark and deletes the bookmark.|

## Rename the control at design time
 In document-level projects, when you drag a <xref:Microsoft.Office.Tools.Word.Bookmark> control from the **Toolbox** to your document, Visual Studio automatically generates a name for the control. You can change the name of the control in the **Properties** window.

## Overlapping controls
 Bookmark controls can overlap each other. The same text can be shared by more than one bookmark. When you assign new text to one of the overlapping bookmarks, it contains only the new text and the bookmarks no longer overlap. The other bookmark now contains only the text that wasn't shared between the original overlapping bookmarks.

 The following table shows how the sentence "This is sample text." is shared by two overlapping bookmarks:

|Bookmark|Text|
|--------------|----------|
|Overlapping bookmarks|[this is {sample] text.}|
|Bookmark1|This is sample|
|Bookmark2|sample text.|

 If you assign the new text "This is replacement." to Bookmark1, the bookmarks don't overlap, and Bookmark2 retains only the text that wasn't originally part of Bookmark1.

|Bookmark|Text|
|--------------|----------|
|Two separate bookmarks|[this is replacement]{ text.}|
|Bookmark1|This is replacement|
|Bookmark2|text.|

If you change the text of a bookmark that contains another bookmark, the inner bookmark isn't deleted. However, the inner bookmark becomes an empty bookmark, and moves to the end of the outer bookmark.

The following table shows how the sentence "This is sample text." is shared by a bookmark that's contained within another bookmark:

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

- <xref:Microsoft.Office.Tools.Word.Bookmark.BeforeDoubleClick>

- <xref:Microsoft.Office.Tools.Word.Bookmark.BeforeRightClick>

- <xref:Microsoft.Office.Tools.Word.Bookmark.BindingContextChanged>

- <xref:Microsoft.Office.Tools.Word.Bookmark.Deselected>

- <xref:System.ComponentModel.IComponent.Disposed>

- <xref:Microsoft.Office.Tools.Word.Bookmark.Selected>

- <xref:Microsoft.Office.Tools.Word.Bookmark.SelectionChange>

## Related content

- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [How to: Add Bookmark controls to Word documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)
- [Walkthrough: Create shortcut menus for bookmarks](/previous-versions/visualstudio/visual-studio-2017/vsto/walkthrough-creating-shortcut-menus-for-bookmarks)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
