---
title: "IDebugProcess2::GetName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcess2::GetName"
helpviewer_keywords: 
  - "IDebugProcess2::GetName"
ms.assetid: a2f66ab5-53e5-4cdc-a1b5-3b8afa8ee646
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess2::GetName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the title, friendly name, or file name of the process.  
  
## Syntax  
  
```cpp#  
HRESULT GetName(   
   GETNAME_TYPE  gnType,  
   BSTR*         pbstrName  
);  
```  
  
```csharp  
int GetName(   
   enum_GETNAME_TYPE  gnType,  
   out string         pbstrName  
);  
```  
  
#### Parameters  
 `gnType`  
 [in] A value from the [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md) enumeration that specifies what type of name to return.  
  
 `pbstrName`  
 [out] Returns the name of the process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md)
