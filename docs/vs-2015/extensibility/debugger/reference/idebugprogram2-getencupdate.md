---
title: "IDebugProgram2::GetENCUpdate | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgram2::GetENCUpdate"
helpviewer_keywords: 
  - "IDebugProgram2::GetENCUpdate"
ms.assetid: 9832aac8-6320-4fd8-91dd-2a0852febb00
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# IDebugProgram2::GetENCUpdate
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets the Edit and Continue (ENC) update for this program. A custom debug engine always returns `E_NOTIMPL`.  
  
## Syntax  
  
```cpp#  
HRESULT GetENCUpdate(   
   IUnknown** ppUpdate  
);  
```  
  
```csharp  
int GetENCUpdate(  
   out object ppUpdate  
);  
```  
  
#### Parameters  
 `ppUpdate`  
 [out] Returns an internal interface that can be used to update this program.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
> [!NOTE]
> A custom debug engine should always return `E_NOTIMPL`.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
