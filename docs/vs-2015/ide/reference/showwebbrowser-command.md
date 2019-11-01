---
title: "ShowWebBrowser Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "view.showwebbrowser"
helpviewer_keywords:
  - "ShowWebBrowser command"
  - "View.ShowWebBrowser command"
ms.assetid: c6a4fbd6-8e9d-45cc-8b2f-93990d065e78
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# ShowWebBrowser Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Displays the URL you specify in a Web browser window either within the integrated development environment (IDE) or external to the IDE.

## Syntax

```
View.ShowWebBrowser URL [/new][/ext]
```

## Arguments
 `URL`
 Required. URL (Uniform Resource Locator) for the Web site.

## Switches
 /new
 Optional. Specifies that the page appears in a new instance of the Web browser.

 /ext
 Optional. Specifies that the page appears in the default Web browser outside of the IDE.

## Remarks
 The alias for the **ShowWebBrowser** command is **navigate** or **nav**.

## Example
 The following example displays the MSDN Online home page in a Web browser outside of the IDE. If an instance of the Web browser is already open, it is used; otherwise a new instance is launched.

```
>View.ShowWebBrowser https://msdn.microsoft.com /ext
```

## See Also
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
