---
title: "Use command-line parameters to install Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/12/2017"
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
# Use command-line parameters to install Visual Studio 2017 RC
When you install Visual Studio 2017 RC from a command prompt, you can use the following command-line parameters (also known as switches).  



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
| ```--layout <dir>``` | Optional: Specifies a directory to create an offline install cache. |
| ```--lang <language-locale>``` *[&#60;language-locale&#62; ...]* | Optional: Install/uninstall resource packages with the specified language(s). |
| ```--add <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | Optional: One or more workload or component IDs to add. |
| ```--remove <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | Optional: One or more workload or component IDs to remove. |
| ```--all``` | Optional: Whether to install all workloads and components for a product. |
| ```--includeRecommended``` | Optional: Includes the recommended components for any workloads that are installed, but not the optional components. The workloads are specified either with --all or --add. |
| ```--includeOptional``` | Optional: Includes the optional components for any workloads that are installed, but not the recommended components. The workloads are specified either with --all or --add.  |
| ```--quiet, -q``` | Optional: Do not display any user interface while performing the installation. |
| ```--passive, -p``` | Optional: Display the user interface, but do not request any interaction from the user. |
| ```--norestart``` | Optional: If present, commands with --passive or --quiet will not automatically restart the machine (if required). This is ignored if neither --passive nor --quiet are specified.  |
| ```--locale <language-locale>``` | Optional: Change the display language of the user interface for the installer. Setting will be persisted. |
| ```--nickname <name>``` | Optional: This defines the nickname to assign to an installed product. The nickname cannot be longer than 10 characters.  |
| ```--help, --?, -h, -?``` | Display parameter usage. |

| **Advanced command-line option** | **Description** |
| ----------------------- | --------------- |  
| ```[--channelId] <id>``` | Optional: The ID of the channel for the instance that will be installed. This is required for the install command, ignored for other commands if --installPath is specified. |
| ```[--channelUri] <uri>``` | Optional: The URI of the channel manifest. This can be used for the install command; it is ignored for other commands. |
| ```[--insatllChannelUri] <uri>``` | Optional: The URI of the channel manifest to use for the installation. The URI specified by --channelUri (which must be specified when --installChannelUri is specified) will be used to detect updates. If updates are not desired, --channelUri must be specified without an argument. This can be used for the install command; it is ignored for other commands. |
| ```[--installCatalogUri] <uri>``` | Optional: The URI of the catalog manifest to use for the installation. If specified, the channel manager will attempt to download the catalog manifest from this URI before using the URI in the install channel manifest. This parameter is used to support offline install, where the layout cache will be created with the product catalog already downloaded. This can be used for the install command; it is ignored for other commands. |
| ```[--in] <path>``` | Optional: The URI or path to a response file.  |
| ```[--addProductLang ] <language-locale>``` | Optional: This defines the language of an artifact (group, workload, or component) that is to be installed. It can appear multiple times on the command line. It is optional for the install and modify commands, ignored for the update, repair and uninstall commands. If not present, the installation will use the machine locale. |
| ```[--removeProductLang  ] <language-locale>``` | Optional: This defines the language of an artifact (group, workload, or component) that is to be removed. It can appear multiple times on the command line. It is optional for the install and modify commands, ignored for the update, repair and uninstall commands. |

For a list of workload and component IDs sorted by Visual Studio product, see our [Visual Studio 2017 Workload and Component IDs](https://aka.ms/vs2017componentids) page.

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

> [!IMPORTANT]
> While Visual Studio 2017 RC in general is supported for use in a production environment, those workloads and components that are marked "Preview" in the installation UI are not supported for use in a production environment.

## See also

 * [Install Visual Studio](install-visual-studio.md)
 * [Create an offline installation of Visual Studio 2017 RC](create-an-offline-installation-of-visual-studio.md)
 * [Report a problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
