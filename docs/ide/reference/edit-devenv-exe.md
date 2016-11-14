---
title: "-Edit (devenv.exe) | Microsoft Docs"
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
  - "Devenv, /edit switch"
  - "/Edit Devenv swtich"
ms.assetid: 02b3d6e7-a2b1-4d83-a747-aa8c2fb758b7
caps.latest.revision: 6
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
# /Edit (devenv.exe)
Opens the specified file in an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].  
  
## Syntax  
  
```  
Devenv /edit [file1[ file2]]  
```  
  
## Arguments  
 `file1`  
 Optional. The file to open in an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. If no instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] exists, a new instance is created with a simplified window layout, and `file1` is opened in the new instance.  
  
 `file2`  
 Optional. One or more additional files to open in the existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].  
  
## Remarks  
 If no file is specified and there is an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], the existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] receives focus. If no file is specified and there is no existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], a new instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is created with a simplified window layout.  
  
 If the existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is in a modal state, for example, if the [Options dialog box](../../ide/reference/options-dialog-box-visual-studio.md) is open, the file will open in the existing instance when [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] exits the modal state.  
  
## Example  
 This example opens the file `MyFile.cs` in an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] or opens the file in a new instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] if one does not already exist.  
  
```  
devenv /edit MyFile.cs  
```  
  
## See Also  
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)