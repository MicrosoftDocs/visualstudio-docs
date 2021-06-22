---
title: Create an offline installation
description: Learn how to install Visual Studio offline when you have an unreliable internet connection or low bandwidth.
ms.date: 4/16/2021
ms.custom: seodec18
ms.topic: conceptual
f1_keywords:
- offline installation [Visual Studio]
- offline install [Visual Studio]
- layout [Visual Studio]
ms.assetid: f8625d5e-f6ea-4db0-83c0-619b77fab3cf
author: j-martens
ms.author: jmartens
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Create an offline installation of Visual Studio

::: moniker range="vs-2017"

We designed Visual Studio 2017 to work well in a variety of network and computer configurations. While we recommend that you try the [Visual Studio web installer](https://visualstudio.microsoft.com/vs/older-downloads)&mdash;which is a small file that allows you to stay current with all the latest fixes and features&mdash;we understand that you might not be able to.

::: moniker-end

::: moniker range=">=vs-2019"

We designed Visual Studio 2019 and later to work well in a variety of network and computer configurations. While we recommend that you try the [Visual Studio web installer](https://visualstudio.microsoft.com/downloads)&mdash;which is a small file that allows you to stay current with all the latest fixes and features&mdash;we understand that you might not be able to.

::: moniker-end

For example, you might have an unreliable internet connection or one that has low bandwidth. If so, you have a few options: You can use the new "Download all, then install" feature to download the files before you install, or you can use the command line to create a local cache of the files.

> [!NOTE]
> If you are an enterprise administrator who wants to perform a deployment of Visual Studio to a network of client workstations that are firewalled from the internet, see our [Create a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md) and [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md) pages.

## Use the "Download all, then install" feature

::: moniker range="vs-2017"

[**New in version 15.8**](/visualstudio/releasenotes/vs2017-relnotes-v15.8#install): After you download the web installer, select the new **Download all, then install** option from the Visual Studio Installer. Then, continue with your installation.

   ![The "Download all, then install" option](media/download-all-then-install.png)

::: moniker-end

::: moniker range=">=vs-2019"

After you download the web installer, select the new **Download all, then install** option from the Visual Studio Installer. Then, continue with your installation.

   ![The "Download all, then install" option](media/vs-2019/download-all-then-install-from-installer.png)

::: moniker-end

We designed the "Download all, then install" feature so that you can download Visual Studio as a single installation for the same computer on which you downloaded it. That way, you can safely disconnect from the web before you install Visual Studio.

> [!IMPORTANT]
> Do not use the "Download all, then install" feature to create an offline cache that you intend to transfer to another computer. It's not designed to work that way. <br><br>If you want to create an offline cache on the local computer that you can then use to install Visual Studio, see the [Use the command line to create a local cache](#use-the-command-line-to-create-a-local-cache) section below.  Alternatively, the [Create a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md) page provides information about how to create a cache on the network.

## Use the command line to create a local cache
::: moniker range="vs-2017"

After you download a small bootstrapper, use the command line to create a local cache. Then, use the local cache to install Visual Studio. (This process replaces the ISO files that were available for previous versions). 

::: moniker-end

::: moniker range=">=vs-2019"

After you download a small bootstrapper file, use the command line to create a local cache. Then, use the local cache to install Visual Studio.

::: moniker-end

### Step 1 - Download the Visual Studio bootstrapper

You must have an internet connection to complete this step.

::: moniker range="vs-2017"

To get the latest bootstrapper for Visual Studio 2017 version 15.9, go to the [Visual Studio previous versions](https://visualstudio.microsoft.com/vs/older-downloads/) page and download one of the following bootstrapper files:

| Edition                                      | Filename            |
|----------------------------------------------|---------------------|
| Visual Studio Professional 2017 version 15.9 | vs_professional.exe |
| Visual Studio Enterprise 2017 version 15.9   | vs_enterprise.exe   |
| Visual Studio Build Tools 2017 version 15.9  | vs_buildtools.exe   |

::: moniker-end

::: moniker range="vs-2019"

Start by downloading the Visual Studio 2019 bootstrapper from either the [Visual Studio downloads page](https://visualstudio.microsoft.com/downloads) or the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page for your chosen version and edition of Visual Studio. Your setup file&mdash;or bootstrapper&mdash;will match or be similar to one of the following:

| Edition                         | File                                                                                                                                                                                                                               |
|---------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Visual Studio 2019 Community    | [vs_community.exe](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=community&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=offline+install&utm_content=download+vs2019)       |
| Visual Studio 2019 Professional | [vs_professional.exe](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=professional&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=offline+install&utm_content=download+vs2019) |
| Visual Studio 2019 Enterprise   | [vs_enterprise.exe](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=enterprise&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=offline+install&utm_content=download+vs2019)     |
| Visual Studio 2019 Build Tools  | [vs_buildtools.exe](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=buildtools&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=offline+install&utm_content=download+vs2019)     |

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
> Released versions of Visual Studio 2022 are not yet available, the bootstrappers below are for the preview release of Visual Studio 2022.
>Start by downloading the Visual Studio 2022 bootstrapper from the [Visual Studio downloads page](https://aka.ms/vs2022preview).

| Edition                         | Download                                                            |
|---------------------------------|---------------------------------------------------------------------|
| Visual Studio 2022 Professional | [vs_professional.exe](https://aka.ms/vs/17/pre/vs_professional.exe) |
| Visual Studio 2022 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/pre/vs_enterprise.exe)     |

::: moniker-end

::: moniker range="vs-2017"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it is, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the [Visual Studio build numbers and release dates](/visual-studio-build-numbers-and-release-dates.md) page.

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify its version, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history) page.

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify its version, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the [Visual Studio 2022 Releases](/visualstudio/releases/2022/history) page.

::: moniker-end

### Step 2 - Create a local install cache

You must have an internet connection to complete this step.

Open a command prompt and use the bootstrapper's parameters as defined in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page to create your local installation cache. Common examples using the Enterprise bootstrapper are illustrated below and in the [command-line parameter examples](command-line-parameter-examples.md) page. You can install a language other than English by changing `en-US` to a locale from the [list of language locales](#list-of-language-locales), and you can use the [list of components and workloads](workload-and-component-ids.md) to further customize your cache.

> [!TIP]
> To prevent an error, make sure that your full installation path is less than 80 characters.

- For .NET web and .NET desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\vslayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
    ```

- For .NET desktop and Office development, run:

   ```shell
    vs_enterprise.exe --layout c:\vslayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.Office --includeOptional --lang en-US
    ```

- For C++ desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\vslayout --add Microsoft.VisualStudio.Workload.NativeDesktop --includeRecommended --lang en-US
    ```

- To create a complete local layout, English only, with all features (this will take a long time&mdash;we have _lots_ of features!), run:

   ```shell
    vs_enterprise.exe --layout c:\vslayout --lang en-US
    ```

::: moniker range="vs-2017"

   > [!NOTE]
   > A complete Visual Studio layout requires a minimum of 35 GB of disk space. For more information, see [System requirements](/visualstudio/productinfo/vs2017-system-requirements-vs/). 

::: moniker-end

::: moniker range=">=vs-2019"

   > [!NOTE]
   > A complete Visual Studio layout requires a minimum of 41 GB of disk space. For more information, see [System requirements](/visualstudio/releases/2019/system-requirements/).

::: moniker-end


### Step 3 - Install Visual Studio from the local cache
When you install Visual Studio from a local install cache, the Visual Studio installer uses the local cached versions of the files. But, if you select components during installation that aren't in the cache, then the Visual Studio installer will attempt to download them from the internet. To make sure that you install only the files that you've previously downloaded, use the same [command-line options](use-command-line-parameters-to-install-visual-studio.md) that you used to create the layout cache. 

For example, if you created a local installation cache with the following command:

```shell
vs_enterprise.exe --layout c:\vslayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
```

Then use this command to run the installation:

```shell
c:\vslayout\vs_enterprise.exe --noweb --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional
```

> [!IMPORTANT]
> If you're using Visual Studio Community, you must activate it by logging into the product within 30 days of installation. Activation requires an internet connection.

> [!NOTE]
> If you get an error that a signature is invalid, you must [install updated certificates](install-certificates-for-visual-studio-offline.md). Open the Certificates folder in your offline cache. Double-click each of the certificate files, and then click through the Certificate Manager wizard. If you're asked for a password, leave it blank.

::: moniker range=">=vs-2019"
> [!TIP]
> For offline installations, if you get an error message that says "A product matching the following parameters cannot be found", make sure that you are using the `--noweb` switch with version 16.3.5 or later.

::: moniker-end

### List of language locales

| **Language-locale** | **Language**          |
|---------------------|-----------------------|
| cs-CZ               | Czech                 |
| de-DE               | German                |
| en-US               | English               |
| es-ES               | Spanish               |
| fr-FR               | French                |
| it-IT               | Italian               |
| ja-JP               | Japanese              |
| ko-KR               | Korean                |
| pl-PL               | Polish                |
| pt-BR               | Portuguese - Brazil   |
| ru-RU               | Russian               |
| tr-TR               | Turkish               |
| zh-CN               | Chinese - Simplified  |
| zh-TW               | Chinese - Traditional |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

- [Create a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md)
- [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
- [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
