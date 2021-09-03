---
title: "How to: Add Content controls to Word documents"
description: Learn that in document-level Word projects, you can add content controls to the document in your project at design time or at run time. 
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "restricted permissions [Office development in Visual Studio]"
  - "DropDownListContentControl, adding to documents"
  - "BuildingBlockGalleryContentControl, adding to documents"
  - "partial document protection [Office development in Visual Studio]"
  - "RichTextContentControl, adding to documents"
  - "Word [Office development in Visual Studio], partial document protection"
  - "content controls [Office development in Visual Studio], protecting"
  - "PictureContentControl, adding to documents"
  - "GroupContentControl, adding to documents"
  - "document protection [Office development in Visual Studio]"
  - "PlainTextContentControl, adding to documents"
  - "content controls [Office development in Visual Studio], adding"
  - "ComboBoxContentControl, adding to documents"
  - "DatePickerContentControl, adding to documents"
  - "Word [Office development in Visual Studio], restricted permissions"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Add Content controls to Word documents
  In document-level Word projects, you can add content controls to the document in your project at design time or at run time. In Word VSTO Add-in projects, you can add content controls to any open document at run time.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 This topic describes the following tasks:

- [Add content controls at design time](#designtime)

- [Add content controls at run time in a document-level project](#runtimedoclevel)

- [Add content controls at run time in a VSTO Add-in project](#runtimeaddin)

  For information about content controls, see [Content controls](../vsto/content-controls.md).

## <a name="designtime"></a> Add Content controls at design time
 There are several ways to add content controls to the document in a document-level project at design time:

- Add a content control from the **Word Controls** tab of the **Toolbox**.

- Add a content control to your document in the same manner you would add a native content control in Word.

- Drag a content control to your document from the **Data Sources** window. This is useful when you want to bind the control to data when the control is created. For more information, see [How to: Populate documents with data from objects](../vsto/how-to-populate-documents-with-data-from-objects.md) and [How to: Populate documents with data from a database](../vsto/how-to-populate-documents-with-data-from-a-database.md).

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

### To add a content control to a document by using the Toolbox

1. In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, put the cursor where you want to add the content control, or select the text that you want the content control to replace.

2. Open the **Toolbox** and click the **Word Controls** tab.

3. Add the control one of the following ways:

    - Double-click a content control in the **Toolbox**.

         or

    - Click a content control in the **Toolbox** and then press the **Enter** key.

         or

    - Drag a content control from the **Toolbox** to the document. The content control is added at the current selection in the document, not at the location of the mouse pointer.

> [!NOTE]
> You cannot add a <xref:Microsoft.Office.Tools.Word.GroupContentControl> by using the **Toolbox**. You can only add a <xref:Microsoft.Office.Tools.Word.GroupContentControl> in Word, or at run time.

> [!NOTE]
> Visual Studio does not provide a check box content control in the Toolbox. To add a check box content control to the document, you must create a <xref:Microsoft.Office.Tools.Word.ContentControl> object programmatically. For more information, see [Content controls](../vsto/content-controls.md).

#### To add a content control to a document in Word

1. In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, put the cursor where you want to add the content control, or select the text that you want the content control to replace.

2. On the Ribbon, click the **Developer** tab.

    > [!NOTE]
    > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the Developer tab on the Ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

3. In the **Controls** group, click the icon for the content control that you want to add.

## <a name="runtimedoclevel"></a> Add content controls at run time in a document-level project
 You can add content controls programmatically to your document at run time by using methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of the `ThisDocument` class in your project. Each method has three overloads that you can use to add a content control in the following ways:

- Add a control at the current selection.

- Add a control at a specified range.

- Add a control that is based on a native content control in the document.

  Dynamically created content controls are not persisted in the document when the document is closed. However, a native content control remains in the document. You can recreate a content control that is based on a native content control the next time the document is opened. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

> [!NOTE]
> To add a check box content control to a document in a Word 2010 project, you must create a <xref:Microsoft.Office.Tools.Word.ContentControl> object. For more information, see [Content controls](../vsto/content-controls.md).

### To add a content control at the current selection

1. Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the class name of the content control that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a single parameter for the name of the new control.

     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `AddRichTextControlAtSelection` method from the `ThisDocument_Startup` event handler.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordcontentcontrolreference/RichText.cs" id="Snippet700":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_contentcontrolreference/RichText.vb" id="Snippet700":::

### To add a content control at a specified range

1. Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a <xref:Microsoft.Office.Interop.Word.Range> parameter.

     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `AddRichTextControlAtRange` method from the `ThisDocument_Startup` event handler.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordcontentcontrolreference/RichText.cs" id="Snippet701":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_contentcontrolreference/RichText.vb" id="Snippet701":::

### To add a content control that is based on a native content control

1. Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a `Microsoft.Office.Interop.Word.ContentControl` parameter.

     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to create a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> for every native rich text control that is in the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `CreateRichTextControlsFromNativeControls` method from the `ThisDocument_Startup` event handler.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_wordcontentcontrolreference/RichText.cs" id="Snippet702":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_contentcontrolreference/RichText.vb" id="Snippet702":::

## <a name="runtimeaddin"></a> Add content controls at run time in a VSTO Add-in project
 You can add content controls programmatically to any open document at run time by using a VSTO Add-in. To do this, generate a <xref:Microsoft.Office.Tools.Word.Document> host item that is based on an open document, and then use methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of this host item. Each method has three overloads that you can use to add a content control in the following ways:

- Add a control at the current selection.

- Add a control at a specified range.

- Add a control that is based on a native content control in the document.

  Dynamically created content controls are not persisted in the document when the document is closed. However, a native content control remains in the document. You can recreate a content control that is based on a native content control the next time the document is opened. For more information, see [Persist dynamic controls in Office documents](../vsto/persisting-dynamic-controls-in-office-documents.md).

  For more information about generating host items in VSTO Add-in projects, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

> [!NOTE]
> To add a check box content control to a document, you must create a <xref:Microsoft.Office.Tools.Word.ContentControl> object. For more information, see [Content controls](../vsto/content-controls.md).

### To add a content control at the current selection

1. Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the class name of the content control that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a single parameter for the name of the new control.

     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the active document. To run this code, add the code to the `ThisAddIn` class in your project, and call the `AddRichTextControlAtSelection` method from the `ThisAddIn_Startup` event handler.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb" id="Snippet1":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet1":::

### To add a content control at a specified range

1. Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a <xref:Microsoft.Office.Interop.Word.Range> parameter.

     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the active document. To run this code, add the code to the `ThisAddIn` class in your project, and call the `AddRichTextControlAtRange` method from the `ThisAddIn_Startup` event handler.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb" id="Snippet2":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet2":::

#### To add a content control that is based on a native content control

1. Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a `Microsoft.Office.Interop.Word.ContentControl` parameter.

     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to create a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> for every native rich text control that is in a document, after the document is opened. To run this code, add the code to the `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb" id="Snippet3":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet3":::

     For C#, you must also attach the `Application_DocumentOpen` event handler to the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> event.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs" id="Snippet6":::

## See also
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
