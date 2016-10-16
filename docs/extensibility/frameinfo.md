---
title: "FRAMEINFO"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "FRAMEINFO"
helpviewer_keywords: 
  - "FRAMEINFO structure"
ms.assetid: 95001b89-dddb-45bb-889d-8327994e38a5
caps.latest.revision: 8
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
# FRAMEINFO
Describes a stack frame.  
  
## Syntax  
  
```cpp#  
typedef struct tagFRAMEINFO {   
   FRAMEINFO_FLAGS    m_dwValidFields;  
   BSTR               m_bstrFuncName;  
   BSTR               m_bstrReturnType;  
   BSTR               m_bstrArgs;  
   BSTR               m_bstrLanguage;  
   BSTR               m_bstrModule;  
   UINT64             m_addrMin;  
   UINT64             m_addrMax;  
   IDebugStackFrame2* m_pFrame;  
   IDebugModule2*     m_pModule;  
   BOOL               m_fHasDebugInfo;  
   BOOL               m_fStaleCode;  
   BOOL               m_fAnnotatedFrame;  
} FRAMEINFO;  
```  
  
```c#  
public struct FRAMEINFO {   
   public uint              m_dwValidFields;  
   public string            m_bstrFuncName;  
   public string            m_bstrReturnType;  
   public string            m_bstrArgs;  
   public string            m_bstrLanguage;  
   public string            m_bstrModule;  
   public ulong             m_addrMin;  
   public ulong             m_addrMax;  
   public IDebugStackFrame2 m_pFrame;  
   public IDebugModule2     m_pModule;  
   public int               m_fHasDebugInfo;  
   public int               m_fStaleCode;  
   public int               m_fAnnotatedFrame;  
} FRAMEINFO;  
```  
  
## Members  
 m_dwValidFields  
 A combination of flags from the [FRAMEINFO_FLAGS](../extensibility/frameinfo_flags.md) enumeration that specifies which fields are filled in.  
  
 m_bstrFuncName  
 The function name associated with the stack frame.  
  
 m_bstrReturnType  
 The return type associated with the stack frame.  
  
 m_bstrArgs  
 The arguments to the function associated with the stack frame.  
  
 m_bstrLanguage  
 The language in which the function is implemented.  
  
 m_bstrModule  
 The module name associated with the stack frame.  
  
 m_addrMin  
 The minimum physical stack address.  
  
 m_addrMAX  
 The maximum physical stack address.  
  
 m_pFrame  
 The [IDebugStackFrame2](../extensibility/idebugstackframe2.md) object that represents this stack frame.  
  
 m_pFrame  
 The [IDebugModule2](../extensibility/idebugmodule2.md) object that represents the module that contains this stack frame.  
  
 m_fHasDebugInfo  
 Non-zero (`TRUE`) if debug information exists in the given frame.  
  
 m_fHasDebugInfo  
 Non-zero (`TRUE`) if the stack frame is associated with code that is no longer valid.  
  
 m_fHasDebugInfo  
 Non-zero (`TRUE`) if the stack frame is annotated by the session debug manager (SDM).  
  
## Remarks  
 This structure is passed to the [GetInfo](../extensibility/idebugstackframe2--getinfo.md) method to be filled in. This structure is also contained in a list that is contained in the [IEnumDebugFrameInfo2](../extensibility/ienumdebugframeinfo2.md) interface which, in turn, is returned from a call to the [EnumFrameInfo](../extensibility/idebugthread2--enumframeinfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [FRAMEINFO_FLAGS](../extensibility/frameinfo_flags.md)   
 [IDebugStackFrame2](../extensibility/idebugstackframe2.md)   
 [IDebugModule2](../extensibility/idebugmodule2.md)   
 [GetInfo](../extensibility/idebugstackframe2--getinfo.md)   
 [IEnumDebugFrameInfo2](../extensibility/ienumdebugframeinfo2.md)   
 [EnumFrameInfo](../extensibility/idebugthread2--enumframeinfo.md)