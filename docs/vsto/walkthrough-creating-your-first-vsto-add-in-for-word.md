---
title: "Create Visual Studio Tools for Office Add-ins: Microsoft Word"
description: Create a VSTO add-in for Microsoft Office Word with features that are available to the application itself, regardless of which Word documents are open.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application-level add-ins [Office development in Visual Studio], creating your first project"
  - "Office development in Visual Studio, creating your first project"
  - "add-ins [Office development in Visual Studio], creating your first project"
  - "Word [Office development in Visual Studio], creating your first project"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create your first VSTO Add-in for Word

  This introductory walkthrough shows you how to create a VSTO Add-in for Microsoft Office Word. The features that you create in this kind of solution are available to the application itself, regardless of which documents are open.

 [!INCLUDE[appliesto_wdallapp](../vsto/includes/appliesto-wdallapp-md.md)]

 This walkthrough illustrates the following tasks:

- Creating a Word VSTO Add-in project.

- Writing code that uses the object model of Word to add text to a document when it is saved.

- Building and running the project to test it.

- Cleaning up the completed project so that the VSTO Add-in no longer runs automatically on your development computer.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Word

## Create the project

### To create a new Word VSTO Add-in project in Visual Studio

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.

4. Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.

5. In the list of project templates, select a Word VSTO Add-in project.

6. In the **Name** box, type **FirstWordAddIn**.

7. Click **OK**.

     Visual Studio creates the **FirstWordAddIn** project and opens the ThisAddIn code file in the editor.

## Write code to add text to the saved document
 Next, add code to the ThisAddIn code file. The new code uses the object model of Word to add boilerplate text to each saved document. By default, the ThisAddIn code file contains the following generated code:

- A partial definition of the `ThisAddIn` class. This class provides an entry point for your code and provides access to the object model of Word. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md). The remainder of the `ThisAddIn` class is defined in a hidden code file that you should not modify.

- The `ThisAddIn_Startup` and `ThisAddIn_Shutdown` event handlers. These event handlers are called when Word loads and unloads your VSTO Add-in. Use these event handlers to initialize your VSTO Add-in when it is loaded, and to clean up resources used by your VSTO Add-in when it is unloaded. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### To add a paragraph of text to the saved document

1. In the ThisAddIn code file, add the following code to the `ThisAddIn` class. The new code defines an event handler for the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentBeforeSave> event, which is raised when a document is saved.

    When the user saves a document, the event handler adds new text at the start of the document.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/FirstWordAddIn/ThisAddIn.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/FirstWordAddIn/ThisAddIn.vb" id="Snippet1":::
    ---

   > [!NOTE]
   > This code uses an index value of 1 to access the first paragraph in the <xref:Microsoft.Office.Interop.Word._Document.Paragraphs%2A> collection. Although Visual Basic and Visual C# use 0-based arrays, the lower array bounds of most collections in the Word object model is 1. For more information, see [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md).

2. If you are using C#, add the following required code to the `ThisAddIn_Startup` event handler. This code is used to connect the `Application_DocumentBeforeSave` event handler with the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentBeforeSave> event.

    :::code language="csharp" source="../vsto/codesnippet/CSharp/FirstWordAddIn/ThisAddIn.cs" id="Snippet2":::

   To modify the document when it is saved, the previous code examples use the following objects:

- The `Application` field of the `ThisAddIn` class. The `Application` field returns a <xref:Microsoft.Office.Interop.Word.Application> object, which represents the current instance of Word.

- The `Doc` parameter of the event handler for the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentBeforeSave> event. The `Doc` parameter is a <xref:Microsoft.Office.Interop.Word.Document> object, which represents the saved document. For more information, see [Word object model overview](../vsto/word-object-model-overview.md).

## Test the project

### To test the project

1. Press **F5** to build and run your project.

     When you build the project, the code is compiled into an assembly that is included in the build output folder for the project. Visual Studio also creates a set of registry entries that enable Word to discover and load the VSTO Add-in, and it configures the security settings on the development computer to enable the VSTO Add-in to run. For more information, see [Build Office solutions](../vsto/building-office-solutions.md).

2. In Word, save the active document.

3. Verify that the following text is added to the document.

     **This text was added by using code.**

4. Close Word.

## Clean up the project
 When you finish developing a project, remove the VSTO Add-in assembly, registry entries, and security settings from your development computer. Otherwise, the VSTO Add-in will continue to run every time that you open Word on your development computer.

### To clean up the completed project on your development computer

1. In Visual Studio, on the **Build** menu, click **Clean Solution**.

## Next steps
 Now that you have created a basic VSTO Add-in for Word, you can learn more about how to develop VSTO Add-ins from these topics:

- General programming tasks that you can perform in VSTO Add-ins: [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

- Programming tasks that are specific to Word VSTO Add-ins: [Word solutions](../vsto/word-solutions.md).

- Using the object model of Word: [Word object model overview](../vsto/word-object-model-overview.md).

- Customizing the UI of Word, for example, by adding a custom tab to the Ribbon or creating your own custom task pane: [Office UI customization](../vsto/office-ui-customization.md).

- Building and debugging VSTO Add-ins for Word: [Build Office solutions](../vsto/building-office-solutions.md).

- Deploying VSTO Add-ins for Word: [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## Related content
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Word solutions](../vsto/word-solutions.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Word object model overview](../vsto/word-object-model-overview.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)
