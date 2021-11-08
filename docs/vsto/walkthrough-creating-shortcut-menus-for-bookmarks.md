---
title: "Walkthrough: Create shortcut menus for bookmarks"
description: Learn how to create shortcut menus for Bookmark controls in a document-level customization for Microsoft Word.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "context menus, Word"
  - "Bookmark control, events"
  - "shortcut menus, Word"
  - "menus, creating in Office applications"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Walkthrough: Create shortcut menus for bookmarks
  This walkthrough demonstrates how to create shortcut menus for <xref:Microsoft.Office.Tools.Word.Bookmark> controls in a document-level customization for Word. When a user right-clicks the text in a bookmark, a shortcut menu appears and gives the user options for formatting the text.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- [Create the project](#BKMK_CreateProject).

- [Add text and bookmarks to the document](#BKMK_addtextandbookmarks).

- [Add commands to a shortcut menu](#BKMK_AddCmndsShortMenu).

- [Format the text in the bookmark](#BKMK_formattextbkmk).

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- [!INCLUDE[Word_15_short](../vsto/includes/word-15-short-md.md)] or [!INCLUDE[Word_14_short](../vsto/includes/word-14-short-md.md)]

## <a name="BKMK_CreateProject"></a> Create the project
 The first step is to create a Word document project in Visual Studio.

### To create a new project

- Create a Word document project that has the name **My Bookmark Shortcut Menu**. In the wizard, select **Create a new document**. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Word document in the designer and adds the **My Bookmark Shortcut Menu** project to **Solution Explorer**.

## <a name="BKMK_addtextandbookmarks"></a> Add text and bookmarks to the document
 Add some text to your document and then add two overlapping bookmarks.

### To add text to your document

- In the document that appears in the designer of your project, type the following text.

     **This is an example of creating a shortcut menu when you right-click the text in a bookmark.**

### To add a Bookmark control to your document

1. In the **Toolbox**, from the **Word Controls** tab, drag a <xref:Microsoft.Office.Tools.Word.Bookmark> control to your document.

    The **Add Bookmark Control** dialog box appears.

2. Select the words "creating a shortcut menu when you right-click the text", and then click **OK**.

    `bookmark1` is added to the document.

3. Add another <xref:Microsoft.Office.Tools.Word.Bookmark> control to the words "right-click the text in a bookmark".

    `bookmark2` is added to the document.

   > [!NOTE]
   > The words "right-click the text" are in both `bookmark1` and `bookmark2`.

   When you add a bookmark to a document at design time, a <xref:Microsoft.Office.Tools.Word.Bookmark> control is created. You can program against several events of the bookmark. You can write code in the <xref:Microsoft.Office.Tools.Word.Bookmark.BeforeRightClick> event of the bookmark so that when the user right-clicks the text in the bookmark, a shortcut menu appears.

## <a name="BKMK_AddCmndsShortMenu"></a> Add commands to a shortcut menu
 Add buttons to the shortcut menu that appears when you right-click the document.

### To add commands to a shortcut menu

1. Add a **Ribbon XML** item to the project. For more information, see [How to: Get started customizing the ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md).

2. In **Solution Explorer**, select **ThisDocument.cs** or **ThisDocument.vb**.

3. On the menu bar, choose **View** > **Code**.

     The **ThisDocument** class file opens in the Code Editor.

4. Add the following code to the **ThisDocument** class. This code overrides the CreateRibbonExtensibilityObject method and returns the Ribbon XML class to the Office application.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_word_document_menus.cs/thisdocument.cs" id="Snippet1":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_word_document_menus.vb/thisdocument.vb" id="Snippet1":::

5. In **Solution Explorer**, select the Ribbon XML file. By default, the Ribbon XML file is named Ribbon1.xml.

6. On the menu bar, choose **View** > **Code**.

     The Ribbon xml file opens in the Code Editor.

7. In the Code Editor, replace the contents of the Ribbon XML file with the following code.

    ```xml
    <?xml version="1.0" encoding="UTF-8"?>
    <customUI xmlns="http://schemas.microsoft.com/office/2009/07/customui" onLoad="Ribbon_Load">
      <contextMenus>
        <contextMenu idMso="ContextMenuText">
          <button id="BoldButton" label="Bold" onAction="ButtonClick"
               getVisible="GetVisible" />
          <button id="ItalicButton" label="Italic" onAction="ButtonClick"
              getVisible="GetVisible"/>
        </contextMenu>
      </contextMenus>
    </customUI>
    ```

     This code adds two buttons to the shortcut menu that appears when you right-click the document.

8. In **Solution Explorer**, right-click `ThisDocument`, and then click **View Code**.

9. Declare the following variables and a bookmark variable at the class level.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_word_document_menus.cs/thisdocument.cs" id="Snippet2":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_word_document_menus.vb/thisdocument.vb" id="Snippet2":::

10. In **Solution Explorer**, select the Ribbon code file. By default, the Ribbon code file is named **Ribbon1.cs** or **Ribbon1.vb**.

11. On the menu bar, choose **View** > **Code**.

     The Ribbon code file opens in the Code Editor.

12. In the Ribbon code file, add the following method. This is a callback method for the two buttons that you have added to the shortcut menu of the document. This method determines whether these buttons appear in the shortcut menu. The bold and italic buttons appear only if you right-click text within the bookmark.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_word_document_menus.cs/ribbon1.cs" id="Snippet5":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_word_document_menus.vb/ribbon1.vb" id="Snippet5":::

## <a name="BKMK_formattextbkmk"></a> Format the text in the bookmark

### To format the text in the bookmark

1. In the Ribbon code file, add a `ButtonClick` event handler to apply formatting to the bookmark.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_word_document_menus.cs/ribbon1.cs" id="Snippet6":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_word_document_menus.vb/ribbon1.vb" id="Snippet6":::

2. **Solution Explorer**, select **ThisDocument.cs** or **ThisDocument.vb**.

3. On the menu bar, choose **View** > **Code**.

     The **ThisDocument** class file opens in the Code Editor.

4. Add the following code to the **ThisDocument** class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_word_document_menus.cs/thisdocument.cs" id="Snippet3":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_word_document_menus.vb/thisdocument.vb" id="Snippet3":::

    > [!NOTE]
    > You must write code to handle the case where bookmarks overlap. If you do not, by default, the code will be called for all bookmarks in the selection.

5. In C#, you must add event handlers for the bookmark controls to the <xref:Microsoft.Office.Tools.Word.Document.Startup> event. For information about creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_word_document_menus.cs/thisdocument.cs" id="Snippet4":::

## Test the application
 Test your document to verify that the bold and italic menu items appear in the shortcut menu when you right-click text in a bookmark and that the text is properly formatted.

### To test your document

1. Press **F5** to run your project.

2. Right-click in the first bookmark, and then click **Bold**.

3. Verify that all of the text in `bookmark1` is formatted as bold.

4. Right-click the text where the bookmarks overlap, and then click **Italic**.

5. Verify that all of the text in `bookmark2` is italic, and only the part of the text in `bookmark1` that overlaps `bookmark2` is italic.

## Next steps
 Here are some tasks that might come next:

- Write code to respond to events of host controls in Excel. For more information, see [Walkthrough: Program against events of a NamedRange control](../vsto/walkthrough-programming-against-events-of-a-namedrange-control.md).

- Use a check box to change formatting in a bookmark. For more information, see [Walkthrough: Change document formatting using CheckBox controls](../vsto/walkthrough-changing-document-formatting-using-checkbox-controls.md).

## See also
- [Walkthroughs using Word](../vsto/walkthroughs-using-word.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Bookmark control](../vsto/bookmark-control.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
