---
title: "How to: Add Bookmark controls to Word documents"
description: Learn that in document-level projects, you can add Bookmark controls to the document in your project at design time or at run time.
ms.date: "02/02/2017"
ms.topic: "how-to"
f1_keywords:
  - "VST.Bookmark.Dialog"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Bookmark control, adding to documents"
  - "Create Bookmark Control dialog box"
  - "controls [Office development in Visual Studio], adding to documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Add Bookmark controls to Word documents
  In document-level projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in your project at design time or at run time. In VSTO Add-in projects, you can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to any open document at run time.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 This topic describes the following tasks:

- [Add Bookmark controls at design time](#designtime)

- [Add Bookmark controls at run time in a document-level project](#runtimedoclevel)

- [Add Bookmark controls at run time in a VSTO Add-in project](#runtimeaddin)

  For more information about <xref:Microsoft.Office.Tools.Word.Bookmark> controls, see [Bookmark control](../vsto/bookmark-control.md).

## <a name="designtime"></a> Add Bookmark controls at Design Time
 There are several ways to add <xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in a document-level project at design time:

- From the Visual Studio **Toolbox**.

   You can drag the <xref:Microsoft.Office.Tools.Word.Bookmark> control from the **Toolbox** to your document. You might want to choose this way if you are already using the **Toolbox** to add Windows Forms controls to your document.

- From within Word.

   You can add the <xref:Microsoft.Office.Tools.Word.Bookmark> control to your document in the same manner you would add the native bookmark. The advantage of adding it this way is that you can name your control at the time you create it.

- From the **Data Sources** window.

   You can drag the <xref:Microsoft.Office.Tools.Word.Bookmark> control to your document from the **Data Sources** window. This is useful when you want to bind the control to data at the same time. You can add the host control in the same way you would add a Windows Form control from the **Data Sources** window. For more information, see [Data binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms).

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

#### To add a Bookmark control to a document from the Toolbox

1. Open the **Toolbox** and click the **Word Controls** tab.

2. Drag a <xref:Microsoft.Office.Tools.Word.Bookmark> control to the document.

     The **Add Bookmark** dialog box appears.

3. Select the text or other items you want to include in the bookmark.

4. Click **OK**.

     If you do not want to keep the default bookmark name, you can change the name in the **Properties** window.

#### To add a Bookmark control to a document in Word

1. In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, put the cursor where you want to add the bookmark, or select the text that you want the bookmark to enclose.

2. On the **Insert** tab of the Ribbon, in the **Links** group, click the **Bookmark** button.

3. In the **Bookmark** dialog box, type the name of the new bookmark, and click **Add**.

## <a name="runtimedoclevel"></a> Add Bookmark controls at run time in a document-level project
 You can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls programmatically to your document at run time by using methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of the `ThisDocument` class in your project. There are two method overloads that you can use to add a <xref:Microsoft.Office.Tools.Word.Bookmark> control in the following ways:

- Add a <xref:Microsoft.Office.Tools.Word.Bookmark> at a specified range.

- Add a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark in the document (that is, a <xref:Microsoft.Office.Interop.Word.Bookmark>).

  Dynamically created <xref:Microsoft.Office.Tools.Word.Bookmark> controls are not persisted in the document when the document is closed. However, a native <xref:Microsoft.Office.Interop.Word.Bookmark> remains in the document. You can recreate a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark the next time the document is opened. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

#### To add a Bookmark control to a document programmatically

1. In the `ThisDocument_Startup` event handler in your project, insert the following code to add the <xref:Microsoft.Office.Tools.Word.Bookmark> control to the first paragraph in the document.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcorehostcontrolsword/ThisDocument.cs" id="Snippet1":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsWordVB/ThisDocument.vb" id="Snippet1":::

    > [!NOTE]
    > If you want create a <xref:Microsoft.Office.Tools.Word.Bookmark> control from an existing <xref:Microsoft.Office.Interop.Word.Bookmark>, use the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark%2A> method and pass in the existing <xref:Microsoft.Office.Interop.Word.Bookmark>.

## <a name="runtimeaddin"></a> Add Bookmark controls at run time in a VSTO Add-in project
 You can add <xref:Microsoft.Office.Tools.Word.Bookmark> controls programmatically to any open document at run time by using a VSTO Add-in. To do this, generate a <xref:Microsoft.Office.Tools.Word.Document> host item that is based on an open document, and then use methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of this host item. There are two method overloads that you can use to add a <xref:Microsoft.Office.Tools.Word.Bookmark> control in the following ways:

- Add a <xref:Microsoft.Office.Tools.Word.Bookmark> at a specified range.

- Add a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark in the document (that is, a <xref:Microsoft.Office.Interop.Word.Bookmark>).

  Dynamically created <xref:Microsoft.Office.Tools.Word.Bookmark> controls are not persisted in the document when the document is closed. However, a native <xref:Microsoft.Office.Interop.Word.Bookmark> remains in the document. You can recreate a <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on a native bookmark the next time the document is opened. For more information, see [Persist dynamic controls in Office documents](../vsto/persisting-dynamic-controls-in-office-documents.md).

  For more information about generating host items in VSTO Add-in projects, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

#### To add a Bookmark control at a specified range

1. Use the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark%2A> method, and pass in the <xref:Microsoft.Office.Interop.Word.Range> where you want to add the <xref:Microsoft.Office.Tools.Word.Bookmark>.

     The following code example adds a new <xref:Microsoft.Office.Tools.Word.Bookmark> to the beginning of the active document. To use this example, run the code from the `ThisAddIn_Startup` event handler in a Word VSTO Add-in project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb" id="Snippet4":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet4":::

#### To add a Bookmark control that is based on a native Bookmark control

1. Use the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddBookmark%2A> method, and pass in the existing <xref:Microsoft.Office.Interop.Word.Bookmark> that you want to use as the basis for the new <xref:Microsoft.Office.Tools.Word.Bookmark>.

     The following code example creates a new <xref:Microsoft.Office.Tools.Word.Bookmark> that is based on the first <xref:Microsoft.Office.Interop.Word.Bookmark> in the active document. To use this example, run the code from the `ThisAddIn_Startup` event handler in a Word VSTO Add-in project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb" id="Snippet5":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet5":::

## See also
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [How to: Resize Bookmark controls](../vsto/how-to-resize-bookmark-controls.md)
