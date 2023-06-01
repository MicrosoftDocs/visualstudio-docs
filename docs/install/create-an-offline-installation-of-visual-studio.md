---
title: Create an offline installation
description: Learn how to install Visual Studio offline when you have an unreliable internet connection or low bandwidth.
ms.date: 2/21/2023
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

We designed Visual Studio to work well in various network and computer configurations. For all scenarios involving the local machine, we recommend that you use the [Visual Studio Installer](https://visualstudio.microsoft.com/downloads), which is a small file that checks for updates on a regular basis and helps you stay current with all the latest fixes and features. The information on this page discusses how to create an offline installation package of files for installation on the **local machine**.

> [!NOTE]
> If you are an enterprise IT administrator who wants to perform a deployment of Visual Studio to a network of client workstations, or if you need to create an installation package of files to transfer to or install onto another machine, refer to our [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide) and the [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md) documentation.

## Use the "Download all, then install" feature
Sometimes online access is problematic. For example, you might have an unreliable internet connection or your internet connection may have low bandwidth. For situations like these, we've made other methods available for acquiring Visual Studio. You can use the **Download all, then install** feature from the Visual Studio Installer to download an installation package on the local machine before you install it locally, or you can use the command line to create a local installation package to install locally later.

To download a local installation package, select the **Download all, then install** option in the dropdown at the bottom of the **Workloads** tab of the Visual Studio Installer. The purpose of this feature is to frontload the downloading of the Visual Studio packages onto the same computer that you plan on eventually installing Visual Studio on. By downloading the packages locally first, you can then safely disconnect from the internet before you install Visual Studio.

   ![The "Download all, then install" option](media/vs-2019/download-all-then-install-from-installer.png)

> [!IMPORTANT]
> The **Download all, then install** functionality downloads a Visual Studio installation package that is customized to the local machine. Do not try to transfer this downloaded installation package to another computer, as it's not designed to work that way. Instead, if you want to download an installation package and transfer it to or install it on another machine, then you'll need to create a layout as described in the [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md) documentation.

You can also configure future updates of this instance of Visual Studio to respect the **Download all, then install** behavior. For more information, refer to the [Customize update settings](/visualstudio/install/update-visual-studio?#installation-and-download-behaviors-1) documentation.

## Use the command line to create a local layout

### Step 1 - Download the Visual Studio bootstrapper

[Download the correct bootstrapper for the version and edition of Visual Studio you want](create-a-network-installation-of-visual-studio.md#download-the-visual-studio-bootstrapper-to-create-the-network-layout) and copy it into the directory that you want to serve as the source location of your local layout. The bootstrapper is the executable that you use to create, update, and perform other Visual Studio installation operations. You must have an internet connection to complete this step. 


### Step 2 - Create a local layout

Open a command prompt with administrator privileges, navigate to the directory where you downloaded the bootstrapper, and use the [bootstrapper's parameters](use-command-line-parameters-to-install-visual-studio.md#layout-command-and-command-line-parameters) to create your local layout. Note that you must have an internet connection to complete this step. Common local layout creation examples using the Enterprise bootstrapper are illustrated below and on the [command-line parameter examples](command-line-parameter-examples.md) page. You can install a language other than English by changing `en-US` to a locale from the [list of language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales), and you can use a *vsconfig* file or the [list of components and workloads](workload-and-component-ids.md) to further customize your local layout.

> [!TIP]
> To prevent an error, make sure that your full installation path is less than 80 characters.

::: moniker range="<=vs-2019"
- For .NET web and .NET desktop development for only one language, run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional --lang en-US
    ```
::: moniker-end

::: moniker range=">=vs-2022"
- For .NET web and .NET desktop development for only one language, run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional --lang en-US
    ```
::: moniker-end

- For C++ desktop development including all recommended and optional components, for only one language run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.NativeDesktop --includeRecommended --includeOptional --lang en-US 
    ```

- To create a complete local layout with all features and all languages (this will take a long time&mdash;we have _lots_ of features!), run:

   ```shell
    vs_enterprise.exe --layout c:\localVSlayout
    ```
    
- To create a local layout using an [exported vsconfig file](import-export-installation-configurations.md) to customize the layout content, run the code below. Since this functionality is relatively new, you'll need to use the latest installer in your layout.   

   ```shell
    vs_enterprise.exe --layout C:\localVSlayout --config "C:\myconfig.vsconfig" --lang en-US 
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

Then use this command to run the installation and prevent the client machine from accessing the internet:

```shell
c:\localVSlayout\vs_enterprise.exe --noWeb --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Component.GitHub.VisualStudio --includeOptional
```

::: moniker-end

::: moniker range="vs-2022"

```shell
vs_enterprise.exe --layout c:\localVSlayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional --lang en-US
```

Then use this command to run the installation and prevent the client machine from accessing the internet:

```shell
c:\localVSlayout\vs_enterprise.exe --noWeb --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Workload.NetWeb --includeOptional
```

::: moniker-end

> [!IMPORTANT]
> If you're using Visual Studio Community, you might be prompted to sign in within 30 days of installation, but it won't impact your ability to use the product.

> [!NOTE]
> If you get an error that a signature is invalid, you must [install updated certificates](install-certificates-for-visual-studio-offline.md). Open the Certificates folder in your local layout. Double-click each of the certificate files, and then click through the Certificate Manager wizard. If you're asked for a password, leave it blank.


[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

- [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide)
- [Install certificates required for Visual Studio offline installation](../install/install-certificates-for-visual-studio-offline.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
- [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
