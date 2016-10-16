---
title: "Customizing lab management workflow"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1c15910f-8952-4313-bb9d-87daaab3f67a
caps.latest.revision: 30
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Customizing lab management workflow
You can use the lab default template (LabDefaultTemplate) with lab environments to automate building your application, deploying the new build to a lab environment, and running tests on the new build. For information about how to use the lab default template, see [Create a build-deploy-test workflow for an SCVMM environment](../test/create-a-build-deploy-test-workflow-for-an-scvmm-environment.md) and [Create a build-deploy-test workflow for a standard environment](../test/create-a-build-deploy-test-workflow-for-a-standard-environment.md). However, each build, deploy, and test process might be slightly different because of different requirements. For example, one workflow might require copying the test binaries from the regular build location whereas another workflow requires copying the test binaries from a temporary location. Or one workflow might require that a lab environment is saved in an SCVMM library so testers can deploy it, whereas another workflow does not save the lab environment at all. Because the lab default template is based on Windows Workflow 4.0, it is fully extensible and customizable, so you can customize LabDefaultTemplate to meet your specific requirements. This topic describes the general steps for customizing the lab default template.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 Here are some scenarios where customization of the lab default template is useful:  
  
-   [Customization to specify test binaries location other than build drop location](#SpecifyBinaries)  
  
-   [Customization to support application installers requiring a machine restart after deployment](#DeployRestart)  
  
-   [Customization to read source control files](#ReadSource)  
  
-   [Customization to access a build drop location using the build agent account](#BuildAgentDrop)  
  
-   [Customization to access other locations using the lab service account](#LabServiceAccess)  
  
## The Basic Concepts of Workflow Customization  
 There are three key concepts involved in workflow customization:  
  
-   **Template** The template defines the sequence of activities or steps that are a part of the workflow. The template is based on Windows Workflow Foundation 4.0 and is stored as a .xaml file in Source Control. To load the template into the Workflow Editor, double-click the .xaml file. In the Editor, you will be able to see the various activities and sequences that determine the workflow. You can then use variables with different scopes, conditional logic, loops, and so on to program the template, just as you would with any other programming language. Windows Workflow Foundation enables you to customize the lab default template to suit your needs.  
  
-   **Activities** The activity is the building block of a workflow, and the lab default template uses many activities. You can find additional activities in the **Toolbox** under the heading **Team Foundation Lab Management Activities**. To use an activity in the workflow, drag it from the toolbox into the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Workflow Editor to appropriate location in the template. You can determine the input and output parameters by looking at the properties of the activity. For more information about each Lab Management activity, see [Lab management workflow activities](../test/lab-management-workflow-activities.md). If the activities that are included with the product are insufficient to meet your requirements, you can add new activities.  
  
-   **Arguments** You can create new input arguments for the inputs you need from the user, and pass these values to activities. Choose the **Arguments** tab at the bottom of the Workflow Editor window to see the existing arguments. If you create new arguments, they will appear in the **Build Process Parameters** section of the **Process** tab in the build definition.  
  
 Think about these concepts as you review the following two examples where customization is needed. The first example talks about how to change the in-argument of an existing activity in the template, and the second example talks about how to add new activities from the toolbox. These examples should give you enough context to customize the lab default template according to your requirements.  
  
## Before Starting Customization  
 There are some general steps that you must complete before you start to customize the lab default template. The following diagram illustrates these steps.  
  
 ![Folder location for default workflow templates](../test/media/defaulttemplates.png "DefaultTemplates")  
  
#### To prepare for customization  
  
1.  In [!INCLUDE[esprtfc](../codequality/includes/esprtfc_md.md)], double-click the **Source Control** node for your team project.  
  
2.  In **Source Control Explorer**, expand the Source Control tree and find the **$/<Project_Name>/BuildProcessTemplates** folder.  
  
3.  Map this folder to a local folder, for example, C:\Sources.  
  
4.  Right-click the file LabDefaultTemplate.11.xaml and then choose **Get Latest Version**.  
  
5.  Make a copy of the file LabDefaultTemplate.11.xaml and give it a new name, for example, LabDefaultTemplate_customize.11.xaml  
  
6.  Add this new file to Source Control.  
  
7.  Double-click this new file. The file will open in the **Visual Studio Workflow Editor**.  
  
 Next you will customize the copy you just made of the lab default template.  
  
##  <a name="SpecifyBinaries"></a> Customization to specify test binaries location other than build drop location  
 The default workflow template, LabDefaultTemplate, assumes that the location of the test binaries is the same as the location where builds are dropped. However, in your situation, the test code might not get built alongside the product code. If this occurs, you might want to customize the template so that test binaries are picked up from a different location. This customization involves three steps as shown in the following illustration.  
  
 ![Dragging a LabManagement activity from the toolbox](../test/media/toolboxeditorproperties.png "ToolboxEditorProperties")  
  
### Defining a Workflow In-argument to Specify the Test Binaries Path  
  
##### To define an in-argument  
  
1.  At the bottom of the workflow editor window, click the **Arguments** tab.  
  
2.  Choose **Create Argument**. In the text box, type the name of the argument, for example, `TestBinariesLocation`. In the **Direction** drop-down list, choose **In**. In the **Argument type** drop-down list, choose **String**.  
  
### Passing an Argument Value to the ExecuteRemoteTestRun Activity  
 This activity creates a remote test run, waits until the test run finishes, and then updates the build information with test run statistics.  
  
##### To pass the argument value  
  
1.  In the workflow editor, scroll to the activity **Running Tests**. Although the display name of the activity is Running Tests, the activity Type is **ExecuteRemoteTestRun**.  
  
2.  Right-click the activity and then choose **Properties**. The **Properties** window opens in the lower-right corner and displays the in- and out- arguments of this activity. One of the in-argument of this activity is **TestDirectory**, which sets the path of the test binaries location.  
  
3.  In the **Properties** window, click **TestDirectory**. At the end of the row click the ellipses (…).  
  
4.  In the **Expression Editor**, type **TestBinariesLocation** and then choose **OK**.  
  
5.  On the **File** menu, choose **Save LabDefaultTemplate_customize.11.xaml**  
  
6.  On the Source Control Explorer menu bar, choose the **Check-in** icon.  
  
 You can now use the customized .xaml file to create new build definitions. The new in-argument **TestBinariesLocation** will appear in the **Misc** section of the **Process** tab in your build definition, and you can assign a value there.  
  
##  <a name="DeployRestart"></a> Customization to support application installers requiring a machine restart after deployment  
 The lab default template, does not restart the lab environment after you deploy the application. You might want to customize the template to support applications that might require a restart after they are deployed. If you deployed the application manually in a lab environment, you would restart only the machine the where the application was installed. [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Lab Management does not support operations on virtual machines in an environment. Consequently, to restart one machine requires that all machines in the lab environment be restarted.  
  
> [!WARNING]
>  Ensure that your deployment scripts never restart the machine. If this occurs, the build agent running the deployment script will lose connection with the build controller and the workflow might stop.  
  
 Restarting the virtual machines after you deploy the new build requires adding three activities to LabDefaultTemplate:  
  
1.  Stop the environment  
  
2.  Start the environment  
  
3.  Wait for the virtual machines to start before continuing with the rest of the workflow.  
  
### Stop the Environment  
 You can add a stop environment activity to the default workflow template by dragging the **StopLabEnvironment** activity from the **Toolbox** to the workflow template and initializing the activity variables.  
  
##### To stop the environment  
  
1.  In the workflow editor, scroll to an activity with the display name **Application Deployment Succeeded**.  
  
2.  On the **View** menu, choose **Toolbox**. The toolbox opens on the left side and displays a list of the **Team Foundation Build Activities**. Scroll through the list of activities until you see the list of **Team Foundation Lab Management Activities**.  
  
3.  In the toolbox, choose the **StopLabEnvironment** activity. Drag it to the Workflow Editor, and position it before the **Application Deployment Succeeded** activity.  
  
4.  Right-click the activity and then click **Properties**. The properties window displays the in- and out-arguments for this activity. Notice the workflow already has a variable called **LabEnvironmentUri** which refers to the environment URI.  
  
5.  Choose the **Variables** tab. The list of variables is displayed.  
  
6.  In the **LabEnvironmentUri** row and under the **Default** column, double-click **Enter a VB Expression**. In the text box, type `LabEnvironmentUri`. The editor will display any existing uses of the parameter and you can select the value from that list instead of typing it in.  
  
### Start the Environment  
 You can add a start environment activity to the lab default template by dragging the **StartLabEnvironment** activity from the **Toolbox** to the workflow template and initializing the activity variables.  
  
##### To start the environment  
  
1.  In the toolbox, choose the **StartLabEnvironment** activity. Drag it to the Workflow Editor, and position it before the **Application Deployment Succeeded** activity but after the **StopLabEnvironment** activity.  
  
2.  Right-click the activity and then click **Properties**. The properties window displays the in- and out-arguments for this activity. Again, notice the workflow already has a variable called **LabEnvironmentUri**, which refers to the environment URI.  
  
     Choose the **Variables** tab. The list of variable is displayed.  
  
     In the **LabEnvironmentUri** row and under the **Default** column, double-click **Enter a VB Expression**. In the text box, type `LabEnvironmentUri`. The editor will display any existing uses of the parameter and you can select the value from that list instead of typing it in.  
  
### Wait for the Machines to Restart before Continuing with the Rest of the Workflow.  
 You can add wait time for the virtual machines to start by dragging the **Delay** activity from the **Toolbox** to the workflow template and initializing the activity variables. This activity is located on the **Primitives** tab of the **Toolbox**.  
  
##### To wait for the virtual machines to start  
  
1.  In the Toolbox, choose the **Primitives** tab.  
  
2.  Click the **Delay** activity. Drag it to the Workflow Editor, and position it before the **Application Deployment Succeeded** activity but after the **StartLabEnvironment** activity.  
  
3.  Right-click the activity and then click **Properties**. The properties window displays the in- and out-arguments for this activity. Notice the workflow already has a variable called **Duration**, which refers to the wait time.  
  
4.  In the **Properties** window, choose **Duration** and then choose the ellipses (…).  
  
5.  In the **Expression Editor**, type the wait time (for example, 10 minutes) in the format `TimeSpan.FromMinutes(10)`.  
  
 After you have modified this template, check it in to Source Control and use it to create a new build definition to deploy applications that require restart after installation.  
  
##  <a name="ReadSource"></a> Customization to read source control files  
 If you create custom activities and then use them in your workflow template, make sure that the build agent, which communicates by using the lab service account, can access those activities. Because these activities have to be checked in to the source control system as custom assemblies, you must make sure that that lab service account has permission to read the path in which custom assemblies are checked in. For more information about the lab service account, see [Configure the Lab Service Account](../test/configure-the-lab-service-account.md) You can grant permissions to the lab service account using the `tf permissions` command.  For example, to grant read permissions to the lab service account mydomain\labAccount on the path $/MyProject/CustomAssemblies, you should execute a command similar to: `C:\Program Files\Microsoft Visual Studio 12.0\Common7\IDE>tf permission /user:mydomain\labAccount /collection:http://aseemb-tfs11:8080/tfs/Collection0 /allow:read $/MyProject/CustomAssemblies`  
  
##  <a name="BuildAgentDrop"></a> Customization to access a build drop location using the build agent account  
 The build agent that executes a workflow accesses the build drop location using the lab service account. If you want the build agent to use the build agent account instead, you can customize the lab default template. In the template, find the activity **RunDeploymentScript** which executes the deployment scripts. This activity exposes the property **SharedLocationForNetUse**, which defines the location that should be accessed by using the lab service account. `<mtlwa:RunDeploymentScript DisplayName="Running Deployment Script" ScriptDetails="[scriptDetails]" ThrowOnError="True" SharedLocationForNetUse="[BuildLocation]" />`To access the drop location under the build agent account instead of the lab service account, either delete the property from the template or set the value of this property to null ({x:Null}) as shown in this example: `mtlwa:RunDeploymentScript DisplayName="Running Deployment Script" ScriptDetails="[scriptDetails]" ThrowOnError="True" SharedLocationForNetUse="{x:Null}" />`  
  
##  <a name="LabServiceAccess"></a> Customization to access other locations using the lab service account  
 If the build agent running under the lab service account needs to read locations other than the build drop location, you can change the value of the property **SharedLocationForNetUse** from the default value **[BuildLocation]** to the desired location. For example, for the build agent running under the lab service account to access \\\contoso\scripts directory, you should have: `<mtlwa:RunDeploymentScript DisplayName="Running Deployment Script" ScriptDetails="[scriptDetails]" ThrowOnError="True" SharedLocationForNetUse="\\contoso\scripts" />`  
  
## See Also  
 [Lab management workflow activities](../test/lab-management-workflow-activities.md)   
 [Using a Lab Environment for Your Application Lifecycle](../test/using-a-lab-environment-for-your-application-lifecycle.md)   
 [Define your process](../Topic/Define%20your%20build%20process.md)   
 [Define the build](../Topic/Create%20or%20edit%20a%20build%20definition.md)   
 [A Developer's Introduction to Windows Workflow Foundation (WF) in .NET 4](http://go.microsoft.com/fwlink/?LinkId=200470)