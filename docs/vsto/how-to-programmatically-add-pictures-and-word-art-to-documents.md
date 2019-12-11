---
title: "Add pictures and Word Art to documents programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], adding pictures"
  - "Word documents, adding pictures"
  - "Word documents, adding Word Art"
  - "graphics, adding to Word documents"
  - "WordArt, adding to documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically add pictures and Word Art to documents
  You can add pictures and drawing objects to your documents at design time or during run time. WordArt enables you to add decorative text to Microsoft Office Word documents. These special text effects are drawing objects that you can customize and insert into your document.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Add a picture at design time
 If you are developing a document-level customization, you can add a picture to the document at design time.

### To add a picture to a Word document at design time

1. Place your cursor where you want to insert the picture in the document.

2. Click the **Insert** tab of the ribbon.

3. In the **Illustrations** group, click **Picture**.

4. In the **Insert Picture** dialog box, navigate to the picture you want to insert, and click **Insert**.

     The picture is added to your document at the current cursor location.

## Add a picture at run time
 You can insert a picture into a document at the current cursor location.

### To add a picture at the cursor location

1. Call the <xref:Microsoft.Office.Interop.Word.InlineShapes.AddPicture%2A> method of the <xref:Microsoft.Office.Interop.Word.InlineShapes> collection and pass in the name of the file.

     [!code-vb[Trin_VstcoreWordAutomation#108](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#108)]
     [!code-csharp[Trin_VstcoreWordAutomation#108](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#108)]

## Add WordArt at design time
 If you are developing a document-level customization, you can add WordArt to the document at design time.

### To add WordArt to a Word document at design time

1. Place your cursor where you want to insert the WordArt in the document.

2. Click the **Insert** tab of the Ribbon.

3. In the **Text** group, click **WordArt**, and then select a WordArt style.

4. Add the text that you want to appear in the document to the **Edit WordArt Text** dialog box and click **OK**.

     The text is added to your document with the selected WordArt style applied.

## Add WordArt at run time
 You can insert WordArt into a document at the current cursor location. The procedure is different for document-level customizations and VSTO Add-ins.

### To add WordArt at the cursor location in a document-level customization

1. Get the left and top position of the current cursor location.

     [!code-vb[Trin_VstcoreWordAutomation#109](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#109)]
     [!code-csharp[Trin_VstcoreWordAutomation#109](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#109)]

2. Call the <xref:Microsoft.Office.Interop.Word.Shapes.AddTextEffect%2A> method of the <xref:Microsoft.Office.Interop.Word.Shapes> object in the document.

     [!code-vb[Trin_VstcoreWordAutomation#110](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#110)]
     [!code-csharp[Trin_VstcoreWordAutomation#110](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#110)]

### To add WordArt at the cursor location in a VSTO Add-in

1. Get the left and top position of the current cursor location.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#109](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#109)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#109](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#109)]

2. Call the <xref:Microsoft.Office.Interop.Word.Shapes.AddTextEffect%2A> method of the <xref:Microsoft.Office.Interop.Word.Shapes> object of the active document (or a different document that you specify).

     [!code-vb[Trin_VstcoreWordAutomationAddIn#110](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#110)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#110](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#110)]

## Compile the code

- A picture named *SamplePicture.jpg* must exist on drive C.

## See also
- [How to: Programmatically open existing documents](../vsto/how-to-programmatically-open-existing-documents.md)
- [How to: Programmatically insert text into Word documents](../vsto/how-to-programmatically-insert-text-into-word-documents.md)
- [How to: Programmatically restore selections after searches](../vsto/how-to-programmatically-restore-selections-after-searches.md)
- [How to: Programmatically save documents](../vsto/how-to-programmatically-save-documents.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
