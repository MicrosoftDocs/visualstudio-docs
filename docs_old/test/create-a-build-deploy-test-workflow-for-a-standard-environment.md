---
title: "Create a build-deploy-test workflow for a standard environment"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f448c943-73e9-4265-98a2-ca11138e4948
caps.latest.revision: 29
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
# Create a build-deploy-test workflow for a standard environment
> [!NOTE]
>  This topic applies to standard environments. If you want to complete this procedure using an SCVMM environment, see [Create a build-deploy-test workflow for an SCVMM environment](../test/create-a-build-deploy-test-workflow-for-an-scvmm-environment.md).  
  
 You can use a build-deploy-test workflow to automatically deploy an application to your standard environment and run automated tests on that application as part of the build process. Users can then access the application in their standard environment, or they can run manual tests or automated tests separate from the build process using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. For an overview on build-deploy-test workflows, see [Setting Up Automated Build-Deploy-Test Workflows](../test/create-a-build-deploy-test-workflow-for-a-standard-environment.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 This topic describes how to create a build-deploy-test workflow after you create deployment scripts for your workflow. For information about creating deployment scripts, see [PAVE: Guidance for Build-Deploy-Test Workflows](assetId:///b84458a5-4094-4414-8005-83544790aa63). Use the following procedures to create a build-deploy-test workflow for a standard environment:  
  
-   [Check the Prerequisites](#Prerequisites)  
  
-   [Configure Your Build](#BasicBuild)  
  
-   [Create a Build Definition for Your Workflow](#AnotherBuild)  
  
-   [Add Details to Your Workflow](#AddDetails)  
  
-   [Run Your Workflow](#RunWorkflow)  
  
-   [View your Build Results](#ViewResults)  
  
-   [View Your Application](#ViewApplication)  
  
-   [Run Tests After Your Workflow is Complete](#RunTests)  
  
##  <a name="Prerequisites"></a> Prerequisites  
 Before you can set up your workflow to build and deploy your application, use this list to verify that you have completed the following tasks:  
  
#### Prerequisite tasks  
  
1.  Configure Team Foundation Build Service. See: **How to: Configure a Build Machine**.  
  
2.  Install a test controller and register it with your team project collection: [Setting Up Test Controllers in Lab Environments](../test/setting-up-test-controllers-in-lab-environments.md).  
  
3.  > [!NOTE]
    >  When you create your lab environment, choose the options to run tests and use a workflow.  
  
     Create a standard environment that uses your virtual and physical machines. See: [Standard lab environments](../test/standard-lab-environments.md).  
  
4.  If you are going to run automated tests in your lab environment, you must add your tests to a test plan and create a test setting using Microsoft Test Manager. See [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
5.  Create deployment scripts that your build-deploy-test workflow can use to install your application. See [Creating deployment scripts for build-deploy-test workflows](../test/creating-deployment-scripts-for-build-deploy-test-workflows.md).  
  
##  <a name="BasicBuild"></a> Configure your build  
 Your build-deploy-test workflow can either deploy an existing build of your application, or it can run a build definition, and then deploy the new build. To create a new build during your workflow, you must create a separate build definition that your workflow can use to build your application. When you add the build details to your workflow, you will either choose the drop location of an existing build or the build definition for creating a new build.  
  
> [!IMPORTANT]
>  If you add a build definition instead of a build drop location to your build-deploy-test workflow, you must disable tests in the build definition that will be used to build your application.  
  
 ![Create a build definition.](../test/media/bdt_createbuild2.png "BDT_CreateBuild2")  
  
#### To create a build definition for your application  
  
1.  On the **Build** menu, choose **New Build Definition**.  
  
2.  On the **General** tab, in the **Build definition name** box, specify a name and in the **Description** text box, add an appropriate description.  
  
3.  Follow the steps as described in the topic [Define the build](../Topic/Create%20or%20edit%20a%20build%20definition.md).  
  
##  <a name="CreateBuildDefinition"></a> Create your build-deploy-test workflow  
 In this section you will create your build-deploy-test workflow.  
  
###  <a name="AnotherBuild"></a> Create a build definition for your workflow  
 Next, create another build definition for your build-deploy-test workflow, as shown in the following illustration:  
  
 ![Use the lab default template.](../test/media/bdt_createworkflow2.png "BDT_CreateWorkflow2")  
  
##### To create a build definition for your workflow  
  
1.  On the **Build** menu, choose **New Build Definition**.  
  
2.  On the **General** tab, in the **Build definition name** box, specify a name and in the **Description** box add an appropriate description.  
  
3.  > [!NOTE]
    >  You can only use the template for a build definition with Manual, Scheduled, or Rolling build triggers. Rolling build triggers are not recommended because a test failure still allows the next rolling build to start or stop the entire build system. Gated check-in and Continuous integration triggers are not supported.  
  
     Choose settings on the **Trigger** and **Workspace**, **Build Defaults**, and **Retention Policy** tabs as described in the topic [Define the build](../Topic/Create%20or%20edit%20a%20build%20definition.md).  
  
    > [!NOTE]
    >  You do not have to enter a build drop path on the **Build Defaults** tab for this build workflow because you do not create build output when you use the Lab template. Clear **My builds copy outputs** and no drop folder is required.  
  
4.  To be able to select the Lab template for the build definition, on the **Process** tab, under **Build process template**, choose **Show details**.  
  
     A drop-down list appears.  
  
5.  Select a template. This is the build process file that defines your workflow.  
  
6.  To create a workflow for your build definition to deploy your application to a virtual environment, select **LabDefaultTemplate.11.xaml** from the drop-down list for **Build process file**.  
  
###  <a name="AddDetails"></a> Add the details for your workflow  
 Now you can add details to your workflow using the **Lab Workflow Parameters** wizard.  
  
 After you add these details to your workflow and save the build definition, you can queue the build to run your workflow:  
  
1.  To enter the details for your workflow, under **Build process parameters**, choose **Lab process settings** and then choose the ellipsis (…).  
  
     This opens the Lab Workflow Parameters wizard where you enter the information for the workflow.  
  
2.  **Select a lab environment:** On the **Environment** tab, select the standard environment to which you want to deploy your application.  
  
3.  Choose **Next**.  
  
4.  **Select a build definition or a build drop location:** If you want your workflow to build your application every time it is run, follow these steps:  
  
    1.  Choose **Use a Team Foundation build**, and choose the build definition that you created earlier.  
  
    2.  Choose **Queue a new build**.  
  
5.  If you want your workflow to use an existing build and not rebuild your application, follow these steps:  
  
    1.  Choose **Use a Team Foundation build**, and choose the build definition that you created earlier.  
  
    2.  Choose **Select an existing build**. Then choose a build from the drop-down list. The existing builds created by the build definition that you chose are displayed in the list.  
  
    3.  Choose a build configuration from **Select build configuration**.  
  
        > [!NOTE]
        >  The build configurations are specified when you create your build definition for your application. If there is more than one build configuration, you can choose one from this list.  
  
6.  If you want to define the location of a build, choose **Use a build from a specified location** and then specify the UNC path of the existing build.  
  
7.  Choose **Next**.  
  
8.  **Details for deployment scripts and commands:**  
  
    > [!IMPORTANT]
    >  Before you complete the next few steps, you must create deployment scripts and commands for your workflow. See [Creating deployment scripts for build-deploy-test workflows](../test/creating-deployment-scripts-for-build-deploy-test-workflows.md).  
  
     ![Add your deployment scripts.](../test/media/bdt_scriptdetails2.png "BDT_ScriptDetails2")  
  
     To deploy the application as part of your workflow, from the **Deploy** tab, select **Deploy the build**.  
  
9. To add the scripts or commands required to deploy your application, choose **Add**. Select the virtual machine, or virtual machine role that you want to add the script or command for.  
  
     You can now add scripts or commands for each virtual machine in your lab environment. For example, if you have a Windows client as part of your application, you might have a script that copies the executable to the location that your coded UI test will use to start the tests on your virtual machine. If you have a Web server then you will have to run the script or command to deploy that part of your application. For more details about how to complete this step, see [Creating deployment scripts for build-deploy-test workflows](../test/creating-deployment-scripts-for-build-deploy-test-workflows.md).  
  
10. Choose **Next**.  
  
11. **Add details for automated tests:**  
  
     To run automated tests from your workflow after you deploy your application, follow these steps:  
  
    1.  Select **Run these tests in the environment**.  
  
    2.  Under **Select the test plan**, select the test plan that you want to use. The test results will be saved as part of this test plan.  
  
    3.  Under **Select the test suites** choose the ellipses (…), and in the **Select test suites** dialog box, select the test suites you want to run.  
  
        > [!NOTE]
        >  By default, the root test suite is selected. If you do not want to run tests in this test suite, you must clear this field.  
  
    4.  Under **Select the test configuration**, select the configuration that you plan to use to run your tests.  
  
        > [!NOTE]
        >  The test results for each test case in each selected test suite will be saved as a pairing of each test case in the suite and the test configuration that you selected. See [Test configurations: specifying test platforms](../test/test-configurations--specifying-test-platforms.md).  
  
    5.  Under **Select the automated test settings**, select the test settings that you created earlier to match the roles in your lab environment in step 9 of the overall process for this topic. See [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md).  
  
12. Choose **Finish**.  
  
13. Choose **Save** to save your build definition.  
  
     The created build definition appears in the **Builds** folder in [!INCLUDE[esprtfc](../codequality/includes/esprtfc_md.md)].  
  
##  <a name="RunWorkflow"></a> Run Your Workflow  
 You can run your workflow by running the build definition that contains your workflow.  
  
1.  To start your workflow, go to the **Builds** folder, then open the shortcut menu for the build definition that contains your workflow.  
  
     Choose **Queue New Build**.  
  
     The **Queue Build** dialog box is displayed.  
  
2.  Verify the information for your build workflow and then choose **Queue**.  
  
     The Build Explorer view is displayed.  
  
3.  To see the Build Summary view as the build progresses, double-click your build.  
  
     You can see the status as the build progresses.  
  
4.  (Optional) If you want to view the environment as the build progresses, open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], locate the **Lab Center**, choose **Lab**, and then choose your environment in the list. You can view the progress of the build reflected in the image for your environment and in the environment details above this image, as follows:  
  
    -   The status of the capabilities (a green arrow is displayed when a capability is ready).  
  
    -   The tests as they run, if the tests interact with the user interface.  
  
     If your build workflow is completed successfully, you will see a green checkmark. If there are errors, you can choose **View Log** to see details.  
  
##  <a name="ViewResults"></a> View the build results for your workflow  
 You can view the build results for your workflow after your workflow is complete.  
  
#### To view the build results for your workflow  
  
1.  From the **Builds** folder in [!INCLUDE[esprtfc](../codequality/includes/esprtfc_md.md)], right-click your build workflow definition and point to **View Builds**.  
  
     The **Build Explorer** view is displayed.  
  
2.  To view your completed build, choose the **Completed** tab.  
  
3.  Double-click the build that you want to view.  
  
     The Build Summary view is displayed.  
  
##  <a name="ViewApplication"></a> View your application after it is deployed  
 After your workflow is complete, you can use Environment Viewer in Microsoft Test Manager, or Remote Desktop to view your application by logging onto the machine your application was deployed to.  
  
##  <a name="RunTests"></a> Test your application after your workflow is complete  
 After your workflow is complete and your application is deployed to your lab environment, you can run tests on your application separate from your workflow. View these topics if you want to run tests on your application separate from your workflow, after your application is deployed to a standard environment:  
  
1.  [Run your tests](../test/running-manual-tests-using-the-web-portal.md)  
  
2.  [Automate system tests](../test/automate-system-tests.md)  
  
## See Also  
 [Setting Up Build-Deploy-Test Workflows](../test/create-a-build-deploy-test-workflow-for-a-standard-environment.md)   
 [Test on a lab environment](../test/test-on-a-lab-environment.md)