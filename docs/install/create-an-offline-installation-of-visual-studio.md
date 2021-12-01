---
title: Create an offline installation
description: Learn how to install Visual Studio offline when you have an unreliable internet connection or low bandwidth.
ms.date: 11/23/2021
ms.topic: conceptual
f1_keywords:
- offline installation [Visual Studio]
- offline install [Visual Studio]
- layout [Visual Studio]
ms.assetid: f8625d5e-f6ea-4db0-83c0-619b77fab3cf
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Create an offline installation of Visual Studio

We designed Visual Studio to work well in various network and computer configurations. We recommend that you use the [Visual Studio Installer](https://visualstudio.microsoft.com/downloads), which is a small file that checks for online updates on a regular basis and helps you stay current with all the latest fixes and features. However, sometimes online access is problematic. For example, you might have an unreliable internet connection or your internet connection may have low bandwidth. For situations like these, we've made a few other methods available for acquiring Visual Studio. You can use the **Download all, then install** feature from the Visual Studio Installer to download the files to a local cache on the local machine before you install, or you can use the command line to create a local cache of the files to install later.

> [!NOTE]
> If you are an enterprise IT administrator who wants to perform a deployment of Visual Studio to a network of client workstations, refer to our [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide) and the [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md) documentation.

## Use the "Download all, then install" feature

In the Visual Studio Installer, on the **Workloads** tab, you can select the **Download all, then install** option in the dropdown at the bottom of the dialog. The purpose of this feature is to frontload the downloading of the Visual Studio packages onto the same computer that you plan on eventually installing Visual Studio on. By downloading the packages into a local cache first, you can then safely disconnect from the internet before you install Visual Studio.

   ![The "Download all, then install" option](media/vs-2019/download-all-then-install-from-installer.png)

> [!IMPORTANT]
> Do not use the **Download all, then install** feature to create a local cache that you intend to transfer to another computer. It's not designed to work that way. 

You can also configure your updates to respect the **Download all, then install** behavior. For more information, refer to the [Customize update settings](/visualstudio/install/update-visual-studio?#installation-and-download-behaviors-1) documentation.

## Use the command line to create a local cache

You can download a small bootstrapper file, and then use the command line to create a local cache. Once the cache is created, you can use it to install Visual Studio. 

### Step 1 - Download the Visual Studio bootstrapper

You must have an internet connection to complete this step.

::: moniker range="vs-2017"

To get the latest bootstrappers for Visual Studio 2017 version 15.9, download one of the files below. These bootstrappers will always install the latest version of Visual Studio 2017, no matter when you run them.

| Edition                                      | Bootstrapper            |
|----------------------------------------------|---------------------|
| Visual Studio 2017 Professional version 15.9 | [vs_professional.exe](https://aka.ms/vs/15/release/vs_professional.exe) |
| Visual Studio 2017 Enterprise version 15.9   | [vs_enterprise.exe](https://aka.ms/vs/15/release/vs_enterprise.exe)   |
| Visual Studio 2017 Build Tools version 15.9  | [vs_buildtools.exe](https://aka.ms/vs/15/release/vs_buildtools.exe)   |

::: moniker-end

::: moniker range="vs-2019"

To get the latest bootstrappers for Visual Studio 2019 that will always install the latest version of 16.11, download one of the files below. Alternatively, if you want to install a specific version of Visual Studio 2019, go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page that has links to the fixed version bootstrappers for each servicing release. 

| Edition                         | Bootstrapper                                                                    |
|---------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2019 Professional version 16.11 | [vs_professional.exe](https://aka.ms/vs/16/release/vs_professional.exe) |
| Visual Studio 2019 Enterprise version 16.11 | [vs_enterprise.exe](https://aka.ms/vs/16/release/vs_enterprise.exe) |
| Visual Studio 2019 Build Tools version 16.11 | [vs_buildtools.exe](https://aka.ms/vs/16/release/vs_buildtools.exe) |

::: moniker-end

::: moniker range="vs-2022"

To get the latest bootstrappers for Visual Studio 2022 that will always install the latest version of the Current channel, download one of the files below. Alternatively, if you want to install a specific version or a specific channel of Visual Studio 2022, go to the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page that has links to the fixed version bootstrappers for each servicing release. 

| Edition                         | Bootstrapper                                                               |
|---------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2022 Community    | [vs_community.exe](https://aka.ms/vs/17/release/vs_community.exe)       |
| Visual Studio 2022 Professional | [vs_professional.exe](https://aka.ms/vs/17/release/vs_professional.exe) |
| Visual Studio 2022 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/release/vs_enterprise.exe)     |
| Visual Studio 2022 Build Tools   | [vs_buildtools.exe](https://aka.ms/vs/17/release/vs_buildtools.exe)         |

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a specific bootstrapper file from the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#release-dates-and-build-numbers) page and want to verify what version it will install, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the table at the bottom of that page.

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it will install, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties** and then choose the **Details** tab. The **Product version** field will describe the [channel and version](/visualstudio/releases/2022/vs2022-release-rhythm) that the bootstrapper will install. The version number should always be read as "latest servicing version of what is specified", and the channel is Current unless explicitly specified. So, a bootstrapper with a Product version of LTSC 17.0 will install the latest 17.0.x servicing release that is available on the 17.0 LTSC channel. A bootstrapper with a Product version that simply says Visual Studio 2022 will install the latest version of Visual Studio 2022 on the Current channel.

::: moniker-end

### Step 2 - Create a local install cache

You must have an internet connection to complete this step.

Open a command prompt and use the bootstrapper's parameters as defined in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page to create your local installation cache. Common examples using the Enterprise bootstrapper are illustrated below and in the [command-line parameter examples](command-line-parameter-examples.md) page. You can install a language other than English by changing `en-US` to a locale from the [list of language locales](#list-of-language-locales), and you can use the [list of components and workloads](workload-and-component-ids.md) to further customize your local cache.

> [!TIP]
> To prevent an error, make sure that your full installation path is less than 80 characters.

::: moniker range="<=vs-2019"
- For .NET web and .NET desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVScache --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
    ```
::: moniker-end

::: moniker range=">=vs-2022"
- For .NET web and .NET desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVScache --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional --lang en-US
    ```
::: moniker-end

- For .NET desktop and Office development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVScache --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.Office --includeOptional --lang en-US
    ```

- For C++ desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVScache --add Microsoft.VisualStudio.Workload.NativeDesktop --includeRecommended --lang en-US
    ```

- To create a complete local cache, English only, with all features (this will take a long time&mdash;we have _lots_ of features!), run:

   ```shell
    vs_enterprise.exe --layout c:\localVScache --lang en-US
    ```

::: moniker range="vs-2017"

   > [!NOTE]
   > A complete local cache of Visual Studio requires a minimum of 35 GB of disk space. For more information, see [System requirements](/visualstudio/productinfo/vs2017-system-requirements-vs/). 

::: moniker-end

::: moniker range="vs-2019"

   > [!NOTE]
   > A complete local cache of Visual Studio requires a minimum of 41 GB of disk space. For more information, see [System requirements](/visualstudio/releases/2019/system-requirements/).

::: moniker-end

::: moniker range="vs-2022"

   > [!NOTE]
   > A complete local cache of Visual Studio requires a minimum of 45 GB of disk space. For more information, see [System requirements](/visualstudio/releases/2022/system-requirements/).

::: moniker-end

### Step 3 - Install Visual Studio from the local cache
When you install Visual Studio from a local install cache, the Visual Studio installer uses the local cached versions of the files. But, if you select components during installation that aren't in the cache, then the Visual Studio installer will attempt to download them from the internet. To make sure that you install only the files that you've previously downloaded, use the same [command-line options](use-command-line-parameters-to-install-visual-studio.md) that you used to create the local cache. To make sure your installer doesn't try to access the internet, use the `--noweb` switch.

For example, if you created a local installation cache with the following command:

::: moniker range="<=vs-2019"

```shell
vs_enterprise.exe --layout c:\localVScache --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
```

Then use this command to run the installation:

```shell
c:\localVScache\vs_enterprise.exe --noweb --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional
```

::: moniker-end

::: moniker range="vs-2022"

```shell
vs_enterprise.exe --layout c:\localVScache --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional --lang en-US
```

Then use this command to run the installation:

```shell
c:\localVScache\vs_enterprise.exe --noweb --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional
```

::: moniker-end

> [!IMPORTANT]
> If you're using Visual Studio Community, you must activate it by logging into the product within 30 days of installation. Activation requires an internet connection.

> [!NOTE]
> If you get an error that a signature is invalid, you must [install updated certificates](install-certificates-for-visual-studio-offline.md). Open the Certificates folder in your local cache. Double-click each of the certificate files, and then click through the Certificate Manager wizard. If you're asked for a password, leave it blank.


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

- [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide)
- [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
