---
title: "Automate installation with a response file"
description: "Learn how to create a JSON response file that helps you automate your Visual Studio installation"
ms.date: 03/30/2019
ms.custom: "seodec18"
ms.topic: conceptual
helpviewer_keywords:
  - "response file"
  - "automate"
  - "installation"
  - "command-line"
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# How to define settings in a response file

Administrators who deploy Visual Studio can specify a response file by using the `--in` parameter, as in the following example:

```cmd
vs_enterprise.exe --in customInstall.json
```

Response files are [JSON](http://json-schema.org/) files whose contents mirror the command-line arguments.  In general, if a command-line parameter takes no arguments (for example, `--quiet`, `--passive`, etc.), the value in the response file should be true/false.  If it takes an argument (for example, `--installPath <dir>`), the value in the response file should be a string.  If it takes an argument and can appear on the command line more than once (for example, `--add <id>`), it should be an array of strings.

Parameters that are specified on the command-line override settings from the response file, except when parameters take multiple inputs (for example, `--add`). When you have multiple inputs, the inputs supplied on the command line are merged with settings from the response file.

## Setting a default configuration for Visual Studio

If you created a network layout cache with the `--layout`, an initial `response.json` file is created in the layout. If you create a partial layout, this response file includes the workloads and languages that were included in the layout.  Running setup from this layout automatically uses this response.json file, which selects the workloads and components included in the layout.  Users can still select or unselect any workloads in the setup UI before installing Visual Studio.

Administrators who create a layout can modify the `response.json` file in the layout to control the default settings that their users see when they install Visual Studio from the layout.  For example, if an administrator wants specific workloads and components installed by default, they can configure the `response.json` file to add them.

When Visual Studio setup is run from a layout folder, it _automatically_ uses the response file in the layout folder.  You don't have to use the `--in` option.

You can update the `response.json` file that is created in an offline layout folder to define the default setting for users who install from this layout.

> [!WARNING]
> It's critical that you leave the existing properties that were defined when the layout was created.

The base `response.json` file in a layout should look similar to the following example, except that it would include the value for the product and channel that you want to install:

::: moniker range="vs-2017"

```json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/15/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.15.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```

::: moniker-end

::: moniker range="vs-2019"

```json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/16/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.16.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```

::: moniker-end

When you create or update a layout, a response.template.json file is also created.  This file contains all of the workload, component, and language IDs that can be used.  This file is provided as a template for what all could be included in a custom install.  Administrators can use this file as a starting point for a custom response file.  Just remove the IDs for the things you do not want to install and save it in your own response file.  Do not customize the response.template.json file or your changes will be lost whenever the layout is updated.

## Example layout response file content

The following example installs Visual Studio Enterprise with six common workloads and components, and with both English and French UI languages. You can use this example as a template; just change the workloads and components to those that you want to install:

::: moniker range="vs-2017"

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

::: moniker-end

::: moniker range="vs-2019"

```json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/16/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.16.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise",

  "installPath": "C:\\VS2019",
  "quiet": false,
  "passive": false,
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

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
