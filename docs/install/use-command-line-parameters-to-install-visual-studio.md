---
title: Use command-line parameters to install Visual Studio
titleSuffix: ''
description: Learn how to use command-line parameters to control or customize your Visual Studio installation.
ms.date: 2/21/2023
ms.topic: conceptual
f1_keywords:
- command-line parameters
- switches
- command prompt
ms.assetid: 480f3cb4-d873-434e-a8bf-82cff7401cf2
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Use command-line parameters to install, update, and manage Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

When you install Visual Studio programmatically or from a command prompt, you can use various command-line parameters to control or customize the installation to perform the following actions:

- Start the installation on the client with certain options and behaviors preselected.
- Automate the installation or update process.
- Create or maintain a network layout of the product files for installing or updating client machines.


The command-line verbs and parameters described below are designed to be used with the following executables or programs:
  - The setup bootstrapper, which is the small (~1 MB) file (for example, vs_enterprise.exe) that initiates the download process.
  - The Visual Studio installer that may already be installed on the machine and is located in the folder `C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe`. Note that you can't initiate the installer programmatically from the same directory that the installer resides in.  
  - With a [winget command using winget's --override switch](#use-winget-to-install-visual-studio). 
  - With an Administrator Update package, which is available to download from the [Microsoft Update Catalog](https://catalog.update.microsoft.com), to programatically update your network layout. More information describing how to do this can be found in the [Update or modify your layout](create-a-network-installation-of-visual-studio.md#update-the-layout-to-a-specific-version-of-the-product) article. 

Not all commands or parameters work in each of these situations, and we've tried to document the exceptions below. Furthermore, in some scenarios you may not have access to all of these executables. For example, client machines may only have the installer available for programmatic execution if Visual Studio was installed via a layout.  

::: moniker range="vs-2019"

You can get the Visual Studio 2019 bootstrappers from the table below. Alternatively, if you want a specific version of Visual Studio 2019, you can go to the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page, which has links to the fixed version bootstrappers for your chosen version and edition of Visual Studio.

| **Edition**                     | **Bootstrapper**                                                             |
|---------------------------------|------------------------------------------------------------------------------|
| Visual Studio 2019 Enterprise version 16.11   | [vs_enterprise.exe](https://aka.ms/vs/16/release/vs_enterprise.exe)     |
| Visual Studio 2019 Professional version 16.11| [vs_professional.exe](https://aka.ms/vs/16/release/vs_professional.exe) |
| Visual Studio 2019 Build Tools version 16.11 | [vs_buildtools.exe](https://aka.ms/vs/16/release/vs_buildtools.exe)     |

::: moniker-end

::: moniker range=">=vs-2022"

To get the latest bootstrappers for Visual Studio 2022 that will always install the latest version of the Current channel, download one of the files below. Alternatively, if you want to install a specific version or a specific channel of Visual Studio 2022, go to the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page, which has links to the fixed version bootstrappers for each servicing release. 

| **Edition**                      | **Bootstrapper**                                                                                   |
|----------------------------|-------------------------------------------------------------------------------------------|
| Visual Studio 2022 Enterprise   | [vs_enterprise.exe](https://aka.ms/vs/17/release/vs_enterprise.exe)     |
| Visual Studio 2022 Professional | [vs_professional.exe](https://aka.ms/vs/17/release/vs_professional.exe) |
| Visual Studio 2022 Community    | [vs_community.exe](https://aka.ms/vs/17/release/vs_community.exe)       |
| Visual Studio 2022 Build Tools   | [vs_buildtools.exe](https://aka.ms/vs/17/release/vs_buildtools.exe)         |

::: moniker-end

::: moniker range="vs-2019"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify its version, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, refer to the table at the bottom of the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history) page.

::: moniker-end

::: moniker range=">=vs-2022"

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify what version it will install, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties** and then choose the **Details** tab. The **Product version** field will describe the [channel and version](/visualstudio/releases/2022/vs2022-release-rhythm) that the bootstrapper will install. The version number should always be read as "latest servicing version of what is specified", and the channel is Current unless explicitly specified. So, a bootstrapper with a Product version of LTSC 17.0 will install the latest 17.0.x servicing release that is available on the 17.0 LTSC channel. A bootstrapper with a Product version that simply says Visual Studio 2022 will install the latest version of Visual Studio 2022 on the Current channel.

::: moniker-end

## Install, Update, Modify, Repair, Uninstall, and Export commands and command-line parameters

When invoking the Visual Studio bootstrapper or the installer programmatically to install the product or to maintain a layout, the first parameter is the command (the verb) that describes the operation to perform. The subsequent optional command line parameters, which are all prefixed by two dashes (--), further define how that operation is supposed to happen. All Visual Studio command-line parameters are case-insensitive, and additional examples can be found on the [Command-line parameter examples](command-line-parameter-examples.md) page.

Syntax example: `vs_enterprise.exe [command] <optional parameters>...`

| **Command** | **Description**                                                                                                         |
|-------------|-------------------------------------------------------------------------------------------------------------------------|
| (blank)     | The default command both installs the product, and it is used for all layout maintenance operations.                    |
| `modify`    | Modifies an installed product.                                                                                          |
| `update`    | Updates an installed product.                                                                                           |
| `updateall` | Updates all of the installed products in sequential order. Works with `--quiet` and `--passive` parameters.             |
| `repair`    | Repairs an installed product.                                                                                           |
| `uninstall` | Uninstalls an installed product.                                                                                        |
| `export`    | Exports installation selection to an installation configuration file.                                                   |

> [!IMPORTANT]
> When specifying multiple distinct workloads or components or languages, you must repeat the `--add` or `--remove` command-line switch for each item.

| **Parameters**                                     | **Description**                                                      |
|----------------------------------------------------|----------------------------------------------------------------------|
| `--installPath <dir>`                              | For the default install command, this parameter is **Optional** and describes where the instance will be installed on the client machine. For other commands like update or modify, this parameter is **Required** and denotes the installation directory for the instance to act upon.  |
| `--add <one or more workload or component IDs>`    | **Optional**: During an install or modify command, this repeatable parameter specifies one or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional` parameters. To include multiple workloads or components, repeat the `--add` command (for example, `--add Workload1 --add Workload2`). For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeRecommended;includeOptional`). For more information, see the [Workload and component IDs](workload-and-component-ids.md) page. |
| `--remove <one or more workload or component IDs>` | **Optional**: During a modify command, this repeatable parameter specifies one or more workload or component IDs to remove. It complements and behaves similarly to the `--add` parameter.   |
| `--addProductLang <language-locale>`               | **Optional**: During an install or modify command, this repeatable parameter specifies the UI language packs that should be installed with the product. If not present, the installation uses the language pack that corresponds to the machine locale. For more information, see the [List of language locales](#list-of-language-locales) section on this page.  |
| `--removeProductLang <language-locale>`            | **Optional**: During an install or modify command, this repeatable parameter determines the UI language packs that should be removed from the product.  It complements and behaves similarly to the `--addProductLang` parameter. |
| `--in <path>`                                      | **Optional**: The URI or path to a [response file](automated-installation-with-response-file.md), which can contain configuration settings.  |
| `--all`                                            | **Optional**: During an install or modify command, this parameter causes all workloads and components for the product to be installed.  |
| `--allWorkloads`                                   | **Optional**: During an install or modify command, this parameter installs all workloads and components, but no recommended or optional components.  |
| `--includeRecommended`                             | **Optional**: During an install or modify command, this parameter includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`.  |
| `--includeOptional`                                | **Optional**: During an install or modify command, this parameter includes the optional components for any workloads that are installed, but not the recommended components. The workloads are specified either with `--allWorkloads` or `--add`. |
| `--quiet, -q`                                      | **Optional**: Used with any command, this parameter prevents any user interface from being displayed while the command is being executed.    |
| `--passive, -p`                                    | **Optional**: This parameter causes the user interface to be displayed in a non-interactive manner. This parameter is mutually exclusive from (and in fact overrides) the `--quiet` parameter.   |
| `--norestart`                                      | **Optional**: This parameter must be paired with either the `--passive` or `--quiet` parameters.  During an install, update, or modify command, adding the `--norestart` parameter will delay any necessary reboot.    |
| `--force`                                          | **Optional**: This parameter forces Visual Studio to close even if any Visual Studio process is in use. Forcing Visual Studio to close might cause loss of work, so use it with caution.  |
| `--installWhileDownloading`                        | **Optional**: During an install, update, or modify command, this parameter allows Visual Studio to both download and install the product in parallel. It's the default experience.  |
| `--downloadThenInstall`                            | **Optional**: During an install, update, or modify command, this parameter forces Visual Studio to download all files before installing them. It is mutually exclusive from the `--installWhileDownloading` parameter.   |
| `--channelUri`                                     | **Optional**: During an update command, you can pass in a new channelUri to change the update settings location.  Recommend to pair with --installPath parameter so that it's very explicit which instance of Visual Studio you're configuring. See [syntax examples of --channelUri](/visualstudio/install/command-line-parameter-examples#using---channelUri) |
| `--nickname <name>`                                | **Optional**: During an install command, this parameter defines the nickname to assign to an installed product. The nickname can't be longer than 10 characters. |
| `--productKey`                                     | **Optional**: During an install command, this parameter defines the product key to use for an installed product. It's composed of 25 alphanumeric characters in the format `xxxxxxxxxxxxxxxxxxxxxxxxx`.  |
| `--removeOos true`                                 | **Optional**: During an install, update, or modify command, this parameter (which must have the word true or false immediately after it) tells the Visual Studio installer to remove (or don't remove) all installed components that have transitioned to an out-of-support state. This behavior is applicable for a single event. If you want to make this behavior persistent, apply this parameter to the modifySettings command which is described below, or [configure the removeOOS global policy](configure-policies-for-enterprise-deployments.md). Useful for helping to keep the machine secure.  |
| `--config <path>`                                  | **Optional**: During an install or modify operation, this determines the workloads and components to add based on a previously saved installation configuration file. This operation is additive and it won't remove any workload or component if they aren't present in the file. Also, items that don't apply to the product won't be added. During an export operation, this determines the location to save the installation configuration file.  |
| `--help, --?, -h, -?`                              | Displays an offline version of this page.     |

## Layout command and command-line parameters

All layout management operations are run using the bootstrapper exe and they assume that the command is the default Install (blank), regardless of if you're creating or updating a layout. So, all layout management operations should start with the initial required `--layout` parameter. The table below describes the other parameters you can use to [create or update a layout](create-a-network-installation-of-visual-studio.md) using the command line. 

| **Layout parameters**                           | **Description**                                        |
|-------------------------------------------------|----------------------------------------------------------------------|
| `--layout <dir>`                                | Specifies a directory to create or update an offline install cache. For more information, see [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md).                       |
| `--lang <one or more language-locales>`         | **Optional**: Used with `--layout` to prepare an offline install cache with resource packages with the specified language(s). For more information, see the [List of language locales](#list-of-language-locales) section on this page.       |
| `--add <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional`. For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeOptional`). For more information, see the [Workload and component IDs](workload-and-component-ids.md) page. <br/>**Note**: If `--add` is used, only the specified workloads and components and their dependencies are downloaded. If `--add` isn't specified, all workloads and components are downloaded to the layout. |
| `--includeRecommended`                          | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`.         |
| `--includeOptional`                             | **Optional**: Includes the recommended *and* optional components for any workloads being included in the layout. The workloads are specified with `--add`.                        |
| `--wait`                       | **Optional**: The process will wait until the install is completed before returning an exit code. This is useful when automating installations where one needs to wait for the install to finish to handle the return code from that install.      |
| `--useLatestInstaller`         | **Optional**: If present, the latest version of the Visual Studio Installer will be included in your layout, even if it belongs to a newer version of the product. This can be useful if you want to take advantage of new features or bug fixes that are available in the latest installer. For more information, refer to [Configure the layout to always use the latest installer](create-a-network-installation-of-visual-studio.md#configure-the-layout-to-always-include-and-provide-the-latest-installer) documentation. |
| `--config <*.vsconfig>`      | **Optional**: If present, Visual Studio will use the [contents of the configuration file](import-export-installation-configurations.md) to configure your layout. |
| `--noWeb`                      | **Optional**: If present, Visual Studio setup uses the files in your layout directory to install Visual Studio. If a user tries to install components that aren't in the layout, setup fails.  For more information, see [Deploying from a network installation](create-a-network-installation-of-visual-studio.md). <br/><br/> **Important**: This switch doesn't stop Visual Studio setup from checking for updates. For more information, see [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md). |
| `--verify`                                      | **Optional**: Verify the contents of a layout. Any corrupt or missing files are listed.            |
| `--fix`                                         | **Optional**: Verify the contents of a layout. If any files are corrupt or missing, they're redownloaded. Internet access is required to fix a layout.           |
| `--clean <one or more paths to catalogs>`       | **Optional**: Removes old versions of components from a layout that has been updated to a newer version.    |

| **Advanced layout parameters** | **Description**                                  |
|--------------------------------|--------------------------------------------------|
| `--channelId <id>`             | **Optional**: The ID of the channel for the instance to be installed. This is required for the install command, and ignored for other commands if `--installPath` is specified.        |
| `--channelUri <uri>`           | **Optional**: The URI of the channel manifest. This value governs the [source location of updates](update-visual-studio.md#configure-source-location-of-updates-1) and the initial value is [configured in the layout's response.json file](create-a-network-installation-of-visual-studio.md#configure-initial-client-installation-defaults-for-this-layout). Refer to [syntax examples of --channelUri](/visualstudio/install/command-line-parameter-examples#using---channelUri) for possible values. If updates aren't wanted, `--channelUri` can point to a non-existent file (for example, --channelUri C:\doesntExist.chman). This can be used for the install command; it's ignored for other commands.  |
| `--installChannelUri <uri>`    | **Optional**: The URI of the channel manifest to use for the installation. The URI specified by `--channelUri` (which must be specified when `--installChannelUri` is specified) is used to detect updates. This can be used for the install command; it's ignored for other commands.  |
| `--installCatalogUri <uri>`    | **Optional**: The URI of the catalog manifest to use for the installation. If specified, the channel manager attempts to download the catalog manifest from this URI before using the URI in the install channel manifest. This parameter is used to support offline install, where the layout cache will be created with the product catalog already downloaded. This can be used for the install command; it's ignored for other commands.    |
| `--productId <id>`             | **Optional**: The ID of the product for the instance that will be installed. This is pre-populated in normal installation conditions. The `productID` is something like "Microsoft.VisualStudio.Product.Enterprise". |
| `--arch all`                   | **Optional**: By default, layouts are created with only x64 product binaries. To include ARM binaries for applicable workloads alongside the x64 binaries in a layout, use the `--arch all` or `--arch *` parameter. To create a layout of just ARM binaries, use `--arch arm64`  
| `--keepLayoutVersion`                           | **Optional**: Apply changes to the layout without updating the product version that's included in the layout.   |
| `--locale <language-locale>`   | **Optional**: Change the display language of the user interface for the installer itself. Setting will be persisted. For more information, see the [List of language locales](#list-of-language-locales) section on this page.     |
| `--cache`                      | **Optional**: If present, packages will be kept after being installed for subsequent repairs. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information.   |
| `--nocache`                    | **Optional**: If present, packages will be deleted after being installed or repaired. They'll be downloaded again only if needed and deleted again after use. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information.    |
| `--noUpdateInstaller`          | **Optional**: If present, prevents the installer from updating itself when quiet is specified. The installer will fail the command and return a non-zero exit code if noUpdateInstaller is specified with quiet when an installer update is required.   |
| `--path <name>=<path>`         | **Optional**: Used to specify custom install paths for the installation. Supported path names are shared, cache, and install.    |
| `--path cache=<path>`          | **Optional**: Uses the location you specify to download installation files. This location can only be set the first time that Visual Studio is installed. Example: `--path cache="C:\VS\cache"`   |
| `--path shared=<path>`         | **Optional**: Contains shared files for side-by-side Visual Studio installations. Some tools and SDKs install to a location on this drive, while some others might override this setting and install to another drive. Example: `--path shared="C:\VS\shared"` <br/><br/>**Important**: This can be set only once and on the first time that Visual Studio is installed.     |
| `--path install=<path>`        | **Optional**: Equivalent to `–-installPath`. Specifically, `--installPath "C:\VS"` and `--path install="C:\VS"` are equivalent. Only one of these commands can be used at a time.     |

## ModifySettings command and command-line parameters
You can modify the update settings and programmatically configure the source location of updates for a given instance of Visual Studio by using either the installer or the bootstrapper on the client machine, and passing in the modifySettings command and the desired update channel.  

| **Command** | **Description**                                                                                                         |
|-------------|-------------------------------------------------------------------------------------------------------------------------|
| `modifySettings`     | Verb used to modify the update settings of a particular instance of Visual Studio.                               |

| **modifySettings parameters**                   | **Description**                                        |
|-------------------------------------------------|----------------------------------------------------------------------|
| `--installPath <dir>`                           | **Recommended** to use to specify which instance of Visual Studio to act upon.  |
| `--newChannelUri`                               | **Required**: The URI of the channel manifest. This value specifies where the next [source location of updates](update-visual-studio.md#configure-source-location-of-updates-1) will be. Refer to [syntax examples of --channelUri](/visualstudio/install/command-line-parameter-examples#using---channelUri) for possible values. If updates aren't wanted, `--channelUri` can point to a non-existent file (for example, --channelUri C:\doesntExist.chman). |
| `--channelUri`                               | The URI of the old channel manifest. Can be used if the --installPath is not known. Must be used in conjunction with productID to identify the right instance to act upon. |
| `--productId <id>`                           | Must be used if --channelUri is specified and is used to identify the right instance to act upon. The `productID` is something like "Microsoft.VisualStudio.Product.Enterprise". |
| `--quiet, -q`                                   | **Optional**: This parameter prevents any user interface from being displayed while the command is being executed. |
| `--removeOos true`                              | **Optional**: During a modifySettings command, this parameter (which must have the word true or false immediately after it) tells the Visual Studio installer to _persistently_ remove (or not remove) all installed components that have transitioned to an out-of-support state. Useful for helping to keep the machine secure. | 

Syntax examples: 

  ```shell
  C:\>"C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" modifySettings --installPath "C:\Program Files\Microsoft\Visual Studio\2022\Enterprise" --newChannelUri https://aka.ms/vs/17/release.LTSC.17.0/channel --removeOos true
  ```

  ```shell 
   C:\>"C:\Program Files\Microsoft\Visual Studio\2022\Enterprise\vs_enterprise.exe" modifySettings --channelUri https://aka.ms/vs/17/release.LTSC.17.0/channel --productID Microsoft.VisualStudio.Product.Enterprise --newChannelUri \\layoutserver\share\path\channelmanifest.json --removeOos true --quiet
  ``` 

## Rollback command and command-line parameters
You can roll back the update programmatically by using the installer on the client machine, and passing in the rollback command alongside the installation path instance.  

| **Command** | **Description**                                                                                                         |
|-------------|-------------------------------------------------------------------------------------------------------------------------|
| `rollback`     | Command to rollback a particular instance of Visual Studio to the previously installed update. This command will not work if the [`DisableRollback`](configure-policies-for-enterprise-deployments.md) is enabled.   |
 
| **rollback parameters**                   | **Description**                                                                           |
|-------------------------------------------|-------------------------------------------------------------------------------------------|
| `--installPath <dir>`                     | **Recommended** to use to specify which instance of Visual Studio to act upon.            |

Syntax examples: 

  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" rollback -–installPath "C:\Program Files\Microsoft Visual Studio\2022\Enterprise"
  ```
  
## Administrator Update command and command-line parameters

You can download an **Administrator Update** from the [Microsoft Update Catalog](https://catalog.update.microsoft.com) and use it to update either your client installation or your layout. 

### Updating a layout

If you're updating a layout to a particular version of Visual Studio, just download the Administrator Update to the computer that's hosting the layout, open up a command prompt on that computer and run a command like this:

```shell
visualstudioupdate-17.0.0to17.1.5.exe layout --layoutPath c:\VSLayout
```

### Updating a client

On the client, if you download the Administrator Update into your installation directory on your client machine, you can just double-click on the file to apply the update. You can also open a command window and pass some of the parameters below to change the default behavior. 

### Configuring the Administrator Update in SCCM

If you are deploying the administrator update through Microsoft Endpoint Manager (SCCM), you can modify the package to adjust the behavior by using the parameters below. You can also control the parameters via a configuration file on the client machine. For more information, refer to [Methods for configuring an administrator update](../install/applying-administrator-updates.md#methods-for-configuring-an-administrator-update)

Note that all Administrator Update parameters are default run in the "update" context unless the layout verb is specified.

| **Administrator update parameters**           | **Description**  |
|-----------------------------------------------|------------------|
| `--installerUpdateArgs [optional parameters]` | This parameter functions as a "pass-through array" of specific parameters that are relevant to administrator update scenarios. Optional parameters that are enabled for this purpose are: <br/><br/> `--quiet`: This is the default experience for administrator updates and is listed here for completeness. <br/> `--passive`: This parameter overrides the `--quiet` parameter.  It causes the UI to appear in a non-interactive manner. <br/>`--norestart`: This parameter must be used in conjunction with either `--quiet` or `--passive` and it causes any necessary reboots to be delayed. <br/>`--noWeb`: This parameter prevents Visual Studio from checking on the internet for updates to the product. <br/>`--force`: This parameter forces Visual Studio to close even if Visual Studio is in use. Use this parameter with caution, as it may cause loss of work. This parameter must only be used when the Administrator update is executed in user context; it is ignored if the Administrator update is executed in system context. <br/>`--installWhileDownloading`: This parameter allows Visual Studio to both download and install the product in parallel. It's the default experience for administrator updates and is listed here for completeness. <br/>`--keepWindowsUpdateOn`: This parameter prevents the installer from turning off the Windows Update agent on the client. You should use this parameter if you're importing an Administrator update from the Catalog into SCCM. You may also need to set the SCCM package timeout to be longer than the default 10 minutes. Changing the SCCM deployment type to be Required makes this parameter unnecessary.<br/>`--downloadThenInstall`: This parameter forces Visual Studio to download all files before installing them. It is mutually exclusive from the `--installWhileDownloading` parameter. |
| `--checkPendingReboot`                        | The update will be aborted if there is a pending reboot on the machine, regardless of which application may have caused it. The default is to not check for pending reboots.    |

Syntax example for passing parameters into an Administrator update:

```shell
visualstudioupdate-16.9.0to16.9.4.exe --installerUpdateArgs=--force,--noWeb,--keepWindowsUpdateOn --checkPendingReboot
```

## Remove channel command and command-line parameters
Channels that are available to update from, are cached on the client, and over time they can clutter things up. You can manually remove [update channels](update-visual-studio.md#configure-source-location-of-updates-1) by bringing up the Visual Studio Installer, switching to the **Available** tab, and clicking on the **X** in the top right corner of the product card. You can programmatically remove channels (for example, older layout locations) using the `removeChannel` command. You can run [vswhere](tools-for-managing-visual-studio-instances.md#using-vswhereexe) programmatically on the client machine to determine which channels are cached on the client machine. 


| **Command** | **Description**                                                                                                         |
|-------------|-------------------------------------------------------------------------------------------------------------------------|
| `removeChannel`  | Command to remove a channel from the client machine.   |
 
| **removeChannel parameters**                   | **Description**                                                                      |
|-------------------------------------------|-------------------------------------------------------------------------------------------|
| `--channelUri`                | **Required** The URI of the old channel manifest.            |
| `--quiet`                     | **Optional** This parameter prevents any user interface from being displayed while the command is being executed.            |
| `--passive`                   | **Optional** This parameter overrides the `--quiet` parameter.  It causes the UI to appear in a non-interactive manner.    |

Syntax example: 

  ```shell
  "C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" removeChannel --channelUri "\\\\server\\share\\layoutdirectory\\ChannelManifest.json"
  ```

## Use winget to install Visual Studio

You can use the [Windows Package Manager](/windows/package-manager/winget/) "winget" tool to programmatically install or update Visual Studio on your machines along other packages managed by winget. By default, winget just installs the Visual Studio core workload. 

  ```shell
  winget install --id Microsoft.VisualStudio.2022.Community
  ```
  
However, if you want to customize the installation and specify additional workloads and components, you can use winget's `--override` switch alongside winget's `install` command, and pass in an [exported vsconfig file](/import-export-installation-configurations.md) like this:

  ```shell
  winget install --id Microsoft.VisualStudio.2022.Community --override "--passive --config c:\my.vsconfig"
  ```

Of course, you can also just include components directly during the initial installation, like this:

 ```shell
  winget install --id Microsoft.VisualStudio.2022.Community --override "--quiet --add Microsoft.Visualstudio.Workload.Azure"
  ```

If you already have Visual Studio installed on your machine, then it's not possible to use winget's `--override` switch alongside winget's `install` or `upgrade` commands. This means that you can't use Visual Studio's `--config` or `--add` parameters to modify an existing installation and add components to it.  

Remember that Visual Studio installations and updates require administrator privileges, so winget will prompt you to elevate your privileges if necessary to complete the command. Also, it's not currently possible to use winget to install multiple editions (that is, different SKUs) or multiple instances of the same SKU at the same time on a client machine. 

## List of workload IDs and component IDs

For a list of workload and component IDs sorted by Visual Studio product, see the [Visual Studio workload and component IDs](workload-and-component-ids.md) page.

## List of language locales

| **Language-locale** | **Language**          |
|---------------------|-----------------------|
| Cs-cz               | Czech                 |
| De-de               | German                |
| En-us               | English               |
| Es-es               | Spanish               |
| Fr-fr               | French                |
| It-it               | Italian               |
| Ja-jp               | Japanese              |
| Ko-kr               | Korean                |
| Pl-pl               | Polish                |
| Pt-br               | Portuguese - Brazil   |
| Ru-ru               | Russian               |
| Tr-tr               | Turkish               |
| Zh-cn               | Chinese - Simplified  |
| Zh-tw               | Chinese - Traditional |

## Error codes

Depending on the result of the operation, the `%ERRORLEVEL%` environment variable is set to one of the following values:

[!INCLUDE[install-error-codes-md](includes/install-error-codes-md.md)]

Each operation generates several log files in the `%TEMP%` directory that indicate the progress of the installation. Sort the folder by date and look for files that begin with `dd_bootstrapper`, `dd_client`, and `dd_setup` for the bootstrapper, the installer app, and the setup engine, respectively.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

- [Command-line parameter examples for Visual Studio installation](command-line-parameter-examples.md)
- [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
- [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md)
- [Visual Studio workload and component IDs](workload-and-component-ids.md)
