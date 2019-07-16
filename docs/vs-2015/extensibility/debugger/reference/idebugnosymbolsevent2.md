---
title: "IDebugNoSymbolsEvent2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugNoSymbolsEvent2 interface"
ms.assetid: f6fb6388-47f6-4385-9ad5-95d62f9a7592
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IDebugNoSymbolsEvent2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Signals the [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] debugger UI to warn the user that symbols could not be located for the launched executable.  
  
## Syntax  
  
```  
IDebugNoSymbolsEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 Implemented by debug engines and consumed by the [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] debugger UI.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
