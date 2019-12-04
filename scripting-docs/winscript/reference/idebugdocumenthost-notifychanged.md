---
title: "IDebugDocumentHost::NotifyChanged | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHost.NotifyChanged"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentHost::NotifyChanged"
ms.assetid: 33a4a54f-3bcb-4422-b3c0-bdbf46590f34
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHost::NotifyChanged
Notifies the host that the document's source file has been saved and that its contents should be refreshed.  
  
## Syntax  
  
```cpp
HRESULT NotifyChanged();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method notifies the host that the document's source file has been saved and that its contents should be refreshed.  
  
## See also  
 [IDebugDocumentHost Interface](../../winscript/reference/idebugdocumenthost-interface.md)