---
title: "Install a custom start page or change the startup item in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "02/01/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.startpage"
  - "VS.StartPage.HowDoI"
  - "vs.ToolsOptionsPages.Startup"
helpviewer_keywords: 
  - "Start Page [Visual Studio]"
  - "customizing Start Page [Visual Studio]"
  - "Visual Studio Start page"
caps.latest.revision: 45
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Customize the start page for Visual Studio

You can customize the startup experience for Visual Studio in several different ways, such as showing the **Open Project** dialog box or opening the solution that was loaded most recently. You can also show a custom start page, which is a Windows Presentation Foundation (WPF) XAML page that runs in a tool window and can run commands that are internal to Visual Studio.

## To change the startup item

1. On the menu bar, choose **Tools**, **Options**.

1. Expand **Environment**, and then choose **Startup**.

1. In the **At startup** list, choose the item to be displayed after Visual Studio launches.

## To show a custom start page

You can [create your own custom start page](../extensibility/creating-a-custom-start-page.md) using the Visual Studio SDK, or use one that somebody else has already created. For example, you can find custom start pages at the [Visual Studio Marketplace](https://marketplace.visualstudio.com/search?target=VS&category=Tools&vsVersion=&subCategory=Start%20Pages&sortBy=Downloads).

To install a custom start page, open the .vsix file, or copy and paste the start page files into the **%USERPROFILE%\Documents\Visual Studio 2017\StartPages** folder on your computer.

### To select which custom start page to display

1. On the menu bar, choose **Tools**, **Options**.

1. Expand **Environment**, and then choose **Startup**.

1. In the **Customize Start Page** list, choose the page that you want.

> [!NOTE]
> If an error in a custom start page causes Visual Studio to crash, you can start Visual Studio in safe mode and then set it to use the default start page. See [/SafeMode (devenv.exe)](../ide/reference/safemode-devenv-exe.md).

## See also

[Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md)
