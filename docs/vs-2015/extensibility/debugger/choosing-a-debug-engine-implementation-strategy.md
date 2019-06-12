---
title: "Choosing a Debug Engine Implementation Strategy | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debug engines, implementation strategies"
ms.assetid: 90458fdd-2d34-4f10-82dc-6d8f31b66d8b
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# Choosing a Debug Engine Implementation Strategy
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the run-time architecture to determine your debug engine (DE) implementation strategy. The debug engine may be created in-process to the program to be debugged, in-process to the Visual Studio session debug manager (SDM), or out-of-process to both of them. The following guidelines should help you to choose among these three strategies.  
  
## Guidelines  
 While it is possible for the DE to be out-of-process to both the SDM and the program to be debugged, there is typically no reason to do so. Calls across process boundaries are relatively slow.  
  
 Debug engines are already provided for the Win32 native run-time environment and for the common language runtime environment. If you must replace the DE for either of these environments, you must create the DE in-process with the SDM.  
  
 Otherwise, you can choose between creating the DE in-process to the SDM or in-process to the program to be debugged. It is important to consider whether the expression evaluator of the DE needs frequent access to the program symbol store, and whether the symbol store can be loaded into memory for rapid access. Also consider the following:  
  
- If there are not many calls between the expression evaluator and the symbol store, or if the symbol store can be read into the SDM memory space, create the DE in-process to the SDM. You must return the CLSID of the debug engine to the SDM when it attaches to your program. The SDM uses this CLSID to create an in-process instance of the DE.  
  
- If the DE must call the program to access the symbol store, create the DE in-process with the program. In this case, the program creates the instance of the DE.  
  
## See Also  
 [Visual Studio Debugger Extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)
