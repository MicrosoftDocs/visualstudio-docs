---
title: Options, Text Editor, All Languages, Scroll Bars
description: Learn how to use the Scroll Bars page in the All Languages section to change the default behavior of the code editor scroll bars within Visual Studio.
ms.date: 9/26/2024
ms.topic: reference
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
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options, Text Editor, All Languages, Scroll Bars

This dialog box lets you change the default behavior of the code editor scroll bar. To display these options, select **Options** from the **Tools** menu. Within the **Text Editor** folder, expand the **All Languages** subfolder, and then choose **Scroll Bars**.

> [!CAUTION]
> This page sets default options for all development languages. Resetting an option in this dialog will reset the Scroll Bars options in all languages to whatever choices are selected here. To change Text Editor options for just one language, expand the subfolder for that language and select its option pages.

## Show horizontal scroll bar

When selected, displays a horizontal scrollbar, which allows you to scroll from side-to-side to view elements that fall outside the viewing area of the Editor. If horizontal scrollbars are unavailable, you can use the cursor keys to scroll.

## Show vertical scroll bar

When selected, displays a vertical scrollbar, which allows you to scroll up and down to view elements that fall outside the viewing area of the Editor. If vertical scrollbars are not available, you can use the Page Up, Page Down and cursor keys to scroll.

## Display

### Show annotations over vertical scroll bar

Select whether the vertical scroll bar shows the following annotations:

- changes
- marks
- errors
- caret position

> [!TIP]
> The **Show marks** option includes breakpoints and bookmarks.

Try it out by opening a large code file and replacing some text that occurs in several places in the file. The scroll bar shows you the effect of the replacements, so you can back out your changes if you replaced something you shouldn't have.

See the [Enhanced scroll bar](/archive/blogs/cdnstudents/visual-studio-tips-and-tricks-enhanced-scroll-bar) blog post on what various colors and symbols mean when editing code.

## Behavior

The scroll bar has two modes: bar mode and map mode.

### Use bar mode for vertical scroll bar

*Bar mode* displays annotation indicators on the scroll bar. Clicking on the scroll bar scrolls the page up or down but does not jump to that location in the file.

### Use map mode for vertical scroll bar

In *map mode*, when you click a location on the scroll bar, the cursor jumps to that location in the file instead of just scrolling up or down a page. Lines of code are shown, in miniature, on the scroll bar. You can adjust the width of the scroll bar, that is, the map column, by selecting a value in **Source overview**. To enable a larger preview of the code when you rest the pointer on the map, select the **Show Preview Tooltip** option. Collapsed regions are shaded differently and expand when you double-click them.

> [!TIP]
> You can turn the miniature code view off in map mode by setting **Source overview** to **Off**. If **Show Preview Tooltip** is selected, you still see a preview of the code at that location when you hover your pointer on the scroll bar, and the cursor still jumps to that location in the file when you click.

## See also

- [How to: Customize the scroll bar](../how-to-track-your-code-by-customizing-the-scrollbar.md)
- [Suggest a feature](https://aka.ms/feedback/suggest)
- [Report a problem](../how-to-report-a-problem-with-visual-studio.md)