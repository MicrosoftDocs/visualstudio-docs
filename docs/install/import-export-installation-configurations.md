---
title: Import or export installation configurations
titleSuffix: ''
description: Learn how to export your installation configuration to a .vsconfig file to share with others, and how to import it to clone.
ms.date: 2/21/2023
ms.topic: how-to
helpviewer_keywords:
- import installation configuration
- export installation configuration
- install Visual Studio
- Visual Studio installer
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Import or export installation configurations

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can use installation configuration files to configure Visual Studio. To do so, export the workloads and components information to a *.vsconfig* file by using the Visual Studio Installer. You can then import the configuration into new or existing installations, use them to create or modify a layout or an offline installation, and share them with others.

## Export a configuration

You can export an installation configuration file from either a previously installed instance of Visual Studio or one that you're currently installing.

1. Open the Visual Studio Installer.

1. On the product card, choose the **More** button, and then select **Export configuration**.

   ![Export configuration from the product card in the Visual Studio installer](../install/media/vs-2022/export-config.png)

1. Browse to or type the location where you want to save your .vsconfig file, and then choose **Review details**.

   ![Export configuration from the Visual Studio installer](../install/media/vs-2022/review-details-1.png)

1. Make sure you've got the workloads and components that you want, and then choose **Export**.

   ::: moniker range="vs-2022"

      :::image type="content" source="../install/media/vs-2022/export-configuration-confirmation-1.png" alt-text="Screenshot of the Export Window.":::

   ::: moniker-end

## Import a configuration

When you're ready to import an installation configuration file, follow these steps.

1. Open the Visual Studio Installer.

1. On the product card, choose the **More** button, and then select **Import configuration**.

1. Locate the .vsconfig file that you want to import, and then choose **Review details**.

1. Make sure you've got the workloads and components that you want, and then choose **Close**.

## Use a configuration file to initialize the contents of a layout

Using the correct bootstrapper that corresponds to the version and edition of Visual Studio that you want, open an administrator command prompt and run the following command. Since this functionality is relatively new, you'll need to use the latest installer in your layout. 

```shell
vs_enterprise.exe --layout c:\localVSlayout --config c:\myconfig.vsconfig --useLatestInstaller --lang en-US 
```

## Automatically install missing components

Save a .vsconfig file to your solution root directory and then open a solution. Visual Studio automatically detects the missing components and prompts you to install them.

![Solution Explorer suggests additional components](../install/media/vs-2019/solution-explorer-config-file.png)

You can also generate a .vsconfig file right from Solution Explorer.

1. Right-click on your solution file.

1. Choose **Add** > **Installation Configuration File**.

1. Confirm the location where you want to save the .vsconfig file, and then choose **Review details**.

1. Make sure you've got the workloads and components that you want, and then choose **Export**.

> [!NOTE]
> For more information, see the [Configure Visual Studio across your organization with .vsconfig](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/) blog post.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md)
* [Update a networked-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
* [Configure policies for enterprise deployments of Visual Studio](set-defaults-for-enterprise-deployments.md)
