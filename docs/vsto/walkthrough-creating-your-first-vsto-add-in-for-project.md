---
title: "Walkthrough: Create your first VSTO Add-in for Project"
description: Create an application-level Add-in for Microsoft Project. This feature is available to the application itself, regardless of which projects are open.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application-level add-ins [Office development in Visual Studio], creating your first project"
  - "Office development in Visual Studio, creating your first project"
  - "Project [Office development in Visual Studio], creating your first project"
  - "add-ins [Office development in Visual Studio], creating your first project"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Create your first VSTO Add-in for Project

  This walkthrough shows you how to create a VSTO Add-in for Microsoft Office Project. The features that you create in this kind of solution are available to the application itself, regardless of which projects are open. For more information, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

 [!INCLUDE[appliesto_projallapp](../vsto/includes/appliesto-projallapp-md.md)]

 This walkthrough illustrates the following tasks:

- Creating a Project VSTO Add-in project.

- Writing code that uses the object model of Project to add a task to a new project.

- Building and running the project to test it.

- Cleaning up the completed project so that the VSTO Add-in no longer runs automatically on your development computer.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

-  Project 2013  or Project 2010.

## Create the project

### To create a new project in Visual Studio

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. In the templates pane, expand **Visual C#** or **Visual Basic**, and then expand **Office/SharePoint**.

4. Under the expanded **Office/SharePoint** node, select the **Office Add-ins** node.

5. In the list of project templates, select **Project 2010 Add-in** or **Project 2013 Add-in**.

6. In the **Name** box, type **FirstProjectAddIn**.

7. Click **OK**.

     Visual Studio creates the **FirstProjectAddIn** project and opens the **ThisAddIn** code file in the editor.

## Write code that adds a new task to a project
 Next, add code to the ThisAddIn code file. The new code uses the object model of Project to add a new task to a project. By default, the ThisAddIn code file contains the following generated code:

- A partial definition of the `ThisAddIn` class. This class provides an entry point for your code and provides access to the object model of Project. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md). The remainder of the `ThisAddIn` class is defined in a hidden code file that you should not modify.

- The `ThisAddIn_Startup` and `ThisAddIn_Shutdown` event handlers. These event handlers are called when Project loads and unloads your VSTO Add-in. Use these event handlers to initialize your VSTO Add-in when it is loaded, and to clean up resources used by your VSTO Add-in when it is unloaded. For more information, see [Events in Office projects](../vsto/events-in-office-projects.md).

### To add a task to a new project

1. In the ThisAddIn code file, add the following code to the `ThisAddIn` class. This code defines an event handler for the `NewProject` event of the `Microsoft.Office.Interop.MSProject.Application` class.

    When the user creates a new project, this event handler adds a task to the project.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ProjectAddInTutorial/ThisAddIn.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_ProjectAddInTutorial/ThisAddIn.vb" id="Snippet1":::
    ---

   To modify the project, this code example uses the following objects:

- The `Application` field of the `ThisAddIn` class. The `Application` field returns a `Microsoft.Office.Interop.MSProject.Application` object, which represents the current instance of Project.

- The `pj` parameter of the event handler for the NewProject event. The `pj` parameter is a `Microsoft.Office.Interop.MSProject.Project` object, which represents the project. For more information, see [Project solutions](../vsto/project-solutions.md).

1. If you are using C#, add the following code to the `ThisAddIn_Startup` event handler. This code connects the `Application_Newproject` event handler with the NewProject event.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_ProjectAddInTutorial/ThisAddIn.cs" id="Snippet2":::

## Test the project
 When you build and run the project, verify that the new task appears in the resulting new project.

### To test the project

1. Press **F5** to build and run your project. Microsoft Project starts and automatically opens a new blank project.

     When you build the project, the code is compiled into an assembly that is included in the build output folder for the project. Visual Studio also creates a set of registry entries that enable Project to discover and load the VSTO Add-in, and it configures the security settings on the development computer to enable the VSTO Add-in to run. For more information, see [Office solution build process overview](/previous-versions/visualstudio/visual-studio-2010/h2c9cdc0(v=vs.100)).

2. Verify that a new task is added to the blank project.

3. Verify that the following text appears in the **Task Name** field of the task.

     **This text was added by using code.**

4. Close Microsoft Project.

## Clean up the project
 When you finish developing a project, remove the VSTO Add-in assembly, registry entries, and security settings from your development computer. Otherwise, the VSTO Add-in will run every time you open Microsoft Project on the development computer.

### To clean up your project

1. In Visual Studio, on the **Build** menu, click **Clean Solution**.

## Next steps
 Now that you have created a basic VSTO Add-in for Project, you can learn more about how to develop VSTO Add-ins from these topics:

- General programming tasks that you can perform in VSTO Add-ins for Project: [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

- Using the object model of Project: [Project solutions](../vsto/project-solutions.md).

- Building and debugging VSTO Add-ins for Project: [Build Office solutions](../vsto/building-office-solutions.md).

- Deploying VSTO Add-ins for Project: [Deploy an Office solution](../vsto/deploying-an-office-solution.md).

## Related content
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Project solutions](../vsto/project-solutions.md)
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)
