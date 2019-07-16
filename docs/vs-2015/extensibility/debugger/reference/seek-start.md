---
title: "SEEK_START | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SEEK_START"
helpviewer_keywords: 
  - "SEEK_START enumeration"
ms.assetid: 55bd8901-626e-428b-a263-23b14417f4c6
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# SEEK_START
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the position from which to start seeking in a disassembly stream.  
  
## Syntax  
  
```cpp#  
enum enum_SEEK_START {   
   SEEK_START_BEGIN       = 0x0001,  
   SEEK_START_END         = 0x0002,  
   SEEK_START_CURRENT     = 0x0003,  
   SEEK_START_CODECONTEXT = 0x0004,  
   SEEK_START_CODELOCID   = 0x0005  
};  
typedef DWORD SEEK_START;  
```  
  
```csharp  
public enum enum_SEEK_START {   
   SEEK_START_BEGIN       = 0x0001,  
   SEEK_START_END         = 0x0002,  
   SEEK_START_CURRENT     = 0x0003,  
   SEEK_START_CODECONTEXT = 0x0004,  
   SEEK_START_CODELOCID   = 0x0005  
};  
```  
  
## Members  
 SEEK_START_BEGIN  
 Starts seeking at the beginning of the current document.  
  
 SEEK_START_END  
 Starts seeking at the end of the current document.  
  
 SEEK_START_CURRENT  
 Starts seeking at the current position of the current document.  
  
 SEEK_START_CODECONTEXT  
 Starts seeking at the given code context of the current document.  
  
 SEEK_START_CODELOCID  
 Starts seeking at the given code location identifier. Code location identifiers are obtained by calling [GetCurrentLocation](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcurrentlocation.md).  
  
## Remarks  
 Passed as an argument to the [Seek](../../../extensibility/debugger/reference/idebugdisassemblystream2-seek.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [Seek](../../../extensibility/debugger/reference/idebugdisassemblystream2-seek.md)   
 [GetCurrentLocation](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcurrentlocation.md)
