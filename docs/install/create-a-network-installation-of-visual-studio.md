---
title: Create a network-based installation
description: Learn how to create a network install point for deploying Visual Studio within an enterprise.
ms.date: 1/20/2023
ms.topic: conceptual
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
ms.assetid: 4CABFD20-962E-482C-8A76-E4012052F701
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Create, maintain, and deploy a network installation of Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Sometimes an enterprise administrator wants to create a network install point that contains Visual Studio files that can be deployed to client workstations. This is to facilitate scenarios where the client machines may have limited permissions or limited access to the internet, or when an organization wants to standardize on a particular version of the developer toolset. We've designed Visual Studio so that an administrator can _create and maintain_ a network layout (file cache), that can be stored on an internal network share. The network layout includes all the Visual Studio files necessary for both initial installation and subsequent product updates.

There is a lot of information on this webpage, and it's grouped up into the following sections:

- [**Before you get started**](#before-you-get-started): highlights tips and other important considerations you should think about when you plan.
- [**Acquire the correct bootstrapper**](#download-the-visual-studio-bootstrapper-to-create-the-network-layout): guidance on where to find and how to distinguish the various bootstrappers that are available for you to use.
- [**Create the network layout**](#create-the-network-layout): describes how to create the layout with the correct product content, channel settings, and version of the installer and how to copy it to a network share. 
- [**Update, modify, and maintain the network layout**](#update-or-modify-your-layout): information on how to best maintain your layout, including how to update the layout's product version, product content, channel settings, installer version, and folder size. 
- [**Install the layout onto client machines**](#install-visual-studio-onto-a-client-machine-from-a-network-installation): describes how to configure client default settings such as what workloads and components to install by default and where the client should look for updates from. Also includes how to do the _initial installation_ of the Visual Studio layout onto the client machines. Guidance and information regarding _updating_ client machines that were originally installed from a layout is covered in the separate [update a network based installation of Visual Studio](update-a-network-installation-of-visual-studio.md) page.
- [**Help and Support**](#get-support-for-your-network-layout): where to ask for help

## Before you get started

There are a few important things to plan out and be aware of before you get started.  

::: moniker range="vs-2019"

- **Folder Management:** If you have multiple editions of Visual Studio in use within your enterprise (for example, Visual Studio 2019 Professional and Visual Studio 2019 Enterprise), you must create a separate network install point for each edition. Also, the layout path must be fewer than 80 characters, although some organizations have successfully used [symbolic links](/windows/win32/fileio/symbolic-links) to work around the 80-character limitation. 
- **Planning for Updates:** You should decide how your client machines should receive product updates _before_ you do the initial client install. This is necessary to ensure that your clients' update location configuration is set correctly. Your choices include having the clients get updates from either the network layout location or from Microsoft hosted servers on the internet. 

 > [!IMPORTANT]
 > The following limitation exists with layout management when you use only Visual Studio 2019 functionality: Once the client has installed from the layout, the client's update location is locked and unchangable. This implies that if you intended for your clients to receive updates from your layout while preserving their repair and uninstall functionality, then you must put all subsequent product updates in the _original_ layout folder that your clients installed from. In other words, the base Visual Studio 2019 functionality does **not** support the ability for a client to do an original installation from one layout location, and then have that client receive a product update from a different layout location. 
 > 
 > This limitation where the product update location is fixed, and product updates must be in the same layout folder as the original install layout does **not** exist in Visual Studio 2022. In Visual Studio 2022, you can easily change the client's source location for updates. We made it possible for you to include and use the latest (Visual Studio 2022) installer, which governs _all_ modern versions of the Visual Studio product family, to manage your Visual Studio 2019 layouts and eliminate the limitation in the 2019 version of the product. The section below [Configure the layout to always include and provide the latest installer](#configure-the-layout-to-always-include-and-provide-the-latest-installer) describes how to enable this.
 
::: moniker-end

::: moniker range="vs-2022"

- **Folder Management:** If you have multiple editions of Visual Studio in use within your enterprise (for example, Visual Studio 2022 Professional and Visual Studio 2022 Enterprise), you must create a separate network install point for each edition. Also, the layout path must be fewer than 80 characters, although some organizations have successfully used [symbolic links](/windows/win32/fileio/symbolic-links) to work around the 80-character limitation.
- **Planning for Updates:** We recommend that you decide how your client machines should receive product updates _before_ you do the initial client install. This is to ensure that your clients' update location configuration is initialized correctly. Your choices include having the clients get updates from either the network layout location or from Microsoft hosted servers on the internet. Fortunately, it is also possible to configure the client source location for updates _after_ the initial install has occurred. 

::: moniker-end

## Download the Visual Studio bootstrapper to create the network layout

Download the bootstrapper for the edition of Visual Studio you want and copy it into the directory that you want to serve as the source location of the layout. Once the layout is created, you can use it to install Visual Studio onto any client machine. The bootstrapper is the executable that you use to create, update, and perform other layout operations. You must have an internet connection to complete this step.

::: moniker range="vs-2019"

The bootstrappers listed below will always install the latest most secure version of Visual Studio 2019, no matter when you run them. Alternatively, if you want to create or update a layout to a specific version of Visual Studio 2019, go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page that has links to the fixed version bootstrappers for each servicing release, and download the one you want. Copy it into the directory that you want to serve as the source location of the layout.

| Edition                                       | Bootstrapper                                                            |
|-----------------------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2019 Enterprise version 16.11   | [vs_enterprise.exe](https://aka.ms/vs/16/release/vs_enterprise.exe)     |
| Visual Studio 2019 Professional version 16.11 | [vs_professional.exe](https://aka.ms/vs/16/release/vs_professional.exe) |
| Visual Studio 2019 Build Tools version 16.11  | [vs_buildtools.exe](https://aka.ms/vs/16/release/vs_buildtools.exe)     |

Other supported bootstrappers include [vs_teamexplorer.exe](https://aka.ms/vs/16/release/vs_TeamExplorer.exe), [vs_testagent.exe](https://aka.ms/vs/16/release/vs_TestAgent.exe), and [vs_testcontroller.exe](https://aka.ms/vs/16/release/vs_TestController.exe).

::: moniker-end

::: moniker range="=vs-2022"

The bootstrappers listed below will always install the latest most secure version of Visual Studio 2022 on the Current channel, no matter when you run them. Alternatively, if you want to create or update a layout to a specific version or a specific channel of Visual Studio 2022, go to the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page that has links to the evergreen and fixed version bootstrappers for each servicing release on each channel, and download the one you want. Copy it into the directory that you want to serve as the source location of the layout. 

| Edition                    | Bootstrapper                                                        |
|----------------------------|----------------------------------------------------------------------|
| Visual Studio 2022 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/release/vs_enterprise.exe)     |
| Visual Studio 2022 Professional | [vs_professional.exe](https://aka.ms/vs/17/release/vs_professional.exe) |
| Visual Studio 2022 Build Tools   | [vs_buildtools.exe](https://aka.ms/vs/17/release/vs_buildtools.exe)         |

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it is, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the table at the bottom of the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history) page.

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it will install, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties** and then choose the **Details** tab. The **Product version** field will describe the [channel and version](/visualstudio/releases/2022/vs2022-release-rhythm) that the bootstrapper will install. The version number should always be read as "latest servicing version of what is specified", and the channel is assumed to be Current unless explicitly specified. So, a bootstrapper with a Product version of LTSC 17.0 will install the latest 17.0.x servicing release that is available on the 17.0 LTSC channel. A bootstrapper with a Product version that simply says Visual Studio 2022 will install the latest servicing version of Visual Studio 2022 on the Current channel.

::: moniker-end

## Create the network layout

You must have an internet connection to complete this step.

Open a command prompt with administrator privileges, navigate to the directory that you downloaded the bootstrapper into, and use the bootstrapper's parameters as defined in the [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page to create and maintain your network layout. Common examples of creating initial layouts are illustrated below and in the [command-line parameter examples for Visual Studio installation](command-line-parameter-examples.md) page.  

A complete initial layout for a single language locale requires about 35 GB of disk space for Visual Studio Community and 45 GB for Visual Studio Enterprise. Additional [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales) require about half a GB each. 
 
The recommended approach is to create an initial layout of Visual Studio Enterprise with all languages and all workloads in the layout directory on the network server. That way, your clients will have access to the entire product offering. To create a full complete layout of Visual Studio, run the following from the machine that you plan to host the network layout on:

  ```vs_enterprise.exe --layout c:\VSLayout```
  
::: moniker range=">=vs-2022"

### Ensure your layout has the correct channel

It is important to ensure that the network layout is based off of the correct [channel](/visualstudio/releases/2022/vs2022-release-rhythm), because this is one of the criteria that [administrator updates](applying-administrator-updates.md), if they're deployed throughout the organization, use to identify which client instances should be updated. For example, if your layout is based off of the VisualStudio.17.Release.LTSC.17.0 channel and if your clients are configured to receive updates from Microsoft hosted servers, then any security updates that we make available on the 17.0 LTSC channel will be available to the clients that have installed or updated from that layout. 

The bootstrappers listed above are based off of the Current channel. To create a layout based off of one of the LTSC channels, simply acquire the correct channel's bootstrapper from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page, copy it into your layout folder, and use it to create or update the layout. 

::: moniker-end

### Configure the contents of a network layout

There are several options you can use to customize the contents of your network layout. You can create a partial layout that only contains a specific set of [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales), [workloads, components, and their recommended or optional dependencies](workload-and-component-ids.md). This might be useful if you know that you're going to deploy only a subset of workloads to client workstations. Typical command-line parameters for customizing the layout include:

* `--add` to specify [workload or component IDs](workload-and-component-ids.md). <br>If `--add` is used, only those workloads and components specified with `--add` are downloaded.  If `--add` isn't used, all workload and components are downloaded.
* `--includeRecommended` to include all the recommended components for the specified workload IDs.
* `--includeOptional` to include all the optional components for the specified workload IDs.
* `--lang` to specify [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales).

Here are a few examples of how to create a custom partial layout.

* To create a layout with all workloads and components for only one language, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --lang en-US
    ```

* To create a layout with all workloads and components for multiple languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --lang en-US de-DE ja-JP
    ```

* To create a layout with one workload and all recommended components for that workload, for all languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --includeRecommended
    ```

* To create a layout with two workloads and one optional component for three languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Component.Git --lang en-US de-DE ja-JP
    ```

* To create a layout with two workloads and all of their recommended and optional components, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeRecommended --includeOptional
    ```

### Ensure your layout is using the latest installer

We recommend that you always use the latest Visual Studio installer in your layout and distribute it to your clients. That way you will have access to the new features and functionality we make available in subsequent versions of the product. For example, if you distribute the Visual Studio 2022 Installer in your Visual Studio 2019 layouts, then your Visual Studio 2019 clients based off of that layout will have the ability to change source location for updates. The scenario where this functionality would be useful is if you want to install from one layout but have updates come from another layout. Further details, including how to turn _off_ using the latest installer, are [described below](#configure-the-layout-to-always-include-and-provide-the-latest-installer)

 > [!IMPORTANT]
 > This capability to use the latest installer is only available to Visual Studio 2019 bootstrappers that were built after Visual Studio 2022 originally shipped. So, the vs_enterprise.exe in the example below must be a version that shipped _after_ November 10, 2021. 

* To create a layout of the entire product that uses the latest and greatest installer available, run
    ```shell
    vs_enterprise.exe --layout C:\VSLayout --useLatestInstaller
    ```

### Copy the layout to a network share

You will need to host the layout on a network share so it can be run from the client machines. If you created the layout on a local machine, then you will need to copy it to a network location. The following example uses [`xcopy`](/windows-server/administration/windows-commands/xcopy/). You can also use [`robocopy`](/windows-server/administration/windows-commands/robocopy/), should you wish. Example:

```shell
xcopy /e c:\VSLayout \\server\share\layoutdirectory
```

> [!IMPORTANT]
> To prevent an error, make sure that your full layout path on the network share is fewer than 80 characters. Or, some organizations have successfully used [symbolic links](/windows/win32/fileio/symbolic-links) to work around the 80-character limitation.

## Update or modify your layout

It is possible to update a network layout of Visual Studio with the latest product updates so that it can be used both as an installation point and an update source for client workstations to receive the latest version of Visual Studio. It is a best practice to periodically update your layout, particularly if you intend for your clients to receive updates from the layout. This section describes the most common or useful layout maintenance operations.

If you host a layout on a file share, you may want to update a private copy of the layout (for example, c:\VSLayout) and then, after all of the updated content is downloaded, copy it to your file share (for example, \\\server\products\VS). If you don't do this, there is a greater chance that any users who happen to run Setup while you are updating the layout might get a mismatch of content from the layout because it was not yet completely updated.

### Update the layout to the most current version of the product

Microsoft frequently releases updated versions of the product to fix functionality or security issues. We recommend that you keep your layout updated with the latest version of the product, so that new client installs always receive the latest goodness. It's also very important to keep your layout updated if your clients are configured to receive updates from the layout. 

When you create the initial layout, the specified options, such as which workloads and languages to include in the layout, are saved in the layout's configuration file. Later, when you want to update that layout to a newer version of the product, you don't have to re-specify the options that you used during initial layout creation. The layout update commands automatically use the saved layout settings. 

Suppose you already created this partial layout using [one of the evergreen bootstrappers in the table above](#download-the-visual-studio-bootstrapper-to-create-the-network-layout).

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --lang en-US
```

Updating this layout to the latest version of the product offered by Microsoft and hosted on Microsoft servers is easy. You just need to use the same evergreen bootstrapper, and run the `--layout` command again to download the latest packages into your layout.

```shell
vs_enterprise.exe --layout c:\VSLayout
```

You can also update your layout to a newer version in an unattended manner. The layout operation runs the setup process in a new console window. The window is left open so users can see the final result and a summary of any errors that might have occurred. If you are performing a layout operation in an unattended manner (for example, you have a script that is regularly run to update your layout to the latest version), then use the `--passive` parameter and the process will automatically close the window.

```shell
vs_enterprise.exe --layout c:\VSLayout --passive
```

### Update the layout to a specific version of the product

Sometimes you may want to update your layout to a _particular version of the product_.  For example, you may want to make your layout match the latest secure version of the servicing baseline that you have standardized your organization on. Here's how to do this:

::: moniker range="vs-2019"

You can go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page and download a particular fixed version bootstrapper, copy it into your layout, and use it to update the layout to that exact version specified in the bootstrapper. You would use the exact same syntax as above.

You can use an **[administrator update](applying-administrator-updates.md)** to update your layout to a specific version. To get the **administrator update**, go to the [Microsoft Update Catalog](https://catalog.update.microsoft.com) and search for your update.  Download the _update.exe_ to the computer that's hosting the layout, open up a command prompt, and run a command as follows:

```shell
visualstudioupdate-16.0.0to16.11.23.exe layout --layoutPath c:\VSLayout
```
Note that administrator updates will not initiate an original layout install; they will only update an existing layout or a client instance. 

::: moniker-end

::: moniker range="vs-2022"

You can go to the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page and download a particular fixed version bootstrapper, copy it into your layout, and use it to update the layout to that exact version specified in the bootstrapper. You would use the exact same syntax as above.

You can use an **[administrator update](applying-administrator-updates.md)** to update your layout to a specific version. To get the **Administrator Update**, go to the [Microsoft Update Catalog](https://catalog.update.microsoft.com), search for the update you want to update your layout to.  Download the _update.exe_ to the computer that's hosting the layout, open up a command prompt on that computer and run a command like this:

```shell
visualstudioupdate-17.0.0to17.4.4.exe layout --layoutPath c:\VSLayout
```
Note that administrator updates will not initiate an original layout install; they will only update an existing layout or a client instance. 

::: moniker-end

::: moniker range=">=vs-2022"

### Modify the channel of the network layout

Occasionally, as channels transition out of support, you will need to ensure that the network layout continues to be based off of a supported channel so that your clients can continue to receive notifications of security updates. If your layout is based off of the VisualStudio.17.Release.LTSC.17.0 channel, then once the 17.0 LTSC channel goes out of support, we will not release any more security updates to it and your layout and clients will become insecure.

To change the channel that the layout is based off of, simply acquire the desired channel's bootstrapper from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page, copy it into your layout folder, and perform a normal update. Your clients should then be appropriately notified of an update so they will be able to stay secure too.

::: moniker-end

### Modify and add to a partial layout

It is possible to modify a partial layout and add additional workloads, components, or languages. In the example below, we'll add the Azure workload and a localized language to the layout we created above. After we've made the modification, both the Managed Desktop and Azure workloads, and the English and German resources are included in this layout. In addition to adding components, the layout is updated to the latest available version.

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --lang de-DE
```

If you want to modify an existing partial layout so that it becomes a full layout, use the --all option, as shown in the following example.

```shell
vs_enterprise.exe --layout c:\VSLayout --all
```

Here's how to add an additional workload and localized language _without_ updating the version. (This command adds the ASP.NET and Web Development workload.) Now the Managed Desktop, Azure, and ASP.NET & Web Development workloads are included in this layout. The language resources for English, German, and French are also included for all these workloads. However, the layout is not updated to the latest available version when this command is run. It remains at the existing version.

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.NetWeb --lang fr-FR --keepLayoutVersion
```

 > [!IMPORTANT]
 > It is not possible to reliably remove components from a layout. 
 
You can also add components to a partial layout by directly editing the `layout.json` configuration file and including the new components you need in the "add" section of this file. Adding components this way or on the command line as illustrated above is equivalent to modifying the layout and adding additional components. 
 
The easiest way to install the newly added layout components on a client machine is to run the bootstrapper in the layout from the client machine. The `response.json` file in the layout will ensure that all the workloads and components that exist in the layout are selected by default in the client's installer UI.   

### Configure the layout to always include and provide the latest installer

You can configure your layout to _always_ include and provide the latest installer to your clients, even if the installer is considered a part of a more recent version of Visual Studio. Thus, when your client updates from this layout, the client will acquire the latest installer that's included and provided by this layout. The benefit is that once the latest installer is on your client, your client installations will be able to take advantage of the bug fixes and new functionality that we continue to add to the installer. 

::: moniker range="vs-2019"

>[!TIP]
>If you want to [change the location where your client's Visual Studio 2019 installation looks for updates](update-visual-studio.md#configure-source-location-of-updates), then you *must* get the latest Visual Studio 2022 installer on your client machine. One way to do this is to include the Visual Studio 2022 installer within your Visual Studio 2019 layouts using the parameters described below. The capability to use the latest installer is only available to Visual Studio 2019 bootstrappers that were built after Visual Studio 2022 originally shipped. So, the vs_enterprise.exe in the example below must be a version that shipped _after_ November 10, 2021. 

::: moniker-end

There are two ways to enable your layout to include and provide the latest installer:

- You can pass in the `--useLatestInstaller` parameter to the bootstrapper when you're creating or updating the layout. This will cause a setting to get set in the layout.json file, which can be found in the root directory of the layout. Here's an example for how to update the layout and configure it to use the latest and greatest installer available.  

   ```shell
   vs_enterprise.exe --layout C:\VSLayout --useLatestInstaller
   ```

- You can edit the layout.json file directly to add this setting.

   ```Example layout.json contents
   {
     "installChannelUri": ".\\ChannelManifest.json",
     "channelUri": "\\\\server\\share\\layoutdirectory\\ChannelManifest.json",
     "installCatalogUri": ".\\Catalog.json",
     "channelId": "VisualStudio.16.Release",
     "productId": "Microsoft.VisualStudio.Product.Enterprise",
   
     "useLatestInstaller": true
     "removeOos": true
     
   }
   ```

There is no way to programmatically remove this setting in the layout.json file, so if you want your layout to _stop_ using the latest installer that Microsoft makes available, and instead use the version of the installer that corresponds to the bootstrapper (which is mostly likely older than the most recent installer), simply edit the layout.json file and remove the `"UseLatestInstaller": true` setting. 

Note that you may find this `"UseLatestInstaller": true` setting in the layout's response.json file too, but it is ignored there. The [response.json file is used to set default configuration options on the _client_ when the client installs or updates from a layout](automated-installation-with-response-file.md). This particular `"useLatestInstaller": true` setting is used to ensure that the contents of the _layout_ contain the latest installer, so that the client machines can then acquire the latest installer from the layout.

### Configure the layout to remove out-of-support components on the client machine.

Some enterprises will want to take advantage of the feature introduced in Visual Studio 2022 version 17.4 that removes components that have transitioned to an out-of-support state. This is relatively easy to set up if you're managing a layout and if your clients are receiving administrator updates. First, you'll need to configure your layout to have the latest version of the installer as described above. Secondly, you'll need to add the line `"removeOos": true` to the response.json file as illustrated above. If your layout has these two details set properly, then subsequent administrator updates will respect this setting and will remove out-of-support components from the client machines.

### Verify a layout

Use `--verify` to perform verification on the network layout which checks if the packages files are either missing or invalid. At the end of the verification, it prints the list of missing and invalid files.

Verification works only for the latest version of a specific minor version of Visual Studio. As soon as a new version is released, verification won't work for layouts that contain previous releases.

```shell
vs_enterprise.exe --layout <layoutDir> --verify
```

> [!NOTE]
> Some important metadata files that are needed by the `--verify` option must be in the layout folder. If these metadata files are missing, "--verify" cannot run and Setup gives you an error. If you experience this error, try to update the layout again, or re-create a new network layout in a different folder.

Remember that Microsoft ships updates to Visual Studio periodically, so a more recent layout might not contain the same version as the initial layout, unless you use the [fixed link bootstrappers](#download-the-visual-studio-bootstrapper-to-create-the-network-layout).

### Fix a layout

Use `--fix` to perform the same verification as `--verify` and also try to fix the identified issues. The `--fix` process needs an internet connection, so make sure your machine is connected to the internet before you invoke `--fix`.

```shell
vs_enterprise.exe --layout <layoutDir> --fix
```

### Remove older versions from a layout

After you perform layout updates to a network cache, the layout folder may have some obsolete packages that are no longer needed by the latest Visual Studio installation. You can use the `--clean` option to remove obsolete packages from the network layout folder.

To do this, you'll need the file path(s) to catalog manifest(s) that contain those obsolete packages. You can find the catalog manifests in an "Archive" folder in the network layout cache. They are saved there when you update a layout. In the "Archive" folder, there is one or more "GUID" named folders, each of which contains an obsolete catalog manifest. The number of "GUID" folders should be the same as the number of updates made to your layouts.

A few files are saved inside each "GUID" folder. The two files of most interest are a "catalog.json" file and a "version.txt" file. The "catalog.json" file is the obsolete catalog manifest you'll need to pass to the `--clean` option. The other version.txt file contains the version of this obsolete catalog manifest. Based on the version number, you can decide whether you want to remove obsolete packages from this catalog manifest. You can do the same as you go through the other "GUID" folders. After you make the decision on the catalog(s) you want to clean, run the `--clean` command by supplying the files paths to these catalogs.

Here is an example of how to use the --clean option:

```shell
c:\VSLayout\vs_enterprise.exe --layout c:\VSLayout --clean c:\VSLayout\Archive\1cd70189-fc55-4583-8ad8-a2711e928325\Catalog.json --clean c:\VSLayout\Archive\d420889f-6aad-4ba4-99e4-ed7833795a10\Catalog.json
```

When you execute this command, Setup analyzes your network layout folder to find the list of files that it will remove. You will then have a chance to review the files that are going to be deleted and confirm the deletions.

## Install Visual Studio onto a client machine from a network installation

Administrators can deploy Visual Studio onto client workstations as part of an installation script. Or, users who have administrator rights can run setup directly from the share to install Visual Studio on their machine. 

* Users can manually install the product from a network layout by running the following command:

    ```shell
    \\server\products\VS\vs_enterprise.exe
    ```

* Administrators can install in an unattended mode by running the following command:

    ```shell
    \\server\products\VS\vs_enterprise.exe --quiet --wait --norestart
    ```

Make sure that either the user or system account that's running the installation has proper access to the network share that contains the layout. For more information, refer to [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md).

> [!NOTE] 
> Be patient. Make sure you `--wait` for both the installer and the product to finish. When installing or updating a client from a layout, the installer is always the first thing to get installed or updated, and then the Visual Studio product itself will get installed or updated. **Both** of these processes need to finish in order to be considered a successful update.   
>
> When executing the install or update as part of an unattended automated batch file, the `--wait` option is helpful to ensure that the `vs_enterprise.exe` process waits until the installation is complete before it returns an exit code. This is useful if an enterprise administrator wants to perform further actions on a completed installation, such as [apply a product key to a successful installation](automatically-apply-product-keys-when-deploying-visual-studio.md). Using the --wait option prevents subsequent operations from kicking off prematurely. If you do not use `--wait`, the `vs_enterprise.exe` process can exit before both parts of the installation are complete, and thus will return an inaccurate exit code that doesn't represent the state of the install operation.

### Install on a client that doesn't have internet access

When you install from a layout, the content that is installed will default to be acquired from the layout. However, if you select a component that isn't in the layout, and the [client has been configured to look at Microsoft hosted servers for updates](automated-installation-with-response-file.md), then the installer will attempt to acquire Visual Studio packages from the internet too. If you want to prevent Visual Studio setup attempting to download any content from the web that is missing in your layout, use the `--noWeb` option. If `--noWeb` is used and the layout is missing any content that is selected to be installed, then the setup will fail.

> [!IMPORTANT]
> The `--noWeb` option does not stop the Visual Studio installer on an internet-connected client machine from _checking_ for updates if the client has been configured to look at Microsoft hosted servers for updates. Rather, `--noWeb` simply prevents the client from downloading the product packages. For more information, see the [Update a Visual Studio client that was installed from a network layout](update-a-network-installation-of-visual-studio.md) page.

If you get an error message that says "A product matching the following parameters cannot be found", make sure that you are using the `--noweb` switch.

### Configure initial client installation defaults for this layout

You can modify the response.json file in the layout folder to set default values for when the product is initially installed on the client machine. Common configuration options include:

- Ability to **configure which workloads, components, or languages should be selected by default** during initial install. 
- Ability to specify **where the client should receive updates from**. Examples include the default Microsoft hosted servers on the internet or from an admin-controlled network layout location.

For more information about how to customize and configure the default client settings for the layout, see [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md).  

### Configure policies for enterprise deployment behavior

You can also control other enterprise deployment behavior such as installation, update, and download behavior, administrator update behavior, how layouts appear in the **Update Settings** dialog, and notification behavior.  

Refer to [Configure policies for enterprise deployments of Visual Studio](set-defaults-for-enterprise-deployments.md) for additional details.


### Error codes

If you used the `--wait` parameter, then depending on the result of the operation, the `%ERRORLEVEL%` environment variable is set to one of the following values:

[!INCLUDE[install-error-codes-md](includes/install-error-codes-md.md)]

### Get support for your network layout

If you experience a problem with your network layout, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE. If you're an IT Administrator and don't have Visual Studio installed, you can submit [**IT Admin feedback here**](https://aka.ms/vs/admin/feedback). When you use this tool, it would be very helpful if you could send the logs by the [VS Collect tool](https://aka.ms/vscollect) which can help us diagnose and fix the problem.

We also offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

We have other support options available, too. See our [Visual Studio Developer Community](https://developercommunity.visualstudio.com/home).

## See also

- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
- [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
- [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
- [Configure policies for enterprise deployments of Visual Studio](set-defaults-for-enterprise-deployments.md) 
- [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing/)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
- [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
