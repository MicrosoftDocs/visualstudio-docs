---
title: "IDebugDisassemblyStream2::Seek | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugDisassemblyStream2::Seek"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::Seek"
ms.assetid: afec3008-b1e0-4803-ad24-195dbfb6497e
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
# IDebugDisassemblyStream2::Seek
Moves the read pointer in the disassembly stream a given number of instructions relative to a specified position.  
  
## Syntax  
  
```cpp#  
HRESULT Seek(   
   SEEK_START          dwSeekStart,  
   IDebugCodeContext2* pCodeContext,  
   UINT64              uCodeLocationId,  
   INT64               iInstructions  
);  
```  
  
```c#  
int Seek(   
   enum_SEEK_START    dwSeekStart,  
   IDebugCodeContext2 pCodeContext,  
   ulong              uCodeLocationId,  
   long               iInstructions  
);  
```  
  
#### Parameters  
 `dwSeekStart`  
 [in] A value from the [SEEK_START](../../../extensibility/debugger/reference/seek-start.md) enumeration that specifies the relative position to begin the seek process.  
  
 `pCodeContext`  
 [in] The [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object representing the code context that the seek operation is relative to. This parameter is used only if `dwSeekStart` = `SEEK_START_CODECONTEXT`; otherwise, this parameter is ignored and can be a null value.  
  
 `uCodeLocationId`  
 [in] The code location identifier that the seek operation is relative to. This parameter is used if `dwSeekStart` = `SEEK_START_CODELOCID`; otherwise, this parameter is ignored and can be set to 0. See the Remarks section for the [GetCodeLocationId](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodelocationid.md) method for a description of a code location identifier.  
  
 `iInstructions`  
 [in] The number of instructions to move relative to the position specified in `dwSeekStart`. This value can be negative to move backwards.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if the seek position was to a point beyond the list of available instructions. Otherwise, returns an error code.  
  
## Remarks  
 If the seek was to a position before the beginning of the list, the read position is set to the first instruction in the list. If the see was to a position after the end of the list, the read position is set to the last instruction in the list.  
  
## See Also  
 [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md)   
 [SEEK_START](../../../extensibility/debugger/reference/seek-start.md)   
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)   
 [GetCodeLocationId](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodelocationid.md)