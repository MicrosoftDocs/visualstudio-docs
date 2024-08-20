---
title: Modify Visual Studio workloads and components
titleSuffix: ''
description: Modify your Visual Studio installation with the Visual Studio Installer. Add or remove workloads, components, and language packs.
ms.date: 08/19/2024
ms.topic: how-to
ms.custom: vs-acquisition
helpviewer_keywords:
- modify Visual Studio
- change visual studio
- changing Visual Studio
- customize Visual Studio
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation

#customer intent: As a developer, I want to learn how to modify my Visual Studio installation so that it meets my needs.
---

# Modify Visual Studio workloads, components, and language packs

It's easy to modify Visual Studio so that it includes only what you want. To do so, open the Visual Studio Installer, and then add or remove workloads, components, and language packs. This article walks you through the process.

## Prerequisites

- By default, to install, update, or modify Visual Studio, the account performing the update must have administrative permissions on the machine. It must also have permissions to the source where the product updates are located (either the internet or an internal location). If you're logged in as a typical user and try to perform one of these commands, you get a User Account Control notice prompting you for admin credentials. Starting in August 2023, an admin can delegate control of modifying Visual Studio to standard users by configuring the [`AllowStandardUserControl` policy](configure-policies-for-enterprise-deployments.md#controlling-installation-download-and-update-behavior). For more information, see [User Permissions and Visual Studio](../ide/user-permissions-and-visual-studio.md).

- The following procedures assume you have an internet connection. For information about how to modify a previously created [offline installation](create-an-offline-installation-of-visual-studio.md) of Visual Studio, see:
  - [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
  - [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)

## Open the installer to modify your installation

To modify your Visual Studio installation, you need to open the Visual Studio Installer and then select a Visual Studio installation to modify.

::: moniker range="vs-2019"

1. Find the Visual Studio Installer on your computer.

     On the Windows Start menu, you can search for "installer."

     :::image type="content" source="media/vs-2019/visual-studio-installer.png" alt-text="Screenshot of the result of a Start menu search for the Visual Studio Installer.":::

     > [!NOTE]
     > You can also find the Visual Studio Installer in the following location:
     >
     > `C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe`

    You might need to update the installer before continuing. If you do, follow the prompts.

1. In the installer, look for the edition of Visual Studio that you installed and then select **Modify**.

     :::image type="content" source="media/vs-2019/vs-installer-modify.png" alt-text="Screenshot of a list of Visual Studio installations in the Visual Studio Installer.":::

     > [!IMPORTANT]
     > If you have an update pending, the **Modify** button is in a different place. This enables you to modify Visual Studio without updating it, if you want to. Select **More** and then select **Modify**.
     >
     >  :::image type="content" source="media/vs-2019/modify-update-visual-studio.png" alt-text="Screenshot of the Modify button in the Visual Studio Installer. The button is located on the More dropdown menu when an update is pending.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. There are many ways to open the Visual Studio Installer:

   - On the Windows Start menu, you can search for "installer" and then select **Visual Studio Installer** from the results.
   
     :::image type="content" source="media/vs-2022/vs-installer.png " alt-text="Screenshot of the result of a Start menu search for the Visual Studio Installer.":::

   - Run the Visual Studio Installer executable file, which is located at `C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe`.

   - If you have Visual Studio open, select **Tools** > **Get Tools and Features**.
   
     :::image type="content" source="media/vs-2022/vs-tools-menu.png" alt-text="Screenshot of the Visual Studio 2022 tools menu. Get Tools and Features is highlighted.":::

   You might be prompted to update the Visual Studio Installer before continuing. If you are, follow the prompts.

1. In the Visual Studio Installer, look for the installation of Visual Studio that you want to modify and then select **Modify**.

     :::image type="content" source="media/vs-2022/vs-installer-modify.png" alt-text="Screenshot of a list of Visual Studio installations in the Visual Studio Installer.":::

::: moniker-end

## Change workloads or individual components

::: moniker range="vs-2019"

 Workloads contain the features you need for the programming language or platform that you use. Use workloads to modify Visual Studio so that it supports the work you want to do.

 > [!TIP]
>For more information about which tool and component bundles you need for development, see [Visual Studio workloads](https://visualstudio.microsoft.com/vs/#workloads).

1. In the Visual Studio Installer, on the **Workloads** tab, select the workloads that you want.

    :::image type="content" source="media/vs-2019/vs-installer-modify-workloads.png" alt-text="Screenshot of the Workloads tab of the Visual Studio Installer." lightbox="media/vs-2019/vs-installer-modify-workloads.png":::

1. You can select the default **Install while downloading** option or the **Download all, then install** option. 

    :::image type="content" source="media/vs-2019/vs-installer-choose-install-or-download.png" alt-text="Screenshot of the download and install options in the Visual Studio Installer.":::

1. Select **Modify**.

1. After the new workloads are installed, select **Launch** in the Visual Studio Installer to open Visual Studio.

::: moniker-end

::: moniker range=">=vs-2022"

Workloads contain the components you need for the programming language or platform that you use. Use workloads to modify Visual Studio so that it supports the work you want to do.

> [!TIP]
> For more information about which tools and component bundles you need for development, see [Visual Studio workloads](https://visualstudio.microsoft.com/vs/#workloads).

1. In the Visual Studio Installer, on the **Workloads** tab, select the workloads that you want.

     :::image type="content" source="media/vs-2022/vs-installer-modify-workloads.png" alt-text="Screenshot of the Workloads tab of the Visual Studio Installer." lightbox="media/vs-2022/vs-installer-modify-workloads.png":::

1. To add more components than a workload installs, on the **Individual components** tab, select the individual components that you want.

     :::image type="content" source="media/vs-2022/vs-installer-individual-components.png" alt-text="Screenshot of the Individual components tab of the Visual Studio Installer." lightbox="media/vs-2022/vs-installer-individual-components.png":::

1. You can select the default **Install while downloading** or **Download all, then install**. 

    :::image type="content" source="media/vs-2022/vs-installer-choose-install-or-download.png" alt-text="Screenshot of the download and install options in the Visual Studio Installer.":::

1. Select **Modify**.

1. After the modified workloads or components are installed, select **Launch** in the Visual Studio Installer to open Visual Studio 2022.

You can also use a [configuration file to modify an existing installation to add or remove components](import-export-installation-configurations.md#programmatically-use-a-configuration-file-to-add-components-to-an-existing-installation). For more information, see [Import or export installation configurations](import-export-installation-configurations.md).

::: moniker-end

> [!TIP]
> For information about the SQL Server Data Tools (SSDT) component, see [Download and install SSDT for Visual Studio](/sql/ssdt/download-sql-server-data-tools-ssdt?view=sql-server-ver15&preserve-view=true).

## Modify language packs

The Visual Studio Installer selects a default language pack for Visual Studio that matches the language of your operating system. You can change the default language whenever you want.

To change the default language:

1. Select the **Language packs** tab in the Visual Studio Installer.
1. Select the language you prefer.
1. Follow the prompts.

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

* [Visual Studio workload & component IDs](workload-and-component-ids.md)
* [Update Visual Studio](update-visual-studio.md)
* [Uninstall Visual Studio](uninstall-visual-studio.md)
* [Update a network-based installation of Visual Studio](update-a-network-installation-of-visual-studio.md)
