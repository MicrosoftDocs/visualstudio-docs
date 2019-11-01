---
title: "IDebugHelper::CreatePropertyBrowser | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugHelper.CreatePropertyBrowser"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugHelper::CreatePropertyBrowser"
ms.assetid: 2fa819cf-c7f7-4bd7-b018-ea33b804ba8f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugHelper::CreatePropertyBrowser
Returns a property browser that wraps a VARIANT.  
  
## Syntax  
  
```cpp
HRESULT CreatePropertyBrowser(  
   VARIANT*                  pvar,  
   LPCOLESTR                 bstrName,  
   IDebugApplicationThread*  pdat,  
   IDebugProperty**          ppdob  
);  
```  
  
#### Parameters  
 `pvar`  
 [in] Root variant to browse.  
  
 `bstrName`  
 [in] Name to give the root.  
  
 `pdat`  
 [in] Thread on which to request properties. If this parameter is NULL, no marshalling is performed.  
  
 `ppdob`  
 [out] The property browser.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns a property browser that wraps a VARIANT.  
  
## See also  
 [IDebugHelper::CreatePropertyBrowserEx](../../winscript/reference/idebughelper-createpropertybrowserex.md)   
 [IDebugHelper Interface](../../winscript/reference/idebughelper-interface.md)   
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)