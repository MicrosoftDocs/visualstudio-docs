---
title: ShowWebBrowser Command
description: Learn about the Show Web Browser command and how it displays the URL you specify in a web browser window either within the IDE or external to the IDE.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "view.showwebbrowser"
helpviewer_keywords:
  - "ShowWebBrowser command"
  - "View.ShowWebBrowser command"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# ShowWebBrowser Command

Displays the URL you specify in a web browser window either within the integrated development environment (IDE) or external to the IDE.

## Syntax

```cmd
View.ShowWebBrowser URL [/new][/ext]
```

## Arguments
`URL`

Required. URL (Uniform Resource Locator) for the website.

## Switches
/new

Optional. Specifies that the page appears in a new instance of the web browser.

/ext

Optional. Specifies that the page appears in the default web browser outside of the IDE.

## Remarks
The alias for the **ShowWebBrowser** command is **navigate** or **nav**.

## Example
The following example displays the Microsoft Learn home page in a web browser outside of the IDE. If an instance of the web browser is already open, it is used; otherwise a new instance is launched.

```cmd
>View.ShowWebBrowser https://learn.microsoft.com /ext
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
