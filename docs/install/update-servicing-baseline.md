---
title: Update Visual Studio while on a servicing baseline
description: Learn how to update Visual Studio while staying on a servicing baseline.
ms.date: 11/23/2021
ms.topic: conceptual
ms.assetid: 
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
monikerRange: ">=vs-2019"
---
# Update Visual Studio while on a servicing baseline

We update Visual Studio often during its product lifecycle. There are two types of updates:

* **Minor release updates**&mdash;for example, 16.0 to 16.1&mdash;that include new features and components.  
* **Servicing updates**—for example, 16.0.4 to 16.0.5—that include only targeted fixes for critical issues.

Enterprise administrators can choose to keep their clients on a servicing baseline. A servicing baseline is supported with servicing updates for a year past the release of the next servicing baseline.

The servicing baseline option gives developers and administrators more flexibility to adopt the new features, bug fixes, or components included in new minor updates. The first servicing baseline is 16.0.x. For more information, see [Support options for enterprise and professional customers](/visualstudio/releases/2019/servicing#support-options-for-enterprise-and-professional-customers).

## How to get onto a servicing baseline

To start using a servicing baseline, download a fixed-version Visual Studio installer bootstrapper from [My.VisualStudio.com](https://my.visualstudio.com/Downloads?q=visual%20studio%202019%20version%2016.0). The bootstrappers have links to the product configurations, workloads, and components for that specific version.

> [!NOTE]
> Be careful to distinguish between the fixed-version bootstrapper and the standard bootstrappers. The standard bootstrappers are configured to use the latest available release of Visual Studio. The standard boostrappers have a number in the file name (for example, vs_enterprise__123456789-123456789.exe) when they're downloaded from My.VisualStudio.com.

During installation, enterprise administrators must configure their clients to prevent the clients from updating to the latest release. There are several ways to do this:
- [Change the `channelUri` setting in the response configuration file](update-servicing-baseline.md#install-a-servicing-baseline-on-a-network) to use a channel manifest in the layout or local folder.
- [Modify the channelUri through command-line execution](update-servicing-baseline.md#install-a-servicing-baseline-via-the-internet) to use a nonexistent file.
- [Set policies on the client system to disable updates](update-servicing-baseline.md#use-policy-settings-to-disable-clients-from-updating), to prevent clients from self-updating.

### Install a servicing baseline on a network

Administrators who use a network layout installation should modify the `channelUri` value in the *response.json* file in the layout to use the *channelmanifest.json* file that's in the same folder. For the steps to take, see [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md). Changing the `channelUri` value enables clients to look for updates in the layout location.

### Install a servicing baseline via the internet

For an internet-based installation, add `--channelUri` with a non-existent channel manifest to the command-line used to launch setup. This disables Visual Studio from using the latest available release for an update. Here's an example:

```shell
vs_enterprise.exe --channelUri c:\doesnotexist.chman
```

### Use policy settings to disable clients from updating

Another option to control updates on a client is to [turn off update notifications](controlling-updates-to-visual-studio-deployments.md). Use this option if the channelUri value was not changed on installation. It will disable the client from receiving links to the latest available release. A fixed-version bootstrapper is still necessary to update to a specific version on the client.

## How to stay on a servicing baseline

When an update for a servicing baseline is available, fixed-version bootstrapper files are made available for the servicing update at [My.VisualStudio.com](https://my.visualstudio.com/Downloads?q=visual%20studio%202019%20version%2016.0).

For administrators who deploy by using a network layout install, the administrator should update the [layout location](create-a-network-installation-of-visual-studio.md#update-or-modify-your-layout). Clients that installed from the location will receive update notifications. If the update must be deployed to clients, follow [these instructions](update-a-network-installation-of-visual-studio.md). When you modify the 'response.json' for an update, do not add additional workloads, components, or languages. Managing these settings must be done as a 'modify' deployment after the product has been updated.

For an internet-based installation, run the new fixed version bootstrapper with the `--channelUri` parameter pointing to a non-existent channel manifest on the client. If the update is deployed in quiet or passive mode, use two separate commands:

1. Update the Visual Studio installer:

    ```shell
    vs_enterprise.exe --quiet --update
    ```

::: moniker range="vs-2019"
 
2. Update the Visual Studio application itself:
    ```shell
    vs_enterprise.exe update --installPath "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise" --quiet --wait --norestart --channelUri c:\doesnotexist.chman
    ```

::: moniker-end

::: moniker range=">=vs-2022"

2. Update the Visual Studio application itself:
    ```shell
    vs_enterprise.exe update --installPath "C:\Program Files\Microsoft Visual Studio\2022\Enterprise" --quiet --wait --norestart --channelUri c:\doesnotexist.chman
    ```

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [How to define settings in a response file](automated-installation-with-response-file.md)
* [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
