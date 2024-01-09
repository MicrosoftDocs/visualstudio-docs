---
title: Deploying GitHub Copilot to Visual Studio 2022 instances
description: Configure and deploy GitHub Copilot to a client machine within an enterprise programmatically with an installation script.
ms.date: 1/10/2024
ms.topic: conceptual
author: anandmeg
ms.author: meghaanand
ms.manager: jmartens
ms.technology: vs-ai-tools
monikerRange: vs-2022
---
# Install GitHub Copilot onto a client machine from a Visual Studio layout

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

For administrators of Visual Studio 2022 version 17.8 or above, there is now a method available to deploy GitHub Copilot onto client workstations programmatically with an installation script.

Note that this method does NOT install the GitHub Copilot chat extension.


## Pre-requisites

To get started, you need:

- Visual Studio 2022 [version 17.8 or later](https://learn.microsoft.com/en-us/visualstudio/releases/2022/release-history)
- A valid and active GitHub Copilot for Business subscription for the end user whose instance of Visual Studio 2022 you are trying to install the Github Copilot component for. 
[See: Managing access for GitHub Copilot for Business in your organization.](https://docs.github.com/en/copilot/managing-copilot-business/managing-access-for-copilot-business-in-your-organization)

## Installing GitHub Copilot to Visual Studio instances

Options for deploying GitHub Copilot onto client machines depend on how Visual Studio is currently installed on these machines.

### Using the Visual Studio Installer

- For most organizations, users will either install Visual Studio on their own by download the installer, or through an administrator command that runs the installer.
- For these customers, you can run a command from the Powershell Admin Window, example for Visual Studio 2022 version 17.8 below:

Be in the c:\Program Files (x86)\Microsoft Visual Studio\Installer> directory:

`$installDir = .\vswhere.exe -products * -version 17.8 -requires Microsoft.VisualStudio.Component.CoreEditor -property installationPath
foreach ($i in $installDir) {
    Write-Host "Adding Copilot to this installed instance" $i
    Start-Process -FilePath .\setup.exe -ArgumentList "modify --installPath ""$i"" --add Component.GitHub.Copilot --passive" -Wait
}`

### Using a layout

If you are not already using a layout-based install to deploy Visual Studio 2022, we don't recommend it. This is typically for air-gapped installs or environments where every developer must be on the exact same version of Visual Studio.

To deploy the GitHub Copilot component to a layout based installation, make sure to add the `Component.GitHub.Copilot` component to the layout, and then run a modify command as in the previous example to add it to the client.

Refer to the [layout documentation](https://learn.microsoft.com/en-us/visualstudio/install/create-a-network-installation-of-visual-studio?view=vs-2022#modify-the-contents-of-a-layout) for further information. 

## End user action required
Note that even after installing the GitHub Copilot component to the client machines, the end user will need to take two steps:

1) Make sure they are logged into the [GitHub web interface](https://github.com/settings/copilot) with the GitHub account associated with their Copilot subscription
2) Launch Visual Studio 2022 and [add their GitHub account to their Visual Studio keychain to activate access](https://learn.microsoft.com/en-us/visualstudio/ide/work-with-github-accounts?view=vs-2022).

## Related content

To learn more, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat extension: Getting started](visual-studio-github-copilot-chat.md)
- [GitHub Copilot: Compare plans](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
