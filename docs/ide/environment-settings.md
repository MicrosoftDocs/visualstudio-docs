---
title: Environment settings
description: Learn about Visual Studio environment settings and how to adjust them to be optimal for the type of development that you do.
ms.custom: SEO-VS-2020
ms.date: 12/12/2022
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Environment settings for Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

When you first [install Visual Studio](../install/install-visual-studio.md), you choose [workloads](../install/install-visual-studio.md#step-4---choose-workloads) and [components](../install/install-visual-studio.md#step-5---choose-individual-components-optional) to customize your development environment. Then, you can further optimize the development environment for the type of development that you do by using the **Import and Export Settings Wizard**. From this wizard, you can choose a specific collection of settings. Each collection optimizes elements such as keyboard shortcuts, window layouts, project and item templates, and command visibility.

The following settings collections are available:

- General
- JavaScript
- Visual Basic
- Visual C#
- Visual C++
- Web Development
- Web Development (Code Only)

## Import and export settings

To open the wizard, select **Tools** > **Import and Export Settings** from the Visual Studio menu bar.

::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/import-export-settings-wizard.png" alt-text="Screenshot of the 'Import and Export Settings Wizard' in Visual Studio 2022.":::

::: moniker-end

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/import-export-settings-wizard.png" alt-text="Screenshot of the 'Import and Export Settings Wizard' in Visual Studio 2019.":::

::: moniker-end

Here, you can import and export your settings. However, you can use the [Reset all settings](#reset-all-settings) option to choose settings collections list.

::: moniker range="vs-2022"

### Reset all settings

Follow these steps:

::: moniker range="vs-2022"

1. In the **Import and Export Settings Wizard**, select **Reset all settings**, and then select **Next**.

1. On the **Save Current Settings** page, select either **Yes** or **No**, and then select **Next**.

1. On the **Choose a Default Collection of Settings** page, choose a collection, and then select **Finish**.

   ![Settings collections in Visual Studio](media/settings-collections.png)

1. On the **Reset Complete** page, select **Close**.

::: moniker-end

::: moniker range="vs-2019"

1. In the **Import and Export Settings Wizard**, select **Reset all settings**, and then select **Next**.

1. On the **Save Current Settings** page, select either **Yes** or **No**, and then select **Next**.

1. On the **Choose a Default Collection of Settings** page, choose a collection, and then select **Finish**.

   ![Settings collections in Visual Studio](media/settings-collections.png)

1. On the **Reset Complete** page, select **Close**.

::: moniker-end

## See also

- [Synchronize settings across multiple computers](synchronized-settings-in-visual-studio.md)
- [Personalize the Visual Studio IDE](personalizing-the-visual-studio-ide.md)
