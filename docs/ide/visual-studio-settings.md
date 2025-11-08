---
title: Use Visual Studio settings to customize Visual Studio
description: Explore the Visual Studio settings experience, learn how to find and filter settings, or view and edit settings in a JSON configuration file.
ms.date: 11/6/2025
ms.topic: concept-article
helpviewer_keywords:
- environments [Visual Studio], settings
monikerRange: "visualstudio"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Visual Studio settings

Settings for the Visual Studio IDE, also called options, let you control many aspects of the behavior of the IDE and all of its tools, components, and extensions. To access Visual Studio settings, select **Tools** > **Options** from the main menu.

:::image type="content" alt-text="Screenshot of the Visual Studio settings experience." source="./media/visualstudio/visual-studio-settings.png" lightbox="./media/visualstudio/visual-studio-settings.png":::

## Browse the category hierarchy

Settings are organized into categories, shown in a hierarchy tree on the left side. For example, **Environment** refers to the main IDE window. Find any setting in the tree, or search for a setting by name, category, or keyword if you know something about the setting you're looking for.

Settings associated with specific workloads, optional components, or extensions don't appear in the tree unless they're installed. See [Modify Visual Studio](../install/modify-visual-studio.md) to install workloads and components. For extensions, see [Manage extensions](finding-and-using-visual-studio-extensions.md).

> [!NOTE]
> Some settings that haven't been migrated to the Visual Studio 2026 experience don't show up in their usual places where you might be used to finding them. For example, **Fonts and Colors** and **Accounts** have not been migrated in Visual Studio 2026 in the first public release. To find these settings, use the **Search feature**, or look under **More settings** (the last item under each top-level node) to see a list of links to settings that haven't been migrated. When you click on the links, the **Options** dialog box appears with the relevant setting page.
>
> :::image type="content" alt-text="Screenshot of the Visual Studio settings experience, with More Settings highlighted, and showing the Options dialog." source="./media/visualstudio/visual-studio-settings-more-settings.png" lightbox="./media/visualstudio/visual-studio-settings-more-settings.png":::

## Search settings by keywords

Search finds any setting that contains the keywords you enter and lets you choose the one you're looking for. To clear the search results, click on the **X**.

Your most recent searches are remembered and offered as suggestions as you type, so you can easily repeat them.

## Filter settings

You can also filter settings in certain ways, for example, you can filter to see only settings related to accessibility, performance, or settings you've modified from the defaults.

:::image type="content" alt-text="Screenshot of Filter options on Settings pane." source="media/visualstudio/visual-studio-settings-filter-options.png" :::

## Scope settings by user or solution

The **Applies to** box lets you scope the settings by the solution you're working on. For example, you might choose different theme colors for each solution you work on. The visual difference can make it easier to find the right IDE window if you have multiple windows open.

## When do changes take effect?

Most setting changes take effect immediately without requiring a save or apply action, or restarting the IDE. Some settings require an IDE restart.

## Synchronize settings

Settings are normally associated with your user profile, and synchronize with other sessions of Visual Studio, if you sign in with the same profile. You must be signed in to synchronize settings. When you first sign in to Visual Studio 2026, you have the option to import settings from your Visual Studio 2022 profile. The settings synchronize to other Visual Studio 2026 sessions where you sign in with the same profile, but those settings don't synchronize back to Visual Studio 2022. For more information, see [Synchronized settings in Visual Studio](synchronized-settings-in-visual-studio.md).

## View or edit the JSON configuration file

You can view or edit the settings you've modified from the defaults by opening the JSON configuration file. To open the file, select **Edit user settings as JSON** from the control bar. The JSON configuration open, showing you what settings you've customized. You can edit these in JSON, copy them and paste them into messaging apps to share customizations with others.

## Sync

Use the **Sync** to refresh the settings view to reflect the current state.

## Related content

- [Customize the Visual Studio IDE](./personalizing-the-visual-studio-ide.md)