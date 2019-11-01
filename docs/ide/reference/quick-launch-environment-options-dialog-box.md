---
title: Quick Launch, Environment, Options Dialog Box
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Environment.QuickLaunch"
  - "vs.quicklaunch"
helpviewer_keywords:
  - "searching IDE"
  - "IDE, searching"
ms.assetid: 4200f297-d065-4723-9a30-d91ff2e26c9d
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
monikerRange: vs-2017
---
# Quick Launch, Environment, Options Dialog Box

You can use **Quick Launch** to quickly search and execute actions for IDE assets such as options, templates, menus. You can't use **Quick Launch** to search for code and symbols. The **Quick Launch** search box is located at the top-right corner of the menu bar and is accessible by pressing **Ctrl**+**Q**. Type your search string in the box. To search for strings that contain @, use '@@'.

**Quick Launch** is enabled by default when you install Visual Studio. On the menu bar, you can show or hide **Quick Launch** by choosing **Tools** > **Options**. Expand the **Environments** node, and then choose **Quick Launch**. Select or clear the **Enable Quick Launch** check box. You can also enable or disable search categories on this page.

## Category List

Quick Launch search results appear in four categories: **Most Recently Used**, **Menus**, **Options**, and **Open Documents**, along with the number of items in the category. To traverse through search results by category, choose the **Ctrl**+**Q** keys to show all the results from the next category. After the last category appears, **Ctrl**+**Q** shows you a few results from each category. Press **Ctrl**+**Shift**+**Q** to navigate through the categories in reverse order. To view all the search results under a category, choose the category name.

You can use the following shortcuts to limit your search to specific categories.

|Category|Shortcut|Shortcut Description|
|--------------|--------------| - |
|Most recently used|@mru<br /><br /> For example, `@mru font`|Displays up to five of the items that you **Most Recently Used**.|
|Menus|@menu<br /><br /> For example, `@menu project`|Limits the search to menu items.|
|Options|@opt<br /><br /> For example, `@opt font`|Limits the search to settings in the **Options** dialog box.|
|Documents|@doc<br /><br /> For example, `@doc program.cs`|Limits the search to file names and paths of open documents for the search criteria, but doesn't search the text inside the files themselves.|

> [!NOTE]
> You can change the shortcut keys on the **General** > **Keyboard** page in the **Options** dialog box.

## Show Previous Results

By default, the search term that you enter is not persisted between search sessions. The search string is cleared if you search for a term, move the cursor outside the **Quick Launch** area, and then go back. To retain the search results, go to the **Options** dialog box, choose **Quick Launch**, and then select the **Show search results from previous search when Quick Launch is activated.** check box. The next time you do a search, leave the Quick Launch area, and come back, Quick Launch will retain the search term last used and also show you the search results.
