---
title: Call code from VBA in a Visual Basic project in Visual Studio
description: Call a method in a document-level customization for Microsoft Office Excel from Visual Basic for Applications (VBA) code in the Excel workbook.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], Visual Basic for Applications and"
  - "ThisDocument class"
  - "Word [Office development in Visual Studio], calling code from VBA"
  - "Visual Basic [Office development in Visual Studio], calling code from VBA"
  - "VBA [Office development in Visual Studio], calling code in document-level customizations"
  - "Office documents [Office development in Visual Studio, Visual Basic for Applications and"
  - "calling code from VBA"
  - "document-level customizations [Office development in Visual Studio], calling code"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Call code from VBA in a Visual Basic project

  This walkthrough demonstrates how to call a method in a document-level customization for Microsoft Office Word from Visual Basic for Applications (VBA) code in the document. The procedure involves three basic steps: add a method to the `ThisDocument` host item class, expose the method to VBA code, and then call the method from VBA code in the document.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 Although this walkthrough uses Word specifically, the concepts demonstrated by the walkthrough also apply to document-level projects for Excel.

 This walkthrough illustrates the following tasks:

- Creating a document that contains VBA code.

- Trusting the location of the document by using the Trust Center in Word.

- Adding a method to the `ThisDocument` host item class.

- Exposing the method to VBA code.

- Calling the method from VBA code.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Word

## Create a document that contains VBA code
 The first step is to create a macro-enabled document that contains a simple VBA macro. The document must contain a VBA project before you create a Visual Studio project that is based on that document. Otherwise, Visual Studio cannot modify the VBA project to enable VBA code to call into the customization assembly.

 If you already have a document that contains VBA code that you want to use, you can skip this step.

### To create a document that contains VBA code

1. Start Word.

2. Save the active document as a Word **Macro-Enabled Document (\*.docm)** with the name **DocumentWithVBA**. Save it in a convenient location, such as the desktop.

3. On the Ribbon, click the **Developer** tab.

    > [!NOTE]
    > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

4. In the **Code** group, click **Visual Basic**.

     The Visual Basic Editor opens.

5. In the **Project** window, double-click **ThisDocument**.

     The code file for the `ThisDocument` object opens.

6. Add the following VBA code to the code file. This code defines a simple function that does nothing. The only purpose of this function is to ensure that a VBA project exists in the document. This is required for later steps in this walkthrough.

    ```vb
    Sub EmptySub()
    End Sub
    ```

7. Save the document and exit Word.

## Create the project
 Now you can create a document-level project for Word that uses the macro-enabled document you created earlier.

### To create a new project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**. If your IDE is set to use Visual Basic development settings, on the **File** menu, click **New Project**.

3. In the templates pane, expand **Visual Basic**, and then expand **Office/SharePoint**.

4. Select the **Office Add-ins** node.

5. In the list of project templates, select the **Word 2010 Document** or **Word 2013 Document** project.

6. In the **Name** box, type **CallingCodeFromVBA**.

7. Click **OK**.

     The **Visual Studio Tools for Office Project Wizard** opens.

8. Select **Copy an existing document**, and, in the **Full path of the existing document** box, specify the location of the **DocumentWithVBA** document that you created earlier. If you are using your own macro-enabled document, specify the location of this document instead.

9. Click **Finish**.

     Visual Studio opens the **DocumentWithVBA** document in the designer and adds the **CallingCodeFromVBA** project to **Solution Explorer**.

## Trust the location of the document
 Before you can expose code in your solution to VBA code in the document, you must trust VBA in the document to run. There are several ways to do this. For this walkthrough, trust the location of the document in the **Trust Center** in Word.

### To trust the location of the document

1. Start Word.

2. Click the **File** tab.

3. Click the **Word Options** button.

4. In the categories pane, click **Trust Center**.

5. In the details pane, click **Trust Center Settings**.

6. In the categories pane, click **Trusted Locations**.

7. In the details pane, click **Add new location**.

8. In the **Microsoft Office Trusted Location** dialog box, browse to the folder that contains the **CallingCodeFromVBA** project.

9. Select **Subfolders of this location are also trusted**.

10. In the **Microsoft Office Trusted Location** dialog box, click **OK**.

11. In the **Trust Center** dialog box, click **OK**.

12. In the **Word Options** dialog box, click **OK**.

13. Exit Word.

## Add a method to the ThisDocument class
 Now that the VBA project is set up, add a method to the `ThisDocument` host item class that you can call from VBA code.

### To add a method to the ThisDocument class

1. In **Solution Explorer**, right-click **ThisDocument.vb**, and then click **View Code**.

     The **ThisDocument.vb** file opens in the Code Editor.

2. Add the following method to the `ThisDocument` class. This method creates a table with two rows and two columns at the beginning of the document. The parameters specify the text that is displayed in the first row. Later in this walkthrough, you will call this method from VBA code in the document.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/CallingCodeFromVBA/ThisDocument.vb" id="Snippet1":::

3. Build the project.

## Expose the method to VBA code
 To expose the `CreateTable` method to VBA code in the document, set the **EnableVbaCallers** property for the `ThisDocument` host item to **True**.

### To expose the method to VBA code

1. In **Solution Explorer**, double-click **ThisDocument.vb**.

     The **DocumentWithVBA** file opens in the designer.

2. In the **Properties** window, select the **EnableVbaCallers** property, and change the value to **True**.

3. Click **OK** in the message that is displayed.

4. Build the project.

## Call the method from VBA code
 You can now call the `CreateTable` method from VBA code in the document.

> [!NOTE]
> In this walkthrough, you will add VBA code to the document while debugging the project. The VBA code you add to this document will be overwritten the next time that you build the project, because Visual Studio replaces the document in the build output folder with a copy of the document from the main project folder. If you want to save the VBA code, you can copy it into the document in the project folder. For more information, see [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md).

### To call the method from VBA code

1. Press **F5** to run your project.

2. On the **Developer** tab, in the **Code** group, click **Visual Basic**.

     The Visual Basic Editor opens.

3. On the **Insert** menu, click **Module**.

4. Add the following code to the new module.

     This code calls the `CreateTable` method in the customization assembly. The macro accesses this method by using the `CallVSTOAssembly` property of the `ThisDocument` object. This property was automatically generated when you set the **EnableVbaCallers** property earlier in this walkthrough.

    ```vb
    Sub CreateTable()
        Call ThisDocument.CallVSTOAssembly.CreateTable("Employee Name", "Start Date")
    End Sub
    ```

5. Press **F5**.

6. Verify that a new table was added to the document.

7. Exit Word without saving your changes.

## Next steps
 You can learn more about calling code in Office solutions from VBA in these topics:

- Call code in a Visual C# customization from VBA. This process is different from the Visual Basic process. For more information, see [Walkthrough: Call code from VBA in a Visual C&#35; project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-csharp-project.md).

- Call code in a VSTO Add-in from VBA. For more information, see [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md).

## Related content
- [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [How to: Expose code to VBA in a Visual Basic project](../vsto/how-to-expose-code-to-vba-in-a-visual-basic-project.md)
- [How to: Expose code to VBA in a Visual C&#35; project](../vsto/how-to-expose-code-to-vba-in-a-visual-csharp-project.md)
- [Walkthrough: Call code from VBA in a Visual C&#35; project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-csharp-project.md)
