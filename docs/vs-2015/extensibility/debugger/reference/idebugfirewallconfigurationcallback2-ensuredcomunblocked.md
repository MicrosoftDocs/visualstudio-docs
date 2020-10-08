---
title: "IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "EnsureDCOMUnblocked"
  - "IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked"
ms.assetid: acf54d27-32a6-47e7-aba6-3cc0004edc7f
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IDebugFirewallConfigurationCallback2::EnsureDCOMUnblocked
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Requests that the firewall not block remote debugging.  
  
## Syntax  
  
```cpp#  
HRESULT EnsureDCOMUnblocked(   
    Void  
);  
```  
  
```csharp  
public int EnsureDCOMUnblocked();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugFirewallConfigurationCallback2](../../../extensibility/debugger/reference/idebugfirewallconfigurationcallback2.md)
