---
title: "Create Visual Studio Tools for Office Add-ins: Outlook mail"
description: Create a VSTO add-in for the Microsoft Office Outlook with features that are available to the application itself, regardless of which Outlook items are open.
ms.date: "08/14/2019"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application-level add-ins [Office development in Visual Studio], creating your first project"
  - "Office development in Visual Studio, creating your first project"
  - "add-ins [Office development in Visual Studio], creating your first project"
  - "Outlook [Office development in Visual Studio], creating your first project"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create your first VSTO Add-in for Outlook

  This walkthrough shows you how to create a VSTO Add-in for Microsoft Office Outlook. The features that you create in this kind of solution are available to the application itself, regardless of which Outlook item is open. For more information, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

 This walkthrough illustrates the following tasks:

- Creating an Outlook VSTO Add-in project for Outlook.

- Writing code that uses the object model of Outlook to add text to the subject and body of a new mail message.

- Building and running the project to test it.

- Cleaning up the completed project so that the VSTO Add-in no longer runs automatically on your development computer.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Outlook

## Create the project

### To create a new Outlook project in Visual Studio

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.

4. Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.

5. In the list of project templates, choose an Outlook VSTO Add-in project.

6. In the **Name** box, type **FirstOutlookAddIn**.

7. Click **OK**.

     Visual Studio creates the **FirstOutlookAddIn** project and opens the **ThisAddIn** code file in the editor.

## Write code that adds text to each new mail message
 Next, add code to the ThisAddIn code file. The new code uses the object model of Outlook to add text to each new mail message. By default, the ThisAddIn code file contains the following generated code:

- A partial definition of the `ThisAddIn` class. This class provides an entry point for your code and provides access to the object model of Outlook. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md). The remainder of the `ThisAddIn` class is defined in a hidden code file that you should not modify.

- The `ThisAddIn_Startup` and `ThisAddIn_Shutdown` event handlers. These event handlers are called when Outlook loads and unloads your VSTO Add-in. Use these event handlers to initialize your VSTO Add-in when it is loaded, and to clean up resources used by your VSTO Add-in when it is unloaded. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### To add text to the subject and body of each new mail message

1. In the ThisAddIn code file, declare a field named `inspectors` in the `ThisAddIn` class. The `inspectors` field maintains a reference to the collection of Inspector windows in the current Outlook instance. This reference prevents the garbage collector from freeing the memory that contains the event handler for the <xref:Microsoft.Office.Interop.Outlook.InspectorsEvents_Event.NewInspector> event.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OutlookAddInTutorial/ThisAddIn.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_OutlookAddInTutorial/ThisAddIn.vb" id="Snippet1":::
    ---

2. Replace the `ThisAddIn_Startup` method with the following code. This code attaches an event handler to the <xref:Microsoft.Office.Interop.Outlook.InspectorsEvents_Event.NewInspector> event.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OutlookAddInTutorial/ThisAddIn.cs" id="Snippet2":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_OutlookAddInTutorial/ThisAddIn.vb" id="Snippet2":::
    ---

3. In the ThisAddIn code file, add the following code to the `ThisAddIn` class. This code defines an event handler for the <xref:Microsoft.Office.Interop.Outlook.InspectorsEvents_Event.NewInspector> event.

    When the user creates a new mail message, this event handler adds text to the subject line and body of the message.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OutlookAddInTutorial/ThisAddIn.cs" id="Snippet3":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_OutlookAddInTutorial/ThisAddIn.vb" id="Snippet3":::
    ---

   To modify each new mail message, the previous code examples use the following objects:

- The `Application` field of the `ThisAddIn` class. The `Application` field returns an <xref:Microsoft.Office.Interop.Outlook.Application> object, which represents the current instance of Outlook.

- The `Inspector` parameter of the event handler for the <xref:Microsoft.Office.Interop.Outlook.InspectorsEvents_Event.NewInspector> event. The `Inspector` parameter is an <xref:Microsoft.Office.Interop.Outlook.Inspector> object, which represents the Inspector window of the new mail message. For more information, see [Outlook solutions](../vsto/outlook-solutions.md).

## Test the project
 When you build and run the project, verify that the text appears in the subject line and body of a new mail message.

### To test the project

1. Press **F5** to build and run your project.

     When you build the project, the code is compiled into an assembly that is included in the build output folder for the project. Visual Studio also creates a set of registry entries that enable Outlook to discover and load the VSTO Add-in, and it configures the security settings on the development computer to enable the VSTO Add-in to run. For more information, see [Office solution build process overview](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md).

2. In Outlook, create a new mail message.

3. Verify that the following text is added to both the subject line and body of the message.

     **This text was added by using code.**

4. Close Outlook.

## Clean up the project
 When you finish developing a project, remove the VSTO Add-in assembly, registry entries, and security settings from your development computer. Otherwise, the VSTO Add-in will run every time that you open Outlook on the development computer.

### To clean up your project

1. In Visual Studio, on the **Build** menu, click **Clean Solution**.

## Next steps
 Now that you have created a basic VSTO Add-in for Outlook, you can learn more about how to develop VSTO Add-ins from these topics:

- General programming tasks that you can perform by using VSTO Add-ins for Outlook. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

- Using the object model of Outlook. For more information, see [Outlook solutions](../vsto/outlook-solutions.md).

- Customizing the UI of Outlook, for example, by adding a custom tab to the Ribbon or creating your own custom task pane. For more information, see [Office UI customization](../vsto/office-ui-customization.md).

- Building and debugging VSTO Add-ins for Outlook. For more information, see [Build Office solutions](../vsto/building-office-solutions.md).

- Deploying VSTO Add-ins for Outlook. For more information, see [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## Related content
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Outlook solutions](../vsto/outlook-solutions.md)
- [Office UI customization](../vsto/office-ui-customization.md)
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)
