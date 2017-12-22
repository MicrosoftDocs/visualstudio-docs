---
title: "Automate Visual Studio installation with a response file | Microsoft Docs"
description: "Learn how to create a JSON response file that helps you automate your Visual Studio installation"
ms.date: "08/14/2017"
ms.reviewer: "tims"
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "response file"
  - "automate"
  - "installation"
  - "command-line"
author: "timsneath"
ms.author: "tglee"
manager: ghogen
ms.workload: 
  - "multiple"
---

# How to define settings in a response file
Administrators who deploy Visual Studio can specify a response file by using the `--in` parameter, as in the following example:

```
vs_enterprise.exe --in customInstall.json
```

Response files are [JSON](http://json-schema.org/) files whose contents mirror the command-line arguments.  In general, if a command-line parameter takes no arguments (for example, `--quiet`, `--passive`, etc.), the value in the response file should be true/false.  If it takes an argument (for example, `--installPath <dir>`), the value in the response file should be a string.  If it takes an argument and can appear on the command line more than once (for example, `--add <id>`), it should be an array of strings.

Parameters that are specified on the command-line override settings from the response file, except when parameters take multiple inputs (for example, `--add`). When you have multiple inputs, the inputs supplied on the command line are merged with settings from the response file.

# Setting a default configuration for Visual Studio

If you created a network layout cache with the `--layout`, an initial `response.json` file is created in the layout. If you create a partial layout, this response file includes the workloads and languages that were included in the layout.  Running setup from this layout automatically uses this response.json file, which selects the workloads and components included in the layout.  Users can still select or unselect any workloads in the setup UI before installing Visual Studio.

Administrators who create a layout can modify the `response.json` file in the layout to control the default settings that their users see when they install Visual Studio from the layout.  For example, if an administrator wants specific workloads and components installed by default, they can configure the `response.json` file to add them.

When Visual Studio setup is run from a layout folder, it _automatically_ uses the response file in the layout folder.  You don't have to use the `--in` option.

You can update the `response.json` file that is created in an offline layout folder to define the default setting for users who install from this layout.

> [!WARNING]
> It's critical that you leave the existing properties that were defined when the layout was created.

The base `response.json` file in a layout should look similar to the following example, except that it would include the value for the product and channel that you want to install:

```json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/15/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.15.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```
When you create or update a layout, a response.template.json file is also created.  This file contains all of the workload, component, and language IDs that can be used.  This file is provided as a template for what all could be included in a custom install.  Administrators can use this file as a starting point for a custom response file.  Just remove the IDs for the things you do not want to install and save it in your own response file.  Do not customize the response.template.json file or your changes will be lost whenever the layout is updated.

## Example layout response file content
The following example installs Visual Studio Enterprise with six common workloads and components, and with both English and French UI languages. You can use this example as a template; just change the workloads and components to those that you want to install:

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

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also
* [Visual Studio 2017 workload and component IDs](workload-and-component-ids.md)
