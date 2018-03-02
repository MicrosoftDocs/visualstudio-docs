---
title: "Walkthrough: Creating Your First Document-Level Customization for Excel | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office development in Visual Studio, creating your first project"
  - "Excel [Office development in Visual Studio], creating your first project"
  - "document-level customizations [Office development in Visual Studio], creating your first project"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Walkthrough: Creating Your First Document-Level Customization for Excel
  This introductory walkthrough shows you how to create a document-level customization for Microsoft Office Excel. The features that you create in this kind of solution are available only when a specific workbook is open. You cannot use a document-level customization to make application-wide changes, for example, displaying a new Ribbon tab when any workbook is open.  
  
 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Creating an Excel workbook project.  
  
-   Adding text to a worksheet that is hosted in the Visual Studio designer.  
  
-   Writing code that uses the object model of Excel to add text to the customized worksheet when it is opened.  
  
-   Building and running the project to test it.  
  
-   Cleaning up the completed project to remove unnecessary build files and security settings from your development computer.  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]  
  
-   [!INCLUDE[Excel_15_short](../vsto/includes/excel-15-short-md.md)] or [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)].  
  
## Creating the Project  
  
#### To create a new Excel workbook project in Visual Studio  
  
1.  Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].  
  
2.  On the **File** menu, point to **New**, and then click **Project**.  
  
3.  In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.  
  
4.  Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.  
  
5.  In the list of project templates, choose an Excel VSTO Add-in project.  
  
6.  In the **Name** box, type **FirstWorkbookCustomization**.  
  
7.  Click **OK**.  
  
     The **Visual Studio Tools for Office Project Wizard** opens.  
  
8.  Select **Create a new document**, and click **OK**.  
  
    -   [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] creates the **FirstWorkbookCustomization** project, and adds the following files to the project.  
  
    -   *FirstWorkbookCustomization*.xlsx - Represents the Excel workbook in the project. Contains all the worksheets and charts.  
  
    -   Sheet1 (.vb file for Visual Basic or .cs file for Visual C#) - A worksheet that provides the design surface and the code for the first worksheet in the workbook. For more information, see [Worksheet Host Item](../vsto/worksheet-host-item.md).  
  
    -   Sheet2 (.vb file for Visual Basic or .cs file for Visual C#) - A worksheet that provides the design surface and the code for the second worksheet in the workbook.  
  
    -   Sheet3 (.vb file for Visual Basic or .cs file for Visual C#) - A worksheet that provides the design surface and the code for the third worksheet in the workbook.  
  
    -   ThisWorkbook (.vb file for Visual Basic or .cs file for Visual C#) - Contains the design surface and the code for workbook-level customizations. For more information, see [Workbook Host Item](../vsto/workbook-host-item.md).  
  
     The Sheet1 code file is opened automatically in the designer.  
  
## Closing and Reopening Worksheets in the Designer  
 If you deliberately or accidentally close a workbook or a worksheet in the designer while you are developing your project, you can reopen it.  
  
#### To close and reopen a worksheet in the designer  
  
1.  Close the workbook by clicking the **Close** button (X) for the designer window.  
  
2.  In **Solution Explorer**, right-click the **Sheet1** code file, and click **View Designer**.  
  
     \- or -  
  
     In **Solution Explorer**, double-click the **Sheet1** code file.  
  
## Adding Text to a Worksheet in the Designer  
 You can design the user interface (UI) of your customization by modifying the worksheet that is open in the designer. For example, you can add text to cells, apply formulas, or add Excel controls. For more information about how to use the designer, see [Office Projects in the Visual Studio Environment](../vsto/office-projects-in-the-visual-studio-environment.md).  
  
#### To add text to a worksheet by using the designer  
  
1.  In the worksheet that is open in the designer, select cell **A1**, and then type the following text.  
  
     **This text was added by using the designer.**  
  
> [!WARNING]  
>  If you add this line of text to cell **A2**, it will be overwritten by other code in this example.  
  
## Adding Text to a Worksheet Programmatically  
 Next, add code to the Sheet1 code file. The new code uses the object model of Excel to add a second line of text to the workbook. By default, the Sheet1 code file contains the following generated code:  
  
-   A partial definition of the `Sheet1` class, which represents the programming model of the worksheet and provides access to the object model of Excel. For more information, [Worksheet Host Item](../vsto/worksheet-host-item.md) and [Word Object Model Overview](../vsto/word-object-model-overview.md). The remainder of the `Sheet1` class is defined in a hidden code file that you should not modify.  
  
-   The `Sheet1_Startup` and `Sheet1_Shutdown` event handlers. These event handlers are called when Excel loads and unloads your customization. Use these event handlers to initialize your customization when it is loaded, and to clean up resources used by your customization when it is unloaded. For more information, see [Events in Office Projects](../vsto/events-in-office-projects.md).  
  
#### To add a second line of text to the worksheet by using code  
  
1.  In **Solution Explorer**, right-click **Sheet1**, and then click **View Code**.  
  
     The code file opens in Visual Studio.  
  
2.  Replace the `Sheet1_Startup` event handler with the following code. When Sheet1 is opened, this code adds a second line of text to the worksheet.  
  
     [!code-csharp[Trin_ExcelWorkbookTutorial#1](../vsto/codesnippet/CSharp/Trin_ExcelWorkbookTutorial/Sheet1.cs#1)]
     [!code-vb[Trin_ExcelWorkbookTutorial#1](../vsto/codesnippet/VisualBasic/Trin_ExcelWorkbookTutorial/Sheet1.vb#1)]  
  
## Testing the Project  
  
#### To test your workbook  
  
1.  Press **F5** to build and run your project.  
  
     When you build the project, the code is compiled into an assembly that is associated with the workbook. Visual Studio puts a copy of the workbook and the assembly in the build output folder for the project, and it configures the security settings on the development computer to enable the customization to run. For more information, see [Building Office Solutions](../vsto/building-office-solutions.md).  
  
2.  In the workbook, verify that you see the following text.  
  
     **This text was added by using the designer.**  
  
     **This text was added by using code.**  
  
3.  Close the workbook.  
  
## Cleaning up the Project  
 When you finish developing a project, you should remove the files in the build output folder and the security settings created by the build process.  
  
#### To clean up the completed project on your development computer  
  
1.  In Visual Studio, on the **Build** menu, click **Clean Solution**.  
  
## Next Steps  
 Now that you have created a basic document-level customization for Excel, you can learn more about how to develop customizations from these topics:  
  
-   General programming tasks that you can perform in document-level customizations: [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md).  
  
-   Programming tasks that are specific to document-level customizations for Excel: [Excel Solutions](../vsto/excel-solutions.md).  
  
-   Using the object model of Excel: [Excel Object Model Overview](../vsto/excel-object-model-overview.md).  
  
-   Customizing the UI of Excel, for example, by adding a custom tab to the Ribbon or creating your own actions pane: [Office UI Customization](../vsto/office-ui-customization.md).  
  
-   Using extended Excel objects provided by Office development tools in Visual Studio to perform tasks that are not possible by using the Excel object model (for example, hosting managed controls on documents and binding Excel controls to data by using the Windows Forms data binding model): [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md).  
  
-   Building and debugging document-level customizations for Excel: [Building Office Solutions](../vsto/building-office-solutions.md).  
  
-   Deploying document-level customizations for Excel: [Deploying an Office Solution](../vsto/deploying-an-office-solution.md).  
  
## See Also  
 [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)   
 [Excel Solutions](../vsto/excel-solutions.md)   
 [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md)   
 [Excel Object Model Overview](../vsto/excel-object-model-overview.md)   
 [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)   
 [Office UI Customization](../vsto/office-ui-customization.md)   
 [Building Office Solutions](../vsto/building-office-solutions.md)   
 [Deploying an Office Solution](../vsto/deploying-an-office-solution.md)   
 [Office Project Templates Overview](../vsto/office-project-templates-overview.md)  
  
  