---
title: "Create workflow with association and initiation forms"
description: In this SharePoint walkthrough, create a basic sequential workflow that incorporates the use of association and initiation forms.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, workflows"
  - "SharePoint development in Visual Studio, workflow association forms"
  - "workflows [SharePoint development in Visual Studio]"
  - "association forms [SharePoint development in Visual Studio]"
  - "initiation forms [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, workflow initiation forms"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Create a workflow with association and initiation forms
  This walkthrough demonstrates how to create a basic sequential workflow that incorporates the use of association and initiation forms. These are ASPX forms that enable parameters to be added to a workflow when it is first associated by the SharePoint administrator (the association form), and when the workflow is started by the user (the initiation form).

 This walkthrough outlines a scenario where a user wants to create an approval workflow for expense reports that has the following requirements:

- When the workflow is associated with a list, the administrator is prompted with an association form where they enter a dollar limit for expense reports.

- Employees upload their expense reports to the Shared Documents list, start the workflow, and then enter the expense total in the workflow initiation form.

- If an employee expense report total exceeds the administrator's predefined limit, a task is created for the employee's manager to approve the expense report. However, if an employee's expense report total is less than or equal to the expense limit, an auto-approved message is written to the workflow's history list.

  This walkthrough illustrates the following tasks:

- Creating a SharePoint list definition sequential workflow project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

- Creating a workflow schedule.

- Handling workflow activity events.

- Creating workflow association and initiation forms.

- Associating the workflow.

- Manually starting the workflow.

> [!NOTE]
> Although this walkthrough uses a sequential workflow project, the process is the same for state machine workflows.
>
> Also, your computer might show different names or locations for some of the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] user interface elements in the following instructions. The [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)] and SharePoint.

- Visual Studio.

## Create a SharePoint sequential workflow project
 First, create a sequential workflow project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. A sequential workflow is a series of steps that executes in order until the last activity finishes. In this procedure, you will create a sequential workflow that applies to the Shared Documents list in SharePoint. The workflow's wizard lets you associate the workflow with either the site or the list definition and lets you determine when the workflow will start.

#### To create a SharePoint sequential workflow project

1. On the menu bar, choose **File** > **New** > **Project** to display the **New Project** dialog box.

2. Expand the **SharePoint** node under either **Visual C#** or **Visual Basic**, and then choose the **2010** node.

3. In the **Templates** pane, choose the **SharePoint 2010 Project** project template.

4. In the **Name** box, enter **ExpenseReport** and then choose the **OK** button.

     The **SharePoint Customization Wizard** appears.

5. In the **Specify the site and security level for debugging** page, choose the **Deploy as a farm solution** option button, and then choose the **Finish** button to accept the trust level and default site.

     This step also sets the trust level for the solution as farm solution, which is the only available option for workflow projects.

6. In **Solution Explorer**, choose the project node.

7. On the menu bar, choose **Project** > **Add New Item**.

8. Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node, and then choose the **2010** node.

9. In the **Templates** pane, choose **Sequential Workflow (Farm Solution only)** template, and then choose the **Add** button.

     The **SharePoint Customization Wizard** appears.

10. In the **Specify the workflow name for debugging** page, accept the default name (**ExpenseReport - Workflow1**). Keep the default workflow template type value (**List Workflow)**. Choose the **Next** button.

11. In the **Would you like Visual Studio to automatically associate the workflow in a debug session?** page, clear the box that automatically associates your workflow template if it is checked.

     This step lets you manually associate the workflow with the Shared Documents list later on, which displays the association form.

12. Choose the **Finish** button.

## Add an association form to the workflow
 Next, create an .ASPX association form that appears when the SharePoint administrator first associates the workflow with an expense report document.

#### To add an association form to the workflow

1. Choose the **Workflow1** node in **Solution Explorer**.

2. On the menu bar, choose **Project** > **Add New Item** to display the **Add New Item** dialog box.

3. In the dialog box tree view, expand either **Visual C#** or **Visual Basic** (depending on your project language), expand the **SharePoint** node, and then choose the **2010** node.

4. In the list of templates, choose the **Workflow Association Form** template.

5. In the **Name** text box, enter **ExpenseReportAssocForm.aspx**.

6. Choose the **Add** button to add the form to the project.

## Designing and coding the association form
 In this procedure, you introduce functionality to the association form by adding controls and code to it.

#### To design and code the association form

1. In the association form (ExpenseReportAssocForm.aspx), locate the `asp:Content` element that has `ID="Main"`.

2. Directly after the first line in this content element, add the following code to create a label and textbox that prompts for the expense approval limit (*AutoApproveLimit*):

    ```aspx-csharp
    <asp:Label ID="lblAutoApproveLimit" Text="Auto Approval Limit:" runat="server" />

    <asp:TextBox ID="AutoApproveLimit" runat="server" />
    <br /><br />
    ```

3. Expand the **ExpenseReportAssocForm.aspx** file in **Solution Explorer** to display its dependent files.

    > [!NOTE]
    > If your project is in [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)], you must choose the **View All Files** button to perform this step.

4. Open the shortcut menu for the ExpenseReportAssocForm.aspx file and choose **View Code**.

5. Replace the `GetAssociationData` method with:

    ```vb
    Private Function GetAssociationData() As String
        ' TODO: Return a string that contains the association data that
        ' will be passed to the workflow. Typically, this is in XML
        ' format.
        Return Me.AutoApproveLimit.Text
    End Function
    ```

    ```csharp
    private string GetAssociationData()
    {
        // TODO: Return a string that contains the association data that
        // will be passed to the workflow. Typically, this is in XML
        // format.
        return this.AutoApproveLimit.Text;
    }
    ```

## Add an initiation form to the workflow
 Next, create the initiation form that appears when users run the workflow against their expense reports.

#### To create an initiation form

1. Choose the **Workflow1** node in **Solution Explorer**.

2. On the menu bar, choose **Project** > **Add New Item** display the **Add New Item** dialog box.

3. In the dialog box tree view, expand either **Visual C#** or **Visual Basic**  (depending on your project language), expand the **SharePoint** node, and then choose the **2010** node.

4. In the list of templates, choose the **Workflow Initiation Form** template.

5. In the **Name** text box, enter **ExpenseReportInitForm.aspx**.

6. Choose the **Add** button to add the form to the project.

## Designing and coding the initiation form
 Next, introduce functionality to the initiation form by adding controls and code to it.

#### To code the initiation form

1. In the initiation form (ExpenseReportInitForm.aspx), locate the `asp:Content` element that contains `ID="Main"`.

2. Directly after the first line in this content element, add the following code to create a label and textbox that displays the expense approval limit (*AutoApproveLimit*) that was entered in the association form, and another label and textbox to prompt for the expense total (*ExpenseTotal*):

    ```aspx-csharp
    <asp:Label ID="lblAutoApproveLimit" Text="Auto Approval Limit:" runat="server" />

    <asp:TextBox ID="AutoApproveLimit" ReadOnly="true" runat="server" />
    <br /><br />
    <asp:Label ID="lblExpenseTotal" Text="Expense Total:" runat="server" />

    <asp:TextBox ID="ExpenseTotal" runat="server" />
    <br /><br />
    ```

3. Expand the **ExpenseReportInitForm.aspx** file in **Solution Explorer** to display its dependent files.

4. Open the shortcut menu for the ExpenseReportInitForm.aspx file and choose **View Code**.

5. Replace the `Page_Load` method with the following example:

    ```vb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As
      EventArgs) Handles Me.Load
        InitializeParams()
        Me.AutoApproveLimit.Text = workflowList.WorkflowAssociations(New
          Guid(associationGuid)).AssociationData
        ' Optionally, add code here to pre-populate your form fields.
    End Sub
    ```

    ```csharp
    protected void Page_Load(object sender, EventArgs e)
    {
        InitializeParams();
        this.AutoApproveLimit.Text =
          workflowList.WorkflowAssociations[new
          Guid(associationGuid)].AssociationData;
    }
    ```

6. Replace the `GetInitiationData` method with the following example:

    ```vb
    ' This method is called when the user clicks the button to start the workflow.
    Private Function GetInitiationData() As String
        Return Me.ExpenseTotal.Text
        ' TODO: Return a string that contains the initiation data that
        ' will be passed to the workflow. Typically, this is in XML
        ' format.
        Return String.Empty
    End Function
    ```

    ```csharp
    // This method is called when the user clicks the button to start the workflow.
    private string GetInitiationData()
    {
        // TODO: Return a string that contains the initiation data that
        // will be passed to the workflow. Typically, this is in XML
        // format.
        return this.ExpenseTotal.Text;
    }
    ```

## Cutomize the workflow
 Next, customize the workflow. Later, you will associate two forms to the workflow.

#### To customize the workflow

1. Display the workflow in the workflow designer by opening Workflow1 in the project.

2. In the **Toolbox**, expand the **Windows Workflow v3.0** node and locate the **IfElse** activity.

3. Add this activity to the workflow by performing one of the following steps:

    - Open the shortcut menu for the **IfElse** activity, choose **Copy**, open the shortcut menu for the line under the **onWorkflowActivated1** activity in the workflow designer, and then choose **Paste**.

    - Drag the **IfElse** activity from the **Toolbox**, and connect it to the line under the **onWorkflowActiviated1** activity in the workflow designer.

4. In the Toolbox, expand the **SharePoint Workflow** node and locate the **CreateTask** activity.

5. Add this activity to the workflow by performing one of the following steps:

    - Open the shortcut menu for the **CreateTask** activity, choose **Copy**, open the shortcut menu for one of the two **Drop Activities Here** areas within **IfElseActivity1** in the workflow designer, and then choose **Paste**.

    - Drag the **CreateTask** activity from the **Toolbox** onto one of the two **Drop Activities Here** areas within **IfElseActivity1**.

6. In the **Properties** window, enter a property value of *taskToken* for the **CorrelationToken** property.

7. Expand the **CorrelationToken** property by choosing the plus sign (![TreeView plus](../sharepoint/media/plus.gif "TreeView plus")) next to it.

8. Choose the drop-down arrow on the **OwnerActivityName** sub property, and set the *Workflow1* value.

9. Choose the **TaskId** property, and then choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) button to display the **Bind Property** dialog box.

10. Choose the **Bind to a new member** tab, choose the **Create Field** option button, and then choose the **OK** button.

11. choose the **TaskProperties** property, and then choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) button to display the **Bind Property** dialog box.

12. Choose the **Bind to a new member** tab, choose the **Create Field** option button, and then choose the **OK** button.

13. In the **Toolbox**, expand the **SharePoint Workflow** node, and locate the **LogToHistoryListActivity** activity.

14. Add this activity to the workflow by performing one of the following steps:

    - Open the shortcut menu for the **LogToHistoryListActivity** activity, choose **Copy**, open the shortcut menu for the other **Drop Activities Here** area within **IfElseActivity1** in the workflow designer, and then choose **Paste**.

    - Drag the **LogToHistoryListActivity** activity from the **Toolbox**, and drop it onto the other **Drop Activities Here** area within **IfElseActivity1**.

## Add code to the workflow
 Next, add code to the workflow to give it functionality.

#### To add code to the workflow

1. Open the shortcut menu for the **createTask1** activity in the workflow designer, and then choose **View Code**.

2. Add the following method:

    ```vb
    Private Sub createTask1_MethodInvoking(ByVal sender As
      System.Object, ByVal e As System.EventArgs)
        createTask1_TaskId1 = Guid.NewGuid
        createTask1_TaskProperties1.AssignedTo = "somedomain\\someuser"
        createTask1_TaskProperties1.Description = "Please approve the
          expense report"
        createTask1_TaskProperties1.Title = "Expense Report Approval
          Needed"
    End Sub
    ```

    ```csharp
    private void createTask1_MethodInvoking(object sender, EventArgs e)
    {
        createTask1_TaskId1 = Guid.NewGuid();
        createTask1_TaskProperties1.AssignedTo = "somedomain\\someuser";
        createTask1_TaskProperties1.Description = "Please approve the
          expense report";
        createTask1_TaskProperties1.Title = "Expense Report Approval
          Needed";
    }
    ```

    > [!NOTE]
    > In the code, replace `somedomain\\someuser` with a domain and user name for which a task will be created, such as, "`Office\\JoeSch`". For testing it is easiest to use the account you are developing with.

3. Below the `MethodInvoking` method, add the following example:

    ```vb
    Private Sub checkApprovalNeeded(ByVal sender As Object, ByVal e As
      ConditionalEventArgs)
        Dim approval As Boolean = False
        If (Convert.ToInt32(workflowProperties.InitiationData) >
          Convert.ToInt32(workflowProperties.AssociationData)) Then
            approval = True
        End If
        e.Result = approval
    End Sub
    ```

    ```csharp
    private void checkApprovalNeeded(object sender, ConditionalEventArgs
      e)
    {
        bool approval = false;
        if (Convert.ToInt32(workflowProperties.InitiationData) >
          Convert.ToInt32(workflowProperties.AssociationData))
        {
            approval = true;
        }
        e.Result = approval;
    }
    ```

4. In the workflow designer, choose the **ifElseBranchActivity1** activity.

5. In the **Properties** window, choose the drop-down arrow of the **Condition** property, and then set the *Code Condition* value.

6. Expand the **Condition** property by choosing the plus sign (![TreeView plus](../sharepoint/media/plus.gif "TreeView plus")) next to it, and then set its value to *checkApprovalNeeded*.

7. In the workflow designer, open the shortcut menu for the **logToHistoryListActivity1** activity, and then choose **Generate Handlers** to generate an empty method for the `MethodInvoking` event.

8. Replace the `MethodInvoking` code with the following:

    ```vb
    Private Sub logToHistoryListActivity1_MethodInvoking(ByVal sender As
      System.Object, ByVal e As System.EventArgs)
        Me.logToHistoryListActivity1.HistoryOutcome = ("Expense was auto
          approved for " + workflowProperties.InitiationData)
    End Sub
    ```

    ```csharp
    private void logToHistoryListActivity1_MethodInvoking(object sender,
      EventArgs e)
    {
        this.logToHistoryListActivity1.HistoryOutcome = "Expense was
          auto approved for " + workflowProperties.InitiationData;
    }
    ```

9. Choose the **F5** key to debug the program.

     This compiles the application, packages it, deploys it, activates its features, recycles the [!INCLUDE[TLA2#tla_iis5](../sharepoint/includes/tla2sharptla-iis5-md.md)] application pool, and then starts the browser at the location specified in the **Site Url** property.

## Associating the workflow to the documents list
 Next, display the workflow association form by associating the workflow with the **SharedDocuments** list on the SharePoint site.

#### To associate the workflow

1. Choose the **Shared Documents** link on the QuickLaunch bar.

2. Choose the **Library** link on the **Library Tools** tab and then choose the **Library Settings** ribbon button.

3. In the **Permissions and Management** section, choose the **Workflow Settings** link and then choose the **Add a workflow** link on the **Workflows** page.

4. In the top list in the workflow settings page, choose the **ExpenseReport - Workflow1** template.

5. In the next field, enter **ExpenseReportWorkflow** and then choose the **Next** button.

     This associates the workflow with the **Shared Documents** list and displays the workflow association form.

6. In the **Auto Approval Limit** text box, enter **1200** and then choose the **Associate Workflow** button.

## Start the workflow
 Next, associate the workflow to one of the documents in the **Shared Documents** list to display the workflow initiation form.

#### To start the workflow

1. On the SharePoint page, choose the **Home** button.

2. Choose the **Shared Documents** link on the QuickLaunch bar to display the **Shared Documents** list.

3. Choose the **Documents** link on the **Library Tools** tab at the top of the page, and then choose the **Upload Document** button on the ribbon to upload a new document into the **Shared Documents** list.

4. In the **Upload Document** dialog box, choose the **Browse** button, choose any document file, choose the **Open** button, and then choose the **OK** button.

     You can change the settings for the document in this dialog box, but leave them at the default values by choosing the **Save** button.

5. Choose the uploaded document, choose the drop-down arrow that appears, and then choose the **Workflows** item.

6. Choose the image next to ExpenseReportWorkflow.

     This displays the workflow initiation form. (Note that the value displayed in the **Auto Approval Limit** box is read-only because it was entered in the association form.)

7. In the **Expense Total** text box, enter **1600**, and then choose the **Start Workflow** button.

     This displays the **Shared Documents** list again. A new column named **ExpenseReportWorkflow** with the value **Completed** is added to the item the workflow just started.

8. Choose the drop-down arrow next to the uploaded document and then choose the **Workflows** item to display the workflow status page. Choose the **Completed** value under **Completed Workflows**. The task is listed under the **Tasks** section.

9. Choose the title of the task to display its task details.

10. Go back to the **SharedDocuments** list and restart the workflow, using either the same document or a different one.

11. Enter an amount on the initiation page that is less than or equal to the amount entered on the association page (**1200**).

     When this occurs, an entry in the history list is created instead of a task. The entry displays in the **Workflow History** section of the workflow status page. Note the message in the **Outcome** column of the history event. It contains the text entered in the `logToHistoryListActivity1.MethodInvoking` event that includes the amount which was auto-approved.

## Next steps
 You can learn more about how to create workflow templates from these topics:

- To learn more about SharePoint workflows, see [Workflows in Windows SharePoint Services](/previous-versions/office/developer/sharepoint-2010/ms416312(v=office.14)).

## See also
- [Create SharePoint workflow solutions](../sharepoint/creating-sharepoint-workflow-solutions.md)
- [Walkthrough: Add an application page to a workflow](../sharepoint/walkthrough-add-an-application-page-to-a-workflow.md)
