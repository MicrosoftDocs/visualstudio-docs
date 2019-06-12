---
title: "DEBUG_ADDRESS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "DEBUG_ADDRESS"
helpviewer_keywords: 
  - "DEBUG_ADDRESS structure"
ms.assetid: 79f5e765-9aac-4b6e-82ef-bed88095e9ba
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# DEBUG_ADDRESS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This structure represents an address.  
  
## Syntax  
  
```cpp  
typedef struct _tagDEBUG_ADDRESS {  
   ULONG32             ulAppDomainID;  
   GUID                guidModule;  
   _mdToken            tokClass;  
   DEBUG_ADDRESS_UNION addr;  
} DEBUG_ADDRESS;  
```  
  
```csharp  
public struct DEBUG_ADDRESS {  
   public uint                ulAppDomainID;  
   public Guid                guidModule;  
   public int                 tokClass;  
   public DEBUG_ADDRESS_UNION addr;  
}  
```  
  
## Terms  
 ulAppDomainID  
 The process ID.  
  
 guidModule  
 The GUID of the module that contains this address.  
  
 tokClass  
 The token identifying the class or type of this address.  
  
> [!NOTE]
> This value is specific to a symbol provider and therefore has no general meaning other than as an identifier for a class type.  
  
 addr  
 A [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) structure, which contains a union of structures that describe the individual address types. The value `addr`.`dwKind` comes from the [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeration, which explains how to interpret the union.  
  
## Remarks  
 This structure is passed to the [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md) method to be filled in.  
  
 **Warning [C++ only]**  
  
 If `addr.dwKind` is `ADDRESS_KIND_METADATA_LOCAL` and if `addr.addr.addrLocal.pLocal` is not a null value, then you must call `Release` on the token pointer:  
  
```  
if (addr.dwKind == ADDRESS_KIND_METADATA_LOCAL &&  addr.addr.addrLocal.pLocal != NULL)  
{  
    addr.addr.addrLocal.pLocal->Release();  
}  
```  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md)   
 [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)   
 [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md)
