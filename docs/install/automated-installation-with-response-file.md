---
title: "Automate Visual Studio installation with a response file | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "05/06/2017"
ms.reviewer: "tims"
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
Administrators deploying Visual Studio can specify a response file using the `--in` parameter, for instance:

```
vs_enterprise.exe --in customInstall.json
```

Response files are [JSON](http://json-schema.org/) files whose contents mirror the command line arguments.  In general, if a command line parameter takes no arguments (e.g. `--quiet`, `--passive`, etc.), the value in the response file should be true/false.  If it takes an argument (e.g. `--installPath <dir>`), the value in the response file should be a string.  If it takes an argument and can appear on the command line more than once (e.g. `--add <id>`), it should be an array of strings.

Parameters specified on the command line override settings from the response file, except in the case of parameters that take multiple inputs (e.g. `--add`), where the inputs supplied on the command line are merged with settings from the response file.

# Setting a default configuration for Visual Studio

If you created a network layout cache with the `--layout`, an initial `response.json` file is created in the layout.

Administrators who create a layout can modify the `response.json` file in the layout to control the default settings that their users will see when installing Visual Studio from the layout.  For example, if an administrator wants specific workloads and components selected to be installed by default, they can configure the `response.json` file to add those.

When Visual Studio setup is run from a layout folder, it will _automatically_ use the response file in the layout folder.  It is not required to use the `--in` option.

You can update the `response.json` file that is created in an offline layout folder to define default setting for users installing from this layout. **However, it is critical that you leave the existing properties that were defined when the layout was created.**

The base `response.json` file in a layout will look similar to this but with value for the product and channel you are installing:

```json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/15/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.15.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```

## Example layout response file content
This example will install Visual Studio Enterprise with six common workloads and components, with both English and French UI languages. You can use this as a template - just change the workloads and components to those you want installed.

```json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/15/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.15.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise",

  "installPath": "C:\\VS2017",
  "quiet": false,
  "passive": false,
  "wait": false,
  "includeRecommended": true,
  "norestart": false,

  "addProductLang": [
    "en-US",
    "fr-FR"
    ],

    "add": [
        "Microsoft.VisualStudio.Workload.ManagedDesktop",
        "Microsoft.VisualStudio.Workload.Data",
        "Microsoft.VisualStudio.Workload.NativeDesktop",
        "Microsoft.VisualStudio.Workload.NetWeb",
        "Microsoft.VisualStudio.Workload.Office",
        "Microsoft.VisualStudio.Workload.Universal",
        "Component.GitHub.VisualStudio"
    ]
}
```
