---
title: "Use command-line parameters to install Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "03/07/2017"
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
When you install Visual Studio 2017 from a command prompt, you can use the following command-line parameters (also known as switches).  

## List of command-line parameters  
 Visual Studio command-line parameters are not case-sensitive.  

| **Command-line command** | **Description** |
| ----------------------- | --------------- |  
| ```modify``` | Modifies an installed product. |
| ```update``` | Updates an installed product. |
| ```repair``` | Repairs an installed product. |
| ```uninstall``` | Uninstalls an installed product. |

If no command is specified, it will install the product.

| **Command-line option** | **Description** |
| ----------------------- | --------------- |  
| ```--installPath <dir>``` | The installation directory for the instance to act upon. For the install command, this is where the instance will be installed. For other commands, this is where the previously-installed instance was installed. |
| ```--productId <id>``` | The ID of the product for the instance that will be installed. This is required for the install command, ignored for other commands if --installPath is specified. |
| ```--layout <dir>``` | **Optional**: Specifies a directory to create an offline install cache. Selecting this option will implicitly add the '--wait' option as well. |
| ```--lang <language-locale>``` *[&#60;language-locale&#62; ...]* | **Optional**: Install/uninstall resource packages with the specified language(s). For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| ```--add <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | **Optional**: One or more workload or component IDs to add. The required components of the artifact are installed, but not the recommended or optional components. You can control additional components globally using '--includeRecommended' and/or '--includeOptional'. For finer-grained control, you can append ';includeRecommended' and/or ';includeOptional' to the artifactId (e.g. '--add Workload1;includeRecommended' or '--add Workload2;includeOptional;includeRecommended'). For more information, see our [Workload and component IDs](workload-and-component-ids.md) page.|
| ```--remove <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | **Optional**: One or more workload or component IDs to remove. For more information, see our [Workload and component IDs](workload-and-component-ids.md) page.|
| ```--all``` | **Optional**: Whether to install all workloads and components for a product. |
| ```--allWorkloads``` | **Optional**: Installs all workloads and their required components, no recommended or optional components. |
| ```--includeRecommended``` | **Optional**: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with --allWorkloads or --add. |
| ```--includeOptional``` | **Optional**: Includes the optional components for any workloads that are installed, but not the recommended components. The workloads are specified either with --allWorkloads or --add.  |
| ```--quiet, -q``` | **Optional**: Do not display any user interface while performing the installation. |
| ```--passive, -p``` | **Optional**: Display the user interface, but do not request any interaction from the user. |
| ```--norestart``` | **Optional**: If present, commands with --passive or --quiet will not automatically restart the machine (if required). This is ignored if neither --passive nor --quiet are specified.  |
| ```--locale <language-locale>``` | **Optional**: Change the display language of the user interface for the installer. Setting will be persisted. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| ```--nickname <name>``` | **Optional**: This defines the nickname to assign to an installed product. The nickname cannot be longer than 10 characters.  |
| ```--help, --?, -h, -?``` | Display parameter usage. |

>Note: When specifying multiple workloads and components, you must repeat the `--add` or `--remove` command line switch for each item.

| **Advanced command-line option** | **Description** |
| ----------------------- | --------------- |  
| ```--channelId <id>``` | **Optional**: The ID of the channel for the instance that will be installed. This is required for the install command, ignored for other commands if --installPath is specified. |
| ```--channelUri <uri>``` | **Optional**: The URI of the channel manifest. This can be used for the install command; it is ignored for other commands. |
| ```--installChannelUri <uri>``` | **Optional**: The URI of the channel manifest to use for the installation. The URI specified by --channelUri (which must be specified when --installChannelUri is specified) will be used to detect updates. If updates are not desired, --channelUri must be specified without an argument. This can be used for the install command; it is ignored for other commands. |
| ```--installCatalogUri <uri>``` | **Optional**: The URI of the catalog manifest to use for the installation. If specified, the channel manager will attempt to download the catalog manifest from this URI before using the URI in the install channel manifest. This parameter is used to support offline install, where the layout cache will be created with the product catalog already downloaded. This can be used for the install command; it is ignored for other commands. |
| ```--in <path>``` | **Optional**: The URI or path to a response file.  |
| ```--addProductLang <language-locale>``` | **Optional**: This defines the language of an artifact (group, workload, or component) that is to be installed. It can appear multiple times on the command line. It is optional for the install and modify commands, ignored for the update, repair and uninstall commands. If not present, the installation will use the machine locale. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| ```--removeProductLang <language-locale>``` | **Optional**: This defines the language of an artifact (group, workload, or component) that is to be removed. It can appear multiple times on the command line. It is optional for the install and modify commands, ignored for the update, repair and uninstall commands. For more information, see the [List of language locales](#list-of-language-locales) section on this page.|
| ```--wait``` | **Optional**: The process will wait until the install is completed before returning a exit code. This is useful when automating installations where one needs to wait for the install to finish to handle the return code from that install. |
| ```--productKey``` | **Optional**: This defines the product key to use for an installed product. It is composed of 25 alphanumeric characters either in the format 'xxxxx-xxxxx-xxxxx-xxxxx-xxxxx' or 'xxxxxxxxxxxxxxxxxxxxxxxxx'. |
## List of workload IDs and component IDs
For a list of workload and component IDs sorted by Visual Studio product, see our [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## List of language locales
| **Language-locale** | **Language** |
| ----------------------- | --------------- |  
| cs-CZ | Czech |
| de-DE | German |
| en-US | English |
| es-ES | Spanish |
| cs-CZ | Czech |
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


## See also

 * [Install Visual Studio](install-visual-studio.md)
 * [Create an offline installation of Visual Studio 2017](create-an-offline-installation-of-visual-studio.md)
 * [Report a problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
