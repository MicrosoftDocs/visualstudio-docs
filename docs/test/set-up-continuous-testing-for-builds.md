---
title: "Set up continuous testing for builds"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a1a600c2-280d-41c6-bd7f-5652901a08c6
caps.latest.revision: 11
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
# Set up continuous testing for builds
Find problems early after changes are checked in and built by running automated tests using Visual Studio Online (VSO) or Team Foundation Server (TFS).  
  
 Before you start:  
  
-   [Create a build definition](https://msdn.microsoft.com/en-us/Library/vs/alm/Build/overview) that builds your solution after each check-in, using continuous integration.  
  
-   [Set up environments](../test/set-up-environments-for-continuous-testing-with-builds.md) to run your app and tests remotely in a distributed environment after each build.  
  
## Step 1: Set up app deployment for your build  
  
1.  In Visual Studio Online or Team Foundation Server, go to your team project.  
  
2.  Go to your build definition. Add steps to deploy your app for testing. For example, if you're testing a Visual Studio solution:  
  
     ![Edit build definition](../test/media/build_editbuilddefinition.png "BUILD_EditBuildDefinition")  
  
     ![Add a step to your build definition](../test/media/vso_addbuildstep.png "VSO_AddBuildStep")  
  
     ![Add File Copy and PowerShell steps](../test/media/build_add_filecopy_powershell.png "BUILD_Add_FileCopy_PowerShell")  
  
3.  Add the details to copy your app from its drop location to its test environment:  
  
    -   Source folder for your app  
  
    -   Environment where to run your app  
  
    -   Target folder where to put your app  
  
     ![Build definition, copy app](../test/media/build_winmachinefilecopyapp.png "BUILD_WinMachineFileCopyApp")  
  
4.  Add the details to deploy your app using PowerShell:  
  
    -   Environment where to run your app  
  
    -   Path to the PowerShell script used to deploy your app  
  
     ![Add step to deploy app with PowerShell](../test/media/build_appdeploy_powershell.png "BUILD_AppDeploy_PowerShell")  
  
5.  Save your build definition.  
  
     ![Build definition: save](../test/media/build_savebuilddef.png "BUILD_SaveBuildDef")  
  
## Step 2: Set up test deployment for your build  
  
1.  In your build definition, add a step with these details to deploy your tests to their test environment:  
  
    -   Source folder for your tests  
  
    -   Environment where to run your tests  
  
    -   Target folder where to put your tests  
  
     ![Build definition, copy tests](../test/media/build_winmachinefilecopytests.png "BUILD_WinMachineFileCopyTests")  
  
2.  Add a step with these details to deploy the test agent for running your tests:  
  
    -   Environment where to deploy the test agent  
  
    -   Credentials for the test machines, so the test agent can run in your test environment  
  
     ![Build definition: deploy test agent details](../test/media/build_testagentdeploy.png "BUILD_TestAgentDeploy")  
  
3.  Save your build definition.  
  
     ![Build definition: save](../test/media/build_savebuilddef.png "BUILD_SaveBuildDef")  
  
## Step 3: Set up your tests to run with your build  
  
1.  In your build definition, add a step with these details to run your tests with the test agent:  
  
    -   Environment where to run your tests  
  
    -   Folder where you put your tests  
  
     ![Build definition: Run tests with test agent](../test/media/build_runtestswithagent.png "BUILD_RunTestsWithAgent")  
  
2.  Save your build definition.  
  
     ![Build definition: save](../test/media/build_savebuilddef.png "BUILD_SaveBuildDef")  
  
3.  To check your test run, queue your build.  
  
     ![Build definition: queue build](../test/media/build_queuebuild.png "BUILD_QueueBuild")  
  
4.  After your build is done, [review your test results](../test/review-continuous-test-results-after-a-build.md).  
  
## Q & A  
  
### Q: How do I run tests in more than one environment?  
 **A:** Add steps to deploy and run your tests for each environment that you want to use.  
  
### Q: Can I deploy to Azure?  
 **A:** Yes, [see these steps here](https://msdn.microsoft.com/Library/vs/alm/Build/azure/index).  
  
### Q: What if I want to run debug builds of native (.cpp) unit tests on the machine with the test agent?  
 **A:** Make sure that you have debug versions of the Universal C Runtime (UCRT) on the machine with the test agent, specifically these libraries: ucrtbased.dll and vcruntime140d.dll. You can include these items with your deployment.  
  
 If you're running release builds of .cpp unit tests, make sure that you have Windows Update KB2999226 on your test agent machine.  
  
## See Also  
 [Run tests with your builds](../test/run-tests-with-your-builds.md)