---
title: "Resource Compiler Error RC2136"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4e9b2ff1-402c-4ec4-8610-fc8fd5f213c0
caps.latest.revision: 6
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Resource Compiler Error RC2136
missing '=' in EXSTYLE=<flags\>  
  
 An equal sign (**=**) was missing from an **EXSTYLE** (Extended Style Flags) statement. When the **EXSTYLE** is embedded in the **DIALOG** or **MENU** statement it must have the following form:  
  
```  
EXSTYLE=FLAGS  
```