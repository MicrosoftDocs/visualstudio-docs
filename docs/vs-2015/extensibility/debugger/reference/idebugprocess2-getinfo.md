---
title: "IDebugProcess2::GetInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcess2::GetInfo"
helpviewer_keywords: 
  - "IDebugProcess2::GetInfo"
ms.assetid: 46021dce-bb97-46c3-b0cc-e5b3b68acc35
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess2::GetInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets a description of the process.  
  
## Syntax  
  
```cpp#  
HRESULT GetInfo(  
   PROCESS_INFO_FIELDS  Fields,  
   PROCESS_INFO*        pProcessInfo  
);  
```  
  
```csharp  
int GetInfo(  
   enum_PROCESS_INFO_FIELDS  Fields,  
   PROCESS_INFO[]            pProcessInfo  
);  
```  
  
#### Parameters  
 `Fields`  
 [in] A combination of values from the [PROCESS_INFO_FIELDS](../../../extensibility/debugger/reference/process-info-fields.md) enumeration that specifies which fields of the `pProcessInfo` parameter are to be filled in.  
  
 `pProcessInfo`  
 [out] A [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md) structure that is filled in with a description of the process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [PROCESS_INFO_FIELDS](../../../extensibility/debugger/reference/process-info-fields.md)   
 [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md)
