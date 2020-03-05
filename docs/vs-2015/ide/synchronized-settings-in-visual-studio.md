---
title: "Synchronized Settings"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "VS.ToolsOptionsPages.Environment.RoamingSettings"
ms.assetid: a3d2ea29-be5d-4012-9820-44b06adbb7dd
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: jillfra
---
# Synchronized Settings in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you use the same personalization account to sign in to Visual Studio on multiple computers, by default your settings are synchronized on all computers.

## Synchronized settings
 By default, the following settings are synchronized.

- Development settings (You have to select a set of settings the first time you run Visual Studio, but you can change the selection anytime. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).)

- The following options in the **Tools &#124; Options** pages:

  - **Theme** and menu bar casing settings, on the **Environment**, **General** options page

  - All settings on the **Environment**, **Fonts and Colors** options page

  - All keyboard shortcuts, on the **Environment**, **Keyboard** options page

  - All settings on the **Environment, Tabs and Windows** options page

  - All settings on the **Environment**, **StartUp** options page

  - All settings on the **Text Editor** options pages

- All settings on the XAML Designer options pages

- User-defined command aliases. For more information about how to define command aliases, see [Visual Studio Command Aliases](../ide/reference/visual-studio-command-aliases.md).

- User-defined window layouts in **Window &#124; Manage Window Layouts** page

## Turning synchronized settings off for a particular computer
 Synchronized settings for Visual Studio are turned on by default. You can turn off synchronized settings on a computer by going to the **Tools &#124; Options &#124; Environment &#124; Synchronized Settings** page and unchecking the checkbox.  For example, if you decide not to synchronize Visual Studio’s settings on Computer A, any setting changes made on Computer A do not appear on Computer B or Computer C. Computer B and C will continue to synchronize with each other, but not with Computer A.

## Synchronizing settings across Visual Studio family products and editions
 Settings can be synchronized across any edition of Visual Studio 2015, including Express and Community editions. Settings are also synchronized across Visual Studio family products, such as Blend. However, each of these family products may have its own settings that are not shared with Visual Studio. For example, settings specific to Blend on Computer A will be shared with Blend on Computer B, but not with Visual Studio on Computer A or B.

> [!WARNING]
> Settings are not synchronized between Visual Studio 2013 and Visual Studio 2015. The first time you open Visual Studio 2015, your settings from Visual Studio 2013 are migrated, but they cannot be migrated back to Visual Studio 2013 after that.

## See Also
 [Personalizing the  IDE](../ide/personalizing-the-visual-studio-ide.md)
