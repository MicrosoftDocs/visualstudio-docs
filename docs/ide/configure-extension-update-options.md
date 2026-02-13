---
title: Configure extension and update options in Visual Studio
description: Learn how to configure automatic updates, extension update behavior, and private extension galleries in Visual Studio.
ms.date: 02/09/2026
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Environment.ExtensionManager
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ms.custom: awp-ai
ai-usage: ai-assisted
---
# Configure extension and update options in Visual Studio

This article shows you how to configure settings for Visual Studio updates, extension updates, and private extension galleries.

## Prerequisites

- Visual Studio installed. If you don't have it, see [Install Visual Studio](../install/install-visual-studio.md).

## Open the Extensions options

::: moniker range="visualstudio"

1. Select **Tools** > **Options** from the menu bar.
1. Expand **All Settings** > **Environment**.
1. Select **Extensions** to open the settings pane.

::: moniker-end
::: moniker range="<=vs-2022"

1. Select **Tools** > **Options** from the menu bar.
1. Expand **Environment**.
1. Select **Extensions** to open the settings page.

::: moniker-end

## Configure automatic update checking

To control whether Visual Studio automatically checks for updates to itself, SDKs, tools, and extensions:

1. Open the Extensions options.
1. Select or clear the **Automatically check for updates** checkbox.

   When enabled, Visual Studio periodically checks for available updates and displays notifications in the menu bar when updates are found.

For more information about updating Visual Studio, see [Update Visual Studio](../install/update-visual-studio.md).

## Install extension updates automatically

To control whether extensions update automatically without prompting:

1. Open the Extensions options.
1. Select or clear the **Install updates automatically** checkbox.

   When enabled, Visual Studio automatically downloads and installs extension updates. When disabled, you receive notifications about available updates but must manually choose to install them.

For more information, see [Find and use Visual Studio extensions](finding-and-using-visual-studio-extensions.md).

## Load per-user extensions when running as administrator

To control whether per-user extensions load when Visual Studio runs with elevated permissions:

1. Open the Extensions options.
1. Select or clear the **Load per user extensions when running as administrator** checkbox.

   By default, per-user extensions don't load when you run Visual Studio as an administrator for security reasons.

For more information, see [Find and use Visual Studio extensions](finding-and-using-visual-studio-extensions.md).

## Add private extension galleries

If your organization hosts a private gallery of proprietary extensions, you can add it to Visual Studio:

1. Open the Extensions options.
1. In the **Additional Extension Galleries** section, select **Add**.
1. Enter the **Name** and **URL** for your private gallery.
1. Select **OK** to save the gallery.

This is an Enterprise feature that enables support for galleries of proprietary extensions hosted by your organization.

For more information, see [Private galleries](../extensibility/private-galleries.md).

## Related content

- [Find and use Visual Studio extensions](finding-and-using-visual-studio-extensions.md)
- [Update Visual Studio](../install/update-visual-studio.md)
- [Private galleries](../extensibility/private-galleries.md)
