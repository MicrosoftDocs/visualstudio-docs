---
title: "Walkthrough: Automate an application from a custom task pane"
description: Create a custom task pane that automates Microsoft PowerPoint by inserting dates into a slide when the user clicks a MonthCalendar control on the custom task pane.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "task panes [Office development in Visual Studio], PowerPoint"
  - "PowerPoint [Office development in Visual Studio], custom task panes"
  - "automating Office applications"
  - "custom task panes [Office development in Visual Studio], automating applications"
  - "custom task panes [Office development in Visual Studio], PowerPoint"
  - "task panes [Office development in Visual Studio], automating applications"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Automate an application from a custom task pane

  This walkthrough demonstrates how to create a custom task pane that automates PowerPoint. The custom task pane inserts dates into a slide when the user clicks a <xref:System.Windows.Forms.MonthCalendar> control that is on the custom task pane.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

 Although this walkthrough uses PowerPoint specifically, the concepts demonstrated by the walkthrough are applicable to any applications that are listed above.

 This walkthrough illustrates the following tasks:

- Designing the user interface of the custom task pane.

- Automating PowerPoint from the custom task pane.

- Displaying the custom task pane in PowerPoint.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft PowerPoint 2010 or  PowerPoint 2013 .

## Create the Add-in project
 The first step is to create a VSTO Add-in project for PowerPoint.

### To create a new project

1. Create a PowerPoint VSTO Add-in project with the name **MyAddIn**, by using the PowerPoint Add-in project template. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the **ThisAddIn.cs** or **ThisAddIn.vb** code file and adds the **MyAddIn** project to **Solution Explorer**.

## Design the user interface of the custom task pane
 There is no visual designer for custom task panes, but you can design a user control with the layout you want. Later in this walkthrough, you will add the user control to the custom task pane.

#### To design the user interface of the custom task pane

1. On the **Project** menu, click **Add User Control**.

2. In the **Add New Item** dialog box, change the name of the user control to **MyUserControl**, and click **Add**.

     The user control opens in the designer.

3. From the **Common Controls** tab of the **Toolbox**, drag a **MonthCalendar** control to the user control.

     If the **MonthCalendar** control is larger than the design surface of the user control, resize the user control to fit the **MonthCalendar** control.

## Automate PowerPoint from the custom task pane
 The purpose of the VSTO Add-in is to put a selected date on the first slide of the active presentation. Use the <xref:System.Windows.Forms.MonthCalendar.DateChanged> event of the control to add the selected date whenever it changes.

### To automate PowerPoint from the custom task pane

1. In the designer, double-click the <xref:System.Windows.Forms.MonthCalendar> control.

     The **MyUserControl.cs** or **MyUserControl.vb** file opens, and an event handler for the <xref:System.Windows.Forms.MonthCalendar.DateChanged> event is created.

2. Add the following code to the top of the file. This code creates aliases for the <xref:Microsoft.Office.Core> and [PowerPoint](/previous-versions/office/developer/office-2010/ff763170%28v%3doffice.14%29) namespaces.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneMonthCalendar/MyUserControl.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneMonthCalendar/MyUserControl.vb" id="Snippet1":::
     ---

3. Add the following code to the `MyUserControl` class. This code declares a [Shape](/previous-versions/office/developer/office-2010/ff760244(v=office.14)) object as a member of `MyUserControl`. In the following step, you will use this [Shape](/previous-versions/office/developer/office-2010/ff760244(v=office.14)) to add a text box to a slide in the active presentation.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneMonthCalendar/MyUserControl.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneMonthCalendar/MyUserControl.vb" id="Snippet2":::
     ---

4. Replace the `monthCalendar1_DateChanged` event handler with the following code. This code adds a text box to the first slide in the active presentation, and then adds the currently selected date to the text box. This code uses the `Globals.ThisAddIn` object to access the object model of PowerPoint.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneMonthCalendar/MyUserControl.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneMonthCalendar/MyUserControl.vb" id="Snippet3":::
     ---

5. In **Solution Explorer**, right-click the **MyAddIn** project and then click **Build**. Verify that the project builds without errors.

## Display the custom task pane
 To display the custom task pane when the VSTO Add-in starts, add the user control to the task pane in the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler of the VSTO Add-in.

### To display the custom task pane

1. In **Solution Explorer**, expand **PowerPoint**.

2. Right-click **ThisAddIn.cs** or **ThisAddIn.vb** and click **View Code**.

3. Add the following code to the `ThisAddIn` class. This code declares instances of `MyUserControl` and <xref:Microsoft.Office.Tools.CustomTaskPane> as members of the `ThisAddIn` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneMonthCalendar/ThisAddIn.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneMonthCalendar/ThisAddIn.vb" id="Snippet4":::
     ---

4. Replace the `ThisAddIn_Startup` event handler with the following code. This code creates a new <xref:Microsoft.Office.Tools.CustomTaskPane> by adding the `MyUserControl` object to the `CustomTaskPanes` collection. The code also displays the task pane.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneMonthCalendar/ThisAddIn.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneMonthCalendar/ThisAddIn.vb" id="Snippet5":::
     ---

## Test the Add-in
 When you run the project, PowerPoint opens and the VSTO Add-in displays the custom task pane. Click the <xref:System.Windows.Forms.MonthCalendar> control to test the code.

### To test your VSTO Add-in

1. Press **F5** to run your project.

2. Confirm that the custom task pane is visible.

3. Click a date in the <xref:System.Windows.Forms.MonthCalendar> control on the task pane.

     The date is inserted into the first slide in the active presentation.

## Next steps
 You can learn more about how to create custom task panes from these topics:

- Create a custom task pane in a VSTO Add-in for a different application. For more information about the applications that support custom task panes, see [Custom task panes](../vsto/custom-task-panes.md).

- Create a Ribbon button that can be used to hide or display a custom task pane. For more information, see [Walkthrough: Synchronize a custom task pane with a Ribbon button](../vsto/walkthrough-synchronizing-a-custom-task-pane-with-a-ribbon-button.md).

- Create a custom task pane for every e-mail message that is opened in Outlook. For more information, see [Walkthrough: Display custom task panes with email messages in Outlook](../vsto/walkthrough-displaying-custom-task-panes-with-e-mail-messages-in-outlook.md).

## Related content
- [Custom task panes](../vsto/custom-task-panes.md)
- [How to: Add a custom task pane to an application](../vsto/how-to-add-a-custom-task-pane-to-an-application.md)
- [Walkthrough: Synchronize a custom task pane with a Ribbon button](../vsto/walkthrough-synchronizing-a-custom-task-pane-with-a-ribbon-button.md)
- [Walkthrough: Display custom task panes with email messages in Outlook](../vsto/walkthrough-displaying-custom-task-panes-with-e-mail-messages-in-outlook.md)
