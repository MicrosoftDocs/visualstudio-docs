---
title: "IDebugPrimitiveTypeField::GetPrimitiveType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "GetPrimitiveType"
  - "IDebugPrimitiveTypeField::GetPrimitiveType"
ms.assetid: a186c922-bbfe-478c-a744-b21eb4672d8f
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugPrimitiveTypeField::GetPrimitiveType
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the primitive type that is associated with this field.  
  
## Syntax  
  
```cpp#  
HRESULT GetPrimitiveType (  
   DWORD* pdwType  
);  
```  
  
```csharp  
int GetPrimitiveType (  
   out uint pdwType  
);  
```  
  
#### Parameters  
 `pdwType`  
 [out] Value from the [CorElementType Enumeration](/dotnet/framework/unmanaged-api/metadata/corelementtype-enumeration) that represents the primitive type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE`.  
  
## See Also  
 [IDebugPrimitiveTypeField](../../../extensibility/debugger/reference/idebugprimitivetypefield.md)
