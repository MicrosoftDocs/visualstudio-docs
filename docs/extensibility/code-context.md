---
title: "Code Context"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], contexts"
ms.assetid: 65e4d37a-086b-426e-9394-a3534967fd59
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# Code Context
In [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] debugging, a **code context**:  
  
-   Provides an abstraction of a position in code as known to the debug engine (DE). For most run-time architectures today, a code context can be thought of as an address in a program's instruction stream. For nontraditional languages, where code may not be represented by instructions, a code context may be represented by some other means.  
  
-   Describes the current position in the execution stream of the program being debugged.  
  
-   Exists only when a program has stopped at a breakpoint.  
  
-   Has an associated document context.  
  
-   Is implemented by an [IDebugCodeContext2](../extensibility/idebugcodecontext2.md) interface.  
  
## See Also  
 [Document Context](../extensibility/document-context.md)   
 [Debugger Contexts](../extensibility/debugger-contexts.md)