---
title: ShowWebBrowser Command
description: Learn about the Show Web Browser command and how it displays the URL you specify in a web browser window either within the IDE or external to the IDE.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "view.showwebbrowser"
helpviewer_keywords:
  - "ShowWebBrowser command"
  - "View.ShowWebBrowser command"
ms.assetid: c6a4fbd6-8e9d-45cc-8b2f-93990d065e78
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
  - "multiple"
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
The following example displays the Microsoft Docs home page in a web browser outside of the IDE. If an instance of the web browser is already open, it is used; otherwise a new instance is launched.

```cmd
>View.ShowWebBrowser https://docs.microsoft.com /ext
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)