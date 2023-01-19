---
title: Create an offline installation
description: Learn how to install Visual Studio offline when you have an unreliable internet connection or low bandwidth.
ms.date: 1/20/2023
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
# Create an offline installation package of Visual Studio for local installation

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

We designed Visual Studio to work well in various network and computer configurations. For all scenarios involving the local machine, we recommend that you use the [Visual Studio Installer](https://visualstudio.microsoft.com/downloads), which is a small file that checks for updates on a regular basis and helps you stay current with all the latest fixes and features. The information on this page discusses how to create an offline installation package of files for installation on the local machine.

If you are an enterprise IT administrator who wants to perform a deployment of Visual Studio to a network of client workstations, or if you need to create an installation package of files to transfer to or install onto another machine, refer to our [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide) and the [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md) documentation.

## Use the "Download all, then install" feature
Sometimes online access is problematic. For example, you might have an unreliable internet connection or your internet connection may have low bandwidth. For situations like these, we've made other methods available for acquiring Visual Studio. You can use the **Download all, then install** feature from the Visual Studio Installer to download an installation package on the local machine before you install, or you can use the command line to create a local installation package to install later.

To download a local installation package, select the **Download all, then install** option in the dropdown at the bottom of the **Workloads** tab of the Visual Studio Installer. The purpose of this feature is to frontload the downloading of the Visual Studio packages onto the same computer that you plan on eventually installing Visual Studio on. By downloading the packages locally first, you can then safely disconnect from the internet before you install Visual Studio.

   ![The "Download all, then install" option](media/vs-2019/download-all-then-install-from-installer.png)

> [!IMPORTANT]
> The **Download all, then install** functionality downloads a Visual Studio installation package that is customized to the local machine. Do not try to transfer this downloaded installation package to another computer, as it's not designed to work that way. Instead, if you want to download an installation package and transfer it to or install it on another machine, then you'll need to create a layout as described in the [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md) documentation.

You can also configure future updates of this instance of Visual Studio to respect the **Download all, then install** behavior. For more information, refer to the [Customize update settings](/visualstudio/install/update-visual-studio?#installation-and-download-behaviors-1) documentation.

## Use the command line to create a local layout

Download the bootstrapper for the edition of Visual Studio you want and copy it into the directory that you want to serve as the source location of your local layout. Once the layout is created, you can use it to install Visual Studio. The bootstrapper is the executable that you use to create, update, and perform other Visual Studio installation operations. You must have an internet connection to complete this.

### Step 1 - Download the Visual Studio bootstrapper

::: moniker range="vs-2019"

The bootstrappers listed below will always install the latest most secure version of Visual Studio 2019, no matter when you run them. Alternatively, if you want to install a specific version of Visual Studio 2019, go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page that has links to the fixed version bootstrappers for each servicing release, and download the one you want. Copy it into the directory that you want to serve as the location of your local layout.

| Edition                         | Bootstrapper                                                                    |
|---------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2019 Professional version 16.11 | [vs_professional.exe](https://aka.ms/vs/16/release/vs_professional.exe) |
| Visual Studio 2019 Enterprise version 16.11 | [vs_enterprise.exe](https://aka.ms/vs/16/release/vs_enterprise.exe) |
| Visual Studio 2019 Build Tools version 16.11 | [vs_buildtools.exe](https://aka.ms/vs/16/release/vs_buildtools.exe) |

::: moniker-end

::: moniker range="vs-2022"

The bootstrappers listed below will always install the latest most secure version of Visual Studio 2022 on the Current channel, no matter when you run them. Alternatively, if you want to install a specific version or a specific channel of Visual Studio 2022, go to the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page that has links to the evergreen and fixed version bootstrappers for each servicing release on each channel, and download the one you want. Copy it into the directory that you want to serve as the location of your local layout.

| Edition                         | Bootstrapper                                                            |
|---------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2022 Community    | [vs_community.exe](https://aka.ms/vs/17/release/vs_community.exe)       |
| Visual Studio 2022 Professional | [vs_professional.exe](https://aka.ms/vs/17/release/vs_professional.exe) |
| Visual Studio 2022 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/release/vs_enterprise.exe)     |
| Visual Studio 2022 Build Tools   | [vs_buildtools.exe](https://aka.ms/vs/17/release/vs_buildtools.exe)    |

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a specific bootstrapper file and want to verify what version it will install, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the table at the bottom of the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history) page.

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it will install, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties** and then choose the **Details** tab. The **Product version** field will describe the [channel and version](/visualstudio/releases/2022/vs2022-release-rhythm) that the bootstrapper will install. The version number should always be read as "latest servicing version of what is specified", and the channel is Current unless explicitly specified. So, a bootstrapper with a Product version of LTSC 17.0 will install the latest 17.0.x servicing release that is available on the 17.0 LTSC channel. A bootstrapper with a Product version that simply says Visual Studio 2022 will install the latest version of Visual Studio 2022 on the Current channel.

::: moniker-end

### Step 2 - Create a local layout

You must have an internet connection to complete this step.

Open a command prompt with administrator privileges, navigate to the directory where you downloaded the bootstrapper into, and use the bootstrapper's parameters as defined in the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page to create your local layout. Common examples using the Enterprise bootstrapper are illustrated below and in the [command-line parameter examples](command-line-parameter-examples.md) page. You can install a language other than English by changing `en-US` to a locale from the [list of language locales](#list-of-language-locales), and you can use the [list of components and workloads](workload-and-component-ids.md) to further customize your local layout.

> [!TIP]
> To prevent an error, make sure that your full installation path is less than 80 characters.

::: moniker range="<=vs-2019"
- For .NET web and .NET desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
    ```
::: moniker-end

::: moniker range=">=vs-2022"
- For .NET web and .NET desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional --lang en-US
    ```
::: moniker-end

- For .NET desktop and Office development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.Office --includeOptional --lang en-US
    ```

- For C++ desktop development, run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.NativeDesktop --includeRecommended --lang en-US
    ```

- To create a complete local layout, English only, with all features (this will take a long time&mdash;we have _lots_ of features!), run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --lang en-US
    ```

- You can also [verify](create-a-network-installation-of-visual-studio.md?#verify-a-layout) or [fix](create-a-network-installation-of-visual-studio.md?#fix-a-layout) an offline installation.

::: moniker range="vs-2019"

   > [!NOTE]
   > A complete local layout of Visual Studio requires a minimum of 41 GB of disk space. For more information, see [System requirements](/visualstudio/releases/2019/system-requirements/).

::: moniker-end

::: moniker range="vs-2022"

   > [!NOTE]
   > A complete local layout of Visual Studio requires a minimum of 45 GB of disk space. For more information, see [System requirements](/visualstudio/releases/2022/system-requirements/).

::: moniker-end

### Step 3 - Install Visual Studio from the local layout
When you install Visual Studio from a local layout, the Visual Studio installer uses the local versions of the files. But, if you select components during installation that aren't in the layout, then the Visual Studio installer will attempt to download them from the internet. To make sure that you install only the files that you've previously downloaded, use the same [command-line options](use-command-line-parameters-to-install-visual-studio.md) that you used to create the local layout. To make sure your installer doesn't try to access the internet when it's installing the product, use the `--noweb` switch.

For example, if you created a local installation layout with the following command:

::: moniker range="<=vs-2019"

```shell
vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
```

Then use this command to run the installation:

```shell
c:\localVSlayout\vs_enterprise.exe --noweb --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional
```

::: moniker-end

::: moniker range="vs-2022"

```shell
vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional --lang en-US
```

Then use this command to run the installation:

```shell
c:\localVSlayout\vs_enterprise.exe --noweb --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional
```

::: moniker-end

> [!IMPORTANT]
> If you're using Visual Studio Community, you might be prompted to sign in within 30 days of installation, but it won't impact your ability to use the product.

> [!NOTE]
> If you get an error that a signature is invalid, you must [install updated certificates](install-certificates-for-visual-studio-offline.md). Open the Certificates folder in your local layout. Double-click each of the certificate files, and then click through the Certificate Manager wizard. If you're asked for a password, leave it blank.

### List of language locales

| **Language-locale** | **Language**          |
|---------------------|-----------------------|
|:::no-loc text="cs-CZ":::                | Czech                 |
|:::no-loc text="de-DE":::                | German                |
|:::no-loc text="en-US":::                | English               |
|:::no-loc text="es-ES":::                | Spanish               |
|:::no-loc text="fr-FR":::                | French                |
|:::no-loc text="it-IT":::                | Italian               |
|:::no-loc text="ja-JP":::                | Japanese              |
|:::no-loc text="ko-KR":::                | Korean                |
|:::no-loc text="pl-PL":::                | Polish                |
|:::no-loc text="pt-BR":::                | Portuguese - Brazil   |
|:::no-loc text="ru-RU":::                | Russian               |
|:::no-loc text="tr-TR":::                | Turkish               |
|:::no-loc text="zh-CN":::                | Chinese - Simplified  |
|:::no-loc text="zh-TW ":::               | Chinese - Traditional |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

- [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide)
- [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
