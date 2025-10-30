---
title: "Create your first document-level customization for Word"
description: Create a document-level customization for Microsoft Word. The features that you create in this kind of solution are available only when a specific document is open.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, creating your first project"
  - "Word [Office development in Visual Studio], creating your first project"
  - "document-level customizations [Office development in Visual Studio], creating your first project"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create your first document-level customization for Word

  This introductory walkthrough shows you how to create a document-level customization for Microsoft Office Word. The features that you create in this kind of solution are available only when a specific document is open. You cannot use a document-level customization to make application-wide changes, for example, displaying a new Ribbon tab when any document is open.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 This walkthrough illustrates the following tasks:

- Creating a Word document project.

- Adding text to the document that is hosted in the Visual Studio designer.

- Writing code that uses the object model of Word to add text to the customized document when it is opened.

- Building and running the project to test it.

- Cleaning up the project to remove unnecessary build files and security settings from your development computer.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites

 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Word

## Create the project

### To create a new Word document project in Visual Studio

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. On the **Create a New Project** dialog select the **Word VSTO Document** project.

     [!INCLUDE[new-project-dialog-search](../vsto/includes/new-project-dialog-search-md.md)]

4. Click **Next**.

5. Type **FirstWorkbookCustomization** in the **Name** box on the **Configure your new project** dialog and click **Create**.

6. Select **Create a new document** from the **Visual Studio Tools for Office Project Wizard**, and click **OK**.

   - Visual Studio creates the **FirstDocumentCustomization** project, and adds the **FirstDocumentCustomization** document and ThisDocument code file to the project. The **FirstDocumentCustomization** document is opened automatically in the designer.

## Close and reopen the document in the designer

 If you deliberately or accidentally close the document in the designer while you are developing your project, you can reopen it.

### To close and reopen the document in the designer

1. Close the document by clicking the **Close** button (X) for the designer window.

2. In **Solution Explorer**, right-click the **ThisDocument** code file, and click **View Designer**.

     \- or -

     In **Solution Explorer**, double-click the **ThisDocument** code file.

## Add text to the document in the designer

 You can design the user interface (UI) of your customization by modifying the document that is open in the designer. For example, you can add text, tables, or Word controls. For more information about how to use the designer, see [Office projects in the Visual Studio environment](../vsto/office-projects-in-the-visual-studio-environment.md).

### To add text to your document by using the designer

1. In the document that is open in the designer, type the following text.

     **This text was added by using the designer.**

## Add text to the document programmatically

 Next, add code to the ThisDocument code file. The new code uses the object model of Word to add a second paragraph of text to the document. By default, the ThisDocument code file contains the following generated code:

- A partial definition of the `ThisDocument` class, which represents the programming model of the document and provides access to the object model of Word. For more information, see [Document host item](../vsto/document-host-item.md) and [Word object model overview](../vsto/word-object-model-overview.md). The remainder of the `ThisDocument` class is defined in a hidden code file that you should not modify.

- The `ThisDocument_Startup` and `ThisDocument_Shutdown` event handlers. These event handlers are called when the document is opened and closed. Use these event handlers to initialize your customization when the document is opened, and to clean up resources used by your customization when the document is closed. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### To add a second paragraph of text to the document by using code

1. In **Solution Explorer**, right-click **ThisDocument**, and then click **View Code**.

     The code file opens in Visual Studio.

2. Replace the `ThisDocument_Startup` event handler with the following code. When the document is opened, this code adds a second paragraph of text to the document.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/FirstDocumentCustomization/ThisDocument.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/FirstDocumentCustomization/ThisDocument.vb" id="Snippet1":::
     ---

    > [!NOTE]
    > This code uses the index value 1 to access the first paragraph in the <xref:Microsoft.Office.Tools.Word.Document.Paragraphs%2A> property. Although Visual Basic and Visual C# use 0-based arrays, the lower array bounds of most collections in the Word object model is 1. For more information, see [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md).

## Test the project

### To test your document

1. Press **F5** to build and run your project.

     When you build the project, the code is compiled into an assembly that is associated with the document. Visual Studio puts a copy of the document and the assembly in the build output folder for the project, and it configures the security settings on the development computer to enable the customization to run. For more information, see [Build Office solutions](../vsto/building-office-solutions.md).

2. In the document, verify that you see the following text.

     **This text was added by using the designer.**

     **This text was added by using code.**

3. Close the document.

## Clean up the project

 When you finish developing a project, you should remove the files in the build output folder and the security settings created by the build process.

### To clean up the completed project on your development computer

1. In Visual Studio, on the **Build** menu, click **Clean Solution**.

## Next steps

 Now that you have created a basic document-level customization for Word, you can learn more about how to develop customizations from these topics:

- General programming tasks that you can perform in document-level customizations: [Program document-level customizations](../vsto/programming-document-level-customizations.md).

- Programming tasks that are specific to document-level customizations for Word: [Word solutions](../vsto/word-solutions.md).

- Using the object model of Word: [Word object model overview](../vsto/word-object-model-overview.md).

- Customizing the UI of Word, for example, by adding a custom tab to the Ribbon or creating your own actions pane: [Office UI customization](../vsto/office-ui-customization.md).

- Using extended Word objects provided by Office solutions in Visual Studio to perform tasks that are not possible by using the Word object model (for example, hosting managed controls on documents and binding Word controls to data by using the Windows Forms data binding model): [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md).

- Building and debugging document-level customizations for Word: [Build Office solutions](../vsto/building-office-solutions.md).

- Deploying document-level customizations for Word: [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## Related content

- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Word solutions](../vsto/word-solutions.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [Word object model overview](../vsto/word-object-model-overview.md)
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)
