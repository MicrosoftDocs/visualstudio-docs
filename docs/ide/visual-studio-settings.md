---
title: Use Visual Studio settings to customize Visual Studio
description: Explore the Visual Studio settings experience, learn how to find and filter settings, or view and edit settings in a JSON configuration file.
ms.date: 2/13/2026
ms.topic: concept-article
helpviewer_keywords:
- environments [Visual Studio], settings
monikerRange: "visualstudio"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ms.custom: peer-review-program, awp-ai
ai-usage: ai-assisted
---
# Visual Studio settings

Settings for the Visual Studio IDE, also called options, let you control many aspects of the behavior of the IDE and all of its tools, components, and extensions. To access Visual Studio settings, select **Tools** > **Options** from the main menu.

:::image type="content" alt-text="Screenshot of the Visual Studio settings experience." source="./media/visualstudio/visual-studio-settings.png" lightbox="./media/visualstudio/visual-studio-settings.png":::

## Browse the category hierarchy

Settings are organized into categories, shown in a hierarchy tree on the left side. For example, **Environment** refers to the main IDE window. Find any setting in the tree, or search for a setting by name, category, or keyword if you know something about the setting you're looking for.

Settings associated with specific workloads, optional components, or extensions don't appear in the tree unless they're installed. See [Modify Visual Studio](../install/modify-visual-studio.md) to install workloads and components. For extensions, see [Manage extensions](finding-and-using-visual-studio-extensions.md).

> [!NOTE]
> Some settings that haven't been migrated to the Visual Studio 2026 experience don't show up in their usual places where you might be used to finding them. For example, **Fonts and Colors** and **Accounts** have not been migrated in Visual Studio 2026 in the first public release. To find these settings, use the **Search feature**.

## Search settings by keywords

Search finds any setting that contains the keywords you enter and lets you choose the one you're looking for. To clear the search results, select the **X**.

Your most recent searches are remembered and offered as suggestions as you type, so you can easily repeat them.

:::image type="content" alt-text="Screenshot of the search bar in Visual Studio settings." source="media/visualstudio/visual-studio-settings-search.png":::

## Filter settings

You can also filter settings in certain ways. For example, you can filter to see only settings related to accessibility, performance, or settings you've modified from the defaults.

:::image type="content" alt-text="Screenshot of Filter options on Settings pane." source="media/visualstudio/visual-studio-settings-filter-options.png" :::

## Scope settings by user or solution

The **Applies to** box lets you scope the settings by the solution you're working on. For example, you might choose different theme colors for each solution you work on. The visual difference can make it easier to find the right IDE window if you have multiple windows open.

## When do changes take effect?

Most setting changes take effect immediately without requiring a save or apply action, or restarting the IDE. Settings that require you to restart the IDE for them to take effect will display a message when you change them.

## Synchronize settings

Settings are normally associated with your user profile, and synchronize with other sessions of Visual Studio, if you sign in with the same profile. You must be signed in to synchronize settings. When you first install Visual Studio 2026, you have the option to import settings from a previous installation. This action imports all settings. Settings that were previously synchronized are automatically applied to the new installation. Any subsequent setting changes will synchronize to other Visual Studio 2026 sessions where you sign in with the same profile, but those settings don't synchronize back to Visual Studio 2022. For more information, see [Synchronized settings in Visual Studio](synchronized-settings-in-visual-studio.md).

### Sync button

Use the **Sync** button to synchronize local settings and online synchronized settings.

Visual Studio associates settings on the **Settings** page with your signed-in profile and synchronizes them across installations that use the same account. After you change a setting, Visual Studio automatically applies it to other signed-in sessions, helping keep your environment consistent.
 
The **Sync** button lets you manually trigger synchronization to ensure your local settings are up-to-date with the stored settings. This can be useful if you want to immediately reconcile local changes with the remote copy, but regular synchronization also happens automatically without requiring manual action.

## View or edit the JSON configuration file

You can view or edit the settings you've modified from the defaults by opening the JSON configuration file. To open the file, select **Edit user settings as JSON** from the toolbar. The JSON configuration opens, showing you what settings you've customized. You can edit these in JSON, or copy any setting to the clipboard to share customizations with others.

Here's an example of the settings file:

```json
/* Visual Studio Settings File */
{
  "languages.dockerfile.general.wordWrapVisualGlyphs": false,
  "languages.fSharpInteractive.general.wordWrapVisualGlyphs": false,
  "languages.memory.general.wordWrapVisualGlyphs": false,
  "languages.register.general.wordWrapVisualGlyphs": false,
  "languages.typeScript.general.wordWrapVisualGlyphs": false,
  "languages.vbScript.general.wordWrapVisualGlyphs": false,
  "languages.cpp.intelliSense.errors.enableErrorFixSuggestions": false,
  "languages.defaults.general.wordWrapVisualGlyphs": true,
  "textEditor.advanced.diffOverviewMargin": true,
  "textEditor.general.stickyScroll.maxLines": 100,
  "copilot.general.debugger.enableDiagnosticsHubProfilerAgent": false,
  "copilot.general.editor.enableAdaptivePaste": false,
  "copilot.general.editor.enableMermaidPreview": false,
  "languages.basic.general.showCompletionOnTyping.hideAdvancedMembers": false,
  "languages.cpp.codeCleanup.includeCleanup.addMissingSuggestionLevel": "suggestion",
  "languages.cpp.codeCleanup.includeCleanup.removeUnusedSuggestionLevel": "dimmed",
  "languages.csharp.general.wordWrapVisualGlyphs": false,
  "languages.json.general.navigationBar": true,
  "languages.rest.tabs.indenting": "smart",
  "languages.rest.general.navigationBar": true,
  "languages.cpp.textEditor.preprocessor.showPreprocessorInactiveColor": false,
  "languages.cpp.intelliSense.quickInfo.enableQuickInfoHelpLink": false,
  "languages.cpp.intelliSense.singleFile.enableSingleFileISense": false,
  "languages.cpp.intelliSense.enableTemplateIntelliSense": false,
  "languages.cpp.textEditor.outlining.enableOutliningOnFileOpen": false,
  "languages.cpp.intelliSense.inactivePlatformIntelliSenseLimit": 1,
  "languages.cpp.codeCleanup.sortIncludes.priorityCaseSensitive": false,
  "languages.cpp.codeStyle.formatting.spacing.spaceAfterSemicolon": true,
  "languages.cpp.intelliSense.quickInfo.useWebSearchOnQuickInfoHelpLink": false,
  "languages.cpp.intelliSense.browsingNavigation.wholeCodebaseSemanticIndex.maximumWorkerThreads": 4,
  "languages.cpp.intelliSense.browsingNavigation.databaseFallback.location": "0",
  "languages.cpp.intelliSense.maximumCachedTranslationUnits": 15,
  "languages.dockerfile.scrollbars.verticalScrollBarMode": "map",
  "languages.cpp.intelliSense.errors.maximumErrorFixErrors": 2,
  "languages.fSharpInteractive.scrollbars.verticalScrollBarMode": "map",
  "textEditor.general.display.autoBraceSurround": true,
  "textEditor.general.imageHoverPreview": true,
  "textEditor.general.display.zeroWidthCharacters": false,
  "languages.cpp.intelliSense.references.maxFindReferencesThreads": 7,
  "languages.cpp.intelliSense.references.autoTuneMaximumFindReferencesThreads": true,
  "languages.memory.scrollbars.verticalScrollBarMode": "map",
  "languages.plainText.scrollbars.verticalScrollBarMode": "bar",
  "copilot.general.chat.preferredChatMode": "Ask",
  "languages.razor.tabs.character": "space",
  "environment.general.showStatusBar": false,
  "languages.register.scrollbars.verticalScrollBarMode": "map",
  "languages.vbScript.scrollbars.verticalScrollBarMode": "map"
}
```

## Related content

- [Customize the Visual Studio IDE](./personalizing-the-visual-studio-ide.md)