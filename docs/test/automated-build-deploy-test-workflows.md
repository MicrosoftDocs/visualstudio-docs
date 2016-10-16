---
title: "Automated build-deploy-test workflows"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 167271fb-20cd-4765-af5d-1284868bbc47
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
# Automated build-deploy-test workflows
You can use a build-deploy-test workflow on Team Foundation Server to deploy and [test](../test/automate-system-tests.md) your application when you [run a build](../Topic/Build%20the%20application.md). This lets you schedule and run the build, deployment, and testing of your application with one build process. Build-deploy-test workflows work with [Lab Management](../test/test-on-a-lab-environment.md) to deploy your applications to a lab environment and run tests on them as part of the build process.  
  
 If your lab environment is an [SCVMM environment](../test/scvmm--virtual--environments.md), you can also use workflows to create and restore snapshots that automatically create a clean environment before you run tests, and to save the state of your environment when a test fails. This ensures that each test isn’t influenced by changes to the lab environment from previous test runs. In addition, it ensures that testers can accurately reproduce that state of a lab environment when they reproduce bugs.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 You can use a build-deploy-test workflow in the following scenarios:  
  
> [!TIP]
>  **Build, or Build and Test**: If you are building your application in a drop folder without deploying it to a lab environment, then you can use the default build process template. For more information, see [Use the Default Template](../Topic/Use%20the%20Default%20Template%20for%20your%20build%20process.md). If you also want to test your application without deploying it, see [Run tests in your build process](../Topic/Run%20tests%20in%20your%20build%20process.md)  
  
-   **Build, Deploy, and Test** − Build your application, then deploy it and run automated tests on it in a lab environment. This workflow enables you to run a series of tests from a test plan, on a deployed application, as part of your build process. This scenario is common when running **build verification tests**.  
  
-   **Deploy and Test** − This scenario is similar to the “build, deploy, and test” scenario, except a new build isn’t created during the workflow. Instead, the workflow uses an existing build from a drop folder.  
  
-   **Deploy Only** – Deploy an existing build from a drop folder to a lab environment without running automated tests during the workflow. Once a build has passed your build verification tests, and is ready to be sent to a test team, you might want to send that specific build to the test team so they can run additional tests that aren’t part of your workflow. This scenario is common when running **manual tests**.  
  
-   **Build and Deploy** – This scenario is similar to the “deploy only” scenario, except a new build is created during the workflow.  
  
 A build-deploy-test workflow is a Windows Workflow file that defines how a *build definition* will run a build, deploy an application, and run tests. A build-deploy-test workflow is created in a build definition by choosing a *build process template* called the lab default template (LabDefaultTemplate.11.xaml), and configuring the settings. You can also create a customized build process template for your workflow depending on your requirements. You configure your build definition after you set up your build machine, test machines, and lab environments.  
  
 The deployment settings in a build-deploy-test workflow define how an application is deployed by specifying the deployment scripts to run on specific machines in your lab environment. You can specify a lab management role to run each deployment script on, or you can specify a specific machine in your lab environment. Creating deployment scripts is a major part of setting up build-deploy-test workflows. Deployment scripts copy files from your build to your lab environment, and then run your installation packages.  
  
 The following diagram describes how a build is deployed by a build-deploy-test workflow:  
  
 ![Dataflow for deployment scripts.](../test/media/deployment_dataflow.png "deployment_dataflow")  
  
 The following steps are displayed in the diagram above.  
  
1.  The build-deploy-test workflow starts a build, and then gets the deployment scripts.  
  
2.  The build definition copies the build files to the drop location.  
  
3.  The workflow runs each deployment script in the working directory of the specific machine or machine role that the script is assigned to.  
  
4.  Each deployment script retrieves build files from the drop location.  
  
5.  Each deployment script copies or installs the specified build files onto machines in the lab environment.  
  
## Prerequisites  
 You must complete these steps before you set up a build-deploy-test workflow.  
  
1.  **Configure Team Foundation Build Service**  
  
     Set up a build configuration for your team project collection using the Administration Console for your Team Foundation Server. When you set up your build configuration, you will select build controllers and build agents to use when building and deploying your application. For information on setting up your build configuration, see **How to Configure a Build Machine**.  
  
2.  **Set up a test controller**  
  
     Install a test controller and register it with your team project collection: [Setting Up Test Controllers in Lab Environments](../test/setting-up-test-controllers-in-lab-environments.md).  
  
3.  **Set up a lab environment**  
  
     Set up a lab environment. Your lab environment can be an SCVMM environment or a standard environment. When you set up your lab environment, test agents will be installed on each machine in the environment. For information about creating a lab environment, see [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
4.  **Additional steps to run automated tests from a test plan in a lab environment**  
  
     Before running automated tests from a test plan, you must first associate your automated tests with test cases from that test plan. When you run automated tests from a test plan, you must use a lab environment. To create a test plan and associate your automated test with it, you must carry out the following tasks.  
  
    1.  Create a test plan and test suite: [Plan manual tests with Microsoft Test Manager](../test/plan-manual-tests-with-microsoft-test-manager.md)  
  
    2.  Associate your automated tests with test cases from your test suite: [Automate a test case](../test/automate-a-test-case-in-microsoft-test-manager.md)  
  
## Tasks  
 Use the following topics to set up your build-deploy-test workflow to deploy your application or to run tests on your application as part of a build process:  
  
|Topic|Description|  
|-----------|-----------------|  
|**Create deployment scripts for your build-deploy-test workflow:** To deploy your application, you must first create deployment scripts for your build-deploy-test workflow. Deployment scripts copy parts of your build to specific machines in your lab environment. In addition, if your build contains a web deployment package or installation package, your deployment scripts must run those packages.|-   [Creating deployment scripts for build-deploy-test workflows](../test/creating-deployment-scripts-for-build-deploy-test-workflows.md)|  
|**Create your build-deploy-test workflow:** You can set up a build-deploy-test workflow with a standard environment, or an SCVMM environment. If you are using an SCVMM environment, you can also use a build process to restore your environment with a snapshot before you run tests, and create a snapshot after your application is deployed.|-   [Create a build-deploy-test workflow for a standard environment](../test/create-a-build-deploy-test-workflow-for-a-standard-environment.md)<br />-   [Create a build-deploy-test workflow for an SCVMM environment](../test/create-a-build-deploy-test-workflow-for-an-scvmm-environment.md)|  
|**Accommodate additional build-deploy-test requirements by customizing your workflow:** If you have additional requirements that the default build process template doesn’t meet, you can create a custom build process template.|-   [Customizing lab management workflow](../test/customizing-lab-management-workflow.md)|  
|**Run Tests as part of your build-deploy-test workflow, or after your workflow is complete:** You can run automated tests as part of your build-deploy-test workflow, or you can run manual and automated tests after your workflow is complete.|-   [Test on a lab environment](../test/test-on-a-lab-environment.md)|  
  
## See Also  
 [Test apps early and often](../test/test-apps-early-and-often.md)