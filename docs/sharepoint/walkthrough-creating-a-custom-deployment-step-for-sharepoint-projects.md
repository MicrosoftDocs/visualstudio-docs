---
title: "Create custom deployment step for SharePoint projects"
description: In this walkthrough, create a custom deployment step to upgrade SharePoint project solutions on a server that's running SharePoint.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint commands"
  - "SharePoint development in Visual Studio, extending deployment"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Create a custom deployment step for SharePoint projects
  When you deploy a SharePoint project, Visual Studio executes a series of deployment steps in a specific order. Visual Studio includes many built-in deployment steps, but you can also create your own.

 In this walkthrough, you will create a custom deployment step to upgrade solutions on a server that's running SharePoint. Visual Studio includes built-in deployment steps for many tasks, such retracting or adding solutions, but it doesn't include a deployment step for upgrading solutions. By default, when you deploy a SharePoint solution, Visual Studio first retracts the solution (if it's already deployed) and then redeploys the entire solution. For more information about the built-in deployment steps, see [Deploy, publish, and upgrade SharePoint solution packages](../sharepoint/deploying-publishing-and-upgrading-sharepoint-solution-packages.md).

 This walkthrough demonstrates the following tasks:

- Creating a Visual Studio extension that performs two main tasks:

  - The extension defines a custom deployment step to upgrade SharePoint solutions.

  - The extension creates a project extension that defines a new deployment configuration, which is a set of deployment steps that are executed for a given project. The new deployment configuration includes the custom deployment step and several built-in deployment steps.

- Create two custom SharePoint commands that the extension assembly calls. SharePoint commands are methods that can be called by extension assemblies to use APIs in the server object model for SharePoint. For more information, see [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md).

- Building a Visual Studio Extension (VSIX) package to deploy both of the assemblies.

- Testing the new deployment step.

## Prerequisites
 You need the following components on the development computer to complete this walkthrough:

- Supported editions of Windows, SharePoint, and Visual Studio.

- The Visual Studio SDK. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the extension. For more information, see [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

  Knowledge of the following concepts is helpful, but not required, to complete the walkthrough:

- Using the server object model for SharePoint. For more information, see [Using the SharePoint Foundation Server-Side Object Model](/previous-versions/office/developer/sharepoint-2010/ee538251(v=office.14)).

- SharePoint solutions. For more information, see [Solutions Overview](/previous-versions/office/developer/sharepoint-2010/aa543214(v=office.14)).

- Upgrading SharePoint solutions. For more information, see [Upgrading a Solution](/previous-versions/office/developer/sharepoint-2010/aa543659(v=office.14)).

## Create the projects
 To complete this walkthrough, you must create three projects:

- A VSIX project to create the VSIX package to deploy the extension.

- A class library project that implements the extension. This project must target the .NET Framework 4.5.

- A class library project that defines the custom SharePoint commands. This project must target the .NET Framework 3.5.

  Start the walkthrough by creating the projects.

#### To create the VSIX project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Extensibility** node.

    > [!NOTE]
    > The **Extensibility** node is available only if you install the Visual Studio SDK. For more information, see the prerequisites section earlier in this topic.

4. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework.

5. Choose the **VSIX Project** template, name the project **UpgradeDeploymentStep**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **UpgradeDeploymentStep** project to **Solution Explorer**.

#### To create the extension project

1. In **Solution Explorer**, open the shortcut menu for the UpgradeDeploymentStep solution node, choose **Add**, and then choose **New Project**.

2. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Windows** node.

3. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework.

4. Choose the **Class Library** project template, name the project **DeploymentStepExtension**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **DeploymentStepExtension** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

#### To create the SharePoint command project

1. In **Solution Explorer**, open the shortcut menu for the UpgradeDeploymentStep solution node, choose **Add**, and then choose **New Project**.

2. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic**, and then choose the **Windows** node.

3. At the top of the dialog box, choose **.NET Framework 3.5** in the list of versions of the .NET Framework.

4. Choose the **Class Library** project template, name the project **SharePointCommands**, and then choose the **OK** button.

     Visual Studio adds the **SharePointCommands** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

## Configure the projects
 Before you write code to create the custom deployment step, you must add code files and assembly references, and you must configure the projects.

#### To configure the DeploymentStepExtension project

1. In the **DeploymentStepExtension** project, add two code files that have the following names:

    - UpgradeStep

    - DeploymentConfigurationExtension

2. Open the shortcut menu on the DeploymentStepExtension project, and then choose **Add Reference**.

3. On the **Framework** tab, select the check box for the System.ComponentModel.Composition assembly.

4. On the **Extensions** tab, select the check box for the Microsoft.VisualStudio.SharePoint assembly, and then choose the **OK** button.

#### To configure the SharePointCommands project

1. In the **SharePointCommands** project, add a code file that's named Commands.

2. In **Solution Explorer**, open the shortcut menu on the **SharePointCommands** project node, and then choose **Add Reference**.

3. On the **Extensions** tab, select the check boxes for the following assemblies, and then click choose the **OK** button

    - Microsoft.SharePoint

    - Microsoft.VisualStudio.SharePoint.Commands

## Define the custom deployment step
 Create a class that defines the upgrade deployment step. To define the deployment step, the class implements the <xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentStep> interface. Implement this interface whenever you want to define a custom deployment step.

#### To define the custom deployment step

1. In the **DeploymentStepExtension** project, open the UpgradeStep code file, and then paste the following code into it.

    > [!NOTE]
    > After you add this code, the project will have some compile errors, but they'll go away when you add code in later steps.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/UpgradeDeploymentStep/deploymentstepextension/upgradestep.cs" id="Snippet1":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/upgradedeploymentstep/deploymentstepextension/upgradestep.vb" id="Snippet1":::

## Create a deployment configuration that includes the custom deployment step
 Create a project extension for the new deployment configuration, which includes several built-in deployment steps and the new upgrade deployment step. By creating this extension, you help SharePoint developers to use the upgrade deployment step in SharePoint projects.

 To create the deployment configuration, the class implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface. Implement this interface whenever you want to create a SharePoint project extension.

#### To create the deployment configuration

1. In the **DeploymentStepExtension** project, open the DeploymentConfigurationExtension code file, and then paste the following code into it.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/UpgradeDeploymentStep/deploymentstepextension/deploymentconfigurationextension.cs" id="Snippet2":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/upgradedeploymentstep/deploymentstepextension/deploymentconfigurationextension.vb" id="Snippet2":::

## Create the custom SharePoint commands
 Create two custom commands that call into the server object model for SharePoint. One command determines whether a solution is already deployed; the other command upgrades a solution.

#### To define the SharePoint commands

1. In the **SharePointCommands** project, open the Commands code file, and then paste the following code into it.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/UpgradeDeploymentStep/SharePointCommands/Commands.cs" id="Snippet4":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/upgradedeploymentstep/sharepointcommands/commands.vb" id="Snippet4":::

## Checkpoint
 At this point in the walkthrough, all the code for the custom deployment step and the SharePoint commands are now in the projects. Build them to make sure that they compile without errors.

#### To build the projects

1. In **Solution Explorer**, open the shortcut menu for the **DeploymentStepExtension** project, and then choose **Build**.

2. Open the shortcut menu for the **SharePointCommands** project, and then choose **Build**.

## Create a VSIX package to deploy the extension
 To deploy the extension, use the VSIX project in your solution to create a VSIX package. First, configure the VSIX package by modifying the source.extension.vsixmanifest file in the VSIX project. Then create the VSIX package by building the solution.

#### To configure and create the VSIX package

1. In **Solution Explorer**, under the **UpgradeDeploymentStep** project, open the shortcut menu for the **source.extension.vsixmanifest** file, and then choose **Open**.

     Visual Studio opens the file in the manifest editor. The source.extension.vsixmanifest file is the basis for the extension.vsixmanifest file that all VSIX packages require. For more information about this file, see [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110)).

2. In the **Product Name** box, enter **Upgrade Deployment Step for SharePoint Projects**.

3. In the **Author** box, enter **Contoso**.

4. In the **Description** box, enter **Provides a custom upgrade deployment step that can be used in SharePoint projects**.

5. In the **Assets** tab of the editor, choose the **New** button.

     The **Add New Asset** dialog box appears.

6. In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

    > [!NOTE]
    > This value corresponds to the `MefComponent` element in the extension.vsixmanifest file. This element specifies the name of an extension assembly in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393736\(v\=vs.100\)).

7. In the **Source** list, choose **A project in current solution**.

8. In the **Project** list, choose **DeploymentStepExtension**, and then choose the **OK** button.

9. In the manifest editor, choose the **New** button again.

     The **Add New Asset** dialog box appears.

10. In the **Type** list, enter **SharePoint.Commands.v4**.

    > [!NOTE]
    > This element specifies a custom extension that you want to include in the Visual Studio extension. For more information, see [Asset Element (VSX Schema)](/previous-versions/dd393737(v=vs.110)).

11. In the **Source** list, choose **A project in current solution**.

12. In the **Project** list, choose **SharePointCommands**, and then choose the **OK** button.

13. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the solution compiles without errors.

14. Make sure that the build output folder for the UpgradeDeploymentStep project now contains the UpgradeDeploymentStep.vsix file.

     By default, the build output folder is the ..\bin\Debug folder under the folder that contains your project file.

## Prepare to test the upgrade deployment step
 To test the upgrade deployment step, you must first deploy a sample solution to the SharePoint site. Start by debugging the extension in the experimental instance of Visual Studio. Then create a list definition and list instance to use to test the deployment step, and then deploy them to the SharePoint site. Next, modify the list definition and list instance and redeploy them to demonstrate how the default deployment process overwrites solutions on the SharePoint site.

 Later in this walkthrough, you'll modify the list definition and list instance, and then you'll upgrade them on the SharePoint site.

#### To start debugging the extension

1. Restart Visual Studio with administrative credentials, and then open the UpgradeDeploymentStep solution.

2. In the DeploymentStepExtension project, open the UpgradeStep code file, and then add a breakpoint to the first line of code in the `CanExecute` and `Execute` methods.

3. Start debugging by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Start Debugging**.

4. Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\11.0Exp\Extensions\Contoso\Upgrade Deployment Step for SharePoint Projects\1.0 and starts an experimental instance of Visual Studio. You'll test the upgrade deployment step in this instance of Visual Studio.

#### To create a SharePoint project with a list definition and a list instance

1. In the experimental instance of Visual Studio, on the menu bar, choose **File** > **New** > **Project**.

2. In the **New Project** dialog box, expand the **Visual C#** node or the **Visual Basic** node, expand the **SharePoint** node, and then choose the **2010** node.

3. At the top of the dialog box, make sure that **.NET Framework 3.5** appears in the list of versions of the .NET Framework.

    Projects for [!INCLUDE[wss_14_long](../sharepoint/includes/wss-14-long-md.md)] and [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] require this version of the .NET Framework.

4. In the list of project templates, choose **SharePoint 2010 Project**, name the project **EmployeesListDefinition**, and then choose the **OK** button.

5. In the **SharePoint Customization Wizard**, enter the URL of the site that you want to use for debugging.

6. Under **What is the trust level for this SharePoint solution**, choose the **Deploy as a farm solution** option button.

   > [!NOTE]
   > The upgrade deployment step doesn't support sandboxed solutions.

7. Choose the **Finish** button.

    [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] creates the EmployeesListDefinition project.

8. Open the shortcut menu for the EmployeesListDefinition project, choose **Add**, and then choose **New Item**.

9. In the **Add New Item - EmployeesListDefinition** dialog box, expand the **SharePoint** node, and then choose the **2010** node.

10. Choose the **List** item template, name the item **Employees List**, and then choose the **Add** button.

     The SharePoint Customization Wizard appears

11. On the **Choose List Settings** page, verify the following settings, and then choose the **Finish** button:

    1. **Employees List** appears in the **What name do you want to display for your list?** box.

    2. The **Create a customizable list based on:** option button is chosen.

    3. **Default (Blank)** is chosen in the **Create a customizable list based on:** list.

       [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] creates the Employees List item with a Title column and a single empty instance and opens the List Designer.

12. In the List Designer, on the **Columns** tab, choose the **Type a new or existing column name** row, and then add the following columns in the **Column Display Name** list:

    1. First Name

    2. Company

    3. Business Phone

    4. E-Mail

13. Save all files, and then close the List Designer.

14. In **Solution Explorer**, expand the **Employees List** node, and then expand the **Employees List Instance** child node.

15. In the *Elements.xml* file, replace the default XML in this file with the following XML. This XML changes the name of the list to **Employees** and adds information for an employee who's named Jim Hance.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <Elements xmlns="http://schemas.microsoft.com/sharepoint/">
      <ListInstance Title="Employees"
                    OnQuickLaunch="TRUE"
                    TemplateType="10000"
                    Url="Lists/Employees"
                    Description="Simple list to test upgrade deployment step">
        <Data>
          <Rows>
            <Row>
              <Field Name="Title">Hance</Field>
              <Field Name="FirstName">Jim</Field>
              <Field Name="Company">Contoso</Field>
              <Field Name="Business Phone">555-555-5555</Field>
              <Field Name="E-Mail">jim@contoso.com</Field>
            </Row>
          </Rows>
        </Data>
      </ListInstance>
    </Elements>
    ```

16. Save and close the *Elements.xml* file.

17. Open the shortcut menu for the EmployeesListDefinition project, and then choose **Open** or **Properties**.

     The Properties Designer opens.

18. On the **SharePoint** tab, clear the **Auto-retract after debugging** check box, and then save the properties.

#### To deploy the list definition and list instance

1. In **Solution Explorer**, choose the **EmployeesListDefinition** project node.

2. In the **Properties** window, make sure that the **Active Deployment Configuration** property is set to **Default**.

3. Choose the **F5** key or, on the menu bar, choose **Debug** > **Start Debugging**.

4. Verify that the project builds successfully, that the web browser opens to the SharePoint site, that the **Lists** item in the Quick Launch bar includes the new **Employees** list, and that the **Employees** list includes the entry for Jim Hance.

5. Close the web browser.

#### To modify the list definition and list instance and redeploy them

1. In the EmployeesListDefinition project, open the *Elements.xml* file that's a child of the **Employee List Instance** project item.

2. Remove the `Data` element and its children to remove the entry for Jim Hance from the list.

     When you finish, the file should contain the following XML.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <Elements xmlns="http://schemas.microsoft.com/sharepoint/">
      <ListInstance Title="Employees"
                    OnQuickLaunch="TRUE"
                    TemplateType="10000"
                    Url="Lists/Employees"
                    Description="Simple list to test upgrade deployment step">
      </ListInstance>
    </Elements>
    ```

3. Save and close the *Elements.xml* file.

4. Open the shortcut menu for the **Employees List** project item, and then choose **Open** or **Properties**.

5. In the List Designer, choose the **Views** tab.

6. In the **Selected columns** list, choose **Attachments**, and then choose the < key to move that column to the **Available columns** list.

7. Repeat the previous step to move the **Business Phone** column from the **Selected columns** list to the **Available columns** list.

     This action removes these fields from the default view of the **Employees** list on the SharePoint site.

8. Start debugging by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Start Debugging**.

9. Verify that the **Deployment Conflicts** dialog box appears.

     This dialog box appears when Visual Studio tries to deploy a solution (the list instance) to a SharePoint site to which that solution has already been deployed. This dialog box won't appear when you execute the upgrade deployment step later in this walkthrough.

10. In the **Deployment Conflicts** dialog box, choose the **Resolve Automatically** option button.

     Visual Studio deletes the list instance on the SharePoint site, deploys the list item in the project, and then opens the SharePoint site.

11. In the **Lists** section of the Quick Launch bar, choose the **Employees** list, and then verify the following details:

    - The **Attachments** and **Home Phone** columns don't appear in this view of the list.

    - The list is empty. When you used the **Default** deployment configuration to redeploy the solution, the **Employees** list was replaced with the new empty list in your project.

## Test the deployment step
 You are now ready to test the upgrade deployment step. First, add an item to the list instance in SharePoint. Then change the list definition and list instance, upgrade them on the SharePoint site, and confirm that the upgrade deployment step doesn't overwrite the new item.

#### To manually add an item to the list

1. In the ribbon on the SharePoint site, under the **List Tools** tab, choose the **Items** tab.

2. In the **New** group, choose **New Item**.

     As an alternative, you can choose the **Add new item** link in the item list itself.

3. In the **Employees - New Item** window, in the **Title** box, enter **Facilities Manager**.

4. In the **First Name** box, enter **Andy**.

5. In the **Company** box, type **Contoso**.

6. Choose the **Save** button, verify that the new item appears in the list, and then close the web browser.

     Later in this walkthrough, you will use this item to verify that the upgrade deployment step doesn't overwrite the contents of this list.

#### To test the upgrade deployment step

1. In the experimental instance of Visual Studio, in **Solution Explorer**, open the shortcut menu for the **EmployeesListDefinition** project node, and then choose **Properties**.

    The Properties Editor/Designer opens.

2. On the **SharePoint** tab, set the **Active Deployment Configuration** property to **Upgrade**.

    This custom deployment configuration includes the new upgrade deployment step.

3. Open the shortcut menu for the **Employees List** project item, and then choose **Properties** or **Open**.

    The Properties Editor/Designer opens.

4. On the **Views** tab, choose the **E-Mail** column, and then choose the **<** key to move that column from the **Selected columns** list to the **Available columns** list.

    This action removes these fields from the default view of the **Employees** list on the SharePoint site.

5. Start debugging by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Start Debugging**.

6. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `CanExecute` method.

7. Choose the **F5** key again or, on the menu bar, choose **Debug** > **Continue**.

8. Verify that the code stops on the breakpoint that you set earlier in the `Execute` method.

9. Choose the **F5** key or, on the menu bar, choose **Debug** > **Continue** a final time.

     The web browser opens the SharePoint site.

10. In the **Lists** section of the Quick Launch area, choose the **Employees** list, and then verify the following details:

    - The item that you manually added earlier (for Andy, the facilities manager) is still in the list.

    - The **Business Phone** and **E-mail Address** columns don't appear in this view of the list.

      The **Upgrade** deployment configuration modifies the existing **Employees** list instance on the SharePoint site. If you used the **Default** deployment configuration instead of the **Upgrade** configuration, you would encounter a deployment conflict. Visual Studio would resolve the conflict by replacing the **Employees** list, and the item for Andy, the facilities manager, would be deleted.

## Clean up the development computer
 After you finish testing the upgrade deployment step, remove the list instance and list definition from the SharePoint site, and remove the deployment step extension from Visual Studio.

#### To remove the list instance from the SharePoint site

1. Open the **Employees** list on the SharePoint site, if the list isn't already open.

2. In the ribbon on the SharePoint site, choose the **List Tools** tab, and then choose the **List** tab.

3. In the **Settings** group, choose the **List Settings** item.

4. Under **Permissions and Management**, choose the **Delete this list** command, choose **OK** to confirm that you want to send the list to the Recycle Bin, and then close the web browser.

#### To remove the list definition from the SharePoint site

1. In the experimental instance of Visual Studio, on the menu bar, choose **Build** > **Retract**.

     Visual Studio retracts the list definition from the SharePoint site.

#### To uninstall the extension

1. In the experimental instance of Visual Studio, on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose **Upgrade Deployment Step for SharePoint Projects**, and then choose the **Uninstall** command.

3. In the dialog box that appears, choose **Yes** to confirm that you want to uninstall the extension, and then choose **Restart Now** to complete the uninstallation.

4. Close both instances of Visual Studio (the experimental instance and the instance of Visual Studio in which the UpgradeDeploymentStep solution is open).

## See also
- [Extend SharePoint packaging and deployment](../sharepoint/extending-sharepoint-packaging-and-deployment.md)