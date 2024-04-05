---
title: "Error: project type not found (Windows Installer, ClickOnce)"
description: "Resolve issues when a Windows Installer or ClickOnce project can't be loaded and you see this error message: The application which this project type is based on was not found."
ms.date: 04/11/2022
ms.topic: error-reference
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "error, deployment"
  - "deployment error"
  - "application not found"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Error: The application which this project type is based on was not found (Windows Installer or ClickOnce)

When you try to load a ClickOnce or Windows Installer project, you may get this error: `<path to project file>: The application which this project type is based on was not found. Please try this link for further information: <link>`.

This message indicates that the project requires components that are not installed for your version of Visual Studio.

## To correct this error

- Make sure the required Visual Studio workload is installed for your project type. Select **Tools** > **Get tools and features** to open the Visual Studio Installer. For Windows Installer or ClickOnce, the workload is .NET desktop development or Desktop development with C++.

- For Windows Installer projects, you may need to install the [Visual Studio Installer Projects extension](../deployment/installer-projects-net-core.md).

- If the project was created using InstallShield from Flexera Software, you may need to repair the installation (this can happen after upgrading Visual Studio).

- After you install required components, close and re-open Visual Studio, and then reload the project.

## See also

[Deployment in Visual Studio](../deployment/deploying-applications-services-and-components.md)
[Create an installer package](../deployment/deploying-applications-services-and-components.md#create-an-installer-package-windows-desktop)