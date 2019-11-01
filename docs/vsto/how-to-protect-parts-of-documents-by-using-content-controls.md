---
title: "How to: Protect parts of documents by using content controls"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "restricted permissions [Office development in Visual Studio]"
  - "partial document protection [Office development in Visual Studio]"
  - "content controls [Office development in Visual Studio], protecting documents"
  - "Word [Office development in Visual Studio], partial document protection"
  - "document protection [Office development in Visual Studio]"
  - "Word [Office development in Visual Studio], restricted permissions"
  - "GroupContentControl"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Protect parts of documents by using content controls
  When you protect part of a document, you prevent users from changing or deleting the content in that part of the document. There are several ways you can protect parts of a Microsoft Office Word document by using content controls:

- You can protect a content control.

- You can protect a part of a document that is not in a content control.

  [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## <a name="EditDeleteControl"></a> Protect a content control
 You can prevent users from editing or deleting a content control by setting properties of the control in a document-level project at design time or at run time.

 You can also protect content controls that you add to a document at run time by using a VSTO Add-in project. For more information, see [How to: Add content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md).

### To protect a content control at design time

1. In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, select the content control that you want to protect.

2. In the **Properties** window, set one or both of the following properties:

    - To prevent users from editing the control, set **LockContents** to **True**.

    - To prevent users from deleting the control, set **LockContentControl** to **True**.

3. Click **OK**.

### To protect a content control at run time

1. Set the `LockContents` property of the content control to **true** to prevent users from editing the control, and set the `LockContentControl` property to **true** to prevent users from deleting the control.

     The following code example demonstrates using the <xref:Microsoft.Office.Tools.Word.RichTextContentControl.LockContents%2A> and <xref:Microsoft.Office.Tools.Word.RichTextContentControl.LockContentControl%2A> properties of two different <xref:Microsoft.Office.Tools.Word.RichTextContentControl> objects in a document-level project. To run this code, add the code to the `ThisDocument` class in your project, and call the `AddProtectedContentControls` method from the `ThisDocument_Startup` event handler.

     [!code-csharp[Trin_ContentControlHowToProtect#2](../vsto/codesnippet/CSharp/Trin_ContentControlHowToProtect/ThisDocument.cs#2)]
     [!code-vb[Trin_ContentControlHowToProtect#2](../vsto/codesnippet/VisualBasic/Trin_ContentControlHowToProtect/ThisDocument.vb#2)]

     The following code example demonstrates using the <xref:Microsoft.Office.Tools.Word.RichTextContentControl.LockContents%2A> and <xref:Microsoft.Office.Tools.Word.RichTextContentControl.LockContentControl%2A> properties of two different <xref:Microsoft.Office.Tools.Word.RichTextContentControl> objects in a VSTO Add-in project. To run this code, add the code to the `ThisAddIn` class in your project, and call the `AddProtectedContentControls` method from the `ThisAddIn_Startup` event handler.

     [!code-vb[Trin_WordAddInDynamicControls#14](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#14)]
     [!code-csharp[Trin_WordAddInDynamicControls#14](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#14)]

## Protect a part of a document that is not in a content control
 You can prevent users from changing an area of a document by putting the area in a <xref:Microsoft.Office.Tools.Word.GroupContentControl>. This is useful in the following scenarios:

- You want to protect an area that does not contain content controls.

- You want to protect an area that already contains content controls, but the text or other items that you want to protect are not in the content controls.

> [!NOTE]
> If you create a <xref:Microsoft.Office.Tools.Word.GroupContentControl> that contains embedded content controls, the embedded content controls are not automatically protected. To prevent users from editing an embedded content control, use the **LockContents** property of the control.

### To protect an area of a document at design time

1. In the document that is hosted in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer, select the area that you want to protect.

2. On the Ribbon, click the **Developer** tab.

    > [!NOTE]
    > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

3. In the **Controls** group, click the **Group** drop-down button, and then click **Group**.

     A <xref:Microsoft.Office.Tools.Word.GroupContentControl> that contains the protected region is automatically generated in the `ThisDocument` class in your project. A border that represents the group control is visible at design time, but there is no visible border at run time.

### To protect an area of a document at run time

1. Programmatically select the area that you want to protect, and then call the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddGroupContentControl%2A> method to create a <xref:Microsoft.Office.Tools.Word.GroupContentControl>.

     The following code example for a document-level project adds text to the first paragraph in the document, selects the first paragraph, and then instantiates a <xref:Microsoft.Office.Tools.Word.GroupContentControl>. To run this code, add the code to the `ThisDocument` class in your project, and call the `ProtectFirstParagraph` method from the `ThisDocument_Startup` event handler.

     [!code-csharp[Trin_ContentControlHowToProtect#1](../vsto/codesnippet/CSharp/Trin_ContentControlHowToProtect/ThisDocument.cs#1)]
     [!code-vb[Trin_ContentControlHowToProtect#1](../vsto/codesnippet/VisualBasic/Trin_ContentControlHowToProtect/ThisDocument.vb#1)]

     The following code example for a VSTO Add-in project adds text to the first paragraph in the active document, selects the first paragraph, and then instantiates a <xref:Microsoft.Office.Tools.Word.GroupContentControl>. To run this code, add the code to the `ThisAddIn` class in your project, and call the `ProtectFirstParagraph` method from the `ThisAddIn_Startup` event handler.

     [!code-vb[Trin_WordAddInDynamicControls#15](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#15)]
     [!code-csharp[Trin_WordAddInDynamicControls#15](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#15)]

## See also
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Content controls](../vsto/content-controls.md)
- [How to: Add content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
