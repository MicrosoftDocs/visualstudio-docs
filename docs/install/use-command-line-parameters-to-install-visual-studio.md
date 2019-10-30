---
title: "Use command-line parameters to install Visual Studio"
titleSuffix: ""
description: "Learn how to use command-line parameters to control or customize your Visual Studio installation."
ms.date: 10/22/2019
ms.custom: "seodec18"
ms.topic: conceptual
f1_keywords:
  - "command-line parameters"
  - "switches"
  - "command prompt"
ms.assetid: 480f3cb4-d873-434e-a8bf-82cff7401cf2
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Use command-line parameters to install Visual Studio

When you install Visual Studio from a command prompt, you can use a variety of command-line parameters to control or customize the installation. From the command line, you can perform the following actions:

- Start the install with certain options preselected.
- Automate the installation process.
- Create a cache (layout) of the installation files for later use.

The command-line options are used in conjunction with the setup bootstrapper, which is the small (1 MB) file that initiates the download process. The bootstrapper is the first executable that is launched when you download from the Visual Studio site.

::: moniker range="vs-2017"

To get a bootstrapper for Visual Studio 2017, see the [**Visual Studio previous versions**](https://visualstudio.microsoft.com/vs/older-downloads/) download page for details on how to do so.

::: moniker-end

::: moniker range="vs-2019"

Use the following links to get a direct link to the latest release bootstrapper for the product edition that you're installing:

- [Visual Studio 2019 Enterprise](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=enterprise&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=link+cta&utm_content=download+commandline+parameters+vs2019+rc)
- [Visual Studio 2019 Professional](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=professional&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=link+cta&utm_content=download+commandline+parameters+vs2019+rc)
- [Visual Studio 2019 Community](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=community&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=link+cta&utm_content=download+commandline+parameters+vs2019+rc)

::: moniker-end


Your bootstrapper file should match or be similar to one of the following file names:

* vs_enterprise.exe
* vs_professional.exe
* vs_community.exe

>[!TIP]
>If you previously downloaded a bootstrapper file and want to verify its version, here's how. In Windows, open File Explorer, right-click the bootstrapper file, choose **Properties**, choose the **Details** tab, and then view the **Product version** number. To match that number to a release of Visual Studio, see the [Visual Studio build numbers and release dates](visual-studio-build-numbers-and-release-dates.md) page.

## Command-line parameters

 Visual Studio command-line parameters are case-insensitive.

> Syntax: `vs_enterprise.exe [command] <options>...`

Replace `vs_enterprise.exe` as appropriate for the product edition you're installing. (Alternatively, you can use `vs_installer.exe`.)

>[!TIP]
> For more examples of how to use the command line to install Visual Studio, see the [Command-line parameter examples](command-line-parameter-examples.md) page.

::: moniker range="vs-2017"

| **Command** | **Description** |
| ----------------------- | --------------- |
| (blank) | Installs the product. |
| `modify` | Modifies an installed product. |
| `update` | Updates an installed product. |
| `repair` | Repairs an installed product. |
| `uninstall` | Uninstalls an installed product. |
| `export` | **New in version 15.9**: Exports installation selection to an installation configuration file. **Note**: Can only be used with vs_installer.exe. |

::: moniker-end

::: moniker range="vs-2019"

| **Command** | **Description** |
| ----------------------- | --------------- |
| (blank) | Installs the product. |
| `modify` | Modifies an installed product. |
| `update` | Updates an installed product. |
| `repair` | Repairs an installed product. |
| `uninstall` | Uninstalls an installed product. |
| `export` | Exports installation selection to an installation configuration file. **Note**: Can only be used with vs_installer.exe. |

::: moniker-end

## Install options

::: moniker range="vs-2017"

| **Install option** | **Description** |
| ----------------------- | --------------- |
| `--installPath <dir>` | The installation directory for the instance to act upon. For the install command, this is **Optional** and is where the instance will be installed. For other commands, this is **Required** and is where the previously installed instance was installed. |
| `--addProductLang <language-locale>` | **Optional**: During an install or modify operation, this determines the UI language packs that are installed to the product. It can appear multiple times on the command line to add multiple language packs. If not present, the installation uses the machine locale. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--removeProductLang <language-locale>` | **Optional**: During an install or modify operation, this determines the UI language packs that are to be removed from the product. It can appear multiple times on the command line to add multiple language packs. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--add <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional`. To include multiple workloads or components, repeat the `--add` command (for example, `--add Workload1 --add Workload2`). For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeRecommended;includeOptional`). For more information, see the [Workload and component IDs](workload-and-component-ids.md) page. You can repeat this option as necessary.|
| `--remove <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to remove. For more information, see our [Workload and component IDs](workload-and-component-ids.md) page. You can repeat this option as necessary.|
| `--in <path>` | **Optional**: The URI or path to a response file.  |
| `--all` | **Optional**: Whether to install all workloads and components for a product. |
| `--allWorkloads` | **Optional**: Installs all workloads and components, no recommended or optional components. |
| `--includeRecommended` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`. |
| `--includeOptional` | **Optional**: Includes the optional components for any workloads that are installed, but not the recommended components. The workloads are specified either with `--allWorkloads` or `--add`.  |
| `--quiet, -q` | **Optional**: Don't display any user interface while performing the installation. |
| `--passive, -p` | **Optional**: Display the user interface, but don't request any interaction from the user. |
| `--norestart` | **Optional**: If present, commands with `--passive` or `--quiet` won't automatically restart the machine (if necessary).  This is ignored if neither `--passive` nor `--quiet` are specified.  |
| `--nickname <name>` | **Optional**: This defines the nickname to assign to an installed product. The nickname can't be longer than 10 characters.  |
| `--productKey` | **Optional**: This defines the product key to use for an installed product. It's composed of 25 alphanumeric characters either in the format `xxxxx-xxxxx-xxxxx-xxxxx-xxxxx` or `xxxxxxxxxxxxxxxxxxxxxxxxx`. |
| `--help, --?, -h, -?` | Display an offline version of this page. |
| `--config <path>` | **Optional** and **New in 15.9**: During an install or modify operation, this determines the workloads and components to add based on a previously saved installation configuration file. This operation is additive and it won't remove any workload or component if they aren't present in the file. Also, items that don't apply to the product won't be added. During an export operation, this determines the location to save the installation configuration file. |

::: moniker-end

::: moniker range="vs-2019"

| **Install option** | **Description** |
| ----------------------- | --------------- |
| `--installPath <dir>` | The installation directory for the instance to act upon. For the install command, this is **Optional** and is where the instance will be installed. For other commands, this is **Required** and is where the previously installed instance was installed. |
| `--addProductLang <language-locale>` | **Optional**: During an install or modify operation, this determines the UI language packs that are installed to the product. It can appear multiple times on the command line to add multiple language packs. If not present, the installation uses the machine locale. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--removeProductLang <language-locale>` | **Optional**: During an install or modify operation, this determines the UI language packs that are to be removed from the product. It can appear multiple times on the command line to add multiple language packs. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--add <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional`. To include multiple workloads or components, repeat the `--add` command (for example, `--add Workload1 --add Workload2`). For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeRecommended;includeOptional`). For more information, see the [Workload and component IDs](workload-and-component-ids.md) page. You can repeat this option as necessary.|
| `--remove <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to remove. For more information, see our [Workload and component IDs](workload-and-component-ids.md) page. You can repeat this option as necessary.|
| `--in <path>` | **Optional**: The URI or path to a response file.  |
| `--all` | **Optional**: Whether to install all workloads and components for a product. |
| `--allWorkloads` | **Optional**: Installs all workloads and components, no recommended or optional components. |
| `--includeRecommended` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`. |
| `--includeOptional` | **Optional**: Includes the optional components for any workloads that are installed, but not the recommended components. The workloads are specified either with `--allWorkloads` or `--add`.  |
| `--quiet, -q` | **Optional**: Don't display any user interface while performing the installation. |
| `--passive, -p` | **Optional**: Display the user interface, but don't request any interaction from the user. |
| `--norestart` | **Optional**: If present, commands with `--passive` or `--quiet` won't automatically restart the machine (if necessary).  This is ignored if neither `--passive` nor `--quiet` are specified.  |
| `--nickname <name>` | **Optional**: This defines the nickname to assign to an installed product. The nickname can't be longer than 10 characters.  |
| `--productKey` | **Optional**: This defines the product key to use for an installed product. It's composed of 25 alphanumeric characters either in the format `xxxxx-xxxxx-xxxxx-xxxxx-xxxxx` or `xxxxxxxxxxxxxxxxxxxxxxxxx`. |
| `--help, --?, -h, -?` | Display an offline version of this page. |
| `--config <path>` | **Optional**: During an install or modify operation, this determines the workloads and components to add based on a previously saved installation configuration file. This operation is additive and it won't remove any workload or component if they aren't present in the file. Also, items that don't apply to the product won't be added. During an export operation, this determines the location to save the installation configuration file. |

::: moniker-end

> [!IMPORTANT]
> When specifying multiple workloads and components, you must repeat the `--add` or `--remove` command-line switch for each item.

## Layout options

::: moniker range="vs-2017"

| **Layout options** | **Description** |
| ----------------------- | --------------- |
| `--layout <dir>` | Specifies a directory to create an offline install cache. For more information, see [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md).|
| `--lang <one or more language-locales>` | **Optional**: Used with `--layout` to prepare an offline install cache with resource packages with the specified language(s). For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--add <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional`. For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeOptional`). For more information, see the [Workload and component IDs](workload-and-component-ids.md) page. <br/>**Note**: If `--add` is used, only the specified workloads and components and their dependencies are downloaded. If `--add` isn't specified, all workloads and components are downloaded to the layout.|
| `--includeRecommended` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`. |
| `--includeOptional` | **Optional**: Includes the recommended *and* optional components for any workloads being included in the layout. The workloads are specified with `--add`.  |
| `--keepLayoutVersion` | **New in 15.3, optional**: Apply changes to the layout without updating the version of the layout. |
| `--verify` | **New in 15.3, optional**: Verify the contents of a layout. Any corrupt or missing files are listed. |
| `--fix` | **New in 15.3, optional**: Verify the contents of a layout. If any files are corrupt or missing, they're redownloaded. Internet access is required to fix a layout. |
| `--clean <one or more paths to catalogs>` | **New in 15.3, optional**: Removes old versions of components from a layout that has been updated to a newer version. |

| **Advanced install options** | **Description** |
| ----------------------- | --------------- |
| `--channelId <id>` | **Optional**: The ID of the channel for the instance to be installed. This is required for the install command, and ignored for other commands if `--installPath` is specified. |
| `--channelUri <uri>` | **Optional**: The URI of the channel manifest. If updates aren't wanted, `--channelUri` can point to a non-existent file (for example, --channelUri C:\doesntExist.chman). This can be used for the install command; it's ignored for other commands. |
| `--installChannelUri <uri>` | **Optional**: The URI of the channel manifest to use for the installation. The URI specified by `--channelUri` (which must be specified when `--installChannelUri` is specified) is used to detect updates. This can be used for the install command; it's ignored for other commands. |
| `--installCatalogUri <uri>` | **Optional**: The URI of the catalog manifest to use for the installation. If specified, the channel manager attempts to download the catalog manifest from this URI before using the URI in the install channel manifest. This parameter is used to support offline install, where the layout cache will be created with the product catalog already downloaded. This can be used for the install command; it's ignored for other commands. |
| `--productId <id>` | **Optional** The ID of the product for the instance that will be installed. This is pre-populated in normal installation conditions. |
| `--wait` | **Optional**: The process will wait until the install is completed before returning an exit code. This is useful when automating installations where one needs to wait for the install to finish to handle the return code from that install. |
| `--locale <language-locale>` | **Optional**: Change the display language of the user interface for the installer itself. Setting will be persisted. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--cache` | **New in 15.2, optional**: If present, packages will be kept after being installed for subsequent repairs. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `--nocache` | **New in 15.2, optional**: If present, packages will be deleted after being installed or repaired. They'll be downloaded again only if needed and deleted again after use. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `--noUpdateInstaller` | **New in 15.2, optional**: If present, prevents the installer from updating itself when quiet is specified. The installer will fail the command and return a non-zero exit code if noUpdateInstaller is specified with quiet when an installer update is required. |
| `--noWeb` | **New in 15.3, optional**: If present, Visual Studio setup uses the files in your layout directory to install Visual Studio. If a user tries to install components that aren't in the layout, setup fails.  For more information, see [Deploying from a network installation](create-a-network-installation-of-visual-studio.md). <br/><br/> **Important**: This switch doesn't stop Visual Studio setup from checking for updates. For more information, see [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md). |
| `--path <name>=<path>` | **New in 15.7, optional**: Used to specify custom install paths for the installation. Supported path names are shared, cache, and install. |
| `--path cache=<path>` | **New in 15.7, optional**: Uses the location you specify to download installation files. This location can only be set the first time that Visual Studio is installed. Example: `--path cache="C:\VS\cache"` |
| `--path shared=<path>` | **New in 15.7, optional**: Contains shared files for side-by-side Visual Studio installations. Some tools and SDKs install to a location on this drive, while some others might override this setting and install to another drive. Example: `--path shared="C:\VS\shared"` <br><br>Important: This can be set only once and on the first time that Visual Studio is installed. |
| `--path install=<path>` | **New in 15.7, optional**: Equivalent to `–-installPath`. Specifically, `--installPath "C:\VS"` and `--path install="C:\VS"` are equivalent. Only one of these commands can be used at a time. |

::: moniker-end

::: moniker range="vs-2019"

| **Layout options** | **Description** |
| ----------------------- | --------------- |
| `--layout <dir>` | Specifies a directory to create an offline install cache. For more information, see [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md).|
| `--lang <one or more language-locales>` | **Optional**: Used with `--layout` to prepare an offline install cache with resource packages with the specified language(s). For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--add <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional`. For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeOptional`). For more information, see the [Workload and component IDs](workload-and-component-ids.md) page. <br/>**Note**: If `--add` is used, only the specified workloads and components and their dependencies are downloaded. If `--add` isn't specified, all workloads and components are downloaded to the layout.|
| `--includeRecommended` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`. |
| `--includeOptional` | **Optional**: Includes the recommended *and* optional components for any workloads being included in the layout. The workloads are specified with `--add`.  |
| `--keepLayoutVersion` | **Optional**: Apply changes to the layout without updating the version of the layout. |
| `--verify` | **Optional**: Verify the contents of a layout. Any corrupt or missing files are listed. |
| `--fix` | **Optional**: Verify the contents of a layout.  If any files are corrupt or missing, they're redownloaded. Internet access is required to fix a layout. |
| `--clean <one or more paths to catalogs>` | **Optional**: Removes old versions of components from a layout that has been updated to a newer version. |

| **Advanced install options** | **Description** |
| ----------------------- | --------------- |
| `--channelId <id>` | **Optional**: The ID of the channel for the instance to be installed. This is required for the install command, and ignored for other commands if `--installPath` is specified. |
| `--channelUri <uri>` | **Optional**: The URI of the channel manifest. If updates aren't wanted, `--channelUri` can point to a non-existent file (for example, --channelUri C:\doesntExist.chman). This can be used for the install command; it's ignored for other commands. |
| `--installChannelUri <uri>` | **Optional**: The URI of the channel manifest to use for the installation. The URI specified by `--channelUri` (which must be specified when `--installChannelUri` is specified) is used to detect updates. This can be used for the install command; it's ignored for other commands. |
| `--installCatalogUri <uri>` | **Optional**: The URI of the catalog manifest to use for the installation. If specified, the channel manager attempts to download the catalog manifest from this URI before using the URI in the install channel manifest. This parameter is used to support offline install, where the layout cache will be created with the product catalog already downloaded. This can be used for the install command; it's ignored for other commands. |
| `--productId <id>` | **Optional** The ID of the product for the instance that will be installed. This is pre-populated in normal installation conditions. |
| `--wait` | **Optional**: The process will wait until the install is completed before returning an exit code. This is useful when automating installations where one needs to wait for the install to finish to handle the return code from that install. |
| `--locale <language-locale>` | **Optional**: Change the display language of the user interface for the installer itself. Setting will be persisted. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--cache` | **Optional**: If present, packages will be kept after being installed for subsequent repairs. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `--nocache` | **Optional**: If present, packages will be deleted after being installed or repaired. They'll be downloaded again only if needed and deleted again after use. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `--noUpdateInstaller` | **Optional**: If present, prevents the installer from updating itself when quiet is specified. The installer will fail the command and return a non-zero exit code if noUpdateInstaller is specified with quiet when an installer update is required. |
| `--noWeb` | **Optional**: If present, Visual Studio setup uses the files in your layout directory to install Visual Studio. If a user tries to install components that aren't in the layout, setup fails.  For more information, see [Deploying from a network installation](create-a-network-installation-of-visual-studio.md). <br/><br/> **Important**: This switch doesn't stop Visual Studio setup from checking for updates. For more information, see [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md). **New in 16.3.5**: This switch prevents errors and improves performance with offline installs and updates.|
| `--path <name>=<path>` | **Optional**: Used to specify custom install paths for the installation. Supported path names are shared, cache, and install. |
| `--path cache=<path>` | **Optional**: Uses the location you specify to download installation files. This location can only be set the first time that Visual Studio is installed. Example: `--path cache="C:\VS\cache"` |
| `--path shared=<path>` | **Optional**: Contains shared files for side-by-side Visual Studio installations. Some tools and SDKs install to a location on this drive, while some others might override this setting and install to another drive. Example: `--path shared="C:\VS\shared"` <br><br>Important: This can be set only once and on the first time that Visual Studio is installed. |
| `--path install=<path>` | **Optional**: Equivalent to `–-installPath`. Specifically, `--installPath "C:\VS"` and `--path install="C:\VS"` are equivalent. Only one of these commands can be used at a time. |

::: moniker-end

## List of workload IDs and component IDs

For a list of workload and component IDs sorted by Visual Studio product, see the [Visual Studio workload and component IDs](workload-and-component-ids.md) page.

## List of language locales

| **Language-locale** | **Language** |
| ----------------------- | --------------- |
| Cs-cz | Czech |
| De-de | German |
| En-us | English |
| Es-es | Spanish |
| Fr-fr | French |
| It-it | Italian |
| Ja-jp | Japanese |
| Ko-kr | Korean |
| Pl-pl | Polish |
| Pt-br | Portuguese - Brazil |
| Ru-ru | Russian |
| Tr-tr | Turkish |
| Zh-cn | Chinese - Simplified |
| Zh-tw | Chinese - Traditional |

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
