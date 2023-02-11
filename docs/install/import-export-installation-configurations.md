---
title: Import or export installation configurations
titleSuffix: ''
description: Learn how to export your installation configuration to a .vsconfig file to share with others, and how to import it to clone.
ms.date: 04/28/2022
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

You can configure Visual Studio across your organization with installation configuration files. To do so, export the workload and component information to a .vsconfig file by using the Visual Studio installer. You can then import the configuration into new or existing installations, and share them with others, too.

Here's how.

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

## Automatically install missing components

**New in Visual Studio 2019**: Save a .vsconfig file to your solution root directory and then open a solution. Visual Studio automatically detects the missing components and prompts you to install them.

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
* [Control updates to Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
* [Configure policies for enterprise deployments](configure-policies-for-enterprise-deployments.md)
