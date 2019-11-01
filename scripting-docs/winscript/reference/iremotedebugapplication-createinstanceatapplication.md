---
title: "IRemoteDebugApplication::CreateInstanceAtApplication | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplication.CreateInstanceAtApplication"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplication::CreateInstanceAtApplication"
ms.assetid: d669ec80-2182-400d-87cc-7c1753315e5c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication::CreateInstanceAtApplication
Allows the creation of objects in the application process by code that is out-of-process to the application.  
  
## Syntax  
  
```cpp
HRESULT CreateInstanceAtApplication(  
   REFCLSID    rclsid,  
   IUnknown*   pUnkOuter,  
   DWORD       dwClsContext,  
   REFIID      riid,  
   IUnknown**  ppvObject  
);  
```  
  
#### Parameters  
 `rclsid`  
 [in] Class identifier (CLSID) of the object to create.  
  
 `pUnkOuter`  
 [in] If `NULL`, the object is not being created as part of an aggregate. Otherwise, `pUnkOuter` is a pointer to the aggregate object's `IUnknown` interface (the controlling `IUnknown`).  
  
 `dwClsContext`  
 [in] Context for running executable code. The values are taken from the enumeration `CLSCTX`.  
  
 `riid`  
 [in] The interface identifier used to communicate with the object.  
  
 `ppvObject`  
 [out] Address of pointer variable that receives the interface pointer requested in `riid`. Upon successful return, *`ppvObject` contains the requested interface pointer. Upon failure, \*`ppvObject` contains `NULL`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method delegates to `CoCreateInstance`.  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)