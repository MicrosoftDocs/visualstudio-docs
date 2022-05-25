---
title: Show import items
description: Use Show Import Items to expand IntelliSense in Visual Studio for Mac.
author: jmatthiesen
ms.author: jomatthi
manager: dominicn
ms.date: 03/29/2019
ms.assetid: C7782BF3-016F-4B41-8A81-85FC540A1A8F
ms.topic: reference
---
# Show import items

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

Visual Studio for Mac can show all available types, even if they aren't imported to your project, in your IntelliSense completion list. By selecting an item which isn't imported, the correct `using` statement will be added to your source file.

![show import items overview](media/importitems-overview.gif)

## How to enable

To enable this feature, open **Preferences** via **Visual Studio** > **Preferences** and navigate to **Text Editor** > **IntelliSense**. Check the box **Show import items** to enable additional items in IntelliSense.

![show import items option](media/show-import-items.png)

## Usage

Once you enable **Show import items**, the process of using the feature to import an item is similar to the normal actions within IntelliSense. As you type code, items that are valid will populate the completion list. This includes items that haven't been imported yet. The items that aren't imported will show their full namespace to the right of the item, allowing you to see which imports you are pulling in to your project.

![show import items list](media/show-import-items-list.png)

In the IntelliSense list, namespaces are shown next to members that are not currently referenced by a `using` statement. If you choose one of those items from the list, the member will be added to your code _and_ the `using` statement will be added to the top of the file. Members from types already referenced in the coded will not show their namespace in IntelliSense.

## See also

- [Quick Actions (Visual Studio on Windows)](/visualstudio/ide/quick-actions)
- [Refactor code (Visual Studio on Windows)](/visualstudio/ide/refactoring-in-visual-studio)
