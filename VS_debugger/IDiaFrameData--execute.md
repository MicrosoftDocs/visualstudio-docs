---
title: "IDiaFrameData::execute"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7a6c7d03-1ff1-4059-bd54-5f407eeebc26
caps.latest.revision: 8
manager: ghogen
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
# IDiaFrameData::execute
Performs stack unwinding and returns results in a stack walk frame interface.  
  
## Syntax  
  
```cpp#  
HRESULT execute (   
   IDiaStackWalkFrame* frame  
);  
```  
  
#### Parameters  
 `frame`  
 [in] An [IDiaStackWalkFrame](../VS_debugger/IDiaStackWalkFrame.md) object that holds the state of frame registers.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.  
  
|Value|Description|  
|-----------|-----------------|  
|E_DIA_INPROLOG|Cannot execute a stack frame while in prologue code.|  
|E_DIA_SYNTAX|Parse error encountered in frame program.|  
|E_DIA_FRAME_ACCESS|Unable to access registers or memory.|  
|E_DIA_VALUE|Error in computation of a value (for example, division by zero).|  
  
## Remarks  
 This method is called during debugging to unwind the stack. The [IDiaStackWalkFrame](../VS_debugger/IDiaStackWalkFrame.md) object is implemented by the client application to receive updates to the registers and to provide methods used by the `execute` method.  
  
## See Also  
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)   
 [IDiaStackWalkFrame](../VS_debugger/IDiaStackWalkFrame.md)