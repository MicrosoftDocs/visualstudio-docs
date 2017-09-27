---
title: "Code Styles and Quick Actions | Microsoft Docs"
ms.custom: ""
ms.date: "03/10/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.devlang: csharp
ms.assetid: 25bb9d99-aeff-4053-925d-2177f5e79574
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
f1_keywords: 
  - "VS.ToolsOptionsPages.Text_Editor.CSharp.Code_Style.General"
  - "VS.ToolsOptionsPages.Text_Editor.Basic.Code_Style.General"
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

# Code Styles and Quick Actions
Code style preferences can be set for your C# and Visual Basic projects by opening the **Tools > Options** window, and then selecting **Text Editor > C# / Basic > Code Style > General**.  Options set in this window are applicable to the local machine.  Each item in the list will show a preview of the preference when selected, as shown below.

![Code Style options](media/code-style-quick-actions-dialog.png)

For each item, you can set the **Preference** and **Severity** using the drop downs on each line.  Severity can be set to **None**, **Suggestion**, **Warning**, or **Error**, and Visual Studio will behave appropriately.  If you want to use [Quick Actions](quick-actions.md) with these code styles to automatically rewrite code to the preferred style, ensure that the setting is set to something other than **None** so the light bulb icon ![Small Light Bulb Icon](media/vs2015_lightbulbsmall.png "VS2017_LightBulbSmall") will appear when the non-preferred styles are used.  These preferences can then can be applied by clicking the Light Bulb icon or pressing **Ctrl + .** when your cursor is on the appropriate line of code.

Code Style settings for .NET can also be managed with an [EditorConfig](editorconfig-code-style-settings-reference.md) file.  In this case, the settings selected in the Options window will be the fallback settings, with the EditorConfig file taking precedence.  You can use this file to enforce and configure the coding style for your entire repo or team.

# See Also
* [Quick Actions](quick-actions.md)