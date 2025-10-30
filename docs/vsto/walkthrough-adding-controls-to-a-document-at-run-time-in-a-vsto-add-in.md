---
title: "Add controls to document at run time in VSTO Add-in"
description: Learn how to use the ribbon to enable users to add a Button class or a RichTextContentControl interface to a document.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "add-ins [Office development in Visual Studio], adding controls"
  - "application-level add-ins [Office development in Visual Studio], adding controls"
  - "controls [Office development in Visual Studio], adding to documents at run time"
  - "documents [Office development in Visual Studio], adding controls at run time"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Add controls to a document at run time in a VSTO Add-in

  You can add controls to any open Microsoft Office Word document by using a VSTO Add-in. This walkthrough demonstrates how to use the ribbon to enable users to add a <xref:Microsoft.Office.Tools.Word.Controls.Button> or a <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to a document.

 **Applies to:** The information in this topic applies to VSTO Add-in projects for Word 2010. For more information, see [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).

 This walkthrough illustrates the following tasks:

- Creating a new Word VSTO Add-in project.

- Providing a user interface (UI) to add controls to the document.

- Adding controls to the document at run time.

- Removing controls from the document.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Word 2013  or  Word 2010 .

## Create a new Word Add-in project
 Start by creating a Word VSTO Add-in project.

### To create a new Word VSTO Add-in project

1. Create a VSTO Add-in project for Word with the name **WordDynamicControls**. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. Add a reference to the **Microsoft.Office.Tools.Word.v4.0.Utilities.dll** assembly. This reference is required to programmatically add a Windows Forms control to the document later in this walkthrough.

## Provide a UI to add controls to a document
 Add a custom tab to the Ribbon in Word. Users can select check boxes on the tab to add controls to a document.

### To provide a UI to add controls to a document

1. On the **Project** menu, click **Add New Item**.

2. In the **Add New Item** dialog box, select **Ribbon (Visual Designer)**.

3. Change the name of the new Ribbon to **MyRibbon**, and click **Add**.

    The **MyRibbon.cs** or **MyRibbon.vb** file opens in the Ribbon Designer and displays a default tab and group.

4. In the Ribbon Designer, click the **group1** group.

5. In the **Properties** window, change the **Label** property for **group1** to **Add Controls**.

6. From the **Office Ribbon Controls** tab of the **Toolbox**, drag a **CheckBox** control onto **group1**.

7. Click **CheckBox1** to select it.

8. In the **Properties** window, change the following properties.

   | Property | Value |
   |-----------|-----------------------|
   | **Name** | **addButtonCheckBox** |
   | **Label** | **Add Button** |

9. Add a second check box to **group1**, and then change the following properties.

   | Property | Value |
   |-----------|---------------------------|
   | **Name** | **addRichTextCheckBox** |
   | **Label** | **Add Rich Text Control** |

10. In the Ribbon Designer, double-click **Add Button**.

     The <xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox.Click> event handler of the **Add Button** check box opens in the Code Editor.

11. Return to the Ribbon Designer, and double-click **Add Rich Text Control**.

     The <xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox.Click> event handler of the **Add Rich Text Control** check box opens in the Code Editor.

    Later in this walkthrough, you will add code to these event handlers to add and remove controls on the active document.

## Add and remove controls on the active document
 In the VSTO Add-in code, you must convert the active document into a <xref:Microsoft.Office.Tools.Word.Document>*host item* before you can add a control. In Office solutions, managed controls can be added only to host items, which act as containers for the controls. In VSTO Add-in projects, host items can be created at run time by using the `GetVstoObject` method.

 Add methods to the `ThisAddIn` class that can be called to add or remove a <xref:Microsoft.Office.Tools.Word.Controls.Button> or <xref:Microsoft.Office.Tools.Word.RichTextContentControl> on the active document. Later in this walkthrough, you will call these methods from the <xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox.Click> event handlers of the check boxes on the Ribbon.

### To add and remove controls on the active document

1. In **Solution Explorer**, double-click *ThisAddIn.cs* or *ThisAddIn.vb* to open the file in the Code Editor.

2. Add the following code to the `ThisAddIn` class. This code declares <xref:Microsoft.Office.Tools.Word.Controls.Button> and <xref:Microsoft.Office.Tools.Word.RichTextContentControl> objects that represent the controls that will be added to the document.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.vb" id="Snippet1":::
     ---

3. Add the following method to the `ThisAddIn` class. When the user clicks the **Add Button** check box on the Ribbon, this method adds a <xref:Microsoft.Office.Tools.Word.Controls.Button> to the current selection on the document if the check box is selected, or removes the <xref:Microsoft.Office.Tools.Word.Controls.Button> if the check box is cleared.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.vb" id="Snippet2":::
     ---

4. Add the following method to the `ThisAddIn` class. When the user clicks the **Add Rich Text Control** check box on the Ribbon, this method adds a <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the current selection on the document if the check box is selected, or removes the <xref:Microsoft.Office.Tools.Word.RichTextContentControl> if the check box is cleared.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.vb" id="Snippet3":::
     ---

## Remove the Button control when the document is saved
 Windows Forms controls are not persisted when the document is saved and then closed. However, an ActiveX wrapper for each control remains in the document, and the border of this wrapper can be seen by end users when the document is reopened. There are several ways to clean up dynamically created Windows Forms controls in VSTO Add-ins. In this walkthrough, you programmatically remove the <xref:Microsoft.Office.Tools.Word.Controls.Button> control when the document is saved.

### To remove the Button control when the document is saved

1. In the *ThisAddIn.cs* or *ThisAddIn.vb* code file, add the following method to the `ThisAddIn` class. This method is an event handler for the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentBeforeSave> event. If the saved document has a <xref:Microsoft.Office.Tools.Word.Document> host item that is associated with it, the event handler gets the host item and removes the <xref:Microsoft.Office.Tools.Word.Controls.Button> control, if it exists.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.vb" id="Snippet4":::
     ---

2. In C#, add the following code to the `ThisAddIn_Startup` event handler. This code is required in C# to connect the `Application_DocumentBeforeSave` event handler with the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentBeforeSave> event.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControlsWalkthrough/ThisAddIn.cs" id="Snippet5":::

## Add and remove controls when the user clicks the check boxes on the ribbon
 Finally, modify the <xref:Microsoft.Office.Tools.Ribbon.RibbonCheckBox.Click> event handlers of the check boxes you added to the ribbon to add or remove controls on the document.

### To add or remove controls when the user clicks the check boxes on the ribbon

1. In the *MyRibbon.cs* or *MyRibbon.vb* code file, replace the generated `addButtonCheckBox_Click` and `addRichTextCheckBox_Click` event handlers with the following code. This code redefines these event handlers to call the `ToggleButtonOnDocument` and `ToggleRichTextControlOnDocument` methods that you added to the `ThisAddIn` class earlier in this walkthrough.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControlsWalkthrough/MyRibbon.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_WordAddInDynamicControlsWalkthrough/MyRibbon.vb" id="Snippet6":::
     ---

## Test the solution
 Add controls to a document by selecting them from the custom tab on the Ribbon. When you save the document, the <xref:Microsoft.Office.Tools.Word.Controls.Button> control is removed.

### To test the solution.

1. Press **F5** to run your project.

2. In the active document, press **Enter** several times to add new empty paragraphs to the document.

3. Select the first paragraph.

4. Click the **Add-Ins** tab.

5. In the **Add Controls** group, click **Add Button**.

     A button appears in the first paragraph.

6. Select the last paragraph.

7. In the **Add Controls** group, click **Add Rich Text Control**.

     A rich text content control is added to the last paragraph.

8. Save the document.

     The button is removed from the document.

## Next steps
 You can learn more about controls in VSTO Add-ins from these topics:

- For a sample that demonstrates how to add many other types of controls to a document at run time and recreate the controls when the document is reopened, see the Word Add-In Dynamic Controls Sample at [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).

- For a walkthrough that demonstrates how to add controls to a worksheet by using a VSTO Add-in for Excel, see [Walkthrough: Add controls to a worksheet at run time in VSTO add-in project](../vsto/walkthrough-adding-controls-to-a-worksheet-at-run-time-in-vsto-add-in-project.md).

## Related content
- [Word solutions](../vsto/word-solutions.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Persist dynamic controls in Office documents](../vsto/persisting-dynamic-controls-in-office-documents.md)
- [How to: Add Windows Forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)
- [How to: Add content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
