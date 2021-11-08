---
title: "Walkthrough: Import a SharePoint Designer reusable workflow | Microsoft Docs"
titleSuffix: ""
description: In this walkthrough, import a reusable workflow created in SharePoint Designer into a Visual Studio SharePoint workflow project.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VS.SharePointTools.WSPImport.ImportWF"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, importing reusable workflows"
  - "reusable workflows [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Import a SharePoint Designer reusable workflow

  This walkthrough demonstrates how to import a reusable workflow created in SharePoint Designer 2010 into a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint workflow project.

 Workflows created in SharePoint Designer, or *declarative workflows*, consist of [!INCLUDE[TLA2#tla_xml](../sharepoint/includes/tla2sharptla-xml-md.md)] statements instead of code. SharePoint Designer 2010 introduces *reusable workflows*, which are portable, declarative workflows that can be used by different lists in SharePoint sites.

 Workflows created in [!INCLUDE[vs_dev11_long](../sharepoint/includes/vs-dev11-long-md.md)], such as sequential and state machine workflows, are called *code workflows*. Code workflows consist of XML files and code modules in which users can customize the workflow's behavior.

 Visual Studio allows you to import reusable workflows created in SharePoint Designer 2010 and convert them to code workflows for use in your SharePoint sites.

 This walkthrough demonstrates the following tasks:

- Creating a simple, reusable workflow in SharePoint Designer.

- Exporting the SharePoint Designer reusable workflow to a *.wsp* file and into SharePoint.

- Importing the *.wsp* file into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] by using the Import Reusable Workflow project.

- Altering the workflow by adding code.

- Using the imported workflow in a SharePoint site.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)] and SharePoint.

- Visual Studio.

- Microsoft [!INCLUDE[TLA2#tla_office](../sharepoint/includes/tla2sharptla-office-md.md)] SharePoint Designer 2010.

## Create target SharePoint subsites
 First you create two new SharePoint subsites: one to host the reusable workflows from SharePoint Designer, another to host the converted workflows.

#### To create SharePoint subsites

1. In SharePoint Designer 2010, on the menu bar, choose **File** > **New Blank Web Site**.

2. In the **New Blank Web Site** dialog box, browse to a SharePoint site where you want to create the workflow, or use the value of http://<em>SystemName</em>/ and then choose the **OK** button.

    The Home page appears.

3. In the **Subsites** section, choose the **New** button.

4. In the **New** dialog box, choose **SharePoint Templates** from the list in the left pane, and choose **Team Site** from the list in the right pane.

5. In the **Specify the location of the Web site** box, replace the word **subsite** in the URL with **SPD1**, and then choose the **OK** button.

    This opens the new subsite into SharePoint Designer. Close this instance of SharePoint Designer and go back to the first instance (the top-level site).

6. Repeat steps 3 - 5 to create the second subsite, this time replacing the word **subsite** in the [!INCLUDE[TLA2#tla_url](../sharepoint/includes/tla2sharptla-url-md.md)] with **SPD2**.

## Create a SharePoint Designer reusable workflow
 Because SharePoint does not include any reusable workflows that you can use for this example, you will create one. In this simple workflow, when a user enters a new task in the Task list that has a specific title, the task is assigned to that user.

#### To create a SharePoint Designer reusable workflow

1. In the **Subsites** section, choose the **SPD1** site to modify it.

2. On the ribbon, choose the **Reusable Workflow** button.

     The Create Reusable Workflow wizard appears.

3. In the **Name** box, enter **SPD Task Workflow**.

4. In the **Content Type** list, choose **Task**, and then choose the **OK** button.

     The workflow opens in the SharePoint Designer workflow designer.

5. In the workflow designer, choose Step 1, and then, on the ribbon, choose the **Condition** button.

6. In the list of conditions, choose **If current item field equals value**.

     This step adds a condition that's named **If field equals value**.

7. In the **If field equals value** condition, choose the **field** link.

8. In the list of values, choose **Title**.

9. In the **If field equals value** condition, choose the **value** link.

10. In the box, enter **New task**.

     The condition statement now reads **If Current Item:Title equals New task**.

11. Choose the line under the condition statement, and then, on the ribbon, choose the **Action** button.

12. In the list of actions, choose **Set field in current item**.

13. In the **Set field to value** action, choose the **field** link, and then, in the list, choose **Assigned to**.

14. In the **Set field to value** action, choose the **value** link, and then, in the list of existing users and groups, choose **User who created the item**.

15. Choose the **Add** button, and then choose the **OK** button.

     The action statement now reads **Set Assigned To to Current Item:CreatedBy**.

## Save and deploy the reusable workflow
 Because [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] can import only *.wsp* files, you must save the reusable workflow as a *.wsp* file and deploy it to SharePoint before importing it into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

> [!IMPORTANT]
> If you receive a runtime error performing the following procedure, you have to perform the procedure on a system that has access to the SharePoint site.

#### To save and deploy the reusable workflow

1. At the top of SharePoint Designer, choose the **Save** button to save your progress, and then choose the **Publish** button to deploy the workflow to the **SPD1** SharePoint site.

2. In the Navigation pane, choose the **Workflows** object.

3. Under **Reusable Workflow**, choose **SPD Task Workflow**.

4. On the ribbon, choose the **Save as Template** button to save the workflow as a *.wsp* file.

5. Open the **SPD1** SharePoint site in a browser to view the *.wsp* file in SharePoint.

6. On the QuickLaunch bar, choose the **Libraries** link.

7. In the **Document Libraries** section, choose the **Site Assets** link.

     The **SPD Task Workflow** file is listed with other site assets.

8. In the list of files, choose the name of that file

9. In the **File Download** dialog box, choose the **Save** button to save the *.wsp* file on your local system.

## Import the .wsp file into Visual Studio
 Import the *.wsp* file into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] by using an Import Reusable Workflow project. This project converts the workflow from a reusable, declarative workflow into a code workflow. After the workflow is converted, you will use code to modify its behavior.

#### To import a workflow from a .wsp file and modify it

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], on the menu bar, choose **File** > **New** > **Project**.

2. In the **New Project** dialog box, expand the **SharePoint** node under either **Visual C#** or **Visual Basic**, and then choose the **2010** node.

3. In the **Templates** pane, choose the **Import Reusable SharePoint 2010 Workflow** template, leave the name of the project as **WorkflowImportProject1**, and then choose the **OK** button.

    The SharePoint Customization Wizard appears.

4. On the **Specify the site and security level for debugging** page, enter the [!INCLUDE[TLA2#tla_url](../sharepoint/includes/tla2sharptla-url-md.md)] for the second SharePoint subsite that you created previously: http://<em>system name</em>/SPD2.

5. In the **What is the trust level for this SharePoint solution?** section, choose the **Deploy as a farm solution** option button, and then choose the **Next** button.

    For more information about sandboxed versus farm solutions, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

6. In the **Specify the new project source** page, browse to the location on the system where you previously saved the *.wsp* file, open the file, and then choose the **Next** button.

   > [!NOTE]
   > Choose the **Finish** button to import all available items in the *.wsp* file.

    This displays a list of reusable workflows available for importing.

7. In the **Select items to import** box, choose the **SPD Task Workflow** workflow, and then choose the **Finish** button.

    After the import operation is finished, a project named **WorkflowImportProject1** is created containing a workflow named **SPD_Workflow_TestFT**. In this folder is the workflow's definition file *Elements.xml* and the workflow designer file (*.xoml*). The designer contains two files: the rules file (.rules) and the code-behind file (either *.cs* or *.vb*, depending on your project's programming language).

8. In **Solution Explorer**, delete the **Other Imported Files** folder.

9. In the *Elements.xml* file, delete `InstantiationURL="_layouts/IniErkflIP.sspx"`.

10. In **Solution Explorer**, choose **WorkflowImportProject1**, and then, on the menu bar, choose **Project** > **Set as Startup Project** to set **WorkflowImportProject1** as the Startup Item.

     This displays the list immediately when you debug the project.

11. Because the **Import Reusable SharePoint 2010 Workflow** template doesn't import the association property values for the imported workflow, you must enter them. To do this:

    1. In **Solution Explorer**, choose the **SPD_Workflow_TestFT** node.

    2. Choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) button next to one of the list properties, such as the **Target List** property.

    3. Fill in the missing values in the SharePoint Customization Wizard, and then choose the **Finish** button.

12. Choose the .xoml file, and then, on the menu bar, choose **View** > **Designer** to view the imported workflow in the workflow designer.

13. In the **Windows Workflow v3.0** node of the **Toolbox**, perform one of the following steps:

    - Open the shortcut menu for the **Code** activity, and then choose **Copy**. In the workflow designer, open the shortcut menu for the line under the **SequenceActivity1** activity, and then choose **Paste**.

    - Drag the **Code** activity from the **Toolbox** to the workflow designer, and connect it to the line under the **SequenceActivity1** activity.

      This adds an activity to the workflow designer named **CodeActivity1**. In this activity, you will add a code action that creates an announcement in the Announcements list when the user starts the workflow.

14. Perform one of the following sets of steps:

    - Double-click **CodeActivity1** to generate an event handler and view the code.

    - In the **Properties** window for **CodeActivity1**, set the value of the **ExecuteCode** property to **codeActivity_ExecuteCode**.

15. Add the following under the existing **using** or **Imports** directives:

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/workflowimportproject1/workflows/spd_task_workflowft/spd task workflow.xoml.cs" id="Snippet1":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/workflowimportproject1/workflows/spd_task_workflowft/spd task workflow.xoml.vb" id="Snippet1":::

16. Replace `codeActivity1_ExecuteCode` with the following:

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/workflowimportproject1/workflows/spd_task_workflowft/spd task workflow.xoml.cs" id="Snippet2":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/workflowimportproject1/workflows/spd_task_workflowft/spd task workflow.xoml.vb" id="Snippet2":::

## Deploy the project and associate the workflow
 Next, run WorkflowImportProject1 to deploy it to a SharePoint site and then associate the workflow with the Tasks list to view and test the modified, converted workflow.

#### To deploy the project and associate the workflow

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], choose the **F5** key to run and deploy the converted workflow project.

2. On the QuickLaunch bar, choose the **Tasks** link to display the Tasks list.

3. On the **List Tools** tab, choose the **Items** button, and then choose the **New Item** button.

     The **Tasks - New Item** dialog box opens.

4. In the **Title** box, enter **New task**, and then choose the **Save** button.

5. On the **List Tools** tab, choose the **List** button, and then choose the **List Settings** button.

     The **List Settings** page appears.

6. In the **Permissions and Management** section, choose the **Workflow Settings** link.

     The **Workflow Settings** page appears.

7. Choose the **Add a Workflow** link.

8. In the **Workflow** list, choose **WorkflowImportProject1 - SPD Workflow Test**.

9. In the **Name** box, enter **SPD Workflow Test**, and then choose the **OK** button.

10. In the QuickLaunch bar, choose the **Tasks** list.

11. Choose the arrow next to **New task**, and then, in the list, choose **Workflows**.

12. In the **Start a New Workflow** section, choose the link for **SPD Workflow Test**, and then choose the **Start** button to initiate the workflow.

    > [!NOTE]
    > Alternatively, you can auto-associate a workflow with a list by running the workflow settings wizard and setting the workflow to auto-associate.

     Notice that two actions are performed by the workflow: your name appears in the task's **Assigned To** column, and an announcement appears in the **Announcements** list.

## See also
- [Import items from an existing SharePoint site](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
- [Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)
