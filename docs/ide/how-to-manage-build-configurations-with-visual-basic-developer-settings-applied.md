---
title: "How to: Manage Build Configurations with Visual Basic Developer Settings Applied | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio, building with Visual Basic settings"
  - "MSBuild, debug build"
  - "advanced build configurations"
  - "building with Visual Basic developer settings"
  - "debug builds"
  - "MSBuild, release build"
  - "release builds"
ms.assetid: eaea6e0b-6c61-4869-8d63-d372c745a23c
caps.latest.revision: 9
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
# How to: Manage Build Configurations with Visual Basic Developer Settings Applied
By default, all advanced build configuration options are hidden with [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] Developer settings applied. This topic explains how to manually enable these settings.  
  
## Enabling advanced build configurations  
 By default, the [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] Developer settings hide the option to open the **Configuration Manager** dialog box and the **Configuration** and **Platform** lists in the [Project Designer](http://msdn.microsoft.com/en-us/898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
#### To enable advanced build configurations  
  
1.  On the **Tools** menu, click **Options**.  
  
2.  Expand **Projects and Solutions**, and click **General**.  
  
    > [!NOTE]
    >  The **General** node is visible even if the **Show all settings** option is unchecked. If you want to see every option available, click **Show all settings**.  
  
3.  Click **Show advanced build configurations**.  
  
4.  Click **OK**.  
  
     On the **Build** menu, **Configuration Manager** is now available, and the **Configuration** and **Platform** lists are visible in the Project Designer.  
  
## See Also  
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)   
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)