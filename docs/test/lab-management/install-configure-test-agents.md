---
title: "Install test agents and test controllers"
ms.date: 04/17/2019
ms.topic: conceptual
helpviewer_keywords:
  - "configure test agents, test lab"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Install test agents and test controllers

For test scenarios that use Visual Studio and Azure Test Plans or Team Foundation Server (TFS), you don't need a test controller. Agents for Visual Studio handle orchestration by communicating with Azure Test Plans or TFS. A scenario could be that you run continuous tests for build and release workflows in Azure Test Plans or TFS.

You might also consider if it's better to use [build or release management](use-build-or-rm-instead-of-lab-management.md) instead of lab management.

## System requirements

The following table shows the system requirements for installing the test agent or test controller for Visual Studio:

| Item | Requirements |
| ---- | ------------ |
| **Agent** | Windows 10<br />Windows 8, Windows 8.1<br />Windows 7 Service Pack 1<br />Windows Server 2016 Standard and Datacenter<br />Windows Server 2012 R2 |
| **Controller** | Windows 10<br />Windows 8, Windows 8.1<br />Windows 7 Service Pack 1<br />Windows Server 2016 Standard and Datacenter<br />Windows Server 2012 R2 |
| **.NET Framework** | .NET Framework 4.5 |

## Install the test controller and test agents

You can download agents for Visual Studio from [visualstudio.microsoft.com](https://visualstudio.microsoft.com/downloads/?q=agents). Look for *Agents for Visual Studio 2019*, select either *Agent* or *Controller*, and then choose *Download*. Run the downloaded executable to install the test agent or controller.

You can download agents for Visual Studio 2017, Visual Studio 2015, and Visual Studio 2013 from the [older downloads](https://visualstudio.microsoft.com/vs/older-downloads/) page.

These installers are available as ISO files for easy installation on virtual machines.

## Compatible versions of TFS, Microsoft Test Manager, the test controller, and test agent

You can mix different versions of TFS, Microsoft Test Manager, the test controller, and the test agent, according to the following table:

| TFS | Microsoft Test Manager with Lab Center | Controller | Agent |
| --- | -------------------------------------- | ---------- | ----- |
| 2017: upgrade from 2015 or new install | 2017 | 2017 | 2017 |
| 2017: upgrade from 2015 or new install | 2017 | 2013 Update 5 | 2013 Update 5 |
| 2017: upgrade from 2015 or new install | 2015 | 2013 Update 5 | 2013 Update 5 |
| 2015: upgrade from 2013 | 2013 | 2013 |2013 |
| 2015: new install | 2013 | 2013 | 2013 |
| 2015: upgrade from 2013 or new install | 2015 | 2013 | 2013 |
| 2013 | 2015 | 2013 | 2013 |

> [!NOTE]
> Lab management scenarios in TFS 2018 and Azure DevOps Services are deprecated. For more information see [TFS 2018 Release Notes](/visualstudio/releasenotes/tfs2018-relnotes#--removing-support-for-lab-center-and-automated-testing-flows-in-microsoft-test-manager).

## Upgrade from Visual Studio 2013 test agents

We recommend that you use agents for Visual Studio in all new automated testing scenarios. You can use the *Deploy Test Agents* task in a build pipeline to download and install the test agents on your machine.

The following table shows the scenarios supported by Agents for Visual Studio 2013, and the alternatives for Team Foundation Server (TFS) 2015 and Azure Test Plans:

| Scenarios supported by Agents for Visual Studio 2013 | Alternative in TFS and Azure Test Plans |
| - | - |
| Build-Deploy-Test workflow in Visual Studio | Users can use a [build pipeline](/azure/devops/pipelines/index?view=vsts) (not a XAML build) for build, deploy, and test scenarios in TFS. |
| Load testing (performance testing) using on-premises remote machines | Use Test Controller and Test Agents 2013 Update 5 to run load tests on-premises. |
| Remote execution of automated tests from Microsoft Test Manager using a lab environment | Currently there is no alternative for this scenario. We recommend you use the Run Functional Tests task in build and release definitions (not in a XAML build) to execute tests remotely. |
| Developers executing remote tests in Visual Studio | No longer supported. |
