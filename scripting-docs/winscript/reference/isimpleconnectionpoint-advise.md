---
title: "ISimpleConnectionPoint::Advise | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ISimpleConnectionPoint.Advise"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "ISimpleConnectionPoint::Advise"
ms.assetid: 59ded60d-b938-4110-aca3-e69ba234ca9a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISimpleConnectionPoint::Advise
Establishes a connection between the simple connection point object and the client's sink.  
  
## Syntax  
  
```cpp
HRESULT Advise(  
   IDispatch*  pdisp,  
   DWORD*      pdwCookie  
);  
```  
  
#### Parameters  
 `pdisp`  
 [in] Pointer to the `IDispatch` interface on the client's advise sink. The client's sink receives outgoing calls from the simple connection point.  
  
 `pdwCookie`  
 [out] Pointer to a returned token that uniquely identifies this connection. The caller uses this token later to delete the connection by passing it to the `ISimpleConnectionPoint::Unadvise` method. If the connection was not successfully established, this value is zero.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method establishes a connection between the simple connection point object and the client's sink.  
  
## See also  
 [ISimpleConnectionPoint Interface](../../winscript/reference/isimpleconnectionpoint-interface.md)   
 [ISimpleConnectionPoint::Unadvise](../../winscript/reference/isimpleconnectionpoint-unadvise.md)