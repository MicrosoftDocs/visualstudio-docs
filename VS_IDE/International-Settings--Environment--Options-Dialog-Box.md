---
title: "International Settings, Environment, Options Dialog Box"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e3a8815c-6995-4099-8e88-34f91fad55b2
caps.latest.revision: 14
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# International Settings, Environment, Options Dialog Box
The International Settings page allows you to change the default language when you have more than one language version of the integrated development environment (IDE) installed on your machine. You can access this dialog box by selecting **Options** from the **Tools** menu and then choosing **International Settings** from the **Environment** folder. If this page does not appear in the list, select **Show all settings** in the **Options** dialog box.  
  
> [!NOTE]
>  The options available in dialog boxes, and the names and locations of menu commands you see, might differ from what is described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 **Language**  
 Lists the available languages for the installed product language versions. This option is unavailable unless you have more than one language version installed on your machine. If multiple languages of products or a mixed language installation of products share the environment, the language selection is changed to **Same as Microsoft Windows**.  
  
> [!CAUTION]
>  In a system with multiple languages installed, the Visual C++ build tools (cl.exe, link.exe, nmake.exe, bscmake.exe and related files) are not affected by this setting. These tools use the version for last language installed and the tools for the previously installed language are overwritten because the Visual C++ build tools do not use the satellite DLL model.  
  
## See Also  
 [Installing Multiple Language Versions of Visual Studio](../VS_Installing/Installing-Multiple-Language-Versions-of-Visual-Studio.md)   
 [Environment Options Dialog Box](../VS_IDE/Environment-Options-Dialog-Box.md)