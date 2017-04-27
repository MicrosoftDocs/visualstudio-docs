---
title: "Automate Visual Studio installation with a response file | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "04/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 448C738E-121F-4B64-8CA8-3BC997817A14
author: "timsneath"
ms.author: "tims"
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
# How to define settings in a response file
Admins deploying VS can also specify a response file using the ```--in <response file>``` command.

Response files are JSON files whose contents mirror the command line arguments.  In general, if a command line parameter takes no arguments (e.g. ```--quiet```, ```--passive```, etc.), the value in the response file should be true/false.  If it takes an argument (e.g. ```--installPath <dir>```), the value in the response file should be a string.  If it takes an argument and can appear on the command line more than once (e.g. ```--add <id>```), it should be an array of strings.

Command line parameters override settings from the response file, except in the case of multi-instance parameters (e.g. --add).  Multi-instance parameters are merged with settings from the response file.

### Web install response files
If you are running the bootstrapper outside of an "offline layout" and want to use a response.json, get a base response.json file by doing the following:
- Run ```vs_enterprise.exe -x``` and extract the contents of the bootstrapper.
- Look in the extracted folder for ```vs_bootstrapper_d15\vs_setup_bootstrapper.json```.  Copy this file and edit it to add your own customizations.
- When installing VS, run a command ```vs_enterprise.exe --in C:\Full\Path\To\My\repsonse.json``` 

The base response.json file will look similar to this but with value for the product and channel you are installing:
```
{
  "productId": "Microsoft.VisualStudio.Product.Enterprise",
  "channelId": "VisualStudio.15.Release",
  "channelUri": "https://aka.ms/vs/15/release/channel"
}
```

#### Example response file for performing a web install:
```
{
  "productId": "Microsoft.VisualStudio.Product.Enterprise",
  "channelId": "VisualStudio.15.Release",
  "channelUri": "https://aka.ms/vs/15/release/channel"

  "installPath": "C:\\desktopVS",
  "addProductLang": "fr-FR",
  "add": [
      "Microsoft.VisualStudio.Workload.ManagedDesktop",
      "Microsoft.VisualStudio.Component.DiagnosticTools"
  ],
  "quiet": true
}
```

### Offline layout repsonse files

If you created an offline layout, a response.json file was created in the layout.  

Admins who create a layout can modify the response.json file in the layout to control the default settings that their users will see when installing VS from the layout.  For example, if the admin wants some specific workloads and components selected to be installed by default, they can configure the response.json file to add those.  

When VS setup is run from a layout folder, it will automatically use the response file in the layout folder.  It is not required to use the ```--in``` option.

You can update the response.json file that is created in an offline layout folder to define default setting for users installing from this layout.  However, be sure to leave the existing properties that were defined when the layout was created.

The base response.json file in a layout will look similar to this but with value for the product and channel you are installing:
```
{"installChannelUri":".\\ChannelManifest.json","channelUri":"https://aka.ms/vs/15/release/channel","installCatalogUri":".\\Catalog.json","channelId":"VisualStudio.15.Release","productId":"Microsoft.VisualStudio.Product.Enterprise",
}
```

#### Example layout response file content:<br>
```
{"installChannelUri":".\\ChannelManifest.json","channelUri":"https://aka.ms/vs/15/release/channel","installCatalogUri":".\\Catalog.json","channelId":"VisualStudio.15.Release","productId":"Microsoft.VisualStudio.Product.Enterprise",
    "installPath": "C:\\desktopVS",
    "addProductLang": "fr-FR",
    "add": [
        "Microsoft.VisualStudio.Workload.ManagedDesktop",
        "Microsoft.VisualStudio.Component.DiagnosticTools"
    ],
    "quiet": false
}
```