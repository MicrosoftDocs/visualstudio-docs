---
title: "IDebugProcess3::GetENCAvailableState | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcess3::GetENCAvailableState"
helpviewer_keywords: 
  - "IDebugProcess3::GetENCAvailableState"
ms.assetid: 98a5d527-8a72-476c-8e92-0bff3d97c195
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess3::GetENCAvailableState
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets the current Edit and Continue state of the process. A custom port supplier should always return `E_NOTIMPL`.  
  
## Syntax  
  
```cpp  
HRESULT GetENCAvailableState(  
   EncUnavailableReason* pReason  
);  
```  
  
```csharp  
int GetENCAvailableState(  
   EncUnavailableReason[] pReason  
);  
```  
  
#### Parameters  
 `pReason`  
 [out] A value from the [EncUnavailableReason](../../../extensibility/debugger/reference/encunavailablereason.md) enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
> [!NOTE]
> A custom port supplier should always return `E_NOTIMPL`.  
  
## Remarks  
 This state can be affected by [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md).  
  
## See Also  
 [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)   
 [DisableENC](../../../extensibility/debugger/reference/idebugprocess3-disableenc.md)   
 [EncUnavailableReason](../../../extensibility/debugger/reference/encunavailablereason.md)
