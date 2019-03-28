---
title: "IDiaFrameData::execute | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaFrameData::execute method"
ms.assetid: 7a6c7d03-1ff1-4059-bd54-5f407eeebc26
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaFrameData::execute
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Performs stack unwinding and returns results in a stack walk frame interface.  
  
## Syntax  
  
```cpp#  
HRESULT execute (   
   IDiaStackWalkFrame* frame  
);  
```  
  
#### Parameters  
 `frame`  
 [in] An [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md) object that holds the state of frame registers.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.  
  
|Value|Description|  
|-----------|-----------------|  
|E_DIA_INPROLOG|Cannot execute a stack frame while in prologue code.|  
|E_DIA_SYNTAX|Parse error encountered in frame program.|  
|E_DIA_FRAME_ACCESS|Unable to access registers or memory.|  
|E_DIA_VALUE|Error in computation of a value (for example, division by zero).|  
  
## Remarks  
 This method is called during debugging to unwind the stack. The [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md) object is implemented by the client application to receive updates to the registers and to provide methods used by the `execute` method.  
  
## See Also  
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)   
 [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md)
