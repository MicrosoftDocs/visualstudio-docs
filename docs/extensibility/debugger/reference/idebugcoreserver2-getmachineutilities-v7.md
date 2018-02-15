---
title: "IDebugCoreServer2::GetMachineUtilities_V7 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCoreServer2::GetMachineUtilities_V7"
helpviewer_keywords: 
  - "IDebugCoreServer2::GetMachineUtilities_V7"
ms.assetid: 64c1f08f-853b-4498-9810-29791581ef2f
caps.latest.revision: 17
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugCoreServer2::GetMachineUtilities_V7
This method gets the machine utilities for a server.  
  
> [!NOTE]
>  This method is obsolete: do not use ([!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] always returns `E_NOTIMPL` if this method is called). It is retained for historical reasons.  
  
## Syntax  
  
```cpp  
HRESULT GetMachineUtilities_V7(  
   IDebugMDMUtil2_V7** ppUtil  
);  
```  
  
```csharp  
int GetMachineUtilities_V7(  
   out IDebugMDMUtil2_V7 ppUtil  
);  
```  
  
#### Parameters  
 `ppUtil`  
 [out] Returns an `IDebugMDMUtil2_V7` interface that represents the machine utilities information.  
  
## Return Value  
 Always returns `E_NOTIMPL`, indicating that the method is not implemented.  
  
## Remarks  
 [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] always returns `E_NOTIMPL` if this method is called.  
  
## See Also  
 [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)