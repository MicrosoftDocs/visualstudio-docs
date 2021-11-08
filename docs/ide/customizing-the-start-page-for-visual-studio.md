---
title: Change the startup experience
description: Learn how to customize your startup experience so Visual Studio opens with the tools that are most useful to you.
ms.custom: SEO-VS-2020
ms.date: 02/01/2017
ms.topic: conceptual
f1_keywords:
- vs.ToolsOptionsPages.Startup
helpviewer_keywords:
- Start Page [Visual Studio]
- customizing Start Page [Visual Studio]
- Visual Studio Start Page
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Customize startup

You can customize the startup experience for Visual Studio in several different ways, such as opening your most recent solution or just an empty development environment.

::: moniker range="vs-2017"

You can also show a custom start page, which is a Windows Presentation Foundation (WPF) XAML page that runs in a tool window and can run commands that are internal to Visual Studio.

::: moniker-end

## To change the startup item

1. On the menu bar, choose **Tools** > **Options**.

2. Expand **Environment**, and then choose **Startup**.

::: moniker range="vs-2017"

3. In the **At startup** list, choose the item to be displayed after Visual Studio launches.

::: moniker-end

::: moniker range=">=vs-2019"

3. In the **On startup, open** list, choose what you want to happen after Visual Studio launches. You can choose from **Start window** (which lets you open a new or existing project), **Most recent solution**, or **Empty environment**.

::: moniker-end

::: moniker range="vs-2017"

## To show a custom start page

You can [create your own custom start page](../extensibility/creating-a-custom-start-page.md) using the Visual Studio SDK, or use one that somebody else has already created. For example, you can find custom start pages at the [Visual Studio Marketplace](https://marketplace.visualstudio.com/search?target=VS&category=Tools&vsVersion=&subCategory=Start%20Pages&sortBy=Downloads).

To install a custom start page, open the *.vsix* file, or copy and paste the start page files into the *%USERPROFILE%\Documents\Visual Studio 2017\StartPages* folder on your computer.

### To select which custom start page to display

1. On the menu bar, choose **Tools** > **Options**.

1. Expand **Environment**, and then choose **Startup**.

1. In the **Customize Start Page** list, choose the page that you want.

> [!TIP]
> If an error in a custom start page causes Visual Studio to crash, you can open Visual Studio in safe mode and then set it to use the default start page. See [/SafeMode (devenv.exe)](../ide/reference/safemode-devenv-exe.md).

## See also

- [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md)

::: moniker-end
