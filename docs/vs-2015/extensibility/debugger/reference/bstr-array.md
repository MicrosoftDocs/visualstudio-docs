---
title: "BSTR_ARRAY | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BSTR_ARRAY"
helpviewer_keywords: 
  - "BSTR_ARRAY structure"
ms.assetid: 48da37f7-a237-48a9-9ff9-389c1a00862c
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# BSTR_ARRAY
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

A structure that describes an array of strings.  
  
## Syntax  
  
```cpp#  
typedef struct tagBSTR_ARRAY {  
   DWORD dwCount;  
   BSTR* Members;  
} BSTR_ARRAY;  
```  
  
```csharp  
struct BSTR_ARRAY {  
   DWORD    dwCount;  
   string[] Members;  
}  
```  
  
## Terms  
 dwCount  
 Number of strings in `Members` array.  
  
 Members  
 Array of strings.  
  
## Remarks  
 This structure is returned from the [EnumPersistedPorts](../../../extensibility/debugger/reference/idebugportsupplier3-enumpersistedports.md) method.  
  
 [C++ only] Each individual string must be freed using `SysFreeString`, and the `Members` array must be freed with `CoTaskMemFree`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [EnumPersistedPorts](../../../extensibility/debugger/reference/idebugportsupplier3-enumpersistedports.md)
