---
title: "Install test agents and test controllers for Visual Studio"
ms.date: 03/02/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
ms.topic: conceptual
helpviewer_keywords:
  - "configure test agents, test lab"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Install test agents and test controllers

For test scenarios that use Visual Studio and Visual Studio Team Services (VSTS) or Team Foundation Server (TFS), you do not need a test controller. Agents for Visual Studio handle orchestration by communicating with VSTS or TFS. A scenario could be that you run continuous tests for build and release workflows in VSTS or TFS.

You might also consider if it's better to use [build or release management](use-build-or-rm-instead-of-lab-management.md) instead of lab management.

## System requirements

| Item | Requirements |
| ---- | ------------ |
| **Agent** | Windows 10<br />Windows 8, Windows 8.1<br />Windows 7 Service Pack 1<br />Windows XP Service Pack 3<br />Windows Server 2012, Windows Server 2012 R2<br />Windows Server 2008 Release 2, Service Pack 1 |
| **Controller** | Windows 10<br />Windows 8, Windows 8.1<br />Windows 7 Service Pack 1<br />Windows Server 2012, Windows Server 2012 R2<br />Windows Server 2008 Release 2, Service Pack 1 |
| **.NET Framework** | .NET Framework 4.5 |

## Install the test controller and test agents

You can download agents for Visual Studio 2017 from [visualstudio.com](https://www.visualstudio.com/downloads/?q=agents). Scroll to the bottom of the page, and look for *Agents for Visual Studio 2017*. Select either *Agent* or *Controller*, and then choose *Download*. Run the downloaded executable to install the test agent or controller.

You can download agents for Visual Studio 2015 and Visual Studio 2013 from the [older downloads](https://www.visualstudio.com/vs/older-downloads/) page.

These installers are available as ISO files for easy installation on virtual machines.

## Compatible versions of TFS, Microsoft Test Manager, the test controller, and test agent

You can mix different versions of TFS, Microsoft Test Manager (MTM), the test controller, and the test agent, according to the following table:

| TFS | MTM with Lab Center | Controller | Agent |
| --- | -------------------------------------- | ---------- | ----- |
| 2017: upgrade from 2015 or new install | 2017 | 2017 | 2017 |
| 2017: upgrade from 2015 or new install | 2017 | 2013 Update 5 | 2013 Update 5 |
| 2017: upgrade from 2015 or new install | 2015 | 2013 Update 5 | 2013 Update 5 |
| 2015: upgrade from 2013 | 2013 | 2013 |2013 |
| 2015: new install | 2013 | 2013 | 2013 |
| 2015: upgrade from 2013 or new install | 2015 | 2013 | 2013 |
| 2013 | 2015 | 2013 | 2013 |

## Upgrade from Visual Studio 2013 test agents

We recommend that you use agents for Visual Studio in all new automated testing scenarios. You can use the *Deploy Test Agents* task in a build definition to download and install the test agents on your machine.

The following table shows the scenarios supported by Agents for Visual Studio 2013, and the alternatives for Team Foundation Server (TFS) 2015 and VSTS:

| Scenarios supported by Agents for Visual Studio 2013 | Alternative in TFS and VSTS |
| --- | --- |
| Build-Deploy-Test workflow in Visual Studio | Users can use a [build definition](/vsts/build-release/) (not a XAML build) for build, deploy, and test scenarios in TFS. |
| Load testing (performance testing) using on-premises remote machines | Use Test Controller and Test Agents 2013 Update 5 to run load tests on-premises. |
| Remote execution of automated tests from Microsoft Test Manager using a lab environment | Currently there is no alternative for this scenario. We recommend you use the Run Functional Tests task in build and release definitions (not in a XAML build) to execute tests remotely. |
| Developers executing remote tests in Visual Studio | No longer supported. |
