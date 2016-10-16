---
title: "Setting Up Test Machines to Run Tests or Collect Data"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "setting up test machines"
ms.assetid: f64b9297-2526-48e7-9758-205ed7a0e284
caps.latest.revision: 77
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
# Setting Up Test Machines to Run Tests or Collect Data
Using Visual Studio, you can run your tests and also collect data and diagnostics when you run your tests. You use *test settings* to specify the data and diagnostics to collect. You can even select diagnostic data adapters that affect the way that your test machine performs. For example, you might want to create a video recording of your desktop while you run your test, or collect system information about your Web server. Or you might want to emulate a slow network to impose a bottleneck on the system.  
  
 To run tests remotely on multiple machines, or collect data and diagnostics remotely you must use a test controller and test agents. The test controller runs as a service and assigns tests to a test agent to run. In addition it can tell the test agent what data or diagnostics need to be collected. You can manage the test controller and agents by using Visual Studio, or if you register the test controller with [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], then you can manage the controller and agents by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
 If you have a distributed application, you define a role for each computer to use to run tests or collect data. For example, if you have an application that consists of a Web server, a database server, and a desktop client, you would define one role for each of these. The desktop client can run the tests and collect data locally, and the other roles can collect any data that you require on the machine that you assign to that role.  You can also assign multiple machines to the same role.  
  
 If you are using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you create an *environment* for this set of roles. An environment is a collection of computers in which each computer has an assigned role.  
  
 The following sections of this topic provide more information about the ways to run tests and collect data, based on the type of tests that you run and whether you want to use an environment:  
  
-   [Manual Tests](#ManualTests)  
  
-   [Automated Tests](#AutomatedTests)  
  
-   [Environments](#Environments)  
  
##  <a name="ManualTests"></a> Manual Tests  
 It is recommended that you run your manual tests on a local machine that is not part of the environment. You can collect data or affect a test machine for your manual tests in the following ways:  
  
-   Collect data on the local machine using default test settings  
  
-   Collect data on a local machine specifying the data to collect  
  
-   Collect data on local and remote tiers of your application  
  
 For more information about how to set up your test settings and environments for these situations, see [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md).  
  
##  <a name="AutomatedTests"></a> Automated Tests  
 You can run tests either by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] or by using Visual Studio.  
  
 If you plan to run your automated tests by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you must use a lab environment that contains a set of roles to run your tests from your test plan. You must create a test controller that is registered with your team project in [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)]. However, [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] will set up the test agent in each machine in the environment.  
  
 If you plan to run automated tests by using Visual Studio, you can just run your automated tests on your local machine and use test settings to collect data locally. If you want to collect data or affect the test machine for specific parts of a multitier application, you can select a test controller and test agents and add roles to use in your test settings. You should not register the test controller with [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)]. However, you must set up a test agent in each machine on which you plan to initiate tests or collect test data.  
  
 The following illustration shows a test controller and test agents that are installed on a machine for each role in an application under test and the tasks that the test agent can perform. The test controller manages the test agents that are registered to it.  
  
> [!IMPORTANT]
>  If you want to use a test controller as part of an environment by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you must register it with [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], as shown in the following illustration. However, if you want to use a test controller from Visual Studio, do not register the test controller with [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)].  
  
 ![Test Controller and Test Agents](../test/media/testagent_concepts.png "TestAgent_Concepts")  
  
> [!WARNING]
>  The test agents and test controllers can be installed in different domains if your testing setup requires it.  
  
##  <a name="Environments"></a> Environments  
 If you use [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] to conduct your tests, you create lab environments on which to run the tests. There are two kinds of environments: standard and SCVMM environments. A standard environment can use physical computers or virtual machines, and the virtual machines can run on any virtualization framework. An SCVMM environment uses only virtual machines that are managed by System Center Virtual Machine Manager (SCVMM).  
  
 [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] can be used to set up both kinds of environment. In the case an SCVMM environment, you can stop and start environments, store environments in a library, and create multiple copies of them.  
  
 In both cases, you assign roles to each machine in the environment. For example, typical roles are **Web Server** and **Desktop Client**. The role names are used by your test workflow to determine what software and tests to deploy on each machine.  
  
 [!INCLUDE[TCMshort](../test/includes/tcmshort_md.md)] inserts a test agent on each computer, which enables the test controller to deploy software, run tests, and collect test results.  
  
 For more information, see [Test on a lab environment](../test/test-on-a-lab-environment.md).  
  
## Tasks  
 Use the following topics to help set up your machines to run tests and collect data.  
  
|Tasks|Associated topics|  
|-----------|-----------------------|  
|**Installing test controllers and test agents to use for running tests and collecting data:** You can use test controllers in your test settings that you create by using Visual Studio. Alternatively, you can use test controllers with your environments.|-   [Install and configure test agents](../test/install-and-configure-test-agents.md)<br />-   [Test Controller and Test Agent Requirements for Load Testing](../test/test-controller-and-test-agent-requirements-for-load-testing.md)<br />-   [Managing Test Controllers and Test Agents with Visual Studio](../test/managing-test-controllers-and-test-agents-with-visual-studio.md)|  
|**Setting up existing computers for running tests:** A standard environment consists of test agents that are installed on physical machines or virtual machines.|-   [Standard lab environments](../test/standard-lab-environments.md)<br />-   [Managing Test Controllers and Test Agents with Visual Studio](../test/managing-test-controllers-and-test-agents-with-visual-studio.md)<br />-   [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)|  
|**Setting up lab environments for running tests**: A lab environment can include physical or virtual machines.|-   [Test on a lab environment](../test/test-on-a-lab-environment.md)<br />-   [Setting Up Test Controllers in Lab Environments](../test/setting-up-test-controllers-in-lab-environments.md)<br />-   [Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md)<br />-   [Automate system tests](../test/automate-system-tests.md)|  
|**Set up how to run tests or collect data by using test settings:** You can create test settings and select the set of roles for your application under test and then select an environment that contains these roles in your test plan. You can also override these settings in your test plan for specific test runs.|-   [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)<br />-   [How to: Override Settings in Your Test Plan for Test Runs](assetId:///832576d2-44bd-4237-8cde-612349a3ab50)|  
  
## See Also  
 [Test apps early and often](../test/test-apps-early-and-often.md)   
 [Testing your application using Microsoft Test Manager](../test/testing-your-application-using-microsoft-test-manager.md)