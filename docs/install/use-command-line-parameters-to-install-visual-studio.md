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
# Use Command-Line Parameters to Install Visual Studio 2017 RC
When you install Visual Studio 2017 RC from a command prompt, you can use the following command-line parameters (also known as switches).  


> [!NOTE]
>  Make sure that you use the actual installer and not the bootstrapper file. For example, make sure you use **`vs_enterprise.exe`** instead of vs_enterprise_*GUID*.exe. You can download an installer from [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015).  

## List of command-line parameters  
 Visual Studio command-line parameters are not case-sensitive.  

| **Command-line option** | **Description** |
| ----------------------- | --------------- |  
| ```[--catalog] <uri>``` *[&#60;uri&#62; ...]* | *Required*: One or more file paths or URIs to catalogs. |
|  ```--installDir <dir>```, ```--installationDirectory <dir>``` | *Required*: The target installation directory. |
|  ```-l <path>, --log <path>``` | Specify the log file; otherwise, one is automatically generated. |
|  ```-v, --verbose``` | Display verbose messages. |
|  ```-?, -h, --help``` | Display parameter usage. |
| ```--instanceId <id>``` | Optional: The instance ID to install or repair. |
| ```--productId <id>``` | Optional: The product ID to install. Otherwise, the first product found is installed. |
| ```--all``` | Optional: Whether to install all workloads and components for a product. |
| ```--add <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | Optional: One or more workload or component IDs to add. |
| ```--remove <workload or component ID>``` *[&#60;workload or component ID&#62; ...]* | Optional: One or more workload or component IDs to remove. |
| ```--optional, --includeOptional``` | Optional: Whether to install all optional workloads and components for selected workload. |
| ```--lang, --language <language-locale>``` *[&#60;language-locale&#62; ...]* | Optional: Install/uninstall resource packages with the specified language(s). |
|  ```--sharedInstallDir <dir>``` | Optional: The target installation directory for shared payloads. |  
| ```--compatInstallDir <dir>``` | Optional: The target installation directory for legacy compatibility payloads. |  
|  ```--layoutDir <dir>```, ```--layoutDirectory <dir>``` | Optional: The layout directory in which to find packages.|
|  ```--locale <language-locale>``` | Optional: Change the display language of the user interface for the installer. Setting will be persisted. |
| ```--quiet``` | Optional: Do not display any user interface while performing the installation. |
| ```--passive``` | Optional: Display the user interface, but do not request any interaction from the user. |

## List of workload IDs and component IDs
For a list of workload and component IDs sorted by Visual Studio product, see our [Visual Studio 2017 Workload and Component IDs](https://aka.ms/vs2017componentids) page.


> [!IMPORTANT]
> While Visual Studio 2017 RC in general is supported for use in a production environment, those workloads and components that are marked "Preview" in the installation UI are not supported for use in a production environment.

## See also

 * [Install Visual Studio](install-visual-studio.md)
 * [Create an offline installation of Visual Studio 2017 RC](create-an-offline-installation-of-visual-studio.md)
 * [Report a problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio-2017.md)
