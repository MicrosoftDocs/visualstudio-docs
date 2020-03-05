---
title: "Create & debug SharePoint workflow solution"
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.Workflow.WorkflowConditions"
  - "VS.SharePointTools.Workflow.WorkflowList"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, workflows"
  - "workflows [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Create and debug a SharePoint workflow solution
  This walkthrough demonstrates how to create a basic sequential workflow template. The workflow checks a property of a shared document library to determine whether a document has been reviewed. If the document has been reviewed, the workflow finishes.

 This walkthrough illustrates the following tasks:

- Creating a SharePoint list definition sequential workflow project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

- Creating workflow activities.

- Handling workflow activity events.

> [!NOTE]
> Although this walkthrough uses a sequential workflow project, the process is identical for a state machine workflow project.
>
> Also, your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of Microsoft Windows and SharePoint.

- Visual Studio.

## Add properties to the SharePoint shared documents library
 To track the review status of documents in the **Shared Documents** library, we will create three new properties for shared documents on our SharePoint site: `Status`, `Assignee`, and `Review Comments`. We define these properties in the **Shared Documents** library.

#### To add properties to the SharePoint shared documents library

1. Open a SharePoint site, such as http://\<system name>/SitePages/Home.aspx, in a Web browser.

2. On the QuickLaunch bar, choose **SharedDocuments**.

3. Choose **Library** on the **Library Tools** ribbon and then choose the **Create Column** button on the ribbon to create a new column.

4. Name the column **Document Status**, set its type to **Choice (menu to choose from)**, specify the following three choices, and then choose the **OK** button:

    - **Review Needed**

    - **Review Complete**

    - **Changes Requested**

5. Create two more columns and name them **Assignee** and **Review Comments**. Set the Assignee column type as a single line of text, and the Review Comments column type as multiple lines of text.

## Enable documents to be edited without requiring a check out
 It is easier to test the workflow template when you can edit the documents without having to check them out. In the next procedure, you configure the SharePoint site to enable that.

#### To enable documents to be edited without checking them out

1. On the QuickLaunch bar, choose the **Shared Documents** link.

2. On the **Library Tools** ribbon, choose the **Library** tab, and then choose the **Library Settings** button to display the **Document Library Settings** page.

3. In the **General Settings** section, choose the **Versioning Settings** link to display the **Versioning Settings** page.

4. Verify that the setting for **Require documents to be checked out before they can be edited** is **No**. If it is not, change it to **No** and then choose the **OK** button.

5. Close the browser.

## Create a SharePoint sequential workflow project
 A sequential workflow is a set of steps that executes in order until the last activity finishes. In this procedure, we create a sequential workflow that will apply to our Shared Documents list. The workflow wizard lets you associate the workflow with either the site definition or the list definition and lets you determine when the workflow will start.

#### To create a SharePoint sequential workflow project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project** to display the **New Project** dialog box.

3. Expand the **SharePoint** node under either **Visual C#** or **Visual Basic**, and then choose the **2010** node.

4. In the **Templates** pane, choose the **SharePoint 2010 Project** template.

5. In the **Name** box, enter **MySharePointWorkflow** and then choose the **OK** button.

     The **SharePoint Customization Wizard** appears.

6. In the **Specify the site and security level for debugging** page, choose the **Deploy as a farm solution** option button, and then choose the **Finish** button to accept the trust level and default site.

     This step sets the trust level for the solution as farm solution, the only available option for workflow projects. For more information, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

7. In **Solution Explorer**, choose the project node, and then, on the menu bar, choose **Project** > **Add New Item**.

8. Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node, and then choose the **2010** node.

9. In the **Templates** pane, choose the **Sequential Workflow (Farm Solution only)** template, and then choose the **Add** button.

     The **SharePoint Customization Wizard** appears.

10. In the **Specify the workflow name for debugging** page, accept the default name (**MySharePointWorkflow - Workflow1**). Keep the default workflow template type value, **List Workflow**, and then choose the **Next** button.

11. In the **Would you like Visual Studio to automatically associate the workflow in a debug session?** page, choose the **Next** button to accept all of the default settings.

     This step automatically associates the workflow with the Shared Documents library.

12. In the **Specify the conditions for how your workflow is started** page, leave the default options selected in the **How do you want the workflow to start?** section and choose the **Finish** button.

     This page enables you to specify when your workflow starts. By default, the workflow starts either when a user manually starts it in SharePoint or when an item to which the workflow is associated is created.

## Create workflow activities
 Workflows contain one or more *activities* that represent actions to perform. Use the workflow designer to arrange activities for a workflow. In this procedure, we will add two activities to the workflow: HandleExternalEventActivity and OnWorkFlowItemChanged. These activities monitor the review status of documents in the **Shared Documents** list

#### To create workflow activities

1. The workflow should be displayed in the workflow designer. If it is not, then open either **Workflow1.cs** or **Workflow1.vb** in **Solution Explorer**.

2. In the designer, choose the **OnWorkflowActivated1** activity.

3. In the **Properties** window, enter **onWorkflowActivated** next to the **Invoked** property, and then choose the Enter key.

     The Code Editor opens, and an event handler method named onWorkflowActivated is added to the Workflow1 code file.

4. Switch back to the workflow designer, open the toolbox, and then expand the **Windows Workflow v3.0** node.

5. In the **Windows Workflow v3.0** node of the **Toolbox**, perform one of the following sets of steps:

    1. Open the shortcut menu for the **While** activity, and then choose **Copy**. In the workflow designer, open the shortcut menu for the line under the **onWorkflowActivated1** activity, and then choose **Paste**.

    2. Drag the **While** activity from the **Toolbox** to the workflow designer, and connect the activity to the line under the **onWorkflowActivated1** activity.

6. Choose the **WhileActivity1** activity.

7. In the **Properties** window, set **Condition** to Code Condition.

8. Expand the **Condition** property, enter **isWorkflowPending** next to the child **Condition** property, and then choose the Enter key.

     The Code Editor opens, and a method named isWorkflowPending is added to the Workflow1 code file.

9. Switch back to the workflow designer, open the toolbox, and then expand the **SharePoint Workflow** node.

10. In the **SharePoint Workflow** node of the **Toolbox**, perform one of the following sets of steps:

    - Open the shortcut menu for the **OnWorkflowItemChanged** activity, and then choose **Copy**. In the workflow designer, open the shortcut menu for the line inside the **whileActivity1** activity, and then choose **Paste**.

    - Drag the **OnWorkflowItemChanged** activity from the **Toolbox** to the workflow designer, and connect the activity to the line inside the **whileActivity1** activity.

11. Choose the **onWorkflowItemChanged1** activity.

12. In the **Properties** window, set the properties as shown in the following table.

    |Property|Value|
    |--------------|-----------|
    |**CorrelationToken**|**workflowToken**|
    |**Invoked**|**onWorkflowItemChanged**|

## Handle activity events
 Finally, check the status of the document from each activity. If the document has been reviewed, then the workflow is finished.

#### To handle activity events

1. In *Workflow1.cs* or *Workflow1.vb*, add the following field to the top of the `Workflow1` class. This field is used in an activity to determine whether the workflow is finished.

    ```vb
    Dim workflowPending As Boolean = True
    ```

    ```csharp
    Boolean workflowPending = true;
    ```

2. Add the following method to the `Workflow1` class. This method checks the value of the `Document Status` property of the Documents list to determine whether the document has been reviewed. If the `Document Status` property is set to `Review Complete`, then the `checkStatus` method sets the `workflowPending` field to **false** to indicate that the workflow is ready to finish.

    ```vb
    Private Sub checkStatus()
        If CStr(workflowProperties.Item("Document Status")) = "Review Complete" Then
            workflowPending = False
        End If
    End Sub
    ```

    ```csharp
    private void checkStatus()
    {
        if ((string)workflowProperties.Item["Document Status"] == "Review Complete")
        workflowPending = false;
    }
    ```

3. Add the following code to the `onWorkflowActivated` and `onWorkflowItemChanged` methods to call the `checkStatus` method. When the workflow starts, the `onWorkflowActivated` method calls the `checkStatus` method to determine whether the document has already been reviewed. If it has not been reviewed, the workflow continues. When the document is saved, the `onWorkflowItemChanged` method calls the `checkStatus` method again to determine whether the document has been reviewed. While the `workflowPending` field is set to **true**, the workflow continues to run.

    ```vb
    Private Sub onWorkflowActivated(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        checkStatus()
    End Sub

    Private Sub onWorkflowItemChanged(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
        checkStatus()
    End Sub
    ```

    ```csharp
    private void onWorkflowActivated(object sender, ExternalDataEventArgs e)
    {
        // Check the status.
        checkStatus();
    }

    private void onWorkflowItemChanged(object sender, ExternalDataEventArgs e)
    {
        // Check the status.
        checkStatus();
    }
    ```

4. Add the following code to the `isWorkflowPending` method to check the status of the `workflowPending` property. Each time the document is saved, the **whileActivity1** activity calls the `isWorkflowPending` method. This method examines the <xref:System.Workflow.Activities.ConditionalEventArgs.Result%2A> property of the <xref:System.Workflow.Activities.ConditionalEventArgs> object to determine whether the **WhileActivity1** activity should continue or finish. If the property is set to **true**, the activity continues. Otherwise, the activity finishes and the workflow finishes.

    ```vb
    Private Sub isWorkflowPending(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ConditionalEventArgs)
        e.Result = workflowPending
    End Sub
    ```

    ```csharp
    private void isWorkflowPending(object sender, ConditionalEventArgs e)
    {
        e.Result = workflowPending;
    }
    ```

5. Save the project.

## Test the SharePoint workflow template
 When you start the debugger, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] deploys the workflow template to the SharePoint server and associates the workflow with the **Shared Documents** list. To test the workflow, start an instance of the workflow from a document in the **Shared Documents** list.

#### To test the SharePoint workflow template

1. In *Workflow1.cs* or *Workflow1.vb*, set a breakpoint next to the **onWorkflowActivated** method.

2. Choose the **F5** key to build and run the solution.

     The SharePoint site appears.

3. In the navigation pane in SharePoint, choose the **Shared Documents** link.

4. In the **Shared Documents** page, choose the **Documents** link on the **Library Tools** tab, and then choose the **Upload Document** button.

5. In the **Upload Document** dialog box, choose the **Browse** button, choose any document file, choose the **Open** button, and then choose the **OK** button.

     This uploads the selected document into the **Shared Documents** list and starts the workflow.

6. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], verify that the debugger stops at the breakpoint next to the `onWorkflowActivated` method.

7. Choose the **F5** key to continue execution.

8. You can change the settings for the document here, but leave them at the default values for now by choosing the **Save** button.

     This returns you to the **Shared Documents** page of the default SharePoint Web site.

9. In the **Shared Documents** page, verify that the value underneath the **MySharePointWorkflow - Workflow1** column is set to **In Progress**. This indicates that the workflow is in progress and that the document is awaiting review.

10. In the **Shared Documents** page, choose the document, choose the arrow that appears, and then choose the **Edit Properties** menu item.

11. Set **Document Status** to **Review Complete**, and then choose the **Save** button.

     This returns you to the **Shared Documents** page of the default SharePoint Web site.

12. In the **Shared Documents** page, verify that the value underneath the **Document Status** column is set to **Review Complete**. Refresh the **Shared Documents** page and verify that the value underneath the **MySharePointWorkflow - Workflow1** column is set to **Completed**. This indicates that workflow is finished and that the document has been reviewed.

## Next steps
 You can learn more about how to create workflow templates from these topics:

- To learn more about SharePoint workflow activities, see [Workflow Activities for SharePoint Foundation](/previous-versions/office/developer/sharepoint-2010/ms446847(v=office.14)).

- To learn more about Windows Workflow Foundation activities, see [System.Workflow.Activities Namespace](/dotnet/api/system.windows.media.color).

## See also
- [Create SharePoint workflow solutions](../sharepoint/creating-sharepoint-workflow-solutions.md)
- [SharePoint project and project item templates](../sharepoint/sharepoint-project-and-project-item-templates.md)
- [Build and debug SharePoint solutions](../sharepoint/building-and-debugging-sharepoint-solutions.md)
