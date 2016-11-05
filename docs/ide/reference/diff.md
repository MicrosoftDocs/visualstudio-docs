---
title: "-Diff | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 5377fedb-632a-4e86-a947-7c11c86451e7
caps.latest.revision: 2
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
# /Diff
Compares two files. The differences are displayed in a special Visual Studio window.  
  
## Syntax  
  
```  
devenv /Diff SourceFile, TargetFile, [SourceDisplayName],[TargetDisplayName]  
```  
  
## Arguments  
 `SourceFile`  
 Required. The full path and name of the first file to be compared.  
  
 `TargetFile`  
 Required. The full path and name of the second file to be compared  
  
 `SourceDisplayName`  
 Optional. The display name of the first file.  
  
 `TargetDisplayName`  
 Optional. The display name of the second file.