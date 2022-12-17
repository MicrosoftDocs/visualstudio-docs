---
title: Update Visual Studio while on a servicing baseline
description: Learn how to configure and update Visual Studio to stay on a servicing baseline.
ms.date: 2/4/2022
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
# DEPRECATED CONTENT Visual Studio and servicing baselines

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

   
>[!IMPORTANT]
> This content is deprecated because the functionaly it describes is contained on other pages, and the layout troubleshooting tips at the bottom are no longer necessary if you are using the [latest Visual Studio installer](create-a-network-installation-of-visual-studio.md#ensure-your-layout-is-using-the-latest-installer) which is also available to all versions of Visual Studio. The page only still exists so that links and browsing don't result in a broken experience. If you land on this page, please file a [Developer Community](https://aka.ms/vs/admin/feedback] bug report and tell us how you got here so that we can clean up the source links.

























Visual Studio is updated frequently during its product lifecycle. There are two main types of updates: feature updates and servicing updates. Feature updates are indicated by a change in the minor version number, such as 16.4 to 16.5, and they contain significant product updates. Servicing updates consist of critical quality or security fixes and they are denoted by a change in the servicing version number, such as 16.7.8 to 16.7.9. 

A servicing baseline, also referred to as a Long-Term Servicing Channel (LTSC) is a particular minor version that is supported and kept secure for about a year longer than other minor versions. The purpose of servicing baselines is to give Enterprise and Professional customers a way to adopt and stay on a very stable product and minimize compatibility risk while also staying secure. Refer to the [Visual Studio support lifecycle](/visualstudio/productinfo/vs-servicing) documentation for information about support for secure baselines.

## How to configure your client machine to stay on a servicing baseline

In Visual Studio 2019, it was a challenge to stay on a servicing baseline. You had to use the specific minor version bootstrapper available on either [My.VisualStudio.Com](https://my.visualstudio.com/Downloads) or the [Visual Studio 2019 release history page](/visualstudio/releases/2019/history) to update your client or your layout with the specific version you wanted. You also sometimes needed to perform additional customizations to fine tune the experience.  

In Visual Studio 2022, we vastly improved the experience of easily configuring a client machine to stay on a servicing baseline. Using the Visual Studio 2022 installer, which can also be used by older versions of Visual Studio such as Visual Studio 2019, you can now [configure where your clients will get their updates from](/visualstudio/install/update-visual-studio?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1) using the **Update settings** dialog or the `modifySettings` command. These update source locations are called "channels", and you can find more information about channel purpose and availability in the [Visual Studio Release Rhythm](/visualstudio/productinfo/release-rhythm) documentation. Microsoft makes both the Current and the Preview channels available to everyone, and the Long-Term Servicing Channels (LTSCs) are available to Enterprise and Professional customers. IT Administrators can also configure network layouts as valid update source locations that the clients could have access to. 

Under the covers, the update source location and corresponding notification flag is governed by the client's `--channelUri` value. 
   - For client machines that are attached to network layouts, this value is typically passed in via the `channelUri` value in the layout's customized response.json file. For more information, refer to [configuring client defaults when installing from a network layout](/visualstudio/install/create-a-network-installation-of-visual-studio?#configure-initial-client-installation-defaults-for-this-layout).
   - For client machines that have installed the product using a bootstrapper from the internet, you can disable both the update notifications and the ability for Visual Studio to update from the internet by passing in a non-existent channelURI when the product is originally installed (example below). This approach will prevent you from receiving notifications about security updates, so while it's possible to do, we don't recommend it.
   
```shell
vs_enterprise.exe --channelUri c:\doesnotexist.chman
```

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
