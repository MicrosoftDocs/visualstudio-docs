---
title: "IDebugPortSupplier2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugPortSupplier2"
helpviewer_keywords: 
  - "IDebugPortSupplier2 interface"
ms.assetid: 37067324-2ea6-4a01-8829-a6e9c7a70068
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugPortSupplier2
This interface supplies ports to the session debug manager (SDM).  
  
## Syntax  
  
```  
IDebugPortSupplier2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to represent a port supplier.  
  
## Notes for Callers  
 A call to `CoCreateInstance` with a port supplier's `GUID` returns this interface (this is the typical way to obtain this interface). For example:  
  
```cpp#  
IDebugPortSupplier2 *GetPortSupplier(GUID *pPortSupplierGuid)  
{  
    IDebugPortSupplier2 *pPS = NULL;  
    if (pPortSupplierGuid != NULL) {  
        CComPtr<IDebugPortSupplier2> spPortSupplier;  
        spPortSupplier.CoCreateInstance(*pPortSupplierGuid);  
        if (spPortSupplier != NULL) {  
            pPS = spPortSupplier.Detach();  
        }  
    }  
    return (pPS);  
}  
```  
  
 A call to [GetPortSupplier](../extensibility/idebugcoreserver2--getportsupplier.md) returns this interface, representing the current port supplier being used by [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)].  
  
 [GetPortSupplier](../extensibility/idebugport2--getportsupplier.md) returns this interface, representing the port supplier that created the port.  
  
 [IEnumDebugPortSuppliers2](../extensibility/ienumdebugportsuppliers2.md) represents a list of `IDebugPortSupplier` interfaces (the `IEnumDebugPortSuppliers` interface is obtained from [EnumPortSuppliers](../extensibility/idebugcoreserver2--enumportsuppliers.md), representing all of the port suppliers registered with [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]).  
  
 A debug engine typically does not interact with a port supplier.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPortSupplier2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPortSupplierName](../extensibility/idebugportsupplier2--getportsuppliername.md)|Gets the port supplier name.|  
|[GetPortSupplierId](../extensibility/idebugportsupplier2--getportsupplierid.md)|Gets the port supplier identifier.|  
|[GetPort](../extensibility/idebugportsupplier2--getport.md)|Gets a port from a port supplier.|  
|[EnumPorts](../extensibility/idebugportsupplier2--enumports.md)|Enumerates the ports that already exist.|  
|[CanAddPort](../extensibility/idebugportsupplier2--canaddport.md)|Verifies that a port supplier supports adding new ports.|  
|[AddPort](../extensibility/idebugportsupplier2--addport.md)|Adds a port.|  
|[RemovePort](../extensibility/idebugportsupplier2--removeport.md)|Removes a port.|  
  
## Remarks  
 A port supplier can identify itself by name and ID, add and remove ports, and enumerate all ports that the port supplier provides.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [GetPortSupplier](../extensibility/idebugport2--getportsupplier.md)   
 [GetPortSupplier](../extensibility/idebugcoreserver2--getportsupplier.md)   
 [IEnumDebugPortSuppliers2](../extensibility/ienumdebugportsuppliers2.md)