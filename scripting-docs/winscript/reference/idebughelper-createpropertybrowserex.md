---
title: "IDebugHelper::CreatePropertyBrowserEx | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugHelper.CreatePropertyBrowserEx"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugHelper::CreatePropertyBrowserEx"
ms.assetid: 87ad322f-09da-4ce8-bb68-0b0bbeec645b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugHelper::CreatePropertyBrowserEx
Returns a property browser that wraps a VARIANT and allows for custom conversion of VARIANT values or VARTYPE types to strings.  
  
## Syntax  
  
```cpp
HRESULT CreatePropertyBrowserEx(  
   VARIANT*                  pvar,  
   LPCOLESTR                 bstrName,  
   IDebugApplicationThread*  pdat,  
   IDebugFormatter*          pdf,  
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
  
 `pdf`  
 [in] Object that provides custom formatting for variants.  
  
 `ppdob`  
 [out] The property browser.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns a property browser that wraps a VARIANT and allows for custom conversion of VARIANT values or VARTYPE types to strings.  
  
## See also  
 [IDebugHelper::CreatePropertyBrowser](../../winscript/reference/idebughelper-createpropertybrowser.md)   
 [IDebugHelper Interface](../../winscript/reference/idebughelper-interface.md)   
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)