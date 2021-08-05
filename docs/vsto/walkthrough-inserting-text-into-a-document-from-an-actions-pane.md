---
title: "Walkthrough: Insert text into a document from an actions pane"
description: Create an actions pane in a Microsoft Word document. Learn that the actions pane contains two controls that collect input and then send the text to the document.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "smart documents [Office development in Visual Studio], creating in Word"
  - "smart documents [Office development in Visual Studio], adding controls"
  - "actions panes [Office development in Visual Studio], creating in Word"
  - "actions panes [Office development in Visual Studio], adding controls"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Walkthrough: Insert text into a document from an actions pane
  This walkthrough demonstrates how to create an actions pane in a Microsoft Office Word document. The actions pane contains two controls that collect input and then send the text to the document.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- Design an interface by using Windows Forms controls on an actions pane control.

- Display the actions pane when the application opens.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- [!INCLUDE[Word_15_short](../vsto/includes/word-15-short-md.md)] or [!INCLUDE[Word_14_short](../vsto/includes/word-14-short-md.md)].

## Create the project
 The first step is to create a Word Document project.

### To create a new project

1. Create a Word Document project with the name **My Basic Actions Pane**. In the wizard, select **Create a new document**. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Word document in the designer and adds the **My Basic Actions Pane** project to **Solution Explorer**.

## Add text and bookmarks to the document
 The actions pane will send text to bookmarks in the document. To design the document, type some text to create a basic form.

### To add text to your document

1. Type the following text into your Word document:

    **March 21, 2008**

    **Name**

    **Address**

    **This is an example of a basic actions pane in Word.**

   You can add a <xref:Microsoft.Office.Tools.Word.Bookmark> control to your document by dragging it from the **Toolbox** in Visual Studio or by using the **Bookmark** dialog box in Word.

### To add a Bookmark control to your document

1. From the **Word Controls** tab of the **Toolbox**, drag a <xref:Microsoft.Office.Tools.Word.Bookmark> control to your document.

     The **Add Bookmark Control** dialog box appears.

2. Select the word **Name**, without selecting the paragraph mark, and click **OK**.

    > [!NOTE]
    > The paragraph mark should be outside of the bookmark. If paragraph marks are not visible in the document, click the **Tools** menu, point to **Microsoft Office Word Tools** and then click **Options**. Click the **View** tab, and select the **Paragraph marks** check box in the **Formatting marks** section of the **Options** dialog box.

3. In the **Properties** window, change the **Name** property of **Bookmark1** to **showName**.

4. Select the word **Address**, without selecting the paragraph mark.

5. On the **Insert** tab of the Ribbon, in the **Links** group, click **Bookmark**.

6. In the **Bookmark** dialog box, type **showAddress** in the **Bookmark Name** box and click **Add**.

## Add controls to the actions pane
 To design the actions pane interface, add an actions pane control to the project and then add Windows Forms controls to the actions pane control.

### To add an actions pane control

1. Select the **My Basic Actions Pane** project in **Solution Explorer**.

2. On the **Project** menu, click **Add New Item**.

3. In the **Add New Item** dialog box, click **Actions Pane Control**, name the control **InsertTextControl,** and click **Add**.

#### To add Windows Form controls to the actions pane control

1. If the actions pane control is not visible in the designer, double-click **InsertTextControl**.

2. From the **Common Controls** tab of the **Toolbox**, drag a **Label** control to the actions pane control.

3. Change the **Text** property of the Label control to **Name**.

4. Add a **Textbox** control to the actions pane control, and change the following properties.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**getName**|
    |**Size**|**130, 20**|

5. Add a second **Label** control to the actions pane control, and change the **Text** property to **Address**.

6. Add a second **Textbox** control to the actions pane control, and change the following properties.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**getAddress**|
    |**Accepts Return**|**True**|
    |**Multiline**|**True**|
    |**Size**|**130, 40**|

7. Add a **Button** control to the actions pane control, and change the following properties.

    |Property|Value|
    |--------------|-----------|
    |**Name**|**addText**|
    |**Text**|**Insert**|

## Add code to insert text into the document
 In the actions pane, write code that inserts the text from the text boxes into the appropriate <xref:Microsoft.Office.Tools.Word.Bookmark> controls in the document. You can use the `Globals` class to access controls on the document from the controls on the actions pane. For more information, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

### To insert text from the actions pane in a bookmark in the document

1. Add the following code to the <xref:System.Windows.Forms.Control.Click> event handler of the **addText** button.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/InsertTextControl.cs" id="Snippet8":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/InsertTextControl.vb" id="Snippet8":::

2. In C#, you must add an event handler for the button click. You can place this code in the `InsertTextControl` constructor after the call to `InitializeComponent`. For information about creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/InsertTextControl.cs" id="Snippet9":::

## Add code to show the actions pane
 To show the actions pane, add the control you created to the control collection.

### To show the actions pane

1. Create a new instance of the actions pane control in the `ThisDocument` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs" id="Snippet10":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb" id="Snippet10":::

2. Add the following code to the <xref:Microsoft.Office.Tools.Word.Document.Startup> event handler of `ThisDocument`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs" id="Snippet11":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb" id="Snippet11":::

## Test the application
 Test your document to verify that the actions pane opens when the document is opened and that text typed into the text boxes is inserted into the bookmarks when the button is clicked.

### To test your document

1. Press **F5** to run your project.

2. Confirm that the actions pane is visible.

3. Type your name and address into the text boxes on the actions pane and click **Insert**.

## Next steps
 Here are some tasks that might come next:

- Create an actions pane in Excel. For more information, see [How to: Add an actions pane to Excel workbooks](/previous-versions/visualstudio/visual-studio-2010/e3zbk0hz(v=vs.100)).

- Bind data to controls on an actions pane. For more information, see [Walkthrough: Bind data to controls on a Word actions pane](../vsto/walkthrough-binding-data-to-controls-on-a-word-actions-pane.md).

## See also
- [Actions pane overview](../vsto/actions-pane-overview.md)
- [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)
- [How to: Add an actions pane to Excel workbooks](/previous-versions/visualstudio/visual-studio-2010/e3zbk0hz(v=vs.100))
- [How to: Manage control layout on actions panes](../vsto/how-to-manage-control-layout-on-actions-panes.md)
- [Bookmark control](../vsto/bookmark-control.md)
