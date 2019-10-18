---
title: "Set Current Stack Frame Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "debug.setcurrentstackframe"
helpviewer_keywords: 
  - "Set Current Stack Frame command"
  - "Debug.SetCurrentStackFrame command"
ms.assetid: 3dcf52c0-6781-4598-bac2-0094dce67c20
caps.latest.revision: 18
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Set Current Stack Frame Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Allows you to set a particular stack frame.  
  
## Syntax  
  
```  
Debug.SetCurrentStackFrame index  
```  
  
## Arguments  
 `index`  
 Required. Selects a stack frame by its index.  
  
## Example  
  
```  
>Debug.SetCurrentStackFrame 1  
```  
  
## See also  
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)   
 [Command Window](../../ide/reference/command-window.md)   
 [Find/Command Box](../../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
