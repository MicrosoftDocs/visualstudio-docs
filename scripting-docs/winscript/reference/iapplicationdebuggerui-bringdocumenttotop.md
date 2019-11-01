---
title: "IApplicationDebuggerUI::BringDocumentToTop | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IApplicationDebuggerUI.BringDocumentToTop"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IApplicationDebuggerUI::BringDocumentToTop"
ms.assetid: ef5fe1e7-4381-4409-a0d7-58f993abe84e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IApplicationDebuggerUI::BringDocumentToTop
Brings the window containing the specified debug document to the top in the debugger user interface.  
  
## Syntax  
  
```cpp
HRESULT BringDocumentToTop(  
   IDebugDocumentText*  pddt  
);  
```  
  
#### Parameters  
 `pddt`  
 [in] Debug document to bring to the top in the debugger user interface.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_INVALIDARG`|The document is not known.|  
  
## Remarks  
 This method brings the window containing the specified debug document to the top in the debugger user interface.  
  
## See also  
 [IApplicationDebuggerUI Interface](../../winscript/reference/iapplicationdebuggerui-interface.md)