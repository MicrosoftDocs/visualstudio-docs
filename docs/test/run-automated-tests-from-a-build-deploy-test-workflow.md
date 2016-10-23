---
title: "Run automated tests from a build-deploy-test workflow"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.lab.workflow.deploymentscripts"
  - "vs.tfc.teamlab.builddefwizard"
  - "vs.lab.workflow.selectsnapshot"
helpviewer_keywords: 
  - "testing [Lab management], run scheduled tests"
  - "scheduled tests, in a virtual environment"
  - "virtual environments, run scheduled tests"
ms.assetid: 379c1fde-e462-4df2-9588-45ea35cfbca0
caps.latest.revision: 59
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
# Run automated tests from a build-deploy-test workflow
> [!NOTE]
>  This topic applies when you are testing in both standard environments and SCVMM environment. However, the steps that involve environment snapshots only apply to SCVMM environments.  
  
 You can run automated tests in a lab environment using a build-deploy-test workflow by queuing the build for the workflow, or by configuring the workflow to run at a scheduled interval. For information on creating a build-deploy-test workflow and scheduling your workflow, see [Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md). For example, you can build and deploy daily builds of your application on a server and run tests on that server using a client. After you run your automated tests, you can analyze the test results to check the quality of your builds. Test results are saved every time your build-deploy-test workflow is completed. You can use these results to view how stable your build is and decide whether to use that build for manual testing.  
  
 If you’re using an SCVMM environment, you can also use your build results to connect to a snapshot of your lab environment that was made after your application was deployed. This enables you to view the state of the environment after a test failure, even after a new test run restores your environment with a clean snapshot.  
  
 This topic describes how to run or schedule a build-deploy-test workflow to run your automated tests in a standard environment or an SCVMM environment, and then view your test results. In addition, this topic describes how to connect a post deployment snapshot from your build results when using an SCVMM environment.  
  
 Use the following procedures to run automated tests on your application in a lab environment using a build-deploy-test workflow, and then analyze the test results:  
  
-   [Check the Prerequisites](#Prerequisites)  
  
-   [Start Your Build](#CreateBuildDefinition)  
  
-   [Connect to the Environment from Your Build Results](#ConnectFromResults)  
  
-   [View and Analyze the Test Results For Your Build](#ViewTestResults)  
  
## Procedures  
  
##  <a name="Prerequisites"></a> Prerequisites  
 Before you configure and run your scheduled tests in a lab environment, use this list to verify that you have completed the following tasks:  
  
#### Prerequisite Tasks  
  
1.  Configure a test controller. See [Setting Up Test Controllers in Lab Environments](../test/setting-up-test-controllers-in-lab-environments.md).  
  
2.  Configure a build controller and build agent using Team Foundation Server Administration. See **How to Configure a Build Machine**.  
  
3.  Create a lab environment and configure it with the required roles for your application. See [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
4.  (Recommended) If you’re using an SCVMM environment, take a snapshot of your environment to use as a clean state for your workflow. See [Using Environment Snapshots with SCVMM Environments](../test/using-environment-snapshots-with-scvmm-environments.md).  
  
5.  Add your automated tests to a test plan. See [Automate a test case](../test/automate-a-test-case-in-microsoft-test-manager.md).  
  
6.  Create test settings for your automated tests and assign the tests to the roles in your lab environment. See [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md).  
  
7.  Create your build-deploy-test workflow. See [Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md).  
  
##  <a name="CreateBuildDefinition"></a> Start Your Build  
 You can run your automated tests from a workflow by queuing a build.  
  
###  <a name="QueueBuild"></a> To queue your build  
  
1.  To start build-deploy-test workflow, open the shortcut menu for your build definition in the Builds folder, and choose **Queue New Build**.  
  
     The **Queue Build** dialog box is displayed.  
  
2.  Verify the information for your workflow and then choose **Queue**.  
  
     The Build Explorer view is displayed.  
  
3.  To see the Build Summary view as the build progresses, double-click your build.  
  
     You can see the status as the build progresses.  
  
4.  (Optional) If you want to view the lab environment as the build progresses, open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], locate the **Lab Center**, choose **Lab**, and then choose your environment in the list.  
  
     If your build-deploy-test workflow is completed successfully, you’ll see a green check mark. If there are errors, you can choose **View Log** to see details.  
  
##  <a name="ConnectFromResults"></a> Connect to the Environment from Your Build Results  
 You might want to connect to your lab environment to investigate an issue if a test fails during the workflow process. You can connect either to the post deployment snapshot, if you selected this option in your build workflow and are using an SCVMM environment, or to the environment in its current state, as shown in this illustration:  
  
 ![Connect to the Environment from Your Build Results](../test/media/teamlabconnectpostbuild.png "TeamLabConnectPostBuild")  
  
#### To connect to the environment from your build results  
  
1.  From the **Builds** folder in [!INCLUDE[esprtfc](../codequality/includes/esprtfc_md.md)], open the shortcut menu for your build definition that contains your workflow and point to **View Builds**.  
  
     The **Build Explorer** view is displayed.  
  
2.  To view your completed build, choose the **Completed** tab.  
  
3.  Double-click the build that you want to view.  
  
     The Build Summary view is displayed.  
  
4.  Choose the link next to View environment snapshot \<Build name and number>.  
  
     The **Connect to environment** dialog box is displayed.  
  
5.  > [!NOTE]
    >  This step only applies to SCVMM environments. If you’re using a standard environment, skip this step.  
  
     If you’re using an SCVMM environment, and you want to connect to the snapshot that was taken after the application was deployed, choose **Connect to the snapshot in this environment**.  
  
    > [!NOTE]
    >  By connecting to this snapshot, any changes that were made after this post-deployment snapshot will be discarded. If you want to keep any changes, connect to the environment in its current state and take a snapshot first, before reverting to the post-deployment snapshot. For information about how to take a snapshot, see [&#91;NIB&#93; How to: Store the State of Your Environment](assetId:///bc4b2074-e915-44a9-8ce1-e4f8e5af5bb7).  
  
6.  If you want to connect to the environment in its current state after you have run any tests from your workflow, choose **Connect to the environment in its current state**.  
  
7.  Choose **Connect**.  
  
     The Microsoft Environment Viewer is displayed and you are connected to the environment. You can now investigate any issues.  
  
##  <a name="ViewTestResults"></a> View and Analyze the Test Results for Your Build-Deploy-Test Workflow  
 You can view the test results summary in your build summary. However, you can also view and analyze the test results by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] because the results are stored as part of your test plan. This is shown in the next illustration. See [Reporting on testing progress for test plans](../test/reporting-on-testing-progress-for-test-plans.md).  
  
 ![View the Test Results from Your Build Workflow](../test/media/teamlabviewresults.png "TeamLabViewResults")  
  
#### To view and analyze the test results from Microsoft Test Manager  
  
1.  Open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. (Go to Start, All Programs, Microsoft Visual Studio, Microsoft Test Manager.)  
  
2.  To view the test results, choose the down-arrow on the center group switcher and then choose **Testing Center**.  
  
3.  On the center group menu bar, choose **Test** and then select one of the test suites from the test suite hierarchy that you used in your build workflow.  
  
     You can see the results for the tests for the configuration that you selected in your build workflow.  
  
4.  If you want to analyze the complete test run, choose **Analyze Test Runs**.  
  
     The **Analyze Test Runs** activity is displayed. It shows any test runs for this test plan.  
  
    > [!NOTE]
    >  The run title will reflect the name of your build definition. The run ID is displayed in the build summary page for your build to help you identify the run.  
  
5.  Double-click a test run to open it and view the details. The test run details are displayed.  
  
6.  (Optional) To update the title of your test run to be more meaningful, type the new name in **Title**.  
  
7.  (Optional) If your test failed, you can update the reason for the failure. Choose **Resolution** and select the reason for the failure from the list.  
  
8.  (Optional) To add comments to the test result, choose the **Comments** icon. Type your comments and then choose **Save comments**.  
  
9. (Optional) To view the details of the individual test, double-click the test.  
  
     The test result is displayed. It shows the details from the test run, the attachments for data that was collected for this test result, and the test results history for that test. You can close this view to return to the test run.  
  
    > [!NOTE]
    >  If you determine that there is a bug, you can create a bug from this view.  
  
10. To save any changes for the test run, choose **Save** in the toolbar.  
  
## See Also  
 [Test on a lab environment](../test/test-on-a-lab-environment.md)