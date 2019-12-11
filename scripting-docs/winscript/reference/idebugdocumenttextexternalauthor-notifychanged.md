---
title: "IDebugDocumentTextExternalAuthor::NotifyChanged | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentTextExternalAuthor.NotifyChanged"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentTextExternalAuthor::NotifyChanged"
ms.assetid: f0de7984-3a15-49e2-bd29-f768f34d2a4d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentTextExternalAuthor::NotifyChanged
Notifies the host that the document source has changed.  
  
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
 This method is called by an external editor after a file-based debugger document is modified and saved to notify the host that the document source has changed. The host then refreshes the document from the source file.  
  
## See also  
 [IDebugDocumentTextExternalAuthor Interface](../../winscript/reference/idebugdocumenttextexternalauthor-interface.md)