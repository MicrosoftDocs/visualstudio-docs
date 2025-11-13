---
title: "Synchronize custom task pane with Ribbon button"
description: Learn how you can create a custom task pane that users can hide or display by clicking a toggle button on the ribbon.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "custom task panes [Office development in Visual Studio], showing and hiding"
  - "showing custom task panes"
  - "Ribbon [Office development in Visual Studio], custom task panes"
  - "toggle buttons [Office development in Visual Studio]"
  - "custom task panes [Office development in Visual Studio], synchronizing with Ribbon button"
  - "user interfaces [Office development in Visual Studio], custom task panes"
  - "synchronization [Office development in Visual Studio], custom task panes"
  - "task panes [Office development in Visual Studio], showing and hiding"
  - "custom task panes [Office development in Visual Studio], creating"
  - "hiding custom task panes"
  - "task panes [Office development in Visual Studio], creating"
  - "task panes [Office development in Visual Studio], synchronizing with Ribbon button"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Synchronize a custom task pane with a Ribbon button

  This walkthrough demonstrates how to create a custom task pane that users can hide or display by clicking a toggle button on the ribbon. You should always create a user interface (UI) element, such as a button, that users can click to display or hide your custom task pane, because Microsoft Office applications do not provide a default way for users to show or hide custom task panes.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

 Although this walkthrough uses Excel specifically, the concepts demonstrated by the walkthrough are applicable to any applications that are listed above.

 This walkthrough illustrates the following tasks:

- Designing the UI of the custom task pane.

- Adding a toggle button to the Ribbon.

- Synchronizing the toggle button with the custom task pane.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Excel or Microsoft  Excel 2013 .

## Create the Add-in project
 In this step, you will create a VSTO Add-in project for Excel.

### To create a new project

1. Create an Excel Add-in project with the name **SynchronizeTaskPaneAndRibbon**, using the Excel Add-in project template. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the **ThisAddIn.cs** or **ThisAddIn.vb** code file and adds the **SynchronizeTaskPaneAndRibbon** project to **Solution Explorer**.

## Add a toggle button to the ribbon
 One of the Office application design guidelines is that users should always have control of the Office application UI. To enable users to control the custom task pane, you can add a Ribbon toggle button that shows and hides the task pane. To create a toggle button, add a **Ribbon (Visual Designer)** item to the project. The designer helps you add and position controls, set control properties, and handle control events. For more information, see [Ribbon designer](../vsto/ribbon-designer.md).

### To add a toggle button to the ribbon

1. On the **Project** menu, click **Add New Item**.

2. In the **Add New Item** dialog box, select **Ribbon (Visual Designer)**.

3. Change the name of the new Ribbon to **ManageTaskPaneRibbon**, and click **Add**.

     The **ManageTaskPaneRibbon.cs** or **ManageTaskPaneRibbon.vb** file opens in the Ribbon Designer and displays a default tab and group.

4. In the Ribbon Designer, click **group1**.

5. In the **Properties** window, set the **Label** property to **Task Pane Manager**.

6. From the **Office Ribbon Controls** tab of the **Toolbox**, drag a **ToggleButton** onto the **Task Pane Manager** group.

7. Click **toggleButton1**.

8. In the **Properties** window, set the **Label** property to **Show Task Pane**.

## Design the user interface of the custom task pane
 There is no visual designer for custom task panes, but you can design a user control with the layout you want. Later in this walkthrough, you will add the user control to the custom task pane.

### To design the user interface of the custom task pane

1. On the **Project** menu, click **Add User Control**.

2. In the **Add New Item** dialog box, change the name of the user control to **TaskPaneControl**, and click **Add**.

     The user control opens in the designer.

3. From the **Common Controls** tab of the **Toolbox**, drag a **TextBox** control to the user control.

## Create the custom task pane
 To create the custom task pane when the VSTO Add-in starts, add the user control to the task pane in the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler of the VSTO Add-in. By default, the custom task pane will not be visible. Later in this walkthrough, you will add code that will display or hide the task pane when the user clicks the toggle button you added to the ribbon.

### To create the custom task pane

1. In **Solution Explorer**, expand **Excel**.

2. Right-click **ThisAddIn.cs** or **ThisAddIn.vb** and click **View Code**.

3. Add the following code to the `ThisAddIn` class. This code declares an instance of `TaskPaneControl` as a member of `ThisAddIn`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneRibbonSynchronize/ThisAddIn.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneRibbonSynchronize/ThisAddIn.vb" id="Snippet1":::
     ---

4. Replace the `ThisAddIn_Startup` event handler with the following code. This code adds the `TaskPaneControl` object to the `CustomTaskPanes` field, but it does not display the custom task pane (by default, the <xref:Microsoft.Office.Tools.CustomTaskPane.Visible%2A> property of the <xref:Microsoft.Office.Tools.CustomTaskPane> class is **false**). The Visual C# code also attaches an event handler to the <xref:Microsoft.Office.Tools.CustomTaskPane.VisibleChanged> event.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneRibbonSynchronize/ThisAddIn.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneRibbonSynchronize/ThisAddIn.vb" id="Snippet2":::
     ---

5. Add the following method to the `ThisAddIn` class. This method handles the <xref:Microsoft.Office.Tools.CustomTaskPane.VisibleChanged> event. When the user closes the task pane by clicking the **Close** button (X), this method updates the state of the toggle button on the Ribbon.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneRibbonSynchronize/ThisAddIn.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneRibbonSynchronize/ThisAddIn.vb" id="Snippet3":::
     ---

6. Add the following property to the `ThisAddIn` class. This property exposes the private `taskPaneValue` object to other classes. Later in this walkthrough, you will add code to the `MyRibbon` class that uses this property.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneRibbonSynchronize/ThisAddIn.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneRibbonSynchronize/ThisAddIn.vb" id="Snippet4":::
     ---

## Hide and show the custom task pane by using the toggle button
 The last step is to add code that displays or hides the custom task pane when the user clicks the toggle button on the Ribbon.

### To display and hide the custom task pane by using the toggle button

1. In the Ribbon Designer, double-click the **Show Task Pane** toggle button.

     Visual Studio automatically generates an event handler named `toggleButton1_Click`, which handles the <xref:Microsoft.Office.Tools.Ribbon.RibbonToggleButton.Click> event of the toggle button. Visual Studio also opens the *MyRibbon.cs* or *MyRibbon.vb* file in the Code Editor.

2. Replace the `toggleButton1_Click` event handler with the following code. When the user clicks the toggle button, this code displays or hides the custom task pane, depending on whether the toggle button is pressed or not pressed.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneRibbonSynchronize/ManageTaskPaneRibbon.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneRibbonSynchronize/ManageTaskPaneRibbon.vb" id="Snippet5":::
     ---

## Test the Add-in
 When you run the project, Excel opens without displaying the custom task pane. Click the toggle button on the ribbon to test the code.

### To test your VSTO Add-in

1. Press **F5** to run your project.

     Confirm that Excel opens, and the **Add-Ins** tab appears on the ribbon.

2. Click the **Add-Ins** tab on the ribbon.

3. In the **Task Pane Manager** group, click the **Show Task Pane** toggle button.

     Verify that the task pane is alternately displayed and hidden when you click the toggle button.

4. When the task pane is visible, click the **Close** button (X) in the corner of the task pane.

     Verify that the toggle button appears to be not pressed.

## Next steps
 You can learn more about how to create custom task panes from these topics:

- Create a custom task pane in a VSTO Add-in for a different application. For more information about the applications that support custom task panes, see [Custom task panes](../vsto/custom-task-panes.md).

- Automate an application from a custom task pane. For more information, see [Walkthrough: Automate an application from a custom task pane](../vsto/walkthrough-automating-an-application-from-a-custom-task-pane.md).

- Create a custom task pane for every e-mail message that is opened in Outlook. For more information, see [Walkthrough: Display custom task panes with email messages in Outlook](../vsto/walkthrough-displaying-custom-task-panes-with-e-mail-messages-in-outlook.md).

## Related content
- [Custom task panes](../vsto/custom-task-panes.md)
- [How to: Add a custom task pane to an application](../vsto/how-to-add-a-custom-task-pane-to-an-application.md)
- [Walkthrough: Automate an application from a custom task pane](../vsto/walkthrough-automating-an-application-from-a-custom-task-pane.md)
- [Walkthrough: Display custom task panes with email messages in Outlook](../vsto/walkthrough-displaying-custom-task-panes-with-e-mail-messages-in-outlook.md)
- [Ribbon overview](../vsto/ribbon-overview.md)
