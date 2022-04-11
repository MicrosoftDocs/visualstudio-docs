---
title: "Error: project type not found (ClickOnce, Windows Installer)"
description: "Learn about your options for deploying apps from Visual Studio."
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
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---

# Error: The application which this project type is based on was not found (ClickOnce or Windows Installer)

When you try to load a ClickOnce or Windows Installer project, you may get this error: ```<path to project file>: The application which this project type is based on was not found. Please try this link for further information: <link>```.

This message indicates that the project requires components that are not installed for your version of Visual Studio.

To resolve this issue:

1. Make sure the correct Visual Studio workload is installed for your project type. Select **Tools** > **Get tools and features** to open the Visual Studio Installer. For ClickOnce or Windows Installer, the workload is .NET desktop development or Desktop development with C++.

   For ClickOnce, make sure the individual component, ClickOnce Publishing, is also installed. This component should be installed with the workload by default.

1. For Windows Installer projects, you may need to install the [Visual Studio Installer Projects extension](../deployment/installer-projects-net-core.md).

1. Re-open the solution in Visual Studio.

## See also

[Deployment in Visual Studio](../deployment/deploying-applications-services-and-components.md)
[Create an installer package](../deployment/deploying-applications-services-and-components.md#create-an-installer-package-windows-desktop)