---
title: "IDebugProcess3::GetHostingProcessLanguage"
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
  - "IDebugProcess3::GetHostingProcessLanguage"
helpviewer_keywords: 
  - "IDebugProcess3::GetHostingProcessLanguage"
ms.assetid: 52fca002-a9ef-43b1-9192-afbe7bb59ad4
caps.latest.revision: 10
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
# IDebugProcess3::GetHostingProcessLanguage
This method returns a `GUID` representing the language of this process as set by a call to [SetHostingProcessLanguage](../extensibility/idebugprocess3--sethostingprocesslanguage.md).  
  
## Syntax  
  
```cpp  
HRESULT GetHostingProcessLanguage(  
   GUID* pguidLang  
);  
```  
  
```c#  
int GetHostingProcessLanguage(  
   out Guid pguidLang  
);  
```  
  
#### Parameters  
 `pguidLang`  
 [out] The `GUID` of the language of this process. `GUID_NULL` (C++) or `Guid.Empty` (C#) means that the language is not set.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDebugProcess3](../extensibility/idebugprocess3.md)   
 [SetHostingProcessLanguage](../extensibility/idebugprocess3--sethostingprocesslanguage.md)