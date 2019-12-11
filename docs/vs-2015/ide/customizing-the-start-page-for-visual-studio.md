---
title: "Customizing the Start Page | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.startpage"
  - "VS.StartPage.HowDoI"
  - "vs.ToolsOptionsPages.Startup"
helpviewer_keywords:
  - "Start Page [Visual Studio]"
  - "customizing Start Page [Visual Studio]"
  - "Visual Studio Start page"
ms.assetid: 925d42eb-ec34-426e-ad81-19db8630e536
caps.latest.revision: 48
author: jillre
ms.author: jillfra
manager: jillfra
---
# Customizing the Start Page for Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can customize the start page for Visual Studio in several default ways, such as showing the **Open Project** dialog box or opening the solution that was loaded most recently. You can also show a custom start page, which is a Windows Presentation Foundation (WPF) XAML page that runs in a tool window and can run commands that are internal to Visual Studio.

## Customizing the default start page

1. On the menu bar, choose **Tools**, **Options**.

2. Expand **Environment**, and then choose **Startup**.

3. In the **At startup** list, choose the item for the customization that you want.

## Show a custom start page

1. Install a custom start page in one of the following ways:

    - Install it from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/), another website, or a page on your local intranet.

        > [!NOTE]
        > If you like a page that's targeted for an earlier version of Visual Studio, you can upgrade the page by using the Visual Studio SDK. See [How to: Upgrade a Visual Studio Custom Start Page](../misc/how-to-upgrade-a-visual-studio-custom-start-page.md).

         Open a .vsix file that contains a custom start page, or copy and paste the start-page files into the **%USERPROFILE% \My Documents\Visual Studio 2015\StartPages** folder on your computer.

    - Create your own start page if you've installed the Visual Studio SDK.

         See [Creating Your Own Start Page](../misc/creating-your-own-start-page.md).

2. On the menu bar, choose **Tools**, **Options**.

3. Expand **Environment**, and then choose **Startup**.

4. In the **Customize Start Page** list, choose the page that you want.

> [!NOTE]
> If an error in a custom start page causes Visual Studio to crash, you can start Visual Studio in safe mode and then set it to use the default start page. See [/SafeMode (devenv.exe)](../ide/reference/safemode-devenv-exe.md).

## See Also
 [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3)
 [Creating Your Own Start Page](../misc/creating-your-own-start-page.md)
