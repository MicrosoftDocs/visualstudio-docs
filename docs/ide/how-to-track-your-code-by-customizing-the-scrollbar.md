---
title: "Scroll bar map mode and bar mode"
ms.date: 09/25/2018
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Customize the scroll bar

When you are working with long code files, it can be hard to keep track of where everything is in the file. You can customize the scroll bar of the code editor to give you an overall picture of what's happening in your code.

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

## Display modes

The scroll bar has two modes: bar mode and map mode.

### Bar mode

*Bar mode* displays annotation indicators on the scroll bar. Clicking on the scroll bar scrolls the page up or down but does not jump to that location in the file.

### Map mode

In *map mode*, when you click a location on the scroll bar, the cursor jumps to that location in the file instead of just scrolling up or down a page. Lines of code are shown, in miniature, on the scroll bar. You can choose how wide the map column is by selecting a value in **Source overview**. To enable a larger preview of the code when you rest the pointer on the map, select the **Show Preview Tooltip** option. Collapsed regions are shaded differently and expand when you double-click them.

> [!TIP]
> You can turn the miniature code view off in map mode by setting **Source overview** to **Off**. If **Show Preview Tooltip** is selected, you still see a preview of the code at that location when you hover your pointer on the scroll bar, and the cursor still jumps to that location in the file when you click.

The following image shows the search example when map mode is on and the width is set to **Medium**:

![Visual Studio scroll bar in map mode](../ide/media/enhancedscrollbar.png)

The following image shows the **Show Preview Tooltip** option:

![Visual Studio scroll bar with a tooltip](../ide/media/enhancedscrollbarsearchtooltip.png)

## See also

- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)