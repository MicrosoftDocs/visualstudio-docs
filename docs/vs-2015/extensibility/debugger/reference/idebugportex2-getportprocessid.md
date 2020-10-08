---
title: "IDebugPortEx2::GetPortProcessId | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPortEx2::GetPortProcessId"
helpviewer_keywords: 
  - "IDebugPortEx2::GetPortProcessId"
ms.assetid: be85be66-47e6-415f-b0ca-24599aa5f13c
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugPortEx2::GetPortProcessId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the process ID of the port itself.  
  
## Syntax  
  
```cpp#  
HRESULT GetPortProcessId (   
   DWORD* pdwProcessId  
);  
```  
  
```csharp  
int GetPortProcessId (   
   out uint pdwProcessId  
);  
```  
  
#### Parameters  
 `pdwProcessId`  
 [out] Returns the physical process ID of the port itself.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 In the Win32 runtime for example, this method typically calls the Win32 function `GetCurrentProcessId` to get the physical process ID.  
  
## See Also  
 [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
