---
title: "IEEDataStorage::GetSize | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IEEDataStorage::GetSize"
helpviewer_keywords: 
  - "IEEDataStorage::GetSize"
ms.assetid: 33d232c4-1239-4abc-922b-e1bc5b908169
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IEEDataStorage::GetSize
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Returns the number of bytes contained in this object.  
  
## Syntax  
  
```cpp#  
HRESULT GetSize(  
   ULONG* size  
);  
```  
  
```csharp  
int GetSize(  
   out uint size  
);  
```  
  
#### Parameters  
 `size`  
 [out] The number of bytes contained in this object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Use the [GetData](../../../extensibility/debugger/reference/ieedatastorage-getdata.md) method to retrieve the actual data bytes.  
  
## See Also  
 [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)   
 [GetData](../../../extensibility/debugger/reference/ieedatastorage-getdata.md)
