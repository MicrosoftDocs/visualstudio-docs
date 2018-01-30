---
title: "International Settings, Environment, Options Dialog Box | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 14
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# International Settings, Environment, Options Dialog Box
The International Settings page allows you to change the default language when you have more than one language version of the integrated development environment (IDE) installed on your machine. You can access this dialog box by selecting **Options** from the **Tools** menu and then choosing **International Settings** from the **Environment** folder. If this page does not appear in the list, select **Show all settings** in the **Options** dialog box.  
  
> [!NOTE]
>  The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).  
  
 **Language**  
 Lists the available languages for the installed product language versions. This option is unavailable unless you have more than one language version installed on your machine. If multiple languages of products or a mixed language installation of products share the environment, the language selection is changed to **Same as Microsoft Windows**.  
  
> [!CAUTION]
>  In a system with multiple languages installed, the Visual C++ build tools (cl.exe, link.exe, nmake.exe, bscmake.exe and related files) are not affected by this setting. These tools use the version for the last language installed. The build tools for the previously installed language are overwritten, because the Visual C++ build tools do not use the satellite DLL model.  
  
## See Also  
 [Install language packs](../../install/install-visual-studio.md#step-6---install-language-packs-optional)   
 [Environment Options Dialog Box](../../ide/reference/environment-options-dialog-box.md)