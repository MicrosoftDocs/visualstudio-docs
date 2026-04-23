---
title: Call code from VBA in a Visual C# project in Visual Studio
description: Call a Visual C# method in a document-level customization for Microsoft Office Excel from Visual Basic for Applications (VBA) code in the Excel workbook.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Excel [Office development in Visual Studio], calling code from VBA"
  - "Word [Office development in Visual Studio], calling code from VBA"
  - "Visual C# [Office development in Visual Studio], calling code from VBA"
  - "workbooks [Office development in Visual Studio], calling code from VBA"
  - "VBA [Office development in Visual Studio], calling code in document-level customizations"
  - "Office documents [Office development in Visual Studio, Visual Basic for Applications and"
  - "calling code from VBA"
  - "document-level customizations [Office development in Visual Studio], calling code"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Call code from VBA in a Visual C# project

  This walkthrough demonstrates how to call a method in a document-level customization for Microsoft Office Excel from Visual Basic for Applications (VBA) code in the workbook. The procedure involves three basic steps: add a method to the `Sheet1` host item class, expose the method to VBA code in the workbook, and then call the method from VBA code in the workbook.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 Although this walkthrough uses Excel specifically, the concepts demonstrated by the walkthrough are also applicable to document-level projects for Word.

 This walkthrough illustrates the following tasks:

- Creating a workbook that contains VBA code.

- Trusting the location of the workbook by using the Trust Center in Excel.

- Adding a method to the `Sheet1` host item class.

- Extracting an interface for the `Sheet1` host item class.

- Exposing the method to VBA code.

- Calling the method from VBA code.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Excel

## Create a workbook that contains VBA code
 The first step is to create a macro-enabled workbook that contains a simple VBA macro. Before you can expose code in a customization to VBA, the workbook must already contain VBA code. Otherwise, Visual Studio cannot modify the VBA project to enable VBA code to call into the customization assembly.

 If you already have a workbook that contains VBA code that you want to use, you can skip this step.

### To create a workbook that contains VBA code

1. Start Excel.

2. Save the active document as an **Excel Macro-Enabled Workbook (\*.xlsm)** with the name **WorkbookWithVBA**. Save it to a convenient location, such as the desktop.

3. On the Ribbon, click the **Developer** tab.

    > [!NOTE]
    > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

4. In the **Code** group, click **Visual Basic**.

     The Visual Basic Editor opens.

5. In the **Project** window, double-click **ThisWorkbook**.

     The code file for the `ThisWorkbook` object opens.

6. Add the following VBA code to the code file. This code defines a simple function that does nothing. The only purpose of this function is to ensure that a VBA project exists in the workbook. This is required for later steps in this walkthrough.

    ```vb
    Sub EmptySub()
    End Sub
    ```

7. Save the document and exit Excel.

## Create the project
 Now you can create a document-level project for Excel that uses the macro-enabled workbook you created earlier.

### To create a new project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. In the templates pane, expand **Visual C#**, and then expand **Office/SharePoint**.

4. Select the **Office Add-ins** node.

5. In the list of project templates, select the **Excel 2010 Workbook** or **Excel 2013 Workbook** project.

6. In the **Name** box, type **CallingCodeFromVBA**.

7. Click **OK**.

     The **Visual Studio Tools for Office Project Wizard** opens.

8. Select **Copy an existing document**, and, in the **Full path of the existing document** box, specify the location of the **WorkbookWithVBA** workbook that you created earlier. If you are using your own macro-enabled workbook, specify the location of that workbook instead.

9. Click **Finish**.

     Visual Studio opens the **WorkbookWithVBA** workbook in the designer and adds the **CallingCodeFromVBA** project to **Solution Explorer**.

## Trust the location of the workbook
 Before you can expose code in your solution to VBA code in the workbook, you must trust VBA in the workbook to run. There are several ways to do this. In this walkthrough, you will accomplish this task by trusting the location of the workbook in the **Trust Center** in Excel.

### To trust the location of the workbook

1. Start Excel.

2. Click the **File** tab.

3. Click the **Excel Options** button.

4. In the categories pane, click **Trust Center**.

5. In the details pane, click **Trust Center Settings**.

6. In the categories pane, click **Trusted Locations**.

7. In the details pane, click **Add new location**.

8. In the **Microsoft Office Trusted Location** dialog box, browse to the folder that contains the **CallingCodeFromVBA** project.

9. Select **Subfolders of this location are also trusted**.

10. In the **Microsoft Office Trusted Location** dialog box, click **OK**.

11. In the **Trust Center** dialog box, click **OK**.

12. In the **Excel Options** dialog box, click **OK**.

13. Exit **Excel**.

## Add a method to the Sheet1 class
 Now that the VBA project is set up, add a public method to the `Sheet1` host item class that you can call from VBA code.

### To add a method to the Sheet1 class

1. In **Solution Explorer**, right-click **Sheet1.cs**, and then click **View Code**.

     The **Sheet1.cs** file opens in the Code Editor.

2. Add the following code to the `Sheet1` class. The `CreateVstoNamedRange` method creates a new <xref:Microsoft.Office.Tools.Excel.NamedRange> object at the specified range. This method also creates an event handler for the <xref:Microsoft.Office.Tools.Excel.NamedRange.Selected> event of the <xref:Microsoft.Office.Tools.Excel.NamedRange>. Later in this walkthrough, you will call the `CreateVstoNamedRange` method from VBA code in the document.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/CallingCodeFromVBA/Sheet1.cs" id="Snippet2":::

3. Add the following method to the `Sheet1` class. This method overrides the <xref:Microsoft.Office.Tools.Excel.WorksheetBase.GetAutomationObject%2A> method to return the current instance of the `Sheet1` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/CallingCodeFromVBA/Sheet1.cs" id="Snippet3":::

4. Apply the following attributes before the first line of the `Sheet1` class declaration. These attributes make the class visible to COM, but without generating a class interface.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/CallingCodeFromVBA/Sheet1.cs" id="Snippet1":::

## Extract an interface for the Sheet1 class
 Before you can expose the `CreateVstoNamedRange` method to VBA code, you must create a public interface that defines this method, and you must expose this interface to COM.

### To extract an interface for the Sheet1 class

1. In the **Sheet1.cs** code file, click anywhere in the `Sheet1` class.

2. On the **Refactor** menu, click **Extract Interface**.

3. In the **Extract Interface** dialog box, in the **Select public members to form interface** box, click the entry for the `CreateVstoNamedRange` method.

4. Click **OK**.

     Visual Studio generates a new interface named `ISheet1`, and it modifies the definition of the `Sheet1` class so that it implements the `ISheet1` interface. Visual Studio also opens the **ISheet1.cs** file in the Code Editor.

5. In the **ISheet1.cs** file, replace the `ISheet1` interface declaration with the following code. This code makes the `ISheet1` interface public, and it applies the <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute to make the interface visible to COM.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/CallingCodeFromVBA/ISheet1.cs" id="Snippet4":::

6. Build the project.

## Expose the method to VBA code
 To expose the `CreateVstoNamedRange` method to VBA code in the workbook, set the **ReferenceAssemblyFromVbaProject** property for the `Sheet1` host item to **True**.

### To expose the method to VBA code

1. In **Solution Explorer**, double-click **Sheet1.cs**.

     The **WorkbookWithVBA** file opens in the designer, with Sheet1 visible.

2. In the **Properties** window, select the **ReferenceAssemblyFromVbaProject** property, and change the value to **True**.

3. Click **OK** in the message that is displayed.

4. Build the project.

## Call the method from VBA code
 You can now call the `CreateVstoNamedRange` method from VBA code in the workbook.

> [!NOTE]
> In this walkthrough, you will add VBA code to the workbook while debugging the project. The VBA code you add to this document will be overwritten the next time that you build the project, because Visual Studio replaces the document in the build output folder with a copy of the document from the main project folder. If you want to save the VBA code, you can copy it into the document in the project folder. For more information, see [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md).

### To call the method from VBA code

1. Press **F5** to run your project.

2. On the **Developer** tab, in the **Code** group, click **Visual Basic**.

     The Visual Basic Editor opens.

3. On the **Insert** menu, click **Module**.

4. Add the following code to the new module.

     This code calls the `CreateTable` method in the customization assembly. The macro accesses this method by using the global `GetManagedClass` method to access the `Sheet1` host item class that you exposed to VBA code. The `GetManagedClass` method was automatically generated when you set the **ReferenceAssemblyFromVbaProject** property earlier in this walkthrough.

    ```vb
    Sub CallVSTOMethod()
        Dim VSTOSheet1 As CallingCodeFromVBA.Sheet1
        Set VSTOSheet1 = GetManagedClass(Sheet1)
        Call VSTOSheet1.CreateVstoNamedRange(Sheet1.Range("A1"), "VstoNamedRange")
    End Sub
    ```

5. Press **F5**.

6. In the open workbook, click cell **A1** on **Sheet1**. Verify that the message box appears.

7. Exit Excel without saving your changes.

## Next steps
 You can learn more about calling code in Office solutions from VBA in these topics:

- Call code in a host item in a Visual Basic customization from VBA. This process is different from the Visual C# process. For more information, see [Walkthrough: Call code from VBA in a Visual Basic project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-basic-project.md).

- Call code in a VSTO Add-in from VBA. For more information, see [Walkthrough: Call code in a VSTO Add-in from VBA](../vsto/walkthrough-calling-code-in-a-vsto-add-in-from-vba.md).

## Related content
- [Combine VBA and document-level customizations](../vsto/combining-vba-and-document-level-customizations.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [How to: Expose Code to VBA in a Visual Basic project](../vsto/how-to-expose-code-to-vba-in-a-visual-basic-project.md)
- [How to: Expose Code to VBA in a Visual C&#35; project](../vsto/how-to-expose-code-to-vba-in-a-visual-csharp-project.md)
- [Walkthrough: Call code from VBA in a Visual Basic project](../vsto/walkthrough-calling-code-from-vba-in-a-visual-basic-project.md)
