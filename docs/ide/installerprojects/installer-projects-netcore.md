---
title: "Visual Studio Installer Projects and .NET Core 3.1 | Microsoft Docs"
ms.date: "08/07/2020"
ms.topic: "conceptual"
helpviewer_keywords:
  - "installer projects"
  - "installer projects, .NETCore"
author: MSLukeWest
ms.author: lukewest
manager: MSLukeWest
ms.workload:
  - "multiple"
---

# Visual Studio Installer Projects Extension and .NET Core 3.1

Packaging applications as an MSI is often accomplished using the Visual Studio Installer Projects Extension.

You can download the extension here:
[Visual Studio Installer Projects](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects)

## Update for .NET Core
.NET Core has two different models for publishing.

- Framework-dependent deployments

- Self-contained applications include the runtime.

You can learn more about of these deployment strategies [here](https://docs.microsoft.com/dotnet/core/deploying/).

### Workflow changes for .NET Core 3.1

- Pick “Publish Items” instead of “Primary Output” to get the correct output for .NET Core 3.1 projects.

- To create a self-contained installer, set the “PublishProfilePath” property on the “Publish Items” node in the setup project, using the relative path of a publish profile with the correct properties set.

### Prerequisites for .NET Core 3.1

If you would like your installer to be able to install the necessary runtime for a framework-dependent .NET Core 3.1 app, you can do this using [prerequisites](../../deployment/application-deployment-prerequisites.md).  From the properties dialog of your installer project open the “Prerequisites...” dialog and you'll see the following entries:

- .NET Core Runtime 3.1.x (x86)

- .NET Core Runtime 3.1.x (x64)

- .NET Desktop Runtime 3.1.x (x86)

- .NET Desktop Runtime 3.1.x (x64)

Note: These items are present starting with the Visual Studio 2019 Update 7 release.

## See also

- [Prerequisites Dialog Box](../../ide/reference/prerequisites-dialog-box.md)
- [Application Deployment Prerequisites](../../deployment/application-deployment-prerequisites.md)
