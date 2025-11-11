---
title: Create a network-based installation
description: Create a private network install point to deploy Visual Studio to support enterprise users with limited permissions or client machines with limited internet access.
ms.date: 11/3/2025
ms.topic: how-to
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: installation
---
# Create and maintain a network installation of Visual Studio

> 📣 **We'd love to hear your feedback!**
> *Please take a moment to complete this [survey](https://aka.ms/learnlayoutfeedback) and let us know how we can improve the layout experience. Thank you for your support!*

Sometimes an enterprise administrator wants to create a private installation cache (also known as a "layout") that contains Visual Studio files that can be [deployed to client machines within an organization](deploy-a-layout-onto-a-client-machine.md). 

Creating a layout is useful in following scenarios:
-  User with limited system permissions
-  Client machines with restricted internet access
-  The organization wants to standardize on a specific version of the developer toolset

We designed Visual Studio so that an administrator can both create and maintain a layout and store it on an internal network share and optionally make it available on an organization's intranet. The layout serves as the source location for all Visual Studio files needed for both initial client installation and subsequent updates.

The information on this page is grouped up into three main sections:

* [**Create the layout**](#create-the-layout): describes how to create a layout with the correct product content, configure the default settings, store the layout on a network file share, and make it available on your intranet. 
* [**Maintain the layout**](#maintaining-your-layout): information on how to best update the layout's product version, or modify the layout's product content, channel settings, installer version, and folder size. 
* [**Help and Support**](#get-support-for-your-network-layout): where to ask for help

## Create the layout

### Prepare the network file share storage location

First, you need to determine where you're going to store the downloaded Visual Studio packages. If you have multiple editions of Visual Studio in use within your enterprise (for example, Visual Studio 2022 Professional and Visual Studio 2022 Enterprise), you must create a separate layout for each edition. Creating a separate layout for each edition can consume a lot of disk space, especially when you consider that layout updates consume disk space too. 

The layout path must be fewer than 80 characters; some organizations successfully use [symbolic links](/windows/win32/fileio/symbolic-links) to work around the 80-character limitation. 

### Download the Visual Studio bootstrapper to create the layout

Download the correct bootstrapper for the edition of Visual Studio you want and copy it into the directory that you want to serve as the layout's repository. Once the layout is created, you can then use it to install Visual Studio onto any client machine. The bootstrapper is the executable that you use to create, update, and perform other layout operations. You must have an internet connection and administrator permissions to complete this step.

::: moniker range="vs-2019"

The following bootstrappers always install the latest most secure version of Visual Studio 2019, no matter when you run them. If you want to create or update a layout to a specific version of Visual Studio 2019, go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page.  It contains links to fixed-version bootstrappers for each servicing release. Download the one you want, and copy it into the directory that you want to use as the source location for the layout.

| Edition                                       | Bootstrapper                                                            |
|-----------------------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2019 Enterprise version 16.11   | [vs_enterprise.exe](https://aka.ms/vs/16/release/vs_enterprise.exe)     |
| Visual Studio 2019 Professional version 16.11 | [vs_professional.exe](https://aka.ms/vs/16/release/vs_professional.exe) |
| Visual Studio 2019 Build Tools version 16.11  | [vs_buildtools.exe](https://aka.ms/vs/16/release/vs_buildtools.exe)     |

Other supported bootstrappers include [vs_teamexplorer.exe](https://aka.ms/vs/16/release/vs_TeamExplorer.exe), [vs_testagent.exe](https://aka.ms/vs/16/release/vs_TestAgent.exe), and [vs_testcontroller.exe](https://aka.ms/vs/16/release/vs_TestController.exe).

::: moniker-end

::: moniker range="vs-2022"

The following bootstrappers always install the latest most secure version of Visual Studio 2022 on the Current channel, no matter when you run them. If you want to create or update a layout to a specific version or a specific channel of Visual Studio 2022, download the appropriate bootstrapper. Both the evergreen and fixed-version bootstrappers for each servicing release and channel are available on the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page. Download the one you want, and copy it into the directory that you want to use as the source location for the layout. 

| Edition                         | Bootstrapper                                                            |
|---------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2022 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/release/vs_enterprise.exe)     |
| Visual Studio 2022 Professional | [vs_professional.exe](https://aka.ms/vs/17/release/vs_professional.exe) |
| Visual Studio 2022 Community    | [vs_community.exe](https://aka.ms/vs/17/release/vs_community.exe)    |
| Visual Studio 2022 Build Tools  | [vs_buildtools.exe](https://aka.ms/vs/17/release/vs_buildtools.exe)     |

::: moniker-end

::: moniker range="visualstudio"

<!-- tbd release history link not available-->
The following bootstrappers always install the latest most secure version of Visual Studio 2026 on the Current channel, no matter when you run them. If you want to create or update a layout to a specific version or a specific channel of Visual Studio 2026, download the appropriate bootstrapper. Both the evergreen and fixed-version bootstrappers for each servicing release and channel are available on the [Visual Studio 2026 Release History](/visualstudio/releases/2026/release-history#release-dates-and-build-numbers) page. Download the one you want, and copy it into the directory that you want to use as the source location for the layout. 

| Edition                         | Bootstrapper                                                            |
|---------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2026 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/stable/vs_enterprise.exe)     |
| Visual Studio 2026 Professional | [vs_professional.exe](https://aka.ms/vs/stable/vs_professional.exe) |
| Visual Studio 2026 Community    | [vs_community.exe](https://aka.ms/vs/stable/vs_community.exe)    |
| Visual Studio 2026 Build Tools  | [vs_buildtools.exe](https://aka.ms/vs/stable/vs_buildtools.exe)     |

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it is, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the table at the bottom of the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history) page.

::: moniker-end

::: moniker range="=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify the version it installs, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties** and then choose the **Details** tab. The **Product version** field describes the [channel and version](/visualstudio/releases/2022/release-rhythm-vs2022) that the bootstrapper installs. The version number should always be read as "latest servicing version of what is specified", and the channel is assumed to be Current unless explicitly specified. So, a bootstrapper with a Product version of LTSC 17.0 installs the latest 17.0.x servicing release that's available on the 17.0 LTSC channel. A bootstrapper with a Product version that says Visual Studio 2022 installs the latest servicing version of Visual Studio 2022 on the Current channel.

::: moniker-end

::: moniker range=">=visualstudio"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify the version it installs, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties** and then choose the **Details** tab. The **Product version** field describes the [channel and version](/visualstudio/releases/2026/release-rhythm) that the bootstrapper installs. The version number should always be read as "latest servicing version of what is specified", and the channel is assumed to be Current unless explicitly specified. So, a bootstrapper with a Product version of Stable 18.0 installs the latest 18.0.x servicing release that's available on the 18.0 Stable channel. A bootstrapper with a Product version that says Visual Studio 2026 installs the latest servicing version of Visual Studio 2026 on the Stable channel.

::: moniker-end

## Download the Visual Studio packages

You must have an internet connection to complete this step.

Open an elevated Command Prompt, navigate to the directory where you downloaded the bootstrapper, and use its parameters as defined in the [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page to create and maintain your network layout. The following examples show common ways to create initial layouts. You can find more examples on the [command-line parameter examples for a Visual Studio installation](command-line-parameter-examples.md) page.  

A complete initial layout for a single language locale requires about 40 GB of disk space for Visual Studio Community and about 50 GB for Visual Studio Enterprise. Extra [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales) require about half a GB each. 
 
The recommended approach is to create an initial layout of Visual Studio with all workloads and appropriate languages and store the packages into the layout directory on the network server. That way, any client installation has access to the entire Visual Studio product offering and the ability to install any subset. To create a full complete layout of Visual Studio, run the following command from the directory that you plan to host the network layout on:

  ```vs_enterprise.exe --layout c:\VSLayout```
  
::: moniker range=">=vs-2022"
<!-- paused -->
### Ensure your layout is based off of the correct channel

It's important to ensure that the network layout is based on the correct [channel](/visualstudio/releases/2022/release-rhythm-vs2022). This is because the channel is one of the criteria that [administrator updates](applying-administrator-updates.md) use, when deployed throughout the organization, to identify which client instances should be updated. For example, if your layout is based on the VisualStudio.17.Release.LTSC.17.0 channel and if your clients are configured to receive updates from Microsoft-hosted servers, then any security updates released on the 17.0 LTSC channel will be available to the clients that installed or updated from that layout. 

The bootstrappers listed previously are based off of the Current channel. To create a layout based off of one of the LTSC channels, acquire the correct channel's bootstrapper from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page, copy it into your layout folder, and use it to create or update the layout. 

::: moniker-end

### Configure the contents of a layout

There are several options you can use to customize the contents of your network layout. You can create a partial layout that only contains a specific set of [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales), [workloads, components, and their recommended or optional dependencies](workload-and-component-ids.md). A partial layout is useful if you know that you're going to deploy only a subset of workloads to client workstations. Typical command-line parameters for customizing the layout include:

* `--add` to specify [workload or component IDs](workload-and-component-ids.md). <br>If `--add` is used, only those workloads and components specified with `--add` are downloaded.  If `--add` isn't used, all workload and components are downloaded.
* `--includeRecommended` to include all the recommended components for the specified workload IDs.
* `--includeOptional` to include all the optional components for the specified workload IDs.
* `--config` to use a `*.vsconfig` file to specify the [workloads, components or extensions](#use-a-configuration-file-to-initialize-the-contents-of-a-layout) that should be included in or referenced by the layout. Make sure you specify the **full path** of the config file.  
* `--lang` to specify [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales).

Here are a few examples of how to create a custom network layout.

* To create a layout with required components for all workloads in only one language, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --lang en-US
    ```

* To create a layout with required components for all workloads in multiple languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --lang en-US de-DE ja-JP
    ```

* To create a layout with one workload and all required and recommended components for that workload in all languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --includeRecommended
    ```

* To create a layout with two workloads and one optional component in three languages, run:

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --add Microsoft.VisualStudio.Workload.ManagedDesktop --add Microsoft.VisualStudio.Component.Git --lang en-US de-DE ja-JP
    ```

#### Use a configuration file to initialize the contents of a layout

You can use the `--config` parameter to pass in a [`*.vsconfig` file](import-export-installation-configurations.md). Make sure you specify the **full path** of the config file. Using a `*.vsconfig` file during layout creation customizes and limits the contents of a network layout to what is specified in the configuration file. The configuration file is copied into the layout directory and renamed to `layout.vsconfig`.  

Any [extensions specified in the `*.vsconfig` file](import-export-installation-configurations.md#extensions) aren't copied directly into the layout. Instead, the layout's `response.json` file contains a reference to the newly created `layout.vsconfig` file, defining the installation location for the client's extensions. If you're installing extensions that aren't digitally signed, make sure to edit the `response.json` to add `"allowUnsignedExtensions": true`. See [`response.json` content examples](automated-installation-with-response-file.md#example-customized-layout-response-file-content).  

```shell
vs_enterprise.exe --layout "C:\VSLayout" --config "C:\myconfig.vsconfig" 
```

### Copy the layout to a network share

You need to host the layout on a network share so it can be accessed from the client machines. If you created the layout on a local machine, then you need to copy it to a network file location. The following example uses [`xcopy`](/windows-server/administration/windows-commands/xcopy/). You can also use [`robocopy`](/windows-server/administration/windows-commands/robocopy/), should you wish. Example:

```shell
xcopy /e c:\VSLayout \\server\share\layoutdirectory
```

### Configure initial client installation defaults for this layout

A file called `response.json` is created in the root folder of the layout. This customizable file supplies the initial default settings to configure on the client, when the client initially installs from the layout. Common configuration options include the ability to configure:
- Which workloads, components, or languages should be installed by default on the client
- If recommended components should also be installed
- If the client should respect an installation `*.vsconfig` file
- Where should the client receive updates from
- If out-of-support components should be removed during an update
- If unsigned extensions are allowed to load quietly & programmatically

More information can be found on the [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md) page. 

### Making your layout accessible via an intranet site

Starting in June 2023, you're able to make your layouts available on an internal intranet site, which lets you take advantage of webserver file caching and georeplication performance capabilities. To use this new feature, you need to use the latest Visual Studio bootstrappers and the latest Visual Studio Installer. IT administrators must do the following to take advantage of this intranet web hosting capability:

1. First, create and maintain a network layout and ensure that the bits are present and regularly updated on the network share. Also, remember to configure the [channelUri value in the layout's response.json](automated-installation-with-response-file.md#configure-the-response-file-used-when-installing-from-a-layout) if you want your clients to get their updates from the intranet layout location.
2. Next, an admin needs to prepare an internal website and bind the website's source to the layout's network file location. They also need to ensure that the webserver respects the following MIME types:

     | **File Extension** | **MIME Type** |
     |------------------|------------------|
     | **.cab** | `application/vnd.ms-cab-compressed` |
     | **.exe**| `application/octet-stream` |
     | **.json** | `application/json` |
     | **.msi**| `application/octet-stream` |
     | **.msu** | `application/octet-stream` |
     | **.nupkg**| `application/octet-stream` |
     | **.opc** | `application/octet-stream` |
     | **.ps1**| `application/postscript` |
     | **.vsix** | `application/octet-stream` |
     | **.xml**| `text/xml` |
     | **.zip**| `application/x-zip-compressed` |

3. Lastly, to deploy this layout on the client, [run a PowerShell script on the client to perform the initial installation](deploy-a-layout-onto-a-client-machine.md#install-from-an-internal-intranet-location). After Visual Studio successfully installs onto the client from a web hosted layout, then [client updates for webhosted layouts can be updated via standard methods](update-a-network-installation-of-visual-studio.md).  

### Ensure your layout is using the latest installer

> [!NOTE]
> As of June 2023, the latest installer ships by default with every update to all supported versions of Visual Studio 2017 and later. So if you're using one of these product versions, you don't need to do anything explicitly to get the latest version of the installer with the latest functionality and bug fixes. 

If you're using a version of Visual Studio shipped before June 2023, we recommend that you always use the latest Visual Studio Installer in your layout and distribute it to your clients. For example, if you distribute the Visual Studio 2022 installer in your Visual Studio 2019 layout, then your Visual Studio 2019 clients based off of that layout have the ability to change the source location for updates or to easily remove out-of-support components. Further details are [described in the following section](#configure-the-layout-to-always-include-and-provide-the-latest-installer).

The capability to ensure programmatically that you're using the latest installer is only available to Visual Studio 2019 bootstrappers built after Visual Studio 2022 originally shipped. So, the vs_enterprise.exe in the following example must be a version that shipped *after* November 10, 2021. 

To create a layout of the entire product that uses the latest and greatest installer available, run

```shell
vs_enterprise.exe --layout C:\VSLayout --useLatestInstaller
```

## Maintaining your layout

It's considered best practice to periodically update your Visual Studio layout to the latest secure version of the product. Doing so ensures that the layout can be used both as an installation point and as an update source for client installations. The following section describes the most common or useful layout maintenance operations.

If you host a layout on a network file share, download an updated layout to a private local share (for example, c:\VSLayoutUpdate). After the updated content is downloaded, copy it to your layout network file share (for example, \\server\products\VS). If you don't do this, users who happen to run setup while you're updating the layout might get a mismatch of content from the layout because it isn't yet updated.

### Update the layout to the most current version of the product

Microsoft frequently releases updated versions of the product to fix functionality or security issues. We strongly recommend that you keep your layout updated with the latest version of the product so that your clients always have access to the latest most secure version of the product. This is especially important if your clients don't have internet access and can *only* receive product updates from the layout. Visual Studio typically releases security updates on the second Tuesday of the month, known as "patch Tuesday", so a good strategy would be to update all your layouts on patch Tuesday afternoons.

When you create the initial layout, the specified options, such as which workloads and languages to include in the layout, are saved in the layout's configuration file `layout.json`. Later, when you update that layout to a newer version of the product, you don't have to re-specify which components of the product you want in the layout. A layout update simply updates the existing components in the layout to their most current version.  

Suppose you already created this partial layout using [one of the evergreen bootstrappers in the previous table](#download-the-visual-studio-bootstrapper-to-create-the-layout).

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --lang en-US
```

Updating this layout to the latest version of the product offered by Microsoft and hosted on Microsoft servers is easy. You just need to use the existing evergreen bootstrapper in the layout, and run the `--layout` command in an elevated prompt to download the latest packages into your layout, as follows:

```shell
vs_enterprise.exe --layout c:\VSLayout
```

You can also update your layout to an updated version in an unattended manner. The layout operation runs the setup process in a new console window. The window is left open so that admins can see the final layout update result and a summary of any errors that occur. If you'd like to perform a layout update operation in an unattended manner (for example, you have a script that is regularly run to update your layout to the latest version), then use the `--passive` parameter and the process automatically closes the window.

```shell
vs_enterprise.exe --layout c:\VSLayout --passive
```

### Update the layout to a specific version of the product

Sometimes you may want to update your layout to a *particular version of the product*.  For example, you may want to make your layout match the latest secure version of the servicing baseline that you have standardized your organization on. Here's how to do this:

::: moniker range="vs-2019"

You can go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page and download a particular fixed version bootstrapper, copy it into your layout, and use it to update the layout to that exact version specified in the bootstrapper. You would use the exact same syntax as previously.

You can use an **[administrator update](applying-administrator-updates.md)** to update your layout to a specific version of the product. To get the **administrator update**, go to the [Microsoft Update Catalog](https://catalog.update.microsoft.com) and search for the update version that you want to update your layout to.  Download the `update.exe` to the computer that's hosting the layout, open up an elevated command prompt, and run a command like this:

```shell
visualstudioupdate-16.0.0to16.11.23.exe layout --layoutPath c:\VSLayout
```
An administrator update doesn't initiate the creation of a new layout; it only updates an existing layout. You need to use a bootstrapper to create the initial layout.

::: moniker-end

::: moniker range="vs-2022"

You can go to the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page and download a particular fixed version bootstrapper, copy it into your layout, and use it to update the layout to that exact version specified in the bootstrapper. You would use the exact same syntax as above.

You can use an **[administrator update](applying-administrator-updates.md)** to update your layout to a specific version of the product. To get the **administrator update**, go to the [Microsoft Update Catalog](https://catalog.update.microsoft.com), and search for the update you want to update your layout to.  Download the `update.exe` to the computer that's hosting the layout, open up an elevated command prompt on that computer and run a command like this:

```shell
visualstudioupdate-17.0.0to17.4.4.exe layout --layoutPath c:\VSLayout
```
An administrator update doesn't initiate the creation of a new layout; it only updates an existing layout. You need to use a bootstrapper to create the initial layout.

::: moniker-end

::: moniker range="=visualstudio"

You can go to the [Visual Studio 2022 Release History](/visualstudio/releases/2026/release-history#release-dates-and-build-numbers) page and download a particular fixed version bootstrapper, copy it into your layout, and use it to update the layout to that exact version specified in the bootstrapper. You would use the exact same syntax as above.

You can use an **[administrator update](applying-administrator-updates.md)** to update your layout to a specific version of the product. To get the **administrator update**, go to the [Microsoft Update Catalog](https://catalog.update.microsoft.com), and search for the update you want to update your layout to.  Download the `update.exe` to the computer that's hosting the layout, open up an elevated command prompt on that computer and run a command like this:

```shell
visualstudioupdate-18.0.0to18.4.4.exe layout --layoutPath c:\VSLayout
```
An administrator update doesn't initiate the creation of a new layout; it only updates an existing layout. You need to use a bootstrapper to create the initial layout.

::: moniker-end

::: moniker range=">=vs-2022"

### Ensuring your network layout is based off of a supported version

Occasionally, as channels transition out of support, you need to ensure that the network layout continues to be based on a supported channel so that your clients can continue to receive notifications of security updates. If your layout is based on the VisualStudio.17.Release.LTSC.17.0 channel, then once the 17.0 LTSC channel goes out of support in July 2023, we won't release any more security updates to it and your layout and clients will become insecure. [Support dates for various Visual Studio 2022 channels can be found here](/visualstudio/releases/2022/release-history#evergreen-bootstrappers).

To change the channel that the layout is based off of, acquire the desired channel's bootstrapper from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page, copy it into your layout folder, and perform a normal update. Your clients should then be appropriately notified of an update so they are able to stay secure too.

::: moniker-end

### Modify the contents of a layout

It is possible to modify a partial layout and ***add*** other workloads, components, or languages. It is **not** possible to reliably remove components from a layout.

In the following example, we add the Azure workload and a localized language to the layout that was previously created with just the Managed Desktop workload and English language. After we make the modification, both the Managed Desktop and Azure workloads, and both the English and German resources are included in this layout. In addition to adding components, the `--layout` command also causes the layout to be updated to the version specified by the bootstrapper. So, if you're using the [evergreen bootstrapper](#download-the-visual-studio-bootstrapper-to-create-the-layout), then the resultant layout has the new component, the new language, and all layout contents are updated to the latest version on the bootstrapper's channel. 

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --lang de-DE
```

If you want to modify an existing partial layout so that it becomes a full layout, use the --all option, as shown in the following example. Again, this command causes the layout contents to be updated to the version specified by the bootstrapper.

```shell
vs_enterprise.exe --layout c:\VSLayout --all
```

You can add components to a layout by passing in a `*.vsconfig` file that contains other components you want in your layout. If you do this, the new `*.vsconfig` content will overwrite the existing `layout.vsconfig` content. For more information, refer to the previous section [Using a configuration file to initialize the contents of a layout](#use-a-configuration-file-to-initialize-the-contents-of-a-layout).

```shell
vs_enterprise.exe --layout C:\VSLayout --config "C:\myupdatedconfig.vsconfig"
```

Lastly, you can directly edit the `layout.json` configuration file in the layout folder and update the "add" section of this file to include the additional components you want included in your layout. You then need to update the layout using `--layout` as previously described to download the latest components. 
 
> [!NOTE]
> The easiest way to install the newly added layout components onto a client machine is to run the bootstrapper in the layout from the client machine. The 'add' section of the `response.json` file in the layout will determine which components are selected by default in the client's installer UI. If you've modified the layout using one of the previous methods, you may want to manually double check and possibly adjust the 'add' section in the `response.json` file so that it more appropriately matches the contents in the 'add' section of the newly modified `layout.json` file. 

### Configure the layout to remove out-of-support components on the client machine

Some enterprises will want to take advantage of the feature introduced in Visual Studio 2022 version 17.4 that removes components that have transitioned to an out-of-support state. This is relatively easy to set up if you're managing a layout and if your clients are receiving administrator updates. First, you'll need to configure your layout to have the [latest version of the installer as described below](#configure-the-layout-to-always-include-and-provide-the-latest-installer). Secondly, you'll need to add the line `"removeOos": true` to the `response.json` file. If your layout has these two details set properly, then subsequent administrator updates will respect this setting and will remove out-of-support components from the client machines.

### Verify a layout

Use `--verify` to perform verification on the network layout which checks if the packages files are either missing or invalid. At the end of the verification, it prints the list of missing and invalid files.

Verification works only for the latest version of a specific minor version of Visual Studio. As soon as a new version is released, verification won't work for layouts that contain previous releases.

```shell
vs_enterprise.exe --layout <layoutDir> --verify
```

> [!NOTE]
> Some important metadata files that are needed by the `--verify` option must be in the layout folder. If these metadata files are missing, "--verify" cannot run and Setup gives you an error. If you experience this error, try to update the layout again, or re-create a new network layout in a different folder.

Remember that Microsoft ships updates to Visual Studio periodically, so, if you're using an [evergreen bootstrapper](#download-the-visual-studio-bootstrapper-to-create-the-layout), then a more recent layout might not contain the same version as the initial layout. However, if you use a [fixed link bootstrappers](#download-the-visual-studio-bootstrapper-to-create-the-layout), then you'll (almost) always get a deterministic file set.

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

### Configure the layout to always include and provide the latest installer

> [!NOTE]
> As of June 2023, the latest installer ships by default with every update to all supported versions of Visual Studio 2017 and later. So if you're using one of these product versions, you don't need to do anything explicitly to get the latest version of the installer with the latest functionality and bug fixes. 

However, if you're using a layout that was created before June 2023, then you can also explicitly configure your layout to *always* include and provide the latest installer to your clients, even if the installer is considered a part of a more recent version of Visual Studio. Thus, when your client updates from this layout, the client will acquire the latest installer that's included and provided by this layout. The benefit is that once the latest installer is on your client, your client installations will be able to take advantage of the bug fixes and new functionality that we continue to add to the installer. 

::: moniker range="vs-2019"

>[!TIP]
>If you want to [change the location where your client's Visual Studio 2019 installation looks for updates](update-visual-studio.md#configure-source-location-of-updates) or if you want to remove all out-of-support components, then you *must* get the latest Visual Studio 2022 installer on your client machine. One way to do this is to include the Visual Studio 2022 installer within your Visual Studio 2019 layouts using the parameters described below. The capability to use the latest installer is only available to Visual Studio 2019 bootstrappers that were built after Visual Studio 2022 originally shipped. So, the vs_enterprise.exe in the example below must be a version that shipped *after* November 10, 2021. 

::: moniker-end

There are several ways to enable your layout to include and provide the latest installer:

- You can use a version of Visual Studio that was built on or after June 2023.

- You can pass in the `--useLatestInstaller` parameter to the bootstrapper when you're creating or updating the layout. This will cause a setting to get set in the `layout.json` file, which can be found in the root directory of the layout. Here's an example for how to update the layout and configure it to use the latest and greatest installer available.  

   ```shell
   vs_enterprise.exe --layout C:\VSLayout --useLatestInstaller
   ```

- You can edit the `layout.json` file directly to add this setting.

   ```Example layout.json contents
   {
     "installChannelUri": ".\\ChannelManifest.json",
     "channelUri": "\\\\server\\share\\layoutdirectory\\ChannelManifest.json",
     "installCatalogUri": ".\\Catalog.json",
     "channelId": "VisualStudio.16.Release",
     "productId": "Microsoft.VisualStudio.Product.Enterprise",
   
     "useLatestInstaller": true,
     "removeOos": true
     
   }
   ```

There is no way to programmatically remove this setting in the `layout.json` file, so if you want your layout to *stop* using the latest installer that Microsoft makes available, and instead use the version of the installer that corresponds to the bootstrapper (which is mostly likely older than the most recent installer), edit the `layout.json` file and remove the `"UseLatestInstaller": true` setting. 

You may find this `"UseLatestInstaller": true` setting in the layout's `response.json` file too, but it is ignored there for the purposes of ensuring the layout always has the latest installer. The [response.json file is used to set default configuration options on the *client* when the client installs or updates from a layout](automated-installation-with-response-file.md). This particular `"useLatestInstaller": true` setting in the `layout.json` file is used to ensure that the contents of the *layout* contain the latest installer, so that the client machines can then acquire the latest installer from the layout.

### Error codes

If you used the `--wait` parameter, then depending on the result of the operation, the `%ERRORLEVEL%` environment variable is set to one of the following values:

[!INCLUDE[install-error-codes-md](includes/install-error-codes-md.md)]

### Get support for your network layout

If you experience a problem with your network layout, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE. If you're an IT Administrator and don't have Visual Studio installed, you can submit [**IT Admin feedback here**](https://aka.ms/vs/admin/feedback). When you use this tool, it would be very helpful if you could send the logs by the [Visual Studio Collect tool](https://aka.ms/vscollect) which can help us diagnose and fix the problem.

We also offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

We have other support options available, too. See our [Visual Studio Developer Community](https://developercommunity.visualstudio.com/home).

## Related content

- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Deploy Visual Studio from a layout onto a client machine](deploy-a-layout-onto-a-client-machine.md)
- [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
- [Troubleshoot network-related errors when you install or use Visual Studio](/troubleshoot/developer/visualstudio/installation/troubleshoot-network-related-errors)
- [Configure policies for enterprise deployments of Visual Studio](configure-policies-for-enterprise-deployments.md) 
- [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing/)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
- [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
