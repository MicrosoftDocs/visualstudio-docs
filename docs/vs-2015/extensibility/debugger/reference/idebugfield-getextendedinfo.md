---
title: "IDebugField::GetExtendedInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugField::GetExtendedInfo"
helpviewer_keywords: 
  - "IDebugField::GetExtendedInfo method"
ms.assetid: 46c0dd4d-4fd5-4efd-a908-71e4248e8e8d
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# IDebugField::GetExtendedInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets extended information about a field.  
  
## Syntax  
  
```cpp#  
HRESULT GetExtendedInfo(   
   REFGUID guidExtendedInfo,  
   BYTE**  prgBuffer,  
   DWORD*  pdwLen  
);  
```  
  
```csharp  
int GetExtendedInfo(  
   ref Guid guidExtendedInfo,   
   IntPtr[] prgBuffer,   
   ref uint pdwLen  
);  
```  
  
#### Parameters  
 `guidExtendedInfo`  
 [in] Selects the information to be returned. Valid values are:  
  
|Value|Description|  
|-----------|-----------------|  
|`guidConstantValue`|The value as a sequence of bytes.|  
|`guidConstantType`|The type as a type signature.|  
  
 `prgBuffer`  
 [out] Returns the extended information.  
  
 `pdwLen`  
 [in, out] Returns the size of the extended information, in bytes.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Currently, this method returns only the type or value of a constant. The caller must free the buffer returned in `prgBuffer` by calling COM's `CoTaskMemFree` function (C++) or <xref:System.Runtime.InteropServices.Marshal.FreeCoTaskMem%2A> (C#).  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
