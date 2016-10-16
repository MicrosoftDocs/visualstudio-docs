---
title: "DEBUG_ADDRESS_UNION"
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
  - "DEBUG_ADDRESS_UNION"
helpviewer_keywords: 
  - "DEBUG_ADDRESS_UNION union"
ms.assetid: e3d11aab-de0d-4109-b5dc-11e07e64382d
caps.latest.revision: 9
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
# DEBUG_ADDRESS_UNION
Describes different kinds of addresses.  
  
## Syntax  
  
```cpp  
typedef struct _tagDEBUG_ADDRESS_UNION {  
   ADDRESS_KIND dwKind;  
   union {  
      NATIVE_ADDRESS                  addrNative;  
      UNMANAGED_ADDRESS_THIS_RELATIVE addrThisRel;  
      UNMANAGED_ADDRESS_PHYSICAL      addrUPhysical;  
      METADATA_ADDRESS_METHOD         addrMethod;  
      METADATA_ADDRESS_FIELD          addrField;  
      METADATA_ADDRESS_LOCAL          addrLocal;  
      METADATA_ADDRESS_PARAM          addrParam;  
      METADATA_ADDRESS_ARRAYELEM      addrArrayElem;  
      METADATA_ADDRESS_RETVAL         addrRetVal;  
      DWORD                           unused;  
   } addr;  
} DEBUG_ADDRESS_UNION;  
```  
  
```c#  
public struct DEBUG_ADDRESS_UNION {  
   public ADDRESS_KIND dwKind;  
   public IntPtr       unionmember;  
}  
```  
  
## Terms  
 dwKind  
 A value from the [ADDRESS_KIND](../extensibility/address_kind.md) enumeration, specifying how to interpret the union.  
  
 addr.addrNative  
 [C++ only] Contains the [NATIVE_ADDRESS](../extensibility/native_address.md) structure if `dwKind` = ADDRESS_KIND_NATIVE.  
  
 addr.addrThisRel  
 [C++ only] Contains the[UNMANAGED_ADDRESS_THIS_RELATIVE](../extensibility/unmanaged_address_this_relative.md) structure if `dwKind` = ADDRESS_KIND_UNMANAGED_THIS_RELATIVE.  
  
 addr.addUPhysical  
 [C++ only] Contains the[UNMANAGED_ADDRESS_PHYSICAL](../extensibility/unmanaged_address_physical.md) structure if `dwKind` = ADDRESS_KIND_UNMANAGED_PHYSICAL.  
  
 addr.addrMethod  
 [C++ only] Contains the[METADATA_ADDRESS_METHOD](../extensibility/metadata_address_method.md) structure if `dwKind` = ADDRESS_KIND_METHOD.  
  
 addr.addrField  
 [C++ only] Contains the[METADATA_ADDRESS_FIELD](../extensibility/metadata_address_field.md) structure if `dwKind` = ADDRESS_KIND_FIELD.  
  
 addr.addrLocal  
 [C++ only] Contains the[METADATA_ADDRESS_LOCAL](../extensibility/metadata_address_local.md) structure if `dwKind` = ADDRESS_KIND_LOCAL.  
  
 addr.addrParam  
 [C++ only] Contains the[METADATA_ADDRESS_PARAM](../extensibility/metadata_address_param.md) structure if `dwKind` = ADDRESS_KIND_PARAM.  
  
 addr.addrArrayElem  
 [C++ only] Contains the[METADATA_ADDRESS_ARRAYELEM](../extensibility/metadata_address_arrayelem.md) structure if `dwKind` = ADDRESS_KIND_ARRAYELEM.  
  
 addr.addrRetVal  
 [C++ only] Contains the[METADATA_ADDRESS_RETVAL](../extensibility/metadata_address_retval.md) structure if `dwKind` = ADDRESS_KIND_RETVAL.  
  
 addr.unused  
 [C++ only] padding.  
  
 addr  
 [C++ only] The name of the union.  
  
 unionmember  
 [C# only] This value needs to be marshaled to the appropriate structure type based on `dwKind`. See Remarks for the association between `dwKind` and interpretation of the union.  
  
## Remarks  
 This structure is part of the [DEBUG_ADDRESS](../extensibility/debug_address.md) structure and represents one of a number of different kinds of addresses (the `DEBUG_ADDRESS` structure is filled in by a call to the [GetAddress](../extensibility/idebugaddress--getaddress.md) method).  
  
 [C# only] The following table shows how to interpret the `unionmember` member for each kind of address. The Example shows how this is done for one kind of address.  
  
|`dwKind`|`unionmember` interpreted as|  
|--------------|----------------------------------|  
|`ADDRESS_KIND_NATIVE`|[NATIVE_ADDRESS](../extensibility/native_address.md)|  
|`ADDRESS_KIND_UNMANAGED_THIS_RELATIVE`|[UNMANAGED_ADDRESS_THIS_RELATIVE](../extensibility/unmanaged_address_this_relative.md)|  
|`ADDRESS_KIND_UNMANAGED_PHYSICAL`|[UNMANAGED_ADDRESS_PHYSICAL](../extensibility/unmanaged_address_physical.md)|  
|`ADDRESS_KIND_METHOD`|[METADATA_ADDRESS_METHOD](../extensibility/metadata_address_method.md)|  
|`ADDRESS_KIND_FIELD`|[METADATA_ADDRESS_FIELD](../extensibility/metadata_address_field.md)|  
|`ADDRESS_KIND_LOCAL`|[METADATA_ADDRESS_LOCAL](../extensibility/metadata_address_local.md)|  
|`ADDRESS_KIND_PARAM`|[METADATA_ADDRESS_PARAM](../extensibility/metadata_address_param.md)|  
|`ADDRESS_KIND_ARRAYELEM`|[METADATA_ADDRESS_ARRAYELEM](../extensibility/metadata_address_arrayelem.md)|  
|`ADDRESS_KIND_RETVAL`|[METADATA_ADDRESS_RETVAL](../extensibility/metadata_address_retval.md)|  
  
## Example  
 This example shows how to interpret one kind of address (`METADATA_ADDRESS_ARRAYELEM`) of the `DEBUG_ADDRESS_UNION` structure in C#. The remaining elements can be interpreted in exactly the same way.  
  
```c#  
using System;  
using System.Runtime.Interop.Services;  
using Microsoft.VisualStudio.Debugger.Interop;  
  
namespace MyPackage  
{  
    public class MyClass  
    {  
        public void Interpret(DEBUG_ADDRESS_UNION dau)  
        {  
            if (dau.dwKind == (uint)enum_ADDRESS_KIND.ADDRESS_KIND_METADATA_ARRAYELEM)  
            {  
                 METADATA_ADDRESS_ARRAYELEM arrayElem =  
                     (METADATA_ADDRESS_ARRAYELEM)Marshal.PtrToStructure(dau.unionmember,  
                                 typeof(METADATA_ADDRESS_ARRAYELEM));  
            }  
        }  
    }  
}  
```  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [DEBUG_ADDRESS](../extensibility/debug_address.md)   
 [ADDRESS_KIND](../extensibility/address_kind.md)   
 [GetAddress](../extensibility/idebugaddress--getaddress.md)