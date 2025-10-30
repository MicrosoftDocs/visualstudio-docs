---
title: Deploy GitHub Copilot within your enterprise
description: Configure and deploy GitHub Copilot programmatically to existing Visual Studio instances on a client's machine within an enterprise.
ms.date: 8/30/2025
ms.update-cycle: 180-days
ms.topic: install-set-up-deploy
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: ">=vs-2022"
ms.custom: ai-learning-hub
---
# Deploy GitHub Copilot to existing Visual Studio instances

Administrators of Visual Studio 2022 version 17.8 or above can deploy GitHub Copilot to client workstations programmatically using an installation script, similar to deploying other [Visual Studio components](../install/workload-and-component-ids.md). 

This method does NOT install the GitHub Copilot Chat extension.

## Prerequisites

To get started, you need:

- Visual Studio 2022 [version 17.8 or later](/visualstudio/releases/2022/release-history) installed on the client machines.
  Refer to the [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide) for deployment guidance.
- A valid and active GitHub Copilot for Business subscription for the end user installing the GitHub Copilot component in Visual Studio. 
  [Learn more: Managing access for GitHub Copilot for Business in your organization.](https://docs.github.com/en/copilot/managing-copilot-business/managing-access-for-copilot-business-in-your-organization)

Options for deploying GitHub Copilot depend on how Visual Studio is currently installed on client machines.

## Modify an existing installation to add the GitHub Copilot component

In most cases, users either install Visual Studio themselves, or set it up using a development environment setup script on their machine.
To add the GitHub Copilot component to an existing Visual Studio installation, use the installer's `modify` command from either a Command Prompt or PowerShell window. Learn more about [using command-line parameters with your Visual Studio installation](../install/use-command-line-parameters-to-install-visual-studio.md).

### Sample installation instructions

Ensure you're in the Visual Studio Installer directory (`C:\Program Files (x86)\Microsoft Visual Studio\Installer`) before running the command.

```
$installDir = .\vswhere.exe -products * -version 17.8 -requires Microsoft.VisualStudio.Component.CoreEditor -property installationPath
foreach ($i in $installDir) {
    Write-Host "Adding Copilot to this installed instance" $i
    Start-Process -FilePath .\setup.exe -ArgumentList "modify --installPath ""$i"" --add Component.GitHub.Copilot --passive" -Wait
}
```

## Deploy using a layout

If you're using a layout to deploy Visual Studio across your organization, follow these steps:

1. Add the `Component.GitHub.Copilot` component to the layout.
1. Ensure the client is configured to [receive updates from the layout](../install/update-visual-studio.md#configure-source-location-of-updates)
1. Run a `modify` command (as shown in the previous example) to install GitHub Copilot on the client machine.

For more information, refer to the [layout documentation](../install/create-a-network-installation-of-visual-studio.md#modify-the-contents-of-a-layout). 

## End user action required

After installing the GitHub Copilot component on client machines, the end user must complete the following steps to enable GitHub Copilot:

1. Log in to the [GitHub web interface](https://github.com/settings/copilot) using the GitHub account associated with their Copilot subscription.
1. Activate access by launching Visual Studio 2022 and [adding their GitHub account to the Visual Studio keychain](work-with-github-accounts.md).

## Related content

To learn more, consider exploring the following resources:

- [GitHub Copilot Completions: Getting started](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat: Getting started](visual-studio-github-copilot-chat.md)
- [GitHub Copilot: Compare plans](https://github.com/features/copilot/plans)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
- [Use command-line parameters to install, update, and manage Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md)
