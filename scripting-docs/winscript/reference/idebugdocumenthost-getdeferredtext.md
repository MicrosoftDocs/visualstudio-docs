---
title: "IDebugDocumentHost::GetDeferredText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHost.GetDeferredText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugDocumentHost::GetDeferredText"
ms.assetid: 527da666-fef5-4db3-a319-e68d466a7721
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHost::GetDeferredText
Returns a range of characters that were added by using the `IDebugDocumentHelper::AddDeferredText` method, in the original host document.  
  
## Syntax  
  
```cpp
HRESULT GetDeferredText(  
   DWORD              dwTextStartCookie,  
   WCHAR*             pcharText,  
   SOURCE_TEXT_ATTR*  pstaTextAttr,  
   ULONG*             pcNumChars,  
   ULONG              cMaxChars  
);  
```  
  
#### Parameters  
 `dwTextStartCookie`  
 [in] Host-defined cookie that represents the starting position of the text.  
  
 `pcharText`  
 [in, out] A character text buffer. This method does not return characters if this parameter is `NULL`.  
  
 `pstaTextAttr`  
 [in, out] A character attribute buffer. This method does not return attributes if this parameter is `NULL`.  
  
 `pcNumChars`  
 [in, out] Indicates the actual number of characters/attributes returned. This parameter must be set to zero before calling this method.  
  
 `cMaxChars`  
 [in] The maximum number of characters to return.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_NOTIMPL`|The method is not implemented.|  
  
## Remarks  
 This method may return `E_NOTIMPL`, if the host does not call `IDebugDocumentHelper::AddDeferredText`.  
  
> [!NOTE]
> This method returns the text from the original document. The host does not keep track of edits or other changes to the document.  
  
## See also  
 [IDebugDocumentHost Interface](../../winscript/reference/idebugdocumenthost-interface.md)   
 [IDebugDocumentHelper::AddDeferredText](../../winscript/reference/idebugdocumenthelper-adddeferredtext.md)   
 [SOURCE_TEXT_ATTR Enumeration](../../winscript/reference/source-text-attr-enumeration.md)