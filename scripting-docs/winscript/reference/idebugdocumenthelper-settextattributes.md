---
title: "IDebugDocumentHelper::SetTextAttributes | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.SetTextAttributes"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::SetTextAttributes"
ms.assetid: 31657738-9e4c-436a-be61-23f4185d452e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::SetTextAttributes
Sets the attributes on a range of text, overriding other attributes on that text.  
  
## Syntax  
  
```cpp
HRESULT SetTextAttributes(  
   ULONG              ulCharOffset,  
   ULONG              cChars,  
   SOURCE_TEXT_ATTR*  pstaTextAttr  
);  
```  
  
#### Parameters  
 `ulCharOffset`  
 [in] The location of the start of the text range.  
  
 `cChars`  
 [in] The number of characters in the range.  
  
 `pstaTextAttr`  
 [in] The source text attributes for the range of text.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 It is an error to call `SetTextAttributes` on a text range before that text is added to the document. Call the `AddDBCSText`, `AddUnicodeText`, or `AddDeferredText` methods to add text to the document.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)   
 [IDebugDocumentHelper::AddUnicodeText](../../winscript/reference/idebugdocumenthelper-addunicodetext.md)   
 [IDebugDocumentHelper::AddDBCSText](../../winscript/reference/idebugdocumenthelper-adddbcstext.md)   
 [IDebugDocumentHelper::AddDeferredText](../../winscript/reference/idebugdocumenthelper-adddeferredtext.md)   
 [SOURCE_TEXT_ATTR Enumeration](../../winscript/reference/source-text-attr-enumeration.md)