---
title: "Help Window in the R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 4/26/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ef9c04d4-0d5e-405a-842e-8d47fa0e8781
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---


# Help in R Tools for Visual Studio

Help for R is integrated directly into the interactive window in Visual Studio. Whenever you use the `?` command, such as `?mtcars`, help from the R documentation appears in a Visual Studio window:

![Help window in Visual Studio](media/help-window.png)

> [!Tip]
> The help window, like all others in Visual Studio, can be arranged and docked however you like. See [Customize window layouts in Visual Studio](../ide/customizing-window-layouts-in-visual-studio.md).
>
> You can also open help results in a browser instead by selecting the **R Tools > Options** menu and set the **R Help Browser** property to `External`.

To search help, use the `??` command with the search term in quotes if it include spaces:

```R
??"Motor Trend"
```

![Help search results](media/help-search1.png)

The help window also has a search input field through which you can conduct further searches in the R documentation directly:

![Help search results using the input field](media/help-search2.png)

## Integrated help lookup

Because developers often search the R documentation for help on function names, datasets, and other elements, R Tools for Visual Studio streamlines the process by integrating help lookups directly into the editor and interactive window.

- Pressing F1 during an auto-complete operation produces a list of help results that match the substring.
- Right-click in a search term (like a function) and select the **Help on** command, or just press F1, to open help for that function. You can also invoke **Help on** for any selection.

    ![Invoking help through the right click context menu](media/help-right-click.png)

## Integrated StackOverflow search

In addition to searching in the R documentation, developers often search StackOverflow while writing code. RTVS streamlines that process as well. When you right-click a term or a selection and select the **Search web for** command, or just press Ctrl+F1, a Visual Studio window opens that contains search results for that term that is scoped to StackOverflow by default:

![Web search results in Visual Studio](media/help-web-search-results.png)

You can change the appended string, `R site:stackoverflow`, through the **R Tools > Options > F1 Web search string** option:

![Changing the F1 Web search string option](media/options-dialog.png)