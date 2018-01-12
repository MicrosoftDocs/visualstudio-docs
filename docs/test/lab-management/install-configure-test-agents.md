---
title: "Install and configure test agents | Microsoft Docs"
ms.custom: ""
ms.date: "05/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-devops-test
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "configure test agents, test lab"
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
author: gewarren
---
# Install and configure test agents

For test scenarios using Visual Studio and 
Visual Studio Team Services or Team Foundation Server (TFS), 
you won't need a test controller because Agents for Microsoft Visual Studio 
handle orchestration by communicating with Team Services or TFS. 
For example, you're running continuous tests with your build and release workflows in Team Services or TFS.

If you need your test agent or test controller to work with TFS 2013, 
use Agents for Microsoft Visual Studio 2013 Update 5 and configure the test controller.

Also consider if it would be easier to [use Build or Release Management instead](use-build-or-rm-instead-of-lab-management.md).

## What do I need?

**Where do I get the test controller and test agents?**

* If you are running tests using Build vNext tasks and want to install agents from a local directory - 

  * [Download Agents for Microsoft Visual Studio 2015 RTM and Update 1](http://go.microsoft.com/fwlink/p/?LinkId=619266). 

  * [Download Agents for Microsoft Visual Studio 2017 and Visual Studio 2015 Update 2](https://www.visualstudio.com/downloads/download-visual-studio-vs) - Choose **Tools for Visual Studio 2015** and then select **Agents for Visual Studio 2015** from the left navigation bar.

* [Download Agents for Microsoft Visual Studio 2013 Update 5](http://go.microsoft.com/fwlink/p/?LinkId=619264), if you want to run:

  * Load tests using on-premises remote machines.

  * Continuous tests remotely using Microsoft Test Manager or MSTest and test settings for lab environments.

  * Continuous tests using TFS 2013.

These installers are available as ISO files (virtual CD) for easy installation on virtual machines. 

[Can I mix versions of TFS, Microsoft Test Manager, the test controller, and test agent?](#MixedVersions)

**What system requirements do I need to install my test controller and test agents?**

| Item | Requirements |
| ---- | ------------ |
| **Agent** | Windows 10<br />Windows 8, Windows 8.1<br />Windows 7 Service Pack 1<br />Windows XP Service Pack 3<br />Windows Server 2012, Windows Server 2012 R2<br />Windows Server 2008 Release 2, Service Pack 1 |
| **Controller** | Windows 10<br />Windows 8, Windows 8.1<br />Windows 7 Service Pack 1<br />Windows Server 2012, Windows Server 2012 R2<br />Windows Server 2008 Release 2, Service Pack 1 |
| **.NET Framework** | .NET Framework 4.5 |

## Q & A

<!-- BEGINSECTION class="m-qanda" -->

<a name="MixedVersions"></a>

####Q: Can I mix versions of TFS, Microsoft Test Manager, the test controller, and test agent?

A: Yes, here are the compatible and supported combinations:

| TFS | Microsoft Test Manager with Lab Center | Controller | Agent |
| --- | -------------------------------------- | ---------- | ----- |
| 2015: upgrade from 2013 | 2013 | 2013 |2013 |
| 2015: new install | 2013 | 2013 | 2013 |
| 2015: upgrade from 2013 or new install | 2015 | 2013 | 2013 |
| 2013 | 2015 | 2013 | 2013 |

####Q: Will the Test Agent 2015 support all the scenarios supported by Test Controller and Test Agent of Visual Studio 2013?

A: We recommend you use Agents for Visual Studio in all the new automated testing scenarios. 
You can use the Deploy Test Agents task in a build definition to download and install the test agents on your machine.
The following table shows the scenarios supported by Agents for Visual Studio 2013
and the alternatives for Team Foundation Server (TFS) 2015 and Team Services (TS).

| Scenarios supported by Agents for Visual Studio 2013 | Alternative in TFS and TS |
| --- | --- |
| Build-Deploy-Test workflow in Visual Studio | Users can use a [build definition](https://www.visualstudio.com/team-services/continuous-integration/) (not a XAML build) for build, deploy, and test scenarios in TFS. |
| Load testing (performance testing) using on-premises remote machines | Use Test Controller/Test Agents 2013 Update 5 to run load tests on-premises. [More information](https://msdn.microsoft.com/en-us/library/ff400223.aspx). |
| Remote execution of automated tests from Microsoft Test Manager using a lab environment | Currently there is no alternative for this scenario. We recommend you use the Run Functional Tests task in build and release definitions (not in a XAML build) to execute tests remotely. |
| Developers executing remote tests in Visual Studio | No longer supported. |

<!-- ENDSECTION -->

## See also

* [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](https://msdn.microsoft.com/library/dd286743%28v=vs.140%29.aspx)
