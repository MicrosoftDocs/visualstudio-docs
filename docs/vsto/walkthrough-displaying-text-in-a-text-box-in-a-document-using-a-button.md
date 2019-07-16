---
title: "Display text in text box in document using button"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "text boxes, displaying text in documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Display text in a text box in a document using a button
  This walkthrough demonstrates how to use buttons and text boxes in a document-level customization for Microsoft Office Word.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- Adding controls to the Word document in a document-level project at design time.

- Populating a text box when a button is clicked.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Word

## Create the project
 The first step is to create a Word Document project.

### To create a new project

1. Create a Word Document project with the name **My Word Button**. In the wizard, select **Create a new document**.

     For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Word document in the designer and adds the **My Word Button** project to **Solution Explorer**.

## Add controls to the Word document
 The user interface controls consist of a button and a text box on the Word document.

### To add a button and a text box

1. Verify that the document is open in the Visual Studio designer.

2. From the **Common Controls** tab of the **Toolbox**, drag a <xref:Microsoft.Office.Tools.Word.Controls.TextBox> control to the document.

   > [!NOTE]
   > In Word, controls are dropped in-line with text by default. You can modify the way controls and shape objects are inserted by changing the default on the **Edit** tab of the **Options** dialog box in Word.

3. On the **View** menu, click **Properties Window**.

4. Find **TextBox1** in the **Properties** window drop-down box and change the **Name** property of the text box to **displayText**.

5. Drag a **Button** control to the document and change the following properties.

   |Property|Value|
   |--------------|-----------|
   |**Name**|**insertText**|
   |**Text**|**Insert Text**|

   Now you can write the code that will run when the button is clicked.

## Populate the text box when the button is clicked
 Every time the user clicks the button, **Hello World!** is added to the text box.

### To write to the text box when the button is clicked

1. In **Solution Explorer**, right-click **ThisDocument**, and then click **View Code** on the shortcut menu.

2. Add the following code to the <xref:System.Windows.Forms.Control.Click> event handler of the button.

     [!code-vb[Trin_VstcoreProgrammingControlsWord#7](../vsto/codesnippet/VisualBasic/my chart options/ThisDocument.vb#7)]
     [!code-csharp[Trin_VstcoreProgrammingControlsWord#7](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsWordCS/ThisDocument.cs#7)]

3. In C#, you must add an event handler for the button to the <xref:Microsoft.Office.Tools.Word.Document.Startup> event. For information about creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     [!code-csharp[Trin_VstcoreProgrammingControlsWord#8](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsWordCS/ThisDocument.cs#8)]

## Test the application
 You can now test your document to make sure that the message **Hello World!** appears in the text box when you click the button.

### To test your document

1. Press **F5** to run your project.

2. Click the button.

3. Confirm that **Hello World!** appears in the text box.

## Next steps
 This walkthrough shows the basics of using buttons and text boxes on Word documents. Here are some tasks that might come next:

- Using a combo box to change formatting. For more information, see [Walkthrough: Change document formatting using CheckBox controls](../vsto/walkthrough-changing-document-formatting-using-checkbox-controls.md).

- Using radio buttons to select chart styles. For more information, see [Walkthrough: Update a chart in a document using radio buttons](../vsto/walkthrough-updating-a-chart-in-a-document-using-radio-buttons.md).

## See also
- [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)
- [Walkthroughs using Word](../vsto/walkthroughs-using-word.md)
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [How to: Add Windows Forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
