---
title: "IEnumDebugAddresses::Reset | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugAddresses::Reset"
helpviewer_keywords: 
  - "IEnumDebugAddresses::Reset method"
ms.assetid: 3a9d7f20-5bc6-4e13-8e91-5af4092e092f
caps.latest.revision: 6
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugAddresses::Reset
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugAddresses::Reset](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugaddresses-reset).  
  
This method resets the enumeration to the first element.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(void);  
```  
  
```csharp  
int Reset();  
```  
  
#### Parameters  
 None  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to [Next](../../../extensibility/debugger/reference/ienumdebugaddresses-next.md) returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)   
 [Next](../../../extensibility/debugger/reference/ienumdebugaddresses-next.md)

