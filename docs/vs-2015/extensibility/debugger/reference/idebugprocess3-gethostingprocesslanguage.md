---
title: "IDebugProcess3::GetHostingProcessLanguage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcess3::GetHostingProcessLanguage"
helpviewer_keywords: 
  - "IDebugProcess3::GetHostingProcessLanguage"
ms.assetid: 52fca002-a9ef-43b1-9192-afbe7bb59ad4
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess3::GetHostingProcessLanguage
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method returns a `GUID` representing the language of this process as set by a call to [SetHostingProcessLanguage](../../../extensibility/debugger/reference/idebugprocess3-sethostingprocesslanguage.md).  
  
## Syntax  
  
```cpp  
HRESULT GetHostingProcessLanguage(  
   GUID* pguidLang  
);  
```  
  
```csharp  
int GetHostingProcessLanguage(  
   out Guid pguidLang  
);  
```  
  
#### Parameters  
 `pguidLang`  
 [out] The `GUID` of the language of this process. `GUID_NULL` (C++) or `Guid.Empty` (C#) means that the language is not set.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See also  
 [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)   
 [SetHostingProcessLanguage](../../../extensibility/debugger/reference/idebugprocess3-sethostingprocesslanguage.md)
