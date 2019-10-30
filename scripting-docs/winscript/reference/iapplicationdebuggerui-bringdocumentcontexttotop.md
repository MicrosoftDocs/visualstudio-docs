---
title: "IApplicationDebuggerUI::BringDocumentContextToTop | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IApplicationDebuggerUI.BringDocumentContextToTop"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IApplicationDebuggerUI::BringDocumentContextToTop"
ms.assetid: 7844217d-658b-42af-8d10-2714f4eded20
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IApplicationDebuggerUI::BringDocumentContextToTop
Brings the window containing the given document context to the top in the debugger user interface and scrolls the window to the context.  
  
## Syntax  
  
```cpp
HRESULT BringDocumentContextToTop(  
   IDebugDocumentContext*  pddc  
);  
```  
  
#### Parameters  
 `pddc`  
 [in] Document context to bring to the top in the debugger user interface.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_INVALIDARG`|The context specified by `pddc` is not known.|  
  
## Remarks  
 This method brings the window containing the given document context to the top in the debugger user interface and scrolls the window to the context.  
  
## See also  
 [IApplicationDebuggerUI Interface](../../winscript/reference/iapplicationdebuggerui-interface.md)