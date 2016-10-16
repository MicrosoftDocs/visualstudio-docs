---
title: "TYPE_INFO"
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
  - "TYPE_INFO"
helpviewer_keywords: 
  - "TYPE_INFO structure"
ms.assetid: d725cb68-a565-49d1-a16f-ff0445c587a0
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
# TYPE_INFO
This structure specifies various kinds of information about a field's type.  
  
## Syntax  
  
```cpp#  
struct _tagTYPE_INFO_UNION {  
   dwTYPE_KIND dwKind;  
   union {  
      METADATA_TYPE typeMeta;  
      PDB_TYPE      typePdb;  
      BUILT_TYPE    typeBuilt;  
      DWORD         unused;  
   } type;  
} TYPE_INFO;  
```  
  
```c#  
public struct TYPE_INFO {  
   public uint   dwKind;  
   public IntPtr unionmember;  
};  
```  
  
#### Parameters  
 dwKind  
 A value from the [dwTYPE_KIND](../extensibility/dwtype_kind.md) enumeration that determines how to interpret the union.  
  
 type.typeMeta  
 [C++ only] Contains a [METADATA_TYPE](../extensibility/metadata_type.md) structure if `dwKind` is `TYPE_KIND_METADATA`.  
  
 type.typePdb  
 [C++ only] Contains a [PDB_TYPE](../extensibility/pdb_type.md) structure if `dwKind` is `TYPE_KIND_PDB`.  
  
 type.typeBuilt  
 [C++ only] Contains a [BUILT_TYPE](../extensibility/built_type.md) structure if `dwKind` is `TYPE_KIND_BUILT`.  
  
 type.unused  
 Unused padding.  
  
 type  
 Name of the union.  
  
 unionmember  
 [C# only] Marshal this to the appropriate structure type based on `dwKind`.  
  
## Remarks  
 This structure is passed to the [GetTypeInfo](../extensibility/idebugfield--gettypeinfo.md) method where it is filled in. How the contents of the structure are interpreted is based on the `dwKind` field.  
  
> [!NOTE]
>  [C++ only] If `dwKind` equals `TYPE_KIND_BUILT`, then it is necessary to release the underlying [IDebugField](../extensibility/idebugfield.md) object when destroying the `TYPE_INFO` structure. This is done by calling `typeInfo.type.typeBuilt.pUnderlyingField->Release()`.  
  
 [C# only] The following table shows how to interpret the `unionmember` member for each kind of type. The Example shows how this is done for one kind of type.  
  
|`dwKind`|`unionmember` interpreted as|  
|--------------|----------------------------------|  
|`TYPE_KIND_METADATA`|[METADATA_TYPE](../extensibility/metadata_type.md)|  
|`TYPE_KIND_PDB`|[PDB_TYPE](../extensibility/pdb_type.md)|  
|`TYPE_KIND_BUILT`|[BUILT_TYPE](../extensibility/built_type.md)|  
  
## Example  
 This example shows how to interpret the `unionmember` member of the `TYPE_INFO` structure in C#. This example shows interpreting only one type (`TYPE_KIND_METADATA`) but the others are interpreted in exactly the same way.  
  
```c#  
using System;  
using System.Runtime.Interop.Services;  
using Microsoft.VisualStudio.Debugger.Interop;  
  
namespace MyPackage  
{  
    public class MyClass  
    {  
        public void Interpret(TYPE_INFO ti)  
        {  
            if (ti.dwKind == (uint)enum_dwTypeKind.TYPE_KIND_METADATA)  
            {  
                 METADATA_TYPE dataType = (METADATA_TYPE)Marshal.PtrToStructure(ti.unionmember,  
                                               typeof(METADATA_TYPE));  
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
 [dwTYPE_KIND](../extensibility/dwtype_kind.md)   
 [GetTypeInfo](../extensibility/idebugfield--gettypeinfo.md)   
 [METADATA_TYPE](../extensibility/metadata_type.md)   
 [PDB_TYPE](../extensibility/pdb_type.md)   
 [BUILT_TYPE](../extensibility/built_type.md)