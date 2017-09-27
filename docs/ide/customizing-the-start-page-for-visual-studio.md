---
title: "Customize the Start Page for Visual Studio | Microsoft Docs"
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
ms.assetid: 925d42eb-ec34-426e-ad81-19db8630e536
caps.latest.revision: 45
author: "gewarren"
ms.author: "gewarren"
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
# Customize the start page for Visual Studio
You can customize the start page for Visual Studio in several default ways, such as showing the **Open Project** dialog box or opening the solution that was loaded most recently. You can also show a custom start page, which is a Windows Presentation Foundation (WPF) XAML page that runs in a tool window and can run commands that are internal to Visual Studio.  

## Customize the default start page  

1.  On the menu bar, choose **Tools**, **Options**.  

2.  Expand **Environment**, and then choose **Startup**.  

3.  In the **At startup** list, choose the item for the customization that you want.  

## Show a custom start page  

1.  Install a custom start page in one of the following ways:  

    -   Install it from the [Visual Studio Gallery](http://visualstudiogallery.msdn.microsoft.com/site/search?f%5B0%5D.Type=SearchText&f%5B0%5D.Value=start%20page), another website, or a page on your local intranet.  

        Open a .vsix file that contains a custom start page, or copy and paste the start-page files into the **%USERPROFILE% \My Documents\Visual Studio 2017\StartPages** folder on your computer.  

    -   Create your own start page if you've installed the Visual Studio SDK.  

         See [Creating a Custom Start Page](../extensibility/creating-a-custom-start-page.md).  

2.  On the menu bar, choose **Tools**, **Options**.  

3.  Expand **Environment**, and then choose **Startup**.  

4.  In the **Customize Start Page** list, choose the page that you want.  

> [!NOTE]
>  If an error in a custom start page causes Visual Studio to crash, you can start Visual Studio in safe mode and then set it to use the default start page. See [/SafeMode (devenv.exe)](../ide/reference/safemode-devenv-exe.md).  

## See also  
 [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md)   
