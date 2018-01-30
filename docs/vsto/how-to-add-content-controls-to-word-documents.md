---
title: "How to: Add Content Controls to Word Documents | Microsoft Docs"
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
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add Content Controls to Word Documents
  In document-level Word projects, you can add content controls to the document in your project at design time or at run time. In Word VSTO Add-in projects, you can add content controls to any open document at run time.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 This topic describes the following tasks:  
  
-   [Adding content controls at design time](#designtime)  
  
-   [Adding content controls at run time in a document-level project](#runtimedoclevel)  
  
-   [Adding content controls at run time in an VSTO Add-in project](#runtimeaddin)  
  
 For information about content controls, see [Content Controls](../vsto/content-controls.md).  
  
##  <a name="designtime"></a> Adding Content Controls at Design Time  
 There are several ways to add content controls to the document in a document-level project at design time:  
  
-   Add a content control from the **Word Controls** tab of the **Toolbox**.  
  
-   Add a content control to your document in the same manner you would add a native content control in Word.  
  
-   Drag a content control to your document from the **Data Sources** window. This is useful when you want to bind the control to data when the control is created. For more information, see [How to: Populate Documents with Data from Objects](../vsto/how-to-populate-documents-with-data-from-objects.md) and [How to: Populate Documents with Data from a Database](../vsto/how-to-populate-documents-with-data-from-a-database.md).  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
#### To add a content control to a document by using the Toolbox  
  
1.  In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, put the cursor where you want to add the content control, or select the text that you want the content control to replace.  
  
2.  Open the **Toolbox** and click the **Word Controls** tab.  
  
3.  Add the control one of the following ways:  
  
    -   Double-click a content control in the **Toolbox**.  
  
         or  
  
    -   Click a content control in the **Toolbox** and then press the ENTER key.  
  
         or  
  
    -   Drag a content control from the **Toolbox** to the document. The content control is added at the current selection in the document, not at the location of the mouse pointer.  
  
> [!NOTE]  
>  You cannot add a <xref:Microsoft.Office.Tools.Word.GroupContentControl> by using the **Toolbox**. You can only add a <xref:Microsoft.Office.Tools.Word.GroupContentControl> in Word, or at run time.  
  
> [!NOTE]  
>  Visual Studio does not provide a check box content control in the Toolbox. To add a check box content control to the document, you must create a <xref:Microsoft.Office.Tools.Word.ContentControl> object programmatically. For more information, see [Content Controls](../vsto/content-controls.md).  
  
#### To add a content control to a document in Word  
  
1.  In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, put the cursor where you want to add the content control, or select the text that you want the content control to replace.  
  
2.  On the Ribbon, click the **Developer** tab.  
  
    > [!NOTE]  
    >  If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the Developer Tab on the Ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).  
  
3.  In the **Controls** group, click the icon for the content control that you want to add.  
  
##  <a name="runtimedoclevel"></a> Adding Content Controls at Run Time in a Document-Level Project  
 You can add content controls programmatically to your document at run time by using methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of the `ThisDocument` class in your project. Each method has three overloads that you can use to add a content control in the following ways:  
  
-   Add a control at the current selection.  
  
-   Add a control at a specified range.  
  
-   Add a control that is based on a native content control in the document.  
  
 Dynamically created content controls are not persisted in the document when the document is closed. However, a native content control remains in the document. You can recreate a content control that is based on a native content control the next time the document is opened. For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
> [!NOTE]  
>  To add a check box content control to a document in a Word 2010 project, you must create a <xref:Microsoft.Office.Tools.Word.ContentControl> object. For more information, see [Content Controls](../vsto/content-controls.md).  
  
#### To add a content control at the current selection  
  
1.  Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the class name of the content control that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a single parameter for the name of the new control.  
  
     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `AddRichTextControlAtSelection` method from the `ThisDocument_Startup` event handler.  
  
     [!code-csharp[Trin_ContentControlReference#700](../vsto/codesnippet/CSharp/trin_wordcontentcontrolreference/RichText.cs#700)]
     [!code-vb[Trin_ContentControlReference#700](../vsto/codesnippet/VisualBasic/trin_contentcontrolreference/RichText.vb#700)]  
  
#### To add a content control at a specified range  
  
1.  Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a <xref:Microsoft.Office.Interop.Word.Range> parameter.  
  
     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `AddRichTextControlAtRange` method from the `ThisDocument_Startup` event handler.  
  
     [!code-csharp[Trin_ContentControlReference#701](../vsto/codesnippet/CSharp/trin_wordcontentcontrolreference/RichText.cs#701)]
     [!code-vb[Trin_ContentControlReference#701](../vsto/codesnippet/VisualBasic/trin_contentcontrolreference/RichText.vb#701)]  
  
#### To add a content control that is based on a native content control  
  
1.  Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a Microsoft.Office.Interop.Word.ContentControl parameter.  
  
     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to create a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> for every native rich text control that is in the document. To run this code, add the code to the `ThisDocument` class in your project, and call the `CreateRichTextControlsFromNativeControls` method from the `ThisDocument_Startup` event handler.  
  
     [!code-csharp[Trin_ContentControlReference#702](../vsto/codesnippet/CSharp/trin_wordcontentcontrolreference/RichText.cs#702)]
     [!code-vb[Trin_ContentControlReference#702](../vsto/codesnippet/VisualBasic/trin_contentcontrolreference/RichText.vb#702)]  
  
##  <a name="runtimeaddin"></a> Adding Content Controls at Run Time in a VSTO Add-in Project  
 You can add content controls programmatically to any open document at run time by using a VSTO Add-in. To do this, generate a <xref:Microsoft.Office.Tools.Word.Document> host item that is based on an open document, and then use methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of this host item. Each method has three overloads that you can use to add a content control in the following ways:  
  
-   Add a control at the current selection.  
  
-   Add a control at a specified range.  
  
-   Add a control that is based on a native content control in the document.  
  
 Dynamically created content controls are not persisted in the document when the document is closed. However, a native content control remains in the document. You can recreate a content control that is based on a native content control the next time the document is opened. For more information, see [Persisting Dynamic Controls in Office Documents](../vsto/persisting-dynamic-controls-in-office-documents.md).  
  
 For more information about generating host items in VSTO Add-in projects, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
> [!NOTE]  
>  To add a check box content control to a document, you must create a <xref:Microsoft.Office.Tools.Word.ContentControl> object. For more information, see [Content Controls](../vsto/content-controls.md).  
  
#### To add a content control at the current selection  
  
1.  Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the class name of the content control that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a single parameter for the name of the new control.  
  
     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the active document. To run this code, add the code to the `ThisAddIn` class in your project, and call the `AddRichTextControlAtSelection` method from the `ThisAddIn_Startup` event handler.  
  
     [!code-vb[Trin_WordAddInDynamicControls#1](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#1)]
     [!code-csharp[Trin_WordAddInDynamicControls#1](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#1)]  
  
#### To add a content control at a specified range  
  
1.  Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a <xref:Microsoft.Office.Interop.Word.Range> parameter.  
  
     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to add a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the beginning of the active document. To run this code, add the code to the `ThisAddIn` class in your project, and call the `AddRichTextControlAtRange` method from the `ThisAddIn_Startup` event handler.  
  
     [!code-vb[Trin_WordAddInDynamicControls#2](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#2)]
     [!code-csharp[Trin_WordAddInDynamicControls#2](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#2)]  
  
#### To add a content control that is based on a native content control  
  
1.  Use a <xref:Microsoft.Office.Tools.Word.ControlCollection> method that has the name `Add`\<*control class*> (where *control class* is the name of the content control class that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A>), and that has a Microsoft.Office.Interop.Word.ContentControl parameter.  
  
     The following code example uses the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddRichTextContentControl%2A> method to create a new <xref:Microsoft.Office.Tools.Word.RichTextContentControl> for every native rich text control that is in a document, after the document is opened. To run this code, add the code to the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_WordAddInDynamicControls#3](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#3)]
     [!code-csharp[Trin_WordAddInDynamicControls#3](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#3)]  
  
     For C#, you must also attach the `Application_DocumentOpen` event handler to the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> event.  
  
     [!code-csharp[Trin_WordAddInDynamicControls#6](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#6)]  
  
## See Also  
 [Automating Word by Using Extended Objects](../vsto/automating-word-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)   
 [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md)  
  