---
title: "Create a network-based installation"
description: "Learn how to create a network install point for deploying Visual Studio within an enterprise."
ms.date: 10/29/2019
ms.custom: "seodec18"
ms.topic: conceptual
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 4CABFD20-962E-482C-8A76-E4012052F701
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Create a network installation of Visual Studio

Typically, an enterprise administrator creates a network install point to deploy to client workstations. We've designed Visual Studio to enable you to cache the files for the initial installation along with all product updates to a single folder. (This process is also referred to as _creating a layout_.)

We've done this so that client workstations can use the same network location to manage their installation even if they haven't yet updated to the latest servicing update.

 > [!NOTE]
 > If you have multiple editions of Visual Studio in use within your enterprise (for example, both Visual Studio Professional and Visual Studio Enterprise), you must create a separate network install share for each edition.

## Download the Visual Studio bootstrapper

Download a bootstrapper file for the edition of Visual Studio you want. Make sure to choose **Save**, and then choose **Open folder**.

::: moniker range="vs-2017"

To get a bootstrapper for Visual Studio 2017, see the [Visual Studio previous versions](https://visualstudio.microsoft.com/vs/older-downloads/) download page for details on how to do so.

Your setup executable&mdash;or to be more specific, the bootstrapper file&mdash;should match or be similar to one of the following.

| Edition | Filename |
|-------------|-----------------------|
|Visual Studio Enterprise | **vs_enterprise.exe** |
|Visual Studio Professional | **vs_professional.exe** |
|Visual Studio Build Tools   | **vs_buildtools.exe** |

Other supported bootstrappers include **vs_feedbackclient.exe**, **vs_teamexplorer.exe**, **vs_testagent.exe**, **vs_testcontroller.exe**, and **vs_testprofessional.exe**.

::: moniker-end

::: moniker range="vs-2019"

Your setup executable&mdash;or to be more specific, a bootstrapper file&mdash;should match or be similar to one of the following.

|Edition | Download|
|-------------|-----------------------|
|Visual Studio Enterprise | [**vs_enterprise.exe**](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=enterprise&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=network+install&utm_content=download+vs2019) |
|Visual Studio Professional | [**vs_professional.exe**](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=professional&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=network+install&utm_content=download+vs2019) |
| Visual Studio Build Tools   | [**vs_buildtools.exe**](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=buildtools&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=offline+install&utm_content=download+vs2019) |

Other supported bootstrappers include [vs_teamexplorer.exe](https://aka.ms/vs/16/release/vs_teamexplorer.exe), [vs_testagent.exe](https://aka.ms/vs/16/release/vs_testagent.exe), and [vs_testcontroller.exe](https://aka.ms/vs/16/release/vs_testcontroller.exe).

::: moniker-end

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify its version, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, see the [Visual Studio build numbers and release dates](visual-studio-build-numbers-and-release-dates.md) page.

## Create an offline installation folder

You must have an internet connection to complete this step. To create an offline installation with all languages and all features, use a command that is similar to one of the following examples.

   > [!IMPORTANT]
   > A complete Visual Studio layout requires a minimum of 35 GB of disk space and can take some time to download. See the [Customize the network layout](#customize-the-network-layout) section for details on how to create a layout with only the components you want to install.
   >
   > [!TIP]
   > Make sure that you run the command from your Download directory. Typically, that's `C:\Users\<username>\Downloads` on a computer running Windows 10.

- For Visual Studio Enterprise, run:

  ```vs_enterprise.exe --layout c:\VSLayout```

- For Visual Studio Professional, run:

  ```vs_professional.exe --layout c:\VSLayout```

## Modify the response.json file

You can modify the response.json to set default values that are used when setup is run.  For example, you can configure the `response.json` file to select a specific set of workloads selected automatically. See [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md) for details.

And, if you run into a problem with the Visual Studio bootstrapper throwing an error when you pair it with a response.json file, see the "Failed to parse ID from parent process" section of the [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md#error-failed-to-parse-id-from-parent-process) page for more information on what to do.

## Copy the layout to a network share

Host the layout on a network share so it can be run from other machines.

The following example uses [xcopy](/windows-server/administration/windows-commands/xcopy/). You can also use [robocopy](/windows-server/administration/windows-commands/robocopy/), should you wish.  

::: moniker range="vs-2017"

Example:

```cmd
xcopy /e c:\VSLayout \\server\products\VS2017
```

::: moniker-end

::: moniker range="vs-2019"

```cmd
xcopy /e c:\VSLayout \\server\products\VS2019
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

    ```cmd
    vs_enterprise.exe --layout C:\VSLayout --lang en-US
    ```

* To download all workloads and components for multiple languages, run:

    ```cmd
    vs_enterprise.exe --layout C:\VSLayout --lang en-US de-DE ja-JP
    ```

* To download one workload for all languages, run:

    ```cmd
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --includeRecommended
    ```

* To download two workloads and one optional component for three languages, run:

    ```cmd
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeRecommended --lang en-US de-DE ja-JP
    ```

* To download two workloads and all of their recommended components:

    ```cmd
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeRecommended
    ```

* To download two workloads and all of their recommended and optional components, run:

    ```cmd
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Component.GitHub.VisualStudio --includeOptional
    ```

::: moniker range="vs-2017"

### New in version 15.3

::: moniker-end

::: moniker range="vs-2019"

### Save your layout options

::: moniker-end

When you run a layout command, the options that you specify are saved (such as the workloads and languages). Subsequent layout commands will include all of the previous options.  Here is an example of a layout with one workload for English only:

```cmd
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --lang en-US
```

When you want to update that layout to a newer version, you don't have to specify any additional command-line parameters. The previous settings are saved and used by any subsequent layout commands in this layout folder.  The following command will update the existing partial layout.

```cmd
vs_enterprise.exe --layout c:\VSLayout
```

When you want to add an additional workload, here's an example of how to do so. In this case, we'll add the Azure workload and a localized language.  Now, both Managed Desktop and Azure are included in this layout.  The language resources for English and German are included for all these workloads. The layout is updated to the latest available version.

```cmd
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --lang de-DE
```

If you want to update an existing layout to a full layout, use the --all option, as shown in the following example.

```cmd
vs_enterprise.exe --layout c:\VSLayout --all
```

## Deploy from a network installation

Administrators can deploy Visual Studio onto client workstations as part of an installation script. Or, users who have administrator rights can run setup directly from the share to install Visual Studio on their machine.

* Users can install by running the following command: <br>

    ```cmd
    \\server\products\VS\vs_enterprise.exe
    ```

* Administrators can install in an unattended mode by running the following command:

    ```cmd
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

::: moniker range="vs-2019"
> [!IMPORTANT]
> For offline installations, if you get an error message that says "A product matching the following parameters cannot be found", make sure that you are using the `--noweb` switch with version 16.3.5 or later.
>
::: moniker-end

When you install from a layout, the content that is installed is acquired from the layout. However, if you select a component that isn't in the layout, it will be acquired from the internet.  If you want to prevent Visual Studio setup from downloading any content that is missing in your layout, use the `--noWeb` option. If `--noWeb` is used and the layout is missing any content that is selected to be installed, setup fails.

> [!IMPORTANT]
> The `--noWeb` option does not stop Visual Studio setup from checking for updates. For more information, see the [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md) page.

### Error codes

If you used the `--wait` parameter, then depending on the result of the operation, the `%ERRORLEVEL%` environment variable is set to one of the following values:

[!INCLUDE[install-error-codes-md](includes/install-error-codes-md.md)]

## Update a network install layout

As product updates become available, you might want to [update the network install layout](update-a-network-installation-of-visual-studio.md) to incorporate updated packages.

## How to create a layout for a previous Visual Studio release

::: moniker range="vs-2017"

> [!NOTE]
> The Visual Studio bootstrappers that are available on [visualstudio.microsoft.com](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2017) download and install the latest Visual Studio release that's available whenever they are run.
>
> So, if you download a Visual Studio *bootstrapper* today and run it six months from now, it installs the Visual Studio release that is current at the time you run the bootstrapper.
>
> But, if you create a *layout* and then install from it, the layout installs the specific version of Visual Studio that exists in the layout. Even though a newer version might exist online, you get the version of Visual Studio that is in the layout.

::: moniker-end

::: moniker range="vs-2019"

> [!NOTE]
> The Visual Studio bootstrappers that are available on [visualstudio.microsoft.com](https://visualstudio.microsoft.com/downloads) download and install the latest Visual Studio release that's available whenever they are run.
>
> So, if you download a Visual Studio *bootstrapper* today and run it six months from now, it installs the Visual Studio release that is current at the time you run the bootstrapper.
>
> But, if you create a *layout* and then install from it, the layout installs the specific version of Visual Studio that exists in the layout. Even though a newer version might exist online, you get the version of Visual Studio that is in the layout.

::: moniker-end

If you need to create a layout for an older version of Visual Studio, go to [https://my.visualstudio.com](https://my.visualstudio.com) to download "fixed" versions of the Visual Studio bootstrappers.

### How to get support for your offline installer

If you experience a problem with your offline installation, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool. When you use this tool, you can send us the telemetry and logs we need to help us diagnose and fix the problem.

We also offer a [**live chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

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
