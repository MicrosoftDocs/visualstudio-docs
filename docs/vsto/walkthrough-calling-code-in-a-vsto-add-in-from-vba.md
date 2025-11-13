---
title: "Walkthrough: Call code in a VSTO Add-in from VBA"
description: Learn how to expose an object in a VSTO Add-in to other Microsoft Office solutions, including Visual Basic for Applications (VBA) and COM VSTO Add-ins.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "VBA [Office development in Visual Studio], calling code in application-level add-ins"
  - "application-level add-ins [Office development in Visual Studio], calling code from other solutions"
  - "Video How tos, Office development in Visual Studio"
  - "calling add-in code"
  - "add-ins [Office development in Visual Studio], calling code from other solutions"
  - "interoperability [Office development in Visual Studio]"
  - "calling code from VBA"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Call code in a VSTO Add-in from VBA

  This walkthrough demonstrates how to expose an object in a VSTO Add-in to other Microsoft Office solutions, including Visual Basic for Applications (VBA) and COM VSTO Add-ins.

 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]

 Although this walkthrough uses Excel specifically, the concepts demonstrated by the walkthrough are applicable to any VSTO Add-in project template provided by Visual Studio.

 This walkthrough illustrates the following tasks:

- Defining a class that can be exposed to other Office solutions.

- Exposing the class to other Office solutions.

- Calling a method of the class from VBA code.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Excel

## Create the VSTO Add-in project
 The first step is to create a VSTO Add-in project for Excel.

### To create a new project

1. Create an Excel VSTO Add-in project with the name **ExcelImportData**, using the Excel VSTO Add-in project template. For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the **ThisAddIn.cs** or **ThisAddIn.vb** code file and adds the **ExcelImportData** project to **Solution Explorer**.

## Define a class that you can expose to other Office solutions
 The purpose of this walkthrough is to call into the `ImportData` method of a class named `AddInUtilities` in your VSTO Add-in from VBA code. This method writes a string into cell A1 of the active worksheet.

 To expose the `AddInUtilities` class to other Office solutions, you must make the class public and visible to COM. You must also expose the [IDispatch](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch) interface in the class. The code in the following procedure demonstrates one way to meet these requirements. For more information, see [Calling Code in VSTO Add-ins from Other Office Solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md).

### To define a class that you can expose to other Office solutions

1. On the **Project** menu, click **Add Class**.

2. In the **Add New Item** dialog box, change the name of the new class to **AddInUtilities**, and click **Add**.

     The **AddInUtilities.cs** or **AddInUtilities.vb** file opens in the Code Editor.

3. Add the following directives to the top of the file.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddInInteropWalkthrough/AddInUtilities.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_AddInInteropWalkthrough/AddInUtilities.vb" id="Snippet2":::
     ---

4. Replace the `AddInUtilities` class with the following code.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddInInteropWalkthrough/AddInUtilities.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_AddInInteropWalkthrough/AddInUtilities.vb" id="Snippet3":::
     ---

     This code makes the `AddInUtilities` class visible to COM, and it adds the `ImportData` method to the class. To expose the [IDispatch](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-idispatch) interface, the `AddInUtilities` class also has the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute, and it implements an interface that is visible to COM.

## Expose the class to other Office solutions
 To expose the `AddInUtilities` class to other Office solutions, override the <xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService%2A> method in the `ThisAddIn` class. In your override, return an instance of the `AddInUtilities` class.

### To expose the AddInUtilities class to other Office Solutions

1. In **Solution Explorer**, expand **Excel**.

2. Right-click **ThisAddIn.cs** or **ThisAddIn.vb**, and then click **View Code**.

3. Add the following code to the `ThisAddIn` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_AddInInteropWalkthrough/ThisAddIn.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_AddInInteropWalkthrough/ThisAddIn.vb" id="Snippet1":::
     ---

4. On the **Build** menu, click **Build Solution**.

     Verify that the solution builds without errors.

## Test the VSTO Add-in
 You can call into the `AddInUtilities` class from several different types of Office solutions. In this walkthrough, you will use VBA code in an Excel workbook. For more information about the other types of Office solutions you can also use, see [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md).

### To test your VSTO Add-in

1. Press **F5** to run your project.

2. In Excel, save the active workbook as an Excel Macro-Enabled Workbook (*.xlsm). Save it in a convenient location, such as the desktop.

3. On the Ribbon, click the **Developer** tab.

    > [!NOTE]
    > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the developer tab on the Ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

4. In the **Code** group, click **Visual Basic**.

     The Visual Basic Editor opens.

5. In the **Project** window, double-click **ThisWorkbook**.

     The code file for the `ThisWorkbook` object opens.

6. Add the following VBA code to the code file. This code first gets a COMAddIn object that represents the **ExcelImportData** VSTO Add-in. Then, the code uses the Object property of the COMAddIn object to call the `ImportData` method.

    ```vb
    Sub CallVSTOMethod()
        Dim addIn As COMAddIn
        Dim automationObject As Object
        Set addIn = Application.COMAddIns("ExcelImportData")
        Set automationObject = addIn.Object
        automationObject.ImportData
    End Sub
    ```

7. Press **F5**.

8. Verify that a new **Imported Data** sheet has been added to the workbook. Also verify that cell A1 contains the string **This is my data**.

9. Exit Excel.

## Next steps
 You can learn more about programming VSTO Add-ins from these topics:

- Use the `ThisAddIn` class to automate the host application and perform other tasks in VSTO Add-in projects. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

- Create a custom task pane in a VSTO Add-in. For more information, see [Custom task panes](../vsto/custom-task-panes.md) and [How to: Add a custom task pane to an application](../vsto/how-to-add-a-custom-task-pane-to-an-application.md).

- Customize the ribbon in a VSTO Add-in. For more information, see [Ribbon overview](../vsto/ribbon-overview.md) and [How to: Get started customizing the ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md).

## Related content
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Call code in VSTO Add-ins from other Office solutions](../vsto/calling-code-in-vsto-add-ins-from-other-office-solutions.md)
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Customize UI features by using extensibility interfaces](../vsto/customizing-ui-features-by-using-extensibility-interfaces.md)
