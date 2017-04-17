---
title: "Use command-line parameters to install Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "04/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "command-line parameters"
  - "switches"
  - "command prompt"
ms.assetid: 480f3cb4-d873-434e-a8bf-82cff7401cf2
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Use command-line parameters to install Visual Studio 2017
When you install Visual Studio 2017 from a command prompt, you can use a variety of command-line parameters to control or customize the installation. From the command line, you can do the following:
- Start the install with certain options preselected.
- Automate the installation process.
- Create a cache (layout) of the installation files for later use.

The command-line options are used in conjunction with the setup bootstrapper, which is the small (approx. 1MB) file that initiates the download process. The bootstrapper is the first executable that is launched when you download from the Visual Studio site. You can get a direct link to the latest release bootstrapper for the product edition that you're installing from these links:

* [Visual Studio 2017 Enterprise](https://aka.ms/vs/15/release/vs_enterprise.exe)
* [Visual Studio 2017 Professional](https://aka.ms/vs/15/release/vs_professional.exe)
* [Visual Studio 2017 Community](https://aka.ms/vs/15/release/vs_community.exe)

## List of command-line parameters  
 Visual Studio command-line parameters are case-insensitive.

>  Syntax: `vs_enterprise.exe [command] <options>...`

(Replace `vs_enterprise.exe` as appropriate for the product edition you're installing. For examples, see the [Command-line parameter examples](command-line-parameter-examples.md) page.)


| **Command** | **Description** |
| ----------------------- | --------------- |
| (blank) | Installs the product. |
| ```modify``` | Modifies an installed product. |
| ```update``` | Updates an installed product. |
| ```repair``` | Repairs an installed product. |
| ```uninstall``` | Uninstalls an installed product. |


| **Install option** | **Description** |
| ----------------------- | --------------- |  
| ```--installPath <dir>``` | The installation directory for the instance to act upon. For the install command, this is where the instance will be installed. For other commands, this is where the previously-installed instance was installed. |
| ```--layout <dir>``` | **Optional**: Specifies a directory to create an offline install cache. Selecting this option will implicitly add the '--wait' option as well. If called from a batch file, this command will complete before execution passes to the next command in the batch file. |
| ```--lang <language-locale>``` *[&#60;language-locale&#62; ...]* | **Optional**: Used with --layout to prepare an offline install cache with resource packages with the specified language(s). For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| ```--addProductLang <language-locale>``` | **Optional**: During an install or modify operation, this determines the UI language packs that are to be installed to the product. It can appear multiple times on the command line to add multiple language packs. If not present, the installation will use the machine locale. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| ```--removeProductLang <language-locale>``` | **Optional**: During an install or modify operation, this determines the UI language packs that are to be removed from the product. It can appear multiple times on the command line to add multiple language packs. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| ```--add <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using '--includeRecommended' and/or '--includeOptional'. For finer-grained control, you can append ';includeRecommended' and/or ';includeOptional' to the artifactId (e.g. '--add Workload1;includeRecommended' or '--add Workload2;includeOptional;includeRecommended'). For more information, see our [Workload and component IDs](workload-and-component-ids.md) page.|
| ```--remove <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | **Optional**: One or more workload or component IDs to remove. For more information, see our [Workload and component IDs](workload-and-component-ids.md) page.|
| ```--in <path>``` | **Optional**: The URI or path to a response file.  |
| ```--all``` | **Optional**: Whether to install all workloads and components for a product. |
| ```--allWorkloads``` | **Optional**: Installs all workloads and their required components, no recommended or optional components. |
| ```--includeRecommended``` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with --allWorkloads or --add. |
| ```--includeOptional``` | **Optional**: Includes the optional components for any workloads that are installed, but not the recommended components. The workloads are specified either with --allWorkloads or --add.  |
| ```--quiet, -q``` | **Optional**: Do not display any user interface while performing the installation. |
| ```--passive, -p``` | **Optional**: Display the user interface, but do not request any interaction from the user. |
| ```--norestart``` | **Optional**: If present, commands with --passive or --quiet will not automatically restart the machine (if required). This is ignored if neither --passive nor --quiet are specified.  |
| ```--nickname <name>``` | **Optional**: This defines the nickname to assign to an installed product. The nickname cannot be longer than 10 characters.  |
| ```--productKey``` | **Optional**: This defines the product key to use for an installed product. It is composed of 25 alphanumeric characters either in the format 'xxxxx-xxxxx-xxxxx-xxxxx-xxxxx' or 'xxxxxxxxxxxxxxxxxxxxxxxxx'. |
| ```--help, --?, -h, -?``` | Display an offline version of this page. |

> Note: When specifying multiple workloads and components, you must repeat the `--add` or `--remove` command line switch for each item.

| **Advanced install options** | **Description** |
| ----------------------- | --------------- |  
| ```--channelId <id>``` | **Optional**: The ID of the channel for the instance that will be installed. This is required for the install command, ignored for other commands if --installPath is specified. |
| ```--channelUri <uri>``` | **Optional**: The URI of the channel manifest. This can be used for the install command; it is ignored for other commands. |
| ```--installChannelUri <uri>``` | **Optional**: The URI of the channel manifest to use for the installation. The URI specified by --channelUri (which must be specified when --installChannelUri is specified) will be used to detect updates. If updates are not desired, --channelUri must be specified without an argument. This can be used for the install command; it is ignored for other commands. |
| ```--installCatalogUri <uri>``` | **Optional**: The URI of the catalog manifest to use for the installation. If specified, the channel manager will attempt to download the catalog manifest from this URI before using the URI in the install channel manifest. This parameter is used to support offline install, where the layout cache will be created with the product catalog already downloaded. This can be used for the install command; it is ignored for other commands. |
| ```--productId <id>``` | **Optional** The ID of the product for the instance that will be installed. This is prepopulated in normal installation conditions. |
| ```--wait``` | **Optional**: The process will wait until the install is completed before returning a exit code. This is useful when automating installations where one needs to wait for the install to finish to handle the return code from that install. |
| ```--locale <language-locale>``` | **Optional**: Change the display language of the user interface for the installer itself. Setting will be persisted. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|

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
| 3010 | Operation completed successfully, but install requires reboot before it can be used |
| Other | Failure condition occurred - check the logs for more information |

Each operation will generate several log files in the `%TEMP%` directory that indicate the progress of the installation. Sort the folder by date and look for files beginning `dd_bootstrapper`, `dd_client` and `dd_setup` for the bootstrapper, the installer app, and the setup engine, respectively.

## See also

 * [Install Visual Studio 2017](install-visual-studio.md)
 * [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
 * [Command-line parameter examples for Visual Studio 2017 installation](command-line-parameter-examples.md)
 * [Report a problem with Visual Studio 2017](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
