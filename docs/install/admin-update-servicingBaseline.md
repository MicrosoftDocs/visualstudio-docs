---
title: "Update Visual Studio while on a servicing baseline"
titleSuffix: ""
description: "Learn how to update Visual Studio while staying on a servicing baseline."
ms.date: 05/22/2019
ms.custom: "seodec18"
ms.topic: conceptual
ms.assetid: 
author: doughall
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Update Visual Studio while on a servicing baseline

Visual Studio 2019 will have frequent updates during its [product lifecycle](/visualstudio/productinfo/release-rhythm.md#release-channel-updates). These will include both minor release updates (for example: 16.0 to 16.1) that can include new features and components, and servicing updates (for example: 16.0.4 to 16.0.5) containing only targeted fixes for critical issues. 

Enterprise administrators can choose to keep their clients on a servicing baseline, which is supported with servicing updates for a year past the release of the next servicing baseline. This allows for more flexibility for developers and administrators to adopt the new features, bug fixes, or components included in new minor updates. The first servicing baseline is 16.0.x. See [Support options for enterprise and professional customers](/visualstudio/releases/2019/servicing.md#support-options-for-enterprise-and-professional-customers) for more information.

## How to get onto a servicing baseline

To start using a servicing baseline, download a fixed version Visual Studio Installer bootstrapper from [My.VisualStudio.com](https://my.visualstudio.com/Downloads?q=visual%20studio%202019%20version%2016.0). These bootstrappers have links to the product configurations, workloads, and components for that specific version. 

> [!NOTE]
> Be careful to distinguish between the fixed version bootstrapper and the normal bootstrappers. The normal bootstrappers are configured to use the latest available release of Visual Studio. They will have a number in the filename (for example: vs_enterprise__123456789-123456789.exe) when downloaded from my.visualstudio.com.

During install, enterprise administrators need to configure their clients to use the fixed version of Visual Studio to stay on the servicing baseline. This can be done by setting the channelUri through command-line execution, by changing the channelUri setting in the response configuration file, or by setting policies on the client system to disable updates. 

For administrators using a network layout install, set the channeluri in the `response.json` in the layout root. This will enable clients to use the layout for future updates. Here are additional details on [response file settings](automated-installation-with-response-file.md).

If it is an internet based install, add `--channelUri` with a non-existent channel manifest to the command-line used to launch setup. This will disable Visual Studio from using the latest available release for an update. Here is an example:

  ```cmd
   vs_enterprise.exe --channelUri c:\doesnotexist.chman 
  ```

Another option to control updates on a client is to [turn off update notifications](controlling-updates-to-visual-studio-deployments.md). Use this option if the channelUri value was not changed on install. It will disable the client from receiving links to the latest available release.

## How to stay on a servicing baseline

When there is an update for a servicing baseline, download the fixed version bootstrapper file for the servicing update from [My.VisualStudio.com](https://my.visualstudio.com/Downloads?q=visual%20studio%202019%20version%2016.0).

For administrators using a network layout install, update the [layout location](update-a-network-installation-of-visual-studio.md). Clients that installed from the location will receive update notifications. If the update needs to be deployed to clients, follow [these instructions](update-a-network-installation-of-visual-studio.md#how-to-deploy-an-update-to-client-machines).

If it is an internet based install, run the new fixed version bootstrapper with the `--channelUri` parameter pointing to a non-existent channel manifest on the client. If the update is deployed in quiet or passive mode, use two separate commands:

  * First, update the Visual Studio installer: <br>```vs_enterprise.exe --quiet --update```
  * Then, update the Visual Studio application itself: <br>```vs_enterprise.exe update --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" --quiet --wait --norestart --channelUri c:\doesnotexist.chman```

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
