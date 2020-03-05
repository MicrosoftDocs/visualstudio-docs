---
title: "International Settings, Environment, Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Environment.InternationalSettings"
  - "VS.ToolsOptionsPages.Environment.International_Settings"
  - "VS.Environment.International Settings"
  - "VS.ToolsOptionsPag.Environment.International_Settings"
helpviewer_keywords:
  - "International Settings dialog box"
  - "languages, environment settings"
  - "Options dialog box, international settings"
  - "languages, specifying default"
ms.assetid: e3a8815c-6995-4099-8e88-34f91fad55b2
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# International Settings, Environment, Options Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The International Settings page allows you to change the default language when you have more than one language version of the integrated development environment (IDE) installed on your machine. You can access this dialog box by selecting **Options** from the **Tools** menu and then choosing **International Settings** from the **Environment** folder. If this page does not appear in the list, select **Show all settings** in the **Options** dialog box.

> [!NOTE]
> The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

 **Language**
 Lists the available languages for the installed product language versions. This option is unavailable unless you have more than one language version installed on your machine. If multiple languages of products or a mixed language installation of products share the environment, the language selection is changed to **Same as Microsoft Windows**.

> [!CAUTION]
> In a system with multiple languages installed, the Visual C++ build tools (cl.exe, link.exe, nmake.exe, bscmake.exe and related files) are not affected by this setting. These tools use the version for last language installed and the tools for the previously installed language are overwritten because the Visual C++ build tools do not use the satellite DLL model.

## See Also
 [Environment Options Dialog Box](../../ide/reference/environment-options-dialog-box.md)
