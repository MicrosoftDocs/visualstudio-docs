---
title: "Walkthrough: Create a template by using content controls"
description: Learn how to create a document-level customization that uses content controls to create structured and reusable content in a Microsoft Word template.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "building blocks [Office development in Visual Studio]"
  - "Word [Office development in Visual Studio], creating documents"
  - "content controls [Office development in Visual Studio], adding to documents"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create a template by using content controls

  This walkthrough demonstrates how to create a document-level customization that uses content controls to create structured and reusable content in a Microsoft Office Word template.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 Word enables you to create a collection of reusable document parts, named *building blocks*. This walkthrough shows how to create two tables as building blocks. Each table contains several content controls that can hold different types of content, such as plain text or dates. One of the tables contains information about an employee, and the other table contains customer feedback.

 After you create a document from the template, you can add either of the tables to the document by using several <xref:Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl> objects, which display the available building blocks in the template.

 This walkthrough illustrates the following tasks:

- Creating tables that contain content controls in a Word template at design time.

- Populating a combo box content control and a drop-down list content control programmatically.

- Preventing users from editing a specified table.

- Adding tables to the building block collection of a template.

- Creating a content control that displays the available building blocks in the template.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Word.

## Create a new Word template project
 Create a Word template so that users can create their own copies easily.

### To create a new Word template project

1. Create a Word template project with the name **MyBuildingBlockTemplate**. In the wizard, create a new document in the solution. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Word template in the designer and adds the **MyBuildingBlockTemplate** project to **Solution Explorer**.

## Create the employee table
 Create a table that contains four different types of content controls where the user can enter information about an employee.

### To create the employee table

1. In the Word template that is hosted in the Visual Studio designer, on the Ribbon, click the **Insert** tab.

2. In the **Tables** group, click **Table**, and insert a table with two columns and four rows.

3. Type text in the first column so that it resembles the following column:

   ||
   |-|
   |**Employee Name**|
   |**Hire Date**|
   |**Title**|
   |**Picture**|

4. Click in the first cell in the second column (next to **Employee Name**).

5. On the Ribbon, click the **Developer** tab.

   > [!NOTE]
   > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

6. In the **Controls** group, click the **Text** button ![PlainTextContentControl](../vsto/media/plaintextcontrol.gif "PlainTextContentControl") to add a <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> to the first cell.

7. Click the second cell in the second column (next to **Hire Date**).

8. In the **Controls** group, click the **Date Picker** button ![DatePickerContentControl](../vsto/media/datepicker.gif "DatePickerContentControl") to add a <xref:Microsoft.Office.Tools.Word.DatePickerContentControl> to the second cell.

9. Click the third cell in the second column (next to **Title**).

10. In the **Controls** group, click the **Combo Box** button ![ComboBoxContentControl](../vsto/media/combobox.gif "ComboBoxContentControl") to add a <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl> to the third cell.

11. Click the last cell in the second column (next to **Picture**).

12. In the **Controls** group, click the **Picture Content Control** button ![PictureContentControl](../vsto/media/pictcontentcontrol.gif "PictureContentControl") to add a <xref:Microsoft.Office.Tools.Word.PictureContentControl> to the last cell.

## Create the customer feedback table
 Create a table that contains three different types of content controls where the user can enter customer feedback information.

### To create the customer feedback table

1. In the Word template, click in the line after the employee table that you added earlier, and press **Enter** to add a new paragraph.

2. On the Ribbon, click the **Insert** tab.

3. In the **Tables** group, click **Table**, and insert a table with two columns and three rows.

4. Type text in the first column so that it resembles the following column:

   ||
   |-|
   |**Customer Name**|
   |**Satisfaction Rating**|
   |**Comments**|

5. Click in the first cell of the second column (next to **Customer Name**).

6. On the Ribbon, click the **Developer** tab.

7. In the **Controls** group, click the **Text** button ![PlainTextContentControl](../vsto/media/plaintextcontrol.gif "PlainTextContentControl") to add a <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> to the first cell.

8. Click in the second cell of the second column (next to **Satisfaction Rating**).

9. In the **Controls** group, click the **Drop-Down List** button ![DropDownListContentControl](../vsto/media/dropdownlist.gif "DropDownListContentControl") to add a <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> to the second cell.

10. Click in the last cell of the second column (next to **Comments**).

11. In the **Controls** group, click the **Rich Text** button ![RichTextContentControl](../vsto/media/richtextcontrol.gif "RichTextContentControl") to add a <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to the last cell.

## Populate the combo box and drop-down list programmatically
 You can initialize content controls at design time by using the **Properties** window in Visual Studio. You can also initialize them at run time, which enables you to set their initial states dynamically. For this walkthrough, use code to populate the entries in the <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl> and <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> at run time so that you can see how these objects work.

### To modify the UI of the content controls programmatically

1. In **Solution Explorer**, right-click **ThisDocument.cs** or **ThisDocument.vb**, and then click **View Code**.

2. Add the following code to the `ThisDocument` class. This code declares several objects that you will use later in this walkthrough.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/ContentControlTemplateWalkthrough/ThisDocument.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/ContentControlTemplateWalkthrough/ThisDocument.vb" id="Snippet1":::
     ---

3. Add the following code to the `ThisDocument_Startup` method of the `ThisDocument` class. This code adds entries to the <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl> and <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> in the tables, and sets the placeholder text that is displayed in each of these controls before the user edits them.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/ContentControlTemplateWalkthrough/ThisDocument.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/ContentControlTemplateWalkthrough/ThisDocument.vb" id="Snippet2":::
     ---

## Prevent users from editing the employee table
 Use the <xref:Microsoft.Office.Tools.Word.GroupContentControl> object that you declared earlier to protect the employee table. After protecting the table, users can still edit the content controls in the table. However, they cannot edit text in the first column or modify the table in other ways, such as adding or deleting rows and columns. For more information about how to use a <xref:Microsoft.Office.Tools.Word.GroupContentControl> to protect a part of a document, see [Content controls](../vsto/content-controls.md).

### To prevent users from editing the employee table

1. Add the following code to the `ThisDocument_Startup` method of the `ThisDocument` class, after the code that you added in the previous step. This code prevents users from editing the employee table by putting the table inside the <xref:Microsoft.Office.Tools.Word.GroupContentControl> object that you declared earlier.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/ContentControlTemplateWalkthrough/ThisDocument.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/ContentControlTemplateWalkthrough/ThisDocument.vb" id="Snippet3":::
     ---

## Add the tables to the building block collection
 Add the tables to a collection of document building blocks in the template so that users can insert the tables that you have created into the document. For more information about document building blocks, see [Content controls](../vsto/content-controls.md).

### To add the tables to the building blocks in the template

1. Add the following code to the `ThisDocument_Startup` method of the `ThisDocument` class, after the code that you added in the previous step. This code adds new building blocks that contain the tables to the Microsoft.Office.Interop.Word.BuildingBlockEntries collection, which contains all the reusable building blocks in the template. The new building blocks are defined in a new category named **Employee and Customer Information** and are assigned the building block type `Microsoft.Office.Interop.Word.WdBuildingBlockTypes.wdTypeCustom1`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/ContentControlTemplateWalkthrough/ThisDocument.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/ContentControlTemplateWalkthrough/ThisDocument.vb" id="Snippet4":::
     ---

2. Add the following code to the `ThisDocument_Startup` method of the `ThisDocument` class, after the code that you added in the previous step. This code deletes the tables from the template. The tables are no longer necessary, because you have added them to the gallery of reusable building blocks in the template. The code first puts the document into design mode so that the protected employee table can be deleted.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/ContentControlTemplateWalkthrough/ThisDocument.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/ContentControlTemplateWalkthrough/ThisDocument.vb" id="Snippet5":::
     ---

## Create a content control that displays the building blocks
 Create a content control that provides access to the building blocks (that is, the tables) that you created earlier. Users can click this control to add the tables to the document.

### To create a content control that displays the building blocks

1. Add the following code to the `ThisDocument_Startup` method of the `ThisDocument` class, after the code that you added in the previous step. This code initializes the <xref:Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl> object that you declared earlier. The <xref:Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl> displays all building blocks that are defined in the category **Employee and Customer Information** and that have the building block type `Microsoft.Office.Interop.Word.WdBuildingBlockTypes.wdTypeCustom1`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/ContentControlTemplateWalkthrough/ThisDocument.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/ContentControlTemplateWalkthrough/ThisDocument.vb" id="Snippet6":::
     ---

## Test the project
 Users can click the building block gallery controls in the document to insert the employee table or the customer feedback table. Users can type or select responses in the content controls in both of the tables. Users can modify other parts of the customer feedback table, but they should not be able to modify other parts of the employee table.

### To test the employee table

1. Press **F5** to run the project.

2. Click **Choose your first building block** to display the first building block gallery content control.

3. Click the drop-down arrow next to the **Custom Gallery 1** heading in the control, and select **Employee Table**.

4. Click in the cell to the right of the **Employee Name** cell and type a name.

     Verify that you can add only text to this cell. The <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> allows users to add only text, not other types of content such as art or a table.

5. Click in the cell to the right of the **Hire Date** cell and select a date in the date picker.

6. Click in the cell to the right of the **Title** cell and select one of the job titles in the combo box.

     Optionally, type the name of a job title that is not in the list. This is possible because the <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl> enables users to select from a list of entries or to type their own entries.

7. Click the icon in the cell to the right of the **Picture** cell and browse to an image to display it.

8. Try to add rows or columns to the table, and try to delete rows and columns from the table. Verify that you cannot modify the table. The <xref:Microsoft.Office.Tools.Word.GroupContentControl> prevents you from making any modifications.

### To test the customer feedback table

1. Click **Choose your second building block** to display the second building block gallery content control.

2. Click the drop-down arrow next to the **Custom Gallery 1** heading in the control, and select **Customer Table**.

3. Click in the cell to the right of the **Customer Name** cell and type a name.

4. Click in the cell to the right of the **Satisfaction Rating** cell and select one of the available options.

     Verify that you cannot type your own entry. The <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> allows users only to select from a list of entries.

5. Click in the cell to the right of the **Comments** cell and type some comments.

     Optionally, add some content other than text, such as art or an embedded table. This is possible because the <xref:Microsoft.Office.Tools.Word.RichTextContentControl> enables users to add content other than text.

6. Verify that you can add rows or columns to the table, and that you can delete rows and columns from the table. This is possible because you have not protected the table by putting it in a <xref:Microsoft.Office.Tools.Word.GroupContentControl>.

7. Close the template.

## Next steps
 You can learn more about how to use content controls from this topic:

- Bind content controls to pieces of XML, also named custom XML parts, that are embedded in a document. For more information, see [Walkthrough: Bind content controls to custom XML parts](../vsto/walkthrough-binding-content-controls-to-custom-xml-parts.md).

## Related content
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Content controls](../vsto/content-controls.md)
- [How to: Add content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md)
- [How to: Protect parts of documents by using content controls](../vsto/how-to-protect-parts-of-documents-by-using-content-controls.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
