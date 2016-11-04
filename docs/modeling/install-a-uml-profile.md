---
title: "Install a UML profile | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "UML - extending, profiles"
ms.assetid: 586f9ba5-4d01-4a1d-b001-32e2efaa4f24
caps.latest.revision: 11
author: "alexhomer1"
ms.author: "ahomer"
manager: "douge"
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
# Install a UML profile
You can extend Visual Studio with a UML profile. A profile lets you add stereotypes and additional properties to the elements you can create in UML models. To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
 If you receive a UML model that has been created using profiles, some properties will not be displayed unless you install the same profiles.  
  
 A profile is distributed inside a Visual Studio Extension. An extension might also contain other features such as menu commands. For more information, see [Managing Visual Studio Extensions](http://go.microsoft.com/fwlink/?LinkId=160728).  
  
### To install a UML Profile on your computer  
  
1.  The profile should have been given to you in the form of a Visual Studio Extension (`.vsix`) file. There might be other features in the same file.  
  
     Move the `.vsix` file to a convenient location on your computer.  
  
2.  Double-click the `.vsix` file in Windows Explorer (or File Explorer), or open it within [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)].  
  
3.  Click **Install** in the dialog box that appears.  
  
4.  To uninstall or temporarily disable the extension, open **Extension Manager** from the **Tools** menu.  
  
### To uninstall or disable a profile extension  
  
1.  On the Visual Studio **Tools** menu, click **Extension Manager**.  
  
2.  Click the extension that you want to remove, and then click **Disable** or **Uninstall**.  
  
## See Also  
 [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md)   
 [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)