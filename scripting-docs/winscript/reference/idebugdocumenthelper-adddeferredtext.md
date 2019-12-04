---
title: "IDebugDocumentHelper::AddDeferredText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.AddDeferredText"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::AddDeferredText"
ms.assetid: 9463cfb0-76cc-45ee-b32c-f37dce2b2e0e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::AddDeferredText
Notifies the helper that the given text is available, but it does not provide the characters.  
  
## Syntax  
  
```cpp
HRESULT AddDeferredText(  
   ULONG  cChars,  
   DWORD  dwTextStartCookie  
);  
```  
  
#### Parameters  
 `cChars`  
 [in] Number of (Unicode) characters to add.  
  
 `dwTextStartCookie`  
 [in] Host-defined cookie that represents the starting position of the text.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|The method failed.|  
  
## Remarks  
 This method allows the host to defer providing the characters to add until they are needed, while allowing the helper to generate accurate notifications and size information. The `dwTextStartCookie` parameter is a cookie, defined by the host, which represents the starting position of the text. Subsequent calls to `IDebugDocumentText::GetText` must provide this cookie. For example, in a host that represents text in DBCS, the cookie could be a byte offset.  
  
 It is assumed that a single call to `IDebugDocumentText::GetText` can get characters from multiple calls to `AddDeferredText`. Helper classes may also ask for the same range of deferred characters more than once.  
  
> [!NOTE]
> Calls to `AddDeferredText` should not be mixed with calls to `AddUnicodeText` or `AddDBCSText`. If this occurs, `E_FAIL` is returned.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)   
 [IDebugDocumentHelper::AddUnicodeText](../../winscript/reference/idebugdocumenthelper-addunicodetext.md)   
 [IDebugDocumentHelper::AddDBCSText](../../winscript/reference/idebugdocumenthelper-adddbcstext.md)   
 [IDebugDocumentText::GetText](../../winscript/reference/idebugdocumenttext-gettext.md)