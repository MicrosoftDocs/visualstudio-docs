---
title: Create a network-based installation
description: Learn how to create a network install point for deploying Visual Studio within an enterprise.
ms.date: 04/06/2021
ms.custom: seodec18
ms.topic: conceptual
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 4CABFD20-962E-482C-8A76-E4012052F701
author: j-martens
ms.author: jmartens
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Create a network installation of Visual Studio

Sometimes an enterprise administrator wants to create a network install point that contains Visual Studio files that can be deployed to client workstations. This is to facilitate scenarios where the client machines may have limited permissions or limited access to the internet, or when internal teams want to do compatibility testing before their organization standardizes on a particular version of the developer toolset. We've designed Visual Studio so that an administrator can _create a network layout_ which is essentially creating a file cache located on an internal static network share that includes all the Visual Studio files for both initial installation and all future product updates.

 > [!NOTE]
 >  - If you have multiple editions of Visual Studio in use within your enterprise (for example, both Visual Studio 2019 Professional and Visual Studio 2019 Enterprise), you must create a separate network install share for each edition.
 >  - We recommend that you decide how you want the clients to receive product updates _before_ you do the initial client install.  This makes it easier to ensure that your configuration options are set correctly. Your choices include having the clients get updates from the network layout location or from the internet. 
 >  - The original Visual Studio installation layout and all subsequent product updates must be located in the same network directory to ensure that repair and uninstall functionality works properly.

## Download the Visual Studio bootstrapper

Download a bootstrapper file for the edition of Visual Studio you want. Make sure to choose **Save**, and then choose **Open folder**.

::: moniker range="vs-2017"

To get the latest bootstrapper for Visual Studio 2017 version 15.9, go to the [Visual Studio previous versions](https://visualstudio.microsoft.com/vs/older-downloads/) page and download one of the following bootstrapper files:

| Edition                                      | Filename            |
|----------------------------------------------|---------------------|
| Visual Studio 2017 Enterprise version 15.9   | vs_enterprise.exe   |
| Visual Studio 2017 Professional version 15.9 | vs_professional.exe |
| Visual Studio 2017 Build Tools version 15.9  | vs_buildtools.exe   |

Other supported bootstrappers include vs_feedbackclient.exe, vs_teamexplorer.exe, vs_testagent.exe, vs_testcontroller.exe, and vs_testprofessional.exe.

::: moniker-end

::: moniker range="vs-2019"

Start by downloading the Visual Studio 2019 bootstrapper from either the [Visual Studio downloads page](https://visualstudio.microsoft.com/downloads) or the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page for your chosen version and edition of Visual Studio.  Your setup executable&mdash;or to be more specific, a bootstrapper file&mdash;will match or be similar to one of the following:

| Edition                    | Download                                                                                                                                                                                                                           |
|----------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Visual Studio Enterprise   | [vs_enterprise.exe](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=enterprise&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=network+install&utm_content=download+vs2019)     |
| Visual Studio Professional | [vs_professional.exe](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=professional&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=network+install&utm_content=download+vs2019) |
| Visual Studio Build Tools  | [vs_buildtools.exe](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=buildtools&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=offline+install&utm_content=download+vs2019)     |

Other supported bootstrappers include [vs_teamexplorer.exe](https://download.visualstudio.microsoft.com/download/pr/f6473c9f-a5f6-4249-af28-c2fd14b6a0fb/4026077127d25d33789f3882998266946608d8ada378b6ed7c8fff8c07f3dde2/vs_TeamExplorer.exe), [vs_testagent.exe](https://download.visualstudio.microsoft.com/download/pr/f6473c9f-a5f6-4249-af28-c2fd14b6a0fb/1383bf8bcda3d0e986a2e42c14114aaea8a7b085d31aa0623c9f70b2bad130e4/vs_TestAgent.exe), and [vs_testcontroller.exe](https://download.visualstudio.microsoft.com/download/pr/f6473c9f-a5f6-4249-af28-c2fd14b6a0fb/54dcf24b76e7cd9fb8be0ac518a9dfba6daf18fe9b2aa1543411b1cda8820918/vs_TestController.exe).

::: moniker-end

::: moniker range=">=vs-2022"

>![!TIP]
> Released versions of Visual Studio 2022 are not yet available, the bootstrappers below are for the preview release of Visual Studio 2022.
Start by downloading the Visual Studio 2022 bootstrapper from the [Visual Studio downloads page](https://aka.ms/vs2022preview).

| Edition                    | Download                                                                             |
|----------------------------|--------------------------------------------------------------------------------------|
| Visual Studio Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/preview/bootstrapper/vs_enterprise.exe)     |
| Visual Studio Professional | [vs_professional.exe](https://aka.ms/vs/17/preview/bootstrapper/vs_professional.exe) |

::: moniker-end

::: moniker range="vs-2017"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it is, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, see [Visual Studio build numbers and release dates](visual-studio-build-numbers-and-release-dates.md).

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it is, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, see [Visual Studio 2019 Releases](/visualstudio/releases/2019/history).

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it is, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, see [Visual Studio 2022 Releases](/visualstudio/releases/2022/history).

::: moniker-end

## Create an offline installation folder

You must have an internet connection to complete this step.

Open a command prompt, navigate to the directory that you downloaded the bootstrapper into, and use the bootstrapper's parameters as defined in the [Use command-line parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) page to create and maintain your network installation cache. Common examples of creating initial layouts are illustrated below and in [Command-line parameter examples for Visual Studio installation](../install/command-line-parameter-examples.md).  

   > [!IMPORTANT]
   > A complete initial layout for a single language locale requires about 35 GB of disk space for Visual Studio Community and 42 GB for Visual Studio Enterprise. Additional [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales) require about half a GB each. See the [Customize the network layout](#customize-the-network-layout) section for more info. Be mindful that subsequent layout updates must also be stored in this same network location, so expect that the directory contents of the network layout location can get quite large over time.  

- To create an initial layout of Visual Studio Enterprise with all languages and all features, run:

  ```vs_enterprise.exe --layout c:\VSLayout```

- To create an initial layout of Visual Studio Professional with all languages and all features, run:

  ```vs_professional.exe --layout c:\VSLayout```

## Modify the response.json file

You can modify the `response.json` file to set default values that are used when setup is run.  For example, you can configure the `response.json` file to select a specific set of workloads that should be selected automatically. You can also configure the `response.json` to specify if the client should only receive updated files from the network layout location. For more information, see [Automate Visual Studio installation with a response file](../install/automated-installation-with-response-file.md). 

If you run into a problem with the Visual Studio bootstrapper throwing an error when you pair it with a `response.json` file, see [Troubleshoot network-related errors when you install or use Visual Studio](../install/troubleshooting-network-related-errors-in-visual-studio.md#error-failed-to-parse-id-from-parent-process) page for more information.

## Copy the layout to a network share

Host the layout on a network share so it can be run from the client machines.

The following example uses [`xcopy`](/windows-server/administration/windows-commands/xcopy/). You can also use [`robocopy`](/windows-server/administration/windows-commands/robocopy/), should you wish.

::: moniker range="vs-2017"

Example:

```shell
xcopy /e c:\VSLayout \\server\products\VS2017
```

::: moniker-end

::: moniker range="vs-2019"

```shell
xcopy /e c:\VSLayout \\server\products\VS2019
```

::: moniker-end

::: moniker range=">=vs-2022"

```shell
xcopy /e c:\VSLayout \\server\products\VS2022
```

::: moniker-end

> [!IMPORTANT]
> To prevent an error, make sure that your full layout path is less than 80 characters.

## Customize the network layout

There are several options you can use to customize your network layout. You can create a partial layout that only contains a specific set of [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales), [workloads, components, and their recommended or optional dependencies](workload-and-component-ids.md). This might be useful if you know that you're going to deploy only a subset of workloads to client workstations. Typical command-line parameters for customizing the layout include:

* `--add` to specify [workload or component IDs](workload-and-component-ids.md). <br>If `--add` is used, only those workloads and components specified with `--add` are downloaded.  If `--add` isn't used, all workload and components are downloaded.
* `--includeRecommended` to include all the recommended  components for the specified workload IDs
* `--includeOptional` to include all the recommended and optional components for the specified workload IDs.
* `--lang` to specify [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales).

Here are a few examples of how to create a custom partial layout.

* To download all workloads and components for only one language, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --lang en-US
    ```

* To download all workloads and components for multiple languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --lang en-US de-DE ja-JP
    ```

* To download one workload for all languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --includeRecommended
    ```

* To download two workloads and one optional component for three languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeRecommended --lang en-US de-DE ja-JP
    ```

* To download two workloads and all of their recommended components:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeRecommended
    ```

* To download two workloads and all of their recommended and optional components, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeOptional
    ```

### Save your layout options

When you run a layout command, the options that you specify are saved (such as the workloads and languages). Subsequent layout commands will include all of the previous options.  Here is an example of a layout with one workload for English only:

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --lang en-US
```

When you want to update that layout to a newer version, you don't have to specify any additional command-line parameters. The previous settings are saved and used by any subsequent layout commands in this layout folder.  The following command will update the existing partial layout.

```shell
vs_enterprise.exe --layout c:\VSLayout
```

When you want to add an additional workload, here's an example of how to do so. In this case, we'll add the Azure workload and a localized language.  Now, both Managed Desktop and Azure are included in this layout.  The language resources for English and German are included for all these workloads. The layout is updated to the latest available version.

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --lang de-DE
```

If you want to update an existing layout to a full layout, use the --all option, as shown in the following example.

```shell
vs_enterprise.exe --layout c:\VSLayout --all
```

## Deploy from a network installation

Administrators can deploy Visual Studio onto client workstations as part of an installation script. Or, users who have administrator rights can run setup directly from the share to install Visual Studio on their machine.

* Users can install by running the following command: <br>

    ```shell
    \\server\products\VS\vs_enterprise.exe
    ```

* Administrators can install in an unattended mode by running the following command:

    ```shell
    \\server\products\VS\vs_enterprise.exe --quiet --wait --norestart
    ```

> [!IMPORTANT]
> To prevent an error, make sure that your full layout path is less than 80 characters.

> [!TIP]
> When executed as part of a batch file, the `--wait` option ensures that the `vs_enterprise.exe` process waits until the installation is complete before it returns an exit code.
>
> This is useful if an enterprise administrator wants to perform further actions on a completed installation (for example, to [apply a product key to a successful installation](automatically-apply-product-keys-when-deploying-visual-studio.md)) but must wait for the installation to finish to handle the return code from that installation.
>
> If you do not use `--wait`, the `vs_enterprise.exe` process exits before the installation is complete and returns an inaccurate exit code that doesn't represent the state of the install operation.
>

::: moniker range=">=vs-2019"
> [!IMPORTANT]
> For offline installations, if you get an error message that says "A product matching the following parameters cannot be found", make sure that you are using the `--noweb` switch with version 16.3.5 or later.
>
::: moniker-end

When you install from a layout, the content that is installed is acquired from the layout. However, if you select a component that isn't in the layout, it will be acquired from the internet.  If you want to prevent Visual Studio setup from downloading any content that is missing in your layout, use the `--noWeb` option. If `--noWeb` is used and the layout is missing any content that is selected to be installed, setup fails.

> [!TIP]
> If you want to install from an offline source on a non-internet connected computer, specify both the `--noWeb` and `--noUpdateInstaller` options. The former prevents downloading updated workloads, components, and so on. The latter prevents the installer from self-updating from the web.

> [!IMPORTANT]
> The `--noWeb` option does not stop Visual Studio setup on an internet-connected computer from checking for updates. For more information, see the [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md) page.

### Error codes

If you used the `--wait` parameter, then depending on the result of the operation, the `%ERRORLEVEL%` environment variable is set to one of the following values:

[!INCLUDE[install-error-codes-md](includes/install-error-codes-md.md)]

## Update a network install layout

As product updates become available, you might want to [update the network install layout](update-a-network-installation-of-visual-studio.md) to incorporate updated packages.

## How to create a layout for a previous Visual Studio release

First you need to understand that there are two types of Visual Studio bootstrappers - one that can be characterized by the words "latest", "current", "evergreen" and "tip", and one that essentially means "fixed version". Both types of bootstrapper files have the exact same name, and the best way to distinguish the type is to pay attention to where you got it from. The Visual Studio bootstrappers available on the [Visual Studio downloads page](https://visualstudio.microsoft.com/downloads) are considered evergreen Visual Studio bootstrappers, and they always install (or update) the latest release that's available in the channel at the time the bootstrapper is run. The Visual Studio bootstrappers available on the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history) [Visual Studio 2022 Releases](/visualstudio/releases/2022/history)  page, or that are embedded inside the administrator update in the Microsoft Update Catalog install a particular fixed version of the product.

So, if you download an evergreen Visual Studio bootstrapper today and run it six months from now, it will install the Visual Studio release that is current at the time the bootstrapper is run. It's designed to always install the latest bits and keep you current.

If you download a fixed-link bootstrapper, or if you run an administrator update that you downloaded from the Microsoft Catalog, then it will always install a particular version of the product, no matter when it was run.

Lastly, you can create a network layout using any one of these bootstrappers, and the version that will get created in the layout depends on the bootstrapper you're using, for example, it will either be a fixed version or current. You can then update the network layout using any later bootstrapper or you can also use the administrator update package from the Microsoft Update Catalog. Regardless of how you update the layout, the resulting updated layout will be a package cache that contains a particular version of the product, and it will then behave like a fixed link bootstrapper. So, whenever the client installs from the layout, the client will install the specific version of Visual Studio that exists in the layout (even though a newer version might exist online).

### How to get support for your offline installer

If you experience a problem with your offline installation, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool. When you use this tool, you can send us the telemetry and logs we need to help us diagnose and fix the problem.

We also offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

We have other support options available, too. For a list, see our [Feedback](../ide/feedback-options.md) page.

## See also

- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
- [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
- [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
- [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
- [Update Visual Studio while on a servicing baseline](update-servicing-baseline.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
- [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
