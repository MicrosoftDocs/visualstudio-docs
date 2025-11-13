---
title: Scroll bar map mode and bar mode
description: Learn how to track changes in your code through the customization of the scroll bar and also learn how to use Bar mode and Map mode.
ms.date: 05/2/2025
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.All_Languages.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.Basic.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.CSharp.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.CoffeeScript.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.CSS.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.Dockerfile.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.F%2523.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.HQL.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.HTML.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.HTMLX.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.JavaScript.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.TypeScript.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.JSON.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.LESS.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.Plain_Text.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.ResJSON.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.SCSS.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.SQL_Server_Tools.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.StreamAnalytics.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.T-SQL90.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.U-SQL.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.XAML.ScrollBars
- VS.ToolsOptionsPages.Text_Editor.XML.ScrollBars
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Customize the scroll bar

When you're working with long code files, it can be hard to keep track of where everything is in the file. You can customize the scroll bar of the code editor to give you an overall picture of what's happening in your code.

## Annotations

You can select whether the scroll bar shows annotations such as code changes, breakpoints, bookmarks, errors, and caret position.

   1. Open the **Scroll Bars** options page by choosing **Tools** > **Options** > **Text Editor** > **All Languages** > **Scroll Bars**.

   2. Select **Show Annotations over vertical scroll bar**, and then select the annotations you want to see. The available annotations are:

      - changes
      - marks
      - errors
      - caret position

      > [!TIP]
      > The **Show marks** option includes breakpoints and bookmarks.

Try it out by opening a large code file and replacing some text that occurs in several places in the file. The scroll bar shows you the effect of the replacements, so you can back out your changes if you replaced something you shouldn't have.

Here's how the scroll bar looks after a search for a string. Notice that all instances of the string appear in the scroll bar.

![Visual Studio scroll bar after searching for a string](../ide/media/enhancedscrollbarsearch.png)

Here's the scroll bar after replacing all the instances of the string. The red marks in the scroll bar show where the text replacement introduced errors.

![Visual Studio scroll bar after replacing a string with errors](../ide/media/enhancedscrollbarreplace.png)

### Table of annotations 

Curious as to which scroll bar annotations and their associated colors match which actions? See the following tables for details.

#### Code changes

Code changes are annotated in the far-left side of the vertical scroll bar. To modify the **Track changes** setting, go to **Tools** > **Options** > **Text Editor** > **Settings**.

**Tracked files (in a Git repository)**

|Color     | Default annotation     | Status | Settings name  |
|----------|------------------------|--------|----------------|
| Green    | :::image type="content" source="media/scroll-bar-git-track-addition-green-outline.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a tracked addition that's saved."::: | Unsaved  | Track additions in files under source control |
| Green    | :::image type="content" source="media/scroll-bar-git-track-addition-green-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a tracked addition that's unsaved.":::| Saved  | Track additions in files under source control |
| Red      | :::image type="content" source="media/scroll-bar-git-track-deletion-red-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a tracked deletion.":::| Deleted  | Track deletions in files under source control |
| Blue     | :::image type="content" source="media/scroll-bar-git-track-modification-blue-outline.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a tracked modification that's unsaved.":::| Unsaved | Track modifications in files under source control |
| Blue     | :::image type="content" source="media/scroll-bar-git-track-modification-blue-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a tracked modification that's saved.":::| Saved  | Track modifications in files under source control |

**Untracked files (not in a Git repository)**

|Color     | Default annotation     | Status | Settings name  |
|----------|------------------------|--------|----------------|
| Gold    | :::image type="content" source="media/scroll-bar-track-changes-gold-outline.png" alt-text="Screenshot of the default annotation in scroll bar that indicates change in a file before it's saved."::: | Unsaved  | Track changes in files before save |
| Green    | :::image type="content" source="media/scroll-bar-track-changes-green-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a change in a file after it's saved.":::| Saved  | Track changes in files after save |
| Blue     | :::image type="content" source="media/scroll-bar-track-reverted-changes-blue-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a reverted change in a file.":::| Reverted  | Track reverted changes in files |

#### Marks

Marks are annotated in the middle section of the vertical scroll bar. 

|Color     | Default annotation     | Settings name  |
|----------|------------------------|-----------------|
| Dark grey  | :::image type="content" source="media/scroll-bar-bookmark-dark-grey-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a bookmark in a file.":::  | Bookmark |
| Yellow  | :::image type="content" source="media/scroll-bar-find-match-yellow-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a find match status.":::| Find match |
| Dark red | :::image type="content" source="media/scroll-bar-breakpoint-dark-red-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a breakpoint in a file.":::| Breakpoint |
| Light grey | :::image type="content" source="media/scroll-bar-selection-match-light-grey-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a selection match in a file.":::| Selection match |
| Blue  | :::image type="content" source="media/scroll-bar-view-definition-blue-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a view definition mark in a file.":::| View definition |

#### Error, Warning, Information, or Suggestion

Errors, warnings, information, and suggestions are annotated in the far-right side of the vertical scroll bar.

|Color     | Default annotation     | Settings name  |
|----------|------------------------|-----------------|
| Red  | :::image type="content" source="media/scroll-bar-syntax-error-red-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a syntax error in a file.":::  | Syntax error |
| Green  | :::image type="content" source="media/scroll-bar-warning-green-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a warning in a file.":::| Warning |
| Blue | :::image type="content" source="media/scroll-bar-information-blue-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates information in a file.":::| Information |
| Light grey | :::image type="content" source="media/scroll-bar-suggestion-light-grey-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates a suggestion in a file.":::| Suggestion ellipses (...) |

#### Caret position

The caret position is also annotated in the far-right side of the vertical scroll bar. 

|Color     | Default annotation     | Settings name  |
|----------|------------------------|-----------------|
| Dark blue  | :::image type="content" source="media/scroll-bar-caret-dark-blue-solid.png" alt-text="Screenshot of the default annotation in scroll bar that indicates an overview caret in a file.":::  | Overview caret |

## Display modes

The scroll bar has two modes: bar mode and map mode.

### Bar mode

*Bar mode* displays annotation indicators on the scroll bar. Clicking on the scroll bar scrolls the page up or down but doesn't jump to that location in the file.

### Map mode

*Map mode* displays lines of code, in miniature, on the scroll bar. You can choose how wide the map column is by selecting a value in **Source overview**. To enable a larger preview of the code when you rest the pointer on the map, select the **Show Preview Tooltip** option. Collapsed regions are shaded differently and expand when you double-click them.

> [!TIP]
> You can turn the miniature code view off in map mode by setting **Source overview** to **Off**. If **Show Preview Tooltip** is selected, you still see a preview of the code at that location when you hover your pointer on the scroll bar, and the cursor still jumps to that location in the file when you click.

The following image shows the search example when map mode is on and the width is set to **Medium**:

![Visual Studio scroll bar in map mode](../ide/media/enhancedscrollbar.png)

The following image shows the **Show Preview Tooltip** option:

![Visual Studio scroll bar with a tooltip](../ide/media/enhancedscrollbarsearchtooltip.png)

> [!TIP]
> To change the colors that you see in map mode, choose **Tools** > **Options** > **Environment** > **Fonts and Colors**. Next, in **Display items**, choose any of the items that are preceded with "Overview", make the color changes you want, and then choose **OK**.

## Related content

- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)
- [Learn about the Editor Sticky Scroll feature](editor-sticky-scroll.md)