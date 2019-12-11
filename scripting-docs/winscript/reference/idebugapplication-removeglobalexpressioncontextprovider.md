---
title: "IDebugApplication::RemoveGlobalExpressionContextProvider | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.RemoveGlobalExpressionContextProvider"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::RemoveGlobalExpressionContextProvider"
ms.assetid: ace638a3-ed34-4d20-8404-45c684aaaf1a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::RemoveGlobalExpressionContextProvider
Removes a global expression context provider from this application.  
  
## Syntax  
  
```cpp
HRESULT RemoveGlobalExpressionContextProvider(  
   DWORD_PTR  dwCookie  
);  
```  
  
#### Parameters  
 `dwCookie`  
 [in] The cookie returned by the `AddGlobalExpressionContextProvider` method when the global context provider was added.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The `RemoveGlobalExpressionContextProvider` method removes a global expression context provider from this application.  
  
## See also  
 [IDebugApplication::AddGlobalExpressionContextProvider](../../winscript/reference/idebugapplication-addglobalexpressioncontextprovider.md)   
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)