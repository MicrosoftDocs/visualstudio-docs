---
title: "Walkthrough: Import a form region that is designed in Outlook"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "importing form regions"
  - "form regions [Office development in Visual Studio], importing"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Import a form region that is designed in Outlook
  This walkthrough demonstrates how to design a form region in Microsoft Office Outlook, and then import the form region into an Outlook VSTO Add-in project by using the **New Form Region** wizard. Designing the form region in Outlook makes it possible for you to add native Outlook controls to the form region that bind to Outlook data. After you import the form region, you can handle the events of each control.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

 This walkthrough illustrates the following tasks:

- Designing a form region by using the form region designer in Outlook.

- Importing a form region into an Outlook VSTO Add-in project.

- Handling the events of controls on the form region.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- [!INCLUDE[Outlook_15_short](../vsto/includes/outlook-15-short-md.md)] or [!INCLUDE[Outlook_14_short](../vsto/includes/outlook-14-short-md.md)].

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Design a form region by using the form region designer in Outlook
 In this step you will design a form region in Outlook. You will then the save the form region to an easy-to-find location so that you can import it into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

 This example form region completely replaces the usual Task form. It provides a way to track the progress of all tasks that must be completed before the main task can be performed (prerequisite tasks). The form region displays a list of the prerequisite tasks, and shows the completion status for each task in the list. Users can add tasks to the list and remove them. They can also refresh the completion status of each task.

### To design a form region by using the form region designer in Outlook

1. Start Microsoft Office Outlook.

2. In Outlook, on the **Developer** tab, click **Design a Form**. For more information, see [How to: Show the developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

3. In the **Design Form** box, click **Task**, and then click **Open**.

4. In Outlook, on the **Developer** tab, in the **Design** group, click **New Form Region**.

     A new form region opens. If the **Field Chooser** does not appear, click **Field Chooser** in the **Tools** group.

5. Drag the **Subject** field and the **% Complete** field from the **Field Chooser** to the form region.

6. In the **Tools** group, click **Control Toolbox** to open the **Toolbox**.

7. Drag a Label from the **Toolbox** to the form region. Position the label beneath the **Subject** and **% Complete** fields.

8. Right-click the label, and then click **Advanced Properties**.

9. In the **Properties** window, set the **Caption** property to **This task depends on the following tasks**, set the **Width** property to **200**, and then click **Apply**.

10. Drag a ListBox control from the **Toolbox** to the form region. Position the list box beneath the **This task depends on the following tasks** label.

11. Select the list box that you just added.

12. In the **Properties** window, set **Width** to **300**, and then click **Apply**.

13. Drag a Label from the **Toolbox** to the form region. Position the label beneath the list box.

14. Select the label that you just added.

15. In the **Properties** window, set the **Caption** property to **Select a task to add to the list of dependent tasks**, set the **Width** property to **200**, and then click **Apply**.

16. Drag a ComboBox control from the **Toolbox** to the form region. Position the combo box beneath the **Select a task to add to the list of dependent tasks** label.

17. Select the combo box that you just added.

18. In the **Properties** window, set the **Width** property to **300**, and then click **Apply**.

19. Drag a CommandButton control from the **Toolbox** to the form region. Position the command button next to the combo box.

20. Select the command button that you just added.

21. In the **Properties** window, set **Name** to **AddDependentTask**, set **Caption** to **Add Dependent Task**, set **Width** to **100**, and then click **Apply**.

22. In the **Field Chooser**, click **New**.

23. In the **New Field** dialog box, type **hiddenField** in the **Name** field, and then click **OK**.

24. Drag the **hiddenField** field from the **Field Chooser** to the form region.

25. In the **Properties** window, set **Visible** to **0 - False**, and then click **Apply**.

26. In Outlook, on the **Developer** tab, in the **Design** group, click the **Save** button, and then click **Save Form Region As**.

     Name the form region **TaskFormRegion** and save it to a local directory on your computer.

     Outlook saves the form region as an Outlook Form Storage (*.ofs*) file. The form region is saved with the name *TaskFormRegion.ofs*.

27. Exit Outlook.

## Create a new Outlook Add-in project
 In this step, you will create an Outlook VSTO Add-in project. Later in this walkthrough, you will import the form region into to the project.

### To create a new Outlook VSTO Add-in project

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], create an Outlook VSTO Add-in project with the name **TaskAddIn**.

2. In the **New Project** dialog box, select **Create directory for solution**.

3. Save the project to the default project directory.

     For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

## Import the form region
 You can import the form region that you designed in Outlook into the Outlook VSTO Add-in project by using the **New Outlook Form Region** wizard.

### To import the form region into the Outlook VSTO Add-in project

1. In **Solution Explorer**, right-click the **TaskAddIn** project, point to **Add**, and then click **New Item**.

2. In the **Templates** pane, select **Outlook Form Region**, name the file **TaskFormRegion**, and then click **Add**.

     The **NewOutlook Form Region** wizard starts.

3. On the **Select how you want to create the form region** page, click **Import an Outlook Form Storage (.ofs) File**, and then click **Browse**.

4. In the **Existing Outlook Form Region File Location** dialog box, browse to the location of *TaskFormRegion.ofs*, select **TaskFormRegion.ofs**, click **Open**, and then click **Next**.

5. On the **Select the type of form region you want to create** page, click **Replace-all**, and then click **Next**.

     A *replace-all* form region replaces the entire Outlook form. For more information about form region types, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

6. On the **Supply descriptive text and select your display preferences** page, click **Next**.

7. On the **Identify the message classes that will display this form region** page, in the **Which custom message classes will display this form region** field, type **IPM.Task.TaskFormRegion**, and then click **Finish**.

     A *TaskFormRegion.cs* or *TaskFormRegion.vb* file is added to your project.

## Handle the events of controls on the form region
 Now that you have the form region in the project, you can add code that handles the `Microsoft.Office.Interop.Outlook.OlkCommandButton.Click` event of the button that you added to the form region in Outlook.

 Also, add code to the <xref:Microsoft.Office.Tools.Outlook.FormRegionControl.FormRegionShowing> event that updates controls on the form region when the form region appears.

### To handle the events of controls on the form region

1. In **Solution Explorer**, right-click *TaskFormRegion.cs* or *TaskFormRegion.vb*, and then click **View Code**.

    *TaskFormRegion.cs* or *TaskFormRegion.vb* opens in the Code Editor.

2. Add the following code to the `TaskFormRegion` class. This code populates the combo box on the form region with the subject line of each task from the Outlook Tasks folder.

    [!code-csharp[Trin_Outlook_FR_Import#1](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Import/TaskFormRegion.cs#1)]
    [!code-vb[Trin_Outlook_FR_Import#1](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Import_O12/TaskFormRegion.vb#1)]

3. Add the following code to the `TaskFormRegion` class. This code performs the following tasks:

   - Locates the `Microsoft.Office.Interop.Outlook.TaskItem` in the Tasks folder by calling the `FindTaskBySubjectName` helper method and passing the subject of the desired task. You will add the `FindTaskBySubjectName` helper method in the next step.

   - Adds the `Microsoft.Office.Interop.Outlook.TaskItem.Subject` and `Microsoft.Office.Interop.Outlook.TaskItem.PercentComplete` values to the dependent task list box.

   - Adds the subject of the task to the hidden field on the form region. The hidden field stores these values as part of the Outlook item.

     [!code-csharp[Trin_Outlook_FR_Import#2](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Import/TaskFormRegion.cs#2)]
     [!code-vb[Trin_Outlook_FR_Import#2](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Import_O12/TaskFormRegion.vb#2)]

4. Add the following code to the `TaskFormRegion` class. This code provides the helper method `FindTaskBySubjectName` that was described in the preceding step.

    [!code-csharp[Trin_Outlook_FR_Import#3](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Import/TaskFormRegion.cs#3)]
    [!code-vb[Trin_Outlook_FR_Import#3](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Import_O12/TaskFormRegion.vb#3)]

5. Add the following code to the `TaskFormRegion` class. This code performs the following tasks:

   - Refreshes the list box on the form region with the current completion status of each dependent task.

   - Parses the hidden text field to obtain the subject of each dependent task. It then locates each `Microsoft.Office.Interop.Outlook.TaskItem` in the *Tasks* folder by calling the `FindTaskBySubjectName` helper method and passing the subject of each task.

   - Adds the `Microsoft.Office.Interop.Outlook.TaskItem.Subject` and `Microsoft.Office.Interop.Outlook.TaskItem.PercentComplete` values to the dependent task list box.

     [!code-csharp[Trin_Outlook_FR_Import#4](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Import/TaskFormRegion.cs#4)]
     [!code-vb[Trin_Outlook_FR_Import#4](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Import_O12/TaskFormRegion.vb#4)]

6. Replace the `TaskFormRegion_FormRegionShowing` event handler with the following code. This code performs the following tasks:

   - Populates the combo box on the form region with task subjects when the form region appears.

   - Calls the `RefreshTaskListBox` helper method when the form region appears. This displays any dependent tasks that were added to the list box when the item was previously opened.

     [!code-csharp[Trin_Outlook_FR_Import#5](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Import/TaskFormRegion.cs#5)]
     [!code-vb[Trin_Outlook_FR_Import#5](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Import_O12/TaskFormRegion.vb#5)]

## Test the Outlook form region
 To test the form region, add tasks to the list of prerequisite tasks on the form region. Update the completion status of a prerequisite task, and then view the updated completion status of the task in the prerequisite task list.

### To test the form region

1. Press **F5** to run the project.

     Outlook starts.

2. In Outlook, on the **Home** tab, click **New Items**, and then click **Task**.

3. In the task form, type **Dependent Task** in the **Subject** field.

4. On the **Task** tab of the Ribbon, in the **Actions** group, click **Save & Close**.

5. In Outlook, on the **Home** tab, click **New Items**, click **More Items**, and then click **Choose Form**.

6. In the **Choose Form** dialog box, click **TaskFormRegion**, and then click **Open**.

     The **TaskFormRegion** form region appears. This form replaces the entire task form. The **Select a task to add to the list of dependent tasks** combo box is populated with other tasks in the Tasks folder.

7. On the task form, in the **Subject** field, type **Primary Task**.

8. In the **Select a task to add to the list of dependent tasks** combo box, select **Dependent Task**, and then click **Add Dependent Task**.

     **0% Complete -- Dependent Task** appears in the **This task depends on the following tasks** list box. This demonstrates that you successfully handled the `Microsoft.Office.Interop.Outlook.OlkCommandButton.Click` event of the button.

9. Save and close the **Primary Task** item.

10. Reopen the Dependent Task item in Outlook.

11. On the Dependent Task form, change the **% Complete** field to **50%**.

12. On the **Task** tab of the Dependent Task Ribbon, in the **Actions** group, click **Save & Close**.

13. Reopen the **Primary Task** item in Outlook.

     **50% Complete -- Dependent Task** now appears in the **This task depends on the following tasks** list box.

## Next steps
 You can learn more about how to customize the UI of an Outlook application from these topics:

- To learn more about how to design the appearance of a form region by dragging managed controls onto a visual designer, see [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md).

- To learn about how to customize the Ribbon of an Outlook item, see [Customize a ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md).

- To learn more about how to add a custom task pane to Outlook, see [Custom task panes](../vsto/custom-task-panes.md).

## See also
- [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Guidelines to create Outlook form regions](../vsto/guidelines-for-creating-outlook-form-regions.md)
- [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md)
- [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md)
- [Associate a form region with an Outlook message class](../vsto/associating-a-form-region-with-an-outlook-message-class.md)
- [Custom actions in Outlook form regions](../vsto/custom-actions-in-outlook-form-regions.md)
- [How to: Prevent Outlook from displaying a form region](../vsto/how-to-prevent-outlook-from-displaying-a-form-region.md)
