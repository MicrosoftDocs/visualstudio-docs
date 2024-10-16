---
title: "Programmatically insert text into Word documents"
description: Insert text into a Microsoft Word document at a specific location or by replacing specific text  programmatically by using Visual Basic or C# in Visual Studio.
titleSuffix: ""
ms.date: "08/14/2019"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, inserting text in documents"
  - "text [Office development in Visual Studio], inserting in documents"
  - "ranges, replacing text in documents"
  - "documents [Office development in Visual Studio], inserting text"
  - "text [Office development in Visual Studio], replacing"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically insert text into Word documents

  There are three primary ways to insert text into Microsoft Office Word documents:

- Insert text in a range.

- Replace text in a range with new text.

- Use the <xref:Microsoft.Office.Interop.Word.Selection.TypeText%2A> method of a <xref:Microsoft.Office.Interop.Word.Selection> object to insert text at the cursor or selection.

> [!NOTE]
> You can also insert text into content controls and bookmarks. For more information, see [Content controls](../vsto/content-controls.md) and [Bookmark control](../vsto/bookmark-control.md).

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

## Insert text in a range
 Use the <xref:Microsoft.Office.Interop.Word.Range.Text%2A> property of a <xref:Microsoft.Office.Interop.Word.Range> object to insert text in a document.

### To insert text in a range

1. Specify a range at the beginning of a document and insert the text **New Text**.

     The following code example can be used in a document-level customization.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet51":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet51":::
     ---

     The following code example can be used in a VSTO Add-in. This code uses the active document.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet51":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet51":::
     ---

2. Select the <xref:Microsoft.Office.Interop.Word.Range> object, which has expanded from one character to the length of the inserted text.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet52":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet52":::
     ---

## Replace text in a range
 If the specified range contains text, all text in the range is replaced with the inserted text.

### To replace text in a range

1. Create a <xref:Microsoft.Office.Interop.Word.Range> object that consists of the first 12 characters in the document.

     The following code example can be used in a document-level customization.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet53":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet53":::
     ---

     The following code example can be used in a VSTO Add-in. This code uses the active document.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet53":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet53":::
     ---

2. Replace those characters with the string **New Text**.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet54":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet54":::
     ---

3. Select the range.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet55":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet55":::
     ---

## Insert text using TypeText
 The <xref:Microsoft.Office.Interop.Word.Selection.TypeText%2A> method inserts text at the selection. <xref:Microsoft.Office.Interop.Word.Selection.TypeText%2A> behaves differently depending on the options set on the user's computer. The code in the following procedure declares a <xref:Microsoft.Office.Interop.Word.Selection> object variable, and turns off the **Overtype** option if it is turned on. If the **Overtype** option is activated, then any text next to the cursor is overwritten.

### To insert text using the TypeText method

1. Declare a <xref:Microsoft.Office.Interop.Word.Selection> object variable.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet57":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet57":::
    ---

2. Turn off the **Overtype** option if it is turned on.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet58":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet58":::
    ---

3. Test to see whether the current selection is an insertion point.

    If it is, the code inserts a sentence using <xref:Microsoft.Office.Interop.Word.Selection.TypeText%2A>, and then a paragraph mark using the <xref:Microsoft.Office.Interop.Word.Selection.TypeParagraph%2A> method.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet59":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet59":::
    ---

4. The code in the **ElseIf** block tests to see whether the selection is a normal selection. If it is, then another **If** block tests to see whether the **ReplaceSelection** option is turned on. If it is, the code uses the <xref:Microsoft.Office.Interop.Word.Selection.Collapse%2A> method of the selection to collapse the selection to an insertion point at the start of the selected block of text. Insert the text and a paragraph mark.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet60":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet60":::
    ---

5. If the selection is not an insertion point or a block of selected text, then the code in the **Else** block does nothing.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet61":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet61":::
    ---

   You can also use the <xref:Microsoft.Office.Interop.Word.Selection.TypeBackspace%2A> method of the <xref:Microsoft.Office.Interop.Word.Selection> object, which mimics the functionality of the **Backspace** key on your keyboard. However, when it comes to inserting and manipulating text, the <xref:Microsoft.Office.Interop.Word.Range> object offers you more control.

   The following example shows the complete code. To use this example, run the code from the `ThisDocument` or `ThisAddIn` class in your project.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet56":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet56":::
   ---

## Related content
- [How to: Programmatically format text in documents](../vsto/how-to-programmatically-format-text-in-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
