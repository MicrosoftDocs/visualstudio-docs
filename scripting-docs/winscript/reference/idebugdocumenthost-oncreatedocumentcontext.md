---
title: "IDebugDocumentHost::OnCreateDocumentContext | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHost.OnCreateDocumentContext"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentHost::OnCreateDocumentContext"
ms.assetid: 080c8604-cfd7-484e-a337-15040870e683
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHost::OnCreateDocumentContext
Notifies the host that a new document context is being created and allows the host to optionally return a controlling unknown for the new context.  
  
## Syntax  
  
```cpp
HRESULT OnCreateDocumentContext(  
   IUnknown**  ppunkOuter  
);  
```  
  
#### Parameters  
 `ppunkOuter`  
 [out] An object that controls the new context.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_NOTIMPL`|The host does not provide a controlling object.|  
  
## Remarks  
 This method allows the host to add new functionality to the helper-provided document contexts. This method may return **E_NOTIMPL** or a null outer object, in which case the caller is responsible for creating the context.  
  
## See also  
 [IDebugDocumentHost Interface](../../winscript/reference/idebugdocumenthost-interface.md)