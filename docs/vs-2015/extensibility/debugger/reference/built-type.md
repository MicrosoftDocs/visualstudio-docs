---
title: "BUILT_TYPE | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BUILT_TYPE"
helpviewer_keywords: 
  - "BUILT_TYPE structure"
ms.assetid: cc02c32c-0f65-4210-ad25-a9b1899066e8
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# BUILT_TYPE
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This structure specifies information about a field type taken from metadata.  
  
## Syntax  
  
```cpp#  
typedef struct _tagTYPE_BUILT {  
   ULONG32      ulAppDomainID;  
   GUID         guidModule;  
   IDebugField* pUnderlyingField;  
} BUILT_TYPE;  
```  
  
```csharp  
public struct BUILT_TYPE {  
   public uint        ulAppDomainID;  
   public Guid        guidModule;  
   public IDebugField pUnderlyingField;  
};  
```  
  
#### Parameters  
 ulAppDomainID  
 ID of the application from which the symbol came. This is used to uniquely identify an instance of the application.  
  
 guidModule  
 The GUID of the module that contains this field.  
  
 pUnderlyingField  
 An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object identifying the underlying field associated with this built field.  
  
## Remarks  
 This structure appears as part of the union in the [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md) structure when the `dwKind` field of the `TYPE_INFO` structure is set to `TYPE_KIND_BUILT` (a value from the [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md)   
 [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
