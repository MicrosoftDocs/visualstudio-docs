---
title: "Synchronize your settings in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/23/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "VS.ToolsOptionsPages.Environment.RoamingSettings"
ms.assetid: a3d2ea29-be5d-4012-9820-44b06adbb7dd
caps.latest.revision: 10
author: "kempb"
ms.author: "kempb"
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
# Synchronize your settings in Visual Studio
When you sign in to Visual Studio on multiple computers using the same personalization account, by default your settings are synchronized on all computers.

## Synchronized settings  
 By default, the following settings are synchronized.  

-   Development settings (You have to select a set of settings the first time you run Visual Studio, but you can change the selection anytime. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).)  

-   The following options in the **Tools &#124; Options** pages:  

    -   **Theme** and menu bar casing settings, on the **Environment**, **General** options page  

    -   All settings on the **Environment**, **Fonts and Colors** options page  

    -   All keyboard shortcuts, on the **Environment**, **Keyboard** options page  

    -   All settings on the **Environment, Tabs and Windows** options page  

    -   All settings on the **Environment**, **StartUp** options page  

    -   All settings on the **Text Editor** options pages  

-   All settings on the XAML Designer options pages  

-   User-defined command aliases. For more information about how to define command aliases, see [Visual Studio Command Aliases](../ide/reference/visual-studio-command-aliases.md).  

-   User-defined window layouts in **Window &#124; Manage Window Layouts** page  

## Turn off synchronized settings on a particular computer  
 Synchronized settings for Visual Studio are turned on by default. You can turn off synchronized settings on a computer by going to the **Tools &#124; Options &#124; Environment &#124; Synchronized Settings** page and unchecking the checkbox.  For example, if you decide not to synchronize Visual Studio's settings on Computer A, any setting changes made on Computer A do not appear on Computer B or Computer C. Computer B and C will continue to synchronize with each other, but not with Computer A.  

## Synchronize settings across Visual Studio family products and editions  
 Settings can be synchronized across any edition of Visual Studio, including the Community edition. Settings are also synchronized across Visual Studio family products. However, each of these family products may have its own settings that are not shared with Visual Studio. For example, settings specific to one product on Computer A will be shared with another on Computer B, but not with Visual Studio on Computer A or B.  

## See also  
 [Personalizing the  IDE](../ide/personalizing-the-visual-studio-ide.md)
