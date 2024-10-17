---
title: Deploy GitHub Copilot within your enterprise
description: Configure and deploy GitHub Copilot programmatically to existing Visual Studio instances on a client's machine within an enterprise.
ms.date: 7/15/2024
ms.topic: conceptual
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: vs-2022
ms.custom: ai-learning-hub
---
# Deploy GitHub Copilot to existing Visual Studio instances

Administrators of Visual Studio 2022 version 17.8 or above can deploy GitHub Copilot onto client workstations programmatically with an installation script, just like you deploy other [Visual Studio components](../install/workload-and-component-ids.md). 

This method does NOT install the GitHub Copilot chat extension.

## Prerequisites

To get started, you need:

- This section assumes that Visual Studio 2022 [version 17.8 or later](/visualstudio/releases/2022/release-history) is already installed on the client machines. If it's not, refer to the guidance in the [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide) for how to deploy Visual Studio throughout your organization.
- A valid and active GitHub Copilot for Business subscription is required for the end user whose Visual Studio 2022 instance you're installing the GitHub Copilot component for. 
[See: Managing access for GitHub Copilot for Business in your organization.](https://docs.github.com/en/copilot/managing-copilot-business/managing-access-for-copilot-business-in-your-organization)

Options for deploying GitHub Copilot onto client machines depend on how Visual Studio is currently installed on these machines.

## Modify an existing installation to add the GitHub Copilot component

Most of the time, users would either acquire Visual Studio themselves, or run a development environment setup script on their machine.
To add the GitHub Copilot component to an existing installation of Visual Studio, use the installer's `modify` command from either a command line or PowerShell window.

### Sample install instructions

Make sure you're in the Visual Studio Installer directory in the command line or PowerShell window: `C:\Program Files (x86)\Microsoft Visual Studio\Installer`

```
$installDir = .\vswhere.exe -products * -version 17.8 -requires Microsoft.VisualStudio.Component.CoreEditor -property installationPath
foreach ($i in $installDir) {
    Write-Host "Adding Copilot to this installed instance" $i
    Start-Process -FilePath .\setup.exe -ArgumentList "modify --installPath ""$i"" --add Component.GitHub.Copilot --passive" -Wait
}
```

## Deploy using a layout

If you're using a layout to deploy Visual Studio across your organization, you first need to add the `Component.GitHub.Copilot` component to the layout.  Then, assuming the client is configured to [receive updates from the layout](../install/update-visual-studio.md#configure-source-location-of-updates), you can run a `modify` command as in the previous example to add it to the client.

For more information, see the [layout documentation](../install/create-a-network-installation-of-visual-studio.md#modify-the-contents-of-a-layout). 

## End user action required

After installing the GitHub Copilot component to the client machines, the end user will need to take the following steps to enable GitHub Copilot:

1. Log into the [GitHub web interface](https://github.com/settings/copilot) with the GitHub account associated with their Copilot subscription.
1. Activate access by launching Visual Studio 2022 and [adding their GitHub account to the Visual Studio keychain](work-with-github-accounts.md).

## Related content

To learn more, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat extension: Getting started](visual-studio-github-copilot-chat.md)
- [GitHub Copilot: Compare plans](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
- [Use command-line parameters to install, update, and manage Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md)
