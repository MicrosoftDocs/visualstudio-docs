---
title: "Use command-line parameters to install Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/17/2018"
ms.reviewer: "tims"
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "command-line parameters"
  - "switches"
  - "command prompt"
ms.assetid: 480f3cb4-d873-434e-a8bf-82cff7401cf2
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
ms.workload:
  - "multiple"
---
# Use command-line parameters to install Visual Studio 2017
When you install Visual Studio 2017 from a command prompt, you can use a variety of command-line parameters to control or customize the installation. From the command line, you can perform the following actions:

- Start the install with certain options preselected.
- Automate the installation process.
- Create a cache (layout) of the installation files for later use.

The command-line options are used in conjunction with the setup bootstrapper, which is the small (approximately 1MB) file that initiates the download process. The bootstrapper is the first executable that is launched when you download from the Visual Studio site. Use the following links to get a direct link to the latest release bootstrapper for the product edition that you're installing:

* [Visual Studio 2017 Enterprise](https://aka.ms/vs/15/release/vs_enterprise.exe)
* [Visual Studio 2017 Professional](https://aka.ms/vs/15/release/vs_professional.exe)
* [Visual Studio 2017 Community](https://aka.ms/vs/15/release/vs_community.exe)

## List of command-line parameters  
 Visual Studio command-line parameters are case-insensitive.

> Syntax: `vs_enterprise.exe [command] <options>...`

(Replace `vs_enterprise.exe` as appropriate for the product edition you're installing.)

>[!TIP]
> For more examples of how to use the command line to install Visual Studio 2017, see the [Command-line parameter examples](command-line-parameter-examples.md) page.)

| **Command** | **Description** |
| ----------------------- | --------------- |
| (blank) | Installs the product. |
| `modify` | Modifies an installed product. |
| `update` | Updates an installed product. |
| `repair` | Repairs an installed product. |
| `uninstall` | Uninstalls an installed product. |

| **Install option** | **Description** |
| ----------------------- | --------------- |
| `--installPath <dir>` | The installation directory for the instance to act upon. For the install command, this is **Optional** and is where the instance will be installed. For other commands, this is **Required** and is where the previously installed instance was installed. |
| `--addProductLang <language-locale>` | **Optional**: During an install or modify operation, this determines the UI language packs that are installed to the product. It can appear multiple times on the command line to add multiple language packs. If not present, the installation uses the machine locale. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--removeProductLang <language-locale>` | **Optional**: During an install or modify operation, this determines the UI language packs that are to be removed from the product. It can appear multiple times on the command line to add multiple language packs. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--add <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional`. For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeRecommended;includeOptional`). For more information, see our [Workload and component IDs](workload-and-component-ids.md) page. You can repeat this option as necessary.|
| `--remove <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to remove. For more information, see our [Workload and component IDs](workload-and-component-ids.md) page. You can repeat this option as necessary.|
| `--in <path>` | **Optional**: The URI or path to a response file.  |
| `--all` | **Optional**: Whether to install all workloads and components for a product. |
| `--allWorkloads` | **Optional**: Installs all workloads and components, no recommended or optional components. |
| `--includeRecommended` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`. |
| `--includeOptional` | **Optional**: Includes the optional components for any workloads that are installed, but not the recommended components. The workloads are specified either with `--allWorkloads` or `--add`.  |
| `--quiet, -q` | **Optional**: Do not display any user interface while performing the installation. |
| `--passive, -p` | **Optional**: Display the user interface, but do not request any interaction from the user. |
| `--norestart` | **Optional**: If present, commands with `--passive` or `--quiet` will not automatically restart the machine (if required).  This is ignored if neither `--passive` nor `--quiet` are specified.  |
| `--nickname <name>` | **Optional**: This defines the nickname to assign to an installed product. The nickname cannot be longer than 10 characters.  |
| `--productKey` | **Optional**: This defines the product key to use for an installed product. It is composed of 25 alphanumeric characters either in the format `xxxxx-xxxxx-xxxxx-xxxxx-xxxxx` or `xxxxxxxxxxxxxxxxxxxxxxxxx`. |
| `--help, --?, -h, -?` | Display an offline version of this page. |

> Note: When specifying multiple workloads and components, you must repeat the `--add` or `--remove` command-line switch for each item.

| **Layout options** | **Description** |
| ----------------------- | --------------- |
| `--layout <dir>` | Specifies a directory to create an offline install cache. For more information, see [Create a network-based installation of Visual Studio](create-a-network-installation-of-visual-studio.md).|
| `--lang <one or more language-locales>` | **Optional**: Used with `--layout` to prepare an offline install cache with resource packages with the specified language(s). For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--add <one or more workload or component IDs>` | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using `--includeRecommended` and/or `--includeOptional`. For finer-grained control, you can append `;includeRecommended` or `;includeOptional` to the ID (for example, `--add Workload1;includeRecommended` or `--add Workload2;includeOptional`). For more information, see our [Workload and component IDs](workload-and-component-ids.md) page. <br/>**Note**: If `--add` is used, only the specified workloads and components and their dependencies are downloaded. If `--add` is not specified, all workloads and components are downloaded to the layout.|
| `--includeRecommended` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with `--allWorkloads` or `--add`. |
| `--includeOptional` | **Optional**: Includes the recommended *and* optional components for any workloads being included in the layout. The workloads are specified with `--add`.  |
| `--keepLayoutVersion` | **New in 15.3, optional**: Apply changes to the layout without updating the version of the layout. |
| `--verify` | **New in 15.3, optional**: Verify the contents of a layout.  Any corrupt or missing files are listed. |
| `--fix` | **New in 15.3, optional**: Verify the contents of a layout.  If any files are found to be corrupt or missing, they are re-downloaded.  Internet access is required to fix a layout. |
| `--clean <one or more paths to catalogs>` | **New in 15.3, optional**: Removes old versions of components from a layout that has been updated to a newer version. |

| **Advanced install options** | **Description** |
| ----------------------- | --------------- |
| `--channelId <id>` | **Optional**: The ID of the channel for the instance to be installed. This is required for the install command, ignored for other commands if `--installPath` is specified. |
| `--channelUri <uri>` | **Optional**: The URI of the channel manifest. If updates are not desired, `--channelUri` can point to a non-existent file. (for example, --channelUri C:\doesntExist.chman) This can be used for the install command; it is ignored for other commands. |
| `--installChannelUri <uri>` | **Optional**: The URI of the channel manifest to use for the installation. The URI specified by `--channelUri` (which must be specified when `--installChannelUri` is specified) is used to detect updates. This can be used for the install command; it is ignored for other commands. |
| `--installCatalogUri <uri>` | **Optional**: The URI of the catalog manifest to use for the installation. If specified, the channel manager attempts to download the catalog manifest from this URI before using the URI in the install channel manifest. This parameter is used to support offline install, where the layout cache will be created with the product catalog already downloaded. This can be used for the install command; it is ignored for other commands. |
| `--productId <id>` | **Optional** The ID of the product for the instance that will be installed. This is prepopulated in normal installation conditions. |
| `--wait` | **Optional**: The process will wait until the install is completed before returning an exit code. This is useful when automating installations where one needs to wait for the install to finish to handle the return code from that install. |
| `--locale <language-locale>` | **Optional**: Change the display language of the user interface for the installer itself. Setting will be persisted. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| `--cache` | **New in 15.2, optional**: If present, packages will be kept after being installed for subsequent repairs. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `--nocache` | **New in 15.2, optional**: If present, packages will be deleted after being installed or repaired. They will be downloaded again only if needed and deleted again after use. This overrides the global policy setting to be used for subsequent installs, repairs, or modifications. The default policy is to cache packages. This is ignored for the uninstall command. Read how to [disable or move the package cache](disable-or-move-the-package-cache.md) for more information. |
| `--noUpdateInstaller` | **New in 15.2, optional**: If present, prevents the installer from updating itself when quiet is specified. The installer will fail the command and return a non-zero exit code if noUpdateInstaller is specified with quiet when an installer update is required. |
| `--noWeb` | **New in 15.3, optional**: Setup now downloads any content that it is installing from the Internet.  All content that is being installed must be available in an offline layout.  If the layout is missing content, setup fails.  For more information, see [Deploying from a network installation](create-a-network-installation-of-visual-studio.md). |

## List of workload IDs and component IDs
For a list of workload and component IDs sorted by Visual Studio product, see the [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## List of language locales
| **Language-locale** | **Language** |
| ----------------------- | --------------- |
| cs-CZ | Czech |
| de-DE | German |
| en-US | English |
| es-ES | Spanish |
| fr-FR | French |
| it-IT | Italian |
| ja-JP | Japanese |
| ko-KR | Korean |
| pl-PL | Polish |
| pt-BR | Portuguese - Brazil |
| ru-RU | Russian |
| tr-TR | Turkish |
| zh-CN | Chinese - Simplified |
| zh-TW | Chinese - Traditional |

## Error codes
Depending on the result of the operation, the `%ERRORLEVEL%` environment variable will be set to one of the following values:

| **Value** | **Result** |
| --------- | ---------- |
| 0 | Operation completed successfully |
| 1602 | Operation was canceled |
| 3010 | Operation completed successfully, but install requires reboot before it can be used |
| 5004 | Operation was canceled |
| 5007 | Operation was blocked - the computer does not meet the requirements |
| Other | Failure condition occurred - check the logs for more information |

Each operation generates several log files in the `%TEMP%` directory that indicate the progress of the installation. Sort the folder by date and look for files that begin with `dd_bootstrapper`, `dd_client`, and `dd_setup` for the bootstrapper, the installer app, and the setup engine, respectively.

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also

 * [Command-line parameter examples for Visual Studio 2017 installation](command-line-parameter-examples.md)
 * [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
 * [Automate Visual Studio installation with a response file](automated-installation-with-response-file.md)
