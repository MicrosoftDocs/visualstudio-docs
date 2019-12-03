---
title: "IDebugExpressionContext::GetLanguageInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpressionContext.GetLanguageInfo"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpressionContext::GetLanguageInfo"
ms.assetid: 35e25662-0b2a-4c3f-bce4-f01726bc04a8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpressionContext::GetLanguageInfo
Returns a name and GUID for the language that owns this context.  
  
## Syntax  
  
```cpp
HRESULT GetLanguageInfo(  
   BSTR*  pbstrLanguageName,  
   GUID*  pLanguageID  
);  
```  
  
#### Parameters  
 `pbstrLanguageName`  
 [out] The name of the language.  
  
 `pLanguageID`  
 [out] The unique id for the language.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns a name and GUID for the language that owns this context.  
  
## See also  
 [IDebugExpressionContext Interface](../../winscript/reference/idebugexpressioncontext-interface.md)