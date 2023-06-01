---
title: Create a network-based installation
description: Learn how to create a network install point for deploying Visual Studio within an enterprise.
ms.date: 6/2/2023
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
# Create and maintain a network installation of Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Sometimes an enterprise administrator wants to create a private installation point that contains Visual Studio files that can be deployed to client machines within an organization. This solution enables scenarios where the user may have limited permissions, where the client machines may have limited access to the internet, or when an organization wants to standardize on a particular version of the developer toolset. We've designed Visual Studio so that an administrator can both create and maintain a "layout" (i.e. the Visual Studio file cache) that can be stored on an internal network share and, if desired, be made available on an organization's intranet. The layout serves as the source location for all  Visual Studio files needed for both initial client installation as well as subsequent updates.

The information on this page is grouped up into three main sections:

1. [**Create the layout**](#create-the-layout): describes how to create the layout with the correct product content, how to configure the client's default settings, how to store it on a network file share, and how to make it available if you want to host it on a webserver on your intranet. 
1. [**Maintain the layout**](#maintaining-your-layout): information on how to best update the layout's product version, or modify the layout's product content, channel settings, installer version, and folder size. 
1. [**Help and Support**](#get-support-for-your-network-layout): where to ask for help


## Create the layout

### Prepare the network file share storage location

First, you'll need to determine where you're going to store the downloaded Visual Studio packages. If you have multiple editions of Visual Studio in use within your enterprise (for example, Visual Studio 2022 Professional and Visual Studio 2022 Enterprise), you must create a separate layout for each edition. This can consume a lot of disk space, especially when you consider that layout updates consume disk space too. Lastly, if you're [using the latest Visual Studio installer](#configure-the-layout-to-always-include-and-provide-the-latest-installer), then it's possible to change the client's configuration and have it use another layout location as a source for updates. The layout path must be fewer than 80 characters; some organizations have successfully used [symbolic links](/windows/win32/fileio/symbolic-links) to work around the 80-character limitation. 

### Download the Visual Studio bootstrapper to create the layout

Download the correct bootstrapper for the edition of Visual Studio you want and copy it into the directory that you want to serve as the layout's repository. Once the layout is created, you can then use it to install Visual Studio onto any client machine. The bootstrapper is the executable that you use to create, update, and perform other layout operations. You must have an internet connection to complete this step.

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

| Edition                         | Bootstrapper                                                            |
|---------------------------------|-------------------------------------------------------------------------|
| Visual Studio 2022 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/release/vs_enterprise.exe)     |
| Visual Studio 2022 Professional | [vs_professional.exe](https://aka.ms/vs/17/release/vs_professional.exe) |
| Visual Studio 2022 Community    | [vs_community.exe](https://aka.ms/vs/17/release/vs_community.exe)    |
| Visual Studio 2022 Build Tools  | [vs_buildtools.exe](https://aka.ms/vs/17/release/vs_buildtools.exe)     |

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it is, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the table at the bottom of the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history) page.

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it will install, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties** and then choose the **Details** tab. The **Product version** field will describe the [channel and version](/visualstudio/releases/2022/vs2022-release-rhythm) that the bootstrapper will install. The version number should always be read as "latest servicing version of what is specified", and the channel is assumed to be Current unless explicitly specified. So, a bootstrapper with a Product version of LTSC 17.0 will install the latest 17.0.x servicing release that is available on the 17.0 LTSC channel. A bootstrapper with a Product version that simply says Visual Studio 2022 will install the latest servicing version of Visual Studio 2022 on the Current channel.

::: moniker-end

## Download the Visual Studio packages

You must have an internet connection to complete this step.

Open an elevated command prompt, navigate to the directory that you downloaded the bootstrapper into, and use the bootstrapper's parameters as defined in the [use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page to create and maintain your network layout. Common examples of creating initial layouts are illustrated below and in the [command-line parameter examples for Visual Studio installation](command-line-parameter-examples.md) page.  

A complete initial layout for a single language locale requires about 40 GB of disk space for Visual Studio Community and 50 GB for Visual Studio Enterprise. Additional [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales) require about half a GB each. 
 
The recommended approach is to create an initial layout of Visual Studio with all workloads and appropriate languages and store the packages into the layout directory on the network server. That way, any client installation will have access to the entire Visual Studio product offering and the ability to install any subset. To create a full complete layout of Visual Studio, run the following command from the directory that you plan to host the network layout on:

  ```vs_enterprise.exe --layout c:\VSLayout```
  
::: moniker range=">=vs-2022"

### Ensure your layout is based off of the correct channel

It is important to ensure that the network layout is based off of the correct [channel](/visualstudio/releases/2022/vs2022-release-rhythm), because this is one of the criteria that [administrator updates](applying-administrator-updates.md), if they're deployed throughout the organization, use to identify which client instances should be updated. For example, if your layout is based off of the VisualStudio.17.Release.LTSC.17.0 channel and if your clients are configured to receive updates from Microsoft hosted servers, then any security updates that we make available on the 17.0 LTSC channel will be available to the clients that have installed or updated from that layout. 

The bootstrappers listed above are based off of the Current channel. To create a layout based off of one of the LTSC channels, simply acquire the correct channel's bootstrapper from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page, copy it into your layout folder, and use it to create or update the layout. 

::: moniker-end

### Configure the contents of a layout

There are several options you can use to customize the contents of your network layout. You can create a partial layout that only contains a specific set of [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales), [workloads, components, and their recommended or optional dependencies](workload-and-component-ids.md). This might be useful if you know that you're going to deploy only a subset of workloads to client workstations. Typical command-line parameters for customizing the layout include:

* `--add` to specify [workload or component IDs](workload-and-component-ids.md). <br>If `--add` is used, only those workloads and components specified with `--add` are downloaded.  If `--add` isn't used, all workload and components are downloaded.
* `--includeRecommended` to include all the recommended components for the specified workload IDs.
* `--includeOptional` to include all the optional components for the specified workload IDs.
* `--vsconfig` to use a config file to specify the components that should be included in the layout
* `--lang` to specify [language locales](use-command-line-parameters-to-install-visual-studio.md#list-of-language-locales).

Here are a few examples of how to create a custom partial layout.

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
    
* You can also use an [exported vsconfig file](import-export-installation-configurations.md) to customize and limit the contents of a network layout. 

    ```shell
    vs_enterprise.exe --layout C:\VSLayout --config "C:\myconfig.vsconfig" 
    ```

### Copy the layout to a network share

You will need to host the layout on a network share so it can be accessed from the client machines. If you created the layout on a local machine, then you will need to copy it to a network file location. The following example uses [`xcopy`](/windows-server/administration/windows-commands/xcopy/). You can also use [`robocopy`](/windows-server/administration/windows-commands/robocopy/), should you wish. Example:

```shell
xcopy /e c:\VSLayout \\server\share\layoutdirectory
```

### Configure initial client installation defaults for this layout

A file called `response.json` will get created in the root folder of the layout. This customizable file supplies the initial default settings that are configured on the client when the client initially installs from the layout. Common configuration options include the ability to configure which workloads, components, or languages should be installed by default on the client, where the client should receive updates from, or if out-of-support components should be removed during an update.  

More information can be found on the [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md) page. 

### Making your layout accessible via an intranet site

Starting in June 2023, you will be able to make your layouts available on an internal intranet site, which lets you take advantage of webserver file caching and georeplication performance capabilities. To use this new feature, you need to be using the latest Visual Studio bootstrappers and latest Visual Studio installer. IT administrators must do the following to take advantage of this intranet webhosting capability:

1. First, create and maintain a network layout and ensure that the bits are present and regularly updated on the network share as described on this page. Also, remember to configure the [channelUri value in the layout's response.json](automated-installation-with-response-file.md#configure-the-response-file-used-when-installing-from-a-layout) if you want to configure the client to get its updates from the intranet layout location.
2. Next, an admin will need to prepare an internal website and bind the source to the layout's network file location. They also need to ensure that the following MIME types in the table below are respected by the webserver. As an example, a more detailed reference description for [how to set up an IIS webserver is described here](iis webserver).

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
     | **.xml**| `application/x-zip-compressed` |

3. Lastly, to deploy this layout on the client, you'll need to [run a PowerShell script on the client to perform the initial installation](deploy-a-layout-onto-a-client-machine.md#install-from-an-internal-intranet-location). After Visual Studio has successfully installed onto the client from a webhosted layout, then [client updates for webhosted layouts behave the same as they do for network share hosted layouts](update-a-network-installation-of-visual-studio.md).  

### Ensure your layout is using the latest installer

> [!NOTE]
> As of June 2023, the latest installer ships by default with every update to all supported versions of Visual Studio 2017, Visual Studio 2019, and Visual Studio 2022. So if you're using one of these product versions, you won't need to do anything explicitly to get the latest version of the installer with the latest functionality and bug fixes. 

If you're using a version of Visual Studio that was shipped before June 2023, we recommend that you always use the latest Visual Studio installer in your layout and distribute it to your clients. For example, if you distribute the Visual Studio 2022 installer in your Visual Studio 2019 layout, then your Visual Studio 2019 clients based off of that layout will have the ability to change the source location for updates or to easily remove out-of-support components. Further details are [described below](#configure-the-layout-to-always-include-and-provide-the-latest-installer)

The capability to programmatically ensure that you're using the latest installer is only available to Visual Studio 2019 bootstrappers that were built after Visual Studio 2022 originally shipped. So, the vs_enterprise.exe in the example below must be a version that shipped _after_ November 10, 2021. 

To create a layout of the entire product that uses the latest and greatest installer available, run

```shell
vs_enterprise.exe --layout C:\VSLayout --useLatestInstaller
```

## Maintaining your layout

It is a best practice to periodically update your Visual Studio layout to the latest secure version of the product. This will ensure that the layout can be used both as an installation point as well as an update source for client installations. This section describes the most common or useful layout maintenance operations.

If you host a layout on a network file share, you may want to download an updated layout to a private local share (for example, c:\VSLayoutUpdate) and then, after all of the updated content is downloaded, copy it to your layout network file share (for example, \\server\products\VS). If you don't do this, there is a possibility that any users who happen to run Setup while you are updating the layout might get a mismatch of content from the layout because it was not yet completely updated.

### Update the layout to the most current version of the product

Microsoft frequently releases updated versions of the product to fix functionality or security issues. We strongly recommend that you keep your layout updated with the latest version of the product so that your clients always have access to the latest most secure version of the product. This is especially important if your clients don't have internet access and can *only* receive product updates from the layout.  

When you create the initial layout, the specified options, such as which workloads and languages to include in the layout, are saved in the layout's configuration file `layout.json`. Later, when you update that layout to a newer version of the product, you don't have to re-specify which components of the product you want in the layout. A layout update simply updates the existing components in the layout to their most current version.  

Suppose you already created this partial layout using [one of the evergreen bootstrappers in the table above](#download-the-visual-studio-bootstrapper-to-create-the-network-layout).

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.ManagedDesktop --lang en-US
```

Updating this layout to the latest version of the product offered by Microsoft and hosted on Microsoft servers is easy. You just need to use the existing evergreen bootstrapper in the layout, and simply run the `--layout` command in an elevated prompt to download the latest packages into your layout, as follows:

```shell
vs_enterprise.exe --layout c:\VSLayout
```

You can also update your layout to an updated version in an unattended manner. The layout operation runs the setup process in a new console window. The window is left open so that admins can see the final layout update result and a summary of any errors that might have occurred. If you'd like to perform a layout update operation in an unattended manner (for example, you have a script that is regularly run to update your layout to the latest version), then use the `--passive` parameter and the process will automatically close the window.

```shell
vs_enterprise.exe --layout c:\VSLayout --passive
```

### Update the layout to a specific version of the product

Sometimes you may want to update your layout to a _particular version of the product_.  For example, you may want to make your layout match the latest secure version of the servicing baseline that you have standardized your organization on. Here's how to do this:

::: moniker range="vs-2019"

You can go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page and download a particular fixed version bootstrapper, copy it into your layout, and use it to update the layout to that exact version specified in the bootstrapper. You would use the exact same syntax as above.

You can use an **[administrator update](applying-administrator-updates.md)** to update your layout to a specific version of the product. To get the **administrator update**, go to the [Microsoft Update Catalog](https://catalog.update.microsoft.com) and search for the update version that you want to update your layout to.  Download the _update.exe_ to the computer that's hosting the layout, open up an elevated command prompt, and run a command like this:

```shell
visualstudioupdate-16.0.0to16.11.23.exe layout --layoutPath c:\VSLayout
```
Note that an administrator updates will not initiate the creation of a new layout; it will only update an existing layout. 

::: moniker-end

::: moniker range="vs-2022"

You can go to the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page and download a particular fixed version bootstrapper, copy it into your layout, and use it to update the layout to that exact version specified in the bootstrapper. You would use the exact same syntax as above.

You can use an **[administrator update](applying-administrator-updates.md)** to update your layout to a specific version of the product. To get the **administrator update**, go to the [Microsoft Update Catalog](https://catalog.update.microsoft.com), and search for the update you want to update your layout to.  Download the _update.exe_ to the computer that's hosting the layout, open up an elevated command prompt on that computer and run a command like this:

```shell
visualstudioupdate-17.0.0to17.4.4.exe layout --layoutPath c:\VSLayout
```
Note that an administrator update will not initiate the creation of a new layout; it will only update an existing layout. 

::: moniker-end

::: moniker range=">=vs-2022"

### Ensuring your network layout is based off of a supported version

Occasionally, as channels transition out of support, you will need to ensure that the network layout continues to be based off of a supported channel so that your clients can continue to receive notifications of security updates. If your layout is based off of the VisualStudio.17.Release.LTSC.17.0 channel, then once the 17.0 LTSC channel goes out of support in July 2023, we will not release any more security updates to it and your layout and clients will become insecure. [Support dates for various Visual Studio 2022 channels can be found here](/visualstudio/releases/2022/release-history#evergreen-bootstrappers).

To change the channel that the layout is based off of, simply acquire the desired channel's bootstrapper from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page, copy it into your layout folder, and perform a normal update. Your clients should then be appropriately notified of an update so they will be able to stay secure too.

::: moniker-end

### Modify the contents of a layout

It is possible to modify a partial layout and ***add*** additional workloads, components, or languages. It is **not** possible to reliably remove components from a layout.

In the example below, we'll add the Azure workload and a localized language to the layout that was previously created with just the Managed Desktop workload and English language. After we've made the modification, both the Managed Desktop and Azure workloads, and both the English and German resources will be included in this layout. In addition to adding components, the `--layout` command will also cause the layout to be updated to the version specified by the bootstrapper. So, if you're using the [evergreen bootstrapper](#download-the-visual-studio-bootstrapper-to-create-the-network-layout), then the resultant layout will have the new component, the new language, and all layout contents will be updated to the latest version on the bootstrapper's channel. 

```shell
vs_enterprise.exe --layout c:\VSLayout --add Microsoft.VisualStudio.Workload.Azure --lang de-DE
```

If you want to modify an existing partial layout so that it becomes a full layout, use the --all option, as shown in the following example. Again, this command will cause the layout contents to be updated to the version specified by the bootstrapper.

```shell
vs_enterprise.exe --layout c:\VSLayout --all
```

You can add components to a layout by passing in a vsconfig file that contains the additional components you want in your layout. 

```shell
vs_enterprise.exe --layout C:\VSLayout --config "C:\myconfig.vsconfig"
```

Lastly, you can directly edit the `layout.json` configuration file in the layout folder and update the "add" section of this file to include the additional components you want included in your layout. You'll then need to update the layout using `--layout` as previously described to download the latest components. 
 
 > [!Note]
 > The easiest way to install the newly added layout components onto a client machine is to run the bootstrapper in the layout from the client machine. The 'add' section of the `response.json` file in the layout will determine which components are selected by default in the client's installer UI. If you've modified the layout using one of the methods above, you may want to manually double check and possibly adjust the 'add' section in the `response.json` file so that it more appropriately matches the contents in the 'add' section of the newly modified `layout.json` file. 

### Configure the layout to remove out-of-support components on the client machine.

Some enterprises will want to take advantage of the feature introduced in Visual Studio 2022 version 17.4 that removes components that have transitioned to an out-of-support state. This is relatively easy to set up if you're managing a layout and if your clients are receiving administrator updates. First, you'll need to configure your layout to have the [latest version of the installer as described below](#configure-the-layout-to-always-include-and-provide-the-latest-installer). Secondly, you'll need to add the line `"removeOos": true` to the `response.json` file. If your layout has these two details set properly, then subsequent administrator updates will respect this setting and will remove out-of-support components from the client machines.

### Verify a layout

Use `--verify` to perform verification on the network layout which checks if the packages files are either missing or invalid. At the end of the verification, it prints the list of missing and invalid files.

Verification works only for the latest version of a specific minor version of Visual Studio. As soon as a new version is released, verification won't work for layouts that contain previous releases.

```shell
vs_enterprise.exe --layout <layoutDir> --verify
```

> [!NOTE]
> Some important metadata files that are needed by the `--verify` option must be in the layout folder. If these metadata files are missing, "--verify" cannot run and Setup gives you an error. If you experience this error, try to update the layout again, or re-create a new network layout in a different folder.

Remember that Microsoft ships updates to Visual Studio periodically, so, if you're using an [evergreen bootstrapper](#download-the-visual-studio-bootstrapper-to-create-the-network-layout), then a more recent layout might not contain the same version as the initial layout. However, if you use a [fixed link bootstrappers](#download-the-visual-studio-bootstrapper-to-create-the-network-layout), then you'll (almost) always get a deterministic file set.

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
> As of June 2023, the latest installer is shipping by default with every update to supported versions of Visual Studio 2017, Visual Studio 2019, and Visual Studio 2022. So you won't need to do anything explicitly to get the latest version of the installer with the latest functionality and bug fixes into your layout and onto your clients. 

However, if you're using a layout that was created before June 2023, then you can also explicitly configure your layout to _always_ include and provide the latest installer to your clients, even if the installer is considered a part of a more recent version of Visual Studio. Thus, when your client updates from this layout, the client will acquire the latest installer that's included and provided by this layout. The benefit is that once the latest installer is on your client, your client installations will be able to take advantage of the bug fixes and new functionality that we continue to add to the installer. 

::: moniker range="vs-2019"

>[!TIP]
>If you want to [change the location where your client's Visual Studio 2019 installation looks for updates](update-visual-studio.md#configure-source-location-of-updates) or if you want to remove all out-of-support components, then you *must* get the latest Visual Studio 2022 installer on your client machine. One way to do this is to include the Visual Studio 2022 installer within your Visual Studio 2019 layouts using the parameters described below. The capability to use the latest installer is only available to Visual Studio 2019 bootstrappers that were built after Visual Studio 2022 originally shipped. So, the vs_enterprise.exe in the example below must be a version that shipped _after_ November 10, 2021. 

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
   
     "useLatestInstaller": true
     "removeOos": true
     
   }
   ```

There is no way to programmatically remove this setting in the `layout.json` file, so if you want your layout to _stop_ using the latest installer that Microsoft makes available, and instead use the version of the installer that corresponds to the bootstrapper (which is mostly likely older than the most recent installer), simply edit the `layout.json` file and remove the `"UseLatestInstaller": true` setting. 

Note that you may find this `"UseLatestInstaller": true` setting in the layout's `response.json` file too, but it is ignored there for the purposes of ensuring the layout always has the latest installer. The [response.json file is used to set default configuration options on the _client_ when the client installs or updates from a layout](automated-installation-with-response-file.md). This particular `"useLatestInstaller": true` setting in the `layout.json` file is used to ensure that the contents of the _layout_ contain the latest installer, so that the client machines can then acquire the latest installer from the layout.

### Error codes

If you used the `--wait` parameter, then depending on the result of the operation, the `%ERRORLEVEL%` environment variable is set to one of the following values:

[!INCLUDE[install-error-codes-md](includes/install-error-codes-md.md)]

### Get support for your network layout

If you experience a problem with your network layout, we want to know about it. The best way to tell us is by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio installer and in the Visual Studio IDE. If you're an IT Administrator and don't have Visual Studio installed, you can submit [**IT Admin feedback here**](https://aka.ms/vs/admin/feedback). When you use this tool, it would be very helpful if you could send the logs by the [VS Collect tool](https://aka.ms/vscollect) which can help us diagnose and fix the problem.

We also offer an [**installation chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

We have other support options available, too. See our [Visual Studio Developer Community](https://developercommunity.visualstudio.com/home).

## See also

- [Visual Studio administrator guide](visual-studio-administrator-guide.md)
- [Deploy Visual Studio from a layout onto a client machine](deploy-a-layout-onto-a-client-machine.md)
- [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
- [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
- [Configure policies for enterprise deployments of Visual Studio](configure-policies-for-enterprise-deployments.md) 
- [Visual Studio product lifecycle and servicing](/visualstudio/productinfo/vs-servicing/)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
- [Install certificates required for Visual Studio offline installation](install-certificates-for-visual-studio-offline.md)
