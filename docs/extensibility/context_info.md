---
title: "CONTEXT_INFO"
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
  - "CONTEXT_INFO"
helpviewer_keywords: 
  - "CONTEXT_INFO structure"
ms.assetid: 6b513f4e-e7b0-4969-adf0-2205ccc1e09b
caps.latest.revision: 11
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
# CONTEXT_INFO
This structure describes a memory context or code context.  
  
## Syntax  
  
```cpp#  
typedef struct _tagCONTEXT_INFO {   
   CONTEXT_INFO_FIELDS dwFields;  
   BSTR                bstrModuleUrl;  
   BSTR                bstrFunction;  
   TEXT_POSITION       posFunctionOffset;  
   BSTR                bstrAddress;  
   BSTR                bstrAddressOffset;  
   BSTR                bstrAddressAbsolute;  
} CONTEXT_INFO;  
```  
  
```c#  
public struct CONTEXT_INFO {  
   public uint          dwFields;  
   public string        bstrModuleUrl;  
   public string        bstrFunction;  
   public TEXT_POSITION posFunctionOffset;  
   public string        bstrAddress;  
   public string        bstrAddressOffset;  
   public string        bstrAddressAbsolute;  
};  
```  
  
## Members  
 dwFields  
 A combination of flags from he [CONTEXT_INFO_FIELDS](../extensibility/context_info_fields.md) enumeration that specifies which fields are filled out**.**  
  
 bstrModuleUrl  
 The name of the module where the context is located.  
  
 bstrFunction  
 The function name where the context is located.  
  
 posFunctionOffset  
 A [TEXT_POSITION](../extensibility/text_position.md) structure that identifies the line and column offset of the function associated with the code context.  
  
 bstrAddress  
 The address in code where the given context is located.  
  
 bstrAddressOffset  
 The offset of the address in code where the given context is located.  
  
 bstrAddressAbsolute  
 The absolute address in memory where the given context is located.  
  
## Remarks  
 This structure is returned from a call to the [GetInfo](../extensibility/idebugmemorycontext2--getinfo.md) method.  
  
 A typical use for this structure is in support of a **Memory** debug window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [GetInfo](../extensibility/idebugmemorycontext2--getinfo.md)   
 [CONTEXT_INFO_FIELDS](../extensibility/context_info_fields.md)   
 [TEXT_POSITION](../extensibility/text_position.md)