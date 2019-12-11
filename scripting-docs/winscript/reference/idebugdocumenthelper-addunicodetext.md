---
title: "IDebugDocumentHelper::AddUnicodeText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.AddUnicodeText"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::AddUnicodeText"
ms.assetid: f4ef648e-c55d-4ef0-8df3-e808b798d3b8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::AddUnicodeText
Appends a Unicode string to the end of this document.  
  
## Syntax  
  
```cpp
HRESULT AddUnicodeText(  
   LPCOLESTR  pszText  
);  
```  
  
#### Parameters  
 `pszText`  
 [in] Pointer to a null-terminated string containing the text.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|The method was unable to add the characters.|  
  
## Remarks  
 This method generates `IDebugDocumentTextEvents` notifications.  
  
> [!NOTE]
> If this method is called after `AddDeferredText` has been called, `E_FAIL` is returned.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)   
 [IDebugDocumentHelper::AddDeferredText](../../winscript/reference/idebugdocumenthelper-adddeferredtext.md)   
 [IDebugDocumentTextEvents Interface](../../winscript/reference/idebugdocumenttextevents-interface.md)