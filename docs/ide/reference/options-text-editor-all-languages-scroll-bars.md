---
title: Options, Text Editor, All Languages, Scroll Bars
ms.date: 10/25/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.All_Languages.Scroll_Bars"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Options, Text Editor, All Languages, Scroll Bars
This dialog box lets you change the default behavior of the code editor scroll bar. To display these options, select **Options** from the **Tools** menu. Within the **Text Editor** folder, expand the **All Languages** subfolder, and then choose **Scroll Bars**.

> [!CAUTION]
> This page sets default options for all development languages. Remember that resetting an option in this dialog will reset the Scroll Bars options in all languages to whatever choices are selected here. To change Text Editor options for just one language, expand the subfolder for that language and select its option pages.

## Show horizontal scroll bar

When selected, displays a horizontal scrollbar, which allows you to scroll from side-to-side to view elements that fall outside the viewing area of the Editor. If horizontal scrollbars are unavailable, you can use the cursor keys to scroll.

## Show vertical scroll bar

When selected, displays a vertical scrollbar, which allows you to scroll up and down to view elements that fall outside the viewing area of the Editor. If vertical scrollbars are not available, you can use the Page Up, Page Down and cursor keys to scroll.

## Display

### Show annotations

You can select whether the scroll bar shows annotations such as code changes, breakpoints, bookmarks, errors, and caret position.

   1. On the **Scroll Bars** options page, select **Show Annotations over vertical scroll bar**. 
   2. Select the annotations you want to see. The available annotations are:

      - changes
      - marks
      - errors
      - caret position

      > [!TIP]
      > The **Show marks** option includes breakpoints and bookmarks.

Try it out by opening a large code file and replacing some text that occurs in several places in the file. The scroll bar shows you the effect of the replacements, so you can back out your changes if you replaced something you shouldn't have.

## Behavior

The scroll bar has two modes: bar mode and map mode.

### Use bar mode for vertical scroll bar

*Bar mode* displays annotation indicators on the scroll bar. Clicking on the scroll bar scrolls the page up or down but does not jump to that location in the file.

### Use map mode for vertical scroll bar

In *map mode*, when you click a location on the scroll bar, the cursor jumps to that location in the file instead of just scrolling up or down a page. Lines of code are shown, in miniature, on the scroll bar. You can choose how wide the map column is by selecting a value in **Source overview**. To enable a larger preview of the code when you rest the pointer on the map, select the **Show Preview Tooltip** option. Collapsed regions are shaded differently and expand when you double-click them.

> [!TIP]
> You can turn the miniature code view off in map mode by setting **Source overview** to **Off**. If **Show Preview Tooltip** is selected, you still see a preview of the code at that location when you hover your pointer on the scroll bar, and the cursor still jumps to that location in the file when you click.

## See also

- [How to: Customize the scroll bar](../how-to-track-your-code-by-customizing-the-scrollbar.md)