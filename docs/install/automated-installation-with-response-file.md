---
title: Automate installation with a response file
description: Learn how to create a JSON response file that helps you automate your Visual Studio installation
ms.date: 11/23/2021
ms.topic: conceptual
helpviewer_keywords:
- response file
- automate
- installation
- command-line
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Programmatically configure default settings using a response file

The Visual Studio response file is a [JSON](http://json-schema.org/) file whose contents mirror the command-line parameters and arguments. The response file is used to initialize settings during the initial installation of the product. 

## Automate installation
Administrators who deploy Visual Studio can specify a response file by using the `--in` parameter, as in the following example:

```shell
vs_enterprise.exe --in customInstall.json
```
## Response file contents
The response file encapsulates command line parameters and follows these general rules:
 - If a command-line parameter takes no arguments (for example, `--quiet`, `--passive`, etc.), the value in the response file should be true/false. 
 - If the parameter takes an argument (for example, `--installPath <dir>`), the value in the response file should be a string. 
 - If the parameter takes an argument and can appear on the command-line more than once (for example, `--add <id>`), the value in the response file should be an array of strings.

Parameters that are specified on the command-line override the settings that are included in the response file, except when parameters take multiple inputs (for example, `--add`). When you have multiple inputs, the inputs supplied on the command line are merged with settings from the response file.

## Configure the response file used with network layouts
If you created a network layout by using the `--layout` command, an initial default vanilla `response.json` file was created in the root of the layout folder. Administrators can then modify this `response.json` file in the layout to control the settings that the clients should use when they invoke the bootstrapper in that layout to install or update Visual Studio on the client.

The configuration settings in the `response.json` file are only referenced and used when the client is using the bootstrapper in the layout. The `response.json` in the layout is _not_ used when the client is invoking the update locally on the client.  

If the administrator created a partial layout, then the default `response.json` file will specify only the workloads and languages that were included in the partial layout. 

Assuming `--quiet` mode is **not** used when the client is performing the initial install, then the users running an initial installation can override the defaults specified in the `response.json` and further select or unselect any workloads in the setup UI before the installation actually occurs. If the user does select components or workloads that aren't available in the layout, and if the channelURI in the `response.json` points to Microsoft hosted servers, then Visual Studio setup will try to acquire the packages from the internet.

When Visual Studio setup is run from a layout folder, the setup will _automatically_ use the `response.json` file in the layout folder. You don't have to use the `--in` option.

> [!WARNING]
> It's critical that you don't delete any properties in the `response.json` that were defined when the layout was created. You can change the values, but you can't remove any items.

The base `response.json` file in a layout should look similar to the following example, except that it would include the value for the product and channel that you want to install:

::: moniker range="vs-2017"

```Default response.json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/15/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.15.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```

::: moniker-end

::: moniker range="=vs-2019"

```Default response.json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/16/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.16.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```

::: moniker-end

::: moniker range="=vs-2022"

```Default response.json for Current channel layout
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/17/release/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.17.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```

```Default response.json for LTSC 17.0 channel layout
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "https://aka.ms/vs/17/release.ltsc.17.0/channel",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.17.Release.LTSC.17.0",
  "productId": "Microsoft.VisualStudio.Product.Enterprise"
}
```

::: moniker-end

When you create or update a layout, a response.template.json file is also created.  This file contains all of the workload, component, and language IDs that can be used.  This file is provided as a template for what all could be included in a custom install. Administrators can use this file as a starting point for a custom response file. Just remove the IDs for the things you do not want to install and save it in the `response.json` file or your own response file. Do not customize the response.template.json file or your changes will be lost whenever the layout is updated.

## Example customized layout response file content

::: moniker range="vs-2017"

The following `response.json` file example will initialize a Visual Studio Enterprise client install to include several common workloads and components, to include both the English and French UI languages, and to have the update location configured to point back to the layout. Note that for Visual Studio 2017, once the update location (channelURI) is set on the client, it cannot be changed later.

```Example response.json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "\\\\server\\share\\layoutdirectory\\ChannelManifest.json",
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

::: moniker range="=vs-2019"

The following `response.json` file example will initialize a Visual Studio Enterprise client install to select several common workloads and components, to select both the English and French UI languages, and to have the update location configured to point back to the layout. Note that for Visual Studio 2019, the update location (channelURI) can only be configured during initial installation and cannot be changed after the fact _unless_ you use the functionality in the latest installer. Refer to [Set defaults for enterprise deployments of Visual Studio](\visualstudio\install\set-defaults-for-enterprise-deploymnets#Use-the-latest-installer) for information how to configure this.

```Example response.json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "\\\\server\\share\\layoutdirectory\\ChannelManifest.json",
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

::: moniker range="=vs-2022"

The following `response.json` file example will initialize a Visual Studio Enterprise client install to select several common workloads and components, to select both the English and French UI languages, and to have the update location configured to point back to the layout. 

```Example response.json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "\\\\server\\share\\layoutdirectory\\ChannelManifest.json",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.17.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise",

  "installPath": "C:\\VS2022",
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
        "Microsoft.VisualStudio.Workload.Universal"
    ]
}
```

::: moniker-end

## Troubleshooting
If you run into a problem with the Visual Studio bootstrapper throwing an error when you pair it with a `response.json` file, see [Troubleshoot network-related errors when you install or use Visual Studio](../install/troubleshooting-network-related-errors-in-visual-studio.md#error-failed-to-parse-id-from-parent-process) page for more information.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also
* [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
