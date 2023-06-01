---
title: Configure installation default settings with a response file
description: Learn how to create a response JSON file that helps you automate your Visual Studio installation
ms.date: 6/2/2023
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
# Configure installation default settings using a response file

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The Visual Studio response file is a [JSON](http://json-schema.org/) file whose contents contain customizations used during the initial installation of Visual Studio onto the client. Its contents mirror the [command line arguments and parameters](use-command-line-parameters-to-install-visual-studio.md). Common configuration options include:

- Ability to [**configure which workloads, components, or languages should be selected by default**](install-visual-studio#step-4---choose-workloads) during initial install. 
- Ability to specify [**where the client should receive updates from**](update-visual-studio.md#configure-source-location-of-updates-1). Examples include the default Microsoft hosted servers on the internet or from an admin-controlled network layout location.
- Ability to specify if [**out-of-support components**](update-visual-studio.md#remove-out-of-support-components) should be removed during updates.

## Creating the response file

The `response.json` file is typically created when an administrator [creates a layout](create-a-network-installation-of-visual-studio.md) and can be found in the root folder of the layout. However, you can create your own response file using one of the examples below.

## Specifying the response file

If an administrator [deploys Visual Studio by invoking the bootstrapper from a layout](deploy-a-layout-onto-a-client-machine.md#install-visual-studio-onto-a-client-machine-from-a-layout), the response file found in the layout's root will automatically be used. Administrators can also choose to explicitly specify a different response file by using the `--in` parameter, as in the following example:

```shell
\\server\share\layoutdirectory\vs_enterprise.exe --in customInstall.json
```

## Response file contents

The response file encapsulates command line parameters and follows these general rules:
 - If a command-line parameter takes no arguments (for example, `--quiet`, `--passive`, etc.), the value in the response file should be true/false. 
 - If the parameter takes an argument (for example, `--installPath <dir>`), the value in the response file should be a string. 
 - If the parameter takes an argument and can appear on the command-line more than once (for example, `--add <id>`), the value in the response file should be an array of strings.

Parameters that are specified on the command-line override the settings that are included in the response file, except when parameters take multiple inputs (for example, `--add`). When you have multiple inputs, the inputs supplied on the command line are merged with settings from the response file.

## Configure the response file used when installing from a layout

If you created a layout by using the `--layout` command, then a default `response.json` file will be created in the root of the layout folder. Administrators are expected to modify and customize the response file appropriately _before_ installing onto a client machine. That way, they can control the client's initial configuration settings.

The configuration settings in the `response.json` file are only referenced when executing a [bootstrapper](create-a-network-installation-of-visual-studio.md#download-the-visual-studio-bootstrapper-to-create-the-layout) (e.g. vs_enterprise.exe). Bootstrappers are typically used to perform initial installation on the client, but sometimes they're used to update a client too. The `response.json` is never used when the client is using installer (setup.exe) behavior invoked locally on the client.  

If the administrator created a partial layout, then the default `response.json` file in the layout will specify only the workloads and languages that were included in the partial layout. 

Make sure to pay special attention to the channelUri setting, which configures [where the client will look for updates](update-visual-studio.md#configure-source-location-of-updates-1). The default configuration is for the client to look at Microsoft hosted servers on the internet for updates. You'll need to change the value of channelUri and point it to your layout if you want clients to get their updates from your layout. Examples for how to do this are [detailed below](#xample-customized-layout-response-file-content). You can always change where a client looks for updates in the future by [executing the installer on the client and invoking the 'modifySettings' command](use-command-line-parameters-to-install-visual-studio#modifysettings-command-and-command-line-parameters). 

Assuming `--quiet` mode is **not** used when the client is performing the initial install, then the users running an initial installation can override the defaults specified in the `response.json` and further select or unselect any workloads in the setup UI before the installation actually occurs. If the user does select components or workloads that aren't available in the layout, and if the channelUri in the `response.json` points to Microsoft hosted servers, then Visual Studio setup will try to acquire the packages from the internet.

> [!WARNING]
> It's critical that you don't delete any properties in the `response.json` that were defined when the layout was created. You can change the values, but you can't remove any items.

The base `response.json` file in a layout should look similar to the following example, except that the productID would reflect the edition in your layout.   

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

The following `response.json` file example will initialize a Visual Studio 2019 Enterprise client install to select several common workloads and components, to select both the English and French UI languages, and to have the update location configured to look for sources in a network hosted layout. Note that for Visual Studio 2019, the update location (channelUri) can only be configured during initial installation and cannot be changed after the fact _unless_ you use the functionality in the latest installer. Refer to the [Configure policies for enterprise deployments of Visual Studio](configure-policies-for-enterprise-deployments.md#configuring-source-location-for-updates) and the [Configure your layout to always include and provide the latest installer](create-a-network-installation-of-visual-studio.md#configure-the-layout-to-always-include-and-provide-the-latest-installer) for information on how to configure this.

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
  "useLatestInstaller": true,
  "removeOos": true,
  
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

The following `response.json` file example will initialize a Visual Studio 2022 Enterprise client install to select several common workloads and components, to select both the English and French UI languages, to always [remove components that have transitioned to out of support when the client is being updated](update-visual-studio.md#remove-out-of-support-components), and to have the update location configured to look for sources in a http hosted layout. See the list of out-of-support components [here](out-of-support-components.md).

```Example response.json
{
  "installChannelUri": ".\\ChannelManifest.json",
  "channelUri": "http://MyCompanyIntranetSite/VS2022Enterprise/ChannelManifest.json",
  "installCatalogUri": ".\\Catalog.json",
  "channelId": "VisualStudio.17.Release",
  "productId": "Microsoft.VisualStudio.Product.Enterprise",

  "installPath": "C:\\VS2022",
  "quiet": false,
  "passive": false,
  "includeRecommended": true,
  "norestart": false,
  "useLatestInstaller": true,
  "removeOos": true,

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

> [!WARNING]
> You CANNOT have "noWeb": true in your `response.json` if you're using intranet webhosted layouts. 

## Troubleshooting
If you run into a problem with the Visual Studio bootstrapper throwing an error when you pair it with a `response.json` file, see [Troubleshoot network-related errors when you install or use Visual Studio](../install/troubleshooting-network-related-errors-in-visual-studio.md#error-failed-to-parse-id-from-parent-process) page for more information.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also
* [Visual Studio Administrators Guide](https://aka.ms/vs/admin/guide)
* [Create and Maintain a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Deploy Visual Studio from a layout onto a client machine](deploy-a-layout-onto-a-client-machine.md)
* [Configure policies for enterprise deployments](configure-policies-for-enterprise-deployments.md)
* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Troubleshoot network-related errors when you install or use Visual Studio](troubleshooting-network-related-errors-in-visual-studio.md)
