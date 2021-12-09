---
description: "Packaging applications as an MSI is often accomplished using the Visual Studio Installer Projects Extension."
title: "Visual Studio Installer Projects and .NET 6.0"
titleSuffix: ""
ms.date: "11/29/2021"
ms.topic: "conceptual"
helpviewer_keywords:
  - "installer projects"
  - "installer projects, .NETCore"
author: MSLukeWest
ms.author: lukewest
manager: MSLukeWest
monikerRange: '>= vs-2019'
ms.workload:
  - "multiple"
---

# Visual Studio Installer Projects Extension and .NET 6.0

Packaging applications as an MSI is often accomplished using the Visual Studio Installer Projects Extension.

This article applies to apps targeting .NET Core 3.1, .NET 5, and .NET 6.

You can download the extension here:

::: moniker range=">= vs-2022"
[Visual Studio Installer Projects](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2022InstallerProjects)
::: moniker-end
::: moniker range="vs-2019"
[Visual Studio Installer Projects](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects)
::: moniker-end

## Update for .NET Core

.NET Core has two different models for publishing.

- Framework-dependent deployments

- Self-contained applications include the runtime.

To learn more about these deployment strategies, see [.NET Core application publishing overview](/dotnet/core/deploying/).

### Workflow changes for .NET Core 3.1 and later versions

1. Select **Publish Items** instead of **Primary Output** to get the correct output for .NET Core 3.1, .NET 5.0, or .NET 6.0 projects.  To bring up this dialog, select **Add** > **Project Output...** from the project's context menu.

    ![The Publish Items output group in the Add Project Output Group dialog](../deployment/media/installer-projects-net-core-publish-items-output.png "Pick Publish Items")

2. To create a self-contained installer, set the **PublishProfilePath** property on the **Publish Items** node in the setup project, using the relative path of a publish profile with the correct properties set.

    ![Setting the publish profile on the Publish Items project output item](../deployment/media/installer-projects-net-core-publish-profile.png "Set Publish Profile")

>[!NOTE]
>This workflow is not supported for ASP.NET Core applications, only Windows Desktop applications.

### Prerequisites

If you would like your installer to be able to install the necessary runtime for a framework-dependent .NET Core 3.1, .NET 5.0, or .NET 6.0 app, you can do this using [prerequisites](../deployment/application-deployment-prerequisites.md).  From the properties dialog of your installer project, open the **Prerequisites...** dialog and you'll see the following entries:

![.NET Core items in the Prerequisites dialog](../deployment/media/installer-projects-net-core-prerequisites.png ".NET Core Prerequisites")

The **.NET Core Runtime...** option should be selected for console applications, **.NET Desktop Runtime...** should be selected for WPF/WinForms applications.

>[!NOTE]
>These items are present starting with the Visual Studio 2019 Update 7 release.

## See also

- [Prerequisites Dialog Box](../ide/reference/prerequisites-dialog-box.md)
- [Application Deployment Prerequisites](../deployment/application-deployment-prerequisites.md)
