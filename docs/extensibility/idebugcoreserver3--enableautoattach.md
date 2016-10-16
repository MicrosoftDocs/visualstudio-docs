---
title: "IDebugCoreServer3::EnableAutoAttach"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugCoreServer3::EnableAutoAttach"
helpviewer_keywords: 
  - "IDebugCoreServer3::EnableAutoAttach"
ms.assetid: 06aa633b-263b-4e08-8844-9a52d5120b94
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugCoreServer3::EnableAutoAttach
Enables automatic attaching for the specified debug engines.  
  
## Syntax  
  
```cpp#  
HRESULT EnableAutoAttach(  
   GUID*     rgguidSpecificEngines,  
   DWORD     celtSpecificEngines,  
   LPCOLESTR pszStartPageUrl,  
   BSTR*     pbstrSessionId  
);  
```  
  
```c#  
int EnableAutoAttach(  
   Guid[]     rgguidSpecificEngines,  
   uint       celtSpecificEngines,  
   string     pszStartPageUrl,  
   out string pbstrSessionId  
);  
```  
  
#### Parameters  
 `rgguidSpecificEngines`  
 [in] Array of GUIDs for each debug engine to mark as auto-attaching.  
  
 `celtSpecificEngines`  
 [in] The number of engines specified in `rgguidSpecificEngines`.  
  
 `pszStartPageUrl`  
 [in] The starting URL to use when auto-attaching.  
  
 `pbstrSessionID`  
 [out] ID of the session that was auto-attached.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code. One error code is `E_AUTO_ATTACH_NOT_REGISTERED`, which indicates that the auto-attach class factory has not been registered.  
  
## Remarks  
 When a program associated with the specified URL is started, the specified debug engines are automatically started and attached.  
  
## See Also  
 [IDebugCoreServer3](../extensibility/idebugcoreserver3.md)